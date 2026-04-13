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
    }
}
