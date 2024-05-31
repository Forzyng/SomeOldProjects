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
    /// Логика взаимодействия для Snake.xaml
    /// </summary>
    public partial class Snake : Window
    {
        User user;
        System.Xml.Serialization.XmlSerializer SerializerOfUser;

        int XP = 0;

        System.Windows.Threading.DispatcherTimer Timer;
        private int speed;

        private Section Food;

        private Random rnd;

        int SMoney = 0;

        private int D = 20;
        private int AteFood = 0;
        private int counter = 0;
        private int color = 0;
        private int N = 50;
        private int M = 40;
       SolidColorBrush ColorRect;

        private List<Section> Python;
        private Direction MoveDirectrion;

        public Snake()
        {
            InitializeComponent();
            Timer = new System.Windows.Threading.DispatcherTimer();
            Python = new List<Section>();
            rnd = new Random();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SerializerOfUser = new System.Xml.Serialization.XmlSerializer(typeof(User));



            using (var source = new System.IO.StreamReader("SavedUser.xml"))
            {
                user = (User)SerializerOfUser.Deserialize(source);
            }

            Food = new Section { Position = new Point(), Figure = new Ellipse { Width = D, Height = D, Fill = Brushes.DarkRed } };
            do
            {
                Food.Position.X = rnd.Next(0, N);
                Food.Position.Y = rnd.Next(0, M);
            } while (GetSectionByPosition(Food.Position) != null);
            GameField.Children.Add(Food.Figure);
            ShowFood(Food);


            speed = 110; // milisec
            Timer.Interval = new TimeSpan(0, 0, 0, 0, speed);
            Timer.Tick += Timer_Tick;

            Python.Add(new Section
            {
                Position = new Point(N / 2 - 2, M / 2),
                Figure = new Ellipse { Width = D, Height = D, Fill = Brushes.Red }
            });
            Python.Add(new Section
            {
                Position = new Point(N / 2 - 1, M / 2),
                Figure = new Ellipse { Width = D, Height = D, Fill = Brushes.Orange }
            });
            Python.Add(new Section
            {
                Position = new Point(N / 2 - 0, M / 2),
                Figure = new Ellipse { Width = D, Height = D, Fill = Brushes.Yellow }
            });
            Python.Add(new Section
            {
                Position = new Point(N / 2 + 1, M / 2),
                Figure = new Ellipse { Width = D, Height = D, Fill = Brushes.Green }
            });
            Python.Add(new Section
            {
                Position = new Point(N / 2 + 2, M / 2),
                Figure = new Ellipse { Width = D, Height = D, Fill = Brushes.DarkBlue }
            });
            Python.Add(new Section
            {
                Position = new Point(N / 2 + 3, M / 2),
                Figure = new Ellipse { Width = D, Height = D, Fill = Brushes.Purple }
            });

            ShowZmeya();

           
            MoveDirectrion = Direction.Right;
            Timer.Start();
        }

        private void ShowZmeya()
        {
            foreach(var section in Python)
            {
                if(!GameField.Children.Contains(section.Figure))
                {
                    GameField.Children.Add(section.Figure);
                    ShowSection(section);
                }
            }
        }

        private void MovePython()
        {
            // Перерисовывать все звенья не нужно, достаточно стререть "хвост" и добавить
            // секцию перед "головой" в зависимости от направления движения
            Section head = Python.Last(); // ссылка на первый элемент в списке
            Section tail = Python.First();


            Point tailPosition = head.Position;
            /*
            // меняем позицию через эту ссылку
            tail.Position.X = head.Position.X;
            tail.Position.Y = head.Position.Y;
            */
            switch (MoveDirectrion)
            {
                case Direction.Left:
                    tailPosition.X--;
                    break;
                case Direction.Right:
                    tailPosition.X++;
                    break;
                case Direction.Up:
                    tailPosition.Y--;
                    break;
                case Direction.Down:
                    tailPosition.Y++;
                    break;
            }

            

            if (Food.Position.Equals(tailPosition))
            {
                switch (color)
                {
                    case 0:
                        ColorRect = Brushes.Red;
                        color++;
                        break;
                    case 1:
                        ColorRect = Brushes.Orange;
                        color++;
                        break;
                    case 2:
                        ColorRect = Brushes.Yellow;
                        color++;
                        break;
                    case 3:
                        ColorRect = Brushes.Green;
                        color++;
                        break;
                    case 4:
                        ColorRect = Brushes.DarkBlue;
                        color++;
                        break;
                    case 5:
                        ColorRect = Brushes.Purple;
                        color = 0;
                        break;
                }
                tail = new Section
                {
                    Position = tailPosition,
                  
                    Figure = new Ellipse { Width = 20, Height = 20, Fill = ColorRect }
                };
                Food.Figure.Fill = Background;

                XP += 20;
                SMoney += 10;
                AteFood++;
                if (AteFood >= 10)
                {
                    Timer.Stop();
                    String Full = String.Empty;
                    XP += 100;
                    SMoney += 200;
                    Full += $"Ur Score: {XP}\n";
                    Full += $"Highest Score: {user.HighScoreInSnake}\n";
                    Full += $"+ {SMoney} coins";

                    user.Money += SMoney;
                    if (XP > user.HighScoreInSnake)
                    {
                        user.HighScoreInSnake = XP;
                    }

                    using (var source = new System.IO.StreamWriter("SavedUser.xml"))
                    {
                        SerializerOfUser.Serialize(source, user);
                    }

                    MessageBox.Show($"{Full}", "U WINN!!!");
                    Close();
                    return;
                }
                speed -= 10; // milisec
                Timer.Interval = new TimeSpan(0, 0, 0, 0, speed);
                Food = new Section { Position = new Point(), Figure = new Ellipse { Width = D, Height = D, Fill = Brushes.DarkRed } };
                do
                {
                    Food.Position.X = rnd.Next(0, N);
                    Food.Position.Y = rnd.Next(0, M);
                } while (GetSectionByPosition(Food.Position) != null);

                GameField.Children.Add(Food.Figure);
                ShowFood(Food);
                Python.Add(tail);
                ShowZmeya();
            }
            else
            {
                Python.Remove(tail); // удаляем ссылку на объект из списка, но сам объект доступен через tail
                tail.Position = tailPosition;

                // Проверка на нарушение границ поля + Проверка на укус себя
                if (tailPosition.X < 0 || tailPosition.X >= N
                || tailPosition.Y < 0 || tailPosition.Y >= M
                || GetSectionByPosition(tailPosition) != null)
                {
                    Timer.Stop();
                    String Full = String.Empty;
                    XP += 20;
                    Full += $"Ur Score: {XP}\n";
                    Full += $"Highest Score: {user.HighScoreInSnake}\n";
                    Full += $"+ 20 coins";

                    user.Money += 20;
                    if (XP > user.HighScoreInSnake)
                    {
                        user.HighScoreInSnake = XP;
                    }
                    using (var source = new System.IO.StreamWriter("SavedUser.xml"))
                    {
                        SerializerOfUser.Serialize(source, user);
                    }

                    MessageBox.Show($"{Full}", "GG");
                    Close();
                    return;
                }

                Python.Add(tail); // добавляем ссылку на тот же объект, только с измененными коорд.

                
                ShowSection(tail);
            }
        }

        private void ShowSection(Section section)
        {
            //foreach (var a in Python)
            //{
            //    counter++;
            //}
            foreach (var a in Python)
            {
              
                    Canvas.SetZIndex(a.Figure, counter++);
                
            }
            
            counter = 0;
            //Canvas.SetZIndex(section.Figure, 1);

            Canvas.SetLeft(section.Figure, GameField.ActualWidth / N * section.Position.X);
                Canvas.SetTop(section.Figure, GameField.ActualHeight / M * section.Position.Y);
            //counter++;
            //section.Figure.
            // Canvas.SetZIndex(section.Figure, 1);
        }

        private void ShowFood(Section section)
        {
            Canvas.SetLeft(section.Figure, GameField.ActualWidth / N * section.Position.X);
            Canvas.SetTop(section.Figure, GameField.ActualHeight / M * section.Position.Y);
        }












        private Section GetSectionByPosition(Point position)
        {
            foreach(Section section in Python)
            {
                if(section.Position.Equals(position))
                {
                    return section;
                }
            }
            return null;
        }
//А как сделать массив цветов, что бы их можно было использовать в качестве следующей заливки фигур?
        private void Timer_Tick(object sender, EventArgs e)
        {
            MovePython();
        }

        /*
         * 
         * Змейка состоит из звеньев
         * 
         */

        class Section
        {
            public Ellipse Figure;
            public Point Position;
        }


        public enum Direction
        {
            None,
            Left,
            Right,
            Up,
            Down
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Space:
                    Timer.Stop();
                break;

                case Key.Escape:
                    Timer.Stop();
                    this.Close();
                    break;

                case Key.Left:
                    if(MoveDirectrion != Direction.Right)
                    {
                        MoveDirectrion = Direction.Left;
                    }
                    break;

                case Key.Right:
                    if (MoveDirectrion != Direction.Left)
                    {
                        MoveDirectrion = Direction.Right;
                    }
                    break;

                case Key.Down:
                    if (MoveDirectrion != Direction.Up)
                    {
                        MoveDirectrion = Direction.Down;
                    }
                    break;


                case Key.Up:
                    if (MoveDirectrion != Direction.Down)
                    {
                        MoveDirectrion = Direction.Up;
                    }
                    break;
            }
        }
    }
}
