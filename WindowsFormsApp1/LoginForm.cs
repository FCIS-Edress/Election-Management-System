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
    public partial class LoginForm : Form
    {
        private Form main;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }


        private void label1_Click(object sender, EventArgs e)
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
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            if(!IsValidEmail(textBox1.Text)&& !IsValidPassword(textBox2.Text))
            {
                MessageBox.Show("Invalid credentials");
                return; 
            }
            //if(mawgood)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Invalid credentials");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
