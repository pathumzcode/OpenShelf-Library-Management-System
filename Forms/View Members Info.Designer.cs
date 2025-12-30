using System.Drawing;

namespace Forms
{
    partial class View_Members_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Members_Info));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemoveMembers = new System.Windows.Forms.Button();
            this.btnAddMembers = new System.Windows.Forms.Button();
            this.btnViewMembersInfoExit = new System.Windows.Forms.Button();
            this.dgvMemberActions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.lblMemberCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberActions)).BeginInit();
            this.grpMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveMembers
            // 
            resources.ApplyResources(this.btnRemoveMembers, "btnRemoveMembers");
            this.btnRemoveMembers.BackColor = System.Drawing.Color.Black;
            this.btnRemoveMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveMembers.ForeColor = System.Drawing.Color.White;
            this.btnRemoveMembers.Name = "btnRemoveMembers";
            this.btnRemoveMembers.UseVisualStyleBackColor = false;
            this.btnRemoveMembers.Click += new System.EventHandler(this.btnRemoveMembers_Click);
            // 
            // btnAddMembers
            // 
            resources.ApplyResources(this.btnAddMembers, "btnAddMembers");
            this.btnAddMembers.BackColor = System.Drawing.Color.Black;
            this.btnAddMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMembers.ForeColor = System.Drawing.Color.White;
            this.btnAddMembers.Name = "btnAddMembers";
            this.btnAddMembers.UseVisualStyleBackColor = false;
            this.btnAddMembers.Click += new System.EventHandler(this.btnAddMembers_Click_1);
            // 
            // btnViewMembersInfoExit
            // 
            resources.ApplyResources(this.btnViewMembersInfoExit, "btnViewMembersInfoExit");
            this.btnViewMembersInfoExit.BackColor = System.Drawing.Color.Black;
            this.btnViewMembersInfoExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMembersInfoExit.ForeColor = System.Drawing.Color.White;
            this.btnViewMembersInfoExit.Name = "btnViewMembersInfoExit";
            this.btnViewMembersInfoExit.UseVisualStyleBackColor = false;
            this.btnViewMembersInfoExit.Click += new System.EventHandler(this.btnViewMembersInfoExit_Click);
            // 
            // dgvMemberActions
            // 
            this.dgvMemberActions.AllowUserToDeleteRows = false;
            this.dgvMemberActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMemberActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberActions.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvMemberActions, "dgvMemberActions");
            this.dgvMemberActions.Name = "dgvMemberActions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // grpMembers
            // 
            this.grpMembers.BackColor = System.Drawing.Color.Black;
            this.grpMembers.Controls.Add(this.lblMemberCount);
            resources.ApplyResources(this.grpMembers, "grpMembers");
            this.grpMembers.ForeColor = System.Drawing.Color.White;
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.TabStop = false;
            // 
            // lblMemberCount
            // 
            resources.ApplyResources(this.lblMemberCount, "lblMemberCount");
            this.lblMemberCount.Name = "lblMemberCount";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // View_Members_Info
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMemberActions);
            this.Controls.Add(this.grpMembers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewMembersInfoExit);
            this.Controls.Add(this.btnAddMembers);
            this.Controls.Add(this.btnRemoveMembers);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Members_Info";
            this.Load += new System.EventHandler(this.View_Members_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberActions)).EndInit();
            this.grpMembers.ResumeLayout(false);
            this.grpMembers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveMembers;
        private System.Windows.Forms.Button btnAddMembers;
        private System.Windows.Forms.Button btnViewMembersInfoExit;
        private System.Windows.Forms.DataGridView dgvMemberActions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.Label lblMemberCount;
        private System.Windows.Forms.Label label2;
    }
}