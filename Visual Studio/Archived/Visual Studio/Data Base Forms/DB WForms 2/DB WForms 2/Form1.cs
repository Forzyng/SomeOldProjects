using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_WForms_2
{
    public partial class Form1 : Form
    {
        Gadget test = new Gadget();
        const string SQL_Connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\Visual Studio\Data Base Forms\DB WForms 2\DB WForms 2\Book_Magazine.mdf;Integrated Security=True";
        private TestDbContext dbContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new TestDbContext(SQL_Connection);
            dgvGadgets.DataSource = dbContext.Gadgets.ToList();
        }

       
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txb_Type.Text) || string.IsNullOrWhiteSpace(txb_Name.Text) || string.IsNullOrWhiteSpace(txb_Brand.Text) 
                || nud_Display.Value == 0 || nud_Memory.Value == 0)
            {
                return;
            }
            Gadget gadget = new Gadget()
            {
                Id = Guid.NewGuid(),
                Type = txb_Type.Text,
                Name = txb_Name.Text,
                Brand = txb_Brand.Text,
                Memory = (double)nud_Memory.Value,
                Display_Size = (float)nud_Display.Value
            };
            dbContext.Gadgets.Add(gadget);
            dbContext.SaveChanges();
            dgvGadgets.DataSource = dbContext.Gadgets.ToList();
            txb_Type.Text = null;
            txb_Name.Text = null;
            txb_Brand.Text = null;
            nud_Memory.Value = 0;
            nud_Display.Value = 0;
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Delete.Text))
            {
                return;
            }

            Gadget gadget = new Gadget();
            try
            {



                foreach (var item in dbContext.Gadgets.ToList())
                {
                    if (Convert.ToString(item.Id) == txb_Delete.Text)
                    {
                        gadget = item;
                    }
                }

                dbContext.Gadgets.Remove(gadget);
                dbContext.SaveChanges();
                dgvGadgets.DataSource = dbContext.Gadgets.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void Btn_Redact_Click(object sender, EventArgs e)
        {


           
            try
            {


                //
                if (string.IsNullOrWhiteSpace(txb_type_red.Text) || string.IsNullOrWhiteSpace(txb_name_red.Text) || string.IsNullOrWhiteSpace(txb_brand_red.Text)
                    || num_display_red.Value == 0 || num_memory_red.Value == 0)
                {
                    return;
                }
                Gadget gd2 = new Gadget()
                {
                    Id = test.Id,
                    Type = txb_type_red.Text,
                    Name = txb_name_red.Text,
                    Brand = txb_brand_red.Text,
                    Memory = (double)num_memory_red.Value,
                    Display_Size = (float)num_display_red.Value
                };
                dbContext.Gadgets.Add(gd2);
                dbContext.SaveChanges();
                dgvGadgets.DataSource = dbContext.Gadgets.ToList();
             

                //


                dbContext.SaveChanges();
                dgvGadgets.DataSource = dbContext.Gadgets.ToList();
                txb_Delete.Text = null;
                txb_Type.Text = null;
                txb_Name.Text = null;
                txb_Brand.Text = null;
                nud_Memory.Value = 0;
                nud_Display.Value = 0;

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Btn_Redact.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            txb_type_red.Visible = false;
            txb_name_red.Visible = false;
            txb_brand_red.Visible = false;
            num_memory_red.Visible = false;
            num_display_red.Visible = false;

            label7.Visible = true;
            txb_Readact_Find.Visible = true;
            Btn_find.Visible = true;
        }


        private void Btn_find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Readact_Find.Text))
            {
                return;
            }

            Gadget gadget = new Gadget();
            try
            {

                foreach (var item in dbContext.Gadgets.ToList())
                {
                    if (Convert.ToString(item.Id) == txb_Readact_Find.Text)
                    {
                        gadget = item;
                    }
                }

           

                //dgvGadgets.DataSource = dbContext.Gadgets.FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }



            Btn_Redact.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;

            txb_type_red.Visible = true;
            txb_type_red.Text = gadget.Type;

            txb_name_red.Visible = true;
            txb_name_red.Text = gadget.Name;

            txb_brand_red.Visible = true;
            txb_brand_red.Text = gadget.Brand;

            num_memory_red.Visible = true;
            num_memory_red.Value = Convert.ToDecimal(gadget.Memory);

            num_display_red.Visible = true;
            num_display_red.Value = Convert.ToDecimal(gadget.Display_Size);

            txb_Readact_Find.Text = null;

            test = gadget;
            dbContext.Gadgets.Remove(gadget);



            label7.Visible = false;
            txb_Readact_Find.Visible = false;
            Btn_find.Visible = false;

        }



















        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
