
namespace CS_Lan_Form_Receive_File
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
            this.grb_Connection = new System.Windows.Forms.GroupBox();
            this.btn_Receive = new System.Windows.Forms.Button();
            this.nud_Port = new System.Windows.Forms.NumericUpDown();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlg_Folder = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_select = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.lb_Messages = new System.Windows.Forms.ListBox();
            this.grb_Connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Connection
            // 
            this.grb_Connection.Controls.Add(this.btn_Receive);
            this.grb_Connection.Controls.Add(this.nud_Port);
            this.grb_Connection.Controls.Add(this.txb_address);
            this.grb_Connection.Controls.Add(this.label3);
            this.grb_Connection.Controls.Add(this.label2);
            this.grb_Connection.Enabled = false;
            this.grb_Connection.Location = new System.Drawing.Point(27, 78);
            this.grb_Connection.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grb_Connection.Name = "grb_Connection";
            this.grb_Connection.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grb_Connection.Size = new System.Drawing.Size(873, 244);
            this.grb_Connection.TabIndex = 4;
            this.grb_Connection.TabStop = false;
            this.grb_Connection.Text = "Connection";
            // 
            // btn_Receive
            // 
            this.btn_Receive.Location = new System.Drawing.Point(672, 60);
            this.btn_Receive.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_Receive.Name = "btn_Receive";
            this.btn_Receive.Size = new System.Drawing.Size(145, 47);
            this.btn_Receive.TabIndex = 4;
            this.btn_Receive.Text = "Receive";
            this.btn_Receive.UseVisualStyleBackColor = true;
            this.btn_Receive.Click += new System.EventHandler(this.btn_Receive_Click);
            // 
            // nud_Port
            // 
            this.nud_Port.Location = new System.Drawing.Point(182, 151);
            this.nud_Port.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
            this.nud_Port.Size = new System.Drawing.Size(373, 32);
            this.nud_Port.TabIndex = 3;
            this.nud_Port.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txb_address
            // 
            this.txb_address.Location = new System.Drawing.Point(182, 75);
            this.txb_address.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(465, 32);
            this.txb_address.TabIndex = 2;
            this.txb_address.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folder Path";
            // 
            // txb_select
            // 
            this.txb_select.Enabled = false;
            this.txb_select.Location = new System.Drawing.Point(209, 31);
            this.txb_select.Name = "txb_select";
            this.txb_select.Size = new System.Drawing.Size(465, 32);
            this.txb_select.TabIndex = 6;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(724, 24);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(120, 45);
            this.btn_select.TabIndex = 7;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lb_Messages
            // 
            this.lb_Messages.FormattingEnabled = true;
            this.lb_Messages.ItemHeight = 24;
            this.lb_Messages.Location = new System.Drawing.Point(27, 351);
            this.lb_Messages.Name = "lb_Messages";
            this.lb_Messages.Size = new System.Drawing.Size(873, 244);
            this.lb_Messages.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 619);
            this.Controls.Add(this.lb_Messages);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.txb_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grb_Connection);
            this.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Receive File";
            this.grb_Connection.ResumeLayout(false);
            this.grb_Connection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Connection;
        private System.Windows.Forms.Button btn_Receive;
        private System.Windows.Forms.NumericUpDown nud_Port;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog dlg_Folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_select;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ListBox lb_Messages;
    }
}

