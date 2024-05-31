using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBasicsSecond
{
    public partial class Form1 : Form
    {
        Roast roast;
        List<Addon> addons;
        public Form1()
        {
            InitializeComponent();
            // В конструкторе создаем/инициализируем данные
            roast = Roast.None;
            addons = new List<Addon>();
            addons.Add(new Addon { Name = "Mushrooms", Price = 5.99f });
            addons.Add(new Addon { Name = "Corn", Price = 4.99f });
            addons.Add(new Addon { Name = "Tomato", Price = 3.99f });
            addons.Add(new Addon { Name = "Cornflakes", Price = 10.99f });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Элементы формы собраны и готовы к применению (Но ещё не прорисованы)
            // В этом событие "настраиваем" то, что относится к элементам управления

            DopingCheckedListBox.Items.Clear();
            foreach (Addon addon in addons)
            {
                DopingCheckedListBox.Items.Add(addon);
            }
        }

        private void MainTittle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Message = "298";
            if (CheckBox1.Checked)
            {
                if (textBox2.Text != Message)
                {
                    MessageBox.Show("Ты не получишь Леона, если не введешь CVC правильно");
                }
                else
                {
                    MessageBox.Show("ПОСМОТРИ, На ТвоЁМ АКке в БрАБЛ КвАсЕ есть Лион");
                }
            }
            else
            {
                MessageBox.Show("Галочку поставь сначала");
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void LabelComboBoxPizza_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPizzaOrder_Click(object sender, EventArgs e)
        {
            String check = String.Empty;
            float sum = 0;
            // Diametr
            if(DiametrComboBox.SelectedItem == null)
            {
                MessageBox.Show("Как Леона выбивать, все галочки ставишь, как пиццу заказать, диаметр забываешь выбирать");
                return;
            }
            int diametr = Convert.ToInt32(DiametrComboBox.SelectedItem);

            float DiametrPrice = diametr * 1.5f;
            check += $"Diametr is  {diametr} cm ({DiametrPrice}$)\n";
            sum += DiametrPrice;
            float DoughPrice;
            Dough dough;
            if(PizzaDoughRadionButton1.Checked)
            {
                dough = Dough.Americano;
                DoughPrice = 15;
                check += $"Dough is {dough} ({DoughPrice}$)\n";
                sum += DoughPrice;
            }
            else
            {
                if(PizzaDoughRadionButton2.Checked)
                {
                    dough = Dough.Italiano;
                    DoughPrice = 20;
                    check += $"Dough is {dough} ({DoughPrice}$)\n";
                    sum += DoughPrice;
                }
                else
                {
                    MessageBox.Show("Блин, это как просто диаметр привезти? Нам что-ли круг и диаметр начертить?");
                    return;
                }
            }


            if (roast == Roast.None)
            {

                MessageBox.Show("Ну привезу я сырое тесто, и что?");
                return;

            }
            check += $"Roast is {roast}\n";
            check += "Doping is: ";
            foreach (var item in DopingCheckedListBox.CheckedItems)
            {
                check += "\n" + ((Addon)item).ToFullString();
                sum += ((Addon)item).Price;
            }
                
            // Delivery

            if(DeliveryCheckBox.Checked)
            {
                float DeliveryPrice = 40;
                check += $"\nDelivery is {DeliveryPrice}$\n";
                sum += DeliveryPrice;
            }
            else
            {
                check += "\nPickup\n";
            }

            check += $"Total sum is !!! {sum}$ !!!";

            if(
                 DialogResult.Yes ==
                 MessageBox.Show(check, "\n\n We are buying ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
               )
            {
                MessageBox.Show("Spasibo");
            }
            else
            {
                MessageBox.Show("Ne Spasibo");
            }
        }
      
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RoastLVL1.Checked)
            {
                roast = Roast.Rare;
            }
        }

        private void RoastLVLLabel_Click(object sender, EventArgs e)
        {

        }

        private void RoastLVLBox_Enter(object sender, EventArgs e)
        {

        }

        private void RoastLVL2_CheckedChanged(object sender, EventArgs e)
        {
            if(RoastLVL2.Checked)
            {
                roast = Roast.Medium;
            }
        }

        private void RoastLVL3_CheckedChanged(object sender, EventArgs e)
        {
            if (RoastLVL3.Checked)
            {
                roast = Roast.WellDone;
            }
        }

        private void ButtonXO_Click(object sender, EventArgs e)
        {
            // Создаём новую форму
            var xo = new xO();
            // Отображаем форму
            this.Hide();
            // xo.ShowDialog(); - модальный режим (Нельзя вернктся на прошлую форму) [Sync]
            // xo.Show(); - немодальный (обычный) режим - можно вернуться в т.ч. создать ещё форму [Async]
            xo.ShowDialog();
            this.Show();

        }

        private void ButtonPyatnashki_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pyatnashki().ShowDialog();
            this.Show();
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EventsDnD().ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Events2().ShowDialog();
            this.Show();
        }

        private void LabirintButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Labirint().ShowDialog();
            this.Show();
        }

        private void ButtonGDI_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GDI().ShowDialog();
            this.Show();
        }

        private void ButtonSquash_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Squash().ShowDialog();
            this.Show();
        }
    }


    enum Roast
    {
        None,
        Rare,
        Medium,
        WellDone
    }
    enum Dough
    {
        Americano,
        Italiano
    }


    class Addon
    {
        public String Name { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public String ToFullString()
        {
            return Name + " (" + Price + "$)";
        }
    }



}
