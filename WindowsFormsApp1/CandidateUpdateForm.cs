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
    public partial class CandidateUpdateForm : Form
    {
        private Form main;
        public CandidateUpdateForm()
        {
            InitializeComponent();
        }
        public CandidateUpdateForm(Form main)
        {
            InitializeComponent();
            this.main = main;
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
            string firstName = textBox1.Text;
            string secondName = textBox2.Text;
            string city = textBox3.Text;
            string email = textBox4.Text;
            string password = textBox6.Text;
            string confirmpassword = textBox8.Text;
            string goals = textBox7.Text;

            if (firstName == "" || secondName == "" || city == "" || email == "" || goals == "")
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

            MessageBox.Show($"Update Successful!\n\n" +
                $"Name: {firstName} {secondName}\n" +
                $"City: {city}\n" +
                $"Email: {email}\n" +
                $"Password: {password}");

            // missing the update statements for oracle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }
    }
}
