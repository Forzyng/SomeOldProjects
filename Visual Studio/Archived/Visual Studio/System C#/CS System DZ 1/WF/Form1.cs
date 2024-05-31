using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WF
{
    public partial class Form1 : Form
    {
        Form2 form2;
        bool check;
        Button[] buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[] { button1, button2, button3, button4, button5 };
            form2 = new Form2();
            check = true;
            form2.ShowDialog();
            form2.Hide();
            //this.ShowDialog();
            do
            {

                if (form2.Text == "1")
                {
                    foreach (var item in buttons)
                    {
                        item.Text = "1";
                        item.BackColor = Color.Red;
                    }
                    check = false;
                }

            } while (check);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
