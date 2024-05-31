
namespace EXAM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txb_rec_find = new System.Windows.Forms.TextBox();
            this.btn_rec_find = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgv_Records_Info = new System.Windows.Forms.DataGridView();
            this.Record_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Record_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Record_PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Record_Collective = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Record_Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Record_Publisher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Record_Price_for_Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_Records = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txb_perf_find = new System.Windows.Forms.TextBox();
            this.btn_perf_find = new System.Windows.Forms.Button();
            this.dgv_Performers_Info = new System.Windows.Forms.DataGridView();
            this.Performer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number_of_tracks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Performer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Performer_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Performer_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Performer_Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Performer_Publishment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.list_Performers = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txb_gen_find = new System.Windows.Forms.TextBox();
            this.btn_gen_find = new System.Windows.Forms.Button();
            this.dgv_Genres_Info = new System.Windows.Forms.DataGridView();
            this.Genre_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre_Publishment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Genre_Collective = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.list_Genres = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_recomendation = new System.Windows.Forms.DataGridView();
            this.btn_Roger_Password = new System.Windows.Forms.Button();
            this.btn_Roger_Surname = new System.Windows.Forms.Button();
            this.btn_Roger_name = new System.Windows.Forms.Button();
            this.txb_change_Password = new System.Windows.Forms.TextBox();
            this.txb_Change_surname = new System.Windows.Forms.TextBox();
            this.txb_change_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete_Acc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Profile = new System.Windows.Forms.DataGridView();
            this.ProfileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfileBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_delete_admin = new System.Windows.Forms.Button();
            this.btn_admin_redact = new System.Windows.Forms.Button();
            this.btn_add_admin = new System.Windows.Forms.Button();
            this.nud_admin_price = new System.Windows.Forms.NumericUpDown();
            this.nud_admin_tr = new System.Windows.Forms.NumericUpDown();
            this.cmb_admin_gen = new System.Windows.Forms.ComboBox();
            this.cmb_admin_publ = new System.Windows.Forms.ComboBox();
            this.cmb_admin_col = new System.Windows.Forms.ComboBox();
            this.txb_admin_Name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_admin_Rec = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btn_DISCOUNT = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.dgv_content = new System.Windows.Forms.DataGridView();
            this.Adm_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adm_Tracks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adm_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adm_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adm_Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Adm_Publisher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Adm_colect = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Rec_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rec_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rec_Tracks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rec_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rec_Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Rec_collective = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Rec_Publisher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Rec_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont_Tracks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont_Genre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cont_Coll = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cont_Publish = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Records_Info)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Performers_Info)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Genres_Info)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recomendation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Profile)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_admin_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_admin_tr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_Rec)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 644);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txb_rec_find);
            this.tabPage1.Controls.Add(this.btn_rec_find);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dgv_Records_Info);
            this.tabPage1.Controls.Add(this.list_Records);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Records";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txb_rec_find
            // 
            this.txb_rec_find.Location = new System.Drawing.Point(404, 53);
            this.txb_rec_find.Name = "txb_rec_find";
            this.txb_rec_find.Size = new System.Drawing.Size(343, 30);
            this.txb_rec_find.TabIndex = 4;
            // 
            // btn_rec_find
            // 
            this.btn_rec_find.Location = new System.Drawing.Point(808, 50);
            this.btn_rec_find.Name = "btn_rec_find";
            this.btn_rec_find.Size = new System.Drawing.Size(67, 34);
            this.btn_rec_find.TabIndex = 3;
            this.btn_rec_find.Text = "Find";
            this.btn_rec_find.UseVisualStyleBackColor = true;
            this.btn_rec_find.Click += new System.EventHandler(this.btn_rec_find_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A-z",
            "Z-a",
            "Date O",
            "Date N",
            "Tracks +",
            "Tracks -"});
            this.comboBox1.Location = new System.Drawing.Point(404, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 30);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // dgv_Records_Info
            // 
            this.dgv_Records_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Records_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Record_Id,
            this.Record_Number,
            this.Record_PublishDate,
            this.Record_Collective,
            this.Record_Genre,
            this.Record_Publisher,
            this.Record_Price_for_Sale});
            this.dgv_Records_Info.Location = new System.Drawing.Point(404, 102);
            this.dgv_Records_Info.Name = "dgv_Records_Info";
            this.dgv_Records_Info.Size = new System.Drawing.Size(620, 500);
            this.dgv_Records_Info.TabIndex = 1;
            // 
            // Record_Id
            // 
            this.Record_Id.DataPropertyName = "Id";
            this.Record_Id.HeaderText = "Id";
            this.Record_Id.Name = "Record_Id";
            this.Record_Id.Visible = false;
            // 
            // Record_Number
            // 
            this.Record_Number.DataPropertyName = "Number_of_tracks";
            this.Record_Number.HeaderText = "Tracks";
            this.Record_Number.Name = "Record_Number";
            // 
            // Record_PublishDate
            // 
            this.Record_PublishDate.DataPropertyName = "PublishDate";
            this.Record_PublishDate.HeaderText = "Date";
            this.Record_PublishDate.Name = "Record_PublishDate";
            this.Record_PublishDate.Width = 200;
            // 
            // Record_Collective
            // 
            this.Record_Collective.DataPropertyName = "CollectiveID";
            this.Record_Collective.HeaderText = "Collective";
            this.Record_Collective.Name = "Record_Collective";
            this.Record_Collective.Width = 200;
            // 
            // Record_Genre
            // 
            this.Record_Genre.DataPropertyName = "GenreID";
            this.Record_Genre.HeaderText = "Genre";
            this.Record_Genre.Name = "Record_Genre";
            this.Record_Genre.Width = 150;
            // 
            // Record_Publisher
            // 
            this.Record_Publisher.DataPropertyName = "PublisherID";
            this.Record_Publisher.HeaderText = "Publisher";
            this.Record_Publisher.Name = "Record_Publisher";
            this.Record_Publisher.Width = 300;
            // 
            // Record_Price_for_Sale
            // 
            this.Record_Price_for_Sale.DataPropertyName = "PriceForSale";
            this.Record_Price_for_Sale.HeaderText = "Price";
            this.Record_Price_for_Sale.Name = "Record_Price_for_Sale";
            // 
            // list_Records
            // 
            this.list_Records.FormattingEnabled = true;
            this.list_Records.ItemHeight = 22;
            this.list_Records.Location = new System.Drawing.Point(6, 6);
            this.list_Records.Name = "list_Records";
            this.list_Records.Size = new System.Drawing.Size(392, 598);
            this.list_Records.TabIndex = 0;
            this.list_Records.SelectedIndexChanged += new System.EventHandler(this.list_Records_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txb_perf_find);
            this.tabPage2.Controls.Add(this.btn_perf_find);
            this.tabPage2.Controls.Add(this.dgv_Performers_Info);
            this.tabPage2.Controls.Add(this.list_Performers);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Performers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txb_perf_find
            // 
            this.txb_perf_find.Location = new System.Drawing.Point(404, 19);
            this.txb_perf_find.Name = "txb_perf_find";
            this.txb_perf_find.Size = new System.Drawing.Size(343, 30);
            this.txb_perf_find.TabIndex = 6;
            // 
            // btn_perf_find
            // 
            this.btn_perf_find.Location = new System.Drawing.Point(807, 19);
            this.btn_perf_find.Name = "btn_perf_find";
            this.btn_perf_find.Size = new System.Drawing.Size(67, 34);
            this.btn_perf_find.TabIndex = 5;
            this.btn_perf_find.Text = "Find";
            this.btn_perf_find.UseVisualStyleBackColor = true;
            this.btn_perf_find.Click += new System.EventHandler(this.btn_perf_find_Click);
            // 
            // dgv_Performers_Info
            // 
            this.dgv_Performers_Info.AllowUserToAddRows = false;
            this.dgv_Performers_Info.AllowUserToDeleteRows = false;
            this.dgv_Performers_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Performers_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Performer_Id,
            this.Number_of_tracks,
            this.Performer_Name,
            this.Performer_Date,
            this.Performer_Price,
            this.Performer_Genre,
            this.Performer_Publishment});
            this.dgv_Performers_Info.Location = new System.Drawing.Point(404, 69);
            this.dgv_Performers_Info.Name = "dgv_Performers_Info";
            this.dgv_Performers_Info.ReadOnly = true;
            this.dgv_Performers_Info.Size = new System.Drawing.Size(626, 534);
            this.dgv_Performers_Info.TabIndex = 2;
            // 
            // Performer_Id
            // 
            this.Performer_Id.DataPropertyName = "Id";
            this.Performer_Id.HeaderText = "Id";
            this.Performer_Id.Name = "Performer_Id";
            this.Performer_Id.ReadOnly = true;
            this.Performer_Id.Visible = false;
            // 
            // Number_of_tracks
            // 
            this.Number_of_tracks.DataPropertyName = "Number_of_tracks";
            this.Number_of_tracks.HeaderText = "Tracks";
            this.Number_of_tracks.Name = "Number_of_tracks";
            this.Number_of_tracks.ReadOnly = true;
            // 
            // Performer_Name
            // 
            this.Performer_Name.DataPropertyName = "Name";
            this.Performer_Name.HeaderText = "Name";
            this.Performer_Name.Name = "Performer_Name";
            this.Performer_Name.ReadOnly = true;
            this.Performer_Name.Width = 200;
            // 
            // Performer_Date
            // 
            this.Performer_Date.DataPropertyName = "PublishDate";
            this.Performer_Date.HeaderText = "Date";
            this.Performer_Date.Name = "Performer_Date";
            this.Performer_Date.ReadOnly = true;
            this.Performer_Date.Width = 200;
            // 
            // Performer_Price
            // 
            this.Performer_Price.DataPropertyName = "PriceForSale";
            this.Performer_Price.HeaderText = "Price";
            this.Performer_Price.Name = "Performer_Price";
            this.Performer_Price.ReadOnly = true;
            // 
            // Performer_Genre
            // 
            this.Performer_Genre.DataPropertyName = "GenreID";
            this.Performer_Genre.HeaderText = "Genre";
            this.Performer_Genre.Name = "Performer_Genre";
            this.Performer_Genre.ReadOnly = true;
            this.Performer_Genre.Width = 200;
            // 
            // Performer_Publishment
            // 
            this.Performer_Publishment.DataPropertyName = "PublisherID";
            this.Performer_Publishment.HeaderText = "Publishment";
            this.Performer_Publishment.Name = "Performer_Publishment";
            this.Performer_Publishment.ReadOnly = true;
            this.Performer_Publishment.Width = 300;
            // 
            // list_Performers
            // 
            this.list_Performers.FormattingEnabled = true;
            this.list_Performers.ItemHeight = 22;
            this.list_Performers.Location = new System.Drawing.Point(0, 1);
            this.list_Performers.Name = "list_Performers";
            this.list_Performers.Size = new System.Drawing.Size(398, 598);
            this.list_Performers.TabIndex = 1;
            this.list_Performers.SelectedIndexChanged += new System.EventHandler(this.list_Performers_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txb_gen_find);
            this.tabPage3.Controls.Add(this.btn_gen_find);
            this.tabPage3.Controls.Add(this.dgv_Genres_Info);
            this.tabPage3.Controls.Add(this.list_Genres);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1030, 609);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Genres";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txb_gen_find
            // 
            this.txb_gen_find.Location = new System.Drawing.Point(369, 24);
            this.txb_gen_find.Name = "txb_gen_find";
            this.txb_gen_find.Size = new System.Drawing.Size(343, 30);
            this.txb_gen_find.TabIndex = 8;
            this.txb_gen_find.TextChanged += new System.EventHandler(this.txb_gen_find_TextChanged);
            // 
            // btn_gen_find
            // 
            this.btn_gen_find.Location = new System.Drawing.Point(731, 21);
            this.btn_gen_find.Name = "btn_gen_find";
            this.btn_gen_find.Size = new System.Drawing.Size(67, 34);
            this.btn_gen_find.TabIndex = 7;
            this.btn_gen_find.Text = "Find";
            this.btn_gen_find.UseVisualStyleBackColor = true;
            this.btn_gen_find.Click += new System.EventHandler(this.btn_gen_find_Click);
            // 
            // dgv_Genres_Info
            // 
            this.dgv_Genres_Info.AllowUserToAddRows = false;
            this.dgv_Genres_Info.AllowUserToDeleteRows = false;
            this.dgv_Genres_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Genres_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Genre_Id,
            this.Genre_Name,
            this.Genre_Date,
            this.Genre_price,
            this.Genre_Number,
            this.Genre_Publishment,
            this.Genre_Collective});
            this.dgv_Genres_Info.Location = new System.Drawing.Point(370, 74);
            this.dgv_Genres_Info.Name = "dgv_Genres_Info";
            this.dgv_Genres_Info.ReadOnly = true;
            this.dgv_Genres_Info.Size = new System.Drawing.Size(654, 528);
            this.dgv_Genres_Info.TabIndex = 2;
            // 
            // Genre_Id
            // 
            this.Genre_Id.HeaderText = "Id";
            this.Genre_Id.Name = "Genre_Id";
            this.Genre_Id.ReadOnly = true;
            this.Genre_Id.Visible = false;
            // 
            // Genre_Name
            // 
            this.Genre_Name.DataPropertyName = "Name";
            this.Genre_Name.HeaderText = "Name";
            this.Genre_Name.Name = "Genre_Name";
            this.Genre_Name.ReadOnly = true;
            this.Genre_Name.Width = 200;
            // 
            // Genre_Date
            // 
            this.Genre_Date.DataPropertyName = "PublishDate";
            this.Genre_Date.HeaderText = "Date";
            this.Genre_Date.Name = "Genre_Date";
            this.Genre_Date.ReadOnly = true;
            this.Genre_Date.Width = 200;
            // 
            // Genre_price
            // 
            this.Genre_price.DataPropertyName = "PriceForSale";
            this.Genre_price.HeaderText = "Price";
            this.Genre_price.Name = "Genre_price";
            this.Genre_price.ReadOnly = true;
            // 
            // Genre_Number
            // 
            this.Genre_Number.DataPropertyName = "Number_of_tracks";
            this.Genre_Number.HeaderText = "Tracks";
            this.Genre_Number.Name = "Genre_Number";
            this.Genre_Number.ReadOnly = true;
            // 
            // Genre_Publishment
            // 
            this.Genre_Publishment.DataPropertyName = "PublisherID";
            this.Genre_Publishment.HeaderText = "Publisher";
            this.Genre_Publishment.Name = "Genre_Publishment";
            this.Genre_Publishment.ReadOnly = true;
            this.Genre_Publishment.Width = 300;
            // 
            // Genre_Collective
            // 
            this.Genre_Collective.DataPropertyName = "CollectiveID";
            this.Genre_Collective.HeaderText = "Performer";
            this.Genre_Collective.Name = "Genre_Collective";
            this.Genre_Collective.ReadOnly = true;
            this.Genre_Collective.Width = 250;
            // 
            // list_Genres
            // 
            this.list_Genres.FormattingEnabled = true;
            this.list_Genres.ItemHeight = 22;
            this.list_Genres.Location = new System.Drawing.Point(3, 0);
            this.list_Genres.Name = "list_Genres";
            this.list_Genres.Size = new System.Drawing.Size(360, 598);
            this.list_Genres.TabIndex = 1;
            this.list_Genres.SelectedIndexChanged += new System.EventHandler(this.list_Genres_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgv_recomendation);
            this.tabPage4.Controls.Add(this.btn_Roger_Password);
            this.tabPage4.Controls.Add(this.btn_Roger_Surname);
            this.tabPage4.Controls.Add(this.btn_Roger_name);
            this.tabPage4.Controls.Add(this.txb_change_Password);
            this.tabPage4.Controls.Add(this.txb_Change_surname);
            this.tabPage4.Controls.Add(this.txb_change_Name);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.btn_delete_Acc);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.dgv_Profile);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1030, 609);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Profile";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_recomendation
            // 
            this.dgv_recomendation.AllowUserToAddRows = false;
            this.dgv_recomendation.AllowUserToDeleteRows = false;
            this.dgv_recomendation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recomendation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rec_Id,
            this.Rec_Name,
            this.Rec_Tracks,
            this.Rec_Date,
            this.Rec_Genre,
            this.Rec_collective,
            this.Rec_Publisher,
            this.Rec_Price});
            this.dgv_recomendation.Location = new System.Drawing.Point(3, 398);
            this.dgv_recomendation.Name = "dgv_recomendation";
            this.dgv_recomendation.ReadOnly = true;
            this.dgv_recomendation.Size = new System.Drawing.Size(1024, 116);
            this.dgv_recomendation.TabIndex = 14;
            this.dgv_recomendation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_recomendation_CellContentClick);
            // 
            // btn_Roger_Password
            // 
            this.btn_Roger_Password.Location = new System.Drawing.Point(667, 298);
            this.btn_Roger_Password.Name = "btn_Roger_Password";
            this.btn_Roger_Password.Size = new System.Drawing.Size(38, 30);
            this.btn_Roger_Password.TabIndex = 12;
            this.btn_Roger_Password.Text = "✓";
            this.btn_Roger_Password.UseVisualStyleBackColor = true;
            this.btn_Roger_Password.Click += new System.EventHandler(this.btn_Roger_Password_Click);
            // 
            // btn_Roger_Surname
            // 
            this.btn_Roger_Surname.Location = new System.Drawing.Point(667, 237);
            this.btn_Roger_Surname.Name = "btn_Roger_Surname";
            this.btn_Roger_Surname.Size = new System.Drawing.Size(38, 30);
            this.btn_Roger_Surname.TabIndex = 11;
            this.btn_Roger_Surname.Text = "✓";
            this.btn_Roger_Surname.UseVisualStyleBackColor = true;
            this.btn_Roger_Surname.Click += new System.EventHandler(this.btn_Roger_Surname_Click);
            // 
            // btn_Roger_name
            // 
            this.btn_Roger_name.Location = new System.Drawing.Point(667, 176);
            this.btn_Roger_name.Name = "btn_Roger_name";
            this.btn_Roger_name.Size = new System.Drawing.Size(38, 30);
            this.btn_Roger_name.TabIndex = 10;
            this.btn_Roger_name.Text = "✓";
            this.btn_Roger_name.UseVisualStyleBackColor = true;
            this.btn_Roger_name.Click += new System.EventHandler(this.btn_Roger_name_Click);
            // 
            // txb_change_Password
            // 
            this.txb_change_Password.Location = new System.Drawing.Point(306, 299);
            this.txb_change_Password.Name = "txb_change_Password";
            this.txb_change_Password.Size = new System.Drawing.Size(333, 30);
            this.txb_change_Password.TabIndex = 9;
            // 
            // txb_Change_surname
            // 
            this.txb_Change_surname.Location = new System.Drawing.Point(306, 237);
            this.txb_Change_surname.Name = "txb_Change_surname";
            this.txb_Change_surname.Size = new System.Drawing.Size(333, 30);
            this.txb_Change_surname.TabIndex = 8;
            // 
            // txb_change_Name
            // 
            this.txb_change_Name.Location = new System.Drawing.Point(306, 176);
            this.txb_change_Name.Name = "txb_change_Name";
            this.txb_change_Name.Size = new System.Drawing.Size(333, 30);
            this.txb_change_Name.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Donate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni Bk BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "Change Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni Bk BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Change Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni Bk BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Change Name:";
            // 
            // btn_delete_Acc
            // 
            this.btn_delete_Acc.Location = new System.Drawing.Point(801, 553);
            this.btn_delete_Acc.Name = "btn_delete_Acc";
            this.btn_delete_Acc.Size = new System.Drawing.Size(184, 35);
            this.btn_delete_Acc.TabIndex = 2;
            this.btn_delete_Acc.Text = "Delete Account";
            this.btn_delete_Acc.UseVisualStyleBackColor = true;
            this.btn_delete_Acc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni Bk BT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "It is Your Profile";
            // 
            // dgv_Profile
            // 
            this.dgv_Profile.AllowUserToAddRows = false;
            this.dgv_Profile.AllowUserToDeleteRows = false;
            this.dgv_Profile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Profile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileID,
            this.ProfileName,
            this.ProfileSurname,
            this.ProfileDiscount,
            this.ProfileBalance});
            this.dgv_Profile.Location = new System.Drawing.Point(3, 63);
            this.dgv_Profile.Name = "dgv_Profile";
            this.dgv_Profile.ReadOnly = true;
            this.dgv_Profile.Size = new System.Drawing.Size(702, 72);
            this.dgv_Profile.TabIndex = 0;
            // 
            // ProfileID
            // 
            this.ProfileID.DataPropertyName = "Id";
            this.ProfileID.HeaderText = "Id";
            this.ProfileID.Name = "ProfileID";
            this.ProfileID.ReadOnly = true;
            this.ProfileID.Visible = false;
            // 
            // ProfileName
            // 
            this.ProfileName.DataPropertyName = "Name";
            this.ProfileName.HeaderText = "Name";
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.ReadOnly = true;
            this.ProfileName.Width = 200;
            // 
            // ProfileSurname
            // 
            this.ProfileSurname.DataPropertyName = "Surname";
            this.ProfileSurname.HeaderText = "Surname";
            this.ProfileSurname.Name = "ProfileSurname";
            this.ProfileSurname.ReadOnly = true;
            this.ProfileSurname.Width = 200;
            // 
            // ProfileDiscount
            // 
            this.ProfileDiscount.DataPropertyName = "Discount";
            this.ProfileDiscount.HeaderText = "Discount";
            this.ProfileDiscount.Name = "ProfileDiscount";
            this.ProfileDiscount.ReadOnly = true;
            this.ProfileDiscount.Width = 110;
            // 
            // ProfileBalance
            // 
            this.ProfileBalance.DataPropertyName = "Balance";
            this.ProfileBalance.HeaderText = "Balance";
            this.ProfileBalance.Name = "ProfileBalance";
            this.ProfileBalance.ReadOnly = true;
            this.ProfileBalance.Width = 145;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.tabControl2);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1030, 609);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Admin Panel";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Work with our DB (only Admins)";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Font = new System.Drawing.Font("Bodoni Bk BT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(10, 67);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1014, 535);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btn_delete_admin);
            this.tabPage6.Controls.Add(this.btn_admin_redact);
            this.tabPage6.Controls.Add(this.btn_add_admin);
            this.tabPage6.Controls.Add(this.nud_admin_price);
            this.tabPage6.Controls.Add(this.nud_admin_tr);
            this.tabPage6.Controls.Add(this.cmb_admin_gen);
            this.tabPage6.Controls.Add(this.cmb_admin_publ);
            this.tabPage6.Controls.Add(this.cmb_admin_col);
            this.tabPage6.Controls.Add(this.txb_admin_Name);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.dgv_admin_Rec);
            this.tabPage6.Location = new System.Drawing.Point(4, 32);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1006, 499);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Records";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_delete_admin
            // 
            this.btn_delete_admin.Location = new System.Drawing.Point(892, 425);
            this.btn_delete_admin.Name = "btn_delete_admin";
            this.btn_delete_admin.Size = new System.Drawing.Size(84, 33);
            this.btn_delete_admin.TabIndex = 15;
            this.btn_delete_admin.Text = "Delete";
            this.btn_delete_admin.UseVisualStyleBackColor = true;
            this.btn_delete_admin.Click += new System.EventHandler(this.btn_delete_admin_Click);
            // 
            // btn_admin_redact
            // 
            this.btn_admin_redact.Location = new System.Drawing.Point(892, 390);
            this.btn_admin_redact.Name = "btn_admin_redact";
            this.btn_admin_redact.Size = new System.Drawing.Size(84, 33);
            this.btn_admin_redact.TabIndex = 14;
            this.btn_admin_redact.Text = "Redact";
            this.btn_admin_redact.UseVisualStyleBackColor = true;
            this.btn_admin_redact.Click += new System.EventHandler(this.btn_admin_redact_Click);
            // 
            // btn_add_admin
            // 
            this.btn_add_admin.Location = new System.Drawing.Point(892, 357);
            this.btn_add_admin.Name = "btn_add_admin";
            this.btn_add_admin.Size = new System.Drawing.Size(84, 33);
            this.btn_add_admin.TabIndex = 13;
            this.btn_add_admin.Text = "Add";
            this.btn_add_admin.UseVisualStyleBackColor = true;
            this.btn_add_admin.Click += new System.EventHandler(this.btn_add_admin_Click);
            // 
            // nud_admin_price
            // 
            this.nud_admin_price.Location = new System.Drawing.Point(611, 431);
            this.nud_admin_price.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_admin_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_admin_price.Name = "nud_admin_price";
            this.nud_admin_price.Size = new System.Drawing.Size(196, 30);
            this.nud_admin_price.TabIndex = 12;
            this.nud_admin_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_admin_tr
            // 
            this.nud_admin_tr.Location = new System.Drawing.Point(611, 360);
            this.nud_admin_tr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_admin_tr.Name = "nud_admin_tr";
            this.nud_admin_tr.Size = new System.Drawing.Size(196, 30);
            this.nud_admin_tr.TabIndex = 11;
            this.nud_admin_tr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmb_admin_gen
            // 
            this.cmb_admin_gen.FormattingEnabled = true;
            this.cmb_admin_gen.Location = new System.Drawing.Point(611, 395);
            this.cmb_admin_gen.Name = "cmb_admin_gen";
            this.cmb_admin_gen.Size = new System.Drawing.Size(196, 31);
            this.cmb_admin_gen.TabIndex = 10;
            // 
            // cmb_admin_publ
            // 
            this.cmb_admin_publ.FormattingEnabled = true;
            this.cmb_admin_publ.Location = new System.Drawing.Point(129, 429);
            this.cmb_admin_publ.Name = "cmb_admin_publ";
            this.cmb_admin_publ.Size = new System.Drawing.Size(294, 31);
            this.cmb_admin_publ.TabIndex = 9;
            // 
            // cmb_admin_col
            // 
            this.cmb_admin_col.FormattingEnabled = true;
            this.cmb_admin_col.Location = new System.Drawing.Point(129, 392);
            this.cmb_admin_col.Name = "cmb_admin_col";
            this.cmb_admin_col.Size = new System.Drawing.Size(294, 31);
            this.cmb_admin_col.TabIndex = 8;
            // 
            // txb_admin_Name
            // 
            this.txb_admin_Name.Location = new System.Drawing.Point(129, 356);
            this.txb_admin_Name.Name = "txb_admin_Name";
            this.txb_admin_Name.Size = new System.Drawing.Size(294, 30);
            this.txb_admin_Name.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(532, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "N Tracks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Publisher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Collective";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name";
            // 
            // dgv_admin_Rec
            // 
            this.dgv_admin_Rec.AllowUserToAddRows = false;
            this.dgv_admin_Rec.AllowUserToDeleteRows = false;
            this.dgv_admin_Rec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin_Rec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adm_Id,
            this.Adm_Name,
            this.Adm_Tracks,
            this.Adm_Date,
            this.Adm_Price,
            this.Adm_Genre,
            this.Adm_Publisher,
            this.Adm_colect});
            this.dgv_admin_Rec.Location = new System.Drawing.Point(7, 7);
            this.dgv_admin_Rec.Name = "dgv_admin_Rec";
            this.dgv_admin_Rec.ReadOnly = true;
            this.dgv_admin_Rec.Size = new System.Drawing.Size(993, 332);
            this.dgv_admin_Rec.TabIndex = 0;
            this.dgv_admin_Rec.SelectionChanged += new System.EventHandler(this.dgv_admin_Rec_SelectionChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label12);
            this.tabPage8.Controls.Add(this.comboBox2);
            this.tabPage8.Controls.Add(this.btn_DISCOUNT);
            this.tabPage8.Controls.Add(this.btn_new);
            this.tabPage8.Controls.Add(this.dgv_content);
            this.tabPage8.Location = new System.Drawing.Point(4, 31);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1030, 609);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Content";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // btn_DISCOUNT
            // 
            this.btn_DISCOUNT.Location = new System.Drawing.Point(171, 17);
            this.btn_DISCOUNT.Name = "btn_DISCOUNT";
            this.btn_DISCOUNT.Size = new System.Drawing.Size(110, 44);
            this.btn_DISCOUNT.TabIndex = 2;
            this.btn_DISCOUNT.Text = "Акции";
            this.btn_DISCOUNT.UseVisualStyleBackColor = true;
            this.btn_DISCOUNT.Click += new System.EventHandler(this.btn_DISCOUNT_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(18, 17);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(110, 44);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Новинки";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // dgv_content
            // 
            this.dgv_content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_content.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Content_Id,
            this.Content_Name,
            this.Cont_Tracks,
            this.Cont_Date,
            this.Cont_Price,
            this.Cont_Genre,
            this.Cont_Coll,
            this.Cont_Publish});
            this.dgv_content.Location = new System.Drawing.Point(6, 87);
            this.dgv_content.Name = "dgv_content";
            this.dgv_content.Size = new System.Drawing.Size(1018, 515);
            this.dgv_content.TabIndex = 0;
            // 
            // Adm_Id
            // 
            this.Adm_Id.DataPropertyName = "Id";
            this.Adm_Id.HeaderText = "Id";
            this.Adm_Id.Name = "Adm_Id";
            this.Adm_Id.ReadOnly = true;
            this.Adm_Id.Visible = false;
            // 
            // Adm_Name
            // 
            this.Adm_Name.DataPropertyName = "Name";
            this.Adm_Name.HeaderText = "Name";
            this.Adm_Name.Name = "Adm_Name";
            this.Adm_Name.ReadOnly = true;
            this.Adm_Name.Width = 200;
            // 
            // Adm_Tracks
            // 
            this.Adm_Tracks.DataPropertyName = "Number_of_tracks";
            this.Adm_Tracks.HeaderText = "Tracks";
            this.Adm_Tracks.Name = "Adm_Tracks";
            this.Adm_Tracks.ReadOnly = true;
            // 
            // Adm_Date
            // 
            this.Adm_Date.DataPropertyName = "PublishDate";
            this.Adm_Date.HeaderText = "Date";
            this.Adm_Date.Name = "Adm_Date";
            this.Adm_Date.ReadOnly = true;
            this.Adm_Date.Width = 150;
            // 
            // Adm_Price
            // 
            this.Adm_Price.DataPropertyName = "Price";
            this.Adm_Price.HeaderText = "Price";
            this.Adm_Price.Name = "Adm_Price";
            this.Adm_Price.ReadOnly = true;
            // 
            // Adm_Genre
            // 
            this.Adm_Genre.DataPropertyName = "GenreID";
            this.Adm_Genre.HeaderText = "Genre";
            this.Adm_Genre.Name = "Adm_Genre";
            this.Adm_Genre.ReadOnly = true;
            this.Adm_Genre.Width = 150;
            // 
            // Adm_Publisher
            // 
            this.Adm_Publisher.DataPropertyName = "PublisherID";
            this.Adm_Publisher.HeaderText = "Publisher";
            this.Adm_Publisher.Name = "Adm_Publisher";
            this.Adm_Publisher.ReadOnly = true;
            this.Adm_Publisher.Width = 150;
            // 
            // Adm_colect
            // 
            this.Adm_colect.DataPropertyName = "CollectiveID";
            this.Adm_colect.HeaderText = "Collective";
            this.Adm_colect.Name = "Adm_colect";
            this.Adm_colect.ReadOnly = true;
            this.Adm_colect.Width = 150;
            // 
            // Rec_Id
            // 
            this.Rec_Id.DataPropertyName = "Id";
            this.Rec_Id.HeaderText = "Id";
            this.Rec_Id.Name = "Rec_Id";
            this.Rec_Id.ReadOnly = true;
            this.Rec_Id.Visible = false;
            // 
            // Rec_Name
            // 
            this.Rec_Name.DataPropertyName = "Name";
            this.Rec_Name.HeaderText = "Name";
            this.Rec_Name.Name = "Rec_Name";
            this.Rec_Name.ReadOnly = true;
            this.Rec_Name.Width = 200;
            // 
            // Rec_Tracks
            // 
            this.Rec_Tracks.DataPropertyName = "Number_of_tracks";
            this.Rec_Tracks.HeaderText = "Tracks";
            this.Rec_Tracks.Name = "Rec_Tracks";
            this.Rec_Tracks.ReadOnly = true;
            // 
            // Rec_Date
            // 
            this.Rec_Date.DataPropertyName = "PublishDate";
            this.Rec_Date.HeaderText = "Date";
            this.Rec_Date.Name = "Rec_Date";
            this.Rec_Date.ReadOnly = true;
            this.Rec_Date.Width = 150;
            // 
            // Rec_Genre
            // 
            this.Rec_Genre.DataPropertyName = "GenreID";
            this.Rec_Genre.HeaderText = "Genre";
            this.Rec_Genre.Name = "Rec_Genre";
            this.Rec_Genre.ReadOnly = true;
            this.Rec_Genre.Width = 150;
            // 
            // Rec_collective
            // 
            this.Rec_collective.DataPropertyName = "CollectiveID";
            this.Rec_collective.HeaderText = "Collective";
            this.Rec_collective.Name = "Rec_collective";
            this.Rec_collective.ReadOnly = true;
            this.Rec_collective.Width = 200;
            // 
            // Rec_Publisher
            // 
            this.Rec_Publisher.DataPropertyName = "PublisherID";
            this.Rec_Publisher.HeaderText = "Publisher";
            this.Rec_Publisher.Name = "Rec_Publisher";
            this.Rec_Publisher.ReadOnly = true;
            this.Rec_Publisher.Width = 200;
            // 
            // Rec_Price
            // 
            this.Rec_Price.DataPropertyName = "Price";
            this.Rec_Price.HeaderText = "Price";
            this.Rec_Price.Name = "Rec_Price";
            this.Rec_Price.ReadOnly = true;
            // 
            // Content_Id
            // 
            this.Content_Id.DataPropertyName = "Id";
            this.Content_Id.HeaderText = "Id";
            this.Content_Id.Name = "Content_Id";
            this.Content_Id.Visible = false;
            // 
            // Content_Name
            // 
            this.Content_Name.DataPropertyName = "Name";
            this.Content_Name.HeaderText = "Name";
            this.Content_Name.Name = "Content_Name";
            this.Content_Name.Width = 200;
            // 
            // Cont_Tracks
            // 
            this.Cont_Tracks.DataPropertyName = "Number_of_tracks";
            this.Cont_Tracks.HeaderText = "Tracks";
            this.Cont_Tracks.Name = "Cont_Tracks";
            // 
            // Cont_Date
            // 
            this.Cont_Date.DataPropertyName = "PublishDate";
            this.Cont_Date.HeaderText = "Date";
            this.Cont_Date.Name = "Cont_Date";
            this.Cont_Date.Width = 150;
            // 
            // Cont_Price
            // 
            this.Cont_Price.DataPropertyName = "Price";
            this.Cont_Price.HeaderText = "Price";
            this.Cont_Price.Name = "Cont_Price";
            // 
            // Cont_Genre
            // 
            this.Cont_Genre.DataPropertyName = "GenreID";
            this.Cont_Genre.HeaderText = "Genre";
            this.Cont_Genre.Name = "Cont_Genre";
            this.Cont_Genre.Width = 150;
            // 
            // Cont_Coll
            // 
            this.Cont_Coll.DataPropertyName = "CollectiveID";
            this.Cont_Coll.HeaderText = "Collective";
            this.Cont_Coll.Name = "Cont_Coll";
            this.Cont_Coll.Width = 200;
            // 
            // Cont_Publish
            // 
            this.Cont_Publish.DataPropertyName = "PublisherID";
            this.Cont_Publish.HeaderText = "Publisher";
            this.Cont_Publish.Name = "Cont_Publish";
            this.Cont_Publish.Width = 200;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "По исполнителю",
            "По жанру",
            "По издателю",
            "По пластинке"});
            this.comboBox2.Location = new System.Drawing.Point(755, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 30);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(576, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = "Популярные:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 657);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Records_Info)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Performers_Info)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Genres_Info)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recomendation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Profile)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_admin_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_admin_tr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_Rec)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_content)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_Records_Info;
        private System.Windows.Forms.ListBox list_Records;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_Performers;
        private System.Windows.Forms.DataGridView dgv_Performers_Info;
        private System.Windows.Forms.DataGridView dgv_Genres_Info;
        private System.Windows.Forms.ListBox list_Genres;
        private System.Windows.Forms.Button btn_delete_Acc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileBalance;
        private System.Windows.Forms.Button btn_Roger_Password;
        private System.Windows.Forms.Button btn_Roger_Surname;
        private System.Windows.Forms.Button btn_Roger_name;
        private System.Windows.Forms.TextBox txb_change_Password;
        private System.Windows.Forms.TextBox txb_Change_surname;
        private System.Windows.Forms.TextBox txb_change_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Record_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Record_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Record_PublishDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Record_Collective;
        private System.Windows.Forms.DataGridViewComboBoxColumn Record_Genre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Record_Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Record_Price_for_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre_Number;
        private System.Windows.Forms.DataGridViewComboBoxColumn Genre_Publishment;
        private System.Windows.Forms.DataGridViewComboBoxColumn Genre_Collective;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txb_rec_find;
        private System.Windows.Forms.Button btn_rec_find;
        private System.Windows.Forms.TextBox txb_perf_find;
        private System.Windows.Forms.Button btn_perf_find;
        private System.Windows.Forms.TextBox txb_gen_find;
        private System.Windows.Forms.Button btn_gen_find;
        private System.Windows.Forms.DataGridViewTextBoxColumn Performer_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number_of_tracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Performer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Performer_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Performer_Price;
        private System.Windows.Forms.DataGridViewComboBoxColumn Performer_Genre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Performer_Publishment;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btn_delete_admin;
        private System.Windows.Forms.Button btn_admin_redact;
        private System.Windows.Forms.Button btn_add_admin;
        private System.Windows.Forms.NumericUpDown nud_admin_price;
        private System.Windows.Forms.NumericUpDown nud_admin_tr;
        private System.Windows.Forms.ComboBox cmb_admin_gen;
        private System.Windows.Forms.ComboBox cmb_admin_publ;
        private System.Windows.Forms.ComboBox cmb_admin_col;
        private System.Windows.Forms.TextBox txb_admin_Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_admin_Rec;
        private System.Windows.Forms.Button btn_DISCOUNT;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridView dgv_content;
        private System.Windows.Forms.DataGridView dgv_recomendation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adm_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adm_Tracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adm_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adm_Price;
        private System.Windows.Forms.DataGridViewComboBoxColumn Adm_Genre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Adm_Publisher;
        private System.Windows.Forms.DataGridViewComboBoxColumn Adm_colect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rec_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rec_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rec_Tracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rec_Date;
        private System.Windows.Forms.DataGridViewComboBoxColumn Rec_Genre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Rec_collective;
        private System.Windows.Forms.DataGridViewComboBoxColumn Rec_Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rec_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont_Tracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont_Price;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cont_Genre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cont_Coll;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cont_Publish;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

