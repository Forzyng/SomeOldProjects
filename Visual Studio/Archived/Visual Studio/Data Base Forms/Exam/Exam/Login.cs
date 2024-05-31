using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Login : Form
    {
        public string UserLogin;
        public string UserPassword;
        public bool Success;

        public string GetUserLogin
        {
            get { return UserLogin; }
        }

        public bool ShowSuccess
        {
            get { return Success; }
        }

        public string GetUserPassword
        {
            get { return UserPassword; }
        }


       

        public Login()
        {
            InitializeComponent();
            Success = false;
            UserLogin = string.Empty;
            UserPassword = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Login.Text) || string.IsNullOrEmpty(txb_Password.Text))
            {
                return;
            }

            UserLogin = txb_Login.Text;
            UserPassword = txb_Password.Text;
            Success = true;

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txb_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
