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
    public partial class Report_Show_Has_Voted : Form
    {
        private Form main;
        Report_Voters CR;
        public Report_Show_Has_Voted(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void Report_Show_Has_Voted_Load(object sender, EventArgs e)
        {
            CR = new Report_Voters();
            crystalReportViewer1.ReportSource = CR;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }
    }
}
