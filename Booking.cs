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
    public partial class Booking : Form
    {
        decimal tP = 0; //Total Price
        decimal pps= 0; //Price Per Seat
        int tns = 0; //Total Number of Seats
        string trnName = ""; //Train Name
        bool isBerthChecked = false;

        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            userD userD = new userD();
            this.Hide();
            userD.Show();
        }

        private void show_BTN_Click(object sender, EventArgs e)
        {
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

        private void bill_BTN_Click(object sender, EventArgs e)
        {
            if (trainSchView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a train from the schedule.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(noseat_TB.Text) || !int.TryParse(noseat_TB.Text, out int noOfSeats) || noOfSeats <= 0)
            {
                MessageBox.Show("Please enter a valid number of seats.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isBerthChecked = berthChk.Checked;

            int selectedTrainID = Convert.ToInt32(trainSchView.SelectedRows[0].Cells["trainID"].Value);
            string trainName = trainSchView.SelectedRows[0].Cells["trainName"].Value.ToString();
            trnName = trainName;
            int totalSeats = Convert.ToInt32(trainSchView.SelectedRows[0].Cells["totalSeats"].Value);
            int availableSeats = Convert.ToInt32(trainSchView.SelectedRows[0].Cells["availableSeats"].Value);

            if (noOfSeats > availableSeats)
            {
                MessageBox.Show("The number of seats you requested is not available.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tns = noOfSeats;

            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT pricePerSeat FROM trains WHERE trainID = @trainID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@trainID", selectedTrainID);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            decimal pricePerSeat = Convert.ToDecimal(result);
                            pps = pricePerSeat;

                            // Calculate total price
                            decimal totalPrice = pricePerSeat * noOfSeats;

                            if (isBerthChecked)
                            {
                                totalPrice *= 2; // Double the price if berth is selected
                            }
                            tP = totalPrice;

                            // Display the total price in the pricePnl
                            Label priceLabel = new Label
                            {
                                Text = $"Total Price: {totalPrice:C}",
                                AutoSize = true,
                                Font = new Font("Arial", 12, FontStyle.Bold),
                                ForeColor = Color.Black
                            };

                            pricePnl.Controls.Clear(); // Clear any previous content
                            pricePnl.Controls.Add(priceLabel);
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve train details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void pay_BTN_Click(object sender, EventArgs e)
        {
            string startLocation = startLoc.Text;
            string endLocation = endLoc.Text;

            int selectedTrainID = Convert.ToInt32(trainSchView.SelectedRows[0].Cells["trainID"].Value);

            paymentFrm paymentFrm = new paymentFrm(trnName,selectedTrainID, tP, pps, tns, isBerthChecked, startLocation, endLocation);
            this.Hide();
            paymentFrm.Show();

        }
    }
}
