using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Forms
{
    public partial class Complete_Book_Details : Form
    {
        // Connection string
        private readonly string _connString;

        // Keep the data in memory for filtering
        private DataTable dtTransactions;
        private DataTable dtBooks;

        public Complete_Book_Details()
        {
            InitializeComponent();
            _connString = ConfigurationManager.ConnectionStrings["LMSConn"].ConnectionString;
        }

        private void Complete_Book_Details_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            LoadBooksData();
            LoadTotalBookCount();
        }


        private void LoadBooksData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connString))
                {
                    con.Open();
                    string query = @"SELECT [BookID],
                                            [BookName],
                                            [AuthorName],
                                            [Subject],
                                            [Category],
                                            [Language],
                                            [Publisher],
                                            [PublicationYear],
                                            [Quantity],
                                            [Edition],
                                            [Notes]
                                     FROM [dbo].[Books]";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    dtBooks = new DataTable();
                    da.Fill(dtBooks);

                    dgvBooks.DataSource = dtBooks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void LoadTotalBookCount()
        {
            using (SqlConnection con = new SqlConnection(_connString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT SUM(Quantity) FROM Books";
                    SqlCommand cmd = new SqlCommand(query, con);
                    object result = cmd.ExecuteScalar();
                    int totalBooks = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    lblBooksCount.Text = totalBooks.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading total books: " + ex.Message);
                }
            }
        }

        private void LoadTransactions()
        {
            string query = @"
                SELECT TOP (1000)
                    TransactionID,
                    LibraryID,
                    BookID,
                    BookName,
                    AdminID,
                    ActionType,
                    Quantity,
                    IssueDate,
                    DueDate,
                    ReturnDate,
                    TransactionDate,
                    Notes
                FROM dbo.Transactions
                ORDER BY TransactionID DESC";

            try
            {
                using (SqlConnection con = new SqlConnection(_connString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    dtTransactions = new DataTable();
                    da.Fill(dtTransactions);

                    dgvTransactions.AutoGenerateColumns = true;
                    dgvTransactions.DataSource = dtTransactions;

                    FormatGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction data:\n" + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvTransactions.Columns.Contains("TransactionID"))
                dgvTransactions.Columns["TransactionID"].Visible = false;

            foreach (string colName in new[] { "IssueDate", "DueDate", "ReturnDate", "TransactionDate" })
            {
                if (dgvTransactions.Columns.Contains(colName));
            }
        }

        //  SEARCH BOTH TABLES
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Here...") return;

            string searchValue = txtSearch.Text.Trim().Replace("'", "''");

            // --- Search in Transactions ---
            if (dtTransactions != null)
            {
                DataView dvTrans = dtTransactions.DefaultView;

                if (string.IsNullOrEmpty(searchValue))
                {
                    dvTrans.RowFilter = "";
                }
                else
                {
                    dvTrans.RowFilter = string.Format(
                        "CONVERT(TransactionID, 'System.String') LIKE '%{0}%' OR " +
                        "LibraryID LIKE '%{0}%' OR " +
                        "BookID LIKE '%{0}%' OR " +
                        "BookName LIKE '%{0}%' OR " +
                        "AdminID LIKE '%{0}%' OR " +
                        "ActionType LIKE '%{0}%' OR " +
                        "CONVERT(Quantity, 'System.String') LIKE '%{0}%' OR " +
                        "CONVERT(IssueDate, 'System.String') LIKE '%{0}%' OR " +
                        "CONVERT(DueDate, 'System.String') LIKE '%{0}%' OR " +
                        "CONVERT(ReturnDate, 'System.String') LIKE '%{0}%' OR " +
                        "CONVERT(TransactionDate, 'System.String') LIKE '%{0}%' OR " +
                        "Notes LIKE '%{0}%'",
                        searchValue
                    );
                }
            }

            // --- Search in Books ---
            if (dtBooks != null)
            {
                DataView dvBooks = dtBooks.DefaultView;

                if (string.IsNullOrEmpty(searchValue))
                {
                    dvBooks.RowFilter = "";
                }
                else
                {
                    dvBooks.RowFilter = string.Format(
                        "CONVERT(BookID, 'System.String') LIKE '%{0}%' OR " +
                        "BookName LIKE '%{0}%' OR " +
                        "AuthorName LIKE '%{0}%' OR " +
                        "Subject LIKE '%{0}%' OR " +
                        "Category LIKE '%{0}%' OR " +
                        "Language LIKE '%{0}%' OR " +
                        "Publisher LIKE '%{0}%' OR " +
                        "CONVERT(PublicationYear, 'System.String') LIKE '%{0}%' OR " +
                        "CONVERT(Quantity, 'System.String') LIKE '%{0}%' OR " +
                        "Edition LIKE '%{0}%' OR " +
                        "Notes LIKE '%{0}%'",
                        searchValue
                    );
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Here...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.White;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Here...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            Add_Books dashboard = new Add_Books();
            dashboard.Show();
            this.Close();
        }

        private void btnRemoveBooks_Click(object sender, EventArgs e)
        {
            Remove_Books dashboard = new Remove_Books();
            dashboard.Show();
            this.Close();
        }

        private void btnBookInfoExit_Click(object sender, EventArgs e)
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

    }
}
