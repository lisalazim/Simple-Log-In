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

    public partial class Form3 : Form
    {
        public string NewPassword { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = password2.Text;
            string confirm = confirmPassword.Text;

            if (newPassword.Equals(confirm))
            {
                // Simpan password baru ke properti NewPassword
                NewPassword = newPassword;

                // Lakukan tindakan perubahan password di sini
                MessageBox.Show("Password has been changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Tutup Form3 setelah mengganti password

            }
            else
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
