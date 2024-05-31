
namespace WindowsFormsBasicsSecond
{
    partial class Labirint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Labirint));
            this.SMILE = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SMILE)).BeginInit();
            this.SuspendLayout();
            // 
            // SMILE
            // 
            this.SMILE.Image = ((System.Drawing.Image)(resources.GetObject("SMILE.Image")));
            this.SMILE.Location = new System.Drawing.Point(593, 403);
            this.SMILE.Name = "SMILE";
            this.SMILE.Size = new System.Drawing.Size(34, 31);
            this.SMILE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SMILE.TabIndex = 0;
            this.SMILE.TabStop = false;
            this.SMILE.Click += new System.EventHandler(this.SMILE_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Labirint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(639, 497);
            this.Controls.Add(this.SMILE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Labirint";
            this.Text = "미로";
            this.Load += new System.EventHandler(this.Labirint_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Labirint_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Labirint_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Labirint_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.SMILE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SMILE;
        private System.Windows.Forms.Timer timer1;
    }
}