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
    public partial class UserDashboardForm : Form
    {
        private Form main;
        OracleConnection conn;
        private int id;
        string ordb = "data source = orcl; user id = hr; password = hr;";
        public UserDashboardForm()
        {
            InitializeComponent();
        }
        public UserDashboardForm(Form main , int id)
        {
            InitializeComponent();
            this.main = main;
            this.id = id;
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
            UserUpdateForm userupdateform = new UserUpdateForm(this, id);
            userupdateform.Show();
            this.Hide();
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
        private void button2_Click(object sender, EventArgs e)
        {
            // check if election is running or not
            bool status = get_has_voted();
            bool stat = get_election_status();
            if (status == true && stat == false)
            {
                new UserVoteForm(this, id).Show();
                this.Hide();
            }
            else if (status == false)
            {
                MessageBox.Show("You Already Voted Before");
            }
            else
            {
                MessageBox.Show("You Cannot Vote Right Now");

            }
        }
        private bool get_has_voted()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_has_voted";

            cmd.Parameters.Add("p_id", OracleDbType.Int32).Value = id;

            cmd.Parameters.Add("p_has_voted", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            Oracle.DataAccess.Types.OracleDecimal val =
                (Oracle.DataAccess.Types.OracleDecimal)cmd.Parameters["p_has_voted"].Value;

            int status = val.ToInt32();
            return status == 0;
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

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
