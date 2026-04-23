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
    public partial class UserVoteForm : Form
    {
        private Form main;

        public UserVoteForm()
        {
            InitializeComponent();
        }

        public UserVoteForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("Sorry Choose a Candidate to Vote or Return back");
                return;
            }
            else
            {
                // bishoy please do the following
                string candidateName=comboBox1.Text;
                // add the counter of this candidate by 1 in the database
                // make the hasVoted flag of this user by true
            }
        }
    }
}
