using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Forms
{
    public partial class Issue_Books : Form
    {
        private string _libraryID;
        private string _firstName;
        private string _lastName;

        // Store available books after Check
        private List<string> availableBooks = new List<string>();

        public Issue_Books(string libraryID, string firstName, string lastName)
        {
            InitializeComponent();
            _libraryID = libraryID;
            _firstName = firstName;
            _lastName = lastName;
        }

        private void Issue_Books_Load(object sender, EventArgs e)
        {
            txtILibraryID.Text = _libraryID;
            txtIFirstName.Text = _firstName;
            txtILastName.Text = _lastName;
        }

        private void FillBookName(TextBox bookIdTextBox, TextBox bookNameTextBox)
        {
            if (string.IsNullOrWhiteSpace(bookIdTextBox.Text))
            {
                bookNameTextBox.Clear();
                return;
            }

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT BookName FROM Books WHERE BookID = @BookID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookIdTextBox.Text.Trim());
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    bookNameTextBox.Text = result?.ToString() ?? string.Empty;
                }
            }
        }

        private void txtBookID1_TextChanged(object sender, EventArgs e) => FillBookName(txtBookID1, txtBookName1);
        private void txtBookID2_TextChanged(object sender, EventArgs e) => FillBookName(txtBookID2, txtBookName2);
        private void txtBookID3_TextChanged(object sender, EventArgs e) => FillBookName(txtBookID3, txtBookName3);

        private void btnICheck_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
            List<string> bookIds = new List<string>();
            if (!string.IsNullOrWhiteSpace(txtBookID1.Text)) bookIds.Add(txtBookID1.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtBookID2.Text)) bookIds.Add(txtBookID2.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtBookID3.Text)) bookIds.Add(txtBookID3.Text.Trim());

            if (bookIds.Count == 0)
            {
                MessageBox.Show("Please enter at least one Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            availableBooks.Clear();
            List<string> unavailableBooks = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (var bookId in bookIds)
                {
                    string qtyQuery = "SELECT BookName, Quantity FROM Books WHERE BookID = @BookID";
                    using (SqlCommand cmd = new SqlCommand(qtyQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string bookName = reader["BookName"].ToString();
                                int qty = Convert.ToInt32(reader["Quantity"]);
                                if (qty > 0)
                                    availableBooks.Add(bookId);
                                else
                                    unavailableBooks.Add($"'{bookName}' (ID: {bookId}) is currently unavailable.");
                            }
                            else
                            {
                                unavailableBooks.Add($"Book ID {bookId} does not exist.");
                            }
                        }
                    }
                }

                if (unavailableBooks.Count > 0)
                {
                    MessageBox.Show(string.Join("\n", unavailableBooks), "Unavailable Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check unreturned books
                string checkQuery = @"SELECT B.BookID, B.BookName, T.DueDate
                                      FROM Transactions T
                                      INNER JOIN Books B ON T.BookID = B.BookID
                                      WHERE T.LibraryID = @LibraryID AND T.ReturnDate IS NULL";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@LibraryID", _libraryID);
                    DataTable dt = new DataTable();
                    new SqlDataAdapter(checkCmd).Fill(dt);

                    lstUnreturnedBooks.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        lstUnreturnedBooks.Items.Add($"{row["BookName"]} (ID: {row["BookID"]}) - Due: {Convert.ToDateTime(row["DueDate"]).ToShortDateString()}");
                    }
                    if (dt.Rows.Count == 0) lstUnreturnedBooks.Items.Add("No unreturned books.");

                    if (dt.Rows.Count + availableBooks.Count > 3)
                    {
                        MessageBox.Show("Member cannot issue more than 3 books per week!", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        availableBooks.Clear();
                        return;
                    }

                    dtpDueDate.Value = DateTime.Now.AddDays(7);
                    MessageBox.Show("All books are available. Due Date generated: " + dtpDueDate.Value.ToShortDateString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            if (availableBooks.Count == 0)
            {
                MessageBox.Show("No books available to issue. Please click 'Check' first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
            DateTime issueDate = DateTime.Now;
            DateTime dueDate = dtpDueDate.Value;
            string adminID = Admin_LogIn_Page.CurrentAdminID;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (var bookId in availableBooks)
                {
                    string bookName = "";
                    using (SqlCommand cmd = new SqlCommand("SELECT BookName FROM Books WHERE BookID=@BookID", con))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        bookName = cmd.ExecuteScalar()?.ToString();
                    }

                    // Generate TransactionID
                    string lastId = "000000";
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 TransactionID FROM Transactions ORDER BY CAST(TransactionID AS INT) DESC", con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null) lastId = result.ToString();
                    }

                    string transactionID = (int.Parse(lastId) + 1).ToString("D6");

                    // Insert transaction with ActionType='Issue'
                    string insertQuery = @"INSERT INTO Transactions 
                                           (TransactionID, LibraryID, BookID, BookName, AdminID, IssueDate, DueDate, Quantity, ActionType, Notes)
                                           VALUES (@TransactionID, @LibraryID, @BookID, @BookName, @AdminID, @IssueDate, @DueDate, @Quantity, 'Issue', 'Book Issued')";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                        insertCmd.Parameters.AddWithValue("@LibraryID", _libraryID);
                        insertCmd.Parameters.AddWithValue("@BookID", bookId);
                        insertCmd.Parameters.AddWithValue("@BookName", bookName);
                        insertCmd.Parameters.AddWithValue("@AdminID", adminID);
                        insertCmd.Parameters.AddWithValue("@IssueDate", issueDate);
                        insertCmd.Parameters.AddWithValue("@DueDate", dueDate);
                        insertCmd.Parameters.AddWithValue("@Quantity", -1);
                        insertCmd.ExecuteNonQuery();
                    }

                    // Update book quantity
                    using (SqlCommand updateCmd = new SqlCommand("UPDATE Books SET Quantity = Quantity - 1 WHERE BookID = @BookID", con))
                    {
                        updateCmd.Parameters.AddWithValue("@BookID", bookId);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Books issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void ClearForm()
        {
            txtBookID1.Clear(); txtBookName1.Clear();
            txtBookID2.Clear(); txtBookName2.Clear();
            txtBookID3.Clear(); txtBookName3.Clear();
            lstUnreturnedBooks.Items.Clear();
            dtpDueDate.Value = DateTime.Now;
            availableBooks.Clear();
        }

        private void btnRBLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = @"INSERT INTO MemberActions (LibraryID, FirstName, LastName, Action, AdminID, Notes)
                                         VALUES (@LibraryID, @FirstName, @LastName, @Action, @AdminID, 'Member Log Out')";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@LibraryID", _libraryID);
                            cmd.Parameters.AddWithValue("@FirstName", _firstName);
                            cmd.Parameters.AddWithValue("@LastName", _lastName);
                            cmd.Parameters.AddWithValue("@Action", "LogOut");
                            cmd.Parameters.AddWithValue("@AdminID", Admin_LogIn_Page.CurrentAdminID);
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error logging member action: " + ex.Message);
                }

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            Return_Books returnForm = new Return_Books();
            returnForm.Show();
            this.Close();
        }

        private void btnIssueBooksExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                                        "Confirm Exit",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
