
namespace WindowsFormsBasicsSecond
{
    partial class GDI
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
            this.ButtonBlack = new System.Windows.Forms.Button();
            this.ButtonGreen = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ButtonBlack
            // 
            this.ButtonBlack.Location = new System.Drawing.Point(38, 12);
            this.ButtonBlack.Name = "ButtonBlack";
            this.ButtonBlack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBlack.TabIndex = 0;
            this.ButtonBlack.Text = "Black";
            this.ButtonBlack.UseVisualStyleBackColor = true;
            this.ButtonBlack.Click += new System.EventHandler(this.ButtonBlack_Click);
            // 
            // ButtonGreen
            // 
            this.ButtonGreen.Location = new System.Drawing.Point(38, 50);
            this.ButtonGreen.Name = "ButtonGreen";
            this.ButtonGreen.Size = new System.Drawing.Size(75, 23);
            this.ButtonGreen.TabIndex = 1;
            this.ButtonGreen.Text = "Green";
            this.ButtonGreen.UseVisualStyleBackColor = true;
            this.ButtonGreen.Click += new System.EventHandler(this.ButtonGreen_Click);
            this.ButtonGreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonGreen_KeyDown);
            this.ButtonGreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ButtonGreen_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(38, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 24);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(132, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 61);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // GDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonGreen);
            this.Controls.Add(this.ButtonBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "GDI";
            this.Text = "GDI";
            this.Load += new System.EventHandler(this.GDI_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GDI_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GDI_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GDI_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GDI_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GDI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GDI_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GDI_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonBlack;
        private System.Windows.Forms.Button ButtonGreen;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}