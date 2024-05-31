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
        //bool MouseHold;
        double DragOffSetX, DragOffSetY;
        double SaveX, SaveY;
        bool first;
        TextBlock Dragged;
        List<TextBlock> Letters;
        public Words()
        {
            InitializeComponent();
            // MouseHold = false;
            Dragged = null;
            first = false;
            SaveX = SaveY = 0;
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
                            MessageBox.Show("U WIN!!!");
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
