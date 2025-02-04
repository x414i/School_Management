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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClasses
            // 
            this.cmbClasses.Font = new System.Drawing.Font("Cairo", 10F);
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(577, 44);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbClasses.Size = new System.Drawing.Size(444, 32);
            this.cmbClasses.TabIndex = 0;
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnLoadStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnLoadStudents.Image = global::School_Management.Properties.Resources.icons8_load_30;
            this.btnLoadStudents.Location = new System.Drawing.Point(329, 60);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLoadStudents.Size = new System.Drawing.Size(98, 64);
            this.btnLoadStudents.TabIndex = 1;
            this.btnLoadStudents.Text = "تحديث";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click_1);
            // 
            // btnSaveAttendance
            // 
            this.btnSaveAttendance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSaveAttendance.Image = global::School_Management.Properties.Resources.icons8_save_30;
            this.btnSaveAttendance.Location = new System.Drawing.Point(193, 60);
            this.btnSaveAttendance.Name = "btnSaveAttendance";
            this.btnSaveAttendance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSaveAttendance.Size = new System.Drawing.Size(98, 64);
            this.btnSaveAttendance.TabIndex = 2;
            this.btnSaveAttendance.Text = "حفظ";
            this.btnSaveAttendance.UseVisualStyleBackColor = true;
            this.btnSaveAttendance.Click += new System.EventHandler(this.btnSaveAttendance_Click_1);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Cairo", 10F);
            this.dtpDate.Location = new System.Drawing.Point(577, 92);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDate.Size = new System.Drawing.Size(444, 32);
            this.dtpDate.TabIndex = 4;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(0, 0);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStudents.Size = new System.Drawing.Size(1152, 568);
            this.dgvStudents.TabIndex = 5;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            this.dgvStudents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 10F);
            this.label1.Location = new System.Drawing.Point(1050, 42);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "الصف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.Location = new System.Drawing.Point(1068, 92);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(46, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "التاريخ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnLoadStudents);
            this.panel2.Controls.Add(this.btnSaveAttendance);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.cmbClasses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(1152, 172);
            this.panel2.TabIndex = 9;
            // 
            // AttendanceTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvStudents);
            this.Name = "AttendanceTrackingForm";
            this.Text = "AttendanceTrackingForm";
            this.Load += new System.EventHandler(this.AttendanceTrackingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}