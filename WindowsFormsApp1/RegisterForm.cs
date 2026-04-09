using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        private Form main;

        public RegisterForm()
        {
            InitializeComponent();
        }

        public RegisterForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string secondName = textBox2.Text;
            string birthday = dateTimePicker1.Value.ToShortDateString();
            string gender = comboBox1.SelectedItem.ToString();
            string nationalID = textBox5.Text;
            string city = textBox3.Text;
            string email = textBox5.Text;
            string password = textBox6.Text;
            string confirmpassword = textBox8.Text;

            if (firstName == "" || secondName == "" || nationalID == "" || city == "" || gender == "" || birthday == "" || email == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if(!IsValidEmail(email))
            {
                MessageBox.Show("Please Submit Valid Email");
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Please Submit Valid Complex Password like Lolo123#");
                return;
            }
            if(password!= confirmpassword)
            {
                MessageBox.Show("Please Make Sure the Passwords are the same");
                return;
            }

            MessageBox.Show($"Registration Successful!\n\n" +
                $"Name: {firstName} {secondName}\n" +
                $"Birthday: {birthday}\n" +
                $"Gender: {gender}\n" +
                $"National ID: {nationalID}\n" +
                $"City: {city}\n"+
                $"Email: {email}\n" +
                $"Password: {password}");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
