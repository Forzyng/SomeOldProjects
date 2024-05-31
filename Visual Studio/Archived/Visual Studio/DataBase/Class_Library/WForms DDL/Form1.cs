using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Library;

namespace WForms_DDL
{
    public partial class Form1 : Form
    {
        private List<User> users;
        public Form1()
        {
            InitializeComponent();
            users = new List<User>();
            users.Add(new User { Id = Guid.NewGuid(), Name = "User 1", Login = "Login 1", Password = "123456789" });
            users.Add(new User { Id = Guid.NewGuid(), Name = "User 2", Login = "Login 2", Password = "987654321" });
            users.Add(new User { Id = Guid.NewGuid(), Name = "User 3", Login = "Login 3", Password = "1209348756" });
            dgv_User.DataSource = users;

            foreach(var item in users)
            {
                lb_ToString.Items.Add(item);
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
