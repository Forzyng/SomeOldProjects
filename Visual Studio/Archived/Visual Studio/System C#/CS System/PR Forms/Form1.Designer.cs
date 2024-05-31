
namespace PR_Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Get = new System.Windows.Forms.Button();
            this.Lb_Res = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Random Numbers:";
            // 
            // Btn_Get
            // 
            this.Btn_Get.Location = new System.Drawing.Point(359, 326);
            this.Btn_Get.Name = "Btn_Get";
            this.Btn_Get.Size = new System.Drawing.Size(154, 41);
            this.Btn_Get.TabIndex = 1;
            this.Btn_Get.Text = "Get";
            this.Btn_Get.UseVisualStyleBackColor = true;
            this.Btn_Get.Click += new System.EventHandler(this.Btn_Get_Click);
            // 
            // Lb_Res
            // 
            this.Lb_Res.FormattingEnabled = true;
            this.Lb_Res.ItemHeight = 37;
            this.Lb_Res.Location = new System.Drawing.Point(19, 12);
            this.Lb_Res.Name = "Lb_Res";
            this.Lb_Res.Size = new System.Drawing.Size(494, 263);
            this.Lb_Res.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 398);
            this.Controls.Add(this.Lb_Res);
            this.Controls.Add(this.Btn_Get);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("TypoUpright BT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Get;
        private System.Windows.Forms.ListBox Lb_Res;
    }
}

