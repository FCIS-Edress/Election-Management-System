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
    public partial class CandidateDashboardForm : Form
    {
        private Form main;
        private int id;
        OracleConnection conn;
        string ordb = "data source = orcl; user id = hr; password = hr;";
        public CandidateDashboardForm()
        {
            InitializeComponent();
        }
        public CandidateDashboardForm(Form main , int id)
        {
            InitializeComponent();
            this.main = main;
            this.id = id;
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
            CandidateUpdateForm candidateupdateform = new CandidateUpdateForm(this , id);
            candidateupdateform.Show();
            this.Hide();
        }

        private void CandidateDashboardForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            bool status = get_results_status();
            if (status == true)
                MessageBox.Show("You Cannot See Results Right Now");
            else
            {
                new ResultsForm(this).Show();
                this.Hide();
            }
        }
    }
}
