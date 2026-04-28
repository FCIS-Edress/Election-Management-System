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
    public partial class Report_Show_Election : Form
    {
        private Form main;
        Election_filter CR;
        public Report_Show_Election(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Report_Show_Election_Load(object sender, EventArgs e)
        {
            CR = new Election_filter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, dateTimePicker1.Value.Date);
            CR.SetParameterValue(1, dateTimePicker2.Value.Date);
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
