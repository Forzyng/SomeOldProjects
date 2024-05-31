
namespace DB_WForms_PR
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
            this.dvgCountries = new System.Windows.Forms.DataGridView();
            this.Tasks = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSee = new System.Windows.Forms.TextBox();
            this.Button_Show = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Show_Countries = new System.Windows.Forms.TextBox();
            this.Btn_Show_Countries = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_id = new System.Windows.Forms.Button();
            this.Btn_Name_cou = new System.Windows.Forms.Button();
            this.Btn_Cap = new System.Windows.Forms.Button();
            this.Btn_Quantity = new System.Windows.Forms.Button();
            this.Btn_area = new System.Windows.Forms.Button();
            this.Btn_part = new System.Windows.Forms.Button();
            this.txb_Letter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_letter_Show = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Letter_Cap = new System.Windows.Forms.TextBox();
            this.Btn_Lettet_Cap = new System.Windows.Forms.Button();
            this.Btn_Min_Pop = new System.Windows.Forms.Button();
            this.Btn_Avg = new System.Windows.Forms.Button();
            this.Btn_In_all_Countries = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Btn_Task4_4 = new System.Windows.Forms.Button();
            this.Btn_top3_max = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Task4_4 = new System.Windows.Forms.TextBox();
            this.Btn_AVG_4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_AVG_EXAC = new System.Windows.Forms.TextBox();
            this.MAX_BTN = new System.Windows.Forms.Button();
            this.MIN_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCountries)).BeginInit();
            this.Tasks.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgCountries
            // 
            this.dvgCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCountries.Location = new System.Drawing.Point(1, 1);
            this.dvgCountries.Name = "dvgCountries";
            this.dvgCountries.Size = new System.Drawing.Size(747, 274);
            this.dvgCountries.TabIndex = 0;
            // 
            // Tasks
            // 
            this.Tasks.Controls.Add(this.tabPage1);
            this.Tasks.Controls.Add(this.tabPage2);
            this.Tasks.Controls.Add(this.tabPage3);
            this.Tasks.Location = new System.Drawing.Point(12, 281);
            this.Tasks.Name = "Tasks";
            this.Tasks.SelectedIndex = 0;
            this.Tasks.Size = new System.Drawing.Size(725, 125);
            this.Tasks.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_top3_max);
            this.tabPage2.Controls.Add(this.Btn_In_all_Countries);
            this.tabPage2.Controls.Add(this.Btn_Avg);
            this.tabPage2.Controls.Add(this.Btn_Min_Pop);
            this.tabPage2.Controls.Add(this.Btn_Lettet_Cap);
            this.tabPage2.Controls.Add(this.txb_Letter_Cap);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Btn_letter_Show);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txb_Letter);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 99);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter what to see";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbSee
            // 
            this.txbSee.Location = new System.Drawing.Point(106, 12);
            this.txbSee.Name = "txbSee";
            this.txbSee.Size = new System.Drawing.Size(126, 20);
            this.txbSee.TabIndex = 3;
            this.txbSee.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Button_Show
            // 
            this.Button_Show.Location = new System.Drawing.Point(249, 10);
            this.Button_Show.Name = "Button_Show";
            this.Button_Show.Size = new System.Drawing.Size(75, 23);
            this.Button_Show.TabIndex = 1;
            this.Button_Show.Text = "Show";
            this.Button_Show.UseVisualStyleBackColor = true;
            this.Button_Show.Click += new System.EventHandler(this.Button_Show_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_area);
            this.tabPage1.Controls.Add(this.Btn_part);
            this.tabPage1.Controls.Add(this.Btn_Cap);
            this.tabPage1.Controls.Add(this.Btn_Quantity);
            this.tabPage1.Controls.Add(this.Btn_Name_cou);
            this.tabPage1.Controls.Add(this.Btn_id);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Btn_Show_Countries);
            this.tabPage1.Controls.Add(this.txb_Show_Countries);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Button_Show);
            this.tabPage1.Controls.Add(this.txbSee);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 99);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Part of the world";
            // 
            // txb_Show_Countries
            // 
            this.txb_Show_Countries.Location = new System.Drawing.Point(131, 53);
            this.txb_Show_Countries.Name = "txb_Show_Countries";
            this.txb_Show_Countries.Size = new System.Drawing.Size(126, 20);
            this.txb_Show_Countries.TabIndex = 5;
            // 
            // Btn_Show_Countries
            // 
            this.Btn_Show_Countries.Location = new System.Drawing.Point(273, 53);
            this.Btn_Show_Countries.Name = "Btn_Show_Countries";
            this.Btn_Show_Countries.Size = new System.Drawing.Size(97, 23);
            this.Btn_Show_Countries.TabIndex = 6;
            this.Btn_Show_Countries.Text = "Show Countries";
            this.Btn_Show_Countries.UseVisualStyleBackColor = true;
            this.Btn_Show_Countries.Click += new System.EventHandler(this.Btn_Show_Countries_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "What to not show";
            // 
            // Btn_id
            // 
            this.Btn_id.Location = new System.Drawing.Point(522, 5);
            this.Btn_id.Name = "Btn_id";
            this.Btn_id.Size = new System.Drawing.Size(75, 23);
            this.Btn_id.TabIndex = 8;
            this.Btn_id.Text = "Id";
            this.Btn_id.UseVisualStyleBackColor = true;
            this.Btn_id.Click += new System.EventHandler(this.Btn_id_Click);
            // 
            // Btn_Name_cou
            // 
            this.Btn_Name_cou.Location = new System.Drawing.Point(622, 6);
            this.Btn_Name_cou.Name = "Btn_Name_cou";
            this.Btn_Name_cou.Size = new System.Drawing.Size(75, 23);
            this.Btn_Name_cou.TabIndex = 9;
            this.Btn_Name_cou.Text = "Country";
            this.Btn_Name_cou.UseVisualStyleBackColor = true;
            this.Btn_Name_cou.Click += new System.EventHandler(this.Btn_Name_cou_Click);
            // 
            // Btn_Cap
            // 
            this.Btn_Cap.Location = new System.Drawing.Point(522, 40);
            this.Btn_Cap.Name = "Btn_Cap";
            this.Btn_Cap.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cap.TabIndex = 11;
            this.Btn_Cap.Text = "Capital";
            this.Btn_Cap.UseVisualStyleBackColor = true;
            this.Btn_Cap.Click += new System.EventHandler(this.Btn_Cap_Click);
            // 
            // Btn_Quantity
            // 
            this.Btn_Quantity.Location = new System.Drawing.Point(622, 40);
            this.Btn_Quantity.Name = "Btn_Quantity";
            this.Btn_Quantity.Size = new System.Drawing.Size(75, 23);
            this.Btn_Quantity.TabIndex = 10;
            this.Btn_Quantity.Text = "Population";
            this.Btn_Quantity.UseVisualStyleBackColor = true;
            this.Btn_Quantity.Click += new System.EventHandler(this.Btn_Quantity_Click);
            // 
            // Btn_area
            // 
            this.Btn_area.Location = new System.Drawing.Point(522, 73);
            this.Btn_area.Name = "Btn_area";
            this.Btn_area.Size = new System.Drawing.Size(75, 23);
            this.Btn_area.TabIndex = 13;
            this.Btn_area.Text = "Area";
            this.Btn_area.UseVisualStyleBackColor = true;
            this.Btn_area.Click += new System.EventHandler(this.Btn_area_Click);
            // 
            // Btn_part
            // 
            this.Btn_part.Location = new System.Drawing.Point(622, 73);
            this.Btn_part.Name = "Btn_part";
            this.Btn_part.Size = new System.Drawing.Size(75, 23);
            this.Btn_part.TabIndex = 12;
            this.Btn_part.Text = "Part";
            this.Btn_part.UseVisualStyleBackColor = true;
            this.Btn_part.Click += new System.EventHandler(this.Btn_part_Click);
            // 
            // txb_Letter
            // 
            this.txb_Letter.Location = new System.Drawing.Point(168, 9);
            this.txb_Letter.Name = "txb_Letter";
            this.txb_Letter.Size = new System.Drawing.Size(100, 20);
            this.txb_Letter.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter letter(s) (finding countries)";
            // 
            // Btn_letter_Show
            // 
            this.Btn_letter_Show.Location = new System.Drawing.Point(274, 7);
            this.Btn_letter_Show.Name = "Btn_letter_Show";
            this.Btn_letter_Show.Size = new System.Drawing.Size(75, 23);
            this.Btn_letter_Show.TabIndex = 2;
            this.Btn_letter_Show.Text = "Show";
            this.Btn_letter_Show.UseVisualStyleBackColor = true;
            this.Btn_letter_Show.Click += new System.EventHandler(this.Btn_letter_Show_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Enter letter(s) (finding capitals)";
            // 
            // txb_Letter_Cap
            // 
            this.txb_Letter_Cap.Location = new System.Drawing.Point(168, 46);
            this.txb_Letter_Cap.Name = "txb_Letter_Cap";
            this.txb_Letter_Cap.Size = new System.Drawing.Size(100, 20);
            this.txb_Letter_Cap.TabIndex = 4;
            // 
            // Btn_Lettet_Cap
            // 
            this.Btn_Lettet_Cap.Location = new System.Drawing.Point(274, 43);
            this.Btn_Lettet_Cap.Name = "Btn_Lettet_Cap";
            this.Btn_Lettet_Cap.Size = new System.Drawing.Size(75, 23);
            this.Btn_Lettet_Cap.TabIndex = 5;
            this.Btn_Lettet_Cap.Text = "Show";
            this.Btn_Lettet_Cap.UseVisualStyleBackColor = true;
            this.Btn_Lettet_Cap.Click += new System.EventHandler(this.Btn_Lettet_Cap_Click);
            // 
            // Btn_Min_Pop
            // 
            this.Btn_Min_Pop.Location = new System.Drawing.Point(580, 7);
            this.Btn_Min_Pop.Name = "Btn_Min_Pop";
            this.Btn_Min_Pop.Size = new System.Drawing.Size(115, 23);
            this.Btn_Min_Pop.TabIndex = 6;
            this.Btn_Min_Pop.Text = "TOP 3 MIN Country";
            this.Btn_Min_Pop.UseVisualStyleBackColor = true;
            this.Btn_Min_Pop.Click += new System.EventHandler(this.Btn_Min_Pop_Click);
            // 
            // Btn_Avg
            // 
            this.Btn_Avg.Location = new System.Drawing.Point(580, 36);
            this.Btn_Avg.Name = "Btn_Avg";
            this.Btn_Avg.Size = new System.Drawing.Size(115, 23);
            this.Btn_Avg.TabIndex = 7;
            this.Btn_Avg.Text = "AVG";
            this.Btn_Avg.UseVisualStyleBackColor = true;
            this.Btn_Avg.Click += new System.EventHandler(this.Btn_Avg_Click);
            // 
            // Btn_In_all_Countries
            // 
            this.Btn_In_all_Countries.Location = new System.Drawing.Point(581, 67);
            this.Btn_In_all_Countries.Name = "Btn_In_all_Countries";
            this.Btn_In_all_Countries.Size = new System.Drawing.Size(115, 23);
            this.Btn_In_all_Countries.TabIndex = 8;
            this.Btn_In_all_Countries.Text = "All";
            this.Btn_In_all_Countries.UseVisualStyleBackColor = true;
            this.Btn_In_all_Countries.Click += new System.EventHandler(this.Btn_In_all_Countries_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MIN_BTN);
            this.tabPage3.Controls.Add(this.MAX_BTN);
            this.tabPage3.Controls.Add(this.txb_AVG_EXAC);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.Btn_AVG_4);
            this.tabPage3.Controls.Add(this.txb_Task4_4);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.Btn_Task4_4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(717, 99);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Task 4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Btn_Task4_4
            // 
            this.Btn_Task4_4.Location = new System.Drawing.Point(246, 6);
            this.Btn_Task4_4.Name = "Btn_Task4_4";
            this.Btn_Task4_4.Size = new System.Drawing.Size(75, 23);
            this.Btn_Task4_4.TabIndex = 0;
            this.Btn_Task4_4.Text = "Show";
            this.Btn_Task4_4.UseVisualStyleBackColor = true;
            this.Btn_Task4_4.Click += new System.EventHandler(this.Btn_Task4_4_Click);
            // 
            // Btn_top3_max
            // 
            this.Btn_top3_max.Location = new System.Drawing.Point(438, 7);
            this.Btn_top3_max.Name = "Btn_top3_max";
            this.Btn_top3_max.Size = new System.Drawing.Size(136, 23);
            this.Btn_top3_max.TabIndex = 9;
            this.Btn_top3_max.Text = "TOP 3 MAX population";
            this.Btn_top3_max.UseVisualStyleBackColor = true;
            this.Btn_top3_max.Click += new System.EventHandler(this.Btn_top3_max_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Enter Part World";
            // 
            // txb_Task4_4
            // 
            this.txb_Task4_4.Location = new System.Drawing.Point(128, 8);
            this.txb_Task4_4.Name = "txb_Task4_4";
            this.txb_Task4_4.Size = new System.Drawing.Size(100, 20);
            this.txb_Task4_4.TabIndex = 2;
            // 
            // Btn_AVG_4
            // 
            this.Btn_AVG_4.Location = new System.Drawing.Point(246, 51);
            this.Btn_AVG_4.Name = "Btn_AVG_4";
            this.Btn_AVG_4.Size = new System.Drawing.Size(75, 23);
            this.Btn_AVG_4.TabIndex = 3;
            this.Btn_AVG_4.Text = "Show AVG";
            this.Btn_AVG_4.UseVisualStyleBackColor = true;
            this.Btn_AVG_4.Click += new System.EventHandler(this.Btn_AVG_4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Enter Part World";
            // 
            // txb_AVG_EXAC
            // 
            this.txb_AVG_EXAC.Location = new System.Drawing.Point(128, 51);
            this.txb_AVG_EXAC.Name = "txb_AVG_EXAC";
            this.txb_AVG_EXAC.Size = new System.Drawing.Size(100, 20);
            this.txb_AVG_EXAC.TabIndex = 5;
            // 
            // MAX_BTN
            // 
            this.MAX_BTN.Location = new System.Drawing.Point(536, 11);
            this.MAX_BTN.Name = "MAX_BTN";
            this.MAX_BTN.Size = new System.Drawing.Size(75, 23);
            this.MAX_BTN.TabIndex = 6;
            this.MAX_BTN.Text = "MAX";
            this.MAX_BTN.UseVisualStyleBackColor = true;
            this.MAX_BTN.Click += new System.EventHandler(this.MAX_BTN_Click);
            // 
            // MIN_BTN
            // 
            this.MIN_BTN.Location = new System.Drawing.Point(536, 51);
            this.MIN_BTN.Name = "MIN_BTN";
            this.MIN_BTN.Size = new System.Drawing.Size(75, 23);
            this.MIN_BTN.TabIndex = 7;
            this.MIN_BTN.Text = "MIN";
            this.MIN_BTN.UseVisualStyleBackColor = true;
            this.MIN_BTN.Click += new System.EventHandler(this.MIN_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.dvgCountries);
            this.Name = "Form1";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCountries)).EndInit();
            this.Tasks.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCountries;
        private System.Windows.Forms.TabControl Tasks;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Button_Show;
        private System.Windows.Forms.TextBox txbSee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Show_Countries;
        private System.Windows.Forms.TextBox txb_Show_Countries;
        private System.Windows.Forms.Button Btn_area;
        private System.Windows.Forms.Button Btn_part;
        private System.Windows.Forms.Button Btn_Cap;
        private System.Windows.Forms.Button Btn_Quantity;
        private System.Windows.Forms.Button Btn_Name_cou;
        private System.Windows.Forms.Button Btn_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_letter_Show;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Letter;
        private System.Windows.Forms.Button Btn_Lettet_Cap;
        private System.Windows.Forms.TextBox txb_Letter_Cap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Avg;
        private System.Windows.Forms.Button Btn_Min_Pop;
        private System.Windows.Forms.Button Btn_In_all_Countries;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Btn_Task4_4;
        private System.Windows.Forms.Button Btn_top3_max;
        private System.Windows.Forms.TextBox txb_Task4_4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_AVG_4;
        private System.Windows.Forms.TextBox txb_AVG_EXAC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button MIN_BTN;
        private System.Windows.Forms.Button MAX_BTN;
    }
}

