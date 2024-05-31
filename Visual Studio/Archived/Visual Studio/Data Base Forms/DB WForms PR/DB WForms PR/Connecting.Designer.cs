
namespace DB_WForms_PR
{
    partial class Connecting
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
            this.Button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.txbDB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(27, 114);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(116, 23);
            this.Button_Connect.TabIndex = 0;
            this.Button_Connect.Text = "Connect To local DB";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Base";
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(104, 27);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(247, 20);
            this.txbServer.TabIndex = 3;
            this.txbServer.Text = "(LocalDB)\\MSSQLLocalDB";
            // 
            // txbDB
            // 
            this.txbDB.Location = new System.Drawing.Point(104, 66);
            this.txbDB.Name = "txbDB";
            this.txbDB.Size = new System.Drawing.Size(247, 20);
            this.txbDB.TabIndex = 4;
            this.txbDB.Text = "D:\\Programming\\Visual Studio\\Data Base Forms\\DB WForms PR\\DB WForms PR\\Countries." +
    "mdf";
            // 
            // Connecting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 160);
            this.Controls.Add(this.txbDB);
            this.Controls.Add(this.txbServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Connect);
            this.Name = "Connecting";
            this.Text = "Connecting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.TextBox txbDB;
    }
}