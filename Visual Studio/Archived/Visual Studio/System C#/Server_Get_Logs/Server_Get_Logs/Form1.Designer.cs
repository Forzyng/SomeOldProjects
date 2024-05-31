
namespace Server_Get_Logs
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
            this.components = new System.ComponentModel.Container();
            this.dlgOpen = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.Lb_All = new System.Windows.Forms.ListBox();
            this.Btn_start = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.b_asc_dsc = new System.Windows.Forms.ComboBox();
            this.b_category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nud_Every_sec = new System.Windows.Forms.NumericUpDown();
            this.refr_every_sec = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.txb_path = new System.Windows.Forms.TextBox();
            this.Btn_Download = new System.Windows.Forms.Button();
            this.Btn_refresh = new System.Windows.Forms.Button();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.dgv_Logs = new System.Windows.Forms.DataGridView();
            this.Timer_Refresh = new System.Windows.Forms.Timer(this.components);
            this.Timer_btn_refr = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Save_logs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_save_to_logs = new System.Windows.Forms.Button();
            this.txb_path_logs = new System.Windows.Forms.TextBox();
            this.FBD_LOGS = new System.Windows.Forms.FolderBrowserDialog();
            this.dgv_Logs_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_load_logs = new System.Windows.Forms.Button();
            this.OFD_LOGS = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Every_sec)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Logs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port:";
            // 
            // nud_port
            // 
            this.nud_port.Location = new System.Drawing.Point(87, 19);
            this.nud_port.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nud_port.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(146, 32);
            this.nud_port.TabIndex = 6;
            this.nud_port.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Lb_All
            // 
            this.Lb_All.FormattingEnabled = true;
            this.Lb_All.ItemHeight = 25;
            this.Lb_All.Location = new System.Drawing.Point(6, 142);
            this.Lb_All.Name = "Lb_All";
            this.Lb_All.Size = new System.Drawing.Size(781, 429);
            this.Lb_All.TabIndex = 7;
            // 
            // Btn_start
            // 
            this.Btn_start.Location = new System.Drawing.Point(251, 9);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.Size = new System.Drawing.Size(114, 48);
            this.Btn_start.TabIndex = 8;
            this.Btn_start.Text = "Start";
            this.Btn_start.UseVisualStyleBackColor = true;
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 619);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_load_logs);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.Btn_Save_logs);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nud_port);
            this.tabPage1.Controls.Add(this.Btn_start);
            this.tabPage1.Controls.Add(this.Lb_All);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.b_asc_dsc);
            this.tabPage2.Controls.Add(this.b_category);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.Btn_Download);
            this.tabPage2.Controls.Add(this.Btn_refresh);
            this.tabPage2.Controls.Add(this.Btn_Del);
            this.tabPage2.Controls.Add(this.dgv_Logs);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // b_asc_dsc
            // 
            this.b_asc_dsc.FormattingEnabled = true;
            this.b_asc_dsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.b_asc_dsc.Location = new System.Drawing.Point(285, 450);
            this.b_asc_dsc.Name = "b_asc_dsc";
            this.b_asc_dsc.Size = new System.Drawing.Size(200, 33);
            this.b_asc_dsc.TabIndex = 17;
            // 
            // b_category
            // 
            this.b_category.FormattingEnabled = true;
            this.b_category.Items.AddRange(new object[] {
            "Name",
            "Date"});
            this.b_category.Location = new System.Drawing.Point(140, 450);
            this.b_category.Name = "b_category";
            this.b_category.Size = new System.Drawing.Size(139, 33);
            this.b_category.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Order By";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nud_Every_sec);
            this.panel1.Controls.Add(this.refr_every_sec);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 40);
            this.panel1.TabIndex = 14;
            // 
            // nud_Every_sec
            // 
            this.nud_Every_sec.Location = new System.Drawing.Point(370, 3);
            this.nud_Every_sec.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nud_Every_sec.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_Every_sec.Name = "nud_Every_sec";
            this.nud_Every_sec.Size = new System.Drawing.Size(100, 32);
            this.nud_Every_sec.TabIndex = 4;
            this.nud_Every_sec.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_Every_sec.ValueChanged += new System.EventHandler(this.nud_Every_sec_ValueChanged);
            // 
            // refr_every_sec
            // 
            this.refr_every_sec.AutoSize = true;
            this.refr_every_sec.Location = new System.Drawing.Point(345, 11);
            this.refr_every_sec.Name = "refr_every_sec";
            this.refr_every_sec.Size = new System.Drawing.Size(15, 14);
            this.refr_every_sec.TabIndex = 3;
            this.refr_every_sec.UseVisualStyleBackColor = true;
            this.refr_every_sec.CheckedChanged += new System.EventHandler(this.refr_every_sec_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Refresh every () seconds:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.txb_path);
            this.groupBox1.Location = new System.Drawing.Point(8, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path where will be files";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(506, 19);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(118, 45);
            this.Btn_Save.TabIndex = 10;
            this.Btn_Save.Text = "Save To";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click_1);
            // 
            // txb_path
            // 
            this.txb_path.Enabled = false;
            this.txb_path.Location = new System.Drawing.Point(9, 28);
            this.txb_path.Name = "txb_path";
            this.txb_path.Size = new System.Drawing.Size(479, 32);
            this.txb_path.TabIndex = 11;
            // 
            // Btn_Download
            // 
            this.Btn_Download.Location = new System.Drawing.Point(644, 525);
            this.Btn_Download.Name = "Btn_Download";
            this.Btn_Download.Size = new System.Drawing.Size(124, 46);
            this.Btn_Download.TabIndex = 5;
            this.Btn_Download.Text = "Download";
            this.Btn_Download.UseVisualStyleBackColor = true;
            this.Btn_Download.Click += new System.EventHandler(this.Btn_Download_Click);
            // 
            // Btn_refresh
            // 
            this.Btn_refresh.Location = new System.Drawing.Point(644, 453);
            this.Btn_refresh.Name = "Btn_refresh";
            this.Btn_refresh.Size = new System.Drawing.Size(124, 46);
            this.Btn_refresh.TabIndex = 2;
            this.Btn_refresh.Text = "Refresh";
            this.Btn_refresh.UseVisualStyleBackColor = true;
            this.Btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.Location = new System.Drawing.Point(514, 453);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(124, 46);
            this.Btn_Del.TabIndex = 1;
            this.Btn_Del.Text = "Delete";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // dgv_Logs
            // 
            this.dgv_Logs.AllowUserToAddRows = false;
            this.dgv_Logs.AllowUserToDeleteRows = false;
            this.dgv_Logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Logs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Logs_Id,
            this.dgv_FileName,
            this.dgv_time});
            this.dgv_Logs.Location = new System.Drawing.Point(3, 3);
            this.dgv_Logs.Name = "dgv_Logs";
            this.dgv_Logs.ReadOnly = true;
            this.dgv_Logs.Size = new System.Drawing.Size(784, 337);
            this.dgv_Logs.TabIndex = 0;
            this.dgv_Logs.SelectionChanged += new System.EventHandler(this.dgv_Logs_SelectionChanged);
            // 
            // Timer_Refresh
            // 
            this.Timer_Refresh.Interval = 1000;
            this.Timer_Refresh.Tick += new System.EventHandler(this.Timer_Refresh_Tick);
            // 
            // Timer_btn_refr
            // 
            this.Timer_btn_refr.Interval = 1000;
            this.Timer_btn_refr.Tick += new System.EventHandler(this.Timer_btn_refr_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Functions:";
            // 
            // Btn_Save_logs
            // 
            this.Btn_Save_logs.Location = new System.Drawing.Point(662, 9);
            this.Btn_Save_logs.Name = "Btn_Save_logs";
            this.Btn_Save_logs.Size = new System.Drawing.Size(114, 48);
            this.Btn_Save_logs.TabIndex = 9;
            this.Btn_Save_logs.Text = "Save";
            this.Btn_Save_logs.UseVisualStyleBackColor = true;
            this.Btn_Save_logs.Click += new System.EventHandler(this.Btn_Save_logs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_save_to_logs);
            this.groupBox2.Controls.Add(this.txb_path_logs);
            this.groupBox2.Location = new System.Drawing.Point(11, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 70);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path where will be logs";
            // 
            // btn_save_to_logs
            // 
            this.btn_save_to_logs.Location = new System.Drawing.Point(506, 19);
            this.btn_save_to_logs.Name = "btn_save_to_logs";
            this.btn_save_to_logs.Size = new System.Drawing.Size(118, 45);
            this.btn_save_to_logs.TabIndex = 10;
            this.btn_save_to_logs.Text = "Save To";
            this.btn_save_to_logs.UseVisualStyleBackColor = true;
            this.btn_save_to_logs.Click += new System.EventHandler(this.btn_save_to_logs_Click);
            // 
            // txb_path_logs
            // 
            this.txb_path_logs.Enabled = false;
            this.txb_path_logs.Location = new System.Drawing.Point(9, 28);
            this.txb_path_logs.Name = "txb_path_logs";
            this.txb_path_logs.Size = new System.Drawing.Size(479, 32);
            this.txb_path_logs.TabIndex = 11;
            // 
            // dgv_Logs_Id
            // 
            this.dgv_Logs_Id.DataPropertyName = "Id";
            this.dgv_Logs_Id.HeaderText = "Id";
            this.dgv_Logs_Id.Name = "dgv_Logs_Id";
            this.dgv_Logs_Id.ReadOnly = true;
            this.dgv_Logs_Id.Visible = false;
            // 
            // dgv_FileName
            // 
            this.dgv_FileName.DataPropertyName = "FileName";
            this.dgv_FileName.HeaderText = "Name";
            this.dgv_FileName.Name = "dgv_FileName";
            this.dgv_FileName.ReadOnly = true;
            this.dgv_FileName.Width = 500;
            // 
            // dgv_time
            // 
            this.dgv_time.DataPropertyName = "Time";
            this.dgv_time.HeaderText = "Time";
            this.dgv_time.Name = "dgv_time";
            this.dgv_time.ReadOnly = true;
            this.dgv_time.Width = 240;
            // 
            // Btn_load_logs
            // 
            this.Btn_load_logs.Location = new System.Drawing.Point(662, 80);
            this.Btn_load_logs.Name = "Btn_load_logs";
            this.Btn_load_logs.Size = new System.Drawing.Size(114, 48);
            this.Btn_load_logs.TabIndex = 15;
            this.Btn_load_logs.Text = "Load";
            this.Btn_load_logs.UseVisualStyleBackColor = true;
            this.Btn_load_logs.Click += new System.EventHandler(this.Btn_load_logs_Click);
            // 
            // OFD_LOGS
            // 
            this.OFD_LOGS.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 635);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Main ";
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Every_sec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Logs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog dlgOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.ListBox Lb_All;
        private System.Windows.Forms.Button Btn_start;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox txb_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Download;
        private System.Windows.Forms.NumericUpDown nud_Every_sec;
        private System.Windows.Forms.CheckBox refr_every_sec;
        private System.Windows.Forms.Button Btn_refresh;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.DataGridView dgv_Logs;
        private System.Windows.Forms.Timer Timer_Refresh;
        private System.Windows.Forms.ComboBox b_asc_dsc;
        private System.Windows.Forms.ComboBox b_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Timer_btn_refr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_save_to_logs;
        private System.Windows.Forms.TextBox txb_path_logs;
        private System.Windows.Forms.Button Btn_Save_logs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog FBD_LOGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Logs_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_time;
        private System.Windows.Forms.Button Btn_load_logs;
        private System.Windows.Forms.OpenFileDialog OFD_LOGS;
    }
}

