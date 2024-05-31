using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetModelFirst
{
    public partial class MainForm : Form
    {
        private StudentsDbContainer studentsDb;
        public MainForm()
        {
            InitializeComponent();

            dgvGroups.MultiSelect = false;
            dgvGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGroups.ReadOnly = true;
            dgvGroups.AutoGenerateColumns = false;

            dgvStudents.MultiSelect = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.ReadOnly = true;
            dgvStudents.AutoGenerateColumns = false;

            studentsDb = new StudentsDbContainer();
            UpdateGroups();
            UpdateStudents();
        }
        private void UpdateGroups(bool save=false)
        {
            if (save)
                studentsDb.SaveChanges();

            dgvGroups.DataSource = studentsDb.Groups.ToList();

            cbGroupId.DataSource = studentsDb.Groups.ToList();
            cbGroupId.DisplayMember = "Name";
            cbGroupId.ValueMember = "Id";

            var groups = studentsDb.Groups.ToList();

            colStudentGroup.DataSource = groups;
            colStudentGroup.DataPropertyName = "GroupId";
            colStudentGroup.DisplayMember = "Name";
            colStudentGroup.ValueMember = "Id";
        }
        private void UpdateStudents(bool save = false)
        {
            if (save)
                studentsDb.SaveChanges();

            dgvStudents.DataSource = studentsDb.Students.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Group group = new Group()
            {
                Name = edGroupName.Text,
                Teacher = edGroupTeacher.Text,
                Course = (int)edGroupCourse.Value
            };
            studentsDb.Groups.Add(group);

            UpdateGroups(true);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Group group = cbGroupId.SelectedItem as Group;

            if (group == null)
                return;

            Student student = new Student()
            {
                FirstName = edFirstName.Text,
                LastName = edLastName.Text,
                Group = group
            };

            studentsDb.Students.Add(student);

            UpdateStudents(true);
        }

        private void btnFindByGroupName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edFindByGroup.Text))
                return;
        }
    }
}
