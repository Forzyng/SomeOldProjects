
namespace System_Copy_Files
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
            this.Btn_Count = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Enter_Words = new System.Windows.Forms.TextBox();
            this.lb_res = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Count
            // 
            this.Btn_Count.Location = new System.Drawing.Point(609, 567);
            this.Btn_Count.Name = "Btn_Count";
            this.Btn_Count.Size = new System.Drawing.Size(146, 59);
            this.Btn_Count.TabIndex = 0;
            this.Btn_Count.Text = "Подсчёт";
            this.Btn_Count.UseVisualStyleBackColor = true;
            this.Btn_Count.Click += new System.EventHandler(this.Btn_Count_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите слово (а):";
            // 
            // txb_Enter_Words
            // 
            this.txb_Enter_Words.Location = new System.Drawing.Point(18, 102);
            this.txb_Enter_Words.Multiline = true;
            this.txb_Enter_Words.Name = "txb_Enter_Words";
            this.txb_Enter_Words.Size = new System.Drawing.Size(737, 272);
            this.txb_Enter_Words.TabIndex = 2;
            // 
            // lb_res
            // 
            this.lb_res.FormattingEnabled = true;
            this.lb_res.ItemHeight = 34;
            this.lb_res.Location = new System.Drawing.Point(18, 462);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(552, 174);
            this.lb_res.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.txb_Enter_Words);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Count);
            this.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Enter_Words;
        private System.Windows.Forms.ListBox lb_res;
        private System.Windows.Forms.Label label2;
    }
}

