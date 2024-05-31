using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBasicsSecond
{
    public partial class Labirint : Form
    {
        Bitmap puc;
        Color WallColor;
        int FirxtX = 0;
        int FirstY = 0;

        int msc = 0;

        int Horizontal, Vertical;
        public Labirint()
        {
            InitializeComponent();
            puc = new Bitmap("fon2.bmp");
            // WallColor = Color.FromArgb(255, 0, 0, 0);
            WallColor = puc.GetPixel(3, 3); // Цвет стены - пиксель (3, 3)
        }

        // Эксперементы... По щелчку мыши
        private void Labirint_Load(object sender, EventArgs e)
        {
            Horizontal = Vertical = 0;
            FirxtX = SMILE.Left;
            FirstY = SMILE.Top;
            timer1.Start();
        }

        private void Labirint_MouseDown(object sender, MouseEventArgs e)
        {
            Text = puc.GetPixel(e.X, e.Y).ToString() + " " 
                + (puc.GetPixel(e.X, e.Y) == WallColor);              // Color.FromArgb(255,0,0,0)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            msc++;
            if(Horizontal < 0)
            {
                if(!IsWallLeft(2))
                {
                    SMILE.Left += 2 * Horizontal;
                }
            }
            if (Horizontal > 0)
            {
                if (SMILE.Right >= puc.Width - 10)
                {

                }
                else
                {
                    if (!IsWallRight(2))
                    {
                        SMILE.Left += 2 * Horizontal;
                    }
                }
               

            }
            if (Vertical < 0)
            {
                if (SMILE.Top <=  2)
                {
                    timer1.Stop();
                    DialogResult dialogResult = MessageBox.Show($"U win!!! - {msc / 60} sec", "Try again?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        timer1.Start();
                        SMILE.Left = FirxtX;
                        SMILE.Top = FirstY;
                        Horizontal = Vertical = 0;
                        msc = 0;
                    }
                    else
                    {
                        if (dialogResult == DialogResult.No)
                        {
                            this.Close();
                            return;
                        }
                    }
                }
                else
                {
                    if (!IsWallUp(2))
                    {
                        SMILE.Top += 2 * Vertical;
                    }
                }
                
            }

            if (Vertical > 0)
            {
                if (!IsWallDown(2))
                {
                    SMILE.Top += 2 * Vertical;
                }
            }
            

           // SMILE.Top += 2 * Vertical;
        }

        private void Labirint_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Horizontal = -1;
                    break;
                case Keys.Right:
                        Horizontal = 1;
                    break;
                case Keys.Up:
                    Vertical = -1;
                    break;
                case Keys.Down:
                    Vertical = 1;
                    break;
            }
        }

        private void Labirint_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if(Horizontal == -1)
                    {
                        Horizontal = 0;
                    }
                    break;
                case Keys.Right:
                    if(Horizontal == 1)
                    {
                        Horizontal = 0;
                    }
                    break;
                case Keys.Up:
                    if (Vertical == -1)
                    {
                        Vertical = 0;
                    }
                    break;
                case Keys.Down:
                    if (Vertical == 1)
                    {
                        Vertical = 0;
                    }
                    break;
            }
        }

        private bool IsWallLeft(int step)
        {
            int x = SMILE.Left;
            int y = SMILE.Top;
            for(int i = 0; i < SMILE.Height; i++)
            {
                if (puc.GetPixel(x - step, y + i) == WallColor)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsWallRight(int step)
        {
            int x = SMILE.Right;
            int y = SMILE.Top;
            for (int i = 0; i < SMILE.Height; i++)
            {
                if (puc.GetPixel(x + step, y + i) == WallColor)
                {
                    return true;
                }
                 
            }
            return false;
        }
        private bool IsWallUp(int step)
        {
            int x = SMILE.Left;
            int y = SMILE.Top;
            for (int i = 0; i < SMILE.Width; i++)
            {
                if (puc.GetPixel(x + i, y - step) == WallColor)
                {
                    return true;
                }

            }
            return false;
        }

        private void SMILE_Click(object sender, EventArgs e)
        {

        }

        private bool IsWallDown(int step)
        {
            int x = SMILE.Left;
            int y = SMILE.Top + SMILE.Height;
            for (int i = 0; i < SMILE.Width; i++)
            {
                if (puc.GetPixel(x + i, y + step) == WallColor)
                {
                    return true;
                }

            }
            return false;
        }
    }
}

/*
 * 
 * Об изображениях 
 * формы не является непосредственным ресурсом -
 * нет возможности обратится к пикселю. узнать его цвет
 * Для нашей задачи мы открываем фоновое изображение отдельно
 * Координаты (позиции) берем из формы, а пиксели (цвет) - из файла
 * 
 * 
 * Об Управлении
 * (Движение персонажа при помощи клавиатуры)
 * Вариант 1.Поставить движение на событие клавиатуры
 * нехорошо: Событие срабатывает один раз и, чаще всего, с паузой посылает очередь
 *           посыл очереди настраивается системой
 * Вариант 2: "Игровой таймер" - постоянно посылают хроно-события, в которых
 *             проверяется факт нажатия кнопок (Чаще всего флаги - булевые переменные)
 * 
 * 
 */
