using System;
using System.Windows.Forms;
using System.Data.SqlClient;

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

                    dgvTimetable.DataSource = dataTable;

                    // إخفاء عمود TimetableID
                    if (dgvTimetable.Columns["TimetableID"] != null)
                    {
                        dgvTimetable.Columns["TimetableID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the timetable: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void LoadTimetable()
        //{
        //    try
        //    {
        //        string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            string query = "SELECT TimetableID, ClassName, SubjectName, TeacherName, Day, Time FROM Timetable";
        //            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //            System.Data.DataTable dataTable = new System.Data.DataTable();
        //            adapter.Fill(dataTable);

        //            // إعداد DataGridView
        //            dgvTimetable.DataSource = dataTable;

        //            // إخفاء عمود TimetableID
        //            if (dgvTimetable.Columns["TimetableID"] != null)
        //            {
        //                dgvTimetable.Columns["TimetableID"].Visible = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while loading the timetable: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //private void LoadTimetable()
        //{
        //    try
        //    {
        //        string connectionString = "Server=YOUR_SERVER_NAME;Database=SchoolManagement;Trusted_Connection=True;";
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            string query = "SELECT TimetableID, ClassName, SubjectName, TeacherName, Day, Time FROM Timetable";
        //            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //            System.Data.DataTable dataTable = new System.Data.DataTable();
        //            adapter.Fill(dataTable);
        //            dgvTimetable.DataSource = dataTable;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while loading the timetable: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading dropdown data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            if (dgvTimetable.SelectedRows.Count > 0)
            {
                cmbClass.Text = dgvTimetable.SelectedRows[0].Cells["ClassName"].Value.ToString();
                cmbSubject.Text = dgvTimetable.SelectedRows[0].Cells["SubjectName"].Value.ToString();
                cmbTeacher.Text = dgvTimetable.SelectedRows[0].Cells["TeacherName"].Value.ToString();
                cmbDay.Text = dgvTimetable.SelectedRows[0].Cells["Day"].Value.ToString();
                txtTimetableID.Text = dgvTimetable.SelectedRows[0].Cells["Time"].Value.ToString();

                // الحصول على TimetableID من الجدول
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


        //private void btnEditLesson_Click(object sender, EventArgs e)
        //{
        //    if (dgvTimetable.SelectedRows.Count > 0)
        //    {
        //        cmbClass.Text = dgvTimetable.SelectedRows[0].Cells["ClassName"].Value.ToString();
        //        cmbSubject.Text = dgvTimetable.SelectedRows[0].Cells["SubjectName"].Value.ToString();
        //        cmbTeacher.Text = dgvTimetable.SelectedRows[0].Cells["TeacherName"].Value.ToString();
        //        cmbDay.Text = dgvTimetable.SelectedRows[0].Cells["Day"].Value.ToString();
        //        txtTime.Text = dgvTimetable.SelectedRows[0].Cells["Time"].Value.ToString();
        //        txtTimetableID.Text = dgvTimetable.SelectedRows[0].Cells["TimetableID"].Value.ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a lesson to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //private void btnDeleteLesson_Click(object sender, EventArgs e)
        //{
        //    if (dgvTimetable.SelectedRows.Count > 0)
        //    {
        //        int timetableID = Convert.ToInt32(dgvTimetable.SelectedRows[0].Cells["TimetableID"].Value);

        //        try
        //        {
        //            string connectionString = "Server=YOUR_SERVER_NAME;Database=SchoolManagement;Trusted_Connection=True;";
        //            using (SqlConnection connection = new SqlConnection(connectionString))
        //            {
        //                connection.Open();
        //                string query = "DELETE FROM Timetable WHERE TimetableID = @TimetableID";
        //                SqlCommand command = new SqlCommand(query, connection);
        //                command.Parameters.AddWithValue("@TimetableID", timetableID);
        //                command.ExecuteNonQuery();
        //                MessageBox.Show("Lesson deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                LoadTimetable();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a lesson to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        private void btnSaveLesson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbClass.Text) || string.IsNullOrEmpty(cmbSubject.Text) || string.IsNullOrEmpty(cmbTeacher.Text) || string.IsNullOrEmpty(cmbDay.Text) || string.IsNullOrEmpty(txtTimetableID.Text))
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

                    if (string.IsNullOrEmpty(txtTimetableID.Text))
                    {
                         query = @"
                                    INSERT INTO Timetable (ClassID, SubjectID, TeacherID, Day, Time)
                                    VALUES (
                                        (SELECT ClassID FROM Classes WHERE ClassName = @ClassName),
                                        (SELECT SubjectID FROM Subjects WHERE SubjectName = @SubjectName),
                                        (SELECT TeacherID FROM Teachers WHERE Name = @TeacherName),
                                                                                                    @Day,@Time)";
                    }
                    else
                    {
                        query = "UPDATE Timetable SET ClassName = @ClassName, SubjectName = @SubjectName, Name = @TeacherName, Day = @Day, Time = @Time WHERE TimetableID = @TimetableID";
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassName", cmbClass.Text);
                    command.Parameters.AddWithValue("@SubjectName", cmbSubject.Text);
                    command.Parameters.AddWithValue("@TeacherName", cmbTeacher.Text);
                    command.Parameters.AddWithValue("@Day", cmbDay.Text);
                    command.Parameters.AddWithValue("@Time", txtTimetableID.Text);

                    if (!string.IsNullOrEmpty(txtTimetableID.Text))
                    {
                        command.Parameters.AddWithValue("@TimetableID", Convert.ToInt32(txtTimetableID.Text));
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
            txtTimetableID.Clear();
            cmbClass.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;
            cmbDay.SelectedIndex = -1;
            txtTimetableID.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
