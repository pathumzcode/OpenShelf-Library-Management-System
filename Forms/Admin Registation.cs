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
    public partial class Admin_Registation : Form
    {
        public Admin_Registation()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtAAdminID.Clear();
            txtAFirstName.Clear();
            txtALastName.Clear();
            txtAPhone.Clear();
            txtAIDNumber.Clear();
            txtAAddress.Clear();
            txtAAge.Clear();
            txtAPassword.Clear();
            txtAConfirmPassword.Clear();
            cmbAGender.SelectedIndex = -1;
            dtpABirthday.Value = DateTime.Now;
        }
        private string GenerateUniqueAdminID()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            string adminID;
            bool exists;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                do
                {
                    Random rnd = new Random();
                    int number = rnd.Next(100000, 999999);
                    adminID = "AID" + number.ToString();

                    string query = "SELECT COUNT(*) FROM Admins WHERE AdminID = @AdminID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AdminID", adminID);

                    int count = (int)cmd.ExecuteScalar();
                    exists = count > 0;

                } while (exists);
            }

            return adminID;
        }
        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthday = dtpABirthday.Value;
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age--;
            txtAAge.Text = age.ToString();
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            // 1️⃣ Ensure Admin ID is generated
            if (string.IsNullOrWhiteSpace(txtAAdminID.Text))
            {
                MessageBox.Show("Please generate an Admin ID before registering.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2️⃣ Validate age again
            if (!int.TryParse(txtAAge.Text, out int age) || age < 18 || age > 50)
            {
                MessageBox.Show("Please enter a valid age between 18 and 50.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3️⃣ Collect data
            string adminID = txtAAdminID.Text;
            string firstName = txtAFirstName.Text.Trim();
            string lastName = txtALastName.Text.Trim();
            string phone = txtAPhone.Text.Trim();
            string address = txtAAddress.Text.Trim();
            string idNumber = txtAIDNumber.Text.Trim();
            string gender = cmbAGender.SelectedItem.ToString();
            DateTime birthday = dtpABirthday.Value;
            string password = txtAPassword.Text.Trim();

            // 4️⃣ Insert into database
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Admins (AdminID, FirstName, LastName, Phone, Address, Gender, Birthday, Age, Password, IDNumber) " +
                               "VALUES (@AdminID, @FirstName, @LastName, @Phone, @Address, @Gender, @Birthday, @Age, @Password, @IDNumber)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AdminID", adminID);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Birthday", birthday);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@IDNumber", idNumber);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            // 5️⃣ Success message
            MessageBox.Show("Registration Successful!\nYour Admin ID: " + adminID, "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 6️⃣ Clear form for new entry
            ClearForm();
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

        private void dtpABirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthday = dtpABirthday.Value;
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age--;
            txtAAge.Text = age.ToString();
        }

        private void BtnAIDGenarate_Click(object sender, EventArgs e)
        {
            // 1️⃣ Check mandatory fields
            if (string.IsNullOrWhiteSpace(txtAFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtALastName.Text) ||
                string.IsNullOrWhiteSpace(txtAPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAIDNumber.Text) ||
                string.IsNullOrWhiteSpace(txtAAddress.Text) ||
                cmbAGender.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtAAge.Text) ||
                string.IsNullOrWhiteSpace(txtAPassword.Text) ||
                string.IsNullOrWhiteSpace(txtAConfirmPassword.Text))
            {
                MessageBox.Show("Please fill all fields before generating Admin ID.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2️⃣ Validate phone
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtAPhone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3️⃣ Validate age
            if (!int.TryParse(txtAAge.Text, out int age) || age < 18 || age > 50)
            {
                MessageBox.Show("Please enter a valid age between 18 and 50.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4️⃣ Check if passwords match
            if (txtAPassword.Text.Trim() != txtAConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Password and Confirm Password do not match!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5️⃣ Check if admin already exists by ID Number
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=LibraryManagementSystem;Trusted_Connection=True;";
            bool adminExists = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Admins WHERE IDNumber=@IDNumber";
                SqlCommand cmd = new SqlCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@IDNumber", txtAIDNumber.Text.Trim());

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0) adminExists = true;
            }

            if (adminExists)
            {
                MessageBox.Show("This admin already exists! Admin ID will not be generated.",
                    "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAAdminID.Clear();
                return;
            }

            // 6️⃣ Generate unique Admin ID
            string adminID = GenerateUniqueAdminID();
            txtAAdminID.Text = adminID;
            txtAAdminID.ReadOnly = true; // Optional: prevent editing

            MessageBox.Show("Admin ID Generated: " + adminID, "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowPasswordPic_MouseDown(object sender, MouseEventArgs e)
        {
            txtAPassword.UseSystemPasswordChar = false; // Show password when mouse pressed
            txtAConfirmPassword.UseSystemPasswordChar = false;
        }

        private void ShowPasswordPic_MouseUp(object sender, MouseEventArgs e)
        {
            txtAPassword.UseSystemPasswordChar = true;  // Hide password when mouse released
            txtAConfirmPassword.UseSystemPasswordChar = true;
        }

        private void Admin_Registation_Load(object sender, EventArgs e)
        {

        }
    }
    
}
