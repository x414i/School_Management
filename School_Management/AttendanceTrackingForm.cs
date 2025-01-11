using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management
{
    public partial class AttendanceTrackingForm : Form
    {
        public AttendanceTrackingForm()
        {
            InitializeComponent();
        }

        private void AttendanceTrackingForm_Load(object sender, EventArgs e)
        {
            LoadClassesIntoDropdown();
        }

        private void LoadClassesIntoDropdown()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ClassID, ClassName FROM Classes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    cmbClasses.DisplayMember = "ClassName";
                    cmbClasses.ValueMember = "ClassID";
                    cmbClasses.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentsData()
        {
            try
            {
                if (cmbClasses.SelectedValue == null)
                {
                    MessageBox.Show("Please select a class first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int classID = Convert.ToInt32(cmbClasses.SelectedValue);
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT StudentID, StudentName FROM Students WHERE ClassID = @ClassID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@ClassID", classID);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    dgvStudents.DataSource = dataTable;
                    dgvStudents.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Present", Name = "Present" });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            LoadStudentsData();
        }

        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.Rows.Count == 0)
                {
                    MessageBox.Show("No students to save attendance for.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Attendance (StudentID, Date, IsPresent) VALUES (@StudentID, @Date, @IsPresent)";

                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        if (row.Cells["StudentID"].Value != null)
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@StudentID", row.Cells["StudentID"].Value);
                            command.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                            command.Parameters.AddWithValue("@IsPresent", Convert.ToBoolean(row.Cells["Present"].Value));

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Attendance saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
