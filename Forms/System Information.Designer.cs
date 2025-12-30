namespace Forms
{
    partial class System_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_Information));
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookInfoExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInformation
            // 
            this.rtbInformation.BackColor = System.Drawing.Color.Black;
            this.rtbInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInformation.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.rtbInformation, "rtbInformation");
            this.rtbInformation.ForeColor = System.Drawing.Color.White;
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btnBookInfoExit
            // 
            this.btnBookInfoExit.BackColor = System.Drawing.Color.White;
            this.btnBookInfoExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBookInfoExit, "btnBookInfoExit");
            this.btnBookInfoExit.ForeColor = System.Drawing.Color.Black;
            this.btnBookInfoExit.Name = "btnBookInfoExit";
            this.btnBookInfoExit.UseVisualStyleBackColor = false;
            this.btnBookInfoExit.Click += new System.EventHandler(this.btnBookInfoExit_Click);
            // 
            // System_Information
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnBookInfoExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "System_Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookInfoExit;
    }
}