
namespace Test_Configuration
{
    partial class Main_Form
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
            this.Label_strings = new System.Windows.Forms.Label();
            this.Button_Show_Conn = new System.Windows.Forms.Button();
            this.cbConnection = new System.Windows.Forms.ComboBox();
            this.txbConnectionString = new System.Windows.Forms.ComboBox();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SQLQuery = new System.Windows.Forms.ComboBox();
            this.Button_Exec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_red = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_strings
            // 
            this.Label_strings.AutoSize = true;
            this.Label_strings.Location = new System.Drawing.Point(12, 24);
            this.Label_strings.Name = "Label_strings";
            this.Label_strings.Size = new System.Drawing.Size(94, 13);
            this.Label_strings.TabIndex = 0;
            this.Label_strings.Text = "Connection strings";
            // 
            // Button_Show_Conn
            // 
            this.Button_Show_Conn.Location = new System.Drawing.Point(426, 19);
            this.Button_Show_Conn.Name = "Button_Show_Conn";
            this.Button_Show_Conn.Size = new System.Drawing.Size(75, 21);
            this.Button_Show_Conn.TabIndex = 1;
            this.Button_Show_Conn.Text = "Show";
            this.Button_Show_Conn.UseVisualStyleBackColor = true;
            this.Button_Show_Conn.Click += new System.EventHandler(this.Button_Show_Conn_Click);
            // 
            // cbConnection
            // 
            this.cbConnection.FormattingEnabled = true;
            this.cbConnection.Location = new System.Drawing.Point(112, 19);
            this.cbConnection.Name = "cbConnection";
            this.cbConnection.Size = new System.Drawing.Size(289, 21);
            this.cbConnection.TabIndex = 2;
            this.cbConnection.SelectedIndexChanged += new System.EventHandler(this.cbConnection_SelectedIndexChanged);
            // 
            // txbConnectionString
            // 
            this.txbConnectionString.FormattingEnabled = true;
            this.txbConnectionString.Location = new System.Drawing.Point(15, 59);
            this.txbConnectionString.Name = "txbConnectionString";
            this.txbConnectionString.Size = new System.Drawing.Size(386, 21);
            this.txbConnectionString.TabIndex = 3;
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(426, 59);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(74, 21);
            this.Button_Connect.TabIndex = 4;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SQL Query";
            // 
            // SQLQuery
            // 
            this.SQLQuery.FormattingEnabled = true;
            this.SQLQuery.Location = new System.Drawing.Point(93, 99);
            this.SQLQuery.Name = "SQLQuery";
            this.SQLQuery.Size = new System.Drawing.Size(308, 21);
            this.SQLQuery.TabIndex = 6;
            // 
            // Button_Exec
            // 
            this.Button_Exec.Enabled = false;
            this.Button_Exec.Location = new System.Drawing.Point(426, 99);
            this.Button_Exec.Name = "Button_Exec";
            this.Button_Exec.Size = new System.Drawing.Size(72, 21);
            this.Button_Exec.TabIndex = 7;
            this.Button_Exec.Text = "Execute";
            this.Button_Exec.UseVisualStyleBackColor = true;
            this.Button_Exec.Click += new System.EventHandler(this.Button_Exec_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 217);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(264, 379);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(426, 379);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 379);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 20);
            this.textBox4.TabIndex = 14;
            // 
            // btn_red
            // 
            this.btn_red.Location = new System.Drawing.Point(345, 379);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(75, 23);
            this.btn_red.TabIndex = 15;
            this.btn_red.Text = "Redact";
            this.btn_red.UseVisualStyleBackColor = true;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 492);
            this.Controls.Add(this.btn_red);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Button_Exec);
            this.Controls.Add(this.SQLQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.txbConnectionString);
            this.Controls.Add(this.cbConnection);
            this.Controls.Add(this.Button_Show_Conn);
            this.Controls.Add(this.Label_strings);
            this.Name = "Main_Form";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_strings;
        private System.Windows.Forms.Button Button_Show_Conn;
        private System.Windows.Forms.ComboBox cbConnection;
        private System.Windows.Forms.ComboBox txbConnectionString;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SQLQuery;
        private System.Windows.Forms.Button Button_Exec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_red;
    }
}

