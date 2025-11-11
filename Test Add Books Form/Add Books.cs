using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            txtABookName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtABookName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtABookName.AutoCompleteCustomSource = LoadAutoCompleteValues("BookName", "Books");

            txtAAuthor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAAuthor.AutoCompleteCustomSource = LoadAutoCompleteValues("AuthorName", "Books");

            txtASubject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtASubject.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtASubject.AutoCompleteCustomSource = LoadAutoCompleteValues("Subject", "Books");

            txtAPublisher.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAPublisher.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAPublisher.AutoCompleteCustomSource = LoadAutoCompleteValues("Publisher", "Books");

            txtAEdition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAEdition.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAEdition.AutoCompleteCustomSource = LoadAutoCompleteValues("Edition", "Books");

            txtACategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtACategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtACategory.AutoCompleteCustomSource = LoadAutoCompleteValues("Category", "Books");

            txtAYear.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAYear.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAYear.AutoCompleteCustomSource = LoadAutoCompleteValues("PublicationYear", "Books");

            txtABookID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtABookID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtABookID.AutoCompleteCustomSource = LoadAutoCompleteValues("BookID", "Books");
        }
        private void ClearBookForm()
        {
            txtABookName.Clear();
            txtAQuantity.Clear();
            txtAEdition.Clear();
            txtAPublisher.Clear();
            txtAYear.Clear();
            cmbALanguage.SelectedIndex = -1;
            txtASubject.Clear();
            txtAAuthor.Clear();
            txtACategory.Clear();
            txtABookID.Clear();
            txtANotes.Clear();
            txtSQuantity.Clear();
        }

        //Genarate Random BookID
        private string GenerateUniqueBookID()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            string bookID;
            bool exists;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                do
                {
                    Random rnd = new Random();
                    int number = rnd.Next(100000, 999999);
                    bookID = "BID" + number.ToString();

                    string query = "SELECT COUNT(*) FROM Books WHERE BookID = @BookID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookID", bookID);

                    int count = (int)cmd.ExecuteScalar();
                    exists = count > 0;

                } while (exists);
            }

            return bookID;
        }


        private void btnAddBooks_Click(object sender, EventArgs e)  //Click Add Books Btn
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(txtABookName.Text) ||
                string.IsNullOrWhiteSpace(txtAEdition.Text) ||
                string.IsNullOrWhiteSpace(txtAPublisher.Text) ||
                string.IsNullOrWhiteSpace(txtASubject.Text) ||
                cmbALanguage.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtAAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtAQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtANotes.Text) ||
                string.IsNullOrWhiteSpace(txtACategory.Text))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtAQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtAYear.Text, out int year))
            {
                MessageBox.Show("Publication year must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string bookID = txtABookID.Text.Trim();
            string bookName = txtABookName.Text.Trim();
            string edition = txtAEdition.Text.Trim();
            string publisher = txtAPublisher.Text.Trim();
            string language = cmbALanguage.SelectedItem.ToString();
            string subject = txtASubject.Text.Trim();
            string author = txtAAuthor.Text.Trim();
            string notes = txtANotes.Text.Trim();
            string category = txtACategory.Text.Trim();
            string adminID = Admin_LogIn_Page.CurrentAdminID;

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if book exists
                string checkQuery = @"SELECT BookID, Quantity FROM Books WHERE BookID = @BookID";
                SqlCommand cmd = new SqlCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                SqlDataReader reader = cmd.ExecuteReader();

                int finalQuantity;
                if (reader.Read())
                {
                    // Update quantity
                    int existingQty = Convert.ToInt32(reader["Quantity"]);
                    finalQuantity = existingQty + quantity;
                    reader.Close();

                    string updateQuery = "UPDATE Books SET Quantity = @Quantity WHERE BookID = @BookID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@Quantity", finalQuantity);
                        updateCmd.Parameters.AddWithValue("@BookID", bookID);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Book already exists. Quantity updated to {finalQuantity}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    reader.Close();
                    finalQuantity = quantity;

                    // Insert new book
                    string insertQuery = @"INSERT INTO Books 
                (BookID, BookName, Quantity, Edition, Publisher, PublicationYear, Language, Subject, AuthorName, Category, Notes)
                VALUES (@BookID, @BookName, @Quantity, @Edition, @Publisher, @PublicationYear, @Language, @Subject, @AuthorName, @Category, @Notes)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@BookID", bookID);
                        insertCmd.Parameters.AddWithValue("@BookName", bookName);
                        insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                        insertCmd.Parameters.AddWithValue("@Edition", edition);
                        insertCmd.Parameters.AddWithValue("@Publisher", publisher);
                        insertCmd.Parameters.AddWithValue("@PublicationYear", year);
                        insertCmd.Parameters.AddWithValue("@Language", language);
                        insertCmd.Parameters.AddWithValue("@Subject", subject);
                        insertCmd.Parameters.AddWithValue("@AuthorName", author);
                        insertCmd.Parameters.AddWithValue("@Category", category);
                        insertCmd.Parameters.AddWithValue("@Notes", notes);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"New Book Added Successfully with BookID: {bookID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Generate TransactionID
                string lastId = new SqlCommand("SELECT TOP 1 TransactionID FROM Transactions ORDER BY TransactionID DESC", con)
                                .ExecuteScalar()?.ToString() ?? "000000";
                string transactionID = (int.Parse(lastId) + 1).ToString("D6");

                string insertTransQuery = @"INSERT INTO Transactions 
              (TransactionID, LibraryID, BookID, BookName, AdminID, ActionType, Quantity, TransactionDate, Notes)
              VALUES (@TransactionID, @LibraryID, @BookID, @BookName, @AdminID, @ActionType, @Quantity, @TransactionDate, @Notes)";
                SqlCommand transCmd = new SqlCommand(insertTransQuery, con);
                transCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                transCmd.Parameters.AddWithValue("@LibraryID", DBNull.Value);
                transCmd.Parameters.AddWithValue("@BookID", bookID);
                transCmd.Parameters.AddWithValue("@BookName", bookName);
                transCmd.Parameters.AddWithValue("@AdminID", adminID);
                transCmd.Parameters.AddWithValue("@ActionType", "Add");
                transCmd.Parameters.AddWithValue("@Quantity", quantity);
                transCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                transCmd.Parameters.AddWithValue("@Notes", notes);
                transCmd.ExecuteNonQuery();
            }

            ClearBookForm(); // Clear fields
        }


        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private AutoCompleteStringCollection LoadAutoCompleteValues(string columnName, string tableName)
        {
            var values = new AutoCompleteStringCollection();

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = $"SELECT DISTINCT {columnName} FROM {tableName}";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                            values.Add(reader[0].ToString());
                    }
                }
            }

            return values;
        }

        private void btnAddBooksExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                          "Confirm Exit",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnAGenarate_Click(object sender, EventArgs e)
        {
            // Read book details from form
            string bookName = txtABookName.Text.Trim();
            string edition = txtAEdition.Text.Trim();
            string notes = txtANotes.Text.Trim();
            string publisher = txtAPublisher.Text.Trim();
            int year = 0;
            int.TryParse(txtAYear.Text.Trim(), out year);
            string language = cmbALanguage.SelectedItem?.ToString() ?? "";
            string subject = txtASubject.Text.Trim();
            string author = txtAAuthor.Text.Trim();
            string category = txtACategory.Text.Trim();

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string checkQuery = @"SELECT BookID, Quantity FROM Books 
                              WHERE LOWER(BookName) = LOWER(@BookName) 
                                AND LOWER(Edition) = LOWER(@Edition)
                                AND LOWER(Publisher) = LOWER(@Publisher) 
                                AND PublicationYear = @PublicationYear
                                AND LOWER(Language) = LOWER(@Language) 
                                AND LOWER(Subject) = LOWER(@Subject) 
                                AND LOWER(AuthorName) = LOWER(@AuthorName) 
                                AND LOWER(Category) = LOWER(@Category)";

                using (SqlCommand cmd = new SqlCommand(checkQuery, con))
                {
                    cmd.Parameters.AddWithValue("@BookName", bookName);
                    cmd.Parameters.AddWithValue("@Edition", edition);
                    cmd.Parameters.AddWithValue("@Publisher", publisher);
                    cmd.Parameters.AddWithValue("@PublicationYear", year);
                    cmd.Parameters.AddWithValue("@Language", language);
                    cmd.Parameters.AddWithValue("@Subject", subject);
                    cmd.Parameters.AddWithValue("@AuthorName", author);
                    cmd.Parameters.AddWithValue("@Category", category);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Book exists → show existing quantity
                        txtSQuantity.Text = reader["Quantity"].ToString();
                        txtABookID.Text = reader["BookID"].ToString();
                        MessageBox.Show("Book already exists. Quantity shown in textbox.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        reader.Close();
                        // Book not exists → generate new Book ID
                        string newBookID = GenerateUniqueBookID();
                        txtABookID.Text = newBookID;
                        MessageBox.Show($"New Book ID generated: {newBookID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
