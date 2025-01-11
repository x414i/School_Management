namespace School_Management
{
    partial class AttendanceTrackingForm
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
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.btnSaveAttendance = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClasses
            // 
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(0, 0);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(121, 21);
            this.cmbClasses.TabIndex = 0;
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(0, 41);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(75, 23);
            this.btnLoadStudents.TabIndex = 1;
            this.btnLoadStudents.Text = "Load Students";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            // 
            // btnSaveAttendance
            // 
            this.btnSaveAttendance.Location = new System.Drawing.Point(130, 41);
            this.btnSaveAttendance.Name = "btnSaveAttendance";
            this.btnSaveAttendance.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAttendance.TabIndex = 2;
            this.btnSaveAttendance.Text = "Save Attendance";
            this.btnSaveAttendance.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(69, 70);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(32, 113);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(32, 208);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(240, 150);
            this.dgvStudents.TabIndex = 5;
            // 
            // AttendanceTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveAttendance);
            this.Controls.Add(this.btnLoadStudents);
            this.Controls.Add(this.cmbClasses);
            this.Name = "AttendanceTrackingForm";
            this.Text = "AttendanceTrackingForm";
            this.Load += new System.EventHandler(this.AttendanceTrackingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}