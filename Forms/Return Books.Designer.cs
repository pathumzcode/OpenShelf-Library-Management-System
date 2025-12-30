namespace Forms
{
    partial class Return_Books
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookName1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDLastName = new System.Windows.Forms.Label();
            this.lblLibraryID = new System.Windows.Forms.Label();
            this.lblDLibraryID = new System.Windows.Forms.Label();
            this.lblDFirstName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtRLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBookID1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRLibraryID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtBookID2 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtBookName2 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtBookID3 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtBookName3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRCheck = new System.Windows.Forms.Button();
            this.lstUnreturnedBooks = new System.Windows.Forms.ListView();
            this.btnReturnBooksExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRBLogOut
            // 
            this.btnRBLogOut.BackColor = System.Drawing.Color.Black;
            this.btnRBLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRBLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRBLogOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRBLogOut.ForeColor = System.Drawing.Color.White;
            this.btnRBLogOut.Location = new System.Drawing.Point(781, 778);
            this.btnRBLogOut.Name = "btnRBLogOut";
            this.btnRBLogOut.Size = new System.Drawing.Size(312, 35);
            this.btnRBLogOut.TabIndex = 65;
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
            this.btnReturnBooks.Location = new System.Drawing.Point(426, 778);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(312, 35);
            this.btnReturnBooks.TabIndex = 68;
            this.btnReturnBooks.Text = "Issue Book";
            this.btnReturnBooks.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(92, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 2);
            this.panel1.TabIndex = 72;
            // 
            // txtBookName1
            // 
            this.txtBookName1.BackColor = System.Drawing.Color.Black;
            this.txtBookName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName1.ForeColor = System.Drawing.Color.White;
            this.txtBookName1.Location = new System.Drawing.Point(92, 222);
            this.txtBookName1.Name = "txtBookName1";
            this.txtBookName1.ReadOnly = true;
            this.txtBookName1.Size = new System.Drawing.Size(404, 19);
            this.txtBookName1.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 69;
            this.label1.Text = "Return Books";
            // 
            // lblDLastName
            // 
            this.lblDLastName.AutoSize = true;
            this.lblDLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblDLastName.ForeColor = System.Drawing.Color.White;
            this.lblDLastName.Location = new System.Drawing.Point(1036, 162);
            this.lblDLastName.Name = "lblDLastName";
            this.lblDLastName.Size = new System.Drawing.Size(0, 20);
            this.lblDLastName.TabIndex = 77;
            // 
            // lblLibraryID
            // 
            this.lblLibraryID.AutoSize = true;
            this.lblLibraryID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblLibraryID.ForeColor = System.Drawing.Color.White;
            this.lblLibraryID.Location = new System.Drawing.Point(1036, 185);
            this.lblLibraryID.Name = "lblLibraryID";
            this.lblLibraryID.Size = new System.Drawing.Size(0, 20);
            this.lblLibraryID.TabIndex = 76;
            // 
            // lblDLibraryID
            // 
            this.lblDLibraryID.AutoSize = true;
            this.lblDLibraryID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblDLibraryID.ForeColor = System.Drawing.Color.White;
            this.lblDLibraryID.Location = new System.Drawing.Point(1036, 205);
            this.lblDLibraryID.Name = "lblDLibraryID";
            this.lblDLibraryID.Size = new System.Drawing.Size(0, 20);
            this.lblDLibraryID.TabIndex = 74;
            // 
            // lblDFirstName
            // 
            this.lblDFirstName.AutoSize = true;
            this.lblDFirstName.BackColor = System.Drawing.Color.Black;
            this.lblDFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblDFirstName.ForeColor = System.Drawing.Color.White;
            this.lblDFirstName.Location = new System.Drawing.Point(604, 314);
            this.lblDFirstName.Name = "lblDFirstName";
            this.lblDFirstName.Size = new System.Drawing.Size(0, 20);
            this.lblDFirstName.TabIndex = 73;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(1224, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 2);
            this.panel5.TabIndex = 101;
            // 
            // txtRLastName
            // 
            this.txtRLastName.BackColor = System.Drawing.Color.Black;
            this.txtRLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRLastName.ForeColor = System.Drawing.Color.White;
            this.txtRLastName.Location = new System.Drawing.Point(1224, 186);
            this.txtRLastName.Name = "txtRLastName";
            this.txtRLastName.ReadOnly = true;
            this.txtRLastName.Size = new System.Drawing.Size(186, 19);
            this.txtRLastName.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1219, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 99;
            this.label6.Text = "Last Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(917, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 2);
            this.panel4.TabIndex = 98;
            // 
            // txtRFirstName
            // 
            this.txtRFirstName.BackColor = System.Drawing.Color.Black;
            this.txtRFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFirstName.ForeColor = System.Drawing.Color.White;
            this.txtRFirstName.Location = new System.Drawing.Point(917, 198);
            this.txtRFirstName.Name = "txtRFirstName";
            this.txtRFirstName.ReadOnly = true;
            this.txtRFirstName.Size = new System.Drawing.Size(186, 19);
            this.txtRFirstName.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(912, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 96;
            this.label5.Text = "First Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(564, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 2);
            this.panel3.TabIndex = 95;
            // 
            // txtBookID1
            // 
            this.txtBookID1.BackColor = System.Drawing.Color.Black;
            this.txtBookID1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID1.ForeColor = System.Drawing.Color.White;
            this.txtBookID1.Location = new System.Drawing.Point(564, 222);
            this.txtBookID1.Name = "txtBookID1";
            this.txtBookID1.Size = new System.Drawing.Size(186, 19);
            this.txtBookID1.TabIndex = 94;
            this.txtBookID1.TextChanged += new System.EventHandler(this.txtBookID1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(559, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 93;
            this.label4.Text = "Book ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(917, 362);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 2);
            this.panel2.TabIndex = 92;
            // 
            // txtRLibraryID
            // 
            this.txtRLibraryID.BackColor = System.Drawing.Color.Black;
            this.txtRLibraryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRLibraryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRLibraryID.ForeColor = System.Drawing.Color.White;
            this.txtRLibraryID.Location = new System.Drawing.Point(917, 337);
            this.txtRLibraryID.Name = "txtRLibraryID";
            this.txtRLibraryID.ReadOnly = true;
            this.txtRLibraryID.Size = new System.Drawing.Size(186, 19);
            this.txtRLibraryID.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(912, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Library ID";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.White;
            this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.Black;
            this.btnReturnBook.Location = new System.Drawing.Point(69, 778);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(312, 35);
            this.btnReturnBook.TabIndex = 103;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(564, 340);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 2);
            this.panel6.TabIndex = 108;
            // 
            // txtBookID2
            // 
            this.txtBookID2.BackColor = System.Drawing.Color.Black;
            this.txtBookID2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID2.ForeColor = System.Drawing.Color.White;
            this.txtBookID2.Location = new System.Drawing.Point(564, 315);
            this.txtBookID2.Name = "txtBookID2";
            this.txtBookID2.Size = new System.Drawing.Size(186, 19);
            this.txtBookID2.TabIndex = 107;
            this.txtBookID2.TextChanged += new System.EventHandler(this.txtBookID2_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(92, 340);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(408, 2);
            this.panel7.TabIndex = 105;
            // 
            // txtBookName2
            // 
            this.txtBookName2.BackColor = System.Drawing.Color.Black;
            this.txtBookName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName2.ForeColor = System.Drawing.Color.White;
            this.txtBookName2.Location = new System.Drawing.Point(92, 315);
            this.txtBookName2.Name = "txtBookName2";
            this.txtBookName2.ReadOnly = true;
            this.txtBookName2.Size = new System.Drawing.Size(404, 19);
            this.txtBookName2.TabIndex = 104;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(564, 440);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(190, 2);
            this.panel8.TabIndex = 113;
            // 
            // txtBookID3
            // 
            this.txtBookID3.BackColor = System.Drawing.Color.Black;
            this.txtBookID3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookID3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID3.ForeColor = System.Drawing.Color.White;
            this.txtBookID3.Location = new System.Drawing.Point(564, 415);
            this.txtBookID3.Name = "txtBookID3";
            this.txtBookID3.Size = new System.Drawing.Size(186, 19);
            this.txtBookID3.TabIndex = 112;
            this.txtBookID3.TextChanged += new System.EventHandler(this.txtBookID3_TextChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(92, 439);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(408, 2);
            this.panel9.TabIndex = 111;
            // 
            // txtBookName3
            // 
            this.txtBookName3.BackColor = System.Drawing.Color.Black;
            this.txtBookName3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName3.ForeColor = System.Drawing.Color.White;
            this.txtBookName3.Location = new System.Drawing.Point(92, 414);
            this.txtBookName3.Multiline = true;
            this.txtBookName3.Name = "txtBookName3";
            this.txtBookName3.Size = new System.Drawing.Size(404, 20);
            this.txtBookName3.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(604, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 109;
            // 
            // btnRCheck
            // 
            this.btnRCheck.ForeColor = System.Drawing.Color.Black;
            this.btnRCheck.Location = new System.Drawing.Point(92, 489);
            this.btnRCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnRCheck.Name = "btnRCheck";
            this.btnRCheck.Size = new System.Drawing.Size(188, 30);
            this.btnRCheck.TabIndex = 136;
            this.btnRCheck.Text = "Check";
            this.btnRCheck.UseVisualStyleBackColor = true;
            this.btnRCheck.Click += new System.EventHandler(this.btnRCheck_Click_1);
            // 
            // lstUnreturnedBooks
            // 
            this.lstUnreturnedBooks.BackColor = System.Drawing.Color.Black;
            this.lstUnreturnedBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUnreturnedBooks.ForeColor = System.Drawing.Color.White;
            this.lstUnreturnedBooks.FullRowSelect = true;
            this.lstUnreturnedBooks.HideSelection = false;
            this.lstUnreturnedBooks.LabelWrap = false;
            this.lstUnreturnedBooks.Location = new System.Drawing.Point(92, 539);
            this.lstUnreturnedBooks.Name = "lstUnreturnedBooks";
            this.lstUnreturnedBooks.Size = new System.Drawing.Size(1015, 119);
            this.lstUnreturnedBooks.TabIndex = 137;
            this.lstUnreturnedBooks.UseCompatibleStateImageBehavior = false;
            this.lstUnreturnedBooks.View = System.Windows.Forms.View.List;
            // 
            // btnReturnBooksExit
            // 
            this.btnReturnBooksExit.BackColor = System.Drawing.Color.Black;
            this.btnReturnBooksExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBooksExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBooksExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnReturnBooksExit.ForeColor = System.Drawing.Color.White;
            this.btnReturnBooksExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturnBooksExit.Location = new System.Drawing.Point(1141, 778);
            this.btnReturnBooksExit.Name = "btnReturnBooksExit";
            this.btnReturnBooksExit.Size = new System.Drawing.Size(312, 35);
            this.btnReturnBooksExit.TabIndex = 138;
            this.btnReturnBooksExit.Text = "Exit";
            this.btnReturnBooksExit.UseVisualStyleBackColor = false;
            this.btnReturnBooksExit.Click += new System.EventHandler(this.btnReturnBooksExit_Click);
            // 
            // Return_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1531, 910);
            this.Controls.Add(this.btnReturnBooksExit);
            this.Controls.Add(this.lstUnreturnedBooks);
            this.Controls.Add(this.btnRCheck);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtBookID3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtBookName3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtBookID2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtBookName2);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtRLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtRFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtBookID1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRLibraryID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDLastName);
            this.Controls.Add(this.lblLibraryID);
            this.Controls.Add(this.lblDLibraryID);
            this.Controls.Add(this.lblDFirstName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBookName1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnBooks);
            this.Controls.Add(this.btnRBLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(390, 123);
            this.Name = "Return_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Return Books";
            this.Load += new System.EventHandler(this.Return_Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRBLogOut;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBookName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDLastName;
        private System.Windows.Forms.Label lblLibraryID;
        private System.Windows.Forms.Label lblDLibraryID;
        private System.Windows.Forms.Label lblDFirstName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtRLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBookID1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRLibraryID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtBookID2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBookName2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtBookID3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtBookName3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRCheck;
        private System.Windows.Forms.ListView lstUnreturnedBooks;
        private System.Windows.Forms.Button btnReturnBooksExit;
    }
}