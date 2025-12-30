namespace Forms
{
    partial class Member_LogIn_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_LogIn_Page));
            this.btnStudentExit = new System.Windows.Forms.Button();
            this.StudentSignInBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLibraryID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ShowPasswordPic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentExit
            // 
            this.btnStudentExit.BackColor = System.Drawing.Color.Black;
            this.btnStudentExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentExit.ForeColor = System.Drawing.Color.White;
            this.btnStudentExit.Location = new System.Drawing.Point(366, 405);
            this.btnStudentExit.Name = "btnStudentExit";
            this.btnStudentExit.Size = new System.Drawing.Size(118, 35);
            this.btnStudentExit.TabIndex = 16;
            this.btnStudentExit.Text = "Exit";
            this.btnStudentExit.UseVisualStyleBackColor = false;
            this.btnStudentExit.Click += new System.EventHandler(this.btnStudentExit_Click);
            // 
            // StudentSignInBtn
            // 
            this.StudentSignInBtn.BackColor = System.Drawing.Color.White;
            this.StudentSignInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentSignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentSignInBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSignInBtn.ForeColor = System.Drawing.Color.Black;
            this.StudentSignInBtn.Location = new System.Drawing.Point(106, 405);
            this.StudentSignInBtn.Name = "StudentSignInBtn";
            this.StudentSignInBtn.Size = new System.Drawing.Size(118, 35);
            this.StudentSignInBtn.TabIndex = 15;
            this.StudentSignInBtn.Text = "Sign in";
            this.StudentSignInBtn.UseVisualStyleBackColor = false;
            this.StudentSignInBtn.Click += new System.EventHandler(this.StudentSignInBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(74, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 2);
            this.panel2.TabIndex = 14;
            // 
            // txtMPassword
            // 
            this.txtMPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMPassword.ForeColor = System.Drawing.Color.White;
            this.txtMPassword.Location = new System.Drawing.Point(74, 270);
            this.txtMPassword.Name = "txtMPassword";
            this.txtMPassword.Size = new System.Drawing.Size(354, 19);
            this.txtMPassword.TabIndex = 13;
            this.txtMPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(74, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 2);
            this.panel1.TabIndex = 12;
            // 
            // txtLibraryID
            // 
            this.txtLibraryID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtLibraryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLibraryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtLibraryID.ForeColor = System.Drawing.Color.White;
            this.txtLibraryID.Location = new System.Drawing.Point(74, 155);
            this.txtLibraryID.Name = "txtLibraryID";
            this.txtLibraryID.Size = new System.Drawing.Size(406, 19);
            this.txtLibraryID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(70, 120);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 23);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Library ID";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.Black;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.Location = new System.Drawing.Point(236, 405);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(118, 35);
            this.SignUpBtn.TabIndex = 17;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signup.Location = new System.Drawing.Point(59, 39);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(126, 47);
            this.signup.TabIndex = 18;
            this.signup.Text = "Sign in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(69, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "If you haven\'t an account Sign Up first...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(524, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 60);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // ShowPasswordPic
            // 
            this.ShowPasswordPic.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPasswordPic.BackgroundImage")));
            this.ShowPasswordPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPasswordPic.Location = new System.Drawing.Point(451, 269);
            this.ShowPasswordPic.Name = "ShowPasswordPic";
            this.ShowPasswordPic.Size = new System.Drawing.Size(25, 25);
            this.ShowPasswordPic.TabIndex = 22;
            this.ShowPasswordPic.TabStop = false;
            this.ShowPasswordPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPic_MouseDown);
            this.ShowPasswordPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPic_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(529, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "“Where every shelf is open to everyone...”";
            // 
            // Member_LogIn_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowPasswordPic);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.btnStudentExit);
            this.Controls.Add(this.StudentSignInBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtMPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLibraryID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Member_LogIn_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Lod In Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudentExit;
        private System.Windows.Forms.Button StudentSignInBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLibraryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ShowPasswordPic;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}