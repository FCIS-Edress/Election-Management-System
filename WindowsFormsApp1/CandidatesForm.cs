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
using Oracle.DataAccess.Types;

namespace WindowsFormsApp1
{
    public partial class CandidatesForm : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id = hr; password = hr;";

        private Form main;
        public CandidatesForm()
        {
            InitializeComponent();
        }
        public CandidatesForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void CandidatesForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        // Letters-only validation
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        // Numbers-only validation
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // Email validation
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

        // Password validation: 8+ chars, 1 uppercase, 1 number, 1 special
        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;
            if (!Regex.IsMatch(password, @"[0-9]"))
                return false;
            if (!Regex.IsMatch(password, @"[\W_]"))
                return false;
            return true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string birthday = dateTimePicker1.Value.ToShortDateString();
            string gender = comboBox1.SelectedItem?.ToString();
            string nationalID = textBox5.Text;
            string city = textBox3.Text;
            string email = textBox4.Text;
            string password = textBox6.Text;
            string confirmPassword = textBox8.Text;
            string goals = textBox7.Text;

            // Basic field validation
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(nationalID) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(goals))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            // Email validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please submit a valid email!");
                return;
            }

            // Password validation
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters, include 1 uppercase, 1 number, and 1 special character.");
                return;
            }

            // Confirm password
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO candidates 
    (first_name, last_name, birthday, gender, national_id, city, email, password, goals, is_accepted)
    VALUES 
    (:first_name, :last_name, :birthday, :gender, :national_id, :city, :email, :password, :goals, 0)";

            cmd.Parameters.Add("first_name", OracleDbType.Varchar2).Value = firstName;
            cmd.Parameters.Add("last_name", OracleDbType.Varchar2).Value = lastName;
            cmd.Parameters.Add("birthday", OracleDbType.Date).Value = dateTimePicker1.Value;
            cmd.Parameters.Add("gender", OracleDbType.Varchar2).Value = gender;
            cmd.Parameters.Add("national_id", OracleDbType.Varchar2).Value = nationalID;
            cmd.Parameters.Add("city", OracleDbType.Varchar2).Value = city;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
            cmd.Parameters.Add("goals", OracleDbType.Varchar2).Value = goals;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration Successful!");
            this.main.Show();
            this.Close();

        }
    }
}
