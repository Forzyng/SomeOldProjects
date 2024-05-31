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
   
    public partial class Form1 : Form
    { 
        Book_MagazineEntities testDb;
        public Form1()
        {
            InitializeComponent();
            testDb = new Book_MagazineEntities();
            dgv_Countries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Countries.ReadOnly = true;
            dgv_Countries.AutoGenerateColumns = false;
            dgv_Countries.MultiSelect = false;

            dgv_Countries.DataSource = testDb.Countries.ToList();


            dgv_Authors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Authors.MultiSelect = false;
            dgv_Authors.AutoGenerateColumns = false;

            Btn_Update.Click += (s, e) =>
            {
                dgv_Countries.DataSource = testDb.Countries.ToList();
            };
            Btn_authors_Update_Click(null, null);

            dgv_AuthorsBooks.AutoGenerateColumns = false;
            dgv_AuthorsBooks.ReadOnly = true;
            list_Authors.SelectedIndexChanged += List_Authors_SelectedIndexChanged;
            dgv_Shops.AutoGenerateColumns = false;

            Btn_Shop_Update_Click(null, null);
            
        }

       
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Countries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        #region Coutries

        private void dgv_Countries_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_Countries.SelectedRows.Count == 0)
            {
                return;
            }

            Country country = dgv_Countries.SelectedRows[0].DataBoundItem as Country;

            txb_Countries_Continent.Text = country.Continents;
            txb_Countries_Name.Text = country.Name;
           
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (dgv_Countries.SelectedRows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txb_Countries_Name.Text) || string.IsNullOrWhiteSpace(txb_Countries_Continent.Text))
            {
                return;
            }

            Country country = dgv_Countries.SelectedRows[0].DataBoundItem as Country;

            country.Name = txb_Countries_Name.Text;
            country.Continents = txb_Countries_Continent.Text;

            testDb.SaveChanges();
            dgv_Countries.DataSource = testDb.Countries.ToList();


            txb_Countries_Continent.Text = null;
            txb_Countries_Name.Text = null;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
          

            if (string.IsNullOrWhiteSpace(txb_Countries_Name.Text) || string.IsNullOrWhiteSpace(txb_Countries_Continent.Text))
            {
                return;
            }

            testDb.Countries.Add(new Country()
            {
                Name = txb_Countries_Name.Text,
                Continents = txb_Countries_Continent.Text
            });
     
            testDb.SaveChanges();
            dgv_Countries.DataSource = testDb.Countries.ToList();

            txb_Countries_Continent.Text = null;
            txb_Countries_Name.Text = null;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Countries.SelectedRows.Count == 0)
            {
                return;
            }

            Country country = dgv_Countries.SelectedRows[0].DataBoundItem as Country;
            testDb.Countries.Remove(country);
            testDb.SaveChanges();

            dgv_Countries.DataSource = testDb.Countries.ToList();
        }

        #endregion

        #region Author

        private void Btn_authors_Update_Click(object sender, EventArgs e)
        {
            var country = (from c in testDb.Countries
                           orderby c.Name
                           select c).ToList();

            cmb_Country.DisplayMember = "Name";
            cmb_Country.ValueMember = "Id";
            cmb_Country.DataSource = country;

            #region 1.0


            //var authors = (from a in testDb.Authors
            //               orderby a.Name, a.Surname
            //               select new
            //               {
            //                   a.Id,
            //                   a.Name,
            //                   a.Surname,
            //                   Country = a.Country.Name
            //               }).ToList();

            //dgv_Authors.DataSource = authors;
            #endregion


            var authors = (from a in testDb.Authors
                           orderby a.Name, a.Surname
                           select a).ToList();

            dgv_Authors.DataSource = authors;

            Country_Name.DataSource = country;
            Country_Name.DisplayMember = "Name";
            Country_Name.ValueMember = "Id";


        }

        private void dgv_Authors_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_Authors.SelectedRows.Count == 0)
            {
                return;
            }
            //Author author = dgv_Authors.SelectedRows[0].DataBoundItem as Author;
            //txb_A_Name.Text = author.Name;
            Author author = dgv_Authors.SelectedRows[0].DataBoundItem as Author;

            if(author == null)
            {
                return;
            }
            //Guid id = Guid.Parse(dgv_Authors.SelectedRows[0].Cells["Author_Id"].Value.ToString());

            //Author author = testDb.Authors.FirstOrDefault(a => a.Id == id);
            //if(author == null)
            //{
            //    return;
            //}

            txb_A_Name.Text = author.Name;
            txb_A_Surname.Text = author.Surname;

            //Country co = testDb.Countries.FirstOrDefault(c => c.Id == author.CountriesID);
            //cmb_Country.SelectedItem = co;

            cmb_Country.SelectedItem = author.Country;
        }

        private void Btn_A_Add_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                Name = txb_A_Name.Text,
                Surname = txb_A_Surname.Text,
                CountriesID = Guid.Parse(cmb_Country.SelectedValue.ToString())
            };
            testDb.Authors.Add(author);
            
            testDb.SaveChanges();
            Btn_authors_Update_Click(sender, e);
        }

        private void Btn_A_Save_Click(object sender, EventArgs e)
        {
            testDb.SaveChanges();
            MessageBox.Show("Saved!");
        }



        private void Btn_A_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Authors.SelectedRows.Count == 0)
            {
                return;
            }
            Author au = dgv_Authors.SelectedRows[0].DataBoundItem as Author;
            try
            {
                
                testDb.Authors.Remove(au);
                testDb.SaveChanges();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv_Authors.DataSource = testDb.Authors.ToList();
            Btn_authors_Update_Click(sender, e);
        }

        private void Btn_A_Redact_Click(object sender, EventArgs e)
        {
            if (dgv_Authors.SelectedRows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txb_A_Name.Text) || string.IsNullOrWhiteSpace(txb_A_Surname.Text))
            {
                return;
            }

            Author au = dgv_Authors.SelectedRows[0].DataBoundItem as Author;

            au.Name = txb_A_Name.Text;
            au.Surname = txb_A_Surname.Text;
            au.CountriesID = Guid.Parse(cmb_Country.SelectedValue.ToString());

            testDb.SaveChanges();
            dgv_Authors.DataSource = testDb.Authors.ToList();

            Btn_authors_Update_Click(sender, e);
            txb_A_Name.Text = null;
            txb_A_Surname.Text = null;
        }
        #endregion

        private void Btn_Load_Books_Click(object sender, EventArgs e)
        {
            list_Authors.DisplayMember = "FullName";
            list_Authors.ValueMember = "Id";
            list_Authors.DataSource = testDb.Authors.OrderBy(a => a.Name).ToList();
        }

        private void list_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void List_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Authors.SelectedIndex == ListBox.NoMatches)
            {
                return;
            }

            Author author = list_Authors.SelectedItem as Author;

            dgv_AuthorsBooks.DataSource = author.Books.ToList();

            Book_Themes.DisplayMember = "Name";
            Book_Themes.ValueMember = "Id";
            Book_Themes.DataSource = testDb.Themes.OrderBy(t => t.Name).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Shop_Add_Click(object sender, EventArgs e)
        {
            //if(dgv_Shops.SelectedRows.Count != 1)
            //{
            //    return;
            //}


            //AddShop sh = new AddShop(testDb.Countries.ToList());
            //if(sh.ShowDialog() == DialogResult.OK)
            //{
            //    testDb.Shops.Add(AddShop.Shop);
            //    testDb.SaveChanges();
            //    Btn_Shop_Update_Click(null, null);
            //}
        }

        private void Btn_Shop_Update_Click(object sender, EventArgs e)
        {
            dgv_Shops.DataSource = testDb.Shops.OrderBy(s => s.Name).ToList();

            Shop_Country.DisplayMember = "Name";
            Shop_Country.ValueMember = "Id";
            Shop_Country.DataSource = testDb.Countries.OrderBy(c => c.Name).ToList();
        }
    }

    public partial class Author
    {
        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }
    }

}
