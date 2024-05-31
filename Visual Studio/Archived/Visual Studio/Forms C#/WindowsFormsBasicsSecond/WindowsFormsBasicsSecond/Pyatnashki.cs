using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBasicsSecond
{
    public partial class Pyatnashki : Form
    {
        Button[] buttons;
        Random rnd;
        public Pyatnashki()
        {
            InitializeComponent();
            buttons = new Button[16];
            rnd = new Random();
        }

        private void Pyatnashki_Load(object sender, EventArgs e)
        {
            Font buttonFont = new Font("Showcard Gothic", 30);
            // Программные методы добавления элементов управления 
            for (int i = 0; i < 16; i++)
            {
                Button button = new Button
                {
                    BackColor = Color.FromArgb(100, 100, 100, 100),
                    Font = buttonFont,
                    Location = new Point((i % 4) * 105 + 5, (i / 4) * 105 + 5),
                    Size = new Size(100, 100),
                    TabStop = false,
                    Tag = i, // Специальное поле для добавления данных
                    Text = ((i + 1) % 16).ToString(),
                    Visible = i != 15
                };
                button.Click += Button_Click; // Устанавливаем обработчик событий
                buttons[i] = button; // Добавляем кнопку в массив
                PanelField.Controls.Add(button); // Добавляем кнопку на поле
            }
            Shuffle();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Узнаем, какая кнопка нажата
            Button button = sender as Button;
            if(button == null)
            {
                return;
            }


            if (MakeMove(button))
            {
                if(IsVictory())
                {
                    DialogResult dialogResult = MessageBox.Show("U win!!!", "Try again?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Shuffle();
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
            }
            else
            {
                SystemSounds.Beep.Play();
            }
            
            //MessageBox.Show(button.Text);
        }


        private bool MakeMove(Button ClickedButton)
        {
            // Узнаем номер (позицию) кнопки
            int pos = Convert.ToInt32(ClickedButton.Tag);

            // Ссылка на кнопку с которой будет обмен (ход) - на пустую кнопку
            Button ChangeButton = null;
            // Возможность хода влево
            // (pos % 4) == 0 - значит кнопка слева и ход невозможен
            if ((pos % 4) != 0)
            {
                // если кнопка слева невидима, значит ход возможен
                if (buttons[pos - 1].Visible == false)
                {
                    ChangeButton = buttons[pos - 1];
                    // меняем НЕ кнопки, а текст и видимость

                }

            }

            if ((pos % 4) != 3)
            {
                if (buttons[pos + 1].Visible == false)
                {
                    ChangeButton = buttons[pos + 1];
                }
            }


            // Возможность хода вверх

            if (pos < 12)
            {
                if (buttons[pos + 4].Visible == false)
                {
                    ChangeButton = buttons[pos + 4];
                }
            }
            if (pos > 3)
            {
                if (buttons[pos - 4].Visible == false)
                {
                    ChangeButton = buttons[pos - 4];
                }
            }
            if (ChangeButton != null)
            {
                ChangeButton.Text = ClickedButton.Text;
                ChangeButton.Visible = true;
                ClickedButton.Text = "0";
                ClickedButton.Visible = false;
                return true;
            }
            return false;
        }

        private void Shuffle()
        {
            // Перемешиивание поля
            int MoveCount = 0;
            do
            {
                if (MakeMove(buttons[rnd.Next(16)]))
                {
                    MoveCount += 1;
                }
            } while (MoveCount < 3);



        }

        private bool IsVictory()
        {
            for(int i = 0; i < 15; i++)
            {
                if(!buttons[i].Text.Equals((i + 1).ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private void PanelField_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
