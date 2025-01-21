namespace School_Management
{
    partial class TimetableManagementForm
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
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.المادة = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimetableID = new System.Windows.Forms.TextBox();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.btnEditLesson = new System.Windows.Forms.Button();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.btnSaveLesson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimetable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.Subject,
            this.Teacher,
            this.Day,
            this.Time});
            this.dgvTimetable.Location = new System.Drawing.Point(0, 291);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.ReadOnly = true;
            this.dgvTimetable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTimetable.Size = new System.Drawing.Size(803, 207);
            this.dgvTimetable.TabIndex = 0;
            // 
            // Class
            // 
            this.Class.HeaderText = "الصف";
            this.Class.Name = "Class";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "المادة";
            this.Subject.Name = "Subject";
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "المعلم";
            this.Teacher.Name = "Teacher";
            // 
            // Day
            // 
            this.Day.HeaderText = "اليوم";
            this.Day.Name = "Day";
            // 
            // Time
            // 
            this.Time.HeaderText = "الوقت";
            this.Time.Name = "Time";
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("Cairo", 10F);
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(120, 58);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(296, 32);
            this.cmbDay.TabIndex = 1;
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Cairo", 10F);
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(120, 141);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(296, 32);
            this.cmbSubject.TabIndex = 2;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.Font = new System.Drawing.Font("Cairo", 10F);
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(120, 11);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(296, 32);
            this.cmbTeacher.TabIndex = 3;
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Cairo", 10F);
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(120, 101);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(296, 32);
            this.cmbClass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 10F);
            this.label1.Location = new System.Drawing.Point(444, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "الصف";
            // 
            // المادة
            // 
            this.المادة.AutoSize = true;
            this.المادة.Font = new System.Drawing.Font("Cairo", 10F);
            this.المادة.Location = new System.Drawing.Point(443, 144);
            this.المادة.Name = "المادة";
            this.المادة.Size = new System.Drawing.Size(48, 26);
            this.المادة.TabIndex = 6;
            this.المادة.Text = "المادة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 10F);
            this.label3.Location = new System.Drawing.Point(444, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "المعلم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 10F);
            this.label4.Location = new System.Drawing.Point(454, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "اليوم";
            // 
            // txtTimetableID
            // 
            this.txtTimetableID.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtTimetableID.Location = new System.Drawing.Point(120, 186);
            this.txtTimetableID.Name = "txtTimetableID";
            this.txtTimetableID.Size = new System.Drawing.Size(296, 32);
            this.txtTimetableID.TabIndex = 9;
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnAddLesson.Location = new System.Drawing.Point(155, 11);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(91, 34);
            this.btnAddLesson.TabIndex = 10;
            this.btnAddLesson.Text = "إضافة حصة جديدة";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // btnEditLesson
            // 
            this.btnEditLesson.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnEditLesson.Location = new System.Drawing.Point(42, 11);
            this.btnEditLesson.Name = "btnEditLesson";
            this.btnEditLesson.Size = new System.Drawing.Size(107, 34);
            this.btnEditLesson.TabIndex = 11;
            this.btnEditLesson.Text = "تعديل ";
            this.btnEditLesson.UseVisualStyleBackColor = true;
            this.btnEditLesson.Click += new System.EventHandler(this.btnEditLesson_Click);
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnDeleteLesson.Location = new System.Drawing.Point(155, 61);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(91, 39);
            this.btnDeleteLesson.TabIndex = 12;
            this.btnDeleteLesson.Text = "حذف";
            this.btnDeleteLesson.UseVisualStyleBackColor = true;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // btnSaveLesson
            // 
            this.btnSaveLesson.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnSaveLesson.Location = new System.Drawing.Point(42, 51);
            this.btnSaveLesson.Name = "btnSaveLesson";
            this.btnSaveLesson.Size = new System.Drawing.Size(107, 43);
            this.btnSaveLesson.TabIndex = 13;
            this.btnSaveLesson.Text = "حفظ";
            this.btnSaveLesson.UseVisualStyleBackColor = true;
            this.btnSaveLesson.Click += new System.EventHandler(this.btnSaveLesson_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnClose.Location = new System.Drawing.Point(63, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 35);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddLesson);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnEditLesson);
            this.panel1.Controls.Add(this.btnSaveLesson);
            this.panel1.Controls.Add(this.btnDeleteLesson);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 221);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbTeacher);
            this.panel2.Controls.Add(this.txtTimetableID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbSubject);
            this.panel2.Controls.Add(this.المادة);
            this.panel2.Controls.Add(this.cmbDay);
            this.panel2.Controls.Add(this.cmbClass);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(271, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 227);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.Location = new System.Drawing.Point(443, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "الوقت";
            // 
            // TimetableManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTimetable);
            this.Name = "TimetableManagementForm";
            this.Text = "TimetableManagementForm";
            this.Load += new System.EventHandler(this.TimetableManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label المادة;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimetableID;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.Button btnEditLesson;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.Button btnSaveLesson;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}