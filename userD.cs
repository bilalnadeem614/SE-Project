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
    public partial class userD : Form
    {
        public userD()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            schedule schedule = new schedule();
            this.Hide();
            schedule.Show();
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            this.Hide();
            booking.Show();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            history history = new history();
            this.Hide();
            history.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancleB cancleB = new cancleB();
            this.Hide();
            cancleB.Show();
        }
    }
}
