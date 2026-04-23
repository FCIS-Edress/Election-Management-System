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
    public partial class CandidateDashboardForm : Form
    {
        private Form main;
        public CandidateDashboardForm()
        {
            InitializeComponent();
        }
        public CandidateDashboardForm(Form main)
        {
            InitializeComponent();
            this.main = main;
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
            CandidateUpdateForm candidateupdateform = new CandidateUpdateForm(this);
            candidateupdateform.Show();
            this.Hide();
        }

        private void CandidateDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
