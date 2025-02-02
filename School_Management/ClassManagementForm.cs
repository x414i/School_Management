using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Mysqlx.Crud;
using System.Xml.Linq;
using System.Drawing;

namespace School_Management
{
    public partial class ClassManagementForm : Form
    {
        public ClassManagementForm()
        {
            InitializeComponent();
        }

        private void ClassManagementForm_Load(object sender, EventArgs e)
        {
            LoadClassesData();
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
        private void LoadClassesData()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ClassID, ClassName, Level FROM Classes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvClasses.DataSource = dataTable;
                    if (dgvClasses.Columns["ClassID"] != null)
                    {
                        dgvClasses.Columns["ClassID"].HeaderText = "رقم الصف ";
                    }
                    if (dgvClasses.Columns["ClassName"] != null)
                    {
                        dgvClasses.Columns["ClassName"].HeaderText = "اسم الصف";
                    }
                    if (dgvClasses.Columns["Level"] != null)
                    {
                        dgvClasses.Columns["Level"].HeaderText = "المرحلة";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading class data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddClass_Click_1(object sender, EventArgs e)
        {
            try
            {
                string className = txtClassName.Text.Trim();
                string level = txtLevel.Text.Trim();

                if (string.IsNullOrEmpty(className) || string.IsNullOrEmpty(level))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Classes (ClassName, Level) VALUES (@ClassName, @Level)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassName", className);
                    command.Parameters.AddWithValue("@Level", level);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Class added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClassesData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditClass_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvClasses.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a class to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int classID = Convert.ToInt32(dgvClasses.SelectedRows[0].Cells["ClassID"].Value);
                string className = txtClassName.Text.Trim();
                string level = txtLevel.Text.Trim();

                if (string.IsNullOrEmpty(className) || string.IsNullOrEmpty(level))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Classes SET ClassName = @ClassName, Level = @Level WHERE ClassID = @ClassID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassName", className);
                    command.Parameters.AddWithValue("@Level", level);
                    command.Parameters.AddWithValue("@ClassID", classID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Class updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClassesData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteClass_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvClasses.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a class to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int classID = Convert.ToInt32(dgvClasses.SelectedRows[0].Cells["ClassID"].Value);

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Classes WHERE ClassID = @ClassID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClassID", classID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Class deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClassesData();
                    ClearFields();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            txtClassName.Clear();
            txtLevel.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
