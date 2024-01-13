using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private string storedPassword;
        private void logIn_Click(object sender, EventArgs e)
        {

          
            if (username.Text == "lalalisa" && password.Text == storedPassword)
            {
                new form2().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Oops! your username or your password is incorrect.", "incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.ResetText();
                password.ResetText();
                username.Focus();

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void forgorPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            storedPassword = form3.NewPassword; // Gunakan password baru untuk login ulang

        }
    }
}

