namespace School_Management
{
    partial class SyncDB
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
            this.btnStartSync = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStartSync
            // 
            this.btnStartSync.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartSync.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnStartSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSync.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.btnStartSync.Image = global::School_Management.Properties.Resources.icons8_cloud_sync_32;
            this.btnStartSync.Location = new System.Drawing.Point(430, 31);
            this.btnStartSync.Name = "btnStartSync";
            this.btnStartSync.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnStartSync.Size = new System.Drawing.Size(233, 78);
            this.btnStartSync.TabIndex = 0;
            this.btnStartSync.Text = "بدء المزامنة";
            this.btnStartSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartSync.UseVisualStyleBackColor = true;
            this.btnStartSync.Click += new System.EventHandler(this.btnStartSync_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 137);
            this.txtLog.Name = "txtLog";
            this.txtLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLog.Size = new System.Drawing.Size(1152, 431);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // SyncDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1152, 568);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStartSync);
            this.Name = "SyncDB";
            this.Text = "المزامنة";
            this.Load += new System.EventHandler(this.SyncDB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartSync;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}