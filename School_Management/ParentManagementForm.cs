using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management
{
    public partial class ParentManagementForm : Form
    {
        public ParentManagementForm()
        {
            InitializeComponent();
        }

        private void ParentManagementForm_Load_1(object sender, EventArgs e)
        {
            LoadParents();
        }

        private void LoadParents()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ParentID, Name, Phone, Email FROM Parents";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvParents.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading parents: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {

            // إضافة ولي أمر جديد مباشرةً إذا كانت الحقول تحتوي على بيانات
            if (!string.IsNullOrEmpty(txtParentName.Text) || !string.IsNullOrEmpty(txtPhoneNumber.Text) || !string.IsNullOrEmpty(txtEmail.Text))
            {
                string query = "INSERT INTO Parents (Name, Phone, Email) VALUES (@ParentName, @PhoneNumber, @Email)";
                SqlConnection connection = new SqlConnection("Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;");
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ParentName", txtParentName.Text);
                command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Parent information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadParents();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please fill in the fields and click Save to add a new parent.", "Add Parent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnEditParent_Click(object sender, EventArgs e)
        {
            if (dgvParents.SelectedRows.Count > 0)
            {
                txtParentName.Text = dgvParents.SelectedRows[0].Cells["Name"].Value.ToString();
                txtPhoneNumber.Text = dgvParents.SelectedRows[0].Cells["Phone"].Value.ToString();
                txtEmail.Text = dgvParents.SelectedRows[0].Cells["Email"].Value.ToString();
                txtParentID.Text = dgvParents.SelectedRows[0].Cells["ParentID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a parent to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteParent_Click(object sender, EventArgs e)
        {
            if (dgvParents.SelectedRows.Count > 0)
            {
                int parentID = Convert.ToInt32(dgvParents.SelectedRows[0].Cells["ParentID"].Value);

                try
                {
                    string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Parents WHERE ParentID = @ParentID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ParentID", parentID);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Parent deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadParents();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a parent to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveParent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtParentName.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtEmail.Text))
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

                    if (string.IsNullOrEmpty(txtParentID.Text))
                    {
                        query = "INSERT INTO Parents (Name, Phone, Email) VALUES (@ParentName, @PhoneNumber, @Email)";
                    }
                    else
                    {
                        query = "UPDATE Parents SET Name = @ParentName, Phone = @PhoneNumber, Email = @Email WHERE ParentID = @ParentID";
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ParentName", txtParentName.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    if (!string.IsNullOrEmpty(txtParentID.Text))
                    {
                        command.Parameters.AddWithValue("@ParentID", Convert.ToInt32(txtParentID.Text));
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Parent information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadParents();
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
            txtParentID.Clear();
            txtParentName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ParentID, Name, Phone, Email FROM Parents WHERE Name LIKE @SearchTerm OR Phone LIKE @SearchTerm OR Email LIKE @SearchTerm";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    dgvParents.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadParents();
            txtSearch.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtParentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}