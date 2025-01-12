using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace School_Management
{
    public partial class TeacherManagementForm : Form
    {
        public TeacherManagementForm()
        {
            InitializeComponent();
        }

        private void TeacherManagementForm_Load_1(object sender, EventArgs e)
        {
            // Load teacher data into DataGridView
            LoadTeachersData();
        }

        private void LoadTeachersData()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TeacherID, Name, Specialization FROM Teachers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvTeachers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string subject = txtSubject.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(subject))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Teachers (Name, Specialization) VALUES (@Name, @Subject)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Subject", subject);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Teacher added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeachersData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditTeacher_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvTeachers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a teacher to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int teacherID = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["TeacherID"].Value);
                string name = txtName.Text.Trim();
                string subject = txtSubject.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(subject))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Teachers SET Name = @Name, Specialization = @Subject WHERE TeacherID = @TeacherID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Subject", subject);
                    command.Parameters.AddWithValue("@TeacherID", teacherID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Teacher updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeachersData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTeacher_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvTeachers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a teacher to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int teacherID = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["TeacherID"].Value);

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Teachers WHERE TeacherID = @TeacherID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TeacherID", teacherID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Teacher deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeachersData();
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

       
    }
}
