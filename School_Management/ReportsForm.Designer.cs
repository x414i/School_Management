namespace School_Management
{
    partial class ReportsForm
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
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnExportToPDF = new System.Windows.Forms.Button();
            this.btnSyncReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbReportType
            // 
            this.cmbReportType.Font = new System.Drawing.Font("Cairo", 10F);
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(108, 62);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbReportType.Size = new System.Drawing.Size(397, 32);
            this.cmbReportType.TabIndex = 0;
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(154, 220);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReport.Size = new System.Drawing.Size(706, 329);
            this.dgvReport.TabIndex = 2;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Location = new System.Drawing.Point(3, 72);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnShowReport.Size = new System.Drawing.Size(121, 60);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "تحديث";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // btnExportReport
            // 
            this.btnExportReport.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportReport.Location = new System.Drawing.Point(3, 3);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExportReport.Size = new System.Drawing.Size(121, 63);
            this.btnExportReport.TabIndex = 4;
            this.btnExportReport.Text = "إكسيل";
            this.btnExportReport.UseVisualStyleBackColor = true;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // btnExportToPDF
            // 
            this.btnExportToPDF.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPDF.Location = new System.Drawing.Point(3, 138);
            this.btnExportToPDF.Name = "btnExportToPDF";
            this.btnExportToPDF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExportToPDF.Size = new System.Drawing.Size(121, 60);
            this.btnExportToPDF.TabIndex = 5;
            this.btnExportToPDF.Text = "PDF";
            this.btnExportToPDF.UseVisualStyleBackColor = true;
            this.btnExportToPDF.Click += new System.EventHandler(this.btnExportToPDF_Click);
            // 
            // btnSyncReport
            // 
            this.btnSyncReport.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncReport.Location = new System.Drawing.Point(3, 204);
            this.btnSyncReport.Name = "btnSyncReport";
            this.btnSyncReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSyncReport.Size = new System.Drawing.Size(121, 60);
            this.btnSyncReport.TabIndex = 6;
            this.btnSyncReport.Text = "تقرير المزامنة";
            this.btnSyncReport.UseVisualStyleBackColor = true;
            this.btnSyncReport.Click += new System.EventHandler(this.btnSyncReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.Location = new System.Drawing.Point(562, 62);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "نوع التقرير";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.cmbReportType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(154, 103);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(706, 111);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 10F);
            this.label4.Location = new System.Drawing.Point(562, 18);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "التاريخ من";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Cairo", 10F);
            this.dtpStartDate.Location = new System.Drawing.Point(339, 18);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpStartDate.Size = new System.Drawing.Size(166, 32);
            this.dtpStartDate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 10F);
            this.label3.Location = new System.Drawing.Point(299, 22);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(30, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "الى";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Cairo", 10F);
            this.dtpEndDate.Location = new System.Drawing.Point(108, 18);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpEndDate.Size = new System.Drawing.Size(178, 32);
            this.dtpEndDate.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnExportReport);
            this.panel2.Controls.Add(this.btnShowReport);
            this.panel2.Controls.Add(this.btnSyncReport);
            this.panel2.Controls.Add(this.btnExportToPDF);
            this.panel2.Location = new System.Drawing.Point(12, 217);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(136, 332);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 269);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(121, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "تقرير المزامنة";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(108, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "التقارير";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvReport);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnExportToPDF;
        private System.Windows.Forms.Button btnSyncReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}