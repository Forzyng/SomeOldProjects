using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace DB_WForms_PR
{
    public partial class Form1 : Form
    {
        private DataContext dataContext;
        public Form1()
        {
            InitializeComponent();
            Connecting login = new Connecting();
            login.ShowDialog();
            dvgCountries.AutoGenerateColumns = true;
            using (Connecting form2 = new Connecting())
            {


                dataContext =  new DataContext($@"Data Source={login.TheValueServer};AttachDbFilename={login.TheValueDB};Integrated Security=True");
            }

            var themes = from t in dataContext.GetTable<Country>()
                         orderby t.Name_Country
                         select t;

            //themes = dataContext.GetTable<Themes>();
            dvgCountries.DataSource = themes;

        }

        private void Button_Show_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbSee.Text))
            {
                return;
            }
            if(txbSee.Text == "*")
            {
                var themes = from t in dataContext.GetTable<Country>()
                             orderby t.Name_Country
                             select t;

                //themes = dataContext.GetTable<Themes>();
                dvgCountries.DataSource = themes;
            }
            else
            {
                var themes = dataContext.GetTable<Country>().Where(t => t.Name_Country.Contains(txbSee.Text));         //Contains(txbSearch.Text));
                dvgCountries.DataSource = themes;
                
            }
            txbSee.Text = null;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Show_Countries_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Show_Countries.Text))
            {
                return;
            }
            /*var themes = dataContext.GetTable<Country>().Where(t => t.Name_Part_World.Contains(txb_Show_Countries.Text)); */        //Contains(txbSearch.Text));
            var themes = from t in dataContext.GetTable<Country>()
                         where t.Name_Part_World.Contains(txb_Show_Countries.Text)
                         orderby t.Name_Country
                         select t;

            dvgCountries.DataSource = themes;
            txb_Show_Countries.Text = null;
        }

        private void Btn_id_Click(object sender, EventArgs e)
        {
            if (dvgCountries.Columns[0].Visible == true)
            {
                dvgCountries.Columns[0].Visible = false;
            }
            else
            {
                dvgCountries.Columns[0].Visible = true;
            }
        }

        private void Btn_Name_cou_Click(object sender, EventArgs e)
        {
            if (dvgCountries.Columns[1].Visible == true)
            {
                dvgCountries.Columns[1].Visible = false;
            }
            else
            {
                dvgCountries.Columns[1].Visible = true;
            }
        }

        private void Btn_Cap_Click(object sender, EventArgs e)
        {
            if (dvgCountries.Columns[2].Visible == true)
            {
                dvgCountries.Columns[2].Visible = false;
            }
            else
            {
                dvgCountries.Columns[2].Visible = true;
            }
        }

        private void Btn_Quantity_Click(object sender, EventArgs e)
        {
            if (dvgCountries.Columns[3].Visible == true)
            {
                dvgCountries.Columns[3].Visible = false;
            }
            else
            {
                dvgCountries.Columns[3].Visible = true;
            }
        }

        private void Btn_area_Click(object sender, EventArgs e)
        {
            if (dvgCountries.Columns[4].Visible == true)
            {
                dvgCountries.Columns[4].Visible = false;
            }
            else
            {
                dvgCountries.Columns[4].Visible = true;
            }
        }

        private void Btn_part_Click(object sender, EventArgs e)
        {
            if (dvgCountries.Columns[5].Visible == true)
            {
                dvgCountries.Columns[5].Visible = false;
            }
            else
            {
                dvgCountries.Columns[5].Visible = true;
            }
        }

        private void Btn_letter_Show_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Letter.Text))
            {
                return;
            }
            var themes = dataContext.GetTable<Country>().Where(t => t.Name_Country.StartsWith(txb_Letter.Text));         
            dvgCountries.DataSource = themes;
            txb_Letter.Text = null;
        }

        private void Btn_Lettet_Cap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Letter_Cap.Text))
            {
                return;
            }
            var themes = dataContext.GetTable<Country>().Where(t => t.Name_Capital.StartsWith(txb_Letter_Cap.Text));
            dvgCountries.DataSource = themes;
            txb_Letter_Cap.Text = null;
        }

        private void Btn_Min_Pop_Click(object sender, EventArgs e)
        {
            var themes = from t in dataContext.GetTable<Country>()
                         orderby t.Quantity_People descending
                         select t;

            var theme = themes.Take(3);
            

            dvgCountries.DataSource = theme;
        }

        private void Btn_Avg_Click(object sender, EventArgs e)
        {
         
        }

        private void Btn_In_all_Countries_Click(object sender, EventArgs e)
        {
            var themes = from t in dataContext.GetTable<Country>()
                         orderby t.Quantity_People descending
                         select t;



            dvgCountries.DataSource = themes;
        }

        private void Btn_top3_max_Click(object sender, EventArgs e)
        {
            var themes = from t in dataContext.GetTable<Country>()
                         orderby t.Quantity_People 
                         select t;

            var theme = themes.Take(3);


            dvgCountries.DataSource = theme;
        }

        private void Btn_Task4_4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Task4_4.Text))
            {
                return;
            }
            /*var themes = dataContext.GetTable<Country>().Where(t => t.Name_Part_World.Contains(txb_Show_Countries.Text)); */        //Contains(txbSearch.Text));
            var themes = from t in dataContext.GetTable<Country>()
                         where t.Name_Part_World.Contains(txb_Task4_4.Text)
                         orderby t.Quantity_People
                         select t;

            dvgCountries.DataSource = themes;
            txb_Task4_4.Text = null;
        }

        private void Btn_AVG_4_Click(object sender, EventArgs e)
        {


            var themes = from t in dataContext.GetTable<Country>()

                         select t;


        }

        private void MAX_BTN_Click(object sender, EventArgs e)
        {
            var themes = from t in dataContext.GetTable<Country>()
                         orderby t.Quantity_People descending
                         select t;

            var theme = themes.Take(3);


            dvgCountries.DataSource = theme;
        }

        private void MIN_BTN_Click(object sender, EventArgs e)
        {
            var themes = from t in dataContext.GetTable<Country>()
                         orderby t.Quantity_People
                         select t;

            var theme = themes.Take(3);


            dvgCountries.DataSource = theme;
        }
    }
}
