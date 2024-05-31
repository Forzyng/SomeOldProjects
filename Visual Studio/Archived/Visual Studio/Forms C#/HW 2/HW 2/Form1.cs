using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X > ButtonStatic.Location.X - 20 && e.X < ButtonStatic.Location.X + ButtonStatic.Width + 20) && (e.Y > ButtonStatic.Location.Y - 20 && e.Y < ButtonStatic.Location.Y + ButtonStatic.Height + 20))
            {


                if (e.X > ButtonStatic.Location.X - 20 && e.X < ButtonStatic.Location.X && e.Y > ButtonStatic.Location.Y - 20 && e.Y < ButtonStatic.Location.Y)
                {
                    ButtonStatic.Left += 10;
                    ButtonStatic.Top += 10;
                }
                else
                {
                    if (e.X > ButtonStatic.Location.X - 20 && e.X < ButtonStatic.Location.X && e.Y < ButtonStatic.Location.Y + ButtonStatic.Height + 20 && e.Y > ButtonStatic.Location.Y + ButtonStatic.Height)
                    {
                        ButtonStatic.Left += 10;
                        ButtonStatic.Top -= 10;
                    }
                    else
                    {
                        if (e.X < ButtonStatic.Location.X + ButtonStatic.Width + 20 && e.X > ButtonStatic.Location.X + ButtonStatic.Width && e.Y < ButtonStatic.Location.Y + ButtonStatic.Height + 20 && e.Y > ButtonStatic.Location.Y + ButtonStatic.Height)
                        {
                            ButtonStatic.Left -= 10;
                            ButtonStatic.Top -= 10;
                        }
                        else
                        {
                            if (e.X < ButtonStatic.Location.X + ButtonStatic.Width + 20 && e.X > ButtonStatic.Location.X + ButtonStatic.Width && e.Y > ButtonStatic.Location.Y - 20 && e.Y < ButtonStatic.Location.Y)
                            {
                                ButtonStatic.Left -= 10;
                                ButtonStatic.Top += 10;
                            }
                        }
                    }
                }


                if (e.X > ButtonStatic.Location.X - 20 && e.X < ButtonStatic.Location.X)
                {
                    ButtonStatic.Left += 10;
                }
                else
                {
                    if (e.X < ButtonStatic.Location.X + ButtonStatic.Width + 20 && e.X > ButtonStatic.Location.X + ButtonStatic.Width)
                    {
                        ButtonStatic.Left -= 10;
                    }
                    else
                    {
                        if (e.Y > ButtonStatic.Location.Y - 20 && e.Y < ButtonStatic.Location.Y)
                        {
                            ButtonStatic.Top += 10;
                        }

                        else
                        {
                            if (e.Y < ButtonStatic.Location.Y + ButtonStatic.Height + 20 && e.Y > ButtonStatic.Location.Y + ButtonStatic.Height)
                            {
                                ButtonStatic.Top -= 10;
                            }
                        }
                    }
                }

                if ((ButtonStatic.Location.X < 0 || ButtonStatic.Location.X > ClientSize.Width - ButtonStatic.Width) || (ButtonStatic.Location.Y < 0 || ButtonStatic.Location.Y > ClientSize.Height - ButtonStatic.Height))
                {
                    ButtonStatic.Left = (ClientSize.Width - ButtonStatic.Size.Width) / 2;
                    ButtonStatic.Top = (ClientSize.Height - ButtonStatic.Size.Height) / 2;
                }
            }
        }
    }
}
