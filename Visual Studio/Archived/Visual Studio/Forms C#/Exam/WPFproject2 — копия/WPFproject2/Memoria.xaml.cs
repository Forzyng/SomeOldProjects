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
    /// Логика взаимодействия для Memoria.xaml
    /// </summary>
    public partial class Memoria : Window
    {
        System.Windows.Threading.DispatcherTimer Timer;
        int ShowTime;
        private Card OpenedCard;
        private Card OpenedCard2;
        public Memoria()
        {
            InitializeComponent();
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Interval = new TimeSpan(1000000);
            Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ShowTime > 0)
            {
                ShowTime--;
                if (ShowTime == 0)
                {
                    (OpenedCard.Child as Label).Background = (OpenedCard2.Child as Label).Background =
                    (OpenedCard.Child as Label).Foreground = (OpenedCard2.Child as Label).Foreground = Brushes.Crimson;
                    OpenedCard = null;
                    OpenedCard2 = null;
                }
            }
        }
            private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Escape:
                    Close();
                    return;
            }
        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {
         
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 22; i++)
            {
                Card card = null;
                if (i >= 0 && i < 2)
                {
                     card = new Card((i % 6 + 1).ToString(), 0);
                }
                if (i >= 2 && i < 6)
                {
                    card = new Card((i % 6 + 1).ToString(), 1);
                }
                if (i >= 6 && i < 10)
                {
                    card = new Card((i % 6 + 1).ToString(), 2);
                }

                if (i >= 10 && i < 14)
                {
                    card = new Card((i % 6 + 1).ToString(), 3);
                }

                if (i >= 14 && i < 18)
                {
                    card = new Card((i % 6 + 1).ToString(), 4);
                }

                if (i >= 18 && i < 22)
                {
                    card = new Card((i % 6 + 1).ToString(), 5);
                }

                card.Child.MouseLeftButtonDown += Label_MouseUp_1;
                GameField.Children.Add(card);
                Timer.Start();
            }

            foreach (Border border in GameField.Children)
            {
                if(border != null)
                {
                    var label = border.Child as Label;
                    label.Foreground = label.Background;
                }
            }
            
        }

        private void Label_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            var label = sender as Label;
            if (label != null)
            {
                // label.Foreground = label.Background;
                label.Foreground = Brushes.HotPink;
                if (OpenedCard == null)  // first Click
                {
                    OpenedCard = label.Parent as Card;
                }
                else  // second Click
                {
                   if(OpenedCard.Child == label)
                    {

                    }
                    else
                    {
                        var OpenedLabel = OpenedCard.Child as Label;
                        if (OpenedLabel.Content.Equals(label.Content))
                        {
                            // MessageBox.Show("Umsebenzi omuhle");
                            OpenedLabel.Background = label.Background =
                                OpenedLabel.Foreground = label.Foreground = Brushes.White;


                            OpenedLabel.MouseUp -= Label_MouseUp_1;
                            label.MouseUp -= Label_MouseUp_1;
                            OpenedCard = null;
                        }
                        else
                        {
                            //MessageBox.Show("Kwenziwe kabi");
                            ShowTime = 11;
                            OpenedCard2 = label.Parent as Card;
                        }
                        
                    }
                }
                
            }
        }

        class Card : Border
        {
            public Card(String LabelContent, int check)
            {
                
                BorderThickness = new Thickness(3);
                // Margin = new Thickness(10);
                BorderBrush = Brushes.DarkRed;
                switch(check)
                {
                    case 0:
                        Background = Brushes.Crimson;
                        Child = new Label { Content = LabelContent, FontSize = 50, Foreground = Brushes.DarkBlue, HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, FontFamily = new FontFamily("Bookman Old Style") };
                        break;
                    case 1:
                        Background = Brushes.DarkOrange;
                        Child = new Label { Content = LabelContent, FontSize = 50, Foreground = Brushes.DarkBlue, HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, FontFamily = new FontFamily("Bookman Old Style") };
                        break;
                    case 2:
                        Background = Brushes.Yellow;
                        Child = new Label { Content = LabelContent, FontSize = 50, Foreground = Brushes.DarkBlue, HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, FontFamily = new FontFamily("Bookman Old Style") };
                        break;
                    case 3:
                        Background = Brushes.Green;
                        Child = new Label { Content = LabelContent, FontSize = 50, Foreground = Brushes.DarkRed, HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, FontFamily = new FontFamily("Bookman Old Style") };
                        break;
                    case 4:
                        Background = Brushes.DarkBlue;
                        Child = new Label { Content = LabelContent, FontSize = 50, Foreground = Brushes.DarkRed, HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, FontFamily = new FontFamily("Bookman Old Style") };
                        break;
                    case 5:
                        Background = Brushes.Purple;
                        Child = new Label { Content = LabelContent, FontSize = 50, Foreground = Brushes.DarkRed, HorizontalContentAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, FontFamily = new FontFamily("Bookman Old Style") };
                        break;
                }
                
                

            }
        }
    }
}

/*
 * 
 * Memoria или Найди пару
 * На игровом поле карточки, перевернутые рисунком вниз
 * переворачивается одна карточка, затем вторая.
 * Если рисунки на них совпадают, то карточки переворачиваются (рисунком вниз) и игра продолжается.
 * Задача игрока - запоминать открытые ранее карточки для подбора пар
 * Конец игры когда убраны с поля все карточки
 * 
 */
