using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace School_Management
{
    public partial class TimetableManagementForm : Form
    {
        public TimetableManagementForm()
        {
            InitializeComponent();
        }
        private void TimetableManagementForm_Load(object sender, EventArgs e)
        {
            LoadTimetable();
            LoadDropdowns();
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //panel1.BackColor = ThemeColor.SecondaryColor;
            //panel1.BackColor = ThemeColor.PrimaryColor;
        }
        private void LoadTimetable()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    Timetable.TimetableID, 
                    Classes.ClassName, 
                    Subjects.SubjectName, 
                    Teachers.Name AS TeacherName, 
                    Timetable.Day, 
                    Timetable.Time
                FROM Timetable
                INNER JOIN Classes ON Timetable.ClassID = Classes.ClassID
                INNER JOIN Subjects ON Timetable.SubjectID = Subjects.SubjectID
                INNER JOIN Teachers ON Timetable.TeacherID = Teachers.TeacherID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    dgvTimetable.DataSource = null;
                    dgvTimetable.Columns.Clear();

                    dgvTimetable.AutoGenerateColumns = true; 
                    dgvTimetable.DataSource = dataTable;

                    if (dgvTimetable.Columns["TimetableID"] != null)
                    {
                        dgvTimetable.Columns["TimetableID"].Visible = false;
                    }
                    if (dgvTimetable.Columns["ClassName"] != null)
                    {
                        dgvTimetable.Columns["ClassName"].HeaderText = " الصف";
                    }
                    if (dgvTimetable.Columns["SubjectName"] != null)
                    {
                        dgvTimetable.Columns["SubjectName"].HeaderText = " المادة";
                    }
                    if (dgvTimetable.Columns["TeacherName"] != null)
                    {
                        dgvTimetable.Columns["TeacherName"].HeaderText = " المعلم";
                    }
                    if (dgvTimetable.Columns["Day"] != null)
                    {
                        dgvTimetable.Columns["Day"].HeaderText = " اليوم";
                    }
                    if (dgvTimetable.Columns["Time"] != null)
                    {
                        dgvTimetable.Columns["Time"].HeaderText = " الوقت";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the timetable: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDropdowns()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Load Classes
                    string classQuery = "SELECT ClassName FROM Classes";
                    SqlCommand classCommand = new SqlCommand(classQuery, connection);
                    SqlDataReader classReader = classCommand.ExecuteReader();
                    while (classReader.Read())
                    {
                        cmbClass.Items.Add(classReader["ClassName"].ToString());
                    }
                    classReader.Close();

                    // Load Subjects
                    string subjectQuery = "SELECT SubjectName FROM Subjects";
                    SqlCommand subjectCommand = new SqlCommand(subjectQuery, connection);
                    SqlDataReader subjectReader = subjectCommand.ExecuteReader();
                    while (subjectReader.Read())
                    {
                        cmbSubject.Items.Add(subjectReader["SubjectName"].ToString());
                    }
                    subjectReader.Close();

                    // Load Teachers
                    string teacherQuery = "SELECT Name FROM Teachers";
                    SqlCommand teacherCommand = new SqlCommand(teacherQuery, connection);
                    SqlDataReader teacherReader = teacherCommand.ExecuteReader();
                    while (teacherReader.Read())
                    {
                        cmbTeacher.Items.Add(teacherReader["Name"].ToString());
                    }
                    teacherReader.Close();
                }

                cmbDay.Items.Add("الاحد");
                cmbDay.Items.Add("الإثنين");
                cmbDay.Items.Add("الثلاثاء");
                cmbDay.Items.Add("الأربعاء");
                cmbDay.Items.Add("الخميس");

                cmbTime.Items.Add("08:00");
                cmbTime.Items.Add("09:00");
                cmbTime.Items.Add("10:00");
                cmbTime.Items.Add("11:00");
                cmbTime.Items.Add("12:00");
                cmbTime.Items.Add("13:00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading dropdown data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbClass.Text) || string.IsNullOrEmpty(cmbSubject.Text) || string.IsNullOrEmpty(cmbTeacher.Text) || string.IsNullOrEmpty(cmbDay.Text) || string.IsNullOrEmpty(cmbTime.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Timetable (ClassID, SubjectID, TeacherID, Day, Time)
                VALUES (
                    (SELECT ClassID FROM Classes WHERE ClassName = @ClassName),
                    (SELECT SubjectID FROM Subjects WHERE SubjectName = @SubjectName),
                    (SELECT TeacherID FROM Teachers WHERE Name = @TeacherName),
                    @Day, @Time)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassName", cmbClass.Text);
                    command.Parameters.AddWithValue("@SubjectName", cmbSubject.Text);
                    command.Parameters.AddWithValue("@TeacherName", cmbTeacher.Text);
                    command.Parameters.AddWithValue("@Day", cmbDay.Text);
                    command.Parameters.AddWithValue("@Time", cmbTime.Text); // استخدام الوقت المحدد

                    command.ExecuteNonQuery();
                    MessageBox.Show("Lesson added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadTimetable();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            if (dgvTimetable.SelectedRows.Count > 0)
            {
                cmbClass.Text = dgvTimetable.SelectedRows[0].Cells["ClassName"].Value.ToString();
                cmbSubject.Text = dgvTimetable.SelectedRows[0].Cells["SubjectName"].Value.ToString();
                cmbTeacher.Text = dgvTimetable.SelectedRows[0].Cells["TeacherName"].Value.ToString();
                cmbDay.Text = dgvTimetable.SelectedRows[0].Cells["Day"].Value.ToString();
                cmbTime.Text = dgvTimetable.SelectedRows[0].Cells["Time"].Value.ToString(); 

                var timetableID = dgvTimetable.SelectedRows[0].Cells["TimetableID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a lesson to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            if (dgvTimetable.SelectedRows.Count > 0)
            {
                int timetableID = Convert.ToInt32(dgvTimetable.SelectedRows[0].Cells["TimetableID"].Value);

                try
                {
                    string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Timetable WHERE TimetableID = @TimetableID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@TimetableID", timetableID);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Lesson deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTimetable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a lesson to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSaveLesson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbClass.Text) || string.IsNullOrEmpty(cmbSubject.Text) || string.IsNullOrEmpty(cmbTeacher.Text) || string.IsNullOrEmpty(cmbDay.Text) || string.IsNullOrEmpty(cmbTime.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    if (dgvTimetable.SelectedRows.Count == 0) 
                    {
                        query = @"
                    INSERT INTO Timetable (ClassID, SubjectID, TeacherID, Day, Time)
                    VALUES (
                        (SELECT ClassID FROM Classes WHERE ClassName = @ClassName),
                        (SELECT SubjectID FROM Subjects WHERE SubjectName = @SubjectName),
                        (SELECT TeacherID FROM Teachers WHERE Name = @TeacherName),
                        @Day, @Time)";
                    }
                    else
                    {
                        int timetableID = Convert.ToInt32(dgvTimetable.SelectedRows[0].Cells["TimetableID"].Value);
                        query = @"
                    UPDATE Timetable 
                    SET ClassID = (SELECT ClassID FROM Classes WHERE ClassName = @ClassName),
                        SubjectID = (SELECT SubjectID FROM Subjects WHERE SubjectName = @SubjectName),
                        TeacherID = (SELECT TeacherID FROM Teachers WHERE Name = @TeacherName),
                        Day = @Day, 
                        Time = @Time 
                    WHERE TimetableID = @TimetableID";
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassName", cmbClass.Text);
                    command.Parameters.AddWithValue("@SubjectName", cmbSubject.Text);
                    command.Parameters.AddWithValue("@TeacherName", cmbTeacher.Text);
                    command.Parameters.AddWithValue("@Day", cmbDay.Text);
                    command.Parameters.AddWithValue("@Time", cmbTime.Text); 

                    if (dgvTimetable.SelectedRows.Count > 0) 
                    {
                        int timetableID = Convert.ToInt32(dgvTimetable.SelectedRows[0].Cells["TimetableID"].Value);
                        command.Parameters.AddWithValue("@TimetableID", timetableID);
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Lesson information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTimetable();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            cmbClass.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;
            cmbDay.SelectedIndex = -1;
            cmbTime.SelectedIndex = -1;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
