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
    public partial class bookingsC : UserControl
    {
        public bookingsC()
        {
            InitializeComponent();
        }

        void LoadUserHistory()
        {
            // Ensure the session contains a username
            //if (string.IsNullOrEmpty(SE_Project.Login.UserSession.UserName))
            //{
            //    MessageBox.Show("User session is not active. Please log in again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            string connectionString = "Server=127.0.0.1;Database=test;Uid=root;Pwd=12345";
            string query = "SELECT * FROM bookings";
            ;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Use the username from the session
                        //command.Parameters.AddWithValue("@userName", SE_Project.Login.UserSession.UserName);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the data to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bookingsC_Load(object sender, EventArgs e)
        {
            LoadUserHistory();
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            LoadUserHistory();
        }
    }
}
