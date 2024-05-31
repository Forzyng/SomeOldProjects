
namespace Multithreading_Form
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.pb3 = new System.Windows.Forms.ProgressBar();
            this.Btn_start2 = new System.Windows.Forms.Button();
            this.Btn_Start3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(12, 36);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(109, 45);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(136, 36);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(365, 51);
            this.pb1.TabIndex = 1;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(136, 93);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(365, 51);
            this.pb2.TabIndex = 2;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(136, 150);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(365, 51);
            this.pb3.TabIndex = 3;
            // 
            // Btn_start2
            // 
            this.Btn_start2.Location = new System.Drawing.Point(13, 93);
            this.Btn_start2.Name = "Btn_start2";
            this.Btn_start2.Size = new System.Drawing.Size(108, 50);
            this.Btn_start2.TabIndex = 4;
            this.Btn_start2.Text = "Start";
            this.Btn_start2.UseVisualStyleBackColor = true;
            this.Btn_start2.Click += new System.EventHandler(this.Btn_start2_Click);
            // 
            // Btn_Start3
            // 
            this.Btn_Start3.Location = new System.Drawing.Point(12, 156);
            this.Btn_Start3.Name = "Btn_Start3";
            this.Btn_Start3.Size = new System.Drawing.Size(109, 45);
            this.Btn_Start3.TabIndex = 5;
            this.Btn_Start3.Text = "Start";
            this.Btn_Start3.UseVisualStyleBackColor = true;
            this.Btn_Start3.Click += new System.EventHandler(this.Btn_Start3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.Btn_Start3);
            this.Controls.Add(this.Btn_start2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btn_Start);
            this.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.ProgressBar pb3;
        private System.Windows.Forms.Button Btn_start2;
        private System.Windows.Forms.Button Btn_Start3;
    }
}

