
namespace DB_WForms_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb_GrId = new System.Windows.Forms.ComboBox();
            this.btn_Students_Add = new System.Windows.Forms.Button();
            this.txb_Students_Surname = new System.Windows.Forms.TextBox();
            this.txb_Students_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Students = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_First = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add_Groups = new System.Windows.Forms.Button();
            this.nud_Course = new System.Windows.Forms.NumericUpDown();
            this.txb_add_Name = new System.Windows.Forms.TextBox();
            this.txb_add_Teacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_First)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Course)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmb_GrId);
            this.tabPage2.Controls.Add(this.btn_Students_Add);
            this.tabPage2.Controls.Add(this.txb_Students_Surname);
            this.tabPage2.Controls.Add(this.txb_Students_name);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgv_Students);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Students";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_GrId
            // 
            this.cmb_GrId.FormattingEnabled = true;
            this.cmb_GrId.Location = new System.Drawing.Point(83, 349);
            this.cmb_GrId.Name = "cmb_GrId";
            this.cmb_GrId.Size = new System.Drawing.Size(121, 21);
            this.cmb_GrId.TabIndex = 7;
            // 
            // btn_Students_Add
            // 
            this.btn_Students_Add.Location = new System.Drawing.Point(210, 347);
            this.btn_Students_Add.Name = "btn_Students_Add";
            this.btn_Students_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Students_Add.TabIndex = 6;
            this.btn_Students_Add.Text = "Add";
            this.btn_Students_Add.UseVisualStyleBackColor = true;
            this.btn_Students_Add.Click += new System.EventHandler(this.btn_Students_Add_Click);
            // 
            // txb_Students_Surname
            // 
            this.txb_Students_Surname.Location = new System.Drawing.Point(100, 313);
            this.txb_Students_Surname.Name = "txb_Students_Surname";
            this.txb_Students_Surname.Size = new System.Drawing.Size(185, 20);
            this.txb_Students_Surname.TabIndex = 5;
            // 
            // txb_Students_name
            // 
            this.txb_Students_name.Location = new System.Drawing.Point(100, 283);
            this.txb_Students_name.Name = "txb_Students_name";
            this.txb_Students_name.Size = new System.Drawing.Size(185, 20);
            this.txb_Students_name.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Name";
            // 
            // dgv_Students
            // 
            this.dgv_Students.AllowUserToAddRows = false;
            this.dgv_Students.AllowUserToDeleteRows = false;
            this.dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StId,
            this.First_Name,
            this.StSurname,
            this.colStudentBox});
            this.dgv_Students.Location = new System.Drawing.Point(7, 7);
            this.dgv_Students.Name = "dgv_Students";
            this.dgv_Students.ReadOnly = true;
            this.dgv_Students.Size = new System.Drawing.Size(546, 253);
            this.dgv_Students.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_First);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_Add_Groups);
            this.tabPage1.Controls.Add(this.nud_Course);
            this.tabPage1.Controls.Add(this.txb_add_Name);
            this.tabPage1.Controls.Add(this.txb_add_Teacher);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Groups";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_First
            // 
            this.dgv_First.AllowUserToAddRows = false;
            this.dgv_First.AllowUserToDeleteRows = false;
            this.dgv_First.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_First.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GrName,
            this.GrTeacher,
            this.GrCourse});
            this.dgv_First.Location = new System.Drawing.Point(6, 6);
            this.dgv_First.Name = "dgv_First";
            this.dgv_First.ReadOnly = true;
            this.dgv_First.Size = new System.Drawing.Size(547, 157);
            this.dgv_First.TabIndex = 0;
            this.dgv_First.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_First_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course";
            // 
            // btn_Add_Groups
            // 
            this.btn_Add_Groups.Location = new System.Drawing.Point(194, 247);
            this.btn_Add_Groups.Name = "btn_Add_Groups";
            this.btn_Add_Groups.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_Groups.TabIndex = 7;
            this.btn_Add_Groups.Text = "Add";
            this.btn_Add_Groups.UseVisualStyleBackColor = true;
            this.btn_Add_Groups.Click += new System.EventHandler(this.btn_Add_Groups_Click);
            // 
            // nud_Course
            // 
            this.nud_Course.Location = new System.Drawing.Point(87, 247);
            this.nud_Course.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Course.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Course.Name = "nud_Course";
            this.nud_Course.Size = new System.Drawing.Size(85, 20);
            this.nud_Course.TabIndex = 3;
            this.nud_Course.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Course.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txb_add_Name
            // 
            this.txb_add_Name.Location = new System.Drawing.Point(87, 182);
            this.txb_add_Name.Name = "txb_add_Name";
            this.txb_add_Name.Size = new System.Drawing.Size(182, 20);
            this.txb_add_Name.TabIndex = 1;
            this.txb_add_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_add_Teacher
            // 
            this.txb_add_Teacher.Location = new System.Drawing.Point(87, 218);
            this.txb_add_Teacher.Name = "txb_add_Teacher";
            this.txb_add_Teacher.Size = new System.Drawing.Size(182, 20);
            this.txb_add_Teacher.TabIndex = 2;
            this.txb_add_Teacher.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Teacher";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 407);
            this.tabControl1.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // GrName
            // 
            this.GrName.DataPropertyName = "Name";
            this.GrName.FillWeight = 200F;
            this.GrName.HeaderText = "Name";
            this.GrName.Name = "GrName";
            this.GrName.ReadOnly = true;
            this.GrName.Width = 200;
            // 
            // GrTeacher
            // 
            this.GrTeacher.DataPropertyName = "Teacher";
            this.GrTeacher.HeaderText = "Teacher";
            this.GrTeacher.Name = "GrTeacher";
            this.GrTeacher.ReadOnly = true;
            this.GrTeacher.Width = 200;
            // 
            // GrCourse
            // 
            this.GrCourse.DataPropertyName = "Course";
            this.GrCourse.HeaderText = "Course";
            this.GrCourse.Name = "GrCourse";
            this.GrCourse.ReadOnly = true;
            // 
            // StId
            // 
            this.StId.DataPropertyName = "Id";
            this.StId.HeaderText = "Id";
            this.StId.Name = "StId";
            this.StId.ReadOnly = true;
            // 
            // First_Name
            // 
            this.First_Name.DataPropertyName = "First_Name";
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            // 
            // StSurname
            // 
            this.StSurname.DataPropertyName = "Surname";
            this.StSurname.HeaderText = "Surname";
            this.StSurname.Name = "StSurname";
            this.StSurname.ReadOnly = true;
            // 
            // colStudentBox
            // 
            this.colStudentBox.DataPropertyName = "GroupId";
            this.colStudentBox.HeaderText = "Group";
            this.colStudentBox.Name = "colStudentBox";
            this.colStudentBox.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Ado.Net - Model First";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_First)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Course)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txb_Students_Surname;
        private System.Windows.Forms.TextBox txb_Students_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Students;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_First;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add_Groups;
        private System.Windows.Forms.NumericUpDown nud_Course;
        private System.Windows.Forms.TextBox txb_add_Name;
        private System.Windows.Forms.TextBox txb_add_Teacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_Students_Add;
        private System.Windows.Forms.ComboBox cmb_GrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn StId;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn StSurname;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStudentBox;
    }
}

