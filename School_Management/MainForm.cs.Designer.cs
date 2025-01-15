namespace School_Management
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnManageTeachers = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnManageClasses = new System.Windows.Forms.Button();
            this.btnEnterGrades = new System.Windows.Forms.Button();
            this.btnTrackAttendance = new System.Windows.Forms.Button();
            this.btnManageSubjects = new System.Windows.Forms.Button();
            this.btnManageTimetable = new System.Windows.Forms.Button();
            this.btnManageParents = new System.Windows.Forms.Button();
            this.btnManageActivities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(538, 101);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(95, 42);
            this.btnManageStudents.TabIndex = 1;
            this.btnManageStudents.Text = "إدارة الطلبة";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click_1);
            // 
            // btnManageTeachers
            // 
            this.btnManageTeachers.Location = new System.Drawing.Point(662, 170);
            this.btnManageTeachers.Name = "btnManageTeachers";
            this.btnManageTeachers.Size = new System.Drawing.Size(83, 42);
            this.btnManageTeachers.TabIndex = 2;
            this.btnManageTeachers.Text = "إدارة الاساتذة";
            this.btnManageTeachers.UseVisualStyleBackColor = true;
            this.btnManageTeachers.Click += new System.EventHandler(this.btnManageTeachers_Click_1);
            // 
            // btnViewReports
            // 
            this.btnViewReports.Location = new System.Drawing.Point(526, 293);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(84, 30);
            this.btnViewReports.TabIndex = 3;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(431, 375);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(431, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = " Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnManageClasses
            // 
            this.btnManageClasses.Location = new System.Drawing.Point(378, 101);
            this.btnManageClasses.Name = "btnManageClasses";
            this.btnManageClasses.Size = new System.Drawing.Size(83, 42);
            this.btnManageClasses.TabIndex = 6;
            this.btnManageClasses.Text = "ادارة الصفوف";
            this.btnManageClasses.UseVisualStyleBackColor = true;
            this.btnManageClasses.Click += new System.EventHandler(this.btnManageClasses_Click_1);
            // 
            // btnEnterGrades
            // 
            this.btnEnterGrades.Location = new System.Drawing.Point(539, 356);
            this.btnEnterGrades.Name = "btnEnterGrades";
            this.btnEnterGrades.Size = new System.Drawing.Size(83, 42);
            this.btnEnterGrades.TabIndex = 7;
            this.btnEnterGrades.Text = "Enter Grades";
            this.btnEnterGrades.UseVisualStyleBackColor = true;
            this.btnEnterGrades.Click += new System.EventHandler(this.btnEnterGrades_Click_1);
            // 
            // btnTrackAttendance
            // 
            this.btnTrackAttendance.Location = new System.Drawing.Point(538, 224);
            this.btnTrackAttendance.Name = "btnTrackAttendance";
            this.btnTrackAttendance.Size = new System.Drawing.Size(83, 42);
            this.btnTrackAttendance.TabIndex = 8;
            this.btnTrackAttendance.Text = "Track Attendance";
            this.btnTrackAttendance.UseVisualStyleBackColor = true;
            this.btnTrackAttendance.Click += new System.EventHandler(this.btnTrackAttendance_Click_1);
            // 
            // btnManageSubjects
            // 
            this.btnManageSubjects.Location = new System.Drawing.Point(662, 101);
            this.btnManageSubjects.Name = "btnManageSubjects";
            this.btnManageSubjects.Size = new System.Drawing.Size(83, 42);
            this.btnManageSubjects.TabIndex = 9;
            this.btnManageSubjects.Text = "إدارة المواد";
            this.btnManageSubjects.UseVisualStyleBackColor = true;
            this.btnManageSubjects.Click += new System.EventHandler(this.btnManageSubjects_Click_1);
            // 
            // btnManageTimetable
            // 
            this.btnManageTimetable.Location = new System.Drawing.Point(662, 293);
            this.btnManageTimetable.Name = "btnManageTimetable";
            this.btnManageTimetable.Size = new System.Drawing.Size(83, 42);
            this.btnManageTimetable.TabIndex = 10;
            this.btnManageTimetable.Text = "Manage Timetable";
            this.btnManageTimetable.UseVisualStyleBackColor = true;
            this.btnManageTimetable.Click += new System.EventHandler(this.btnManageTimetable_Click_1);
            // 
            // btnManageParents
            // 
            this.btnManageParents.Location = new System.Drawing.Point(391, 164);
            this.btnManageParents.Name = "btnManageParents";
            this.btnManageParents.Size = new System.Drawing.Size(92, 42);
            this.btnManageParents.TabIndex = 11;
            this.btnManageParents.Text = "ادارة اولياء الامر";
            this.btnManageParents.UseVisualStyleBackColor = true;
            this.btnManageParents.Click += new System.EventHandler(this.btnManageParents_Click_1);
            // 
            // btnManageActivities
            // 
            this.btnManageActivities.Location = new System.Drawing.Point(662, 356);
            this.btnManageActivities.Name = "btnManageActivities";
            this.btnManageActivities.Size = new System.Drawing.Size(83, 42);
            this.btnManageActivities.TabIndex = 12;
            this.btnManageActivities.Text = "Manage Activities";
            this.btnManageActivities.UseVisualStyleBackColor = true;
            this.btnManageActivities.Click += new System.EventHandler(this.btnManageActivities_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageActivities);
            this.Controls.Add(this.btnManageParents);
            this.Controls.Add(this.btnManageTimetable);
            this.Controls.Add(this.btnManageSubjects);
            this.Controls.Add(this.btnTrackAttendance);
            this.Controls.Add(this.btnEnterGrades);
            this.Controls.Add(this.btnManageClasses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnManageTeachers);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnManageTeachers;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnManageClasses;
        private System.Windows.Forms.Button btnEnterGrades;
        private System.Windows.Forms.Button btnTrackAttendance;
        private System.Windows.Forms.Button btnManageSubjects;
        private System.Windows.Forms.Button btnManageTimetable;
        private System.Windows.Forms.Button btnManageParents;
        private System.Windows.Forms.Button btnManageActivities;
    }
}