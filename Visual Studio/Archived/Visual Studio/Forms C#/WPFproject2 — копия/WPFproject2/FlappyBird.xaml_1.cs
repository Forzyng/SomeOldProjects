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
    public partial class FlappyBird : Window
    {
        const int WALLINTERVAL = 60;

        int color = 0;

        System.Windows.Threading.DispatcherTimer Timer;
        int Speed = 200000;
        double BirdY;
        double kg = 2;
        double WallInterval;
        Random rnd;


        List<WALL> wALLs;
        Ellipse Bird;

        public FlappyBird()
        {
            InitializeComponent();
           
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Interval = new TimeSpan(Speed);
            Timer.Tick += Timer_Tick;

            wALLs = new List<WALL>();
            Bird = new Ellipse { Width = 15, Height = 15, Fill = Brushes.DarkOrange };

            WallInterval = 60;

            rnd = new Random();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Escape:
                    this.Close();
                        break;
                case Key.Space:
                    if (Canvas.GetTop(Bird) - (kg * 15) <= 10)
                    {
                    }
                    else
                    {
                        BirdY -= kg * 15;
                    }
                       
                    break;
            }
        }

        private void ShowWALL()
        {
            foreach(WALL w in wALLs)
            {
                if(!GameField.Children.Contains(w.TopSegment))
                {
                    GameField.Children.Add(w.TopSegment);
                    Canvas.SetTop(w.TopSegment, 0);
                }
                if (!GameField.Children.Contains(w.BottomSegment))
                {
                    GameField.Children.Add(w.BottomSegment);
                    Canvas.SetBottom(w.BottomSegment, 0);
                }

                Canvas.SetLeft(w.TopSegment, w.X);
                Canvas.SetLeft(w.BottomSegment, w.X);
            }
        }
        private void AddWall()
        {
            int Gap = 80;
            int TopH = rnd.Next(100, 300);
            #region DRY
            switch (color)
            {
                case 0:
                    wALLs.Add(new WALL
                    {
                        TopSegment = new Rectangle { Fill = Brushes.Red, Width = 20, Height = TopH },
                        BottomSegment = new Rectangle { Fill = Brushes.Red, Width = 20, Height = GameField.ActualHeight - TopH - Gap },
                        X = GameField.ActualWidth
                    });
                    color++;
                    break;
                case 1:
                    wALLs.Add(new WALL
                    {
                        TopSegment = new Rectangle { Fill = Brushes.DarkOrange, Width = 20, Height = TopH },
                        BottomSegment = new Rectangle { Fill = Brushes.DarkOrange, Width = 20, Height = GameField.ActualHeight - TopH - Gap },
                        X = GameField.ActualWidth
                    });
                    color++;
                    break;
                case 2:
                    wALLs.Add(new WALL
                    {
                        TopSegment = new Rectangle { Fill = Brushes.Yellow, Width = 20, Height = TopH },
                        BottomSegment = new Rectangle { Fill = Brushes.Yellow, Width = 20, Height = GameField.ActualHeight - TopH - Gap },
                        X = GameField.ActualWidth
                    });
                    color++;
                    break;
                case 3:
                    wALLs.Add(new WALL
                    {
                        TopSegment = new Rectangle { Fill = Brushes.Green, Width = 20, Height = TopH },
                        BottomSegment = new Rectangle { Fill = Brushes.Green, Width = 20, Height = GameField.ActualHeight - TopH - Gap },
                        X = GameField.ActualWidth
                    });
                    color++;
                    break;
                case 4:
                    wALLs.Add(new WALL
                    {
                        TopSegment = new Rectangle { Fill = Brushes.DarkBlue, Width = 20, Height = TopH },
                        BottomSegment = new Rectangle { Fill = Brushes.DarkBlue, Width = 20, Height = GameField.ActualHeight - TopH - Gap },
                        X = GameField.ActualWidth
                    });
                    color++;
                    break;
                case 5:
                    wALLs.Add(new WALL
                    {
                        TopSegment = new Rectangle { Fill = Brushes.Purple, Width = 20, Height = TopH },
                        BottomSegment = new Rectangle { Fill = Brushes.Purple, Width = 20, Height = GameField.ActualHeight - TopH - Gap },
                        X = GameField.ActualWidth
                    });
                    color = 0;
                    break;
            }
            #endregion

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AddWall();
            GameField.Children.Add(Bird);

            BirdY = (GameField.ActualHeight - Bird.Height) / 2;

            Canvas.SetTop(Bird, BirdY);
            Canvas.SetLeft(Bird, (GameField.ActualWidth - Bird.Width) / 2);
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
           
        
           WallInterval--;
            if(WallInterval <= 0)
            {
                WallInterval = WALLINTERVAL;
                // Добавляем преграду в коллекцию
                AddWall();
            }
            WALL ToRemove = null;
            foreach (WALL w in wALLs)
            {
                w.X -= 3;
                //if (Bird.ActualHeight <= w.X + w.TopSegment.Width)
                //{

                //}
                if (Canvas.GetTop(Bird) >= GameField.ActualHeight - 10)
                {
                    Timer.Stop();
                    MessageBox.Show("GG");
                    this.Close();
                    return;
                }

                //if (Canvas.GetTop(Bird) <= 10 )
                //{
                //    Timer.Stop();
                //    MessageBox.Show("GG");
                //    this.Close();
                //    return;
                //}

                if (w.X <= -w.TopSegment.Width)
                {
                    ToRemove = w;
                }
            }
            if(ToRemove != null)
            {
                wALLs.Remove(ToRemove);
                GameField.Children.Remove(ToRemove.TopSegment);
                GameField.Children.Remove(ToRemove.BottomSegment);
            }
            ShowWALL();
            BirdY += kg;
            Canvas.SetTop(Bird, BirdY);
           
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }


        class WALL
        {
            public Rectangle TopSegment;
            public Rectangle BottomSegment;
            public double X;
        }
    }
}
