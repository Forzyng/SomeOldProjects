
namespace Ne_Podozritelniy_Proverschik_Slov
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.rb_yes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.SaveEverySec_chb = new System.Windows.Forms.CheckBox();
            this.lb_info_One_Str = new System.Windows.Forms.ListBox();
            this.lb_Info_Rus = new System.Windows.Forms.ListBox();
            this.lb_Info_Eng = new System.Windows.Forms.ListBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rb_order_descending = new System.Windows.Forms.RadioButton();
            this.rb_order_ascending = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rb_order_name = new System.Windows.Forms.RadioButton();
            this.rb_order_handle = new System.Windows.Forms.RadioButton();
            this.rb_order_id = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Proc = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandleCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Kill = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_server_logs = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Disconnect = new System.Windows.Forms.Button();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_ip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_send_To_Server = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.Timer_Save = new System.Windows.Forms.Timer(this.components);
            this.Timer_send_in_minute = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proc)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1093, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lb_info_One_Str);
            this.tabPage1.Controls.Add(this.lb_Info_Rus);
            this.tabPage1.Controls.Add(this.lb_Info_Eng);
            this.tabPage1.Controls.Add(this.Btn_Clear);
            this.tabPage1.Controls.Add(this.btn_Save);
            this.tabPage1.Controls.Add(this.btn_load);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1085, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Loger";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_no);
            this.panel2.Controls.Add(this.rb_yes);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(917, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 145);
            this.panel2.TabIndex = 20;
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(9, 90);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(63, 33);
            this.rb_no.TabIndex = 2;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "No";
            this.rb_no.UseVisualStyleBackColor = true;
            this.rb_no.CheckedChanged += new System.EventHandler(this.rb_no_CheckedChanged);
            // 
            // rb_yes
            // 
            this.rb_yes.AutoSize = true;
            this.rb_yes.Location = new System.Drawing.Point(9, 48);
            this.rb_yes.Name = "rb_yes";
            this.rb_yes.Size = new System.Drawing.Size(73, 33);
            this.rb_yes.TabIndex = 1;
            this.rb_yes.TabStop = true;
            this.rb_yes.Text = "Yes";
            this.rb_yes.UseVisualStyleBackColor = true;
            this.rb_yes.CheckedChanged += new System.EventHandler(this.rb_yes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "AutoLoad?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.SaveEverySec_chb);
            this.panel1.Location = new System.Drawing.Point(525, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 145);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Save logs every (sec):";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(52, 80);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(202, 36);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // SaveEverySec_chb
            // 
            this.SaveEverySec_chb.AutoSize = true;
            this.SaveEverySec_chb.Checked = true;
            this.SaveEverySec_chb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveEverySec_chb.Location = new System.Drawing.Point(8, 90);
            this.SaveEverySec_chb.Name = "SaveEverySec_chb";
            this.SaveEverySec_chb.Size = new System.Drawing.Size(15, 14);
            this.SaveEverySec_chb.TabIndex = 16;
            this.SaveEverySec_chb.UseVisualStyleBackColor = true;
            this.SaveEverySec_chb.CheckedChanged += new System.EventHandler(this.SaveEverySec_chb_CheckedChanged);
            // 
            // lb_info_One_Str
            // 
            this.lb_info_One_Str.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lb_info_One_Str.FormattingEnabled = true;
            this.lb_info_One_Str.ItemHeight = 29;
            this.lb_info_One_Str.Location = new System.Drawing.Point(525, 6);
            this.lb_info_One_Str.Name = "lb_info_One_Str";
            this.lb_info_One_Str.Size = new System.Drawing.Size(554, 149);
            this.lb_info_One_Str.TabIndex = 15;
            // 
            // lb_Info_Rus
            // 
            this.lb_Info_Rus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lb_Info_Rus.FormattingEnabled = true;
            this.lb_Info_Rus.ItemHeight = 29;
            this.lb_Info_Rus.Location = new System.Drawing.Point(263, 3);
            this.lb_Info_Rus.Name = "lb_Info_Rus";
            this.lb_Info_Rus.Size = new System.Drawing.Size(256, 468);
            this.lb_Info_Rus.TabIndex = 14;
            // 
            // lb_Info_Eng
            // 
            this.lb_Info_Eng.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lb_Info_Eng.FormattingEnabled = true;
            this.lb_Info_Eng.ItemHeight = 29;
            this.lb_Info_Eng.Location = new System.Drawing.Point(6, 3);
            this.lb_Info_Eng.Name = "lb_Info_Eng";
            this.lb_Info_Eng.Size = new System.Drawing.Size(251, 468);
            this.lb_Info_Eng.TabIndex = 13;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(937, 398);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(142, 70);
            this.Btn_Clear.TabIndex = 12;
            this.Btn_Clear.Text = "Clear (Current)";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(730, 398);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(139, 70);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(525, 398);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(143, 70);
            this.btn_load.TabIndex = 10;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgv_Proc);
            this.tabPage2.Controls.Add(this.Btn_Kill);
            this.tabPage2.Controls.Add(this.btn_Refresh);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1085, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dispetcher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rb_order_descending);
            this.panel5.Controls.Add(this.rb_order_ascending);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(910, 242);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 87);
            this.panel5.TabIndex = 22;
            this.panel5.Visible = false;
            // 
            // rb_order_descending
            // 
            this.rb_order_descending.AutoSize = true;
            this.rb_order_descending.Location = new System.Drawing.Point(4, 5);
            this.rb_order_descending.Name = "rb_order_descending";
            this.rb_order_descending.Size = new System.Drawing.Size(165, 33);
            this.rb_order_descending.TabIndex = 19;
            this.rb_order_descending.TabStop = true;
            this.rb_order_descending.Text = "Descending";
            this.rb_order_descending.UseVisualStyleBackColor = true;
            this.rb_order_descending.CheckedChanged += new System.EventHandler(this.rb_order_descending_CheckedChanged);
            // 
            // rb_order_ascending
            // 
            this.rb_order_ascending.AutoSize = true;
            this.rb_order_ascending.Location = new System.Drawing.Point(4, 44);
            this.rb_order_ascending.Name = "rb_order_ascending";
            this.rb_order_ascending.Size = new System.Drawing.Size(153, 33);
            this.rb_order_ascending.TabIndex = 20;
            this.rb_order_ascending.TabStop = true;
            this.rb_order_ascending.Text = "Ascending";
            this.rb_order_ascending.UseVisualStyleBackColor = true;
            this.rb_order_ascending.CheckedChanged += new System.EventHandler(this.rb_order_ascending_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rb_order_name);
            this.panel4.Controls.Add(this.rb_order_handle);
            this.panel4.Controls.Add(this.rb_order_id);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(778, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(126, 129);
            this.panel4.TabIndex = 21;
            this.panel4.Visible = false;
            // 
            // rb_order_name
            // 
            this.rb_order_name.AutoSize = true;
            this.rb_order_name.Location = new System.Drawing.Point(3, 5);
            this.rb_order_name.Name = "rb_order_name";
            this.rb_order_name.Size = new System.Drawing.Size(94, 33);
            this.rb_order_name.TabIndex = 15;
            this.rb_order_name.TabStop = true;
            this.rb_order_name.Text = "Name";
            this.rb_order_name.UseVisualStyleBackColor = true;
            this.rb_order_name.CheckedChanged += new System.EventHandler(this.rb_order_name_CheckedChanged);
            // 
            // rb_order_handle
            // 
            this.rb_order_handle.AutoSize = true;
            this.rb_order_handle.Location = new System.Drawing.Point(3, 44);
            this.rb_order_handle.Name = "rb_order_handle";
            this.rb_order_handle.Size = new System.Drawing.Size(112, 33);
            this.rb_order_handle.TabIndex = 16;
            this.rb_order_handle.TabStop = true;
            this.rb_order_handle.Text = "Handle";
            this.rb_order_handle.UseVisualStyleBackColor = true;
            this.rb_order_handle.CheckedChanged += new System.EventHandler(this.rb_order_handle_CheckedChanged);
            // 
            // rb_order_id
            // 
            this.rb_order_id.AutoSize = true;
            this.rb_order_id.Location = new System.Drawing.Point(3, 83);
            this.rb_order_id.Name = "rb_order_id";
            this.rb_order_id.Size = new System.Drawing.Size(52, 33);
            this.rb_order_id.TabIndex = 17;
            this.rb_order_id.TabStop = true;
            this.rb_order_id.Text = "Id";
            this.rb_order_id.UseVisualStyleBackColor = true;
            this.rb_order_id.CheckedChanged += new System.EventHandler(this.rb_order_id_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(829, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sorting by:";
            this.label9.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Bookman Old Style", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(834, 98);
            this.checkBox1.MaximumSize = new System.Drawing.Size(30, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(890, 85);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 36);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(820, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seconds (Update)";
            // 
            // dgv_Proc
            // 
            this.dgv_Proc.AllowUserToAddRows = false;
            this.dgv_Proc.AllowUserToDeleteRows = false;
            this.dgv_Proc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PrName,
            this.HandleCount});
            this.dgv_Proc.Location = new System.Drawing.Point(15, 6);
            this.dgv_Proc.Name = "dgv_Proc";
            this.dgv_Proc.ReadOnly = true;
            this.dgv_Proc.Size = new System.Drawing.Size(743, 449);
            this.dgv_Proc.TabIndex = 11;
            this.dgv_Proc.SelectionChanged += new System.EventHandler(this.dgv_Proc_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 200;
            // 
            // PrName
            // 
            this.PrName.DataPropertyName = "ProcessName";
            this.PrName.HeaderText = "Name";
            this.PrName.Name = "PrName";
            this.PrName.ReadOnly = true;
            this.PrName.Width = 350;
            // 
            // HandleCount
            // 
            this.HandleCount.DataPropertyName = "HandleCount";
            this.HandleCount.HeaderText = "Handle";
            this.HandleCount.Name = "HandleCount";
            this.HandleCount.ReadOnly = true;
            this.HandleCount.Width = 150;
            // 
            // Btn_Kill
            // 
            this.Btn_Kill.Enabled = false;
            this.Btn_Kill.Location = new System.Drawing.Point(778, 403);
            this.Btn_Kill.Name = "Btn_Kill";
            this.Btn_Kill.Size = new System.Drawing.Size(126, 52);
            this.Btn_Kill.TabIndex = 10;
            this.Btn_Kill.Text = "Kill";
            this.Btn_Kill.UseVisualStyleBackColor = true;
            this.Btn_Kill.Click += new System.EventHandler(this.Btn_Kill_Click_1);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(953, 403);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(126, 52);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.lb_server_logs);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.Btn_send_To_Server);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1085, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Send";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Logs:";
            // 
            // lb_server_logs
            // 
            this.lb_server_logs.FormattingEnabled = true;
            this.lb_server_logs.ItemHeight = 29;
            this.lb_server_logs.Location = new System.Drawing.Point(560, 81);
            this.lb_server_logs.Name = "lb_server_logs";
            this.lb_server_logs.Size = new System.Drawing.Size(508, 381);
            this.lb_server_logs.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "(Once in a minute)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Disconnect);
            this.panel3.Controls.Add(this.Btn_Connect);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.nud_port);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txb_ip);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 229);
            this.panel3.TabIndex = 6;
            // 
            // Btn_Disconnect
            // 
            this.Btn_Disconnect.Location = new System.Drawing.Point(295, 163);
            this.Btn_Disconnect.Name = "Btn_Disconnect";
            this.Btn_Disconnect.Size = new System.Drawing.Size(162, 43);
            this.Btn_Disconnect.TabIndex = 7;
            this.Btn_Disconnect.Text = "Disconnect";
            this.Btn_Disconnect.UseVisualStyleBackColor = true;
            this.Btn_Disconnect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(33, 163);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(115, 43);
            this.Btn_Connect.TabIndex = 6;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "IP server:";
            // 
            // nud_port
            // 
            this.nud_port.Location = new System.Drawing.Point(190, 95);
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
            this.nud_port.Size = new System.Drawing.Size(267, 36);
            this.nud_port.TabIndex = 5;
            this.nud_port.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Port:";
            // 
            // txb_ip
            // 
            this.txb_ip.Location = new System.Drawing.Point(190, 14);
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.Size = new System.Drawing.Size(267, 36);
            this.txb_ip.TabIndex = 4;
            this.txb_ip.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Send Files to the server:";
            // 
            // Btn_send_To_Server
            // 
            this.Btn_send_To_Server.Location = new System.Drawing.Point(151, 323);
            this.Btn_send_To_Server.Name = "Btn_send_To_Server";
            this.Btn_send_To_Server.Size = new System.Drawing.Size(163, 65);
            this.Btn_send_To_Server.TabIndex = 0;
            this.Btn_send_To_Server.Text = "Send";
            this.Btn_send_To_Server.UseVisualStyleBackColor = true;
            this.Btn_send_To_Server.Click += new System.EventHandler(this.Btn_send_To_Server_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            this.dlgOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpen_FileOk);
            // 
            // Timer_Save
            // 
            this.Timer_Save.Interval = 1000;
            this.Timer_Save.Tick += new System.EventHandler(this.Timer_Save_Tick);
            // 
            // Timer_send_in_minute
            // 
            this.Timer_send_in_minute.Interval = 1000;
            this.Timer_send_in_minute.Tick += new System.EventHandler(this.Timer_send_in_minute_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1119, 524);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Harrington", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Main";
            this.Deactivate += new System.EventHandler(this.Main_Deactivate);
            this.Load += new System.EventHandler(this.Main_Load);
            this.VisibleChanged += new System.EventHandler(this.Main_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lb_info_One_Str;
        private System.Windows.Forms.ListBox lb_Info_Rus;
        private System.Windows.Forms.ListBox lb_Info_Eng;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Proc;
        private System.Windows.Forms.Button Btn_Kill;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandleCount;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox SaveEverySec_chb;
        private System.Windows.Forms.Timer Timer_Save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.RadioButton rb_yes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Disconnect;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_send_To_Server;
        private System.Windows.Forms.Timer Timer_send_in_minute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lb_server_logs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rb_order_id;
        private System.Windows.Forms.RadioButton rb_order_handle;
        private System.Windows.Forms.RadioButton rb_order_name;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rb_order_ascending;
        private System.Windows.Forms.RadioButton rb_order_descending;
    }
}

