
namespace AdoNetModelFirst
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edGroupCourse = new System.Windows.Forms.NumericUpDown();
            this.edGroupTeacher = new System.Windows.Forms.TextBox();
            this.edGroupName = new System.Windows.Forms.TextBox();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.GroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGroupId = new System.Windows.Forms.ComboBox();
            this.edLastName = new System.Windows.Forms.TextBox();
            this.edFirstName = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentGroup = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.edFindByGroup = new System.Windows.Forms.TextBox();
            this.btnFindByGroupName = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edGroupCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 594);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.edGroupCourse);
            this.tabPage1.Controls.Add(this.edGroupTeacher);
            this.tabPage1.Controls.Add(this.edGroupName);
            this.tabPage1.Controls.Add(this.dgvGroups);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Groups";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(240, 527);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Course";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Teacher";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // edGroupCourse
            // 
            this.edGroupCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edGroupCourse.Location = new System.Drawing.Point(116, 530);
            this.edGroupCourse.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.edGroupCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edGroupCourse.Name = "edGroupCourse";
            this.edGroupCourse.Size = new System.Drawing.Size(100, 20);
            this.edGroupCourse.TabIndex = 10;
            this.edGroupCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edGroupTeacher
            // 
            this.edGroupTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edGroupTeacher.Location = new System.Drawing.Point(116, 503);
            this.edGroupTeacher.Name = "edGroupTeacher";
            this.edGroupTeacher.Size = new System.Drawing.Size(224, 20);
            this.edGroupTeacher.TabIndex = 9;
            // 
            // edGroupName
            // 
            this.edGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edGroupName.Location = new System.Drawing.Point(116, 476);
            this.edGroupName.Name = "edGroupName";
            this.edGroupName.Size = new System.Drawing.Size(224, 20);
            this.edGroupName.TabIndex = 8;
            // 
            // dgvGroups
            // 
            this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupId,
            this.colGroupName,
            this.colGroupTeacher,
            this.colGroupCourse});
            this.dgvGroups.Location = new System.Drawing.Point(3, 6);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.Size = new System.Drawing.Size(709, 464);
            this.dgvGroups.TabIndex = 1;
            // 
            // GroupId
            // 
            this.GroupId.DataPropertyName = "Id";
            this.GroupId.HeaderText = "GroupId";
            this.GroupId.Name = "GroupId";
            this.GroupId.ReadOnly = true;
            this.GroupId.Visible = false;
            // 
            // colGroupName
            // 
            this.colGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGroupName.DataPropertyName = "Name";
            this.colGroupName.HeaderText = "Name";
            this.colGroupName.Name = "colGroupName";
            // 
            // colGroupTeacher
            // 
            this.colGroupTeacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGroupTeacher.DataPropertyName = "Teacher";
            this.colGroupTeacher.HeaderText = "Teacher";
            this.colGroupTeacher.Name = "colGroupTeacher";
            // 
            // colGroupCourse
            // 
            this.colGroupCourse.DataPropertyName = "Course";
            this.colGroupCourse.HeaderText = "Course";
            this.colGroupCourse.Name = "colGroupCourse";
            this.colGroupCourse.Width = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFindByGroupName);
            this.tabPage2.Controls.Add(this.edFindByGroup);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnAddStudent);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbGroupId);
            this.tabPage2.Controls.Add(this.edLastName);
            this.tabPage2.Controls.Add(this.edFirstName);
            this.tabPage2.Controls.Add(this.dgvStudents);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Students";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(126, 532);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(95, 23);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FirstName";
            // 
            // cbGroupId
            // 
            this.cbGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupId.FormattingEnabled = true;
            this.cbGroupId.Location = new System.Drawing.Point(126, 504);
            this.cbGroupId.Name = "cbGroupId";
            this.cbGroupId.Size = new System.Drawing.Size(184, 21);
            this.cbGroupId.TabIndex = 3;
            // 
            // edLastName
            // 
            this.edLastName.Location = new System.Drawing.Point(126, 477);
            this.edLastName.Name = "edLastName";
            this.edLastName.Size = new System.Drawing.Size(184, 20);
            this.edLastName.TabIndex = 2;
            // 
            // edFirstName
            // 
            this.edFirstName.Location = new System.Drawing.Point(126, 451);
            this.edFirstName.Name = "edFirstName";
            this.edFirstName.Size = new System.Drawing.Size(184, 20);
            this.edFirstName.TabIndex = 1;
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentId,
            this.colStudentFirstName,
            this.colStudentLastName,
            this.colStudentGroup});
            this.dgvStudents.Location = new System.Drawing.Point(8, 6);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(704, 439);
            this.dgvStudents.TabIndex = 0;
            // 
            // colStudentId
            // 
            this.colStudentId.DataPropertyName = "Id";
            this.colStudentId.HeaderText = "Id";
            this.colStudentId.Name = "colStudentId";
            this.colStudentId.ReadOnly = true;
            this.colStudentId.Visible = false;
            // 
            // colStudentFirstName
            // 
            this.colStudentFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStudentFirstName.DataPropertyName = "FirstName";
            this.colStudentFirstName.HeaderText = "FirstName";
            this.colStudentFirstName.Name = "colStudentFirstName";
            // 
            // colStudentLastName
            // 
            this.colStudentLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStudentLastName.DataPropertyName = "LastName";
            this.colStudentLastName.HeaderText = "LastName";
            this.colStudentLastName.Name = "colStudentLastName";
            // 
            // colStudentGroup
            // 
            this.colStudentGroup.DataPropertyName = "GroupId";
            this.colStudentGroup.HeaderText = "Group";
            this.colStudentGroup.Name = "colStudentGroup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Find Student by Group name";
            // 
            // edFindByGroup
            // 
            this.edFindByGroup.Location = new System.Drawing.Point(554, 476);
            this.edFindByGroup.Name = "edFindByGroup";
            this.edFindByGroup.Size = new System.Drawing.Size(139, 20);
            this.edFindByGroup.TabIndex = 9;
            // 
            // btnFindByGroupName
            // 
            this.btnFindByGroupName.Location = new System.Drawing.Point(554, 502);
            this.btnFindByGroupName.Name = "btnFindByGroupName";
            this.btnFindByGroupName.Size = new System.Drawing.Size(139, 23);
            this.btnFindByGroupName.TabIndex = 10;
            this.btnFindByGroupName.Text = "Find";
            this.btnFindByGroupName.UseVisualStyleBackColor = true;
            this.btnFindByGroupName.Click += new System.EventHandler(this.btnFindByGroupName_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 594);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Ado .Net - Model First";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edGroupCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edGroupCourse;
        private System.Windows.Forms.TextBox edGroupTeacher;
        private System.Windows.Forms.TextBox edGroupName;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGroupId;
        private System.Windows.Forms.TextBox edLastName;
        private System.Windows.Forms.TextBox edFirstName;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentLastName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStudentGroup;
        private System.Windows.Forms.Button btnFindByGroupName;
        private System.Windows.Forms.TextBox edFindByGroup;
        private System.Windows.Forms.Label label7;
    }
}

