using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace School_Management
{
    public partial class TeacherManagementForm : Form
    {
        public TeacherManagementForm()
        {
            InitializeComponent();
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
        private void TeacherManagementForm_Load_1(object sender, EventArgs e)
        {
            LoadTeachersData();
            LoadSubjects();
            LoadTheme();
        }

        private void clearFeild()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            if (cmbSubject.Items.Count > 0)
            {
                cmbSubject.SelectedIndex = 0;
            }
        }

        private void LoadTeachersData()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TeacherID, Name, Specialization, Phone, Email FROM Teachers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvTeachers.DataSource = dataTable;

                    if (dgvTeachers.Columns["TeacherID"] != null)
                    {
                        dgvTeachers.Columns["TeacherID"].HeaderText = "رقم الاستاذ ";
                    }
                    if (dgvTeachers.Columns["Name"] != null)
                    {
                        dgvTeachers.Columns["Name"].HeaderText = "اسم الاستاذ";
                    }
                    if (dgvTeachers.Columns["Specialization"] != null)
                    {
                        dgvTeachers.Columns["Specialization"].HeaderText = " المادة";
                    }
                    if (dgvTeachers.Columns["Phone"] != null)
                    {
                        dgvTeachers.Columns["Phone"].HeaderText = "رقم الهاتف";
                    }
                    if (dgvTeachers.Columns["Email"] != null)
                    {
                        dgvTeachers.Columns["Email"].HeaderText = "البريد الإلكتروني";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjects()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT SubjectName FROM Subjects";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    cmbSubject.DataSource = dataTable;
                    cmbSubject.DisplayMember = "SubjectName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string subjectName = cmbSubject.Text;
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(name) || cmbSubject.SelectedIndex == -1 || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Teachers (Name, Specialization, Phone, Email) VALUES (@Name, @SubjectName, @Phone, @Email)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@SubjectName", subjectName);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Teacher added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeachersData();
                    LoadSubjects();
                    clearFeild();
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
                string subjectName = cmbSubject.Text;
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(name) || cmbSubject.SelectedIndex == -1 || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Teachers SET Name = @Name, Specialization = @SubjectName, Phone = @Phone, Email = @Email WHERE TeacherID = @TeacherID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@SubjectName", subjectName);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@TeacherID", teacherID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Teacher updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTeachersData();
                    clearFeild();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTeachers.SelectedRows[0];
                txtName.Text = row.Cells["Name"].Value.ToString();
                cmbSubject.Text = row.Cells["Specialization"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT TeacherID, Name, Specialization, Phone, Email FROM Teachers WHERE Name LIKE @SearchTerm OR Specialization LIKE @SearchTerm";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvTeachers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }
    }
}