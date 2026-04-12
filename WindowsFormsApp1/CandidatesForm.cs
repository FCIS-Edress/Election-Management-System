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

namespace WindowsFormsApp1
{
    public partial class CandidatesForm : Form
    {
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

        }
        private void button1_Click(object sender, EventArgs e)
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

            // Success message
            MessageBox.Show($"Registration Successful!\n\n" +
                $"Name: {firstName} {lastName}\n" +
                $"Birthday: {birthday}\n" +
                $"Gender: {gender}\n" +
                $"National ID: {nationalID}\n" +
                $"City: {city}\n" +
                $"Email: {email}");
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
    }
}
