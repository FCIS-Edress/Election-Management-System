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
    public partial class CandidatesEditForm : Form
    {
        private Form main;
        OracleDataAdapter adapter;
        DataSet ds;
        private string mode;
        public CandidatesEditForm()
        {
            InitializeComponent();
        }

        public CandidatesEditForm(Form main , string mode)
        {
            InitializeComponent();
            this.main = main;
            this.mode = mode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Updated!");
        }

        private void CandidatesEditForm_Load(object sender, EventArgs e)
        {
            string ordb = "data source = orcl; user id = hr; password = hr;";
            string cmd;
            if (mode == "edit")
                cmd = "SELECT * FROM candidates";
            else
                cmd = "SELECT CANDIDATE_ID , NATIONAL_ID, IS_ACCEPTED FROM candidates";
            adapter = new OracleDataAdapter(cmd, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
