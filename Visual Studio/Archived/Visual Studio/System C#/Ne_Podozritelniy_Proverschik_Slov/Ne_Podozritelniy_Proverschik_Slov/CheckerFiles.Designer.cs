
namespace Ne_Podozritelniy_Proverschik_Slov
{
    partial class CheckerFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckerFiles));
            this.Lb_Banned_Words = new System.Windows.Forms.ListBox();
            this.mb_Save_Words = new MetroFramework.Controls.MetroButton();
            this.mb_Load_Words = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mb_Save_Logs = new MetroFramework.Controls.MetroButton();
            this.lab_Error = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.mb_Load_File = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Lb_All = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.FBD_Path = new System.Windows.Forms.FolderBrowserDialog();
            this.FBD_Logs = new System.Windows.Forms.FolderBrowserDialog();
            this.FBD_Save = new System.Windows.Forms.FolderBrowserDialog();
            this.OFD_Load_Words = new System.Windows.Forms.OpenFileDialog();
            this.OFD_Open_File = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Banned_Words
            // 
            this.Lb_Banned_Words.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_Banned_Words.FormattingEnabled = true;
            this.Lb_Banned_Words.ItemHeight = 18;
            this.Lb_Banned_Words.Location = new System.Drawing.Point(564, 58);
            this.Lb_Banned_Words.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Lb_Banned_Words.Name = "Lb_Banned_Words";
            this.Lb_Banned_Words.Size = new System.Drawing.Size(197, 238);
            this.Lb_Banned_Words.TabIndex = 0;
            // 
            // mb_Save_Words
            // 
            this.mb_Save_Words.Location = new System.Drawing.Point(7, 30);
            this.mb_Save_Words.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mb_Save_Words.Name = "mb_Save_Words";
            this.mb_Save_Words.Size = new System.Drawing.Size(83, 35);
            this.mb_Save_Words.TabIndex = 2;
            this.mb_Save_Words.Text = "Save Words";
            this.mb_Save_Words.Click += new System.EventHandler(this.mb_Save_Words_Click);
            // 
            // mb_Load_Words
            // 
            this.mb_Load_Words.Location = new System.Drawing.Point(7, 71);
            this.mb_Load_Words.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mb_Load_Words.Name = "mb_Load_Words";
            this.mb_Load_Words.Size = new System.Drawing.Size(83, 35);
            this.mb_Load_Words.TabIndex = 3;
            this.mb_Load_Words.Text = "Load Words";
            this.mb_Load_Words.Click += new System.EventHandler(this.mb_Load_Words_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.mb_Save_Logs);
            this.metroPanel1.Controls.Add(this.lab_Error);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.mb_Load_File);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.mb_Load_Words);
            this.metroPanel1.Controls.Add(this.mb_Save_Words);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(6, 58);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(118, 238);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mb_Save_Logs
            // 
            this.mb_Save_Logs.Location = new System.Drawing.Point(7, 153);
            this.mb_Save_Logs.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mb_Save_Logs.Name = "mb_Save_Logs";
            this.mb_Save_Logs.Size = new System.Drawing.Size(83, 35);
            this.mb_Save_Logs.TabIndex = 10;
            this.mb_Save_Logs.Text = "Save Logs";
            this.mb_Save_Logs.Click += new System.EventHandler(this.mb_Save_Logs_Click);
            // 
            // lab_Error
            // 
            this.lab_Error.AutoSize = true;
            this.lab_Error.CustomForeColor = true;
            this.lab_Error.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_Error.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lab_Error.ForeColor = System.Drawing.Color.Red;
            this.lab_Error.Location = new System.Drawing.Point(95, 204);
            this.lab_Error.Name = "lab_Error";
            this.lab_Error.Size = new System.Drawing.Size(17, 25);
            this.lab_Error.TabIndex = 9;
            this.lab_Error.Text = "!";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(7, 194);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(83, 35);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Save Path";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // mb_Load_File
            // 
            this.mb_Load_File.Location = new System.Drawing.Point(7, 112);
            this.mb_Load_File.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mb_Load_File.Name = "mb_Load_File";
            this.mb_Load_File.Size = new System.Drawing.Size(83, 35);
            this.mb_Load_File.TabIndex = 6;
            this.mb_Load_File.Text = "Load File";
            this.mb_Load_File.Click += new System.EventHandler(this.mb_Load_File_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(2, 2);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Functions:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(564, 23);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(166, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "List of banned word:";
            // 
            // Lb_All
            // 
            this.Lb_All.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_All.FormattingEnabled = true;
            this.Lb_All.ItemHeight = 18;
            this.Lb_All.Location = new System.Drawing.Point(129, 58);
            this.Lb_All.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Lb_All.Name = "Lb_All";
            this.Lb_All.Size = new System.Drawing.Size(422, 238);
            this.Lb_All.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(129, 23);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Results:";
            // 
            // OFD_Load_Words
            // 
            this.OFD_Load_Words.DefaultExt = "C:\\";
            // 
            // OFD_Open_File
            // 
            this.OFD_Open_File.FileName = "openFileDialog1";
            // 
            // CheckerFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 313);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Lb_All);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Lb_Banned_Words);
            this.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CheckerFiles";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 19);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_Banned_Words;
        private MetroFramework.Controls.MetroButton mb_Save_Words;
        private MetroFramework.Controls.MetroButton mb_Load_Words;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox Lb_All;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton mb_Load_File;
        private MetroFramework.Controls.MetroLabel lab_Error;
        private System.Windows.Forms.FolderBrowserDialog FBD_Path;
        private MetroFramework.Controls.MetroButton mb_Save_Logs;
        private System.Windows.Forms.FolderBrowserDialog FBD_Logs;
        private System.Windows.Forms.FolderBrowserDialog FBD_Save;
        private System.Windows.Forms.OpenFileDialog OFD_Load_Words;
        private System.Windows.Forms.OpenFileDialog OFD_Open_File;
    }
}