using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management
{
    public partial class SubjectManagementForm : Form
    {
        public SubjectManagementForm()
        {
            InitializeComponent();
        }

        private void SubjectManagementForm_Load(object sender, EventArgs e)
        {
            LoadSubjectsData();
            LoadTeachersIntoDropdown();
        }

        private void LoadSubjectsData()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Corrected query
                    string query = "SELECT s.SubjectID, s.SubjectName, t.Name AS TeacherName " +
                                   "FROM Subjects s " +
                                   "JOIN Teachers t ON s.TeacherID = t.TeacherID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvSubjects.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadTeachersIntoDropdown()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Corrected query
                    string query = "SELECT TeacherID, Name AS TeacherName FROM Teachers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    // Set DisplayMember and ValueMember for the ComboBox
                    cmbTeachers.DisplayMember = "TeacherName"; // Alias used in the query
                    cmbTeachers.ValueMember = "TeacherID";
                    cmbTeachers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading teachers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSubject_Click_1(object sender, EventArgs e)
        {
            try
            {
                string subjectName = txtSubjectName.Text.Trim();
                int teacherID = Convert.ToInt32(cmbTeachers.SelectedValue);

                if (string.IsNullOrEmpty(subjectName))
                {
                    MessageBox.Show("Please enter the subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Subjects (SubjectName, TeacherID) VALUES (@SubjectName, @TeacherID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SubjectName", subjectName);
                    command.Parameters.AddWithValue("@TeacherID", teacherID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Subject added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubjectsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSubjects.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a subject to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int subjectID = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells["SubjectID"].Value);
                string subjectName = txtSubjectName.Text.Trim();
                int teacherID = Convert.ToInt32(cmbTeachers.SelectedValue);

                if (string.IsNullOrEmpty(subjectName))
                {
                    MessageBox.Show("Please enter the subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Subjects SET SubjectName = @SubjectName, TeacherID = @TeacherID WHERE SubjectID = @SubjectID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SubjectName", subjectName);
                    command.Parameters.AddWithValue("@TeacherID", teacherID);
                    command.Parameters.AddWithValue("@SubjectID", subjectID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Subject updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubjectsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSubjects.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a subject to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int subjectID = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells["SubjectID"].Value);

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Subjects WHERE SubjectID = @SubjectID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SubjectID", subjectID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Subject deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubjectsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
