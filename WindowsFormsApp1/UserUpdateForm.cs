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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class UserUpdateForm : Form
    {
        private Form main;
        OracleConnection conn;
        private int id;
        string ordb = "data source = orcl; user id = hr; password = hr;";
        public UserUpdateForm()
        {
            InitializeComponent();
        }

        public UserUpdateForm(Form main, int id)
        {
            InitializeComponent();
            this.main = main;
            this.id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = fname.Text;
            string secondName = lname.Text;
            string city = this.ct.Text;
            string email = em.Text;
            string password = pass.Text;
            string confirmpassword = cpass.Text;

            if (firstName == "" || secondName == "" || city == "" || email == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please Submit Valid Email");
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Please Submit Valid Complex Password like Lolo123#");
                return;
            }
            if (password != confirmpassword)
            {
                MessageBox.Show("Please Make Sure the Passwords are the same");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = @"
        UPDATE voters
        SET 
            first_name = :fname,
            last_name = :lname,
            city = :city,
            email = :email,
            password = :pass
        WHERE voter_id = :id";

            cmd.Parameters.Add("fname", OracleDbType.Varchar2).Value = fname.Text;
            cmd.Parameters.Add("lname", OracleDbType.Varchar2).Value = lname.Text;
            cmd.Parameters.Add("city", OracleDbType.Varchar2).Value = ct.Text;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = em.Text;
            cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = pass.Text;

            cmd.Parameters.Add("id", OracleDbType.Int32).Value = id;

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Updated successfully");
            else
                MessageBox.Show("Update failed");
            this.main.Show();
            this.Close();

        }
        private bool IsValidEmail(string email)
        {
            //try
            //{
            //    var addr = new MailAddress(email);
            //    return addr.Address == email;
            //}
            //catch
            //{
            //    return false;
            //}
            return true;
        }

        public bool IsValidPassword(string password)
        {
            //// Minimum 8 characters
            //if (password.Length < 8)
            //    return false;

            //// At least one uppercase letter
            //if (!Regex.IsMatch(password, @"[A-Z]"))
            //    return false;

            //// At least one number
            //if (!Regex.IsMatch(password, @"[0-9]"))
            //    return false;

            //// At least one special character
            //if (!Regex.IsMatch(password, @"[\W_]")) // \W = non-word characters, _ included
            //    return false;

            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void UserUpdateForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT first_name, last_name, city, email , password FROM voters WHERE voter_id = :id";

            cmd.Parameters.Add("id", OracleDbType.Int32).Value = id;

            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                fname.Text = reader["first_name"].ToString();
                lname.Text = reader["last_name"].ToString();
                ct.Text = reader["city"].ToString();
                em.Text = reader["email"].ToString();
                pass.Text = reader["password"].ToString();
                cpass.Text = reader["password"].ToString();
            }
            reader.Close();

        }
    }


}
