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
    public partial class cancleB : Form
    {
        public cancleB()
        {
            InitializeComponent();
        }

        void LoadRecentBookings()
        {
            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345";
            string query = @"SELECT bookingID, trainID, startLoc, endLoc, bookedSeats, berth, totalPrice, bookedAt 
                     FROM bookings 
                     WHERE userName = @userName AND TIMESTAMPDIFF(MINUTE, bookedAt, NOW()) <= 30";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", Login.UserSession.UserName); // Assuming session stores the user's name.

                    try
                    {
                        connection.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table; // Assuming dataGridView1 is the DataGridView.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading bookings: " + ex.Message);
                    }
                }
            }
        }


        private void cancleB_Load(object sender, EventArgs e)
        {
            LoadRecentBookings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }

            int bookingID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["bookingID"].Value);
            int trainID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["trainID"].Value);
            int bookedSeats = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["bookedSeats"].Value);

            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345";
            string deleteBookingQuery = "DELETE FROM bookings WHERE bookingID = @bookingID";
            string updateSeatsQuery = "UPDATE trains SET availableSeats = availableSeats + @bookedSeats WHERE trainID = @trainID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete booking
                        using (MySqlCommand deleteCommand = new MySqlCommand(deleteBookingQuery, connection, transaction))
                        {
                            deleteCommand.Parameters.AddWithValue("@bookingID", bookingID);
                            deleteCommand.ExecuteNonQuery();
                        }

                        // Update available seats
                        using (MySqlCommand updateCommand = new MySqlCommand(updateSeatsQuery, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@bookedSeats", bookedSeats);
                            updateCommand.Parameters.AddWithValue("@trainID", trainID);
                            updateCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Booking canceled successfully.");
                        LoadRecentBookings(); // Refresh the DataGridView
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error canceling booking: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            userD userD = new userD();
            this.Hide();
            userD.Show();
        }
    }
}
