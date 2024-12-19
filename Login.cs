using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
//using WcfService2;
using ServiceReference1;

namespace SE_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static class UserSession
        {
            public static string Email { get; set; }
            public static int Role { get; set; }
            public static string UserName { get; set; } // New property for storing the user's name
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }


        private void signupBtn_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            this.Hide();
            signupForm.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text.Trim();
            string password = passwordTB.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Both Email and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

            Service1Client client = new Service1Client();
            int role = client.LoginUserAsync(email, password).Result;

            if (role == 1 || role == 2)
            {
                UserSession.Email = email; // Store email in session
                UserSession.Role = role;   // Store role in session

                // Fetch the user's name based on email
                string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name FROM users WHERE email = @Email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            UserSession.UserName = result.ToString(); // Store user name in session
                        }
                    }
                }

                if (role == 1)
                {
                    MessageBox.Show($"Welcome Admin, {UserSession.UserName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adminD adminDashboard = new adminD();
                    this.Hide();
                    adminDashboard.Show();
                }
                else if (role == 2)
                {
                    MessageBox.Show($"Welcome User, {UserSession.UserName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userD userDashboard = new userD();
                    this.Hide();
                    userDashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            client.Close();
        }
    }
}
