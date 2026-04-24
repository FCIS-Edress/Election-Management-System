using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserVoteForm : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id = hr; password = hr;";
        private Form main;
        private int id;
        public UserVoteForm()
        {
            InitializeComponent();
        }

        public UserVoteForm(Form main , int id)
        {
            InitializeComponent();
            this.main = main;
            this.id = id;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a candidate");
                return;
            }

            int candidate_id = Convert.ToInt32(comboBox1.SelectedValue);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO votes (voter_id, candidate_id, vote_date) VALUES (:voter_id, :candidate_id, SYSDATE)";
            cmd.Parameters.Add("voter_id", OracleDbType.Int32).Value = id;
            cmd.Parameters.Add("candidate_id", OracleDbType.Int32).Value = candidate_id;
            cmd.ExecuteNonQuery();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "UPDATE candidates SET votes_count = NVL(votes_count, 0) + 1 WHERE candidate_id = :candidate_id";
            cmd2.Parameters.Add("candidate_id", OracleDbType.Int32).Value = candidate_id;
            cmd2.ExecuteNonQuery();

            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "UPDATE voters SET has_voted = 1 WHERE voter_id = :voter_id";
            cmd3.Parameters.Add("voter_id", OracleDbType.Int32).Value = id;
            cmd3.ExecuteNonQuery();

            MessageBox.Show("Vote Submitted!");
            this.main.Show();
            this.Close();
        }

        private void UserVoteForm_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"
                    SELECT 
                        candidate_id,
                        first_name || ' ' || last_name || ' (ID: ' || candidate_id || ')' AS full_name
                    FROM candidates
                    WHERE is_accepted = 1";

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "full_name";
            comboBox1.ValueMember = "candidate_id";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is DataRowView)
                return;

            int id = Convert.ToInt32(comboBox1.SelectedValue);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT goals FROM candidates WHERE candidate_id = :id";
            cmd.Parameters.Add("id", OracleDbType.Int32).Value = id;

            object result = cmd.ExecuteScalar();

            goa.Text = result?.ToString();
        }
    }
}
