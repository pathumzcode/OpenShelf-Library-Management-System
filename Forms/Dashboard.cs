using Forms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Forms
{
    public partial class Dashboard: Form
    {
        private string _libraryID;
        private string _firstName;
        private string _lastName;

        public Dashboard(string libraryID, string firstName, string lastName)
        {
            InitializeComponent();
            _libraryID = libraryID;
            _firstName = firstName;
            _lastName = lastName;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblDLibraryID.Text = "Library ID:   " + _libraryID;
            lblDFirstName.Text = "First Name:   " + _firstName;
            lblDLastName.Text = "Last Name:   " + _lastName;
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void DashboardPnl_Load(object sender, EventArgs e)
        {
           
        } 
        private void BackToLogInBtn_Click_1(object sender, EventArgs e)
        {
            Member_LogIn_Page dashboard = new Member_LogIn_Page();
            dashboard.Show();
        }

        private void IssueBooksBtn_Click(object sender, EventArgs e)
        {
            Issue_Books issueForm = new Issue_Books(_libraryID, _firstName, _lastName);
            issueForm.Show();
        }

        private void AddStudentsBtn_Click(object sender, EventArgs e)
        {
            Member_Registation dashboard = new Member_Registation();
            dashboard.Show();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            ASettings dashboard = new ASettings();
            dashboard.Show();
        }

        private void CompleteBookBtn_Click(object sender, EventArgs e)
        {
            Complete_Book_Details dashboard = new Complete_Book_Details();
            dashboard.Show();
        }

        private void btbnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Clear All?",
                                                  "Confirm Exit",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                this.Hide();
            }
        }

        private void ViewMembersBtn_Click(object sender, EventArgs e)
        {
            View_Members_Info dashboard = new View_Members_Info();
            dashboard.Show();
        }

        private void ReturnBooksBtn_Click(object sender, EventArgs e)
        {
            Return_Books returnForm = new Return_Books();
            returnForm.Show();
        }

  
    }
}
