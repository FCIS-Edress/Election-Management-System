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
    public partial class Report_Show_Winner : Form
    {
        private Form main;
        Winner_Report CR;
        public Report_Show_Winner(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Show_Winner_Report_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void Report_Show_Winner_Load(object sender, EventArgs e)
        {
            CR = new Winner_Report();
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
