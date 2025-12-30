using System.Drawing;

namespace Forms
{
    partial class Complete_Book_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complete_Book_Details));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.btnRemoveBooks = new System.Windows.Forms.Button();
            this.btnBookInfoExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.grpBooks = new System.Windows.Forms.GroupBox();
            this.lblBooksCount = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.grpBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddBooks
            // 
            resources.ApplyResources(this.btnAddBooks, "btnAddBooks");
            this.btnAddBooks.BackColor = System.Drawing.Color.Black;
            this.btnAddBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBooks.ForeColor = System.Drawing.Color.White;
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.UseVisualStyleBackColor = false;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // btnRemoveBooks
            // 
            resources.ApplyResources(this.btnRemoveBooks, "btnRemoveBooks");
            this.btnRemoveBooks.BackColor = System.Drawing.Color.Black;
            this.btnRemoveBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveBooks.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBooks.Name = "btnRemoveBooks";
            this.btnRemoveBooks.UseVisualStyleBackColor = false;
            this.btnRemoveBooks.Click += new System.EventHandler(this.btnRemoveBooks_Click);
            // 
            // btnBookInfoExit
            // 
            this.btnBookInfoExit.BackColor = System.Drawing.Color.Black;
            this.btnBookInfoExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBookInfoExit, "btnBookInfoExit");
            this.btnBookInfoExit.ForeColor = System.Drawing.Color.White;
            this.btnBookInfoExit.Name = "btnBookInfoExit";
            this.btnBookInfoExit.UseVisualStyleBackColor = false;
            this.btnBookInfoExit.Click += new System.EventHandler(this.btnBookInfoExit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Black;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dgvTransactions, "dgvTransactions");
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            // 
            // grpBooks
            // 
            this.grpBooks.BackColor = System.Drawing.Color.Black;
            this.grpBooks.Controls.Add(this.lblBooksCount);
            resources.ApplyResources(this.grpBooks, "grpBooks");
            this.grpBooks.ForeColor = System.Drawing.Color.White;
            this.grpBooks.Name = "grpBooks";
            this.grpBooks.TabStop = false;
            // 
            // lblBooksCount
            // 
            resources.ApplyResources(this.lblBooksCount, "lblBooksCount");
            this.lblBooksCount.Name = "lblBooksCount";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.dgvBooks, "dgvBooks");
            this.dgvBooks.Name = "dgvBooks";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Complete_Book_Details
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBooks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBookInfoExit);
            this.Controls.Add(this.btnRemoveBooks);
            this.Controls.Add(this.btnAddBooks);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Complete_Book_Details";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Complete_Book_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.grpBooks.ResumeLayout(false);
            this.grpBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Button btnRemoveBooks;
        private System.Windows.Forms.Button btnBookInfoExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.GroupBox grpBooks;
        private System.Windows.Forms.Label lblBooksCount;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}