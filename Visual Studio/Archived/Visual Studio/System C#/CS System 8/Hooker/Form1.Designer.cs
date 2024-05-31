
namespace Hooker
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
            this.btn_activate = new System.Windows.Forms.Button();
            this.btn_deactivate = new System.Windows.Forms.Button();
            this.lb_Info = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_activate
            // 
            this.btn_activate.Location = new System.Drawing.Point(12, 30);
            this.btn_activate.Name = "btn_activate";
            this.btn_activate.Size = new System.Drawing.Size(131, 44);
            this.btn_activate.TabIndex = 0;
            this.btn_activate.Text = "Activate";
            this.btn_activate.UseVisualStyleBackColor = true;
            this.btn_activate.Click += new System.EventHandler(this.btn_activate_Click);
            // 
            // btn_deactivate
            // 
            this.btn_deactivate.Location = new System.Drawing.Point(255, 30);
            this.btn_deactivate.Name = "btn_deactivate";
            this.btn_deactivate.Size = new System.Drawing.Size(162, 44);
            this.btn_deactivate.TabIndex = 1;
            this.btn_deactivate.Text = "Deactivate";
            this.btn_deactivate.UseVisualStyleBackColor = true;
            this.btn_deactivate.Click += new System.EventHandler(this.btn_deactivate_Click);
            // 
            // lb_Info
            // 
            this.lb_Info.FormattingEnabled = true;
            this.lb_Info.ItemHeight = 27;
            this.lb_Info.Location = new System.Drawing.Point(12, 110);
            this.lb_Info.Name = "lb_Info";
            this.lb_Info.Size = new System.Drawing.Size(405, 112);
            this.lb_Info.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 222);
            this.Controls.Add(this.lb_Info);
            this.Controls.Add(this.btn_deactivate);
            this.Controls.Add(this.btn_activate);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_activate;
        private System.Windows.Forms.Button btn_deactivate;
        private System.Windows.Forms.ListBox lb_Info;
    }
}

