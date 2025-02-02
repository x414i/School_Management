using System;
using System.Windows.Forms;

namespace School_Management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnManageStudents_Click_1(object sender, EventArgs e)
        {
           StudentManagementForm studentForm = new StudentManagementForm();
            studentForm.ShowDialog();
        }

        private void btnManageTeachers_Click_1(object sender, EventArgs e)
        {
            TeacherManagementForm teacherForm = new TeacherManagementForm();
            teacherForm.ShowDialog();
        }

        private void btnManageClasses_Click_1(object sender, EventArgs e)
        {
            ClassManagementForm classForm = new ClassManagementForm();
            classForm.ShowDialog();
        }

        private void btnManageSubjects_Click_1(object sender, EventArgs e)
        {
            SubjectManagementForm subjectForm = new SubjectManagementForm();
            subjectForm.ShowDialog();
        }

        private void btnTrackAttendance_Click_1(object sender, EventArgs e)
        {
            AttendanceTrackingForm attendanceForm = new AttendanceTrackingForm();
            attendanceForm.ShowDialog();
        }

        private void btnEnterGrades_Click_1(object sender, EventArgs e)
        {
            GradesEntryForm gradesForm = new GradesEntryForm();
            gradesForm.ShowDialog();
        }

        private void btnManageParents_Click_1(object sender, EventArgs e)
        {
            ParentManagementForm parentForm = new ParentManagementForm();
            parentForm.ShowDialog();
        }

        private void btnManageTimetable_Click_1(object sender, EventArgs e)
        {
            TimetableManagementForm timetableForm = new TimetableManagementForm();
            timetableForm.ShowDialog();
        }

        private void btnManageActivities_Click_1(object sender, EventArgs e)
        {
            ActivitiesManagementForm activitiesForm = new ActivitiesManagementForm();
            activitiesForm.ShowDialog();
        }

        private void btnViewReports_Click_1(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUserForm userForm = new AddUserForm();
            userForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SyncDB syncDB = new SyncDB();
            syncDB.ShowDialog();
        }

        private void syncTimer_Click(object sender, EventArgs e)
        {
            SchoolManagementSyncApp schoolManagementSyncApp = new SchoolManagementSyncApp();
            schoolManagementSyncApp.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
