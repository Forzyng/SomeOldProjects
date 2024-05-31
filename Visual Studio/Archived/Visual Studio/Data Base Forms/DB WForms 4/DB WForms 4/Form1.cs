using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_WForms_4
{
    public partial class Form1 : Form
    {
        private Model1Container DBStudents;
        public Form1()
        {
            InitializeComponent();
            DBStudents = new Model1Container();
            dgv_First.DataSource = DBStudents.Groups.ToList();
            dgv_First.ReadOnly = true;
            dgv_First.AutoGenerateColumns = false;
            dgv_Students.AutoGenerateColumns = false;

            DBStudents = new Model1Container();
            UpdateGroups();
            UpdateStudents();
        }


        private void UpdateGroups(bool save = false)
        {
            if (save)
                DBStudents.SaveChanges();

            dgv_First.DataSource = DBStudents.Groups.ToList();

            cmb_GrId.DataSource = DBStudents.Groups.ToList();
            cmb_GrId.DisplayMember = "Name";
            cmb_GrId.ValueMember = "Id";


        }

        private void UpdateStudents(bool save = false)
        {
            if (save)
                DBStudents.SaveChanges();

            dgv_Students.DataSource = DBStudents.Students.ToList();

        }

        private void btn_Add_Groups_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_add_Name.Text) || string.IsNullOrWhiteSpace(txb_add_Teacher.Text))
            {
                return;
            }

            Group group = new Group()
            {
                //Id = Guid.NewGuid(),
                Name = txb_add_Name.Text,
                Teacher = txb_add_Teacher.Text,
                Course = (int)nud_Course.Value
            };
            DBStudents.Groups.Add(group);
            //students.SaveChanges();
            //dgv_First.DataSource = students.Groups.ToList();
            UpdateGroups(true);
        }


        private void btn_Students_Add_Click(object sender, EventArgs e)
        {
            Group gr = cmb_GrId.SelectedItem as Group;
            if (gr == null)
            {
                return;
            }
            Student stu = new Student()
            {
                First_Name = txb_Students_name.Text,
                Surname = txb_Students_Surname.Text,
                Group = gr
            };

            DBStudents.Students.Add(stu);

            UpdateStudents(true);
        }













        private void dgv_First_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
