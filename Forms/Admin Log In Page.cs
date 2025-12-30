using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Forms
{
    public partial class Admin_LogIn_Page : Form
    {
        // Static variable to store logged-in AdminID globally
        public static string CurrentAdminID;

        public Admin_LogIn_Page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminSignInBtn_Click(object sender, EventArgs e)
        {
            string adminID = txtAdminID.Text.Trim();
            string password = txtAPassword.Text.Trim();

            if (string.IsNullOrEmpty(adminID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Admin ID and Password.");
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Admins WHERE AdminID = @AdminID AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AdminID", adminID);
                cmd.Parameters.AddWithValue("@Password", password);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    // ✅ Save logged-in admin globally
                    CurrentAdminID = adminID;

                    MessageBox.Show("Login successful!\nWelcome " + adminID + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdminExitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ShowPasswordPic_MouseDown(object sender, MouseEventArgs e)
        {
            txtAPassword.UseSystemPasswordChar = false;
        }

        private void ShowPasswordPic_MouseUp(object sender, MouseEventArgs e)
        {
            txtAPassword.UseSystemPasswordChar = true;
        }

        private void Admin_LogIn_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
