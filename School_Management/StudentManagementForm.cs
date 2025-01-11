using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace School_Management
{
    public partial class StudentManagementForm : Form
    {
        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            // Load students data into DataGridView
            LoadStudentsData();
        }

        private void LoadStudentsData()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT StudentID, Name, BirthDate, Class FROM Students";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvStudents.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading students data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string birthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd");
                string studentClass = txtClass.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(studentClass))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Students (Name, BirthDate, Class) VALUES (@Name, @BirthDate, @Class)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);
                    command.Parameters.AddWithValue("@Class", studentClass);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int studentID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);
                string name = txtName.Text.Trim();
                string birthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd");
                string studentClass = txtClass.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(studentClass))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Students SET Name = @Name, BirthDate = @BirthDate, Class = @Class WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);
                    command.Parameters.AddWithValue("@Class", studentClass);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int studentID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Students WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentsData();
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
    }
}






//using System;
//using System.Windows.Forms;

//namespace School_Management
//{
//    public partial class StudentManagementForm : Form
//    {
//        public StudentManagementForm()
//        {
//            InitializeComponent();
//        }

//        private void StudentManagementForm_Load(object sender, EventArgs e)
//        {
//            // Initialize the form with data or settings if necessary
//        }

//        private void btnAddStudent_Click(object sender, EventArgs e)
//        {
//            // Logic to add a new student
//            MessageBox.Show("Add Student functionality not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        private void btnEditStudent_Click(object sender, EventArgs e)
//        {
//            // Logic to edit selected student
//            MessageBox.Show("Edit Student functionality not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        private void btnDeleteStudent_Click(object sender, EventArgs e)
//        {
//            // Logic to delete selected student
//            MessageBox.Show("Delete Student functionality not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        private void btnViewStudentDetails_Click(object sender, EventArgs e)
//        {
//            // Logic to view details of the selected student
//            MessageBox.Show("View Student Details functionality not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        private void btnClose_Click(object sender, EventArgs e)
//        {
//            // Close the form
//            this.Close();
//        }
//    }
//}
