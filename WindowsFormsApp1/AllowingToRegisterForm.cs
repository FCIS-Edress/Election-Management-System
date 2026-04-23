using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AllowingToRegisterForm : Form
    {
        private Form main;

        public AllowingToRegisterForm()
        {
            InitializeComponent();
        }

        public AllowingToRegisterForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AllowingToRegisterForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string FirstPIN = textBox1.Text;
            string SecondPIN = textBox2.Text;
            string ThirdPIN = textBox3.Text;
            string FourthPIN = textBox4.Text;
            

            if ( FirstPIN == "" || SecondPIN == "" || ThirdPIN == "" || FourthPIN == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }
            int firstPIN = Convert.ToInt32(FirstPIN);
            int secondPIN = Convert.ToInt32(SecondPIN);
            int thirdPIN = Convert.ToInt32(ThirdPIN);
            int fourthPIN = Convert.ToInt32(FourthPIN);

            int result = firstPIN * secondPIN * thirdPIN * fourthPIN;

            int _Admin = (int)((Math.Pow(firstPIN - 7, 2) - 49) * (Math.Pow(thirdPIN + 6, 2) - 36));// (x+7)(x-7)(x-6)(x+6)
            int _Candidate = (int)((Math.Pow(firstPIN + 5, 2) - 25) * (Math.Pow(thirdPIN + 4, 2) - 16));// (x-5)(x+5)(x-4)(x+4)
            int _Voter = (int)((Math.Pow(firstPIN + 3, 2) - 9) * (Math.Pow(thirdPIN - 2, 2) - 4));// (x-3)(x+3)(x+2)(x-2)

            if (result == _Admin)
            {
                  // remove
            }
            else if(result == _Candidate)
            {
                CandidatesForm candidateform = new CandidatesForm(this);
                candidateform.Show();
                this.Hide();
            }
            else if(result == _Voter)
            {
                RegisterForm registerform = new RegisterForm(this);
                registerform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid PIN!");
                return;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
