using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDapperTest
{
    public partial class MainForm : Form
    {
        private BookSalesDb db;
        private const string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\Visual Studio\Data Base Forms\DB Wforms 5\AdoNetDapperTest\AdoNetDapperTest\BookMagazine.mdf;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();

            dgvCountries.MultiSelect = false;
            dgvCountries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCountries.ReadOnly = true;

            dgvAuthors.MultiSelect = false;
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.ReadOnly = true;

            db = new BookSalesDb(connectionStr);

            dgvCountries.DataSource = db.Countries;
            dgvAuthors.DataSource = db.Authors.Select(a=>new
            {
                a.Surname,
                a.Name,
                Countrie = a.Countrie.Name
            }).OrderBy(a => a.Surname).ThenBy(a=>a.Name).ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int ret = db.AddCountrie(new Countrie()
            {
                Name = textBox1.Text,
                Continent = textBox2.Text
            });
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dgvCountries.SelectedRows.Count == 0)
            {
                return;
            }
          //  Countrie countrie = dgvCountries.SelectedRows[0];
            //if(countrie == null)
            //{
            //    return;
            //}
            //int ret = db.DeleteCountries(countrie);

            dgvCountries.DataSource = db.Countries;
            //Countrie 
        }

        private void btn_few_cont_Click(object sender, EventArgs e)
        {
            var countries = new List<Countrie>();

            for(int i = 100; i < 110; i++)
            {
                countries.Add(new Countrie()
                {
                    Name = $"Xoo{i}",
                    Continent = "c1"
                });
            }
            //int ret = db.AddCountrie(countries);
        }
    }
}
