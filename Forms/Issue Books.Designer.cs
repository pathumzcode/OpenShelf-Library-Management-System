namespace Forms
{
    partial class Issue_Books
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
            this.btnRBLogOut = new System.Windows.Forms.Button();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtILibraryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtILastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtBookID3 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtBookName3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBookID2 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBookName2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBookID1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDFirstName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookName1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnICheck = new System.Windows.Forms.Button();
            this.lstUnreturnedBooks = new System.Windows.Forms.ListView();
            this.btnIssueBooksExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRBLogOut
            // 
            this.btnRBLogOut.BackColor = System.Drawing.Color.Black;
            this.btnRBLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRBLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBLogOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBLogOut.ForeColor = System.Drawing.Color.White;
            this.btnRBLogOut.Location = new System.Drawing.Point(789, 812);
            this.btnRBLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnRBLogOut.Name = "btnRBLogOut";
            this.btnRBLogOut.Size = new System.Drawing.Size(312, 35);
            this.btnRBLogOut.TabIndex = 66;
            this.btnRBLogOut.Text = "Log Out";
            this.btnRBLogOut.UseVisualStyleBackColor = false;
            this.btnRBLogOut.Click += new System.EventHandler(this.btnRBLogOut_Click);
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.BackColor = System.Drawing.Color.Black;
            this.btnReturnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBooks.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBooks.ForeColor = System.Drawing.Color.White;
            this.btnReturnBooks.Location = new System.Drawing.Point(428, 812);
            this.btnReturnBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(312, 35);
            this.btnReturnBooks.TabIndex = 67;
            this.btnReturnBooks.Text = "Return Book";
            this.btnReturnBooks.UseVisualStyleBackColor = false;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 73;
            this.label1.Text = "Issue Books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(893, 448);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 3);
            this.panel2.TabIndex = 79;
            // 
            // txtILibraryID
            // 
            this.txtILibraryID.BackColor = System.Drawing.Color.Black;
            this.txtILibraryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtILibraryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtILibraryID.ForeColor = System.Drawing.Color.White;
            this.txtILibraryID.Location = new System.Drawing.Point(893, 416);
            this.txtILibraryID.Margin = new System.Windows.Forms.Padding(4);
            this.txtILibraryID.Name = "txtILibraryID";
            this.txtILibraryID.ReadOnly = true;
            this.txtILibraryID.Size = new System.Drawing.Size(222, 19);
            this.txtILibraryID.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(887, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Library ID";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(892, 288);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 3);
            this.panel4.TabIndex = 85;
            // 
            // txtIFirstName
            // 
            this.txtIFirstName.BackColor = System.Drawing.Color.Black;
            this.txtIFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIFirstName.ForeColor = System.Drawing.Color.White;
            this.txtIFirstName.Location = new System.Drawing.Point(892, 256);
            this.txtIFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtIFirstName.Name = "txtIFirstName";
            this.txtIFirstName.ReadOnly = true;
            this.txtIFirstName.Size = new System.Drawing.Size(222, 19);
            this.txtIFirstName.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(887, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 83;
            this.label5.Text = "First Name";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(1200, 288);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 3);
            this.panel5.TabIndex = 88;
            // 
            // txtILastName
            // 
            this.txtILastName.BackColor = System.Drawing.Color.Black;
            this.txtILastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtILastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtILastName.ForeColor = System.Drawing.Color.White;
            this.txtILastName.Location = new System.Drawing.Point(1200, 256);
            this.txtILastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtILastName.Name = "txtILastName";
            this.txtILastName.ReadOnly = true;
            this.txtILastName.Size = new System.Drawing.Size(222, 19);
            this.txtILastName.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1195, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 86;
            this.label6.Text = "Last Name";
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.BackColor = System.Drawing.Color.White;
            this.btnIssueBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBooks.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBooks.ForeColor = System.Drawing.Color.Black;
            this.btnIssueBooks.Location = new System.Drawing.Point(68, 812);
            this.btnIssueBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Size = new System.Drawing.Size(312, 35);
            this.btnIssueBooks.TabIndex = 90;
            this.btnIssueBooks.Text = "Issue Book";
            this.btnIssueBooks.UseVisualStyleBackColor = false;
            this.btnIssueBooks.Click += new System.EventHandler(this.btnIssueBooks_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(561, 586);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(222, 3);
            this.panel8.TabIndex = 129;
            // 
            // txtBookID3
            // 
            this.txtBookID3.BackColor = System.Drawing.Color.Black;
            this.txtBookID3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookID3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID3.ForeColor = System.Drawing.Color.White;
            this.txtBookID3.Location = new System.Drawing.Point(561, 554);
            this.txtBookID3.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookID3.Name = "txtBookID3";
            this.txtBookID3.Size = new System.Drawing.Size(217, 19);
            this.txtBookID3.TabIndex = 128;
            this.txtBookID3.TextChanged += new System.EventHandler(this.txtBookID3_TextChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(127, 586);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(405, 3);
            this.panel9.TabIndex = 127;
            // 
            // txtBookName3
            // 
            this.txtBookName3.BackColor = System.Drawing.Color.Black;
            this.txtBookName3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName3.ForeColor = System.Drawing.Color.White;
            this.txtBookName3.Location = new System.Drawing.Point(127, 554);
            this.txtBookName3.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName3.Name = "txtBookName3";
            this.txtBookName3.ReadOnly = true;
            this.txtBookName3.Size = new System.Drawing.Size(400, 19);
            this.txtBookName3.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(608, 552);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 125;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(561, 446);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 3);
            this.panel6.TabIndex = 124;
            // 
            // txtBookID2
            // 
            this.txtBookID2.BackColor = System.Drawing.Color.Black;
            this.txtBookID2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID2.ForeColor = System.Drawing.Color.White;
            this.txtBookID2.Location = new System.Drawing.Point(561, 414);
            this.txtBookID2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookID2.Name = "txtBookID2";
            this.txtBookID2.Size = new System.Drawing.Size(217, 19);
            this.txtBookID2.TabIndex = 123;
            this.txtBookID2.TextChanged += new System.EventHandler(this.txtBookID2_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(127, 446);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(405, 3);
            this.panel7.TabIndex = 122;
            // 
            // txtBookName2
            // 
            this.txtBookName2.BackColor = System.Drawing.Color.Black;
            this.txtBookName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName2.ForeColor = System.Drawing.Color.White;
            this.txtBookName2.Location = new System.Drawing.Point(127, 414);
            this.txtBookName2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName2.Name = "txtBookName2";
            this.txtBookName2.ReadOnly = true;
            this.txtBookName2.Size = new System.Drawing.Size(400, 19);
            this.txtBookName2.TabIndex = 121;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(561, 317);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 3);
            this.panel3.TabIndex = 120;
            // 
            // txtBookID1
            // 
            this.txtBookID1.BackColor = System.Drawing.Color.Black;
            this.txtBookID1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID1.ForeColor = System.Drawing.Color.White;
            this.txtBookID1.Location = new System.Drawing.Point(561, 284);
            this.txtBookID1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookID1.Name = "txtBookID1";
            this.txtBookID1.Size = new System.Drawing.Size(217, 19);
            this.txtBookID1.TabIndex = 119;
            this.txtBookID1.TextChanged += new System.EventHandler(this.txtBookID1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(555, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 118;
            this.label4.Text = "Book ID";
            // 
            // lblDFirstName
            // 
            this.lblDFirstName.AutoSize = true;
            this.lblDFirstName.BackColor = System.Drawing.Color.Black;
            this.lblDFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblDFirstName.ForeColor = System.Drawing.Color.White;
            this.lblDFirstName.Location = new System.Drawing.Point(608, 412);
            this.lblDFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDFirstName.Name = "lblDFirstName";
            this.lblDFirstName.Size = new System.Drawing.Size(0, 20);
            this.lblDFirstName.TabIndex = 117;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(127, 317);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 3);
            this.panel1.TabIndex = 116;
            // 
            // txtBookName1
            // 
            this.txtBookName1.BackColor = System.Drawing.Color.Black;
            this.txtBookName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName1.ForeColor = System.Drawing.Color.White;
            this.txtBookName1.Location = new System.Drawing.Point(127, 284);
            this.txtBookName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookName1.Name = "txtBookName1";
            this.txtBookName1.ReadOnly = true;
            this.txtBookName1.Size = new System.Drawing.Size(400, 19);
            this.txtBookName1.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 114;
            this.label2.Text = "Book Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(122, 647);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 130;
            this.label8.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(127, 697);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(300, 25);
            this.dtpDueDate.TabIndex = 131;
            // 
            // btnICheck
            // 
            this.btnICheck.ForeColor = System.Drawing.Color.Black;
            this.btnICheck.Location = new System.Drawing.Point(893, 559);
            this.btnICheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnICheck.Name = "btnICheck";
            this.btnICheck.Size = new System.Drawing.Size(188, 30);
            this.btnICheck.TabIndex = 133;
            this.btnICheck.Text = "Check";
            this.btnICheck.UseVisualStyleBackColor = true;
            this.btnICheck.Click += new System.EventHandler(this.btnICheck_Click);
            // 
            // lstUnreturnedBooks
            // 
            this.lstUnreturnedBooks.BackColor = System.Drawing.Color.Black;
            this.lstUnreturnedBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUnreturnedBooks.ForeColor = System.Drawing.Color.White;
            this.lstUnreturnedBooks.HideSelection = false;
            this.lstUnreturnedBooks.Location = new System.Drawing.Point(893, 618);
            this.lstUnreturnedBooks.Name = "lstUnreturnedBooks";
            this.lstUnreturnedBooks.Size = new System.Drawing.Size(530, 119);
            this.lstUnreturnedBooks.TabIndex = 134;
            this.lstUnreturnedBooks.UseCompatibleStateImageBehavior = false;
            this.lstUnreturnedBooks.View = System.Windows.Forms.View.List;
            // 
            // btnIssueBooksExit
            // 
            this.btnIssueBooksExit.BackColor = System.Drawing.Color.Black;
            this.btnIssueBooksExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueBooksExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBooksExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnIssueBooksExit.ForeColor = System.Drawing.Color.White;
            this.btnIssueBooksExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIssueBooksExit.Location = new System.Drawing.Point(1146, 812);
            this.btnIssueBooksExit.Name = "btnIssueBooksExit";
            this.btnIssueBooksExit.Size = new System.Drawing.Size(312, 35);
            this.btnIssueBooksExit.TabIndex = 139;
            this.btnIssueBooksExit.Text = "Exit";
            this.btnIssueBooksExit.UseVisualStyleBackColor = false;
            this.btnIssueBooksExit.Click += new System.EventHandler(this.btnIssueBooksExit_Click);
            // 
            // Issue_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1531, 910);
            this.Controls.Add(this.btnIssueBooksExit);
            this.Controls.Add(this.lstUnreturnedBooks);
            this.Controls.Add(this.btnICheck);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtBookID3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtBookName3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtBookID2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtBookName2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtBookID1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDFirstName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBookName1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIssueBooks);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtILastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtIFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtILibraryID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnBooks);
            this.Controls.Add(this.btnRBLogOut);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(390, 123);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Issue_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Issue Books";
            this.Load += new System.EventHandler(this.Issue_Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRBLogOut;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtILibraryID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtILastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtBookID3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtBookName3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtBookID2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBookName2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBookID1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDFirstName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBookName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnICheck;
        private System.Windows.Forms.ListView lstUnreturnedBooks;
        private System.Windows.Forms.Button btnIssueBooksExit;
    }
}