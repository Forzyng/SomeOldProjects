using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBasicsSecond
{
    public partial class Events2 : Form
    {
        Point StartPoint;
        bool LeftHold;
        bool CtrlHold;
        bool ShiftHold;
        private uint ButtonCounter;
        public Events2()
        {
            InitializeComponent();
            StartPoint = new Point();
        }

        private void Events2_Load(object sender, EventArgs e)
        {
            LeftHold = false;
            CtrlHold = false;
            ButtonCounter = 0;
            this.MouseWheel += Events2_MouseWheel;
        }

        #region
        //private void Form_MouseDown(object sender, MouseEventArgs e)
        //{
        //    switch(e.Button)
        //    {
        //        case MouseButtons.Left:
        //            Text = "Begin"; 
        //            StartPoint.X = e.X;
        //            StartPoint.Y = e.Y;
        //            LeftHold = true;
        //            break;
        //    }
        //}

        //private void Form_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if(LeftHold)
        //    {
        //        Text = String.Format("{0} x {1}", e.X - StartPoint.X, e.Y - StartPoint.Y);
        //    }

        //}

        //private void Form_MouseUp(object sender, MouseEventArgs e)
        //{
        //    switch(e.Button)
        //    {
        //        case MouseButtons.Left:
        //            Text = "End";
        //            LeftHold = false;
        //            break;
        //    }
        //}
        #endregion
        private void Events2_MouseWheel(object sender, MouseEventArgs e)
        {
            Text = e.Delta.ToString();
        }

        private void Button_MouseWheel(object sender, MouseEventArgs e)
        {
            Button butter = sender as Button;
            int delta = e.Delta / 60;
            if (CtrlHold)
            {
                if(butter.Width + delta < 300 && butter.Width + delta > 10 && butter.Height + delta < 300 && butter.Height + delta > 10)
                {
                    butter.Width += delta;
                    butter.Height += delta;
                }   
                

                if (butter.Width > 300 || butter.Width < 10 || butter.Height < 10 || butter.Height > 300)
                {
                    System.Media.SystemSounds.Exclamation.Play();
                }
                else
                {
                    butter.Width += delta;
                    butter.Height += delta;
                }
            }


            if (ShiftHold)
            {
                butter.Font = new Font(butter.Font.FontFamily, Button.DefaultFont.Size + e.Delta / 30);
            }

        }

        private void Events2_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Text = "Begin";
                    StartPoint.X = e.X;
                    StartPoint.Y = e.Y;
                    LeftHold = true;
                    break;
              
            }
        }


        private void Events2_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Text = "End";
                    LeftHold = false;
                    ButtonCounter += 1;
                    int w = Math.Abs(e.X - StartPoint.X);
                    int h = Math.Abs(e.Y - StartPoint.Y);
                    if (w > 300 || w < 10 || h < 10 || h > 300)
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                    }
                    else
                    {
                        var butter = new Button
                        {
                            Text = ButtonCounter.ToString(),
                            Location = new Point
                        (
                            e.X < StartPoint.X ? e.X : StartPoint.X,
                            e.Y < StartPoint.X ? e.Y : StartPoint.Y
                        ),
                            Size = new Size(w, h),
                            Visible = true,
                            Enabled = true
                        };
                        butter.MouseWheel += Button_MouseWheel;
                        butter.Click += Events2_ButtonClick;
                        this.Controls.Add(butter);
                        butter.BringToFront();
                    }


                    break;
            }
        }

        private void Events2_MouseMove(object sender, MouseEventArgs e)
        {
            if (LeftHold)
            {
                Text = String.Format("{0} x {1}", e.X - StartPoint.X, e.Y - StartPoint.Y);
            }
        }

        private void Events2_KeyDown(object sender, KeyEventArgs e)
        {
            Text = e.KeyCode + " | " + e.KeyValue;
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode == Keys.ControlKey)
            {
                CtrlHold = true;
            }
            if (e.KeyCode == Keys.ShiftKey)
            {
                ShiftHold = true;
            }

        }

        private void Events2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                CtrlHold = false;
            }

            if (e.KeyCode == Keys.ShiftKey)
            {
                ShiftHold = false;
            }
        }

        private void Events2_ButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            MessageBox.Show(button.Text);
            // Text = button.Text;
        }

    }
}

/*
 * 
 * ТЗ:
 * Приложение должно создавать кнопки:
 * зажимая ЛКМ (рисуем) прямоугольник, в котором после отпускания ЛКМ
 * появляется кнопка заданных размеров
 * На кнопке - текст - номер кнопки
 * При действии Ctrl - колесо кнопка меняет размер (min - 10x10; max 300x300)
 * При действии Shift - колесо кнопка меняет размер шрифта на кнопке
 * Нажмите на кнопку - сообщение с номером кнопки
 * 
 */