using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management
{
    public partial class GradesEntryForm : Form
    {
        public GradesEntryForm()
        {
            InitializeComponent();
        }

        private void GradesEntryForm_Load(object sender, EventArgs e)
        {
            LoadStudentsIntoDropdown();
            LoadSubjectsIntoDropdown();
            LoadGrades();
        }

        private void LoadStudentsIntoDropdown()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT StudentID, Name FROM Students";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    cmbStudents.DisplayMember = "Name";
                    cmbStudents.ValueMember = "StudentID";
                    cmbStudents.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjectsIntoDropdown()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT SubjectID, SubjectName FROM Subjects";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    cmbSubjects.DisplayMember = "SubjectName";
                    cmbSubjects.ValueMember = "SubjectID";
                    cmbSubjects.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGrades()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT 
                        Grades.GradeID,
                        Students.Name AS StudentName,
                        Subjects.SubjectName,
                        Grades.Marks,
                        Grades.ExamDate
                    FROM Grades
                    INNER JOIN Students ON Grades.StudentID = Students.StudentID
                    INNER JOIN Subjects ON Grades.SubjectID = Subjects.SubjectID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvGrades.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading grades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveGrade_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudents.SelectedValue == null || cmbSubjects.SelectedValue == null || string.IsNullOrEmpty(txtGrade.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int studentID = Convert.ToInt32(cmbStudents.SelectedValue);
                int subjectID = Convert.ToInt32(cmbSubjects.SelectedValue);
                decimal grade = Convert.ToDecimal(txtGrade.Text);
                DateTime examDate = dtpExamDate.Value.Date;

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Grades (StudentID, SubjectID, Marks, ExamDate) VALUES (@StudentID, @SubjectID, @Grade, @ExamDate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@SubjectID", subjectID);
                    command.Parameters.AddWithValue("@Grade", grade);
                    command.Parameters.AddWithValue("@ExamDate", examDate);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Grade saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadGrades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtGrade.Clear();
            dtpExamDate.Value = DateTime.Now;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT 
                        Grades.GradeID,
                        Students.Name AS StudentName,
                        Subjects.SubjectName,
                        Grades.Marks,
                        Grades.ExamDate
                    FROM Grades
                    INNER JOIN Students ON Grades.StudentID = Students.StudentID
                    INNER JOIN Subjects ON Grades.SubjectID = Subjects.SubjectID
                    WHERE Students.Name LIKE @SearchTerm OR Subjects.SubjectName LIKE @SearchTerm OR Grades.ExamDate LIKE @SearchTerm";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvGrades.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgvGrades_CellContentClick(object sender, EventArgs e)
        {

        }

        
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadGrades();
            txtSearch.Clear(); 
        }
    }
}