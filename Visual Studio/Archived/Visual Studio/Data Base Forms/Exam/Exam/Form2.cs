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
    public partial class Form2 : Form
    {
        Login login;
        RegistrationForm regform;

        public string UserName;
        public string UserSurname;
        public string UserLogin;
        public string UserPassword;
        public bool Success;
        public bool SuccessReg;


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

        /// <summary>
        /// ////////////////////////////////////////////////
        /// </summary>

        public string GetUserLoginReg
        {
            get { return UserLogin; }
        }

        public string GetUserNameReg
        {
            get { return UserName; }
        }

        public string GetUserSurnameReg
        {
            get { return UserSurname; }
        }

        public bool ShowSuccessReg
        {
            get { return SuccessReg; }
        }

        public string GetUserPasswordReg
        {
            get { return UserPassword; }
        }




        public Form2()
        {
            InitializeComponent();

            login = new Login();

            regform = new RegistrationForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            login.ShowDialog();
            if(login.ShowSuccess == true)
            {
                UserLogin = login.GetUserLogin;
                UserPassword = login.GetUserPassword;
                Success = login.ShowSuccess;
                this.Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            regform.ShowDialog();
            if(regform.ShowSuccess == true)
            {
                UserName = regform.GetUserName;
                UserSurname = regform.GetUserSurname;
                UserLogin = regform.GetUserLogin;
                UserPassword = regform.GetUserPassword;
                SuccessReg = regform.ShowSuccess;
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
