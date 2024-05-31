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

    public partial class Minesweeper : Window
    {
        int W;
        int H;
        int LableFS;
        Random rnd;
        public Minesweeper()
        {
            InitializeComponent();
            W = 10;
            H = 10;
            rnd = new Random();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Gamefield.Columns = W;
            Gamefield.Rows = H;

            Thickness LabelMargin = new Thickness(2);
            FontFamily LabelFF = new FontFamily("Times New Roman");
            FontWeight LabelFW = FontWeights.Heavy;
            LableFS = 30;
            bool BoolRnd;



            for (int x = 0; x < H; x++)
            {
                for (int y = 0; y < W; y++)
                {
                    BoolRnd = (rnd.Next(7) == 0);
                    Label label = new Label
                    {
                        //Background = ((x & 1) == 1) ? Brushes.MediumPurple : Brushes.DarkMagenta,
                        //Foreground = ((x & 1) == 1) ? Brushes.DarkRed : Brushes.DarkOrange,
                        Background = Brushes.MediumPurple,
                        Foreground = BoolRnd ? Brushes.DarkRed : Brushes.OrangeRed,
                        FontWeight = LabelFW,
                        FontSize = LableFS,
                        FontFamily = LabelFF,
                        Content = BoolRnd ? "#" : "",
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                        VerticalContentAlignment = VerticalAlignment.Center,
                        Margin = LabelMargin,
                        Tag = new LabelData // Tag - поле для доп. тнфо, не участвует в отображении
                        {
                            X = x, Y = y, IsMine = BoolRnd
                        }
                    };
                    label.MouseDown += Label_Click;

                    // Регистрация элемента (по имени)
                    this.RegisterName("CELL" + x + "_" + y, label);


                    // Children - аналог Controls (в Forms) - коллекция дочерних элементов
                    Gamefield.Children.Add(label);
                }
            }





        }
        private void Label_Click(object sender, RoutedEventArgs e)
        {
            var label = sender as Label;
           
            if(label != null)
            {   

                var Data = label.Tag as LabelData; // Извлекаем доп. Информацию
                // Проверяем мина ли это
                if(Data.IsMine)
                {
                    MessageBox.Show("الله عظيم");
                    return;
                }

                // Формируем имя соседа, исходя из известных координат

                String[] Neighbourname = new String[]
                {
                    "CELL" + (Data.X - 1) + "_" + Data.Y, // Left
                    "CELL" + (Data.X + 1) + "_" + Data.Y, // Right
                    "CELL" + Data.X + "_" + (Data.Y-1), // Top
                    "CELL" + Data.X + "_" + (Data.Y+1), // Bottom

                     "CELL" + (Data.X - 1) + "_" + (Data.Y-1),
                    "CELL" + (Data.X + 1) + "_" + (Data.Y+1), 
                    "CELL" + (Data.X + 1) + "_" + (Data.Y-1), 
                    "CELL" + (Data.X - 1)+ "_" + (Data.Y+1), 
            };
                //String Neighbourname = "CELL" + (Data.X - 1) + "_" + Data.Y;

                // Пробуем найти зарегистрированное имя

                int n = 0;
                foreach(String name in Neighbourname)
                {
                    // Пробуем найти зарегестрированное имя
                    var neighbour = this.FindName(name) as Label;
                    // Проверяем найдено ли
                    if(neighbour!=null)
                    {
                        // Извлекаем данные и проверяем на мину
                        if((neighbour.Tag as LabelData).IsMine)
                        {
                            n++;
                        }
                      
                    }
                }
                switch(n)
                {
                    case 0:
                        label.Content = n.ToString();
                        label.Foreground = Brushes.DarkGray;
                        break;
                    case 1:
                        label.Content = n.ToString();
                        label.Foreground = Brushes.DarkBlue;
                        break;
                    case 2:
                        label.Content = n.ToString();
                        label.Foreground = Brushes.DarkGreen;
                        break;
                    case 3:
                        label.Content = n.ToString();
                        label.Foreground = Brushes.Red;
                        break;
                    case 4:
                        label.Content = n.ToString();
                        label.Foreground = Brushes.DarkViolet;
                        break;
                    case 5:
                        label.Content = n.ToString();
                        label.Foreground = Brushes.DeepPink;
                        break;
                        
                }
               // label.Content = n.ToString();
           


            }
        }

        class LabelData
        {
            public int X { get; set; }
            public int Y { get; set; }
            public bool IsMine { get; set; }
        }

    }
}
