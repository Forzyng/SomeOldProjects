using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_WForms_3
{
    public partial class AddShop : Form
    {
        private Shop shop;
        public Shop Shop { get => shop; }
        public AddShop(ICollection<Country> countries, Shop shop = null)
        {
            InitializeComponent();
            cmb_Co.DisplayMember = "Name";
            cmb_Co.ValueMember = "Id";
            cmb_Co.DataSource = countries.OrderBy(c => c.Name).ToList();

            this.shop = shop;
            if(this.shop != null)
            {
                txb_name.Text = this.shop.Name;
                cmb_Co.SelectedItem = this.shop.Country;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.shop == null)
            {
                shop = new Shop();
            }

            shop.Name = txb_name.Text;
            shop.CountriesID = (cmb_Co.SelectedItem as Country).Id;
            
        }
    }
}
