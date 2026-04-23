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
    public partial class UsersEditForm : Form
    {
        private Form main;

        public UsersEditForm()
        {
            InitializeComponent();
        }

        public UsersEditForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // bishoy please save the database new records using disconnected mode 
        }

        private void UsersEditForm_Load(object sender, EventArgs e)
        {
            // bishoy please load the database here in the data grid view 
        }
    }
}
