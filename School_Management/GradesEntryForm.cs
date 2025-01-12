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
        }

        private void LoadStudentsIntoDropdown()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT StudentID, Name FROM Students"; // تعديل اسم العمود هنا
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    cmbStudents.DisplayMember = "Name"; // تأكد من تحديث DisplayMember
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
