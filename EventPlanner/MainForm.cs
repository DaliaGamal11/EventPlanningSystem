using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPlanner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new GuestForm().ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EventForm().ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new InvitationForm().ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aboutMessage = "Event Planner\n" +
                                  "Version 1.0\n" +
                                  "Developed by Dalia Gamal ❤️\n\n" +
                                  "This application helps you manage events, guests, and invitations easily and efficiently.\n" +
                                  "© 2025 All rights reserved.";

            MessageBox.Show(aboutMessage, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Search_bt_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}
