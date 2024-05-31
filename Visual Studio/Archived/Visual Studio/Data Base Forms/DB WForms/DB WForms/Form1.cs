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

namespace DB_WForms
{
    public partial class Form1 : Form
    {
        private DataContext dataContext;
        //private Table<Themes> themes;
        public Form1()
        {
            InitializeComponent();
            dgvThemes.AutoGenerateColumns = false;
            dataContext = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\Visual Studio\Data Base Forms\DB WForms\DB WForms\Book_Magazine.mdf;Integrated Security=True");

            var themes = from t in dataContext.GetTable<Themes>()
                         orderby t.Name
                         select t;

            //themes = dataContext.GetTable<Themes>();
            dgvThemes.DataSource = themes;
            //dgvThemes.Columns[0].ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Upd_Click(object sender, EventArgs e)
        {
            dataContext.SubmitChanges();
            //System.Threading.Thread.Sleep(10);
            //dgvThemes.DataSource = null;
            //themes = dataContext.GetTable<Themes>();
            //dgvThemes.DataSource = themes;


            //var themes = from t in dataContext.GetTable<Themes>().ToList()
            //             orderby Name
            //             select t;

            var themes = dataContext.GetTable<Themes>().OrderBy(t => t.Name);
            dgvThemes.DataSource = themes;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbTheme.Text))
            {
                return;
            }

            Themes theme = new Themes()
            {
                Name = txbTheme.Text
            };

            ///themes.InsertOnSubmit(theme);
            //dataContext.SubmitChanges();
            //System.Threading.Thread.Sleep(10);
            //dgvThemes.DataSource = null;
            //themes = dataContext.GetTable<Themes>();
            //dgvThemes.DataSource = themes;
            //var themes = from t in dataContext.GetTable<Themes>().ToList()
            //             orderby t.Name
            //             select t;

            dataContext.GetTable<Themes>().InsertOnSubmit(theme);
            //dgvThemes.DataSource = themes;
            txbTheme.Text = null;
            Button_Upd_Click(null, null);
        }

        private void Button_Find_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txbSearch.Text))
            {
                return;
            }
            else
            {

                var themes = dataContext.GetTable<Themes>().Where(t => t.Name.StartsWith(txbSearch.Text));         //Contains(txbSearch.Text));
                dgvThemes.DataSource = themes;
                txbSearch.Text = null;
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbDelete.Text))
            {
                return;
            }

            var theme = dataContext.GetTable<Themes>().FirstOrDefault(t => t.Name.Contains(txbDelete.Text));
            if(theme != null)
            {
                DialogResult dialog = MessageBox.Show(this, "Delete it?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog != DialogResult.Yes)
                {
                    return;
                }

                dataContext.GetTable<Themes>().DeleteOnSubmit(theme);
                Button_Upd_Click(null, null);
            }
            txbDelete.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var names = from t in dataContext.GetTable<Themes>()
                        orderby t.Name
                        select t.Name;
            if(LbThemes.Items.Count > 0)
            {
                LbThemes.Items.Clear();
            }

            LbThemes.DataSource = names;
        }

        private void BtnShowToString_Click(object sender, EventArgs e)
        {
            var themes = dataContext.GetTable<Themes>().OrderBy(t => t.Name);
                 if (LbToString.Items.Count > 0)
            {
                LbToString.Items.Clear();
            }
            LbToString.DataSource = themes;
        }
    }
}
