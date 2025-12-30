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
    public partial class System_Information : Form
    {
        public System_Information()
        {
            InitializeComponent();
            LoadInformation();
        }

        private void LoadInformation()
        {

        }

        private void btnBookInfoExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
