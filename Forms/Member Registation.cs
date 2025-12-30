using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Forms
{
    public partial class Member_Registation : Form
    {
        public Member_Registation()
        {
            InitializeComponent();
        }

        private void MemberRegistation_Load(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            txtMLibraryID.Clear();
            txtMFirstName.Clear();
            txtMLastName.Clear();
            txtMPhone.Clear();
            txtMAddress.Clear();
            txtMAge.Clear();
            txtMPassword.Clear();
            txtMConfirmPassword.Clear();
            cmbMGender.SelectedIndex = -1;
            dtpMBirthday.Value = DateTime.Now;
        }

        private string GenerateUniqueLibraryID()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            string libraryID;
            bool exists;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                do
                {
                    Random rnd = new Random();
                    int number = rnd.Next(100000, 999999);
                    libraryID = "LID" + number.ToString();

                    string query = "SELECT COUNT(*) FROM Members WHERE LibraryID = @LibraryID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                    int count = (int)cmd.ExecuteScalar();
                    exists = count > 0;

                } while (exists);
            }

            return libraryID;
        }

        private void BtnLIDGenarate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMLastName.Text) ||
                string.IsNullOrWhiteSpace(txtMPhone.Text) ||
                string.IsNullOrWhiteSpace(txtMAddress.Text) ||
                cmbMGender.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtMAge.Text) ||
                string.IsNullOrWhiteSpace(txtMPassword.Text) ||
                string.IsNullOrWhiteSpace(txtMConfirmPassword.Text))
            {
                MessageBox.Show("Please fill all fields before generating Library ID.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(txtMPhone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMPassword.Text.Trim() != txtMConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Password and Confirm Password do not match!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtMAge.Text, out int age) || age < 1 || age > 120)
            {
                MessageBox.Show("Please enter a valid age between 1 and 120.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
            bool memberExists = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Members WHERE Phone=@Phone";
                SqlCommand cmd = new SqlCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@Phone", txtMPhone.Text.Trim());

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    memberExists = true;
                }
            }

            if (memberExists)
            {
                MessageBox.Show("This member already exists in the system! Library ID will not be generated.",
                    "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMLibraryID.Clear();
                return;
            }

            string libraryID = GenerateUniqueLibraryID();
            txtMLibraryID.Text = libraryID;

            MessageBox.Show("Library ID Generated: " + libraryID, "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMLibraryID.Text))
            {
                MessageBox.Show("Please generate a Library ID before registering.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!int.TryParse(txtMAge.Text, out int age) || age < 1 || age > 120)
            {
                MessageBox.Show("Please enter a valid age between 1 and 120.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string libraryID = txtMLibraryID.Text;
            string firstName = txtMFirstName.Text.Trim();
            string lastName = txtMLastName.Text.Trim();
            string phone = txtMPhone.Text.Trim();
            string address = txtMAddress.Text.Trim();
            string gender = cmbMGender.SelectedItem.ToString();
            DateTime birthday = dtpMBirthday.Value;
            string password = txtMPassword.Text;

            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Members 
                                 (LibraryID, FirstName, LastName, Phone, Address, Gender, Birthday, Age, Password) 
                                 VALUES (@LibraryID, @FirstName, @LastName, @Phone, @Address, @Gender, @Birthday, @Age, @Password)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Birthday", birthday);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            LogMemberAction(libraryID, firstName, lastName);

            MessageBox.Show("Registration Successful!\nYour Library ID: " + libraryID,
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }

        private void LogMemberAction(string libraryID, string firstName, string lastName)
        {
            try
            {
                string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO MemberActions (LibraryID, FirstName, LastName, Action, AdminID, Notes)
                                     VALUES (@LibraryID, @FirstName, @LastName, @Action, @AdminID, 'New Member Registered')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Action", "Register");
                    cmd.Parameters.AddWithValue("@AdminID", Admin_LogIn_Page.CurrentAdminID);

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

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthday = dtpMBirthday.Value;
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age--;
            txtMAge.Text = age.ToString();
        }

        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ShowPasswordPic_MouseDown(object sender, MouseEventArgs e)
        {
            txtMPassword.UseSystemPasswordChar = false;
            txtMConfirmPassword.UseSystemPasswordChar = false;
        }

        private void ShowPasswordPic_MouseUp(object sender, MouseEventArgs e)
        {
            txtMPassword.UseSystemPasswordChar = true;
            txtMConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnMemberExit_Click(object sender, EventArgs e)
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
