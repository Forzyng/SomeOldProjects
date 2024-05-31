using System;
using System.Collections.Generic;
using System.IO;
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
        User user;
        System.Xml.Serialization.XmlSerializer SerializerOfUser;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(user.OpenedMinesweeper)
            {
                Load();
                this.Hide();
                new Minesweeper().ShowDialog();
                this.Show();
                Upload();
                LabelMoney.Content = user.Money;
            }
            //this.Visibility = Visibilty.Collapsed;
            else
            {
                MessageBox.Show("U haven`t bought this game");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if(user.OpenedAlienWar)
            {
                Load();
                this.Hide();
                // new AlienWar().ShowDialog();
                var ALIENWAR = new AlienWar();
                ALIENWAR.Tag = new GameData { Score = 0 };
                ALIENWAR.ShowDialog();
                this.Title += " " + (ALIENWAR.Tag as GameData).Score;
                this.Show();
                Upload();
                LabelMoney.Content = user.Money;
            }
            else
            {
                MessageBox.Show("U haven`t bought this game");
            }
           
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            if(user.OpenedWords)
            {
                Load();
                this.Hide();
                new Words().ShowDialog();
                this.Show();
                Upload();
                LabelMoney.Content = user.Money;
            }
            else
            {
                MessageBox.Show("U haven`t bought this game");
            }

        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            if (user.OpenedSnake)
            {
                Load();
                this.Hide();
                new Snake().ShowDialog();
                this.Show();
                Upload();
                LabelMoney.Content = user.Money;
            }
            else
            {
                MessageBox.Show("U haven`t bought this game");
            }
            
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            if(user.OpenedFlappy)
            {
                Load();
                this.Hide();
                new FlappyBird().ShowDialog();
                this.Show();
                Upload();
                LabelMoney.Content = user.Money;
            }
            else
            {
                MessageBox.Show("U haven`t bought this game");
            }
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            if(user.OpenedMemoria)
            {
                Load();
                this.Hide();
                new Memoria().ShowDialog();
                this.Show();
                Upload();
                LabelMoney.Content = user.Money;
            }
            else
            {
                MessageBox.Show("U haven`t bought this game");
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.S:
                    Load();
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
      SerializerOfUser = new System.Xml.Serialization.XmlSerializer(typeof(User));


            if (File.Exists(@"D:\Programming\Visual Studio\Forms C#\WPFproject2 — копия\WPFproject2\bin\Debug\SavedUser.xml"))
            {

            }
            #region Creating User 
            else
            {
               
                using (var source = new System.IO.StreamWriter("SavedUser.xml"))
                {
                    SerializerOfUser.Serialize(source, new User
                    {
                        Login = "Zod",
                        Password = "123456789",
                        HighScoreInMinesweeper = 0,
                        HighScoreInAlienWar = 0,
                        HighScoreInFlappy = 0,
                        HighScoreInMemoria = 0,
                        HighScoreInSnake = 0,
                        HighScoreInWords = 0,
                        Money = 100000,
                        OpenedAlienWar = false,
                        OpenedFlappy = false,
                        OpenedMemoria = false,
                        OpenedMinesweeper = false,
                        OpenedSnake = false,
                        OpenedWords = false,
                        TotalClicks = 0
                    });
                }
            }




            

            #endregion





            Upload();

            LabelNick.Content = user.Login;
            LabelMoney.Content = user.Money;

        }
       
        private void Coin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Load();
            this.Hide();
            new Clicker().ShowDialog();
            this.Show();
            Upload();
            LabelMoney.Content = user.Money;
            LabelMoney.Content = user.Money;
        }

        private void ImageBuy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(!user.OpenedMinesweeper)
            {
                if (user.Money < 1000)
                {
                    MessageBox.Show("Not enough money");
                }
                else
                {
                    user.Money -= 1000;
                    LabelMoney.Content = user.Money;
                    user.OpenedMinesweeper = true;
                    Load();
                    MessageBox.Show("Don`t for get to use 'S' - for save", "Thx for buying");
                }
            }
            else
            {
                MessageBox.Show("U have already bought this game", "Attention");
            }
            
        }

        private void ImageBuyWords_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!user.OpenedWords)
            {


                if (user.Money < 2000)
                {
                    MessageBox.Show("Not enough money");
                }
                else
                {
                    user.Money -= 2000;
                    LabelMoney.Content = user.Money;
                    user.OpenedWords = true;
                    Load();
                    MessageBox.Show("Don`t for get to use 'S' - for save", "Thx for buying");
                }
            }
            else
            {
                MessageBox.Show("U have already bought this game", "Attention");
            }
        }

        private void ImageBuyMemoria_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!user.OpenedMemoria)
            {


                if (user.Money < 3000)
                {
                    MessageBox.Show("Not enough money");
                }
                else
                {
                    user.Money -= 3000;
                    LabelMoney.Content = user.Money;
                    user.OpenedMemoria = true;
                    Load();
                    MessageBox.Show("Don`t for get to use 'S' - for save", "Thx for buying");
                }
            }
            else
            {
                MessageBox.Show("U have already bought this game", "Attention");
            }
        }

        private void ImageBuySnake_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!user.OpenedSnake)
            {


                if (user.Money < 4000)
                {
                    MessageBox.Show("Not enough money");
                }
                else
                {
                    user.Money -= 4000;
                    LabelMoney.Content = user.Money;
                    user.OpenedSnake = true;
                    Load();
                    MessageBox.Show("Don`t for get to use 'S' - for save", "Thx for buying");
                }
            }
            else
            {
                MessageBox.Show("U have already bought this game", "Attention");
            }
        }

        private void ImageBuyFlappy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!user.OpenedFlappy)
            {
                user.OpenedFlappy = true;
                Load();
                MessageBox.Show("Don`t for get to use 'S' - for save", "Thx for buying");
            }
            else
            {
                MessageBox.Show("U have already bought this game", "Attention");
            }
        }

        private void ImageBuyAlien_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!user.OpenedAlienWar)
            {


                if (user.Money < 5000)
                {
                    MessageBox.Show("Not enough money");
                }
                else
                {
                    user.Money -= 5000;
                    LabelMoney.Content = user.Money;
                    user.OpenedAlienWar = true;
                    Load();
                    MessageBox.Show("Don`t for get to use 'S' - for save", "Thx for buying");
                }
            }
            else
            {
                MessageBox.Show("U have already bought this game", "Attention");
            }
        }

        private void LabelInfo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Upload();
            String Full = String.Empty;
            Full += $"Minesweeper - {user.HighScoreInMinesweeper}\n";
            Full += $"Words - {user.HighScoreInWords}\n";
            Full += $"Memoria - {user.HighScoreInMemoria}\n";
            Full += $"Snake - {user.HighScoreInSnake}\n";
            Full += $"FlappyBird - {user.HighScoreInFlappy}\n";
            Full += $"Galaxy Attack - {user.HighScoreInAlienWar}";
            MessageBox.Show($"{Full}", "Ur Personal Records");
        }

        private void Upload()
        {
            using (var source = new System.IO.StreamReader("SavedUser.xml"))
            {
                user = (User)SerializerOfUser.Deserialize(source);
            }
        }
        private void Load()
        {
            using (var source = new System.IO.StreamWriter("SavedUser.xml"))
            {
                SerializerOfUser.Serialize(source, user);
            }
        }
    }
}
