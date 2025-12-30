using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ASettings : Form
    {
        public ASettings()
        {
            InitializeComponent();
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            Admin_Registation dashboard = new Admin_Registation();
            this.Close();
            dashboard.Show();
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            System_Information dashboard = new System_Information();
            dashboard.Show();
            this.Close();   
        }

        private void ASettings_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
