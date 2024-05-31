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
    /// Логика взаимодействия для AlienWar.xaml
    /// </summary>
    public partial class AlienWar : Window
    {
        System.Windows.Threading.DispatcherTimer Timer;
        GameState GMState;
        bool LeftHold, RightHold;
        //double AlienSpeed, AlienX, AlienY;

        int WeaponLoaded;

        List<Bullet> bullets;
        BitmapImage Alien2;
        List<Image> Aliens;

        int TimeToDown = 1;

        System.Xml.Serialization.XmlSerializer serializer;

        public AlienWar()
        {
            InitializeComponent();
            Alien2 = new BitmapImage(new Uri(@"D:\Programming\Visual Studio\Forms C#\WPFproject2\WPFproject2\alien3.jpg.png"));
            Aliens = new List<Image>();
            Timer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = new TimeSpan(100000)
            };
            Timer.Tick += Timer_Tick;

            GMState = new GameState();

            // Пробное сохранение

            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(GameState));
            //using (var source = new System.IO.StreamWriter("Saved.xml"))
            //{
            //    serializer.Serialize(source, new GameState { ShipSpeed = 5, ShipX = 350 });
            //}
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Moving Bullet
            Bullet ToRemove = null;
            Image toremove = null;
            foreach(var bullet in bullets)
            {
                bullet.Y -= bullet.V;
                if(bullet.Y <= 0)
                {
                    GameField.Children.Remove(bullet.Figure);
                    ToRemove = bullet;
                }
                else
                {
                    Canvas.SetTop(bullet.Figure, bullet.Y);
                }
            }
            if(ToRemove != null)
            {
                GameField.Children.Remove(ToRemove.Figure);
                bullets.Remove(ToRemove);
            }

            if(WeaponLoaded > 0)
            {
                WeaponLoaded--;
            }



            foreach(var ali in Aliens)
            {
                foreach (var bullet in bullets)
                {
                    Canvas.SetLeft(ali, GMState.AlienX);
                    Canvas.SetTop(ali, GMState.AlienY);
                    //GMState.AlienX = Canvas.GetLeft(ali);
                    //GMState.AlienY = Canvas.GetTop(ali);
                    if (bullet.X >= GMState.AlienX && bullet.X <= GMState.AlienX + ali.ActualWidth && bullet.Y >= GMState.AlienY && bullet.Y <= GMState.AlienY + ali.ActualHeight)
                    {
                        toremove = ali;
                        ToRemove = bullet;
                    }
                }

            }
            if(toremove != null)
            {
                GameField.Children.Remove(toremove);
                Aliens.Remove(toremove);
            }

            if (ToRemove != null)
            {
                GameField.Children.Remove(ToRemove.Figure);
                bullets.Remove(ToRemove);
            }
            if(Aliens.Count == 0)
            {
                Timer.Stop();
                MessageBox.Show("U WINN!!!");
                this.Close();
            }
            foreach (var a in Aliens)
            {

                Canvas.SetLeft(a, GMState.AlienX);
                Canvas.SetTop(a, GMState.AlienY);

                //GMState.AlienX = Canvas.GetLeft(a);
                //GMState.AlienY = Canvas.GetTop(a);

                GMState.AlienX += GMState.AlienSpeed;
                if (GMState.AlienX <= 0)
                {

                    GMState.AlienX = 0;
                    GMState.AlienY += a.ActualHeight;
                    GMState.AlienSpeed = -GMState.AlienSpeed;
                    if(TimeToDown == 0)
                    {
                        foreach (var b in Aliens)
                        {
                            Canvas.SetTop(b, GMState.AlienY);
                        }
                        TimeToDown = 2;
                    }
                    TimeToDown--;

                }
                if (GMState.AlienX + a.ActualWidth >= GameField.ActualWidth)
                {
                    GMState.AlienY += a.ActualHeight;
                    GMState.AlienX = GameField.ActualWidth - a.ActualWidth;
                    GMState.AlienSpeed = -GMState.AlienSpeed;
                    if (TimeToDown == 0)
                    {
                        foreach (var b in Aliens)
                        {
                            Canvas.SetTop(b, GMState.AlienY);
                        }
                        TimeToDown = 2;
                    }
                    TimeToDown--;
                }
                if (GMState.AlienY >= GameField.ActualHeight - a.ActualHeight)
                {
                    Timer.Stop();
                    MessageBox.Show("GG");
                    this.Close();
                }
                Canvas.SetLeft(a, GMState.AlienX);
                
            }

            




            if (LeftHold)
            {
                if(GMState.ShipX > 0)
                {
                    GMState.ShipX -= GMState.ShipSpeed;
                }
            }
            if (RightHold)
            {
                if (GMState.ShipX + Ship.ActualWidth < GameField.ActualWidth)
                {
                    GMState.ShipX += GMState.ShipSpeed;
                }
            }
            if (RightHold || LeftHold)
            {
                Canvas.SetLeft(Ship, GMState.ShipX);
            }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            bullets = new List<Bullet>();

            (Tag as GameData).Score += 10;
            Timer.Start();

            LeftHold = RightHold = false;

            serializer = new System.Xml.Serialization.XmlSerializer(typeof(GameState));
            using (var source = new System.IO.StreamReader("Saved.xml"))
            {
                GMState = (GameState)serializer.Deserialize(source);
            }

            Canvas.SetLeft(Ship, GMState.ShipX);


            //AlienSpeed = 5;
            GMState.AlienSpeed = 5;
            TimeToDown = 1;

            WeaponLoaded = 25;
            for(int i = 0; i< 1;i++)
            {
                Image image = new Image
                {
                    Width = 100,
                    Source = Alien2
                };
                Aliens.Add(image);
                GameField.Children.Add(image);
                Canvas.SetTop(image, 35);
                Canvas.SetLeft(image, 100 + 100 * i);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Timer.Stop();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Left:
                    LeftHold = true;
                    break;
                case Key.Right:
                    RightHold = true;
                    break;
                case Key.Escape:
                    this.Close();
                    break;
                case Key.Space: // Выстрел
                    if(WeaponLoaded == 0)
                    {

                    
                        Bullet bullet = new Bullet
                        {
                            Figure = new Ellipse { Fill = Brushes.Crimson, Width = 4, Height = 30 },
                            V = 5,
                            Y = Canvas.GetTop(Ship) - 40,
                            X = GMState.ShipX + Ship.ActualWidth / 2
                        };

                        GameField.Children.Add(bullet.Figure);

                        Canvas.SetLeft(bullet.Figure, bullet.X);
                        Canvas.SetTop(bullet.Figure, bullet.Y);
                    bullets.Add(bullet);
                        WeaponLoaded = 25;
                    }

                    break;
                case Key.S:
                    using (var source = new System.IO.StreamWriter("Saved.xml"))
                    {
                        serializer.Serialize(source, GMState);
                    }
                        break;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Left:
                    LeftHold = false;
                    break;
                case Key.Right:
                    RightHold = false;
                    break;
            }
        }

        class Bullet
        {
            public Ellipse Figure { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public double V { get; set; }
        }
    }
}
