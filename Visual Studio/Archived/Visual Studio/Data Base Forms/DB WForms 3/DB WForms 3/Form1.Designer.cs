
namespace DB_WForms_3
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
            this.dgv_Countries = new System.Windows.Forms.DataGridView();
            this.Id_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Continents_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_add = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_Countries_Continent = new System.Windows.Forms.TextBox();
            this.txb_Countries_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_A_Redact = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.GroupBox();
            this.cmb_Country = new System.Windows.Forms.ComboBox();
            this.Btn_A_Add = new System.Windows.Forms.Button();
            this.Btn_A_Delete = new System.Windows.Forms.Button();
            this.Btn_A_Save = new System.Windows.Forms.Button();
            this.txb_A_Surname = new System.Windows.Forms.TextBox();
            this.txb_A_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_authors_Update = new System.Windows.Forms.Button();
            this.dgv_Authors = new System.Windows.Forms.DataGridView();
            this.Author_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Btn_Load_Books = new System.Windows.Forms.Button();
            this.dgv_AuthorsBooks = new System.Windows.Forms.DataGridView();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Themes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Book_Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_Authors = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Btn_Shop_Update = new System.Windows.Forms.Button();
            this.Btn_Shops_Save = new System.Windows.Forms.Button();
            this.Btn_Shop_Delete = new System.Windows.Forms.Button();
            this.Btn_Shop_Add = new System.Windows.Forms.Button();
            this.dgv_Shops = new System.Windows.Forms.DataGridView();
            this.Shop_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop_Country = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Countries)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Authors)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AuthorsBooks)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shops)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Countries
            // 
            this.dgv_Countries.AllowUserToAddRows = false;
            this.dgv_Countries.AllowUserToDeleteRows = false;
            this.dgv_Countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Countries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Country,
            this.Name_Country,
            this.Continents_Country});
            this.dgv_Countries.Location = new System.Drawing.Point(6, 3);
            this.dgv_Countries.Name = "dgv_Countries";
            this.dgv_Countries.ReadOnly = true;
            this.dgv_Countries.Size = new System.Drawing.Size(638, 235);
            this.dgv_Countries.TabIndex = 0;
            this.dgv_Countries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Countries_CellContentClick);
            this.dgv_Countries.SelectionChanged += new System.EventHandler(this.dgv_Countries_SelectionChanged);
            // 
            // Id_Country
            // 
            this.Id_Country.DataPropertyName = "Id";
            this.Id_Country.HeaderText = "Id";
            this.Id_Country.Name = "Id_Country";
            this.Id_Country.ReadOnly = true;
            // 
            // Name_Country
            // 
            this.Name_Country.DataPropertyName = "Name";
            this.Name_Country.HeaderText = "Name";
            this.Name_Country.Name = "Name_Country";
            this.Name_Country.ReadOnly = true;
            // 
            // Continents_Country
            // 
            this.Continents_Country.DataPropertyName = "Continents";
            this.Continents_Country.HeaderText = "Continents";
            this.Continents_Country.Name = "Continents_Country";
            this.Continents_Country.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 388);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_Delete);
            this.tabPage1.Controls.Add(this.Btn_add);
            this.tabPage1.Controls.Add(this.Btn_Save);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Btn_Update);
            this.tabPage1.Controls.Add(this.dgv_Countries);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Countries";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(34, 323);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 5;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_add
            // 
            this.Btn_add.Location = new System.Drawing.Point(34, 305);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(75, 23);
            this.Btn_add.TabIndex = 4;
            this.Btn_add.Text = "Add";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(34, 282);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_Countries_Continent);
            this.groupBox1.Controls.Add(this.txb_Countries_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(148, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter";
            // 
            // txb_Countries_Continent
            // 
            this.txb_Countries_Continent.Location = new System.Drawing.Point(109, 53);
            this.txb_Countries_Continent.Name = "txb_Countries_Continent";
            this.txb_Countries_Continent.Size = new System.Drawing.Size(206, 20);
            this.txb_Countries_Continent.TabIndex = 3;
            // 
            // txb_Countries_Name
            // 
            this.txb_Countries_Name.Location = new System.Drawing.Point(109, 24);
            this.txb_Countries_Name.Name = "txb_Countries_Name";
            this.txb_Countries_Name.Size = new System.Drawing.Size(206, 20);
            this.txb_Countries_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Continent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(34, 259);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 1;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_A_Redact);
            this.tabPage2.Controls.Add(this.Box);
            this.tabPage2.Controls.Add(this.Btn_authors_Update);
            this.tabPage2.Controls.Add(this.dgv_Authors);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Authors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_A_Redact
            // 
            this.Btn_A_Redact.Location = new System.Drawing.Point(7, 322);
            this.Btn_A_Redact.Name = "Btn_A_Redact";
            this.Btn_A_Redact.Size = new System.Drawing.Size(75, 23);
            this.Btn_A_Redact.TabIndex = 3;
            this.Btn_A_Redact.Text = "Redact";
            this.Btn_A_Redact.UseVisualStyleBackColor = true;
            this.Btn_A_Redact.Click += new System.EventHandler(this.Btn_A_Redact_Click);
            // 
            // Box
            // 
            this.Box.Controls.Add(this.cmb_Country);
            this.Box.Controls.Add(this.Btn_A_Add);
            this.Box.Controls.Add(this.Btn_A_Delete);
            this.Box.Controls.Add(this.Btn_A_Save);
            this.Box.Controls.Add(this.txb_A_Surname);
            this.Box.Controls.Add(this.txb_A_Name);
            this.Box.Controls.Add(this.label5);
            this.Box.Controls.Add(this.label4);
            this.Box.Controls.Add(this.label3);
            this.Box.Location = new System.Drawing.Point(125, 253);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(496, 100);
            this.Box.TabIndex = 2;
            this.Box.TabStop = false;
            this.Box.Text = "Box";
            // 
            // cmb_Country
            // 
            this.cmb_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Country.FormattingEnabled = true;
            this.cmb_Country.Location = new System.Drawing.Point(104, 69);
            this.cmb_Country.Name = "cmb_Country";
            this.cmb_Country.Size = new System.Drawing.Size(222, 21);
            this.cmb_Country.TabIndex = 9;
            // 
            // Btn_A_Add
            // 
            this.Btn_A_Add.Location = new System.Drawing.Point(375, 71);
            this.Btn_A_Add.Name = "Btn_A_Add";
            this.Btn_A_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_A_Add.TabIndex = 8;
            this.Btn_A_Add.Text = "Add";
            this.Btn_A_Add.UseVisualStyleBackColor = true;
            this.Btn_A_Add.Click += new System.EventHandler(this.Btn_A_Add_Click);
            // 
            // Btn_A_Delete
            // 
            this.Btn_A_Delete.Location = new System.Drawing.Point(375, 43);
            this.Btn_A_Delete.Name = "Btn_A_Delete";
            this.Btn_A_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_A_Delete.TabIndex = 7;
            this.Btn_A_Delete.Text = "Delete";
            this.Btn_A_Delete.UseVisualStyleBackColor = true;
            this.Btn_A_Delete.Click += new System.EventHandler(this.Btn_A_Delete_Click);
            // 
            // Btn_A_Save
            // 
            this.Btn_A_Save.Location = new System.Drawing.Point(375, 16);
            this.Btn_A_Save.Name = "Btn_A_Save";
            this.Btn_A_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_A_Save.TabIndex = 6;
            this.Btn_A_Save.Text = "Save";
            this.Btn_A_Save.UseVisualStyleBackColor = true;
            this.Btn_A_Save.Click += new System.EventHandler(this.Btn_A_Save_Click);
            // 
            // txb_A_Surname
            // 
            this.txb_A_Surname.Location = new System.Drawing.Point(104, 43);
            this.txb_A_Surname.Name = "txb_A_Surname";
            this.txb_A_Surname.Size = new System.Drawing.Size(222, 20);
            this.txb_A_Surname.TabIndex = 4;
            // 
            // txb_A_Name
            // 
            this.txb_A_Name.Location = new System.Drawing.Point(104, 20);
            this.txb_A_Name.Name = "txb_A_Name";
            this.txb_A_Name.Size = new System.Drawing.Size(222, 20);
            this.txb_A_Name.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // Btn_authors_Update
            // 
            this.Btn_authors_Update.Location = new System.Drawing.Point(6, 253);
            this.Btn_authors_Update.Name = "Btn_authors_Update";
            this.Btn_authors_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_authors_Update.TabIndex = 1;
            this.Btn_authors_Update.Text = "Update";
            this.Btn_authors_Update.UseVisualStyleBackColor = true;
            this.Btn_authors_Update.Click += new System.EventHandler(this.Btn_authors_Update_Click);
            // 
            // dgv_Authors
            // 
            this.dgv_Authors.AllowUserToAddRows = false;
            this.dgv_Authors.AllowUserToDeleteRows = false;
            this.dgv_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Authors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author_Id,
            this.Name_Author,
            this.Surname,
            this.Country_Name});
            this.dgv_Authors.Location = new System.Drawing.Point(6, 6);
            this.dgv_Authors.Name = "dgv_Authors";
            this.dgv_Authors.ReadOnly = true;
            this.dgv_Authors.Size = new System.Drawing.Size(650, 241);
            this.dgv_Authors.TabIndex = 0;
            this.dgv_Authors.SelectionChanged += new System.EventHandler(this.dgv_Authors_SelectionChanged);
            // 
            // Author_Id
            // 
            this.Author_Id.DataPropertyName = "Id";
            this.Author_Id.HeaderText = "Id";
            this.Author_Id.Name = "Author_Id";
            this.Author_Id.ReadOnly = true;
            // 
            // Name_Author
            // 
            this.Name_Author.DataPropertyName = "Name";
            this.Name_Author.HeaderText = "Name";
            this.Name_Author.Name = "Name_Author";
            this.Name_Author.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Country_Name
            // 
            this.Country_Name.DataPropertyName = "CountriesID";
            this.Country_Name.HeaderText = "Country";
            this.Country_Name.Name = "Country_Name";
            this.Country_Name.ReadOnly = true;
            this.Country_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Country_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Btn_Load_Books);
            this.tabPage3.Controls.Add(this.dgv_AuthorsBooks);
            this.tabPage3.Controls.Add(this.list_Authors);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(662, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Author`s Book";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Btn_Load_Books
            // 
            this.Btn_Load_Books.Location = new System.Drawing.Point(5, 316);
            this.Btn_Load_Books.Name = "Btn_Load_Books";
            this.Btn_Load_Books.Size = new System.Drawing.Size(245, 23);
            this.Btn_Load_Books.TabIndex = 2;
            this.Btn_Load_Books.Text = "Load Author`s Books";
            this.Btn_Load_Books.UseVisualStyleBackColor = true;
            this.Btn_Load_Books.Click += new System.EventHandler(this.Btn_Load_Books_Click);
            // 
            // dgv_AuthorsBooks
            // 
            this.dgv_AuthorsBooks.AllowUserToAddRows = false;
            this.dgv_AuthorsBooks.AllowUserToDeleteRows = false;
            this.dgv_AuthorsBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AuthorsBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_Name,
            this.Book_Price,
            this.Book_Themes,
            this.Book_Pages,
            this.Book_PublishDate});
            this.dgv_AuthorsBooks.Location = new System.Drawing.Point(257, 4);
            this.dgv_AuthorsBooks.Name = "dgv_AuthorsBooks";
            this.dgv_AuthorsBooks.ReadOnly = true;
            this.dgv_AuthorsBooks.Size = new System.Drawing.Size(402, 288);
            this.dgv_AuthorsBooks.TabIndex = 1;
            // 
            // Book_Name
            // 
            this.Book_Name.DataPropertyName = "Name";
            this.Book_Name.HeaderText = "Name";
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.ReadOnly = true;
            // 
            // Book_Price
            // 
            this.Book_Price.DataPropertyName = "Price";
            this.Book_Price.HeaderText = "Price";
            this.Book_Price.Name = "Book_Price";
            this.Book_Price.ReadOnly = true;
            // 
            // Book_Themes
            // 
            this.Book_Themes.DataPropertyName = "ThemesId";
            this.Book_Themes.HeaderText = "Themes";
            this.Book_Themes.Name = "Book_Themes";
            this.Book_Themes.ReadOnly = true;
            // 
            // Book_Pages
            // 
            this.Book_Pages.DataPropertyName = "Pages";
            this.Book_Pages.HeaderText = "Pages";
            this.Book_Pages.Name = "Book_Pages";
            this.Book_Pages.ReadOnly = true;
            // 
            // Book_PublishDate
            // 
            this.Book_PublishDate.DataPropertyName = "PublishDate";
            this.Book_PublishDate.HeaderText = "Publish Date";
            this.Book_PublishDate.Name = "Book_PublishDate";
            this.Book_PublishDate.ReadOnly = true;
            // 
            // list_Authors
            // 
            this.list_Authors.FormattingEnabled = true;
            this.list_Authors.Location = new System.Drawing.Point(5, 4);
            this.list_Authors.Name = "list_Authors";
            this.list_Authors.Size = new System.Drawing.Size(245, 290);
            this.list_Authors.TabIndex = 0;
            this.list_Authors.SelectedIndexChanged += new System.EventHandler(this.list_Authors_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Btn_Shop_Update);
            this.tabPage4.Controls.Add(this.Btn_Shops_Save);
            this.tabPage4.Controls.Add(this.Btn_Shop_Delete);
            this.tabPage4.Controls.Add(this.Btn_Shop_Add);
            this.tabPage4.Controls.Add(this.dgv_Shops);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(662, 362);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Shops";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Btn_Shop_Update
            // 
            this.Btn_Shop_Update.Location = new System.Drawing.Point(20, 316);
            this.Btn_Shop_Update.Name = "Btn_Shop_Update";
            this.Btn_Shop_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Shop_Update.TabIndex = 4;
            this.Btn_Shop_Update.Text = "Update";
            this.Btn_Shop_Update.UseVisualStyleBackColor = true;
            this.Btn_Shop_Update.Click += new System.EventHandler(this.Btn_Shop_Update_Click);
            // 
            // Btn_Shops_Save
            // 
            this.Btn_Shops_Save.Location = new System.Drawing.Point(334, 316);
            this.Btn_Shops_Save.Name = "Btn_Shops_Save";
            this.Btn_Shops_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Shops_Save.TabIndex = 3;
            this.Btn_Shops_Save.Text = "Save";
            this.Btn_Shops_Save.UseVisualStyleBackColor = true;
            this.Btn_Shops_Save.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Shop_Delete
            // 
            this.Btn_Shop_Delete.Location = new System.Drawing.Point(226, 316);
            this.Btn_Shop_Delete.Name = "Btn_Shop_Delete";
            this.Btn_Shop_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Shop_Delete.TabIndex = 2;
            this.Btn_Shop_Delete.Text = "Delete";
            this.Btn_Shop_Delete.UseVisualStyleBackColor = true;
            this.Btn_Shop_Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Shop_Add
            // 
            this.Btn_Shop_Add.Location = new System.Drawing.Point(122, 316);
            this.Btn_Shop_Add.Name = "Btn_Shop_Add";
            this.Btn_Shop_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Shop_Add.TabIndex = 1;
            this.Btn_Shop_Add.Text = "Add";
            this.Btn_Shop_Add.UseVisualStyleBackColor = true;
            this.Btn_Shop_Add.Click += new System.EventHandler(this.Btn_Shop_Add_Click);
            // 
            // dgv_Shops
            // 
            this.dgv_Shops.AllowUserToAddRows = false;
            this.dgv_Shops.AllowUserToDeleteRows = false;
            this.dgv_Shops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Shops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shop_Name,
            this.Shop_Country});
            this.dgv_Shops.Location = new System.Drawing.Point(4, 4);
            this.dgv_Shops.Name = "dgv_Shops";
            this.dgv_Shops.ReadOnly = true;
            this.dgv_Shops.Size = new System.Drawing.Size(655, 290);
            this.dgv_Shops.TabIndex = 0;
            // 
            // Shop_Name
            // 
            this.Shop_Name.DataPropertyName = "Name";
            this.Shop_Name.HeaderText = "Name";
            this.Shop_Name.Name = "Shop_Name";
            this.Shop_Name.ReadOnly = true;
            // 
            // Shop_Country
            // 
            this.Shop_Country.DataPropertyName = "CountriesID";
            this.Shop_Country.HeaderText = "Country";
            this.Shop_Country.Name = "Shop_Country";
            this.Shop_Country.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(662, 362);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Books";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 394);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Countries)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Authors)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AuthorsBooks)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Shops)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Countries;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_Countries_Continent;
        private System.Windows.Forms.TextBox txb_Countries_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView dgv_Authors;
        private System.Windows.Forms.Button Btn_authors_Update;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Button Btn_A_Add;
        private System.Windows.Forms.Button Btn_A_Delete;
        private System.Windows.Forms.Button Btn_A_Save;
        private System.Windows.Forms.TextBox txb_A_Surname;
        private System.Windows.Forms.TextBox txb_A_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Continents_Country;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewComboBoxColumn Country_Name;
        private System.Windows.Forms.Button Btn_A_Redact;
        private System.Windows.Forms.Button Btn_Load_Books;
        private System.Windows.Forms.DataGridView dgv_AuthorsBooks;
        private System.Windows.Forms.ListBox list_Authors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Price;
        private System.Windows.Forms.DataGridViewComboBoxColumn Book_Themes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_PublishDate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Btn_Shop_Update;
        private System.Windows.Forms.Button Btn_Shops_Save;
        private System.Windows.Forms.Button Btn_Shop_Delete;
        private System.Windows.Forms.Button Btn_Shop_Add;
        private System.Windows.Forms.DataGridView dgv_Shops;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn Shop_Country;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

