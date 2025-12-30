namespace Forms
{
    partial class Admin_LogIn_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_LogIn_Page));
            this.signup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAPassword = new System.Windows.Forms.TextBox();
            this.AdminSignInbtn = new System.Windows.Forms.Button();
            this.AdminExitbtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowPasswordPic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPic)).BeginInit();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signup.Location = new System.Drawing.Point(42, 39);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(126, 47);
            this.signup.TabIndex = 0;
            this.signup.Text = "Sign in";
            this.signup.Click += new System.EventHandler(this.AdminSignInBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtAdminID
            // 
            this.txtAdminID.AccessibleName = "AdminID";
            this.txtAdminID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAdminID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAdminID.ForeColor = System.Drawing.Color.White;
            this.txtAdminID.Location = new System.Drawing.Point(46, 164);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(397, 19);
            this.txtAdminID.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(46, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 2);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(46, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 2);
            this.panel2.TabIndex = 6;
            // 
            // txtAPassword
            // 
            this.txtAPassword.AccessibleName = "";
            this.txtAPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtAPassword.ForeColor = System.Drawing.Color.White;
            this.txtAPassword.Location = new System.Drawing.Point(46, 270);
            this.txtAPassword.Name = "txtAPassword";
            this.txtAPassword.Size = new System.Drawing.Size(366, 19);
            this.txtAPassword.TabIndex = 5;
            this.txtAPassword.UseSystemPasswordChar = true;
            // 
            // AdminSignInbtn
            // 
            this.AdminSignInbtn.AccessibleName = "AdminSignInBtn";
            this.AdminSignInbtn.BackColor = System.Drawing.Color.White;
            this.AdminSignInbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminSignInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminSignInbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSignInbtn.ForeColor = System.Drawing.Color.Black;
            this.AdminSignInbtn.Location = new System.Drawing.Point(94, 355);
            this.AdminSignInbtn.Name = "AdminSignInbtn";
            this.AdminSignInbtn.Size = new System.Drawing.Size(118, 35);
            this.AdminSignInbtn.TabIndex = 7;
            this.AdminSignInbtn.Text = "Sign in";
            this.AdminSignInbtn.UseVisualStyleBackColor = false;
            this.AdminSignInbtn.Click += new System.EventHandler(this.AdminSignInBtn_Click);
            // 
            // AdminExitbtn
            // 
            this.AdminExitbtn.AccessibleName = "AdminExitbtn";
            this.AdminExitbtn.BackColor = System.Drawing.Color.Black;
            this.AdminExitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminExitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminExitbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminExitbtn.ForeColor = System.Drawing.Color.White;
            this.AdminExitbtn.Location = new System.Drawing.Point(243, 355);
            this.AdminExitbtn.Name = "AdminExitbtn";
            this.AdminExitbtn.Size = new System.Drawing.Size(118, 35);
            this.AdminExitbtn.TabIndex = 8;
            this.AdminExitbtn.Text = "Exit";
            this.AdminExitbtn.UseVisualStyleBackColor = false;
            this.AdminExitbtn.Click += new System.EventHandler(this.AdminExitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(524, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ShowPasswordPic
            // 
            this.ShowPasswordPic.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPasswordPic.BackgroundImage")));
            this.ShowPasswordPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPasswordPic.Location = new System.Drawing.Point(418, 269);
            this.ShowPasswordPic.Name = "ShowPasswordPic";
            this.ShowPasswordPic.Size = new System.Drawing.Size(25, 25);
            this.ShowPasswordPic.TabIndex = 23;
            this.ShowPasswordPic.TabStop = false;
            this.ShowPasswordPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPic_MouseDown);
            this.ShowPasswordPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPic_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(529, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "“Where every shelf is open to everyone...”";
            // 
            // Admin_LogIn_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowPasswordPic);
            this.Controls.Add(this.AdminExitbtn);
            this.Controls.Add(this.AdminSignInbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtAPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAdminID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_LogIn_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Log In Page";
            this.Load += new System.EventHandler(this.Admin_LogIn_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAPassword;
        private System.Windows.Forms.Button AdminSignInbtn;
        private System.Windows.Forms.Button AdminExitbtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ShowPasswordPic;
        private System.Windows.Forms.Label label4;
    }
}