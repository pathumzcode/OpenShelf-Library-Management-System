using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Forms
{
    public partial class Remove_Members : Form
    {
        public Remove_Members()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtRLibraryID.Clear();
            txtRFirstName.Clear();
            txtRLastName.Clear();
            txtRPhone.Clear();
            txtRAddress.Clear();
            txtRAge.Clear();
            txtRPassword.Clear();
            txtRConfirmPassword.Clear();
            txtRNotes.Clear();
            cmbRGender.SelectedIndex = -1;
            dtpRBirthday.Value = DateTime.Now;
        }

        private void btnMemberRemoveExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?",
                                         "Confirm Exit",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes) this.Close();
        }

        private void BtnLIDSearch_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";

            // CASE 1: Library ID filled → fill other details
            if (!string.IsNullOrWhiteSpace(txtRLibraryID.Text))
            {
                string libraryID = txtRLibraryID.Text.Trim();

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP 1 FirstName, LastName, Phone, Address, Gender, Birthday, Age
                      FROM Members WHERE LibraryID = @LibraryID", con))
                {
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtRFirstName.Text = reader["FirstName"]?.ToString() ?? "";
                            txtRLastName.Text = reader["LastName"]?.ToString() ?? "";
                            txtRPhone.Text = reader["Phone"]?.ToString() ?? "";
                            txtRAddress.Text = reader["Address"]?.ToString() ?? "";

                            string gender = reader["Gender"]?.ToString() ?? "";
                            if (!string.IsNullOrEmpty(gender) && cmbRGender.Items.Contains(gender))
                                cmbRGender.SelectedItem = gender;
                            else
                                cmbRGender.SelectedIndex = -1;

                            if (reader["Birthday"] != DBNull.Value)
                                dtpRBirthday.Value = Convert.ToDateTime(reader["Birthday"]);
                            else
                                dtpRBirthday.Value = DateTime.Now;

                            txtRAge.Text = reader["Age"]?.ToString() ?? "";

                            // Do NOT fill Password fields
                            txtRPassword.Clear();
                            txtRConfirmPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No member found with this Library ID.", "Not Found",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    con.Close();
                }
                return;
            }

            // CASE 2: Library ID empty → fill Library ID using other details
            if (string.IsNullOrWhiteSpace(txtRPhone.Text))
            {
                MessageBox.Show("Either enter Library ID or fill Phone Number and click Search.",
                                "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phone = txtRPhone.Text.Trim();

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT TOP 1 LibraryID 
                  FROM Members
                  WHERE Phone = @Phone", con))
            {
                cmd.Parameters.AddWithValue("@Phone", phone);

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null)
                {
                    txtRLibraryID.Text = result.ToString();
                    MessageBox.Show("Library ID found and filled automatically!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No matching member found with these details.", "Not Found",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnMemberRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRLibraryID.Text) ||
                string.IsNullOrWhiteSpace(txtRPassword.Text) ||
                string.IsNullOrWhiteSpace(txtRConfirmPassword.Text))
            {
                MessageBox.Show("Please fill Library ID and password fields before removing.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtRPassword.Text.Trim() != txtRConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Password and Confirm Password do not match!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to remove this member?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes) return;

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM Members WHERE LibraryID=@LibraryID AND Password=@Password", con))
            {
                cmd.Parameters.AddWithValue("@LibraryID", txtRLibraryID.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtRPassword.Text.Trim());

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    // ✅ Log remove action
                    LogMemberAction(txtRLibraryID.Text.Trim(), txtRFirstName.Text.Trim(), txtRLastName.Text.Trim());

                    MessageBox.Show("Member removed successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("No matching member found or password incorrect!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LogMemberAction(string libraryID, string firstName, string lastName)
        {
            try
            {
                string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO MemberActions (LibraryID, FirstName, LastName, Action, AdminID, Notes)
                                     VALUES (@LibraryID, @FirstName, @LastName, @Action, @AdminID, @Notes)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Action", "Remove");
                    cmd.Parameters.AddWithValue("@AdminID", Admin_LogIn_Page.CurrentAdminID);
                    cmd.Parameters.AddWithValue("@Notes", txtRNotes.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging member action: " + ex.Message);
            }
        }

        private void ShowPasswordPic_MouseDown(object sender, MouseEventArgs e)
        {
            txtRPassword.UseSystemPasswordChar = false; // Show password
            txtRConfirmPassword.UseSystemPasswordChar = false;
        }

        private void ShowPasswordPic_MouseUp(object sender, MouseEventArgs e)
        {
            txtRPassword.UseSystemPasswordChar = true;  // Hide password
            txtRConfirmPassword.UseSystemPasswordChar = true;
        }

        private void Remove_Members_Load(object sender, EventArgs e)
        {

        }
    }
}
