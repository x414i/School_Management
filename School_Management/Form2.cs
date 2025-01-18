using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace School_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            // تعطيل الزر أثناء المزامنة لتجنب النقرات المتكررة
            btnSync.Enabled = false;
            txtLog.AppendText("Synchronization started...\r\n");

            try
            {
                string sqlServerConnectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                string mySqlConnectionString = "Server=localhost;Database=SchoolManagement;User Id=root;Password=;";

                // قائمة الجداول التي سيتم مزامنتها
                var tablesToSync = new[]
                {
                    new { TableName = "Students", Columns = "Name, DateOfBirth, ClassID, ParentID" },
                    new { TableName = "Teachers", Columns = "Name, Specialization" },
                    new { TableName = "Attendance", Columns = "Date, StudentID, Status" },
                    new { TableName = "Grades", Columns = "StudentID, SubjectID, Marks, ExamDate" },
                    new { TableName = "Parents", Columns = "Name, Phone, Email" },
                    new { TableName = "Timetable", Columns = "ClassID, SubjectID, TeacherID, Day, Time" },
                    new { TableName = "Activities", Columns = "Name, Description, Date, ClassID" }
                };

                foreach (var table in tablesToSync)
                {
                    SyncTable(sqlServerConnectionString, mySqlConnectionString, table.TableName, table.Columns);
                }

                txtLog.AppendText("Synchronization completed successfully!\r\n");
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"Error during synchronization: {ex.Message}\r\n");
            }
            finally
            {
                // إعادة تفعيل الزر بعد الانتهاء
                btnSync.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;"))
                {
                    connection.Open();
                    // جلب أسماء الجداول
                    string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clbTables.Items.Add(reader["TABLE_NAME"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"Error loading tables: {ex.Message}\r\n");
            }
        }


        private void AppendLog(string message)
        {
            txtLog.AppendText($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}\r\n");
        }

        private string GenerateInsertQuery(string tableName, DataRow row)
        {
            // قائمة بأسماء الأعمدة
            List<string> columns = new List<string>();
            // قائمة بالقيم
            List<string> values = new List<string>();

            foreach (DataColumn column in row.Table.Columns)
            {
                if (row[column] != DBNull.Value)
                {
                    columns.Add(column.ColumnName);
                    values.Add($"'{row[column].ToString().Replace("'", "''")}'"); // تجنب أخطاء علامات الاقتباس
                }
            }

            // تحويل الأعمدة والقيم إلى استعلام
            string columnsString = string.Join(", ", columns);
            string valuesString = string.Join(", ", values);

            // صيغة الاستعلام النهائي
            string query = $"INSERT INTO {tableName} ({columnsString}) VALUES ({valuesString});";
            return query;
        }

        private void SyncTable(string tableName)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;"))
                using (MySqlConnection mysqlConnection = new MySqlConnection("Server=localhost;Database=SchoolManagement;User Id=root;Password=;"))
                {
                    sqlConnection.Open();
                    mysqlConnection.Open();

                    string selectQuery = $"SELECT * FROM {tableName} WHERE IsSynced = 0";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        // إنشاء Insert Query ديناميكية للبيانات
                        string insertQuery = GenerateInsertQuery(tableName, row);
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, mysqlConnection);
                        insertCommand.ExecuteNonQuery();
                    }

                    string updateQuery = $"UPDATE {tableName} SET IsSynced = 1 WHERE IsSynced = 0";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                    updateCommand.ExecuteNonQuery();

                    txtLog.AppendText($"Synchronization completed for table: {tableName}.\r\n");
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"Error during synchronization for table {tableName}: {ex.Message}\r\n");
            }
        }


        private void SyncTable(string sqlServerConnectionString, string mySqlConnectionString, string tableName, string columns)
        {
            txtLog.AppendText($"Synchronizing table: {tableName}...\r\n");

            using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
            using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
            {
                sqlConnection.Open();
                mySqlConnection.Open();

                string selectQuery = $"SELECT {columns} FROM {tableName} WHERE IsSynced = 0";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        string[] columnArray = columns.Split(',');
                        string insertQuery = $"INSERT INTO {tableName} ({columns}) VALUES ({string.Join(", ", GetParameterPlaceholders(columnArray))})";

                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, mySqlConnection);

                        for (int i = 0; i < columnArray.Length; i++)
                        {
                            insertCommand.Parameters.AddWithValue($"@{columnArray[i].Trim()}", reader[columnArray[i].Trim()]);
                        }

                        insertCommand.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        // إذا كان الخطأ متعلقًا بقيود المفتاح الأجنبي
                        if (ex.Message.Contains("a foreign key constraint fails"))
                        {
                            txtLog.AppendText($"Foreign key constraint failed for table {tableName}. Skipping record.\r\n");
                        }
                        else
                        {
                            throw; // إعادة طرح الخطأ إذا كان غير متعلق بالمفتاح الأجنبي
                        }
                    }
                }

                reader.Close();

                // تحديث حالة IsSynced في SQL Server
                string updateQuery = $"UPDATE {tableName} SET IsSynced = 1 WHERE IsSynced = 0";
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.ExecuteNonQuery();

                txtLog.AppendText($"Synchronization completed for table: {tableName}.\r\n");
            }
        }

        private string[] GetParameterPlaceholders(string[] columns)
        {
            string[] placeholders = new string[columns.Length];
            for (int i = 0; i < columns.Length; i++)
            {
                placeholders[i] = $"@{columns[i].Trim()}";
            }
            return placeholders;
        }

        private void btnStartSync_Click(object sender, EventArgs e)
        {
            foreach (var item in clbTables.CheckedItems)
            {
                string tableName = item.ToString();
                try
                {
                    SyncTable(tableName);
                    txtLog.AppendText($"Synchronization completed for table: {tableName}.\r\n");
                }
                catch (Exception ex)
                {
                    txtLog.AppendText($"Error during synchronization for table {tableName}: {ex.Message}\r\n");
                }
            }
        }

    }
}
