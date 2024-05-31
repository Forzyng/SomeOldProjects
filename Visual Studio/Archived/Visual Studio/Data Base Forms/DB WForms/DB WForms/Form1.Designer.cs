
namespace DB_WForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThemes = new System.Windows.Forms.DataGridView();
            this.coId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Upd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTheme = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.Button_Find = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDelete = new System.Windows.Forms.TextBox();
            this.LbThemes = new System.Windows.Forms.ListBox();
            this.BtnThemes = new System.Windows.Forms.Button();
            this.LbToString = new System.Windows.Forms.ListBox();
            this.BtnShowToString = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThemes
            // 
            this.dgvThemes.AllowUserToAddRows = false;
            this.dgvThemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coId,
            this.coName});
            this.dgvThemes.Location = new System.Drawing.Point(2, 1);
            this.dgvThemes.Name = "dgvThemes";
            this.dgvThemes.Size = new System.Drawing.Size(617, 353);
            this.dgvThemes.TabIndex = 0;
            this.dgvThemes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // coId
            // 
            this.coId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coId.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coId.DefaultCellStyle = dataGridViewCellStyle1;
            this.coId.HeaderText = "Id";
            this.coId.Name = "coId";
            this.coId.ReadOnly = true;
            this.coId.Visible = false;
            // 
            // coName
            // 
            this.coName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coName.DataPropertyName = "Name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coName.DefaultCellStyle = dataGridViewCellStyle2;
            this.coName.HeaderText = "Name";
            this.coName.Name = "coName";
            // 
            // Button_Upd
            // 
            this.Button_Upd.Location = new System.Drawing.Point(25, 375);
            this.Button_Upd.Name = "Button_Upd";
            this.Button_Upd.Size = new System.Drawing.Size(75, 23);
            this.Button_Upd.TabIndex = 1;
            this.Button_Upd.Text = "Update";
            this.Button_Upd.UseVisualStyleBackColor = true;
            this.Button_Upd.Click += new System.EventHandler(this.Button_Upd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Theme";
            // 
            // txbTheme
            // 
            this.txbTheme.Location = new System.Drawing.Point(220, 375);
            this.txbTheme.Name = "txbTheme";
            this.txbTheme.Size = new System.Drawing.Size(199, 20);
            this.txbTheme.TabIndex = 3;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(451, 372);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 4;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(95, 412);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(131, 20);
            this.txbSearch.TabIndex = 6;
            // 
            // Button_Find
            // 
            this.Button_Find.Location = new System.Drawing.Point(245, 412);
            this.Button_Find.Name = "Button_Find";
            this.Button_Find.Size = new System.Drawing.Size(75, 23);
            this.Button_Find.TabIndex = 7;
            this.Button_Find.Text = "Find";
            this.Button_Find.UseVisualStyleBackColor = true;
            this.Button_Find.Click += new System.EventHandler(this.Button_Find_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(451, 450);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 8;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Delete";
            // 
            // txbDelete
            // 
            this.txbDelete.Location = new System.Drawing.Point(245, 455);
            this.txbDelete.Name = "txbDelete";
            this.txbDelete.Size = new System.Drawing.Size(174, 20);
            this.txbDelete.TabIndex = 10;
            // 
            // LbThemes
            // 
            this.LbThemes.FormattingEnabled = true;
            this.LbThemes.Location = new System.Drawing.Point(634, 1);
            this.LbThemes.Name = "LbThemes";
            this.LbThemes.Size = new System.Drawing.Size(232, 82);
            this.LbThemes.TabIndex = 11;
            // 
            // BtnThemes
            // 
            this.BtnThemes.Location = new System.Drawing.Point(705, 89);
            this.BtnThemes.Name = "BtnThemes";
            this.BtnThemes.Size = new System.Drawing.Size(75, 23);
            this.BtnThemes.TabIndex = 12;
            this.BtnThemes.Text = "Show";
            this.BtnThemes.UseVisualStyleBackColor = true;
            this.BtnThemes.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbToString
            // 
            this.LbToString.FormattingEnabled = true;
            this.LbToString.Location = new System.Drawing.Point(634, 147);
            this.LbToString.Name = "LbToString";
            this.LbToString.Size = new System.Drawing.Size(232, 95);
            this.LbToString.TabIndex = 13;
            // 
            // BtnShowToString
            // 
            this.BtnShowToString.Location = new System.Drawing.Point(705, 259);
            this.BtnShowToString.Name = "BtnShowToString";
            this.BtnShowToString.Size = new System.Drawing.Size(75, 23);
            this.BtnShowToString.TabIndex = 14;
            this.BtnShowToString.Text = "Show";
            this.BtnShowToString.UseVisualStyleBackColor = true;
            this.BtnShowToString.Click += new System.EventHandler(this.BtnShowToString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 488);
            this.Controls.Add(this.BtnShowToString);
            this.Controls.Add(this.LbToString);
            this.Controls.Add(this.BtnThemes);
            this.Controls.Add(this.LbThemes);
            this.Controls.Add(this.txbDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Find);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.txbTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Upd);
            this.Controls.Add(this.dgvThemes);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThemes;
        private System.Windows.Forms.Button Button_Upd;
        private System.Windows.Forms.DataGridViewTextBoxColumn coId;
        private System.Windows.Forms.DataGridViewTextBoxColumn coName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTheme;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button Button_Find;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDelete;
        private System.Windows.Forms.ListBox LbThemes;
        private System.Windows.Forms.Button BtnThemes;
        private System.Windows.Forms.ListBox LbToString;
        private System.Windows.Forms.Button BtnShowToString;
    }
}

