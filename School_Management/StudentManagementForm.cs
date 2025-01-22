using System;
using System.Windows.Forms;
using System.Data.SqlClient;

using MySqlConnector;
using System.Xml.Linq;
using System.Data;

namespace School_Management
{
    public partial class StudentManagementForm : Form
    {
        public StudentManagementForm()
        {
            InitializeComponent();
        }
        private void LoadClassesAndParents()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // تحميل الصفوف
                    string classQuery = "SELECT ClassID, ClassName FROM Classes";
                    SqlDataAdapter classAdapter = new SqlDataAdapter(classQuery, connection);
                    System.Data.DataTable classTable = new System.Data.DataTable();
                    classAdapter.Fill(classTable);
                    cmbClass.DataSource = classTable;
                    cmbClass.DisplayMember = "ClassName";
                    cmbClass.ValueMember = "ClassID";

                    // تحميل أولياء الأمور
                    string parentQuery = "SELECT ParentID, Name FROM Parents";
                    SqlDataAdapter parentAdapter = new SqlDataAdapter(parentQuery, connection);
                    System.Data.DataTable parentTable = new System.Data.DataTable();
                    parentAdapter.Fill(parentTable);
                    cmbParent.DataSource = parentTable;
                    cmbParent.DisplayMember = "Name";
                    cmbParent.ValueMember = "ParentID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading classes and parents: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            LoadStudentsData();
            LoadClassesAndParents();
                }

        private void LoadStudentsData()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Correct query to join Students and Classes tables
                    string query = @"
                SELECT 
                    s.StudentID, 
                    s.Name, 
                    s.DateOfBirth AS BirthDate, 
                    c.ClassName AS Class,
                    s.IsSynced 
                FROM 
                    Students s
                LEFT JOIN 
                    Classes c ON s.ClassID = c.ClassID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvStudents.DataSource = dataTable;
                }
                if (dgvStudents.Columns["StudentID"] != null)
                {
                    dgvStudents.Columns["StudentID"].HeaderText = "رقم قيد ";
                }
                if (dgvStudents.Columns["Name"] != null)
                {
                    dgvStudents.Columns["Name"].HeaderText = "اسم الطالب";
                }
                if (dgvStudents.Columns["BirthDate"] != null)
                {
                    dgvStudents.Columns["BirthDate"].HeaderText = " تاريخ الميلاد ";
                }
                if (dgvStudents.Columns["Class"] != null)
                {
                    dgvStudents.Columns["Class"].HeaderText = " الفصل ";
                }
                if (dgvStudents.Columns["IsSynced"] != null)
                {
                    dgvStudents.Columns.Remove("IsSynced");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading students data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string birthDate = dtpBirthDate.Value.ToString("yyyy-MM-dd");
                int classID = Convert.ToInt32(cmbClass.SelectedValue);
                int parentID = Convert.ToInt32(cmbParent.SelectedValue);

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Students (Name, DateOfBirth, ClassID, ParentID) VALUES (@Name, @DateOfBirth, @ClassID, @ParentID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DateOfBirth", birthDate);
                    command.Parameters.AddWithValue("@ClassID", classID);
                    command.Parameters.AddWithValue("@ParentID", parentID);

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
        private void dgvStudents_SelectionChanged(object sender, EventArgs e)

        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStudents.SelectedRows[0];
                txtName.Text = row.Cells["Name"].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                cmbClass.SelectedValue = row.Cells["ClassID"].Value;
                cmbParent.SelectedValue = row.Cells["ParentID"].Value;
            }
        }
        private void btnEditStudent_Click_1(object sender, EventArgs e)
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
                int classID = Convert.ToInt32(cmbClass.SelectedValue);
                int parentID = Convert.ToInt32(cmbParent.SelectedValue);

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Students SET Name = @Name, DateOfBirth = @DateOfBirth, ClassID = @ClassID, ParentID = @ParentID WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DateOfBirth", birthDate);
                    command.Parameters.AddWithValue("@ClassID", classID);
                    command.Parameters.AddWithValue("@ParentID", parentID);
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
        private void btnDeleteStudent_Click_1(object sender, EventArgs e)
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
                    connection.Open();

                    // حذف سجلات الدرجات المرتبطة بالطالب
                    string deleteGradesQuery = "DELETE FROM Grades WHERE StudentID = @StudentID";
                    SqlCommand deleteGradesCommand = new SqlCommand(deleteGradesQuery, connection);
                    deleteGradesCommand.Parameters.AddWithValue("@StudentID", studentID);
                    deleteGradesCommand.ExecuteNonQuery();

                    // حذف الطالب
                    string deleteStudentQuery = "DELETE FROM Students WHERE StudentID = @StudentID";
                    SqlCommand deleteStudentCommand = new SqlCommand(deleteStudentQuery, connection);
                    deleteStudentCommand.Parameters.AddWithValue("@StudentID", studentID);
                    deleteStudentCommand.ExecuteNonQuery();

                    MessageBox.Show("Student and related grades records deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentsData();
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
        private void btnViewStudentDetails_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    s.StudentID, 
                    s.Name, 
                    s.DateOfBirth AS BirthDate, 
                    c.ClassName AS Class 
                FROM 
                    Students s
                LEFT JOIN 
                    Classes c ON s.ClassID = c.ClassID
                WHERE 
                    s.Name LIKE @SearchTerm";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvStudents.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

       
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}