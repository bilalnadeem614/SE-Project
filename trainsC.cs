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
    public partial class trainsC : UserControl
    {
        public trainsC()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        void LoadTrainsIntoGrid()
        {
            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT trainID AS 'Train ID', trainName AS 'Train Name', startLoc AS 'Start Location', endLoc AS 'End Location', totalSeats AS 'Total Seats', availableSeats AS 'Available Seats', pricePerSeat AS 'Price Per Seat' FROM trains";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable trainsTable = new DataTable();
                        adapter.Fill(trainsTable);
                        trainsGridView.DataSource = trainsTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading trains: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void trainsC_Load(object sender, EventArgs e)
        {
            LoadTrainsIntoGrid();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";
            string trainName = trainNameTB.Text;
            string startloc = startLoc.Text;
            string endloc = endLoc.Text;
            int totalSeats = Convert.ToInt32(tSeats.Text);
            int availableSeats = Convert.ToInt32(avlSeats.Text);
            decimal pricePerSeat = Convert.ToDecimal(ppS.Text);

            if (string.IsNullOrEmpty(trainName) ||
                string.IsNullOrEmpty(startloc) ||
                string.IsNullOrEmpty(endloc) ||
                !int.TryParse(tSeats.Text, out totalSeats) ||
                !decimal.TryParse(ppS.Text, out pricePerSeat))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (availableSeats>totalSeats)
            {
                MessageBox.Show("Availabe Seats should not be greater than Total Seats", "Validation Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (addTrainRB.Checked) // Add Train
                    {
                        string insertQuery = "INSERT INTO trains (trainName, startLoc, endLoc, totalSeats, availableSeats, pricePerSeat) VALUES (@trainName, @startLoc, @endLoc, @totalSeats, @availableSeats, @pricePerSeat)";
                        using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@trainName", trainName);
                            command.Parameters.AddWithValue("@startLoc", startLoc.Text);
                            command.Parameters.AddWithValue("@endLoc", endLoc.Text);
                            command.Parameters.AddWithValue("@totalSeats", totalSeats);
                            command.Parameters.AddWithValue("@availableSeats", availableSeats);
                            command.Parameters.AddWithValue("@pricePerSeat", pricePerSeat);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Train added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (updateTrainRB.Checked) // Update Train
                    {
                        if (trainsGridView.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Please select a train to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int trainId = Convert.ToInt32(trainsGridView.SelectedRows[0].Cells["Train ID"].Value);

                        string updateQuery = "UPDATE trains SET trainName = @trainName, startLoc = @startLoc, endLoc = @endLoc, totalSeats = @totalSeats, availableSeats = @availableSeats, pricePerSeat = @pricePerSeat WHERE trainID = @trainID";
                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@trainName", trainName);
                            command.Parameters.AddWithValue("@startLoc", startLoc);
                            command.Parameters.AddWithValue("@endLoc", endLoc);
                            command.Parameters.AddWithValue("@totalSeats", totalSeats);
                            command.Parameters.AddWithValue("@availableSeats", totalSeats); // Reset available seats
                            command.Parameters.AddWithValue("@pricePerSeat", pricePerSeat);
                            command.Parameters.AddWithValue("@trainID", trainId);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Train updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to update train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an operation: Add Train or Update Train.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Reload grid
                    LoadTrainsIntoGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";

            if (!updateTrainRB.Checked)
            {
                MessageBox.Show("Please select the 'Update Train' option to delete a train.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trainsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a train to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int trainId = Convert.ToInt32(trainsGridView.SelectedRows[0].Cells["Train ID"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this train?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM trains WHERE trainID = @trainID";
                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@trainID", trainId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Train deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete train.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    LoadTrainsIntoGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
