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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.Subject,
            this.Teacher,
            this.Day,
            this.Time});
            this.dgvTimetable.Location = new System.Drawing.Point(-1, 277);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.Size = new System.Drawing.Size(431, 150);
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
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(216, 131);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(121, 21);
            this.cmbDay.TabIndex = 1;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(38, 131);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(121, 21);
            this.cmbSubject.TabIndex = 2;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(235, 43);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(121, 21);
            this.cmbTeacher.TabIndex = 3;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(38, 43);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "الصف";
            // 
            // المادة
            // 
            this.المادة.AutoSize = true;
            this.المادة.Location = new System.Drawing.Point(178, 131);
            this.المادة.Name = "المادة";
            this.المادة.Size = new System.Drawing.Size(33, 13);
            this.المادة.TabIndex = 6;
            this.المادة.Text = "المادة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "المعلم";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "اليوم";
            // 
            // txtTimetableID
            // 
            this.txtTimetableID.Location = new System.Drawing.Point(106, 199);
            this.txtTimetableID.Name = "txtTimetableID";
            this.txtTimetableID.Size = new System.Drawing.Size(100, 20);
            this.txtTimetableID.TabIndex = 9;
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(335, 244);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(75, 23);
            this.btnAddLesson.TabIndex = 10;
            this.btnAddLesson.Text = "إضافة حصة جديدة";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // btnEditLesson
            // 
            this.btnEditLesson.Location = new System.Drawing.Point(252, 244);
            this.btnEditLesson.Name = "btnEditLesson";
            this.btnEditLesson.Size = new System.Drawing.Size(75, 23);
            this.btnEditLesson.TabIndex = 11;
            this.btnEditLesson.Text = "Edit Lesson";
            this.btnEditLesson.UseVisualStyleBackColor = true;
            this.btnEditLesson.Click += new System.EventHandler(this.btnEditLesson_Click);
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.Location = new System.Drawing.Point(171, 244);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLesson.TabIndex = 12;
            this.btnDeleteLesson.Text = "Delete Lesson";
            this.btnDeleteLesson.UseVisualStyleBackColor = true;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // btnSaveLesson
            // 
            this.btnSaveLesson.Location = new System.Drawing.Point(80, 248);
            this.btnSaveLesson.Name = "btnSaveLesson";
            this.btnSaveLesson.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLesson.TabIndex = 13;
            this.btnSaveLesson.Text = "Save Lesson";
            this.btnSaveLesson.UseVisualStyleBackColor = true;
            this.btnSaveLesson.Click += new System.EventHandler(this.btnSaveLesson_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(-1, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TimetableManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveLesson);
            this.Controls.Add(this.btnDeleteLesson);
            this.Controls.Add(this.btnEditLesson);
            this.Controls.Add(this.btnAddLesson);
            this.Controls.Add(this.txtTimetableID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.المادة);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.dgvTimetable);
            this.Name = "TimetableManagementForm";
            this.Text = "TimetableManagementForm";
            this.Load += new System.EventHandler(this.TimetableManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}