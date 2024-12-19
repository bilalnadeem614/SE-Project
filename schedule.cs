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
    public partial class schedule : Form
    {
        public schedule()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_BTN_Click(object sender, EventArgs e)
        {
            //string startLocation = startLoc.ToString();
            //string endLocation = endLoc.ToString();

            //if (string.IsNullOrEmpty(startLocation) || string.IsNullOrEmpty(endLocation))
            //{
            //    MessageBox.Show("Please select both start and destination locations.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";

            //using (MySqlConnection connection = new MySqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        string query = "SELECT trainID, trainName, startLoc, endLoc, totalSeats, availableSeats FROM trains WHERE startLoc = @startLoc AND endLoc = @endLoc";

            //        using (MySqlCommand command = new MySqlCommand(query, connection))
            //        {
            //            command.Parameters.AddWithValue("@startLoc", startLocation);
            //            command.Parameters.AddWithValue("@endLoc", endLocation);

            //            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            //            {
            //                DataTable dataTable = new DataTable();
            //                adapter.Fill(dataTable);
            //                trainSchView.DataSource = dataTable;
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            string startLocation = startLoc.Text;
            string endLocation = endLoc.Text;

            if (string.IsNullOrEmpty(startLocation) || string.IsNullOrEmpty(endLocation))
            {
                MessageBox.Show("Please select both start and destination locations.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT trainID, trainName, startLoc, endLoc, totalSeats, availableSeats, pricePerSeat " +
                                   "FROM trains WHERE startLoc = @startLoc AND endLoc = @endLoc";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@startLoc", startLocation);
                        command.Parameters.AddWithValue("@endLoc", endLocation);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                trainSchView.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No trains found for the selected route.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                trainSchView.DataSource = null; // Clear DataGridView
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void book_BTN_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            this.Hide();
            booking.Show();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            userD userD = new userD();
            this.Hide();
            userD.Show();
        }
    }
}
