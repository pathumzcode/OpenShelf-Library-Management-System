using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Forms
{
    public partial class Return_Books : Form
    {
        private string _libraryID;
        private string _firstName;
        private string _lastName;

        public Return_Books()
        {
            InitializeComponent();

            // Load member session info automatically
            _libraryID = Member_LogIn_Page.Session.CurrentLibraryID;
            _firstName = Member_LogIn_Page.Session.CurrentFirstName;
            _lastName = Member_LogIn_Page.Session.CurrentLastName;
        }

        private void Return_Books_Load(object sender, EventArgs e)
        {
            // Auto-fill logged-in member details
            txtRLibraryID.Text = _libraryID;
            txtRFirstName.Text = _firstName;
            txtRLastName.Text = _lastName;
        }

        // Fill book name automatically
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
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", bookIdTextBox.Text.Trim());
                con.Open();
                object result = cmd.ExecuteScalar();
                bookNameTextBox.Text = result?.ToString() ?? string.Empty;
            }
        }

        private void txtBookID1_TextChanged(object sender, EventArgs e) => FillBookName(txtBookID1, txtBookName1);
        private void txtBookID2_TextChanged(object sender, EventArgs e) => FillBookName(txtBookID2, txtBookName2);
        private void txtBookID3_TextChanged(object sender, EventArgs e) => FillBookName(txtBookID3, txtBookName3);


        // Return selected books
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            // Collect Book IDs from textboxes
            List<string> bookIdsToReturn = new List<string>();
            if (!string.IsNullOrWhiteSpace(txtBookID1.Text)) bookIdsToReturn.Add(txtBookID1.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtBookID2.Text)) bookIdsToReturn.Add(txtBookID2.Text.Trim());
            if (!string.IsNullOrWhiteSpace(txtBookID3.Text)) bookIdsToReturn.Add(txtBookID3.Text.Trim());

            if (bookIdsToReturn.Count == 0)
            {
                MessageBox.Show("Please enter at least one Book ID in the text boxes to return.", "No Books", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
            string libraryId = txtRLibraryID.Text.Trim();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (string bookID in bookIdsToReturn)
                {
                    // Get Book Name
                    string bookNameQuery = "SELECT BookName FROM Books WHERE BookID = @BookID";
                    SqlCommand bookNameCmd = new SqlCommand(bookNameQuery, con);
                    bookNameCmd.Parameters.AddWithValue("@BookID", bookID);
                    string bookName = bookNameCmd.ExecuteScalar()?.ToString() ?? "Unknown";

                    // Get last due date
                    string dueDateQuery = "SELECT TOP 1 DueDate FROM Transactions WHERE LibraryID=@LibraryID AND BookID=@BookID AND ReturnDate IS NULL ORDER BY IssueDate DESC";
                    SqlCommand dueDateCmd = new SqlCommand(dueDateQuery, con);
                    dueDateCmd.Parameters.AddWithValue("@LibraryID", libraryId);
                    dueDateCmd.Parameters.AddWithValue("@BookID", bookID);
                    object dueDateObj = dueDateCmd.ExecuteScalar();
                    DateTime? dueDate = dueDateObj != null ? Convert.ToDateTime(dueDateObj) : (DateTime?)null;

                    // Step 1: Update old transaction
                    string updateTransaction = @"UPDATE Transactions
                                         SET ReturnDate=@ReturnDate, ActionType='Return'
                                         WHERE LibraryID=@LibraryID AND BookID=@BookID AND ReturnDate IS NULL";
                    SqlCommand updateTransCmd = new SqlCommand(updateTransaction, con);
                    updateTransCmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now);
                    updateTransCmd.Parameters.AddWithValue("@LibraryID", libraryId);
                    updateTransCmd.Parameters.AddWithValue("@BookID", bookID);
                    updateTransCmd.ExecuteNonQuery();

                    // Step 2: Increase book quantity
                    string updateBook = "UPDATE Books SET Quantity = Quantity + 1 WHERE BookID=@BookID";
                    SqlCommand updateBookCmd = new SqlCommand(updateBook, con);
                    updateBookCmd.Parameters.AddWithValue("@BookID", bookID);
                    updateBookCmd.ExecuteNonQuery();

                    // Step 3: Insert new transaction for the return
                    string lastIdQuery = "SELECT TOP 1 TransactionID FROM Transactions ORDER BY CAST(TransactionID AS INT) DESC";
                    SqlCommand idCmd = new SqlCommand(lastIdQuery, con);
                    object result = idCmd.ExecuteScalar();

                    int newIdNumber = 1;
                    if (result != null && int.TryParse(result.ToString(), out int lastNumber))
                        newIdNumber = lastNumber + 1;

                    string transactionID = newIdNumber.ToString("D6");

                    string insertTransaction = @"
                INSERT INTO Transactions
                (TransactionID, LibraryID, BookID, BookName, AdminID, ActionType, Quantity, IssueDate, DueDate, ReturnDate, TransactionDate, Notes)
                VALUES
                (@TransactionID, @LibraryID, @BookID, @BookName, @AdminID, 'Return', 1, NULL, @DueDate, @ReturnDate, @TransactionDate, 'Book Returned')";
                    SqlCommand insertCmd = new SqlCommand(insertTransaction, con);
                    insertCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                    insertCmd.Parameters.AddWithValue("@LibraryID", libraryId);
                    insertCmd.Parameters.AddWithValue("@BookID", bookID);
                    insertCmd.Parameters.AddWithValue("@BookName", bookName);
                    insertCmd.Parameters.AddWithValue("@AdminID", Admin_LogIn_Page.CurrentAdminID);
                    insertCmd.Parameters.AddWithValue("@DueDate", (object)dueDate ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now);
                    insertCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                    insertCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Selected books returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear textboxes
            txtBookID1.Clear(); txtBookName1.Clear();
            txtBookID2.Clear(); txtBookName2.Clear();
            txtBookID3.Clear(); txtBookName3.Clear();
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
                        string query = @"INSERT INTO MemberActions (LibraryID, FirstName, LastName, Action, AdminID)
                                         VALUES (@LibraryID, @FirstName, @LastName, @Action, @AdminID)";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LibraryID", _libraryID);
                        cmd.Parameters.AddWithValue("@FirstName", _firstName);
                        cmd.Parameters.AddWithValue("@LastName", _lastName);
                        cmd.Parameters.AddWithValue("@Action", "LogOut");
                        cmd.Parameters.AddWithValue("@AdminID", Admin_LogIn_Page.CurrentAdminID);

                        con.Open();
                        cmd.ExecuteNonQuery();
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

        private void lstUnreturnedBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRCheck_Click_1(object sender, EventArgs e)
        {
            lstUnreturnedBooks.Items.Clear();

            string libraryID = txtRLibraryID.Text.Trim();
            if (string.IsNullOrEmpty(libraryID))
            {
                MessageBox.Show("Please enter a valid Library ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                        SELECT BookID, BookName, DueDate
                        FROM Transactions
                        WHERE LibraryID = @LibraryID
                        AND ReturnDate IS NULL
                        ORDER BY DueDate ASC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        lstUnreturnedBooks.Items.Add("✅ No unreturned books found for this member.");
                        lstUnreturnedBooks.ForeColor = Color.LightGreen;
                        return;
                    }

                    while (reader.Read())
                    {
                        string bookID = reader["BookID"].ToString();
                        string bookName = reader["BookName"].ToString();
                        DateTime dueDate = Convert.ToDateTime(reader["DueDate"]);

                        string displayText;
                        if (dueDate < DateTime.Now)
                        {
                            int daysLate = (DateTime.Now - dueDate).Days;
                            displayText = $"⚠️ {bookName} (ID: {bookID}) — Overdue by {daysLate} day(s), Due {dueDate:dd MMM yyyy}";
                        }
                        else
                        {
                            int daysLeft = (dueDate - DateTime.Now).Days;
                            displayText = $"{bookName} (ID: {bookID}) — {daysLeft} day(s) left, Due {dueDate:dd MMM yyyy}";
                        }

                        lstUnreturnedBooks.Items.Add(new ListViewItem(displayText) { Tag = bookID });
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading unreturned books:\n" + ex.Message,
                                    "Database Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnReturnBooksExit_Click(object sender, EventArgs e)
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
