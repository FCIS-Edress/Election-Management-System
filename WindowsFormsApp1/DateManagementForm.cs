using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DateManagementForm : Form
    {

        private Form main;
        OracleConnection conn;
        string ordb = "data source = orcl; user id = hr; password = hr;";
        public DateManagementForm()
        {
            InitializeComponent();
        }
        public DateManagementForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime _StartDate = dateTimePicker1.Value.Date;
            DateTime _EndDate = dateTimePicker2.Value.Date;
            DateTime now = DateTime.Now.Date;

            if (_StartDate < now)
            {
                MessageBox.Show("Start date cannot be in the past.");
                return;
            }

            if (_EndDate <= _StartDate)
            {
                MessageBox.Show("End date must be after start date.");
                return;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"
        INSERT INTO elections 
        (election_id, start_date, end_date, is_running, show_results)
        VALUES 
        (elections_seq.NEXTVAL, :startDate, :endDate, 0, 0)";

            cmd.Parameters.Add("startDate", OracleDbType.Date).Value = _StartDate;
            cmd.Parameters.Add("endDate", OracleDbType.Date).Value = _EndDate;

            cmd.ExecuteNonQuery();

            MessageBox.Show("Election created successfully");

            this.main.Show();
            this.Close();
        }

        private void DateManagementForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
