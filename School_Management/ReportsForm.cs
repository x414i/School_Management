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

        // تحميل أنواع التقارير في ComboBox
        private void LoadReportTypes()
        {
            cmbReportType.Items.Add("الحضور");
            cmbReportType.Items.Add("الدرجات");
            cmbReportType.Items.Add("الأنشطة");
            cmbReportType.SelectedIndex = 0; // تحديد العنصر الأول افتراضيًا
        }
        private void ReportsForm_Load (object sender, EventArgs e)
        {
           
        }

        // حدث عند النقر على زر "عرض التقرير"
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            string selectedReport = cmbReportType.SelectedItem.ToString();
            DateTime selectedDate = dtpReportDate.Value;

            switch (selectedReport)
            {
                case "الحضور":
                    ShowAttendanceReport(selectedDate);
                    break;
                case "الدرجات":
                    ShowGradesReport(selectedDate);
                    break;
                case "الأنشطة":
                    ShowActivitiesReport(selectedDate);
                    break;
            }
        }

        // عرض تقرير الحضور
        private void ShowAttendanceReport(DateTime date)
        {
            string query = @"
                SELECT s.Name AS StudentName, a.Date, a.Status 
                FROM Attendance a
                INNER JOIN Students s ON a.StudentID = s.StudentID
                WHERE a.Date = @Date";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", date.Date);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvReport.DataSource = dataTable;
            }
        }

        // عرض تقرير الدرجات
        private void ShowGradesReport(DateTime date)
        {
            string query = @"
                SELECT s.Name AS StudentName, sub.SubjectName, g.Marks, g.ExamDate 
                FROM Grades g
                INNER JOIN Students s ON g.StudentID = s.StudentID
                INNER JOIN Subjects sub ON g.SubjectID = sub.SubjectID
                WHERE g.ExamDate = @ExamDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ExamDate", date.Date);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvReport.DataSource = dataTable;
            }
        }

        // عرض تقرير الأنشطة
        private void ShowActivitiesReport(DateTime date)
        {
            string query = @"
                SELECT a.Name AS ActivityName, a.Description, a.Date, c.ClassName 
                FROM Activities a
                LEFT JOIN Classes c ON a.ClassID = c.ClassID
                WHERE a.Date = @ActivityDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ActivityDate", date.Date);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvReport.DataSource = dataTable;
            }
        }

        // حدث عند النقر على زر "تصدير التقرير"
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

        // تصدير البيانات إلى Excel
        private void ExportToExcel(DataGridView dataGridView, string fileName)
        {
            // يمكنك استخدام مكتبة مثل "EPPlus" لتصدير البيانات إلى Excel.
            // هذا مثال بسيط:
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;

            // تصدير العناوين
            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }

            // تصدير البيانات
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
            // إنشاء مستند PDF
            Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));
            pdfDoc.Open();

            // إنشاء جدول في PDF
            PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            // إضافة عناوين الأعمدة
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            // إضافة بيانات الصفوف
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value?.ToString());
                }
            }

            // إضافة الجدول إلى المستند
            pdfDoc.Add(pdfTable);
            pdfDoc.Close();
        }
    }
}