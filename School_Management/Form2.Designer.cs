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
            this.txtLog1 = new System.Windows.Forms.RichTextBox();
            this.clbTables = new System.Windows.Forms.CheckedListBox();
            this.btnStartSync = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog1
            // 
            this.txtLog1.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtLog1.Location = new System.Drawing.Point(39, 185);
            this.txtLog1.Name = "txtLog1";
            this.txtLog1.Size = new System.Drawing.Size(322, 202);
            this.txtLog1.TabIndex = 2;
            this.txtLog1.Text = "";
            // 
            // clbTables
            // 
            this.clbTables.Font = new System.Drawing.Font("Cairo", 10F);
            this.clbTables.FormattingEnabled = true;
            this.clbTables.Location = new System.Drawing.Point(19, 38);
            this.clbTables.Name = "clbTables";
            this.clbTables.Size = new System.Drawing.Size(120, 94);
            this.clbTables.TabIndex = 3;
            // 
            // btnStartSync
            // 
            this.btnStartSync.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnStartSync.Location = new System.Drawing.Point(250, 81);
            this.btnStartSync.Name = "btnStartSync";
            this.btnStartSync.Size = new System.Drawing.Size(75, 23);
            this.btnStartSync.TabIndex = 4;
            this.btnStartSync.Text = "btnStartSync";
            this.btnStartSync.UseVisualStyleBackColor = true;
            this.btnStartSync.Click += new System.EventHandler(this.btnStartSync_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Controls.Add(this.btnSync);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 10F);
            this.groupBox1.Location = new System.Drawing.Point(483, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 415);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSync
            // 
            this.btnSync.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnSync.Location = new System.Drawing.Point(77, 32);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(122, 66);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtLog.Location = new System.Drawing.Point(6, 104);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(412, 311);
            this.txtLog.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLog1);
            this.groupBox2.Controls.Add(this.clbTables);
            this.groupBox2.Controls.Add(this.btnStartSync);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 10F);
            this.groupBox2.Location = new System.Drawing.Point(33, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 415);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtLog1;
        private System.Windows.Forms.CheckedListBox clbTables;
        private System.Windows.Forms.Button btnStartSync;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}