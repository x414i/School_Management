using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management
{
    public partial class ActivitiesManagementForm : Form
    {
        public ActivitiesManagementForm()
        {
            InitializeComponent();
        }

        private void ActivitiesManagementForm_Load(object sender, EventArgs e)
        {
            LoadActivities();
            LoadClassesDropdown();
        }

        private void LoadActivities()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT 
                        Activities.ActivityID,
                        Activities.Name,
                        Activities.Description,
                        Activities.Date,
                        Classes.ClassName
                    FROM Activities
                    LEFT JOIN Classes ON Activities.ClassID = Classes.ClassID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvActivities.DataSource = dataTable;

                    if (dgvActivities.Columns["ActivityID"] != null)
                    {
                        dgvActivities.Columns["ActivityID"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading activities: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClassesDropdown()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ClassID, ClassName FROM Classes";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    cmbClass.Items.Clear();
                    cmbClass.Items.Add(new ComboBoxItem { Text = "All Classes", Value = DBNull.Value });

                    while (reader.Read())
                    {
                        cmbClass.Items.Add(new ComboBoxItem
                        {
                            Text = reader["ClassName"].ToString(),
                            Value = reader["ClassID"]
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveActivity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || dtpDate.Value == null)
            {
                MessageBox.Show("Please provide all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = string.IsNullOrEmpty(txtActivityID.Text) ?
                        "INSERT INTO Activities (Name, Description, Date, ClassID) VALUES (@Name, @Description, @Date, @ClassID)" :
                        "UPDATE Activities SET Name = @Name, Description = @Description, Date = @Date, ClassID = @ClassID WHERE ActivityID = @ActivityID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text);
                    command.Parameters.AddWithValue("@Date", dtpDate.Value);
                    command.Parameters.AddWithValue("@ClassID", (cmbClass.SelectedItem as ComboBoxItem)?.Value ?? DBNull.Value);

                    if (!string.IsNullOrEmpty(txtActivityID.Text))
                    {
                        command.Parameters.AddWithValue("@ActivityID", Convert.ToInt32(txtActivityID.Text));
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Activity saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadActivities();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteActivity_Click(object sender, EventArgs e)
        {
            if (dgvActivities.SelectedRows.Count > 0)
            {
                int activityID = Convert.ToInt32(dgvActivities.SelectedRows[0].Cells["ActivityID"].Value);

                try
                {
                    string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Activities WHERE ActivityID = @ActivityID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ActivityID", activityID);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Activity deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadActivities();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an activity to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            txtActivityID.Clear();
            txtName.Clear();
            txtDescription.Clear();
            cmbClass.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
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
                        Activities.ActivityID,
                        Activities.Name,
                        Activities.Description,
                        Activities.Date,
                        Classes.ClassName
                    FROM Activities
                    LEFT JOIN Classes ON Activities.ClassID = Classes.ClassID
                    WHERE Activities.Name LIKE @SearchTerm OR Activities.Description LIKE @SearchTerm OR Activities.Date LIKE @SearchTerm";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvActivities.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadActivities();
            txtSearch.Clear(); // مسح حقل البحث
        }

        private void dgvActivities_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActivities.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvActivities.SelectedRows[0];
                txtActivityID.Text = row.Cells["ActivityID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(row.Cells["Date"].Value);

                // تحديد الفصل في القائمة المنسدلة
                var className = row.Cells["ClassName"].Value.ToString();
                foreach (ComboBoxItem item in cmbClass.Items)
                {
                    if (item.Text == className)
                    {
                        cmbClass.SelectedItem = item;
                        break;
                    }
                }
            }
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}