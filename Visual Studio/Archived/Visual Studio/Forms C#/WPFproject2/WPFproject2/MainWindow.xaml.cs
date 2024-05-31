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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFproject2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //this.Visibility = Visibilty.Collapsed;
            this.Hide();
            new Minesweeper().ShowDialog();
            this.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Words().ShowDialog();
            this.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Snake().ShowDialog();
            this.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new FlappyBird().ShowDialog();
            this.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Memoria().ShowDialog();
            this.Show();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            // new AlienWar().ShowDialog();
            var ALIENWAR = new AlienWar();
            ALIENWAR.Tag = new GameData { Score = 0 };
            ALIENWAR.ShowDialog();
            this.Title += " " + (ALIENWAR.Tag as GameData).Score;
            this.Show();
        }
    }
}
