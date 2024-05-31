using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EXAM
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        User user;
        Music_MagazineEntities musicDB;
        bool check;

        const string message =
        "Are you sure to delete ur acc?";
        const string caption = "Deleting";

        string UserLog;

       

        public Form1()
        {
            InitializeComponent();
            musicDB = new Music_MagazineEntities();

            dgv_Profile.AutoGenerateColumns = false;
            dgv_Records_Info.AutoGenerateColumns = false;
            dgv_Performers_Info.AutoGenerateColumns = false;
            dgv_Genres_Info.AutoGenerateColumns = false;


            ShowRecords();

            ShowPerfomance();

            ShowGenre();



            #region Admin
            var colective = (from c in musicDB.Collectives
                           orderby c.Name
                           select c).ToList();

            cmb_admin_col.DisplayMember = "Name";
            cmb_admin_col.ValueMember = "Id";
            cmb_admin_col.DataSource = colective;

           

            

            var authors = (from a in musicDB.Records
                           orderby a.Name
                           select a).ToList();

            

            var genre = (from g in musicDB.Genres
                         orderby g.Name
                         select g).ToList();

            cmb_admin_gen.DataSource = genre;
            cmb_admin_gen.DisplayMember = "Name";
            cmb_admin_gen.ValueMember = "Id";

            var publisher = (from p in musicDB.Publishers
                         orderby p.Name
                         select p).ToList();

            cmb_admin_publ.DataSource = publisher;
            cmb_admin_publ.DisplayMember = "Name";
            cmb_admin_publ.ValueMember = "Id";
            //txb_admin_Name.Text = musicDB.Records.OrderBy(t => t.Name).Take(1);

            /////////////////////////////////////////////////////////////////////////////////////////////////

            Adm_colect.DisplayMember = "Name";
            Adm_colect.ValueMember = "Id";
            Adm_colect.DataSource = musicDB.Collectives.OrderBy(t => t.Name).ToList();

            Adm_Genre.DisplayMember = "Name";
            Adm_Genre.ValueMember = "Id";
            Adm_Genre.DataSource = musicDB.Genres.OrderBy(t => t.Name).ToList();

            Adm_Publisher.DisplayMember = "Name";
            Adm_Publisher.ValueMember = "Id";
            Adm_Publisher.DataSource = musicDB.Publishers.OrderBy(t => t.Name).ToList();


            //////////////////////////////////////////////////////////////////////////////////////////////////
            dgv_admin_Rec.AutoGenerateColumns = false;
            dgv_admin_Rec.DataSource = authors;




            #endregion




            Rec_collective.DisplayMember = "Name";
            Rec_collective.ValueMember = "Id";
            Rec_collective.DataSource = musicDB.Collectives.OrderBy(t => t.Name).ToList();

            Rec_Genre.DisplayMember = "Name";
            Rec_Genre.ValueMember = "Id";
            Rec_Genre.DataSource = musicDB.Genres.OrderBy(t => t.Name).ToList();

            Rec_Publisher.DisplayMember = "Name";
            Rec_Publisher.ValueMember = "Id";
            Rec_Publisher.DataSource = musicDB.Publishers.OrderBy(t => t.Name).ToList();

            dgv_recomendation.AutoGenerateColumns = false;
            dgv_recomendation.DataSource = musicDB.Records.Distinct().OrderBy(s => Guid.NewGuid()).Take(3).ToList();



            //////////////////////////////////////////////////////////////////////////////////////////////////
            Cont_Coll.DisplayMember = "Name";
            Cont_Coll.ValueMember = "Id";
            Cont_Coll.DataSource = musicDB.Collectives.OrderBy(t => t.Name).ToList();

            Cont_Genre.DisplayMember = "Name";
            Cont_Genre.ValueMember = "Id";
            Cont_Genre.DataSource = musicDB.Genres.OrderBy(t => t.Name).ToList();

            Cont_Publish.DisplayMember = "Name";
            Cont_Publish.ValueMember = "Id";
            Cont_Publish.DataSource = musicDB.Publishers.OrderBy(t => t.Name).ToList();

            dgv_content.AutoGenerateColumns = false;
          



            check = true;
            Form2 form2 = new Form2();

            while (check)
            {
                try
                {


                    form2.ShowDialog();
                }
                catch
                {

                }
                

                if (form2.ShowSuccess == true)
                {
                    var user_find = musicDB.Users.Where(t => t.Login.Equals(form2.GetUserLogin) && t.Password.Equals(form2.GetUserPassword)).FirstOrDefault();
                    if (user_find != null)
                    {
                        dgv_Profile.DataSource = musicDB.Users.Where(t => t.Login.Equals(form2.GetUserLogin) && t.Password.Equals(form2.GetUserPassword)).ToList();
                        UserLog = form2.GetUserLogin;
                        check = false;
                        return;
                    }

                }
                else
                {
                    if (form2.ShowSuccessReg == true)
                    {


                        var user_find = musicDB.Users.Where(t => t.Login.Equals(form2.GetUserLoginReg)).FirstOrDefault();
                        if (user_find != null)
                        {
                            MessageBox.Show("Already exist with this Login");

                        }
                        else
                        {
                            user = new User()
                            {
                                Id = Guid.NewGuid(),
                                Name = form2.GetUserNameReg,
                                Surname = form2.GetUserSurnameReg,
                                Login = form2.GetUserLoginReg,
                                Password = form2.GetUserPasswordReg,
                                Discount = 5
                            };
                            musicDB.Users.Add(user);
                            UserLog = form2.GetUserLoginReg;
                            musicDB.SaveChanges();
                            check = false;
                            return;
                        }


                    }


                }
            }
        }


        public void ShowRecords()
        {
            list_Records.DisplayMember = "Name";
            list_Records.ValueMember = "Id";
            list_Records.DataSource = musicDB.Records.OrderBy(a => a.Name).ToList();
        }

        public void ShowPerfomance()
        {
            list_Performers.DisplayMember = "Name";
            list_Performers.ValueMember = "Id";
            list_Performers.DataSource = musicDB.Collectives.OrderBy(a => a.Name).ToList();
        }

        public void ShowGenre()
        {
            list_Genres.DisplayMember = "Name";
            list_Genres.ValueMember = "Id";
            list_Genres.DataSource = musicDB.Genres.OrderBy(a => a.Name).ToList();
        }




        private void list_Records_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Records.SelectedIndex == ListBox.NoMatches)
            {
                return;
            }

            Record rec = list_Records.SelectedItem as Record;

            dgv_Records_Info.DataSource = musicDB.Records.Where(t => t.Name.Equals(rec.Name)).ToList(); ;

            Record_Collective.DisplayMember = "Name";
            Record_Collective.ValueMember = "Id";
            Record_Collective.DataSource = musicDB.Collectives.OrderBy(t => t.Name).ToList();

            Record_Genre.DisplayMember = "Name";
            Record_Genre.ValueMember = "Id";
            Record_Genre.DataSource = musicDB.Genres.OrderBy(t => t.Name).ToList();

            Record_Publisher.DisplayMember = "Name";
            Record_Publisher.ValueMember = "Id";
            Record_Publisher.DataSource = musicDB.Publishers.OrderBy(t => t.Name).ToList();
        }

        #region Profile
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_Profile.SelectedRows.Count == 0)
            {
                return;
            }
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
              
                User au = dgv_Profile.SelectedRows[0].DataBoundItem as User;
                try
                {

                    musicDB.Users.Remove(au);
                    musicDB.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Application.Exit();
            }

           
        }

        private void btn_Roger_name_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txb_change_Name.Text) || txb_change_Name.Text.Length < 3)
            {
                MessageBox.Show("Uncorrect info");
                return;
            }
            else
            {
                if (dgv_Profile.SelectedRows.Count == 0)
                {
                    return;
                }
                User au = dgv_Profile.SelectedRows[0].DataBoundItem as User;

                au.Name = txb_change_Name.Text;
                
                musicDB.SaveChanges();
                dgv_Profile.DataSource = musicDB.Users.Where(t => t.Login.Equals(au.Login)).ToList();
                txb_change_Name.Text = null;
                MessageBox.Show("Success");
            }
        }

        private void btn_Roger_Surname_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Change_surname.Text) || txb_Change_surname.Text.Length < 3)
            {
                MessageBox.Show("Uncorrect info");
                return;
            }
            else
            {
                if (dgv_Profile.SelectedRows.Count == 0)
                {
                    return;
                }
                User au = dgv_Profile.SelectedRows[0].DataBoundItem as User;

                au.Surname = txb_Change_surname.Text;

                musicDB.SaveChanges();
                dgv_Profile.DataSource = musicDB.Users.Where(t => t.Login.Equals(au.Login)).ToList();
                txb_Change_surname.Text = null;
                MessageBox.Show("Success");
            }
        }

        private void btn_Roger_Password_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_change_Password.Text) || txb_change_Password.Text.Length < 6)
            {
                MessageBox.Show("Uncorrect info");
                return;
            }
            else
            {
                if (dgv_Profile.SelectedRows.Count == 0)
                {
                    return;
                }
                User au = dgv_Profile.SelectedRows[0].DataBoundItem as User;

                au.Password = txb_change_Password.Text;

                musicDB.SaveChanges();
                dgv_Profile.DataSource = musicDB.Users.Where(t => t.Login.Equals(au.Login)).ToList();
                txb_change_Password.Text = null;
                MessageBox.Show("Success");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgv_Profile.SelectedRows.Count == 0)
            {
                return;
            }
            User au = dgv_Profile.SelectedRows[0].DataBoundItem as User;

            au.Balance += 100;

            musicDB.SaveChanges();
            dgv_Profile.DataSource = musicDB.Users.Where(t => t.Login.Equals(au.Login)).ToList();
        }
        #endregion



        private void list_Performers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Performers.SelectedIndex == ListBox.NoMatches)
            {
                return;
            }

            Collective col = list_Performers.SelectedItem as Collective;

            dgv_Performers_Info.DataSource = musicDB.Records.Where(t => t.CollectiveID.Equals(col.Id)).ToList(); ;



            Performer_Genre.DisplayMember = "Name";
            Performer_Genre.ValueMember = "Id";
            Performer_Genre.DataSource = musicDB.Genres.OrderBy(t => t.Name).ToList();

            Performer_Publishment.DisplayMember = "Name";
            Performer_Publishment.ValueMember = "Id";
            Performer_Publishment.DataSource = musicDB.Publishers.OrderBy(t => t.Name).ToList();
        }

        private void list_Genres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Genres.SelectedIndex == ListBox.NoMatches)
            {
                return;
            }

            Genre gen = list_Genres.SelectedItem as Genre;

            dgv_Genres_Info.DataSource = musicDB.Records.Where(t => t.GenreID.Equals(gen.Id)).ToList(); 


            Genre_Collective.DisplayMember = "Name";
            Genre_Collective.ValueMember = "Id";
            Genre_Collective.DataSource = musicDB.Collectives.OrderBy(t => t.Name).ToList();


            Genre_Publishment.DisplayMember = "Name";
            Genre_Publishment.ValueMember = "Id";
            Genre_Publishment.DataSource = musicDB.Publishers.OrderBy(t => t.Name).ToList();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.Equals("A-z"))
            {
                list_Records.DataSource = musicDB.Records.OrderBy(t => t.Name).ToList();
            }
            if (comboBox1.SelectedItem.Equals("Z-a"))
            {
                list_Records.DataSource = musicDB.Records.OrderByDescending(t => t.Name).ToList();
            }
            if (comboBox1.SelectedItem.Equals("Date O"))
            {
                list_Records.DataSource = musicDB.Records.OrderBy(t => t.PublishDate).ToList();
            }
            if (comboBox1.SelectedItem.Equals("Date N"))
            {
                list_Records.DataSource = musicDB.Records.OrderByDescending(t => t.PublishDate).ToList();
            }
            if (comboBox1.SelectedItem.Equals("Tracks +"))
            {
                list_Records.DataSource = musicDB.Records.OrderByDescending(t => t.Number_of_tracks).ToList();
            }
            if (comboBox1.SelectedItem.Equals("Tracks -"))
            {
                list_Records.DataSource = musicDB.Records.OrderBy(t => t.Number_of_tracks).ToList();
            }



        }

        private void btn_rec_find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_rec_find.Text))
            {
                return;
            }
            if (txb_rec_find.Text.Equals("*"))
            {
                list_Records.DataSource = musicDB.Records.OrderBy(t => t.Name).ToList();
            }
            else
            {
                list_Records.DataSource = musicDB.Records.Where(t => t.Name.Contains(txb_rec_find.Text)).OrderBy(t => t.Name).ToList();
            }

        }

        private void btn_perf_find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_perf_find.Text))
            {
                return;
            }
            if (txb_perf_find.Text.Equals("*"))
            {
                list_Performers.DataSource = musicDB.Collectives.OrderBy(t => t.Name).ToList();
            }
            else
            {
                list_Performers.DataSource = musicDB.Collectives.Where(t => t.Name.Contains(txb_perf_find.Text)).OrderBy(t => t.Name).ToList();
            }
            
        }

        private void btn_gen_find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_gen_find.Text))
            {
                return;
            }
            if(txb_gen_find.Text.Equals("*"))
            {
                list_Genres.DataSource = musicDB.Genres.OrderBy(t => t.Name).ToList();
            }
            else
            {
                list_Genres.DataSource = musicDB.Genres.Where(t => t.Name.Contains(txb_gen_find.Text)).OrderBy(t => t.Name).ToList();
            }
            
        }
        




        private void btn_add_admin_Click(object sender, EventArgs e)
        {
            var took = from t in musicDB.Users
                       where t.Login.Equals(UserLog)
                       select t.Admin;
           
            if(string.IsNullOrWhiteSpace(txb_admin_Name.Text) )
            {
                return;
            }

            Record author = new Record()
            {
                Id = Guid.NewGuid(),
                Name = txb_admin_Name.Text,
                Number_of_tracks = (int)nud_admin_tr.Value,
                Price = (int)nud_admin_price.Value,
                PriceForSale = (int)nud_admin_price.Value + 400,
                CollectiveID = Guid.Parse(cmb_admin_col.SelectedValue.ToString()),
                PublisherID = Guid.Parse(cmb_admin_publ.SelectedValue.ToString()),
                GenreID = Guid.Parse(cmb_admin_gen.SelectedValue.ToString())
            };
            musicDB.Records.Add(author);

            musicDB.SaveChanges();
            dgv_admin_Rec.DataSource = musicDB.Records.OrderBy(t=>t.Name).ToList();

        }

        private void btn_admin_redact_Click(object sender, EventArgs e)
        {
            if (dgv_admin_Rec.SelectedRows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txb_admin_Name.Text) )
            {
                return;
            }

            Record au = dgv_admin_Rec.SelectedRows[0].DataBoundItem as Record;

            au.Name = txb_admin_Name.Text;
            au.PublisherID = Guid.Parse(cmb_admin_publ.SelectedValue.ToString());
            au.GenreID  = Guid.Parse(cmb_admin_gen.SelectedValue.ToString());
            au.Number_of_tracks = (int)nud_admin_tr.Value;
            au.CollectiveID = Guid.Parse(cmb_admin_col.SelectedValue.ToString());
            au.Price = (int)nud_admin_price.Value;
            au.PriceForSale = (int)nud_admin_price.Value + 400;


            musicDB.SaveChanges();
            dgv_admin_Rec.DataSource = musicDB.Records.OrderBy(t => t.Name).ToList(); 

            
           
        }

        private void btn_delete_admin_Click(object sender, EventArgs e)
        {
            if (dgv_admin_Rec.SelectedRows.Count == 0)
            {
                return;
            }
            Record au = dgv_admin_Rec.SelectedRows[0].DataBoundItem as Record;
            try
            {

                musicDB.Records.Remove(au);
                musicDB.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv_admin_Rec.DataSource = musicDB.Records.ToList();

            musicDB.SaveChanges();
            dgv_admin_Rec.DataSource = musicDB.Records.ToList();
        }

        private void dgv_admin_Rec_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_admin_Rec.SelectedRows.Count == 0)
            {
                return;
            }

            Record author = dgv_admin_Rec.SelectedRows[0].DataBoundItem as Record;

            if (author == null)
            {
                return;
            }

            txb_admin_Name.Text = author.Name;
            cmb_admin_col.SelectedItem = author.Collective;
            cmb_admin_publ.SelectedItem = author.Publisher;
            cmb_admin_gen.SelectedItem = author.Genre;
            nud_admin_price.Value = (int)author.Price;
            nud_admin_tr.Value = (int)author.Number_of_tracks;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            dgv_content.DataSource = (musicDB.Records.OrderByDescending(t => t.PublishDate)).Take(10).ToList();
        }

        private void btn_DISCOUNT_Click(object sender, EventArgs e)
        {
            //   var qwert = musicDB.Genres.Distinct().OrderBy(s => Guid.NewGuid()).Take(1).ToList();
            var GenreCheck = ((from g in musicDB.Genres.ToList()
                              orderby Guid.NewGuid()
                              select
                                  g.Id).Take(1)).ToString(); 
       

            dgv_content.DataSource = musicDB.Records.Where(t => t.GenreID.ToString().Equals(GenreCheck)).ToList();


            //dgv_recomendation.DataSource = musicDB.Records.Distinct().     //OrderBy(s => s.GenreID. Guid.NewGuid()).Take(3).ToList();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txb_gen_find_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_recomendation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            //            По исполнителю
            //По жанру
            //По издателю
            //По пластинке
            if (comboBox1.SelectedItem.Equals("По исполнителю"))
            {
                comboBox2.DataSource = musicDB.Sales.OrderByDescending(s => s.Quantity).Take(10).ToList();
            }
            if (comboBox1.SelectedItem.Equals("По жанру"))
            {
                comboBox2.DataSource = musicDB.Sales.OrderByDescending(s => s.Quantity).Take(10).ToList();
            }
            if (comboBox1.SelectedItem.Equals("По издателю"))
            {
                comboBox2.DataSource = musicDB.Sales.OrderByDescending(s => s.Quantity).Take(10).ToList();
            }
            if (comboBox1.SelectedItem.Equals("По пластинке"))
            {
                comboBox2.DataSource = musicDB.Sales.OrderByDescending(s => s.Quantity).Take(10).ToList();
                
            }
    

        }
    }
}
