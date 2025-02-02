using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace School_Management
{
    public partial class SyncDB : Form
    {
        public SyncDB()
        {
            InitializeComponent();
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
        private async void btnStartSync_Click(object sender, EventArgs e)
        {
            btnStartSync.Enabled = false;
            AppendLog("بدء المزامنة...", "Info");

            try
            {
                string sqlServerConnectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                string mySqlConnectionString = "Server=localhost;Database=SchoolManagement;User Id=root;Password=;";

                var tablesToSync = new List<string>
                {
                    "Students",
                    "Classes",
                    "Parents",
                    "Teachers",
                    "Subjects",
                    "Attendance",
                    "Grades",
                    "Timetable",
                    "Activities",
                    "CloudSync",
                    "Users"
                };

                foreach (var tableName in tablesToSync)
                {
                    await Task.Run(() => SyncTable(sqlServerConnectionString, mySqlConnectionString, tableName));
                }

                AppendLog("تمت المزامنة بنجاح!", "Success");
            }
            catch (Exception ex)
            {
                AppendLog($"حدث خطأ أثناء المزامنة: {ex.Message}", "Error");
            }
            finally
            {
                btnStartSync.Enabled = true;
            }
        }

        private void SyncTable(string sqlServerConnectionString, string mySqlConnectionString, string tableName)
        {
            AppendLog($"جارٍ مزامنة الجدول: {tableName}...", "Info");

            using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
            using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    mySqlConnection.Open();

                    string selectQuery = $"SELECT * FROM {tableName}";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    AppendLog($"تم جلب {dataTable.Rows.Count} سجل من الجدول {tableName}.", "Info");

                    foreach (DataRow row in dataTable.Rows)
                    {
                        try
                        {
                            string primaryKeyColumn = GetPrimaryKeyColumn(tableName);
                            string checkQuery = $"SELECT COUNT(*) FROM {tableName} WHERE {primaryKeyColumn} = @PrimaryKeyValue";
                            MySqlCommand checkCommand = new MySqlCommand(checkQuery, mySqlConnection);
                            checkCommand.Parameters.AddWithValue("@PrimaryKeyValue", row[primaryKeyColumn]);
                            long count = (long)checkCommand.ExecuteScalar();

                            if (count == 0)
                            {
                                string insertQuery = GenerateInsertQuery(tableName, row);
                                MySqlCommand insertCommand = new MySqlCommand(insertQuery, mySqlConnection);
                                insertCommand.ExecuteNonQuery();
                                AppendLog($"تم إدراج سجل جديد في الجدول {tableName} ({primaryKeyColumn} = {row[primaryKeyColumn]}).", "Success");
                            }
                            else
                            {
                                AppendLog($"تم تخطي السجل المكرر في الجدول {tableName} ({primaryKeyColumn} = {row[primaryKeyColumn]}).", "Warning");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            if (ex.Message.Contains("a foreign key constraint fails"))
                            {
                                AppendLog($"فشل في قيد المفتاح الخارجي للجدول {tableName}. تم تخطي السجل.", "Error");
                            }
                            else
                            {
                                AppendLog($"حدث خطأ أثناء إدراج السجل في الجدول {tableName}: {ex.Message}", "Error");
                                AppendLog($"تفاصيل الخطأ: {ex.StackTrace}", "Error");
                            }
                        }
                    }

                    AppendLog($"تمت مزامنة الجدول: {tableName}.", "Success");
                }
                catch (Exception ex)
                {
                    AppendLog($"حدث خطأ أثناء مزامنة الجدول {tableName}: {ex.Message}", "Error");
                }
                finally
                {
                    sqlConnection.Close();
                    mySqlConnection.Close();
                }
            }
        }

        private string GenerateInsertQuery(string tableName, DataRow row)
        {
            List<string> columns = new List<string>();
            List<string> values = new List<string>();

            foreach (DataColumn column in row.Table.Columns)
            {
                if (row[column] != DBNull.Value)
                {
                    columns.Add(column.ColumnName);
                    values.Add($"'{row[column].ToString().Replace("'", "''")}'");
                }
            }

            string columnsString = string.Join(", ", columns);
            string valuesString = string.Join(", ", values);

            return $"INSERT INTO {tableName} ({columnsString}) VALUES ({valuesString});";
        }

        private string GetPrimaryKeyColumn(string tableName)
        {
            switch (tableName)
            {
                case "Students":
                    return "StudentID";
                case "Parents":
                    return "ParentID";
                case "Teachers":
                    return "TeacherID";
                case "Grades":
                    return "GradeID";
                case "Timetable":
                    return "TimetableID";
                case "Activities":
                    return "ActivityID";
                case "Classes":
                    return "ClassID";
                case "Subjects":
                    return "SubjectID";
                case "Users":
                    return "UserID";
                case "CloudSync":
                    return "SyncID";
                case "Attendance":
                    return "AttendanceID";
                default:
                    throw new Exception($"العمود الرئيسي للجدول {tableName} غير معروف.");
            }
        }

        private void AppendLog(string message, string messageType = "Info")
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(() => AppendLog(message, messageType)));
                return;
            }

            Color color;
            switch (messageType)
            {
                case "Success":
                    color = Color.Green;
                    break;
                case "Error":
                    color = Color.Red;
                    break;
                case "Warning":
                    color = Color.Orange;
                    break;
                default:
                    color = Color.Black;
                    break;
            }

            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.SelectionLength = 0;
            txtLog.SelectionColor = color;
            txtLog.AppendText($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\r\n");
            txtLog.SelectionColor = txtLog.ForeColor;
        }
    }
}