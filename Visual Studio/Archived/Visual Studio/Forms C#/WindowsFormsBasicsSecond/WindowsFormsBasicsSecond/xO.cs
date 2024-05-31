using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBasicsSecond
{
    public partial class xO : Form
    {
        int turn = 0;
        Button[] buttons;
        public xO()
        {
            InitializeComponent();
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        foreach(var b in buttons)
            {
                b.TabStop = false;
            }
        }

        private void xO_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            var button = sender as Button;
            if(button == null)
            {
                return;
            }
            
            if(turn % 2 == 0)
            {
                button.Text = "X";
                turn++;
                LabelToChange.Text = "O";
            }
            else
            {
                button.Text = "0";
                turn++;
                LabelToChange.Text = "X";
            }
            
            button.Enabled = false;
        }

        private void LabelToChange_Click(object sender, EventArgs e)
        {

        }
    }
}
