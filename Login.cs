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

namespace SE_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT password, role FROM users WHERE email = @Email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader["password"].ToString();
                                int role = Convert.ToInt32(reader["role"]);

                                // Step 4: Verify password
                                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                {
                                    // Step 5: Determine role and navigate accordingly
                                    if (role == 1)
                                    {
                                        MessageBox.Show("Welcome Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        adminD adminDashboard = new adminD();
                                        this.Hide();
                                        adminDashboard.Show();
                                    }
                                    else if (role == 2)
                                    {
                                        MessageBox.Show("Welcome User!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        userD userDashboard = new userD();
                                        this.Hide();
                                        userDashboard.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unknown role assigned. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No user found with this email. Please sign up first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log exception and show user-friendly message
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("An unexpected error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
