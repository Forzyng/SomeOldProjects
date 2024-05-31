using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFproject2
{
    /// <summary>
    /// Логика взаимодействия для Words.xaml
    /// </summary>
    public partial class Words : Window
    {
        int WMoney = 0;
        int Tries = 4;
        User user;
        System.Xml.Serialization.XmlSerializer SerializerOfUser;
        System.Windows.Threading.DispatcherTimer Timer;
        int count = 0;
        int time = 0;
        //bool MouseHold;
        double DragOffSetX, DragOffSetY;
        double SaveX, SaveY;
        bool first;
        TextBlock Dragged;
        List<TextBlock> Letters;

        SolidColorBrush ColorRect;
        public Words()
        {
            InitializeComponent();
            // MouseHold = false;
            Dragged = null;
            first = false;
            SaveX = SaveY = 0;
            Timer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = new TimeSpan(10000)
            };
            Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time++;
        }


            private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MouseHold = true;
            Dragged = sender as TextBlock;
            if (first == false)
            {
                SaveX = Canvas.GetLeft(Dragged);
                SaveY = Canvas.GetTop(Dragged);
            }
            if (Dragged != null)
            {
                DragOffSetX = e.GetPosition(Field).X // Координата курсора мыши, относительно Field (Canvas)
                - Canvas.GetLeft(Dragged); // Координата самой буквы (лево-верх)
                DragOffSetY = e.GetPosition(Field).Y - Canvas.GetTop(Dragged);
            }

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SerializerOfUser = new System.Xml.Serialization.XmlSerializer(typeof(User));
            ColorRect = Brushes.Black;


            using (var source = new System.IO.StreamReader("SavedUser.xml"))
            {
                user = (User)SerializerOfUser.Deserialize(source);
            }

            LetterC.Tag = new WordsData
            {
                CheckedWords = false,
                RECTANGLE = LetterCPosition
            };
            LetterO.Tag = new WordsData
            {
                CheckedWords = false,
                RECTANGLE = LetterOPosition
            };
            LetterR.Tag = new WordsData
            {
                CheckedWords = false,
                RECTANGLE = LetterRPosition
            };
            LetterS.Tag = new WordsData
            {
                CheckedWords = false,
                RECTANGLE = LetterSPosition
            };
            LetterI.Tag = new WordsData
            {
                CheckedWords = false,
                RECTANGLE = LetterIPosition
            };
            LetterC2.Tag = new WordsData
            {
                CheckedWords = false,
                RECTANGLE = LetterC2Position
            };
            LetterA.Tag = new WordsData
            {
                CheckedWords = false,
                RECTANGLE = LetterAPosition
            };
            Letters = new List<TextBlock>();
            Letters.Add(LetterC);
            Letters.Add(LetterO);
            Letters.Add(LetterR);
            Letters.Add(LetterS);
            Letters.Add(LetterI);
            Letters.Add(LetterC2);
            Letters.Add(LetterA);
            foreach (var d in Letters)
            {
                count++;
                WMoney += 20;
            }
            Timer.Start();
        }
        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //if (MouseHold)
            //{
            if (Dragged != null)
            {

                var Data = Dragged.Tag as WordsData;

                double x = e.GetPosition(Field).X;
                double y = e.GetPosition(Field).Y;


                // Извлекаем данные о прямоугольнике назначения из тэга перемещаемой буквы

                Rectangle RectAngle = Data.RECTANGLE;
                double px = Canvas.GetLeft(RectAngle);
                double py = Canvas.GetTop(RectAngle);
               
                    foreach (var check in Letters)
                {
                    if (Dragged.Text == check.Text)
                    {
                        var a = check.Tag as WordsData;
                        if (px <= x && x <= px + RectAngle.Width
                                            && py <= y && y <= py + RectAngle.Height)
                        {
                            Canvas.SetLeft(Dragged, px);
                            Canvas.SetTop(Dragged, py);
                            
                            Dragged.Tag = new WordsData
                            {
                                CheckedWords = true,
                                RECTANGLE = RectAngle
                            };
                            foreach (var d in Letters)
                            {
                                var c = d.Tag as WordsData;
                                if (c.CheckedWords != true)
                                {
                                    Dragged = null;
                                    first = false;
                                    return;
                                }
                            }
                            Timer.Stop();
                            if(time/30 < 15)
                            {
                                count += 200;
                            }
                            else
                            {
                                if (time / 30 > 15 && time / 30 < 30)
                                {
                                    count += 100;
                                }
                                else
                                {
                                    count += 50;
                                }
                            }

                            Timer.Stop();
                            WMoney += 100;
                            String Full = String.Empty;
                            Full += $"Ur Time: {time / 30} - sec\n";
                            Full += $"Ur Score: {count}\n";
                            Full += $"Highest Score: {user.HighScoreInWords}\n";
                            Full += $"+ {WMoney} coins";
                            
                            user.Money += WMoney;
                            if (count > user.HighScoreInWords)
                            {
                                user.HighScoreInWords = count;
                            }
                            
                            using (var source = new System.IO.StreamWriter("SavedUser.xml"))
                            {
                                SerializerOfUser.Serialize(source, user);
                            }
                           
                            MessageBox.Show($"{Full}", "U WINN!!!");
                            this.Close();
                        }
                        else
                        {
                            px = Canvas.GetLeft(a.RECTANGLE);
                            py = Canvas.GetTop(a.RECTANGLE);
                            if (px <= x && x <= px + a.RECTANGLE.Width
                                            && py <= y && y <= py + a.RECTANGLE.Height)
                            {
                                Dragged.Tag = new WordsData
                                {
                                    CheckedWords = false,
                                    RECTANGLE = a.RECTANGLE
                                };
                                check.Tag = new WordsData
                                {
                                    CheckedWords = true,
                                    RECTANGLE = RectAngle
                                };
                            }
                            else
                            {
                                
                               
                                    Tries--;
                                    TryesLeft.Content = Tries.ToString();
                                    switch (Tries)
                                    {
                                        case 0:

                                        Rectangle Leg1 = new Rectangle { Width = 10, Height = 45, Fill = ColorRect };
                                        Rectangle Leg2 = new Rectangle { Width = 10, Height = 45, Fill = ColorRect };

                                        Field.Children.Add(Leg1);
                                        Field.Children.Add(Leg2);

                                        Canvas.SetLeft(Leg1, 642);
                                        Canvas.SetTop(Leg1, 337);

                                        Canvas.SetLeft(Leg2, 658);
                                        Canvas.SetTop(Leg2, 337);








                                        count = 0;
                                        foreach (var d in Letters)
                                        {
                                            var c = d.Tag as WordsData;
                                            if (c.CheckedWords == true)
                                            {
                                                count += 20;
                                            }
                                        }
                                        WMoney = 0;
                                        WMoney = count / 10;
                                        WMoney += 20;
                                        Timer.Stop();
                                        String Full = String.Empty;
                                        Full += $"Ur Time: {time / 30} - sec\n";
                                        Full += $"Ur Score: {count}\n";
                                        Full += $"Highest Score: {user.HighScoreInWords}\n";
                                        Full += $"+ {WMoney} coins";

                                        user.Money += WMoney;
                                        if (count > user.HighScoreInWords)
                                        {
                                            user.HighScoreInWords = count;
                                        }

                                        using (var source = new System.IO.StreamWriter("SavedUser.xml"))
                                        {
                                            SerializerOfUser.Serialize(source, user);
                                        }

                                        MessageBox.Show($"{Full}", "GG");
                                        this.Close();
                                        break;

                                        case 1:
                                        Rectangle Arm1 = new Rectangle { Width = 45, Height = 10, Fill = ColorRect };
                                        Rectangle Arm2 = new Rectangle { Width = 45, Height = 10, Fill = ColorRect };

                                        Field.Children.Add(Arm1);
                                        Field.Children.Add(Arm2);

                                        Canvas.SetLeft(Arm1, 605);
                                        Canvas.SetTop(Arm1, 279);

                                        Canvas.SetLeft(Arm2, 660);
                                        Canvas.SetTop(Arm2, 279);

                                        break;
                                        case 2:
                                        Rectangle Tulowiche = new Rectangle { Width = 10, Height = 90, Fill = ColorRect };

                                        Field.Children.Add(Tulowiche);
                                        Canvas.SetLeft(Tulowiche, 650);
                                        Canvas.SetTop(Tulowiche, 249);

                                        break;
                                        case 3:
                                            Ellipse ellipse = new Ellipse { Width = 50, Height = 50, Fill = ColorRect };

                                        Ellipse eye1 = new Ellipse { Width = 5, Height = 5, Fill = Brushes.White };
                                        Ellipse eye2 = new Ellipse { Width = 5, Height = 5, Fill = Brushes.White };

                                        Field.Children.Add(ellipse);

                                        Field.Children.Add(eye1);
                                        Field.Children.Add(eye2);

                                        Canvas.SetLeft(ellipse, 630);
                                        Canvas.SetTop(ellipse, 209);




                                        Canvas.SetLeft(eye1, 664);
                                        Canvas.SetTop(eye1, 229);

                                        Canvas.SetLeft(eye2, 644);
                                        Canvas.SetTop(eye2, 229);
                                        break;


                                    }

                                    Canvas.SetLeft(Dragged, SaveX);
                                    Canvas.SetTop(Dragged, SaveY);


                                }

                        }
                    }
                }

                if (px <= x && x <= px + RectAngle.Width
                    && py <= y && y <= py + RectAngle.Height)
                {
                    //Canvas.SetLeft(Dragged, px);
                    //Canvas.SetTop(Dragged, py);
                    //Dragged.Tag = new WordsData
                    //{
                    //    CheckedWords = true,
                    //    RECTANGLE = RectAngle
                    //};
                    //foreach(var d in Letters)
                    //{
                    //    var a = d.Tag as WordsData;
                    //    if(a.CheckedWords != true)
                    //    {
                    //        Dragged = null;
                    //        first = false;
                    //        return;
                    //    }
                    //}
                    //MessageBox.Show("U WIN!!!");

                }
                else
                {
                    //MessageBox.Show("UUUUUUUUUUUUUUUUUUUUU");
                    Canvas.SetLeft(Dragged, SaveX);
                    Canvas.SetTop(Dragged, SaveY);
                }
            }
            // }
            // MouseHold = false;
            Dragged = null;
            first = false;
        }



        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            //if(MouseHold)
            //{
            if (Dragged != null)
            {
                Canvas.SetLeft(Dragged, e.GetPosition(Field).X - DragOffSetX);
                Canvas.SetTop(Dragged, e.GetPosition(Field).Y - DragOffSetY);
            }


            // }
        }

        class WordsData
        {
            public bool CheckedWords { get; set; }
            public Rectangle RECTANGLE { get; set; }

        }

    }
}
