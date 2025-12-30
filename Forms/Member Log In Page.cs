using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Forms
{
    public partial class Member_LogIn_Page : Form
    {
        public Member_LogIn_Page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMPassword.UseSystemPasswordChar = true;
        }

        private void btnStudentExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                                         "Confirm Exit",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void ShowPasswordPic_MouseDown(object sender, MouseEventArgs e)
        {
            txtMPassword.UseSystemPasswordChar = false;
        }

        private void ShowPasswordPic_MouseUp(object sender, MouseEventArgs e)
        {
            txtMPassword.UseSystemPasswordChar = true;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Member_Registation registration = new Member_Registation();
            registration.Show();
            this.Hide();
        }

        private void StudentSignInBtn_Click(object sender, EventArgs e)
        {
            string libraryID = txtLibraryID.Text.Trim();
            string password = txtMPassword.Text.Trim();

            if (string.IsNullOrEmpty(libraryID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Library ID and Password.");
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT FirstName, LastName FROM Members WHERE LibraryID=@LibraryID AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();

                    Session.CurrentLibraryID = libraryID;
                    Session.CurrentFirstName = firstName;
                    Session.CurrentLastName = lastName;

                    string adminID = Admin_LogIn_Page.CurrentAdminID;

                    InsertMemberAction(libraryID, firstName, lastName, "LogIn", adminID);

                    Dashboard dashboard = new Dashboard(libraryID, firstName, lastName);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static class Session
        {
            public static string CurrentLibraryID { get; set; }
            public static string CurrentFirstName { get; set; }
            public static string CurrentLastName { get; set; }
        }

        private void InsertMemberAction(string libraryID, string firstName, string lastName, string action, string adminID)
        {

            try
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO MemberActions (LibraryID, FirstName, LastName, Action, ActionTime, AdminID, Notes)
                             VALUES (@LibraryID, @FirstName, @LastName, @Action, GETDATE(), @AdminID, 'Member Log In')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Action", action);
                        cmd.Parameters.AddWithValue("@AdminID", adminID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging member action: " + ex.Message);
            }
        }
    }
}
