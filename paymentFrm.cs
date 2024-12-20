using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static SE_Project.Login.UserSession;
namespace SE_Project
{
    public partial class paymentFrm : Form
    {       
        private string TrainName;
        private int TrainID;
        private decimal TotalPrice;
        private decimal PricePerSeat;
        private int TotalNSeats;
        bool isBerth = false;
        private string StartLocation;
        private string EndLocation;
        public paymentFrm(string trainName, int trainID, decimal totalPrice, decimal pricePerSeat, int totalNSeats, bool isBerth, string startLocation, string endLocation)
        {
            TrainName = trainName;
            TrainID = trainID;
            TotalPrice = totalPrice;
            PricePerSeat = pricePerSeat;
            TotalNSeats = totalNSeats;
            InitializeComponent();
            this.isBerth = isBerth;
            StartLocation = startLocation;
            EndLocation = endLocation;
        }

        private void paymentFrm_Load(object sender, EventArgs e)
        {
            // Clear existing controls in the panel
            paymentInfo.Controls.Clear();

            // Create and add a title label
            Label titleLabel = new Label();
            titleLabel.Text = "Payment Information";
            titleLabel.Font = new System.Drawing.Font("Arial", 20, FontStyle.Bold);
            titleLabel.Location = new Point(10, 10);
            titleLabel.AutoSize = true;
            paymentInfo.Controls.Add(titleLabel);
            // Create and add labels for payment details

            int startY = 50; // Starting Y position for details
            int spacing = 30; // Spacing between labels

            Label trainNameLabel = new Label();
            trainNameLabel.Text = $"Train Name: {TrainName}";
            trainNameLabel.Location = new Point(10, startY);
            trainNameLabel.AutoSize = true;
            paymentInfo.Controls.Add(trainNameLabel);

            Label trainIDLabel = new Label();
            trainIDLabel.Text = $"Train ID: {TrainID}";
            trainIDLabel.Location = new Point(10, startY + spacing);
            trainIDLabel.AutoSize = true;
            paymentInfo.Controls.Add(trainIDLabel);

            Label pricePerSeatLabel = new Label();
            pricePerSeatLabel.Text = $"Price Per Seat: {PricePerSeat:C}";
            pricePerSeatLabel.Location = new Point(10, startY + 2 * spacing);
            pricePerSeatLabel.AutoSize = true;
            paymentInfo.Controls.Add(pricePerSeatLabel);

            Label totalSeatsLabel = new Label();
            totalSeatsLabel.Text = $"Number of Seats: {TotalNSeats}";
            totalSeatsLabel.Location = new Point(10, startY + 3 * spacing);
            totalSeatsLabel.AutoSize = true;
            paymentInfo.Controls.Add(totalSeatsLabel);

            Label totalPriceLabel = new Label();
            totalPriceLabel.Text = $"Total Price: {TotalPrice:C}";
            totalPriceLabel.Location = new Point(10, startY + 4 * spacing);
            totalPriceLabel.AutoSize = true;
            paymentInfo.Controls.Add(totalPriceLabel);

        }

        private void pymntBTN_Click(object sender, EventArgs e)
        {
            // Validate Bank Selection
            if (bankOp.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a bank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Account Number
            string accno = accNo.Text.Trim();
            if (string.IsNullOrEmpty(accno) || accno.Length != 11 || !accno.All(char.IsDigit))
            {
                MessageBox.Show("Account number must be an 11-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate PIN
            string pinNo = pin.Text.Trim();
            if (pinNo.Length < 3 || pinNo.Length > 4 || !pinNo.All(char.IsDigit))
            {
                MessageBox.Show("PIN must be 3-4 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If validations pass, process payment
            try
            {
                // Update available seats in the database
                string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Reduce available seats
                    string updateSeatsQuery = "UPDATE trains SET availableSeats = availableSeats - @bookedSeats WHERE trainID = @trainID";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateSeatsQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@bookedSeats", TotalNSeats); // Assuming totalNSeats is passed
                        updateCommand.Parameters.AddWithValue("@trainID", TrainID);        // Assuming TrainID is passed
                        updateCommand.ExecuteNonQuery();
                    }

                    // Insert into bookings table
                    string insertBookingQuery = "INSERT INTO bookings (trainID, userName, bookedSeats, berth, startLoc, endLoc, totalPrice, bookedAt) " +
                                                "VALUES (@trainID, @userName, @bookedSeats, @berth, @startLoc, @endLoc, @totalPrice, NOW())";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertBookingQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@trainID", TrainID);
                        insertCommand.Parameters.AddWithValue("@userName", SE_Project.Login.UserSession.UserName.ToString());
                        insertCommand.Parameters.AddWithValue("@bookedSeats", TotalNSeats);
                        insertCommand.Parameters.AddWithValue("@berth", isBerth ? 1 : 0);
                        insertCommand.Parameters.AddWithValue("@startLoc", StartLocation);
                        insertCommand.Parameters.AddWithValue("@endLoc", EndLocation);
                        insertCommand.Parameters.AddWithValue("@totalPrice", TotalPrice);
                        insertCommand.ExecuteNonQuery();
                    }
                }

                // Generate Ticket PDF
                SaveTicketAsPDF();

                MessageBox.Show("Payment successful! Your ticket has been booked.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the payment form
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveTicketAsPDF()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RailwayTickets");

            // Ensure the directory exists
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = $"Ticket_{TrainName}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string fullPath = Path.Combine(folderPath, fileName);

            using (var doc = new iTextSharp.text.Document())
            {
                //iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(fullPath, FileMode.Create));
                doc.Open();
                doc.Add(new iTextSharp.text.Paragraph("Train Ticket"));
                doc.Add(new iTextSharp.text.Paragraph($"Train Name: {TrainName}"));
                doc.Add(new iTextSharp.text.Paragraph($"Booked By: {SE_Project.Login.UserSession.UserName.ToString()}"));
                doc.Add(new iTextSharp.text.Paragraph($"No. of Seats: {TotalNSeats}"));
                doc.Add(new iTextSharp.text.Paragraph($"Berth Booked: {(isBerth ? "Yes" : "No")}"));
                doc.Add(new iTextSharp.text.Paragraph($"Start Location: {StartLocation}"));
                doc.Add(new iTextSharp.text.Paragraph($"End Location: {EndLocation}"));
                doc.Add(new iTextSharp.text.Paragraph($"Total Payment: {TotalPrice:C}"));
                doc.Close();
            }

            MessageBox.Show($"Ticket has been saved successfully at {fullPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            userD userDashboard = new userD();
            this.Hide();
            userDashboard.Show();
        }

    }
}
