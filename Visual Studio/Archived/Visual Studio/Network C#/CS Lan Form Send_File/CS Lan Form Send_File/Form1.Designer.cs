
namespace CS_Lan_Form_Send_File
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
            this.txb_file = new System.Windows.Forms.TextBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.grb_Connection = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.nud_Port = new System.Windows.Forms.NumericUpDown();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.dlg_Open = new System.Windows.Forms.OpenFileDialog();
            this.lb_Messages = new System.Windows.Forms.ListBox();
            this.grb_Connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // txb_file
            // 
            this.txb_file.Enabled = false;
            this.txb_file.Location = new System.Drawing.Point(157, 17);
            this.txb_file.Name = "txb_file";
            this.txb_file.Size = new System.Drawing.Size(466, 32);
            this.txb_file.TabIndex = 1;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(629, 18);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(128, 31);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // grb_Connection
            // 
            this.grb_Connection.Controls.Add(this.btn_Stop);
            this.grb_Connection.Controls.Add(this.btn_start);
            this.grb_Connection.Controls.Add(this.nud_Port);
            this.grb_Connection.Controls.Add(this.txb_address);
            this.grb_Connection.Controls.Add(this.label3);
            this.grb_Connection.Controls.Add(this.label2);
            this.grb_Connection.Enabled = false;
            this.grb_Connection.Location = new System.Drawing.Point(31, 71);
            this.grb_Connection.Name = "grb_Connection";
            this.grb_Connection.Size = new System.Drawing.Size(726, 150);
            this.grb_Connection.TabIndex = 3;
            this.grb_Connection.TabStop = false;
            this.grb_Connection.Text = "Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // txb_address
            // 
            this.txb_address.Location = new System.Drawing.Point(169, 39);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(329, 32);
            this.txb_address.TabIndex = 2;
            this.txb_address.Text = "127.0.0.1";
            // 
            // nud_Port
            // 
            this.nud_Port.Location = new System.Drawing.Point(169, 89);
            this.nud_Port.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.nud_Port.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Port.Name = "nud_Port";
            this.nud_Port.Size = new System.Drawing.Size(160, 32);
            this.nud_Port.TabIndex = 3;
            this.nud_Port.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(536, 39);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(115, 37);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(536, 89);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(115, 37);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // dlg_Open
            // 
            this.dlg_Open.FileName = "openFileDialog1";
            // 
            // lb_Messages
            // 
            this.lb_Messages.FormattingEnabled = true;
            this.lb_Messages.ItemHeight = 24;
            this.lb_Messages.Location = new System.Drawing.Point(31, 252);
            this.lb_Messages.Name = "lb_Messages";
            this.lb_Messages.Size = new System.Drawing.Size(726, 100);
            this.lb_Messages.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 373);
            this.Controls.Add(this.lb_Messages);
            this.Controls.Add(this.grb_Connection);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.txb_file);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Send File";
            this.grb_Connection.ResumeLayout(false);
            this.grb_Connection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_file;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.GroupBox grb_Connection;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.NumericUpDown nud_Port;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog dlg_Open;
        private System.Windows.Forms.ListBox lb_Messages;
    }
}

