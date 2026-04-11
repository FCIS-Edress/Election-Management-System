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
    public partial class UserDashboardForm : Form
    {
        private Form main;
        public UserDashboardForm()
        {
            InitializeComponent();
        }
        public UserDashboardForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserUpdateForm userupdateform = new UserUpdateForm(this);
            userupdateform.Show();
            this.Hide();
        }
    }
}
