
namespace TestCar
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
            this.dgv_Res_Cars = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Factory = new System.Windows.Forms.TextBox();
            this.txb_model = new System.Windows.Forms.TextBox();
            this.nud_Year = new System.Windows.Forms.NumericUpDown();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.cb_Yes_No_Clear = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Res_Cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Res_Cars
            // 
            this.dgv_Res_Cars.AllowUserToAddRows = false;
            this.dgv_Res_Cars.AllowUserToDeleteRows = false;
            this.dgv_Res_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Res_Cars.Location = new System.Drawing.Point(12, 12);
            this.dgv_Res_Cars.Name = "dgv_Res_Cars";
            this.dgv_Res_Cars.ReadOnly = true;
            this.dgv_Res_Cars.Size = new System.Drawing.Size(532, 276);
            this.dgv_Res_Cars.TabIndex = 0;
            this.dgv_Res_Cars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Res_Cars_CellContentClick);
            this.dgv_Res_Cars.SelectionChanged += new System.EventHandler(this.dgv_Res_Cars_SelectionChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(405, 312);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 39);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Factory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Color";
            // 
            // txb_Factory
            // 
            this.txb_Factory.Location = new System.Drawing.Point(106, 312);
            this.txb_Factory.Name = "txb_Factory";
            this.txb_Factory.Size = new System.Drawing.Size(232, 32);
            this.txb_Factory.TabIndex = 6;
            // 
            // txb_model
            // 
            this.txb_model.Location = new System.Drawing.Point(106, 346);
            this.txb_model.Name = "txb_model";
            this.txb_model.Size = new System.Drawing.Size(232, 32);
            this.txb_model.TabIndex = 7;
            // 
            // nud_Year
            // 
            this.nud_Year.Location = new System.Drawing.Point(106, 381);
            this.nud_Year.Name = "nud_Year";
            this.nud_Year.Size = new System.Drawing.Size(232, 32);
            this.nud_Year.TabIndex = 10;
            // 
            // cmb_Color
            // 
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Location = new System.Drawing.Point(106, 415);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(232, 33);
            this.cmb_Color.TabIndex = 11;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(405, 357);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 39);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(405, 404);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(110, 39);
            this.btn_Load.TabIndex = 13;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // cb_Yes_No_Clear
            // 
            this.cb_Yes_No_Clear.Location = new System.Drawing.Point(521, 404);
            this.cb_Yes_No_Clear.Name = "cb_Yes_No_Clear";
            this.cb_Yes_No_Clear.Size = new System.Drawing.Size(50, 50);
            this.cb_Yes_No_Clear.TabIndex = 14;
            this.cb_Yes_No_Clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 452);
            this.Controls.Add(this.cb_Yes_No_Clear);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.nud_Year);
            this.Controls.Add(this.txb_model);
            this.Controls.Add(this.txb_Factory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_Res_Cars);
            this.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Res_Cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Res_Cars;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Factory;
        private System.Windows.Forms.TextBox txb_model;
        private System.Windows.Forms.NumericUpDown nud_Year;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.CheckBox cb_Yes_No_Clear;
    }
}

