
namespace Registry_work
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
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Write = new System.Windows.Forms.Button();
            this.txb_app = new System.Windows.Forms.TextBox();
            this.Btn_remove = new System.Windows.Forms.Button();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected App:";
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(13, 210);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(112, 34);
            this.btn_Select.TabIndex = 1;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(145, 210);
            this.btn_Write.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(112, 34);
            this.btn_Write.TabIndex = 2;
            this.btn_Write.Text = "Write To";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // txb_app
            // 
            this.txb_app.Location = new System.Drawing.Point(13, 160);
            this.txb_app.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_app.Name = "txb_app";
            this.txb_app.Size = new System.Drawing.Size(376, 26);
            this.txb_app.TabIndex = 3;
            // 
            // Btn_remove
            // 
            this.Btn_remove.Location = new System.Drawing.Point(277, 210);
            this.Btn_remove.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_remove.Name = "Btn_remove";
            this.Btn_remove.Size = new System.Drawing.Size(112, 34);
            this.Btn_remove.TabIndex = 4;
            this.Btn_remove.Text = "Remove";
            this.Btn_remove.UseVisualStyleBackColor = true;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(13, 61);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(376, 26);
            this.txb_Name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 268);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_remove);
            this.Controls.Add(this.txb_app);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.TextBox txb_app;
        private System.Windows.Forms.Button Btn_remove;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label label2;
    }
}

