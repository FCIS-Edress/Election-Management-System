using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminDashboardForm : Form
    {
        private Form main;

        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        public AdminDashboardForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateManagementForm datemanagementform = new DateManagementForm(this);
            datemanagementform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // bishoy make the flag true IsElectionRunning
            // before that check if it's value is true 
            //if(IsElectionRunning== true)
            {
                MessageBox.Show("Elections are already Running");
            }
            //else
            {
                MessageBox.Show("Elections Started");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // bishoy make the flag false IsElectionRunning
            // before that check if it's value is false
            //if(IsElectionRunning== False)
            {
                MessageBox.Show("Elections are already Stopped");
            }
            //else
            {
                MessageBox.Show("Elections Ended");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // bishoy make the flag true ShowResults 
            // before that check if it's value is false
            //if(showresults == true)
            {
                MessageBox.Show("Show Results Turned off");
            }
            //else(showresults == false)
            {
                MessageBox.Show("Show Results Turned on");
            }
        }
    }
}
