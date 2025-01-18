namespace School_Management
{
    partial class Form2
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
            this.btnSync = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtLog1 = new System.Windows.Forms.RichTextBox();
            this.clbTables = new System.Windows.Forms.CheckedListBox();
            this.btnStartSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(474, 106);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(122, 66);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 127);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(412, 311);
            this.txtLog.TabIndex = 1;
            // 
            // txtLog1
            // 
            this.txtLog1.Location = new System.Drawing.Point(458, 226);
            this.txtLog1.Name = "txtLog1";
            this.txtLog1.Size = new System.Drawing.Size(322, 202);
            this.txtLog1.TabIndex = 2;
            this.txtLog1.Text = "";
            // 
            // clbTables
            // 
            this.clbTables.FormattingEnabled = true;
            this.clbTables.Location = new System.Drawing.Point(267, 27);
            this.clbTables.Name = "clbTables";
            this.clbTables.Size = new System.Drawing.Size(120, 94);
            this.clbTables.TabIndex = 3;
            // 
            // btnStartSync
            // 
            this.btnStartSync.Location = new System.Drawing.Point(443, 27);
            this.btnStartSync.Name = "btnStartSync";
            this.btnStartSync.Size = new System.Drawing.Size(75, 23);
            this.btnStartSync.TabIndex = 4;
            this.btnStartSync.Text = "btnStartSync";
            this.btnStartSync.UseVisualStyleBackColor = true;
            this.btnStartSync.Click += new System.EventHandler(this.btnStartSync_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartSync);
            this.Controls.Add(this.clbTables);
            this.Controls.Add(this.txtLog1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSync);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.RichTextBox txtLog1;
        private System.Windows.Forms.CheckedListBox clbTables;
        private System.Windows.Forms.Button btnStartSync;
    }
}