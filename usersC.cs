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
    public partial class usersC : UserControl
    {
        public usersC()
        {
            InitializeComponent();
        }

        void LoadUsersIntoGrid()
        {
            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT user_id AS 'User ID', name AS 'Name', email AS 'Email', role AS 'Role', created_at AS 'Created At' FROM users";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable usersTable = new DataTable();
                        adapter.Fill(usersTable);
                        usersGridView.DataSource = usersTable; // Assuming your DataGridView is named "usersGridView"
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void usersC_Load(object sender, EventArgs e)
        {
            LoadUsersIntoGrid();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";
            string name = nameTB.Text;
            string email = emailTB.Text;
            string password = passwordTB.Text;
            int role = rollCB.SelectedIndex+1;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (addUserRB.Checked) // If "Add User" radio button is selected
                    {
                        string insertQuery = "INSERT INTO users (name, email, password, role) VALUES (@name, @email, @password, @role)";
                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@password", hashedPassword);
                            command.Parameters.AddWithValue("@role", role);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //LoadUsersIntoGrid();
                            }
                            else
                            {
                                MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else if (updateUserRB.Checked) // If "Update User" radio button is selected
                    {
                        if (usersGridView.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Please select a user to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Get the selected user's ID
                        int userId = Convert.ToInt32(usersGridView.SelectedRows[0].Cells["User ID"].Value);

                        string updateQuery = "UPDATE users SET name = @name, email = @email, role = @role WHERE user_id = @user_id";
                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@role", role);
                            command.Parameters.AddWithValue("@user_id", userId);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //LoadUsersIntoGrid();
                            }
                            else
                                MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an operation: Add User or Update User.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Reload the data grid view after operation
                    LoadUsersIntoGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;"; // Update with your database credentials

            // Check if "Update User" radio button is selected
            if (!updateUserRB.Checked)
            {
                MessageBox.Show("Please select the 'Update User' option to delete a user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure a user is selected from the DataGridView
            if (usersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the User ID of the selected user
            int userId = Convert.ToInt32(usersGridView.SelectedRows[0].Cells["User ID"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM users WHERE user_id = @user_id";
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", userId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Reload the DataGridView to reflect the changes
                    LoadUsersIntoGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
