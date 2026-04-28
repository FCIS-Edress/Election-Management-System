using Oracle.DataAccess.Client;
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
        OracleConnection conn;
        string ordb = "data source = orcl; user id = hr; password = hr;";

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
            bool status = get_election_status();
            if (status == false)
                MessageBox.Show("All Election Already Opened");
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE elections SET is_running = 1";
                cmd.ExecuteNonQuery();
                MessageBox.Show("All Election Opened");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool status = get_election_status();
            if (status == true)
                MessageBox.Show("All Election Already Closed");
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE elections SET is_running = 0";
                cmd.ExecuteNonQuery();
                MessageBox.Show("All Election Closed");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool status = get_election_status();
            if (status == false)
                MessageBox.Show("Cannot Show While Election Is Running");
            else
            {
                new UsersEditForm(this).Show();
                this.Hide();
            }
        }
        private bool get_results_status()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_results_status";

            cmd.Parameters.Add("p_status", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            int status = ((Oracle.DataAccess.Types.OracleDecimal)cmd.Parameters[0].Value).ToInt32();

            return status == 0; 
        }
        private bool get_election_status()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_election_status";

            cmd.Parameters.Add("p_status", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            int status = ((Oracle.DataAccess.Types.OracleDecimal)cmd.Parameters[0].Value).ToInt32();
            return status == 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool status = get_results_status();

            if (status == false)
                MessageBox.Show("Results already opened");
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE elections SET show_results = 1";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Results opened");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool status = get_election_status();
            if (status == false)
                MessageBox.Show("Cannot Show While Election Is Running");
            else
            {
                new CandidatesEditForm(this, "edit").Show();
                this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new ResultsForm(this).Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = get_election_status();
            if (status == false)
                MessageBox.Show("Cannot Accept Or Reject While Election Is Running");
            else
            {
                new CandidatesEditForm(this, "Approve").Show();
                this.Hide();
            }
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool status = get_results_status();

            if (status == true)
                MessageBox.Show("Results already closed");
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE elections SET show_results = 0";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Results Closed");
            }

        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            Report_Show_Has_Voted rp1 = new Report_Show_Has_Voted(this);
            rp1.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Report_Show_Election rp2 = new Report_Show_Election(this);
            rp2.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Report_Show_Winner rp3 = new Report_Show_Winner(this);
            rp3.Show();
            this.Hide();
        }
    }
}
