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
    public partial class adminD : Form
    {
        public adminD()
        {
            InitializeComponent();
        }

        private void bookngsBTN_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.Controls.Clear();
            bookingsC bookings = new bookingsC();
            panel1.Controls.Add(bookings);
        }

        private void usrBTN_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.Controls.Clear();
            usersC users = new usersC();
            panel1.Controls.Add(users);
        }

        private void TrnsBTN_Click(object sender, EventArgs e)
        {
            trainsC trainsC = new trainsC();
            panel1.Controls.Clear();
            panel1.Controls.Add(trainsC);
        }
    }
}
