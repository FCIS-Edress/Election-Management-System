using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
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
    public partial class LoginForm : Form
    {
        private Form main;
        OracleConnection conn;
        string ordb = "data source = orcl; user id = hr; password = hr;";
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
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
        private int get_user_id(string email , string role)
        {
            int id = 0;
            OracleCommand idCmd = new OracleCommand();
            idCmd.Connection = conn;
            idCmd.CommandType = CommandType.Text;
            idCmd.Parameters.Add("email", email);
            if (role == "admin")
                idCmd.CommandText = "SELECT admin_id FROM admins WHERE email = :email";
            else if (role == "candidate")
                idCmd.CommandText = "SELECT candidate_id FROM candidates WHERE email = :email";
            else
                idCmd.CommandText = "SELECT voter_id FROM voters WHERE email = :email";
            object result = idCmd.ExecuteScalar();
            if (result != null)
                id = Convert.ToInt32(result);
            return id;
        }
        private void button1_Click(object sender, EventArgs e) {
            //if (!IsValidEmail(emailbox.Text) || !IsValidPassword(passbox.Text))
            //{
            //    MessageBox.Show("Invalid credentials");
            //    return;
            //}

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "login_check";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("res", OracleDbType.RefCursor , ParameterDirection.Output);

            OracleDataReader reader = cmd.ExecuteReader();

            bool found = false;
            while (reader.Read())
            {
                string email = reader[0].ToString().Trim();
                string password = reader[1].ToString().Trim();
                string role = reader[2].ToString().Trim();

                if (email == emailbox.Text.Trim() && password == passbox.Text.Trim())
                {
                    found = true;
                    int id;
                    if (role == "admin")
                    {
                        new AdminDashboardForm(this).Show();
                    }
                    else if (role == "candidate")
                    {
                        id = get_user_id(email, role);
                        new CandidateDashboardForm(this , id).Show();
                    }
                    else
                    {
                        id = get_user_id(email, role);
                        new UserDashboardForm(this , id).Show();
                    }
                    this.Hide();
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Wrong Email OR Password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.main.Show();
            this.Close();
        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
