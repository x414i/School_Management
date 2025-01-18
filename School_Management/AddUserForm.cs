using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net; // تأكد من إضافة هذا السطر

namespace School_Management
{
    public partial class AddUserForm : Form
    {
        private string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            // تعبئة ComboBox بالأدوار
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Teacher");
            cmbRole.Items.Add("Parent");
            cmbRole.SelectedIndex = 0; // تحديد العنصر الأول افتراضيًا
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString(); // الحصول على الدور المحدد

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", BCrypt.Net.BCrypt.HashPassword(password)); // تشفير كلمة المرور
                        command.Parameters.AddWithValue("@Role", role); // استخدام الدور المحدد

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields(); // مسح الحقول
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0; // إعادة تعيين ComboBox إلى القيمة الافتراضية
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}