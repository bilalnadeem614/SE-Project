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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            //string name = nameTB.Text.Trim();
            //string email = emailTB.Text.Trim();
            //string password = passwordTB.Text;
            //string confirmPassword = confPassTB.Text;

            //if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
            //string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            //{
            //    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (password != confirmPassword)
            //{
            //    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (password.Length < 8)
            //{
            //    MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (!IsValidEmail(email))
            //{
            //    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //bool IsValidEmail(string email)
            //{
            //    try
            //    {
            //        var addr = new System.Net.Mail.MailAddress(email);
            //        return addr.Address == email;
            //    }
            //    catch
            //    {
            //        return false;
            //    }
            //}

            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            //string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";
            ////MySqlConnection connection = new MySqlConnection(connectionString);
            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        string query = "INSERT INTO users (name, email, password) VALUES (@name, @email, @password)";
            //        using (MySqlCommand command = new MySqlCommand(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@name", name);
            //            command.Parameters.AddWithValue("@email", email);
            //            command.Parameters.AddWithValue("@password", hashedPassword);

            //            int rowsAffected = command.ExecuteNonQuery();
            //            if (rowsAffected > 0)
            //            {
            //                MessageBox.Show("User signed up successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                Login loginForm = new Login();
            //                this.Close();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Sign-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

            string name = nameTB.Text.Trim();
            string email = emailTB.Text.Trim();
            string password = passwordTB.Text;
            string confirmPassword = confPassTB.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash the password
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users (name, email, password) VALUES (@name, @email, @password)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", hashedPassword);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User signed up successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login loginForm = new Login();
                            this.Hide();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sign-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool IsValidEmail(string email)
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }
    }
}
