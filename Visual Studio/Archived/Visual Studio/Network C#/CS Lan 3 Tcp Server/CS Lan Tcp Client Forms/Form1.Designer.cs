
namespace CS_Lan_Tcp_Client_Forms
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
            this.txb_Ip = new System.Windows.Forms.TextBox();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_disc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_Messages = new System.Windows.Forms.ListBox();
            this.txb_send = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Ip
            // 
            this.txb_Ip.Location = new System.Drawing.Point(211, 61);
            this.txb_Ip.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txb_Ip.Name = "txb_Ip";
            this.txb_Ip.Size = new System.Drawing.Size(373, 39);
            this.txb_Ip.TabIndex = 0;
            // 
            // nud_port
            // 
            this.nud_port.Location = new System.Drawing.Point(211, 125);
            this.nud_port.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nud_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nud_port.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(373, 39);
            this.nud_port.TabIndex = 1;
            this.nud_port.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_port.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_Ip);
            this.groupBox1.Controls.Add(this.nud_port);
            this.groupBox1.Location = new System.Drawing.Point(30, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(620, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP address";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Bodoni Bk BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(57, 250);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(142, 46);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_disc
            // 
            this.btn_disc.Font = new System.Drawing.Font("Bodoni Bk BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disc.Location = new System.Drawing.Point(487, 250);
            this.btn_disc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_disc.Name = "btn_disc";
            this.btn_disc.Size = new System.Drawing.Size(163, 46);
            this.btn_disc.TabIndex = 4;
            this.btn_disc.Text = "Disconnect";
            this.btn_disc.UseVisualStyleBackColor = true;
            this.btn_disc.Click += new System.EventHandler(this.btn_disc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_Messages);
            this.groupBox2.Controls.Add(this.txb_send);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(30, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 284);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Messages";
            // 
            // lb_Messages
            // 
            this.lb_Messages.FormattingEnabled = true;
            this.lb_Messages.ItemHeight = 32;
            this.lb_Messages.Location = new System.Drawing.Point(12, 109);
            this.lb_Messages.Name = "lb_Messages";
            this.lb_Messages.Size = new System.Drawing.Size(602, 164);
            this.lb_Messages.TabIndex = 3;
            // 
            // txb_send
            // 
            this.txb_send.Location = new System.Drawing.Point(143, 40);
            this.txb_send.Name = "txb_send";
            this.txb_send.Size = new System.Drawing.Size(325, 39);
            this.txb_send.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Message";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 603);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_disc);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bodoni Bk BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Tcp Connection";
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Ip;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_disc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lb_Messages;
        private System.Windows.Forms.TextBox txb_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

