using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBasicsSecond
{
    public partial class EventsDnD : Form
    {
        private bool mouseHold;
        private int touchX, touchY;
        private int saveX, saveY;
        public EventsDnD()
        {
            InitializeComponent();
            mouseHold = false;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Controls.Add(pictureBox2);
            //pictureBox3.Location = new Point(200, 200);
            pictureBox2.Location = new Point(280, 280);
        }

        private void EventsDnD_Load(object sender, EventArgs e)
        {

        }

        private void EventsDnD_MouseDown(object sender, MouseEventArgs e)
        {
            Text = "Mouse down @ " + e.X + " ; " + e.Y + " - " + e.Button;
        }

        private void EventsDnD_MouseUp(object sender, MouseEventArgs e)
        {
            Text = "Mouse up @ " + e.X + " ; " + e.Y + " - " + e.Button;
        }

        private void EventsDnD_MouseMove(object sender, MouseEventArgs e)
        {
            Text = "Mouse move @ " + e.X + " ; " + e.Y;
            if (mouseHold)
            {
                MoveRhomb(e.X, e.Y);
                MoveRhomb2(e.X, e.Y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //===========================================
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseHold)
            {
                MoveRhomb(e.X + pictureBox1.Left, e.Y + pictureBox1.Top);
            }
            
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHold)
            {
                MoveRhomb2(e.X + pictureBox2.Left, e.Y + pictureBox2.Top);
            }
        }
        //===========================================
        private void MoveRhomb(int x, int y)
        {
            pictureBox1.Left = x - touchX;
            pictureBox1.Top = y - touchY;
        }

        private void MoveRhomb2(int x, int y)
        {
            pictureBox2.Left = x - touchX;
            pictureBox2.Top = y - touchY;
        }
        //===========================================
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseHold = true;
            touchX = e.X;
            touchY = e.Y;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseHold = true;
            touchX = e.X;
            touchY = e.Y;
            saveX = pictureBox2.Left;
            saveY = pictureBox2.Top;
        }
        //===========================================
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
            int dx = Math.Abs(pictureBox2.Location.X - pictureBox3.Location.X);
            int dy = Math.Abs(pictureBox2.Location.Y - pictureBox3.Location.Y);
            if (dx < 20 && dy < 20)
            {
                MessageBox.Show("يضرب");
            }
            else
            {
                MessageBox.Show($"How close to the center: X - {dx} | Y - {dy}");
                pictureBox2.Left = saveX;
                pictureBox2.Top = saveY;
            }
        }
    }
}

/*
 * 
 * Событие (Events)
 * CPU - Процессор
 * Переферийное устройство (КВ - Keyboard) <<Press A key>>
 * -> Прерывание - остановка работы процессора и переключение его на обработку прерывания
 * Результатом обработки является <<Структура>>, адрес которой возвращает обработчик
 * -> Работа процессора восстанавливается, полученная структура передается
 * операционной системе как Сообщение (Message)
 * -> Сообщение получает прикладная программа (приложение) и формирует из него
 * Событие (Event). <<Структура>> обычно переводится в объект - аргументы события
 * 
 */

/*
 * 
 * Событийно-ориентированое программирование 
 * заключается в создании обработчиков событий, 
 * многда - создании доп. событий
 * совокуаность которых реализует поведение программы
 * в различных условиях
 * 
 */
