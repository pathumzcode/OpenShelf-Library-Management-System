using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Forms
{
    public partial class View_Members_Info : Form
    {
        private DataTable dtMemberActions;

        public View_Members_Info()
        {
            InitializeComponent();
        }

        private void View_Members_Info_Load(object sender, EventArgs e)
        {
            LoadMemberActions();
            LoadMemberCount();
        }

        private void LoadMemberCount()
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(LibraryID) FROM Members";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int totalMembers = (int)cmd.ExecuteScalar();

                    lblMemberCount.Text = totalMembers.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching member count: " + ex.Message);
            }
        }


        // Load MemberActions table into DataGridView
        private void LoadMemberActions()
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
            string query = @"SELECT TOP (1000) [ActionID], 
                                               [LibraryID],
                                                [AdminID],
                                               [FirstName], 
                                                [LastName], 
                                                [Action], 
                                                [ActionTime], 
                                                 [Notes]
                                                           FROM [LibraryManagementSystem].[dbo].[MemberActions]
                                                           ORDER BY [ActionTime] DESC";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                dtMemberActions = new DataTable();
                adapter.Fill(dtMemberActions);

                dgvMemberActions.DataSource = dtMemberActions;

                // Optional: Auto-size columns
                dgvMemberActions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMemberActions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMemberActions.ReadOnly = true;
            }
        }

        //Search/filter DataGridView
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Here...") return;
            string searchValue = txtSearch.Text.Trim().Replace("'", "''");

            if (dtMemberActions == null) return;

            DataView dv = dtMemberActions.DefaultView;

            if (string.IsNullOrEmpty(searchValue))
            {
                dv.RowFilter = ""; 
            }
            else
            {
                dv.RowFilter = string.Format(
                    "CONVERT(ActionID, 'System.String') LIKE '%{0}%' OR " +
                    "LibraryID LIKE '%{0}%' OR " +
                    "AdminID LIKE '%{0}%' OR " +
                    "FirstName LIKE '%{0}%' OR " +
                    "LastName LIKE '%{0}%' OR " +
                    "Action LIKE '%{0}%' OR " +
                    "CONVERT(ActionTime, 'System.String') LIKE '%{0}%' OR " +
                    "Notes LIKE '%{0}%'",
                    
                    searchValue
                );
            }
        }

        private void btnAddMembers_Click_1(object sender, EventArgs e)
        {
            Member_Registation dashboard = new Member_Registation();
            dashboard.Show();
            this.Close();
        }

        private void btnViewMembersInfoExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                                         "Confirm Exit",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnRemoveMembers_Click(object sender, EventArgs e)
        {
            Remove_Members dashboard = new Remove_Members();
            dashboard.Show();
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberActions(); // Reload data
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            // Clear placeholder text when user clicks
            if (txtSearch.Text == "Search Here...")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            // Restore placeholder if left empty
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Here...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}
