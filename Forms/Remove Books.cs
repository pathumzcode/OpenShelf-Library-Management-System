using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Forms
{
    public partial class Remove_Books : Form
    {
        public Remove_Books()
        {
            InitializeComponent();
        }

        private void Remove_Books_Load(object sender, EventArgs e)
        {
            txtRBookName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRBookName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRBookName.AutoCompleteCustomSource = LoadAutoCompleteValues("BookName", "Books");

            txtRAuthor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRAuthor.AutoCompleteCustomSource = LoadAutoCompleteValues("AuthorName", "Books");

            txtRSubject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRSubject.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRSubject.AutoCompleteCustomSource = LoadAutoCompleteValues("Subject", "Books");

            txtRPublisher.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRPublisher.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRPublisher.AutoCompleteCustomSource = LoadAutoCompleteValues("Publisher", "Books");

            txtREdition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtREdition.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtREdition.AutoCompleteCustomSource = LoadAutoCompleteValues("Edition", "Books");

            txtRCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRCategory.AutoCompleteCustomSource = LoadAutoCompleteValues("Category", "Books");

            txtRYear.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtRYear.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtRYear.AutoCompleteCustomSource = LoadAutoCompleteValues("PublicationYear", "Books");
        }
        private void ClearBookForm()
        {
            txtRBookName.Clear();
            txtRQuantity.Clear();
            txtREdition.Clear();
            txtRPublisher.Clear();
            txtRYear.Clear();
            cmbRLanguage.SelectedIndex = -1;
            txtRSubject.Clear();
            txtRAuthor.Clear();
            txtRCategory.Clear();
            txtRBookID.Clear();
            txtSQuantity.Clear();
            txtRNotes.Clear();
        }

        private void txtRBookName_Leave(object sender, EventArgs e)
        {
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

                string bookName = txtRBookName.Text.Trim();

                if (string.IsNullOrEmpty(bookName))
                {
                    txtRBookID.Text = "";
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT TOP 1 BookID FROM Books WHERE BookName = @BookName";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@BookName", bookName);

                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                txtRBookID.Text = result.ToString();
                            }
                            else
                            {
                                txtRBookID.Text = "Not Found";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtRBookID.Text) || string.IsNullOrWhiteSpace(txtRQuantity.Text))
            {
                MessageBox.Show("Please enter Book ID and Quantity to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtRQuantity.Text, out int removeQty))
            {
                MessageBox.Show("Quantity to remove must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string bookID = txtRBookID.Text.Trim();
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            string adminID = Admin_LogIn_Page.CurrentAdminID; // Logged-in admin

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if book exists and get current quantity
                string checkQuery = "SELECT BookName, Quantity FROM Books WHERE BookID = @BookID";
                using (SqlCommand cmd = new SqlCommand(checkQuery, con))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Book ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string bookName = reader["BookName"].ToString();
                    int currentQty = Convert.ToInt32(reader["Quantity"]);
                    reader.Close();

                    //  Check if removal quantity is valid
                    if (removeQty > currentQty)
                    {
                        MessageBox.Show($"Cannot remove {removeQty} books. Only {currentQty} available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //  Confirm removal
                    DialogResult confirm = MessageBox.Show($"Current available quantity: {currentQty}\nDo you want to remove {removeQty} books?",
                                                           "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm != DialogResult.Yes) return;

                    //  Update Books table
                    int newQty = currentQty - removeQty;
                    string updateQuery = "UPDATE Books SET Quantity = @Quantity WHERE BookID = @BookID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@Quantity", newQty);
                        updateCmd.Parameters.AddWithValue("@BookID", bookID);
                        updateCmd.ExecuteNonQuery();
                    }

                    //  Insert transaction record
                    string lastId = new SqlCommand("SELECT TOP 1 TransactionID FROM Transactions ORDER BY TransactionID DESC", con)
                                    .ExecuteScalar()?.ToString() ?? "000000";
                    string transactionID = (int.Parse(lastId) + 1).ToString("D6");

                    string insertTransQuery = @"INSERT INTO Transactions 
                (TransactionID, LibraryID, BookID, BookName, AdminID, ActionType, Quantity, TransactionDate, Notes)
                VALUES (@TransactionID, @LibraryID, @BookID, @BookName, @AdminID, @ActionType, @Quantity, @TransactionDate, @Notes)";
                    using (SqlCommand transCmd = new SqlCommand(insertTransQuery, con))
                    {
                        transCmd.Parameters.AddWithValue("@TransactionID", transactionID);
                        transCmd.Parameters.AddWithValue("@LibraryID", DBNull.Value); // Admin action, no member
                        transCmd.Parameters.AddWithValue("@BookID", bookID);
                        transCmd.Parameters.AddWithValue("@BookName", bookName);
                        transCmd.Parameters.AddWithValue("@AdminID", adminID);
                        transCmd.Parameters.AddWithValue("@ActionType", "Remove");
                        transCmd.Parameters.AddWithValue("@Quantity", -removeQty);
                        transCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                        transCmd.Parameters.AddWithValue("@Notes", txtRNotes.Text.Trim());
                        transCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Books removed successfully.\nNew available quantity: {newQty}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 7️⃣ Clear form fields
                    txtRQuantity.Clear();
                    txtSQuantity.Text = newQty.ToString();
                    ClearBookForm();
                }
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

        private void BtnRSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRBookName.Text) ||
                string.IsNullOrWhiteSpace(txtREdition.Text) ||
                string.IsNullOrWhiteSpace(txtRPublisher.Text) ||
                string.IsNullOrWhiteSpace(txtRSubject.Text) ||
                cmbRLanguage.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtRAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtRQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtRNotes.Text) ||
                string.IsNullOrWhiteSpace(txtRCategory.Text))
            {
                //if isn't fill show error message
                MessageBox.Show("Please fill all fields before searching.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                  // Assuming you have these variables from your form
                  string bookName = txtRBookName.Text.Trim();
                  string notes = txtRNotes.Text.Trim();       // example for Notes textbox
                  string edition = txtREdition.Text.Trim();
                  string publisher = txtRPublisher.Text.Trim();
                  int year = int.Parse(txtRYear.Text.Trim()); // make sure to validate input
                  string language = cmbRLanguage.Text.Trim();
                  string subject = txtRSubject.Text.Trim();
                  string author = txtRAuthor.Text.Trim();
                  string category = txtRCategory.Text.Trim();

                  string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

                  using (SqlConnection con = new SqlConnection(connectionString))
                  {
                      con.Open();

                      // Query to check duplicate / existing book
                      string checkQuery = @"SELECT BookID, Quantity FROM Books 
                        WHERE LOWER(BookName) = LOWER(@BookName) 
                          AND LOWER(Edition) = LOWER(@Edition)
                          AND LOWER(Publisher) = LOWER(@Publisher) 
                          AND PublicationYear = @PublicationYear
                          AND LOWER(Language) = LOWER(@Language) 
                          AND LOWER(Subject) = LOWER(@Subject) 
                          AND LOWER(AuthorName) = LOWER(@AuthorName) 
                          AND LOWER(Category) = LOWER(@Category)";

                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                        {
                            checkCmd.Parameters.AddWithValue("@BookName", bookName);
                            checkCmd.Parameters.AddWithValue("@Edition", edition);
                            checkCmd.Parameters.AddWithValue("@Publisher", publisher);
                            checkCmd.Parameters.AddWithValue("@PublicationYear", year);
                            checkCmd.Parameters.AddWithValue("@Language", language);
                            checkCmd.Parameters.AddWithValue("@Subject", subject);
                            checkCmd.Parameters.AddWithValue("@AuthorName", author);
                            checkCmd.Parameters.AddWithValue("@Category", category);

                            using (SqlDataReader dr = checkCmd.ExecuteReader())
                            {
                                if (dr.Read()) // Book exists
                                {
                                    txtRBookID.Text = dr["BookID"].ToString();
                                    txtSQuantity.Text = dr["Quantity"].ToString();
                                }
                                else // Not found
                                {
                                    txtRBookID.Text = "Book ID Not Found!";
                           
                                }
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnRSearch_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnRemoveBooksExit_Click(object sender, EventArgs e)
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

        private void txtRBookID_MouseLeave(object sender, EventArgs e)
        {
            string bookID = txtRBookID.Text.Trim();
            if (string.IsNullOrEmpty(bookID))
            {
                ClearBookForm();
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"SELECT * FROM Books WHERE BookID = @BookID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookID);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                txtRBookName.Text = dr["BookName"].ToString();
                                txtREdition.Text = dr["Edition"].ToString();
                                txtRPublisher.Text = dr["Publisher"].ToString();
                                txtRYear.Text = dr["PublicationYear"].ToString();
                                txtSQuantity.Text = dr["Quantity"].ToString();
                                cmbRLanguage.Text = dr["Language"].ToString();
                                txtRSubject.Text = dr["Subject"].ToString();
                                txtRAuthor.Text = dr["AuthorName"].ToString();
                                txtRCategory.Text = dr["Category"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Book ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ClearBookForm();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
    }
}
