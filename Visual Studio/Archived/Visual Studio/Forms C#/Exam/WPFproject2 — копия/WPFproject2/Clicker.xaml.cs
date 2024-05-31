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
    /// Логика взаимодействия для Clicker.xaml
    /// </summary>
    public partial class Clicker : Window
    {
        User user;
        System.Xml.Serialization.XmlSerializer SerializerOfUser;

        SolidColorBrush brush;

        System.Windows.Threading.DispatcherTimer Timer;
        int ClickCnt;
        public Clicker()
        {
            InitializeComponent();

            Timer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = new TimeSpan((long)1e7)
            };
            Timer.Tick += Timer_Tick;
            brush = new SolidColorBrush(Colors.Purple);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Progress.Value = ClickCnt * 10;

            brush.Color = Color.FromRgb(
                (byte)(250 - ClickCnt * 25),
                (byte)(ClickCnt * 25),
                (byte)100);

            Progress.Foreground = brush;
            FPS.Content = ClickCnt + " - ClickPS";
            ClickCnt = 0;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            SerializerOfUser = new System.Xml.Serialization.XmlSerializer(typeof(User));
            using (var source = new System.IO.StreamReader("SavedUser.xml"))
            {
                user = (User)SerializerOfUser.Deserialize(source);
            }
            totals.Content = user.TotalClicks;
            Timer.Start();



        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ClickCnt++;
            user.Money++;
            user.TotalClicks++;
            totals.Content = user.TotalClicks;

            using (var source = new System.IO.StreamWriter("SavedUser.xml"))
            {
                SerializerOfUser.Serialize(source, user);
            }
        }
    }
}
