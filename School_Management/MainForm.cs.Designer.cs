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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.syncTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "الشاشة الرئيسية";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManageStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageStudents.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnManageStudents.ForeColor = System.Drawing.Color.Black;
            this.btnManageStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnManageStudents.Image")));
            this.btnManageStudents.Location = new System.Drawing.Point(380, 277);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(120, 100);
            this.btnManageStudents.TabIndex = 1;
            this.btnManageStudents.Text = "إدارة الطلبة";
            this.btnManageStudents.UseVisualStyleBackColor = false;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click_1);
            // 
            // btnManageTeachers
            // 
            this.btnManageTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManageTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageTeachers.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnManageTeachers.ForeColor = System.Drawing.Color.Black;
            this.btnManageTeachers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageTeachers.Image")));
            this.btnManageTeachers.Location = new System.Drawing.Point(758, 171);
            this.btnManageTeachers.Name = "btnManageTeachers";
            this.btnManageTeachers.Size = new System.Drawing.Size(120, 100);
            this.btnManageTeachers.TabIndex = 2;
            this.btnManageTeachers.Text = "إدارة الاساتذة";
            this.btnManageTeachers.UseVisualStyleBackColor = false;
            this.btnManageTeachers.Click += new System.EventHandler(this.btnManageTeachers_Click_1);
            // 
            // btnViewReports
            // 
            this.btnViewReports.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnViewReports.Image = ((System.Drawing.Image)(resources.GetObject("btnViewReports.Image")));
            this.btnViewReports.Location = new System.Drawing.Point(254, 277);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(120, 100);
            this.btnViewReports.TabIndex = 3;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = true;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(2, 277);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 100);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(2, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 100);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = " Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnManageClasses
            // 
            this.btnManageClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManageClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageClasses.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnManageClasses.ForeColor = System.Drawing.Color.Black;
            this.btnManageClasses.Image = ((System.Drawing.Image)(resources.GetObject("btnManageClasses.Image")));
            this.btnManageClasses.Location = new System.Drawing.Point(632, 277);
            this.btnManageClasses.Name = "btnManageClasses";
            this.btnManageClasses.Size = new System.Drawing.Size(120, 100);
            this.btnManageClasses.TabIndex = 6;
            this.btnManageClasses.Text = "ادارة الصفوف";
            this.btnManageClasses.UseVisualStyleBackColor = false;
            this.btnManageClasses.Click += new System.EventHandler(this.btnManageClasses_Click_1);
            // 
            // btnEnterGrades
            // 
            this.btnEnterGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnterGrades.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnEnterGrades.Image = ((System.Drawing.Image)(resources.GetObject("btnEnterGrades.Image")));
            this.btnEnterGrades.Location = new System.Drawing.Point(758, 398);
            this.btnEnterGrades.Name = "btnEnterGrades";
            this.btnEnterGrades.Size = new System.Drawing.Size(120, 100);
            this.btnEnterGrades.TabIndex = 7;
            this.btnEnterGrades.Text = "درجات";
            this.btnEnterGrades.UseVisualStyleBackColor = false;
            this.btnEnterGrades.Click += new System.EventHandler(this.btnEnterGrades_Click_1);
            // 
            // btnTrackAttendance
            // 
            this.btnTrackAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrackAttendance.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnTrackAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrackAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnTrackAttendance.Image")));
            this.btnTrackAttendance.Location = new System.Drawing.Point(506, 398);
            this.btnTrackAttendance.Name = "btnTrackAttendance";
            this.btnTrackAttendance.Size = new System.Drawing.Size(120, 100);
            this.btnTrackAttendance.TabIndex = 8;
            this.btnTrackAttendance.Text = "الحضور";
            this.btnTrackAttendance.UseVisualStyleBackColor = false;
            this.btnTrackAttendance.Click += new System.EventHandler(this.btnTrackAttendance_Click_1);
            // 
            // btnManageSubjects
            // 
            this.btnManageSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManageSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSubjects.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnManageSubjects.ForeColor = System.Drawing.Color.Black;
            this.btnManageSubjects.Image = ((System.Drawing.Image)(resources.GetObject("btnManageSubjects.Image")));
            this.btnManageSubjects.Location = new System.Drawing.Point(506, 277);
            this.btnManageSubjects.Name = "btnManageSubjects";
            this.btnManageSubjects.Size = new System.Drawing.Size(120, 100);
            this.btnManageSubjects.TabIndex = 9;
            this.btnManageSubjects.Text = "إدارة المواد";
            this.btnManageSubjects.UseVisualStyleBackColor = false;
            this.btnManageSubjects.Click += new System.EventHandler(this.btnManageSubjects_Click_1);
            // 
            // btnManageTimetable
            // 
            this.btnManageTimetable.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnManageTimetable.Image = ((System.Drawing.Image)(resources.GetObject("btnManageTimetable.Image")));
            this.btnManageTimetable.Location = new System.Drawing.Point(380, 398);
            this.btnManageTimetable.Name = "btnManageTimetable";
            this.btnManageTimetable.Size = new System.Drawing.Size(120, 100);
            this.btnManageTimetable.TabIndex = 10;
            this.btnManageTimetable.Text = "الجدول الزمني";
            this.btnManageTimetable.UseVisualStyleBackColor = true;
            this.btnManageTimetable.Click += new System.EventHandler(this.btnManageTimetable_Click_1);
            // 
            // btnManageParents
            // 
            this.btnManageParents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManageParents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageParents.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnManageParents.ForeColor = System.Drawing.Color.Black;
            this.btnManageParents.Image = ((System.Drawing.Image)(resources.GetObject("btnManageParents.Image")));
            this.btnManageParents.Location = new System.Drawing.Point(758, 277);
            this.btnManageParents.Name = "btnManageParents";
            this.btnManageParents.Size = new System.Drawing.Size(120, 100);
            this.btnManageParents.TabIndex = 11;
            this.btnManageParents.Text = "ادارة اولياء الامر";
            this.btnManageParents.UseVisualStyleBackColor = false;
            this.btnManageParents.Click += new System.EventHandler(this.btnManageParents_Click_1);
            // 
            // btnManageActivities
            // 
            this.btnManageActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManageActivities.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnManageActivities.Image = ((System.Drawing.Image)(resources.GetObject("btnManageActivities.Image")));
            this.btnManageActivities.Location = new System.Drawing.Point(632, 398);
            this.btnManageActivities.Name = "btnManageActivities";
            this.btnManageActivities.Size = new System.Drawing.Size(120, 100);
            this.btnManageActivities.TabIndex = 12;
            this.btnManageActivities.Text = "Manage Activities";
            this.btnManageActivities.UseVisualStyleBackColor = false;
            this.btnManageActivities.Click += new System.EventHandler(this.btnManageActivities_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Cairo", 10F);
            this.button1.Location = new System.Drawing.Point(128, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 100);
            this.button1.TabIndex = 14;
            this.button1.Text = "Users";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSync
            // 
            this.btnSync.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnSync.Location = new System.Drawing.Point(254, 398);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(120, 100);
            this.btnSync.TabIndex = 15;
            this.btnSync.Text = "btnSync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.button2_Click);
            // 
            // syncTimer
            // 
            this.syncTimer.Font = new System.Drawing.Font("Cairo", 10F);
            this.syncTimer.Location = new System.Drawing.Point(128, 398);
            this.syncTimer.Name = "syncTimer";
            this.syncTimer.Size = new System.Drawing.Size(120, 100);
            this.syncTimer.TabIndex = 16;
            this.syncTimer.Text = "syncTimer";
            this.syncTimer.UseVisualStyleBackColor = true;
            this.syncTimer.Click += new System.EventHandler(this.syncTimer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 501);
            this.Controls.Add(this.btnManageClasses);
            this.Controls.Add(this.btnManageTeachers);
            this.Controls.Add(this.btnManageSubjects);
            this.Controls.Add(this.syncTimer);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnManageParents);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManageActivities);
            this.Controls.Add(this.btnManageTimetable);
            this.Controls.Add(this.btnTrackAttendance);
            this.Controls.Add(this.btnEnterGrades);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewReports);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button syncTimer;
    }
}