using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class CandidateUpdateForm : Form
    {
        private Form main;
        OracleConnection conn;
        private int id;
        string ordb = "data source = orcl; user id = hr; password = hr;";
        OracleDataAdapter da;
        DataTable dt;
        public CandidateUpdateForm()
        {
            InitializeComponent();
        }
        public CandidateUpdateForm(Form main, int id)
        {
            InitializeComponent();
            this.main = main;
            this.id = id;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidPassword(string password)
        {
            // Minimum 8 characters
            if (password.Length < 8)
                return false;

            // At least one uppercase letter
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;

            // At least one number
            if (!Regex.IsMatch(password, @"[0-9]"))
                return false;

            // At least one special character
            if (!Regex.IsMatch(password, @"[\W_]")) // \W = non-word characters, _ included
                return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = fname.Text;
            string secondName = lname.Text;
            string city = ct.Text;
            string email = em.Text;
            string password = pass.Text;
            string confirmpassword = cpass.Text;
            string goals = goa.Text;

            //if (firstName == "" || secondName == "" || city == "" || email == "" || goals == "")
            //{
            //    MessageBox.Show("Please fill all fields!");
            //    return;
            //}

            //if (!IsValidEmail(email))
            //{
            //    MessageBox.Show("Please Submit Valid Email");
            //    return;
            //}

            //if (!IsValidPassword(password))
            //{
            //    MessageBox.Show("Please Submit Valid Complex Password like Lolo123#");
            //    return;
            //}
            //if (password != confirmpassword)
            //{
            //    MessageBox.Show("Please Make Sure the Passwords are the same");
            //    return;
            //}

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                row["first_name"] = fname.Text;
                row["last_name"] = lname.Text;
                row["city"] = ct.Text;
                row["email"] = em.Text;
                row["password"] = pass.Text;
                row["goals"] = goa.Text;

                OracleCommandBuilder cb = new OracleCommandBuilder(da);

                da.Update(dt);

                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Failed To Update");
            }
            this.main.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CandidateUpdateForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            da = new OracleDataAdapter();

            da.SelectCommand = new OracleCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandType = CommandType.Text;

            da.SelectCommand.CommandText = "SELECT candidate_id ,first_name, last_name, city, email, password, goals FROM candidates WHERE candidate_id = :id";

            da.SelectCommand.Parameters.Add("id", OracleDbType.Int32).Value = id;

            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                fname.Text = row["first_name"].ToString();
                lname.Text = row["last_name"].ToString();
                ct.Text = row["city"].ToString();
                em.Text = row["email"].ToString();
                pass.Text = row["password"].ToString();
                cpass.Text = row["password"].ToString();
                goa.Text = row["goals"].ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
