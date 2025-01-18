using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net; // تثبيت المكتبة عبر NuGet: Install-Package BCrypt.Net-Next

namespace School_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Connection string to the database
                string connectionString = "Server=DESKTOP-J4JJ3J7\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get user details
                    string query = "SELECT Password, Role FROM Users WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader["Password"].ToString();
                                string role = reader["Role"].ToString();

                                // Verify the password
                                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                {
                                    MessageBox.Show("Login successful! Role: " + role, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Redirect to the appropriate form based on role
                                    switch (role)
                                    {
                                        case "Admin":
                                            MainForm adminForm = new MainForm();
                                            adminForm.Show();
                                            break;
                                        case "Teacher":
                                            //TeacherForm teacherForm = new TeacherForm();
                                            //teacherForm.Show();
                                            break;
                                        case "Parent":
                                            //ParentForm parentForm = new ParentForm();
                                            //parentForm.Show();
                                            break;
                                    }

                                    this.Hide(); // Hide the login form
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // يمكنك إضافة أي تهيئة إضافية هنا
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // يمكنك إضافة أي منطق إضافي هنا
        }
    }
}