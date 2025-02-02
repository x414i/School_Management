using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

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
            LoadStudentsData();
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
        private void LoadClassesIntoDropdown()
        {
            try
            {
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ClassID, ClassName FROM Classes";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                 
                    DataRow allClassesRow = dataTable.NewRow();
                    allClassesRow["ClassID"] = -1; 
                    allClassesRow["ClassName"] = "جميع الصفوف";
                    dataTable.Rows.InsertAt(allClassesRow, 0);

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
                    MessageBox.Show("يرجى اختيار صف دراسي أولاً.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int classID = Convert.ToInt32(cmbClasses.SelectedValue);
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query;
                    if (classID == -1)
                    {
                        query = @"SELECT 
                             s.StudentID, 
                             s.Name, 
                             CASE WHEN a.Status = 'Present' THEN 1 ELSE 0 END AS Status 
                          FROM Students s
                          LEFT JOIN Attendance a 
                          ON s.StudentID = a.StudentID AND a.Date = @Date";
                    }
                    else
                    {
                        query = @"SELECT 
                             s.StudentID, 
                             s.Name, 
                             CASE WHEN a.Status = 'Present' THEN 1 ELSE 0 END AS Status 
                          FROM Students s
                          LEFT JOIN Attendance a 
                          ON s.StudentID = a.StudentID AND a.Date = @Date
                          WHERE s.ClassID = @ClassID";
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                    if (classID != -1)
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@ClassID", classID);
                    }

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (!dataTable.Columns.Contains("IsDirty"))
                    {
                        dataTable.Columns.Add("IsDirty", typeof(bool)).DefaultValue = false;
                    }

                    dgvStudents.DataSource = dataTable;

                    if (dgvStudents.Columns["StudentID"] != null)
                    {
                        dgvStudents.Columns["StudentID"].HeaderText = "معرف الطالب";
                    }
                    if (dgvStudents.Columns["Name"] != null)
                    {
                        dgvStudents.Columns["Name"].HeaderText = "اسم الطالب";
                    }

                    if (dgvStudents.Columns["Status"] != null && !(dgvStudents.Columns["Status"] is DataGridViewCheckBoxColumn))
                    {
                        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                        {
                            DataPropertyName = "Status",
                            HeaderText = "حضور",
                            Name = "Status",
                            TrueValue = 1,
                            FalseValue = 0,
                            IndeterminateValue = DBNull.Value
                        };
                        dgvStudents.Columns.Remove("Status");
                        dgvStudents.Columns.Add(checkBoxColumn);
                    }

                    if (dgvStudents.Columns["IsDirty"] != null)
                    {
                        dgvStudents.Columns["IsDirty"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadStudents_Click_1(object sender, EventArgs e)
        {
            LoadStudentsData();
        }

        private void btnSaveAttendance_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.Rows.Count == 0)
                {
                    MessageBox.Show("لا يوجد طلاب لحفظ الحضور.", "خطأ في التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        if (row.Cells["StudentID"].Value != null)
                        {
                            int studentID = Convert.ToInt32(row.Cells["StudentID"].Value);
                            DateTime date = dtpDate.Value.Date;
                            bool isPresent = Convert.ToBoolean(row.Cells["Status"].Value);

                            string upsertQuery = @"
                        IF EXISTS (SELECT 1 FROM Attendance WHERE StudentID = @StudentID AND Date = @Date)
                            UPDATE Attendance SET Status = @Status WHERE StudentID = @StudentID AND Date = @Date
                        ELSE
                            INSERT INTO Attendance (StudentID, Date, Status) VALUES (@StudentID, @Date, @Status)";
                            using (SqlCommand upsertCommand = new SqlCommand(upsertQuery, connection))
                            {
                                upsertCommand.Parameters.AddWithValue("@StudentID", studentID);
                                upsertCommand.Parameters.AddWithValue("@Date", date);
                                upsertCommand.Parameters.AddWithValue("@Status", isPresent ? "Present" : "Absent");
                                upsertCommand.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("تم حفظ الحضور بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadStudentsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvStudents.Columns["IsDirty"] != null && e.ColumnIndex == dgvStudents.Columns["Status"].Index)
            {
                dgvStudents.Rows[e.RowIndex].Cells["IsDirty"].Value = true;
            }
        }

    }
}