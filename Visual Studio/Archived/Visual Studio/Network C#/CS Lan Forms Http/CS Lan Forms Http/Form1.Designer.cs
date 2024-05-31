
namespace CS_Lan_Forms_Http
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
            this.txb_load = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.txb_show = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // txb_load
            // 
            this.txb_load.Location = new System.Drawing.Point(165, 30);
            this.txb_load.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txb_load.Name = "txb_load";
            this.txb_load.Size = new System.Drawing.Size(723, 45);
            this.txb_load.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(918, 25);
            this.btn_load.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(155, 48);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txb_show
            // 
            this.txb_show.Enabled = false;
            this.txb_show.Font = new System.Drawing.Font("Bodoni Bk BT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_show.Location = new System.Drawing.Point(24, 439);
            this.txb_show.Multiline = true;
            this.txb_show.Name = "txb_show";
            this.txb_show.Size = new System.Drawing.Size(1072, 411);
            this.txb_show.TabIndex = 3;
            this.txb_show.TextChanged += new System.EventHandler(this.txb_show_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Headers";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Bodoni Bk BT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(24, 162);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1072, 214);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 862);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_show);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.txb_load);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bodoni Bk BT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "Http test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_load;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox txb_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

