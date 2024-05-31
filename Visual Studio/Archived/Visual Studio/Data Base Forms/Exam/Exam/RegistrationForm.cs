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
    public partial class RegistrationForm : Form
    {
        public string UserName;
        public string UserSurname;
        public string UserLogin;
        public string UserPassword;
        public bool Success;

        public string GetUserLogin
        {
            get { return UserLogin; }
        }

        public string GetUserName
        {
            get { return UserName; }
        }

        public string GetUserSurname
        {
            get { return UserSurname; }
        }

        public bool ShowSuccess
        {
            get { return Success; }
        }

        public string GetUserPassword
        {
            get { return UserPassword; }
        }

        public RegistrationForm()
        {
            InitializeComponent();
            Success = false;
            UserName = string.Empty;
            UserSurname = string.Empty;
            UserLogin = string.Empty;
            UserPassword = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txb_Name.Text) || string.IsNullOrWhiteSpace(txb_Surname.Text) || string.IsNullOrWhiteSpace(txb_Login.Text) || string.IsNullOrWhiteSpace(txb_Password.Text))
            {
                return;
            }
            if(txb_Name.Text.Length < 3 || txb_Surname.Text.Length < 3 || txb_Login.Text.Length < 3 || txb_Password.Text.Length < 6)
            {
                return;
            }

            Success = true;
            UserName = txb_Name.Text;
            UserSurname = txb_Surname.Text;
            UserLogin = txb_Login.Text;
            UserPassword = txb_Password.Text;

            this.Hide();

        }
    }
}
