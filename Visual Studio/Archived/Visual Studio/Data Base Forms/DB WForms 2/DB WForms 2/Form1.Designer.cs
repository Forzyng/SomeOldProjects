
namespace DB_WForms_2
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
            this.dgvGadgets = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txb_Type = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Brand = new System.Windows.Forms.TextBox();
            this.nud_Memory = new System.Windows.Forms.NumericUpDown();
            this.nud_Display = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_delete = new System.Windows.Forms.Button();
            this.txb_Delete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Readact_Find = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_type_red = new System.Windows.Forms.TextBox();
            this.txb_name_red = new System.Windows.Forms.TextBox();
            this.txb_brand_red = new System.Windows.Forms.TextBox();
            this.num_memory_red = new System.Windows.Forms.NumericUpDown();
            this.num_display_red = new System.Windows.Forms.NumericUpDown();
            this.Btn_Redact = new System.Windows.Forms.Button();
            this.Btn_find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGadgets)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Memory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Display)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_memory_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_display_red)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGadgets
            // 
            this.dgvGadgets.AllowUserToAddRows = false;
            this.dgvGadgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGadgets.Location = new System.Drawing.Point(1, 0);
            this.dgvGadgets.Name = "dgvGadgets";
            this.dgvGadgets.ReadOnly = true;
            this.dgvGadgets.Size = new System.Drawing.Size(648, 227);
            this.dgvGadgets.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 233);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 158);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_Add);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nud_Display);
            this.tabPage1.Controls.Add(this.nud_Memory);
            this.tabPage1.Controls.Add(this.txb_Brand);
            this.tabPage1.Controls.Add(this.txb_Name);
            this.tabPage1.Controls.Add(this.txb_Type);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add new";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txb_Delete);
            this.tabPage2.Controls.Add(this.Btn_delete);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 132);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txb_Type
            // 
            this.txb_Type.Location = new System.Drawing.Point(121, 6);
            this.txb_Type.Name = "txb_Type";
            this.txb_Type.Size = new System.Drawing.Size(213, 20);
            this.txb_Type.TabIndex = 0;
            this.txb_Type.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(121, 32);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(213, 20);
            this.txb_Name.TabIndex = 1;
            this.txb_Name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txb_Brand
            // 
            this.txb_Brand.Location = new System.Drawing.Point(121, 58);
            this.txb_Brand.Name = "txb_Brand";
            this.txb_Brand.Size = new System.Drawing.Size(213, 20);
            this.txb_Brand.TabIndex = 2;
            this.txb_Brand.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nud_Memory
            // 
            this.nud_Memory.Location = new System.Drawing.Point(234, 84);
            this.nud_Memory.Name = "nud_Memory";
            this.nud_Memory.Size = new System.Drawing.Size(100, 20);
            this.nud_Memory.TabIndex = 3;
            this.nud_Memory.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nud_Display
            // 
            this.nud_Display.Location = new System.Drawing.Point(121, 106);
            this.nud_Display.Name = "nud_Display";
            this.nud_Display.Size = new System.Drawing.Size(100, 20);
            this.nud_Display.TabIndex = 4;
            this.nud_Display.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Brand";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Memory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Display";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Add.Location = new System.Drawing.Point(525, 77);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(107, 49);
            this.Btn_Add.TabIndex = 10;
            this.Btn_Add.Text = "ADD";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_delete
            // 
            this.Btn_delete.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_delete.Location = new System.Drawing.Point(370, 30);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(113, 66);
            this.Btn_delete.TabIndex = 0;
            this.Btn_delete.Text = "DELETE";
            this.Btn_delete.UseVisualStyleBackColor = true;
            this.Btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // txb_Delete
            // 
            this.txb_Delete.Location = new System.Drawing.Point(160, 76);
            this.txb_Delete.Name = "txb_Delete";
            this.txb_Delete.Size = new System.Drawing.Size(164, 20);
            this.txb_Delete.TabIndex = 1;
            this.txb_Delete.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Type Id:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Btn_find);
            this.tabPage3.Controls.Add(this.Btn_Redact);
            this.tabPage3.Controls.Add(this.num_display_red);
            this.tabPage3.Controls.Add(this.num_memory_red);
            this.tabPage3.Controls.Add(this.txb_brand_red);
            this.tabPage3.Controls.Add(this.txb_name_red);
            this.tabPage3.Controls.Add(this.txb_type_red);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txb_Readact_Find);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(640, 132);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Redact";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type Id:";
            // 
            // txb_Readact_Find
            // 
            this.txb_Readact_Find.Location = new System.Drawing.Point(96, 12);
            this.txb_Readact_Find.Name = "txb_Readact_Find";
            this.txb_Readact_Find.Size = new System.Drawing.Size(208, 20);
            this.txb_Readact_Find.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Type";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Name";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Brand";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Memory";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(356, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Display";
            this.label12.Visible = false;
            // 
            // txb_type_red
            // 
            this.txb_type_red.Location = new System.Drawing.Point(437, 9);
            this.txb_type_red.Name = "txb_type_red";
            this.txb_type_red.Size = new System.Drawing.Size(156, 20);
            this.txb_type_red.TabIndex = 7;
            this.txb_type_red.Visible = false;
            // 
            // txb_name_red
            // 
            this.txb_name_red.Location = new System.Drawing.Point(437, 37);
            this.txb_name_red.Name = "txb_name_red";
            this.txb_name_red.Size = new System.Drawing.Size(156, 20);
            this.txb_name_red.TabIndex = 8;
            this.txb_name_red.Visible = false;
            // 
            // txb_brand_red
            // 
            this.txb_brand_red.Location = new System.Drawing.Point(437, 64);
            this.txb_brand_red.Name = "txb_brand_red";
            this.txb_brand_red.Size = new System.Drawing.Size(156, 20);
            this.txb_brand_red.TabIndex = 9;
            this.txb_brand_red.Visible = false;
            // 
            // num_memory_red
            // 
            this.num_memory_red.Location = new System.Drawing.Point(437, 91);
            this.num_memory_red.Name = "num_memory_red";
            this.num_memory_red.Size = new System.Drawing.Size(120, 20);
            this.num_memory_red.TabIndex = 10;
            this.num_memory_red.Visible = false;
            // 
            // num_display_red
            // 
            this.num_display_red.Location = new System.Drawing.Point(437, 109);
            this.num_display_red.Name = "num_display_red";
            this.num_display_red.Size = new System.Drawing.Size(120, 20);
            this.num_display_red.TabIndex = 11;
            this.num_display_red.Visible = false;
            // 
            // Btn_Redact
            // 
            this.Btn_Redact.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Redact.Location = new System.Drawing.Point(11, 66);
            this.Btn_Redact.Name = "Btn_Redact";
            this.Btn_Redact.Size = new System.Drawing.Size(112, 62);
            this.Btn_Redact.TabIndex = 12;
            this.Btn_Redact.Text = "REDACT";
            this.Btn_Redact.UseVisualStyleBackColor = true;
            this.Btn_Redact.Visible = false;
            this.Btn_Redact.Click += new System.EventHandler(this.Btn_Redact_Click);
            // 
            // Btn_find
            // 
            this.Btn_find.Location = new System.Drawing.Point(229, 32);
            this.Btn_find.Name = "Btn_find";
            this.Btn_find.Size = new System.Drawing.Size(75, 23);
            this.Btn_find.TabIndex = 13;
            this.Btn_find.Text = "find";
            this.Btn_find.UseVisualStyleBackColor = true;
            this.Btn_find.Click += new System.EventHandler(this.Btn_find_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 393);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvGadgets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGadgets)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Memory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Display)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_memory_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_display_red)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGadgets;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nud_Display;
        private System.Windows.Forms.NumericUpDown nud_Memory;
        private System.Windows.Forms.TextBox txb_Brand;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Type;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Delete;
        private System.Windows.Forms.Button Btn_delete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Btn_Redact;
        private System.Windows.Forms.NumericUpDown num_display_red;
        private System.Windows.Forms.NumericUpDown num_memory_red;
        private System.Windows.Forms.TextBox txb_brand_red;
        private System.Windows.Forms.TextBox txb_name_red;
        private System.Windows.Forms.TextBox txb_type_red;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_Readact_Find;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_find;
    }
}

