
namespace CS_Lan_SMTP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_from = new System.Windows.Forms.TextBox();
            this.txb_to = new System.Windows.Forms.TextBox();
            this.txb_theme = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_Message = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.chb_SSL = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_server = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Theme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txb_from
            // 
            this.txb_from.Location = new System.Drawing.Point(107, 76);
            this.txb_from.Name = "txb_from";
            this.txb_from.Size = new System.Drawing.Size(228, 20);
            this.txb_from.TabIndex = 4;
            // 
            // txb_to
            // 
            this.txb_to.Location = new System.Drawing.Point(107, 102);
            this.txb_to.Name = "txb_to";
            this.txb_to.Size = new System.Drawing.Size(228, 20);
            this.txb_to.TabIndex = 5;
            // 
            // txb_theme
            // 
            this.txb_theme.Location = new System.Drawing.Point(107, 134);
            this.txb_theme.Name = "txb_theme";
            this.txb_theme.Size = new System.Drawing.Size(228, 20);
            this.txb_theme.TabIndex = 6;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(107, 160);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(228, 20);
            this.txb_password.TabIndex = 7;
            // 
            // txb_Message
            // 
            this.txb_Message.Location = new System.Drawing.Point(25, 220);
            this.txb_Message.Multiline = true;
            this.txb_Message.Name = "txb_Message";
            this.txb_Message.Size = new System.Drawing.Size(428, 146);
            this.txb_Message.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Message";
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(362, 21);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(75, 23);
            this.Btn_Send.TabIndex = 10;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // chb_SSL
            // 
            this.chb_SSL.AutoSize = true;
            this.chb_SSL.Location = new System.Drawing.Point(107, 190);
            this.chb_SSL.Name = "chb_SSL";
            this.chb_SSL.Size = new System.Drawing.Size(46, 17);
            this.chb_SSL.TabIndex = 11;
            this.chb_SSL.Text = "SSL";
            this.chb_SSL.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Port";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(107, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            587,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Server";
            // 
            // txb_server
            // 
            this.txb_server.Location = new System.Drawing.Point(107, 46);
            this.txb_server.Name = "txb_server";
            this.txb_server.Size = new System.Drawing.Size(228, 20);
            this.txb_server.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 378);
            this.Controls.Add(this.txb_server);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chb_SSL);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_Message);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_theme);
            this.Controls.Add(this.txb_to);
            this.Controls.Add(this.txb_from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_from;
        private System.Windows.Forms.TextBox txb_to;
        private System.Windows.Forms.TextBox txb_theme;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_Message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.CheckBox chb_SSL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_server;
    }
}

