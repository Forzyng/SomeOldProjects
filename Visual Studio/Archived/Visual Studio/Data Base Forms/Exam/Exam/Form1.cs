using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exam
{
    public partial class Form1 : Form
    {
        User user;
        Music_MagazineEntities musicDB;
        bool check;


        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;

        public Form1()
        {
            InitializeComponent();
            musicDB = new Music_MagazineEntities();
            //user = new User();
            check = true;
            Form2 form2 = new Form2();

            while (check)
            {
                form2.ShowDialog();

                if (form2.ShowSuccess == true)
                {
                    var user_find = musicDB.Users.Where(t => t.Name.Contains(form2.GetUserLogin) && t.Password.Contains(form2.GetUserPassword));      
                    if(user_find != null)
                    {
                        //user = new User();
                        //user = (User)user_find;
                        check = false;
                        return;      
                    }
                   
                }
                else
                {
                    if (form2.ShowSuccessReg == true)
                    {


                        var user_find = musicDB.Users.Where(t => t.Name.Contains(form2.GetUserLoginReg));
                        if (user_find != null)
                        {
                            MessageBox.Show("Already exist with this Login");

                        }
                        else
                        {
                            user = new User()
                            {
                                Id = Guid.NewGuid(),
                                Name = form2.GetUserNameReg,
                                Surname = form2.GetUserSurnameReg,
                                Login = form2.GetUserLoginReg,
                                Password = form2.GetUserPasswordReg,
                                Discount = 5
                            };
                            musicDB.Users.Add(user);

                            musicDB.SaveChanges();
                            check = false;
                            return;
                        }

                        
                    }


                }
            }










        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
