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
using Oracle.DataAccess.Types;
namespace WindowsFormsApp1
{
    public partial class UsersEditForm : Form
    {
        private Form main;
        OracleDataAdapter adapter;
        DataSet ds;
        public UsersEditForm()
        {
            InitializeComponent();
        }

        public UsersEditForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void UsersEditForm_Load(object sender, EventArgs e)
        {
            string ordb = "data source = orcl; user id = hr; password = hr;";
            string cmd = "SELECT * FROM voters";
            adapter = new OracleDataAdapter(cmd, ordb);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Updated!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
