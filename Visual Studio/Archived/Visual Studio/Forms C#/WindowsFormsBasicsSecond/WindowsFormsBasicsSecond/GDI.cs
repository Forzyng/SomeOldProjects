using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBasicsSecond
{
    public partial class GDI : Form
    {
        bool CtrlHold;
        int ColorPenSize;
        Pen pen, RedPen, ColorPen;
        Graphics gdi;
        Brush ColorBrush, Eraser;
        int NOWX;
        int NOWY;
        int PrevX;
        int PrevY;
        bool LeftHold;
        bool RightHold;
        Bitmap screenshot;
        Graphics screenshotGDI;
        public GDI()
        {
            InitializeComponent();
            this.MouseWheel += GDI_MouseWheel;
            ColorPenSize = 1;
        }

        private void GDI_Load(object sender, EventArgs e)
        {
            LeftHold = false;

            colorDialog1.Color = panel1.BackColor = Color.Aqua;
            ColorPen = new Pen(panel1.BackColor, ColorPenSize);

            pen = new Pen(Color.Black, ColorPenSize);
            RedPen = new Pen(Color.Red, ColorPenSize);

            ColorBrush = new SolidBrush(panel1.BackColor);

            Eraser = new SolidBrush(this.BackColor);

            // Создаем рисунок с размерами как у формы, данные о цвете из Graphics
            screenshot = new Bitmap(this.Width, this.Height, this.CreateGraphics());
            // GDI рисунка - интерфейс для рисования
            screenshotGDI = Graphics.FromImage(screenshot);
        }
        private void GDI_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    LeftHold = true;
                    break;
                case MouseButtons.Right:
                    RightHold = true;
                    break;
            }

            PrevX = e.X; // Инициализация первой точки
            PrevY = e.Y; // Для линии
            gdi = this.CreateGraphics(); // Получаем GDI - объект, содержащий функции графики
        }

        private void GDI_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left: LeftHold = false; break;
                case MouseButtons.Right: RightHold = false; break;
            }

        }

        private void GDI_MouseMove(object sender, MouseEventArgs e)
        {
            NOWX = e.X;
            NOWY = e.Y;
            if (CtrlHold)
            {
                if (LeftHold)
                {
                    // Eraser - круг цвета фона
                    int s = ColorPenSize * 5;
                    gdi.FillEllipse(Eraser, PrevX - s / 2, PrevY - s / 2, s, s);
                    screenshotGDI.FillEllipse(Eraser, PrevX - s / 2, PrevY - s / 2, s, s);

                }

            }
            else
            {


                if (LeftHold && RightHold)
                {
                    gdi.DrawLine(RedPen, PrevX, PrevY, e.X, e.Y);
                    screenshotGDI.DrawLine(RedPen, PrevX, PrevY, e.X, e.Y);

                }
                else
                {
                    if (LeftHold)
                    {
                        // gdi.DrawLine(GreenPen, 0, 0, e.X, e.Y);
                        // gdi.DrawEllipse(GreenPen, e.X, e.Y, 3, 3);
                        gdi.DrawLine(pen, PrevX, PrevY, e.X, e.Y);
                        screenshotGDI.DrawLine(pen, PrevX, PrevY, e.X, e.Y);

                    }
                    else
                    {
                        if (RightHold)
                        {
                            gdi.DrawLine(ColorPen, PrevX, PrevY, e.X, e.Y);
                            screenshotGDI.DrawLine(ColorPen, PrevX, PrevY, e.X, e.Y);

                        }
                    }
                }
            }
            PrevX = e.X;
            PrevY = e.Y;
        }

        private void ButtonBlack_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, ColorPenSize);
        }

        private void ButtonGreen_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Green, ColorPenSize);
        }

        private void ButtonGreen_KeyUp(object sender, KeyEventArgs e)
        {
           


        }

        private void ButtonGreen_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorPen.Color = panel1.BackColor = colorDialog1.Color;
                ColorBrush.Dispose();
                ColorBrush = new SolidBrush(colorDialog1.Color);
                Graphics g = panel2.CreateGraphics();
                g.Clear(panel2.BackColor);
                g.FillEllipse(ColorBrush, 0, 0, ColorPenSize, ColorPenSize);
            }
        }

        private void GDI_KeyDown(object sender, KeyEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, 200, 200);
            if (gdi == null)
            {
                gdi = CreateGraphics();
            }
            switch (e.KeyCode)
            {
                case Keys.S:
                    if(CtrlHold)
                    {
                        screenshot.Save("screenshot.bmp");
                    }
                    else
                    {
                        gdi.FillRectangle(ColorBrush, PrevX - 25, PrevY - 25, 50, 50);
                        screenshotGDI.FillRectangle(ColorBrush, PrevX - 25, PrevY - 25, 50, 50);
                    }
                    
                    break;
                case Keys.P:


                    gdi.FillPie(ColorBrush, new Rectangle(0, 0, NOWX , NOWY + 200), 0, 3);
                    screenshotGDI.FillPie(ColorBrush, new Rectangle(0, 0, NOWX , NOWY + 200), 0, 3);
                    break;
                case Keys.ControlKey:
                    CtrlHold = true;
                    break;

            }
        }

        private void GDI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void GDI_Paint(object sender, PaintEventArgs e)
        {
            // Событие перерисовки - возникает когда нужно отрисовать или востановить
            // Окно / Часть окна
            if(gdi == null) // Первое событие - отрисовка формы
            {
                gdi = CreateGraphics();
            }
            else
            {
                gdi.DrawImage(screenshot, 0, 0); // Перерисовка - восстанавливаем рисунок (с точки 0,0)
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GDI_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.ControlKey:
                    CtrlHold = false;
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void GDI_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                if(ColorPenSize < 10)
                {
                    ColorPenSize++;
                    ColorPen.Width = ColorPenSize;
                    Graphics g = panel2.CreateGraphics();
                    g.Clear(panel2.BackColor);
                    g.FillEllipse(ColorBrush, 0, 0, ColorPenSize, ColorPenSize);
                }
            }
            else
            {
                if(ColorPenSize > 1)
                {
                    ColorPenSize--;
                    ColorPen.Width = ColorPenSize;
                    Graphics g = panel2.CreateGraphics();
                    g.Clear(panel2.BackColor);
                    g.FillEllipse(ColorBrush, 0, 0, ColorPenSize, ColorPenSize);
                }
            }
        }
    }
}

/*
 * 
 * GDI - Graphic Device Interface / графический интерфейс устройства
 * Идея - набор универсальных команд, позволяющих "рисовать" на
 * различных устройствах
 * 
 */