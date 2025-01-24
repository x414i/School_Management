using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace School_Management
{
    public partial class ReportsForm : Form
    {
        string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";

        public ReportsForm()
        {
            InitializeComponent();
            LoadReportTypes();
        }

        private void LoadReportTypes()
        {
            cmbReportType.Items.Add("الحضور");
            cmbReportType.Items.Add("الدرجات");
            cmbReportType.Items.Add("الأنشطة");
            cmbReportType.Items.Add("المزامنة");
            cmbReportType.Items.Add("الأساتذة");
            cmbReportType.Items.Add("الطلاب");
            cmbReportType.Items.Add("الصفوف");
            cmbReportType.Items.Add("المواد");
            cmbReportType.SelectedIndex = 0;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            string selectedReport = cmbReportType.SelectedItem.ToString();
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            switch (selectedReport)
            {
                case "الحضور":
                    ShowAttendanceReport(startDate, endDate);
                    break;
                case "الدرجات":
                    ShowGradesReport(startDate, endDate);
                    break;
                case "الأنشطة":
                    ShowActivitiesReport(startDate, endDate);
                    break;
                case "المزامنة":
                    ShowSyncReport();
                    break;
                case "الأساتذة":
                    ShowTeachersReport();
                    break;
                case "الطلاب":
                    ShowStudentsReport();
                    break;
                case "الصفوف":
                    ShowClassesReport();
                    break;
                case "المواد":
                    ShowSubjectsReport();
                    break;
            }
        }

        private void ShowAttendanceReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT s.Name AS StudentName, a.Date, a.Status 
                FROM Attendance a
                INNER JOIN Students s ON a.StudentID = s.StudentID
                WHERE a.Date BETWEEN @StartDate AND @EndDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate.Date);
                command.Parameters.AddWithValue("@EndDate", endDate.Date);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvReport.DataSource = dataTable;
            }
        }

        private void ShowGradesReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT s.Name AS StudentName, sub.SubjectName, g.Marks, g.ExamDate 
                FROM Grades g
                INNER JOIN Students s ON g.StudentID = s.StudentID
                INNER JOIN Subjects sub ON g.SubjectID = sub.SubjectID
                WHERE g.ExamDate BETWEEN @StartDate AND @EndDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate.Date);
                command.Parameters.AddWithValue("@EndDate", endDate.Date);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvReport.DataSource = dataTable;
            }
        }

        private void ShowActivitiesReport(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT a.Name AS ActivityName, a.Description, a.Date, c.ClassName 
                FROM Activities a
                LEFT JOIN Classes c ON a.ClassID = c.ClassID
                WHERE a.Date BETWEEN @StartDate AND @EndDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate.Date);
                command.Parameters.AddWithValue("@EndDate", endDate.Date);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvReport.DataSource = dataTable;
            }
        }

        private void ShowSyncReport()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT TableName, LastSyncDate, Status 
                FROM CloudSync
                ORDER BY LastSyncDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvReport.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء استرداد تقرير المزامنة: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowTeachersReport()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT t.TeacherID, t.Name, t.Specialization, t.Phone, t.Email 
                FROM Teachers t";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvReport.DataSource = dataTable;

                    if (dgvReport.Columns["TeacherID"] != null)
                    {
                        dgvReport.Columns["TeacherID"].HeaderText = "رقم الأستاذ";
                    }
                    if (dgvReport.Columns["Name"] != null)
                    {
                        dgvReport.Columns["Name"].HeaderText = "اسم الأستاذ";
                    }
                    if (dgvReport.Columns["Specialization"] != null)
                    {
                        dgvReport.Columns["Specialization"].HeaderText = "التخصص";
                    }
                    if (dgvReport.Columns["Phone"] != null)
                    {
                        dgvReport.Columns["Phone"].HeaderText = "رقم الهاتف";
                    }
                    if (dgvReport.Columns["Email"] != null)
                    {
                        dgvReport.Columns["Email"].HeaderText = "البريد الإلكتروني";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء استرداد تقرير الأساتذة: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowStudentsReport()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT s.StudentID, s.Name, s.DateOfBirth, c.ClassName, p.Name AS ParentName 
                FROM Students s
                INNER JOIN Classes c ON s.ClassID = c.ClassID
                LEFT JOIN Parents p ON s.ParentID = p.ParentID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvReport.DataSource = dataTable;

                    if (dgvReport.Columns["StudentID"] != null)
                    {
                        dgvReport.Columns["StudentID"].HeaderText = "رقم الطالب";
                    }
                    if (dgvReport.Columns["Name"] != null)
                    {
                        dgvReport.Columns["Name"].HeaderText = "اسم الطالب";
                    }
                    if (dgvReport.Columns["DateOfBirth"] != null)
                    {
                        dgvReport.Columns["DateOfBirth"].HeaderText = "تاريخ الميلاد";
                    }
                    if (dgvReport.Columns["ClassName"] != null)
                    {
                        dgvReport.Columns["ClassName"].HeaderText = "الصف";
                    }
                    if (dgvReport.Columns["ParentName"] != null)
                    {
                        dgvReport.Columns["ParentName"].HeaderText = "اسم ولي الأمر";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء استرداد تقرير الطلاب: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowClassesReport()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT ClassID, ClassName, Level 
                FROM Classes";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvReport.DataSource = dataTable;

                    if (dgvReport.Columns["ClassID"] != null)
                    {
                        dgvReport.Columns["ClassID"].HeaderText = "رقم الصف";
                    }
                    if (dgvReport.Columns["ClassName"] != null)
                    {
                        dgvReport.Columns["ClassName"].HeaderText = "اسم الصف";
                    }
                    if (dgvReport.Columns["Level"] != null)
                    {
                        dgvReport.Columns["Level"].HeaderText = "المستوى";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء استرداد تقرير الصفوف: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSubjectsReport()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT sub.SubjectID, sub.SubjectName, t.Name AS TeacherName 
                FROM Subjects sub
                INNER JOIN Teachers t ON sub.TeacherID = t.TeacherID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgvReport.DataSource = dataTable;

                    if (dgvReport.Columns["SubjectID"] != null)
                    {
                        dgvReport.Columns["SubjectID"].HeaderText = "رقم المادة";
                    }
                    if (dgvReport.Columns["SubjectName"] != null)
                    {
                        dgvReport.Columns["SubjectName"].HeaderText = "اسم المادة";
                    }
                    if (dgvReport.Columns["TeacherName"] != null)
                    {
                        dgvReport.Columns["TeacherName"].HeaderText = "اسم الأستاذ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء استرداد تقرير المواد: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            if (dgvReport.DataSource != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel File|*.xlsx";
                saveFileDialog.Title = "حفظ التقرير";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    ExportToExcel(dgvReport, saveFileDialog.FileName);
                    MessageBox.Show("تم تصدير التقرير بنجاح!", "تصدير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لتصديرها!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportToExcel(DataGridView dataGridView, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;

            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value?.ToString();
                }
            }

            worksheet.SaveAs(fileName);
            excel.Quit();
        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            if (dgvReport.DataSource != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF File|*.pdf";
                saveFileDialog.Title = "حفظ التقرير كـ PDF";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    ExportToPDF(dgvReport, saveFileDialog.FileName);
                    MessageBox.Show("تم تصدير التقرير إلى PDF بنجاح!", "تصدير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لتصديرها!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExportToPDF(DataGridView dataGridView, string fileName)
        {
            Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));
            pdfDoc.Open();

            PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value?.ToString());
                }
            }

            pdfDoc.Add(pdfTable);
            pdfDoc.Close();
        }

        private void btnSyncReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string countQuery = "SELECT COUNT(*) FROM Students WHERE IsSynced = 1";
                    SqlCommand countCommand = new SqlCommand(countQuery, connection);
                    int syncedCount = Convert.ToInt32(countCommand.ExecuteScalar());

                    string lastSyncQuery = "SELECT MAX(LastSyncDate) FROM CloudSync WHERE TableName = 'Students'";
                    SqlCommand lastSyncCommand = new SqlCommand(lastSyncQuery, connection);
                    object lastSyncDate = lastSyncCommand.ExecuteScalar();

                    string reportMessage = $"عدد السجلات التي تمت مزامنتها: {syncedCount}\n";
                    reportMessage += lastSyncDate != DBNull.Value ? $"تاريخ آخر مزامنة: {lastSyncDate}" : "لم تتم مزامنة أي بيانات بعد.";
                    MessageBox.Show(reportMessage, "تقرير المزامنة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء استرداد تقرير المزامنة: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearResults_Click()
        {
            dgvReport.DataSource = null;
            dgvReport.Rows.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}