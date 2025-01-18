using System;
using System.Data;
using System.Data.SqlClient;
using MySqlConnector; // تثبيت المكتبة عبر NuGet: Install-Package MySqlConnector

namespace School_Management
{
    public class SyncService
    {
        private string sqlServerConnectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
        private string mySqlConnectionString = "Server=localhost;Database=SchoolManagement;User Id=root;Password=;";

        public void SyncTable(string tableName)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();

                    // استرداد السجلات التي لم تتم مزامنتها
                    string selectQuery = $"SELECT * FROM {tableName} WHERE IsSynced = 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, sqlConnection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // نقل البيانات إلى MySQL
                        using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
                        {
                            mySqlConnection.Open();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string insertQuery = $"INSERT INTO {tableName} ({GetColumns(tableName)}) VALUES ({GetValues(row)})";
                                MySqlCommand command = new MySqlCommand(insertQuery, mySqlConnection);

                                foreach (DataColumn column in dataTable.Columns)
                                {
                                    if (column.ColumnName != "IsSynced") // تجاهل حقل IsSynced
                                    {
                                        command.Parameters.AddWithValue($"@{column.ColumnName}", row[column.ColumnName]);
                                    }
                                }

                                command.ExecuteNonQuery();
                            }
                        }

                        // تحديث حالة المزامنة في SQL Server
                        string updateQuery = $"UPDATE {tableName} SET IsSynced = 1 WHERE IsSynced = 0";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                        updateCommand.ExecuteNonQuery();

                        // تسجيل حالة المزامنة في جدول CloudSync
                        string logQuery = "INSERT INTO CloudSync (TableName, LastSyncDate, Status) VALUES (@TableName, @LastSyncDate, @Status)";
                        SqlCommand logCommand = new SqlCommand(logQuery, sqlConnection);
                        logCommand.Parameters.AddWithValue("@TableName", tableName);
                        logCommand.Parameters.AddWithValue("@LastSyncDate", DateTime.Now);
                        logCommand.Parameters.AddWithValue("@Status", "Completed");
                        logCommand.ExecuteNonQuery();

                        Console.WriteLine($"تمت مزامنة جدول {tableName} بنجاح!");

                    }
                    else
                    {
                        Console.WriteLine($"لا توجد بيانات جديدة لمزامنة جدول {tableName}.");
                    }
                }
            }
            catch (Exception ex)
            {
                // تسجيل حالة الفشل في جدول CloudSync
                using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();
                    string logQuery = "INSERT INTO CloudSync (TableName, LastSyncDate, Status) VALUES (@TableName, @LastSyncDate, @Status)";
                    SqlCommand logCommand = new SqlCommand(logQuery, sqlConnection);
                    logCommand.Parameters.AddWithValue("@TableName", tableName);
                    logCommand.Parameters.AddWithValue("@LastSyncDate", DateTime.Now);
                    logCommand.Parameters.AddWithValue("@Status", "Failed");
                    logCommand.ExecuteNonQuery();
                }

                Console.WriteLine($"فشلت مزامنة جدول {tableName}: {ex.Message}");
            }
        }

        private string GetColumns(string tableName)
        {
            // قم بإرجاع أسماء الأعمدة للجدول المحدد
            switch (tableName)
            {
                case "Students":
                    return "StudentID, Name, DateOfBirth, ClassID, ParentID";
                case "Teachers":
                    return "TeacherID, Name, Specialization";
                case "Classes":
                    return "ClassID, ClassName, Level";
                case "Subjects":
                    return "SubjectID, SubjectName, TeacherID";
                case "Attendance":
                    return "AttendanceID, Date, StudentID, Status";
                case "Grades":
                    return "GradeID, StudentID, SubjectID, Marks, ExamDate";
                case "Timetable":
                    return "TimetableID, ClassID, SubjectID, TeacherID, Day, Time";
                case "Activities":
                    return "ActivityID, Name, Description, Date, ClassID";
                default:
                    throw new ArgumentException("جدول غير معروف");
            }
        }

        private string GetValues(DataRow row)
        {
            // قم بإرجاع قيم الأعمدة للسجل المحدد
            string values = "";
            foreach (DataColumn column in row.Table.Columns)
            {
                if (column.ColumnName != "IsSynced") // تجاهل حقل IsSynced
                {
                    values += $"@{column.ColumnName},";
                }
            }
            return values.TrimEnd(',');
        }
    }
}