namespace Forms
{
    partial class ASettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASettings));
            this.btnAdminRegister = new System.Windows.Forms.Button();
            this.btnSystemInfo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminRegister
            // 
            this.btnAdminRegister.BackColor = System.Drawing.Color.White;
            this.btnAdminRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAdminRegister, "btnAdminRegister");
            this.btnAdminRegister.ForeColor = System.Drawing.Color.Black;
            this.btnAdminRegister.Name = "btnAdminRegister";
            this.btnAdminRegister.UseVisualStyleBackColor = false;
            this.btnAdminRegister.Click += new System.EventHandler(this.btnAdminRegister_Click);
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.BackColor = System.Drawing.Color.Black;
            this.btnSystemInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSystemInfo, "btnSystemInfo");
            this.btnSystemInfo.ForeColor = System.Drawing.Color.White;
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.UseVisualStyleBackColor = false;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Black;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // ASettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSystemInfo);
            this.Controls.Add(this.btnAdminRegister);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ASettings";
            this.Load += new System.EventHandler(this.ASettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminRegister;
        private System.Windows.Forms.Button btnSystemInfo;
        private System.Windows.Forms.Button btnLogOut;
    }
}