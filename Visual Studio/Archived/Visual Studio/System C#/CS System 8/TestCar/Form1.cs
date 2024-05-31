using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_System_8;
using System.IO;

namespace TestCar
{
    public partial class Form1 : Form
    {
        private CarLibrary cars;
        private List<ConsoleColor> colors;
        public Form1()
        {
            InitializeComponent();
            colors = new List<ConsoleColor>();
            for (ConsoleColor i = ConsoleColor.Black; i < ConsoleColor.White; i++)
            {
                colors.Add(i);
            }
            cmb_Color.DataSource = colors;
            cars = new CarLibrary();
            dgv_Res_Cars.ReadOnly = true;
            dgv_Res_Cars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Res_Cars.DataSource = cars.Cars.ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Factory.Text) || (string.IsNullOrWhiteSpace(txb_model.Text)))
            {
                return;
            }
            Car car = new Car()
            {
                Factory = txb_Factory.Text,
                Model = txb_model.Text,
                Year = (short)nud_Year.Value,
                Color = (ConsoleColor)cmb_Color.SelectedValue
            };
            cars.Cars.Add(car);
            dgv_Res_Cars.DataSource = cars.Cars.ToList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {


                if (dlgSave.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dlgSave.FileName, FileMode.Create, FileAccess.Write))
                    {
                       
                        cars.SaveToStream(fs);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            try
            {


                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dlgOpen.FileName, FileMode.Open, FileAccess.Read))
                    {
                        dgv_Res_Cars.DataSource = null;
                        cars.LoadFromStream(fs, cb_Yes_No_Clear.Checked);
                        dgv_Res_Cars.DataSource = cars.Cars.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Res_Cars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_Res_Cars_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_Res_Cars.SelectedRows.Count == 0)
            {
                return;
            }
            Car car = dgv_Res_Cars.SelectedRows[0].DataBoundItem as Car;
            if (car != null)
            {
                txb_Factory.Text = car.Factory;
                txb_model.Text = car.Model;
                cmb_Color.SelectedItem = car.Color;
                nud_Year.Value = car.Year;
            }
        }
    }
}
