using System;
using System.Collections.Generic;
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

                    // تغيير أسماء الأعمدة إلى العربية
                    if (dgvActivities.Columns["ActivityID"] != null)
                    {
                        dgvActivities.Columns["ActivityID"].HeaderText = "معرف النشاط";
                        dgvActivities.Columns["ActivityID"].Visible = false; // إخفاء العمود إذا لزم الأمر
                    }
                    if (dgvActivities.Columns["Name"] != null)
                    {
                        dgvActivities.Columns["Name"].HeaderText = "اسم النشاط";
                    }
                    if (dgvActivities.Columns["Description"] != null)
                    {
                        dgvActivities.Columns["Description"].HeaderText = "الوصف";
                    }
                    if (dgvActivities.Columns["Date"] != null)
                    {
                        dgvActivities.Columns["Date"].HeaderText = "التاريخ";
                    }
                    if (dgvActivities.Columns["ClassName"] != null)
                    {
                        dgvActivities.Columns["ClassName"].HeaderText = "الفصل";
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
                    LoadActivities(); // تحديث DataGridView بعد الحفظ
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
            WHERE Activities.Name LIKE @SearchTerm OR Activities.Description LIKE @SearchTerm";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvActivities.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching activities found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            txtSearch.Clear();
            ClearFields();
        }

        private void dgvActivities_SelectionChanged(object sender, EventArgs e)
        {
            // التحقق من وجود صفوف محددة
            if (dgvActivities.SelectedRows.Count > 0)
            {
                // الحصول على الصف المحدد
                DataGridViewRow row = dgvActivities.SelectedRows[0];

                // تعبئة الحقول بالبيانات من الصف المحدد
                txtActivityID.Text = row.Cells["ActivityID"].Value?.ToString() ?? string.Empty;
                txtName.Text = row.Cells["Name"].Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;

                // تعبئة حقل التاريخ
                if (DateTime.TryParse(row.Cells["Date"].Value?.ToString(), out DateTime date))
                {
                    dtpDate.Value = date;
                }
                else
                {
                    dtpDate.Value = DateTime.Now; // قيمة افتراضية إذا كان التاريخ غير صالح
                }

                // تعبئة القائمة المنسدلة (ComboBox)
                var className = row.Cells["ClassName"].Value?.ToString() ?? string.Empty;
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
        private void dgvActivities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddActivity()
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

                    // إذا تم اختيار "All Classes"
                    if ((cmbClass.SelectedItem as ComboBoxItem)?.Value == DBNull.Value)
                    {
                        // جلب جميع الفصول
                        string getClassesQuery = "SELECT ClassID FROM Classes";
                        SqlCommand getClassesCommand = new SqlCommand(getClassesQuery, connection);
                        SqlDataReader reader = getClassesCommand.ExecuteReader();

                        List<int> classIDs = new List<int>();
                        while (reader.Read())
                        {
                            classIDs.Add(Convert.ToInt32(reader["ClassID"]));
                        }
                        reader.Close();

                        // إدراج النشاط لكل فصل
                        foreach (int classID in classIDs)
                        {
                            string insertQuery = "INSERT INTO Activities (Name, Description, Date, ClassID) VALUES (@Name, @Description, @Date, @ClassID)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                            insertCommand.Parameters.AddWithValue("@Name", txtName.Text);
                            insertCommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                            insertCommand.Parameters.AddWithValue("@Date", dtpDate.Value);
                            insertCommand.Parameters.AddWithValue("@ClassID", classID);

                            insertCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Activity added to all classes successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // إدراج النشاط لفصل محدد
                        string insertQuery = "INSERT INTO Activities (Name, Description, Date, ClassID) VALUES (@Name, @Description, @Date, @ClassID)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@Name", txtName.Text);
                        insertCommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                        insertCommand.Parameters.AddWithValue("@Date", dtpDate.Value);
                        insertCommand.Parameters.AddWithValue("@ClassID", (cmbClass.SelectedItem as ComboBoxItem)?.Value ?? DBNull.Value);

                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Activity added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearFields();
                    LoadActivities(); // تحديث DataGridView بعد الإضافة
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnAddUpdateActivity_Click(object sender, EventArgs e)
        {
            AddActivity();
        }


        private void UpdateActivity()
        {
            if (string.IsNullOrEmpty(txtActivityID.Text))
            {
                MessageBox.Show("Please select an activity to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                    // إذا تم اختيار "All Classes"
                    if ((cmbClass.SelectedItem as ComboBoxItem)?.Value == DBNull.Value)
                    {
                        // جلب جميع الفصول
                        string getClassesQuery = "SELECT ClassID FROM Classes";
                        SqlCommand getClassesCommand = new SqlCommand(getClassesQuery, connection);
                        SqlDataReader reader = getClassesCommand.ExecuteReader();

                        List<int> classIDs = new List<int>();
                        while (reader.Read())
                        {
                            classIDs.Add(Convert.ToInt32(reader["ClassID"]));
                        }
                        reader.Close();

                        // تحديث النشاط لكل فصل
                        foreach (int classID in classIDs)
                        {
                            string updateQuery = "UPDATE Activities SET Name = @Name, Description = @Description, Date = @Date, ClassID = @ClassID WHERE ActivityID = @ActivityID";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@Name", txtName.Text);
                            updateCommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                            updateCommand.Parameters.AddWithValue("@Date", dtpDate.Value);
                            updateCommand.Parameters.AddWithValue("@ClassID", classID);
                            updateCommand.Parameters.AddWithValue("@ActivityID", Convert.ToInt32(txtActivityID.Text));

                            updateCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Activity updated for all classes successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // تحديث النشاط لفصل محدد
                        string updateQuery = "UPDATE Activities SET Name = @Name, Description = @Description, Date = @Date, ClassID = @ClassID WHERE ActivityID = @ActivityID";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@Name", txtName.Text);
                        updateCommand.Parameters.AddWithValue("@Description", txtDescription.Text);
                        updateCommand.Parameters.AddWithValue("@Date", dtpDate.Value);
                        updateCommand.Parameters.AddWithValue("@ClassID", (cmbClass.SelectedItem as ComboBoxItem)?.Value ?? DBNull.Value);
                        updateCommand.Parameters.AddWithValue("@ActivityID", Convert.ToInt32(txtActivityID.Text));

                        updateCommand.ExecuteNonQuery();
                        MessageBox.Show("Activity updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearFields();
                    LoadActivities(); // تحديث DataGridView بعد التعديل
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
     
        private void btnUpdateActivity_Click(object sender, EventArgs e)
        {
            UpdateActivity();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtActivityID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
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