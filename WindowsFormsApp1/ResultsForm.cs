using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ResultsForm : Form
    {
        private Form main;

        public ResultsForm()
        {
            InitializeComponent();
        }

        public ResultsForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            // bishoy please load these results only
            // this is an example of the needed results

            //            SELECT
            //    c.candidate_name,
            //    c.party,
            //    COUNT(v.vote_id) AS total_votes
            //FROM votes v
            //JOIN candidates c ON v.candidate_id = c.candidate_id
            //GROUP BY c.candidate_name, c.party
            //ORDER BY total_votes DESC;
        }
    }
}
