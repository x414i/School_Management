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
            // Initialize the main form components or settings
        }

        private void btnManageStudents_Click_1(object sender, EventArgs e)
        {
            //  Open the Student Management form
           StudentManagementForm studentForm = new StudentManagementForm();
            studentForm.ShowDialog();
        }

        private void btnManageTeachers_Click_1(object sender, EventArgs e)
        {
            // Open the Teacher Management form
            TeacherManagementForm teacherForm = new TeacherManagementForm();
            teacherForm.ShowDialog();
        }

        private void btnManageClasses_Click_1(object sender, EventArgs e)
        {
            // Open the Class Management form
            ClassManagementForm classForm = new ClassManagementForm();
            classForm.ShowDialog();
        }

        private void btnManageSubjects_Click_1(object sender, EventArgs e)
        {
            // Open the Subject Management form
            SubjectManagementForm subjectForm = new SubjectManagementForm();
            subjectForm.ShowDialog();
        }

        private void btnTrackAttendance_Click_1(object sender, EventArgs e)
        {
            // Open the Attendance Tracking form
            AttendanceTrackingForm attendanceForm = new AttendanceTrackingForm();
            attendanceForm.ShowDialog();
        }

        private void btnEnterGrades_Click_1(object sender, EventArgs e)
        {
            // Open the Grades Entry form
            GradesEntryForm gradesForm = new GradesEntryForm();
            gradesForm.ShowDialog();
        }

        private void btnManageParents_Click_1(object sender, EventArgs e)
        {
            // Open the Parent Management form
            ParentManagementForm parentForm = new ParentManagementForm();
            parentForm.ShowDialog();
        }

        private void btnManageTimetable_Click_1(object sender, EventArgs e)
        {
            // Open the Timetable Management form
            TimetableManagementForm timetableForm = new TimetableManagementForm();
            timetableForm.ShowDialog();
        }

        private void btnManageActivities_Click_1(object sender, EventArgs e)
        {
            // Open the Activities Management form
            ActivitiesManagementForm activitiesForm = new ActivitiesManagementForm();
            activitiesForm.ShowDialog();
        }

        private void btnViewReports_Click_1(object sender, EventArgs e)
        {
            // Open the Reports form
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            // Logout and return to the login form
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        //private void btnManageStudents_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnManageTeachers_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnManageSubjects_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnViewReports_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnTrackAttendance_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnManageParents_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnManageClasses_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnManageTimetable_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnExit_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnManageActivities_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnEnterGrades_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnLogout_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
