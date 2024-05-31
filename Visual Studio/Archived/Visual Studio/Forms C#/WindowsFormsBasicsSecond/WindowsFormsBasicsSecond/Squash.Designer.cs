
namespace WindowsFormsBasicsSecond
{
    partial class Squash
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Squash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Squash";
            this.Text = "Squash";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Squash_FormClosed);
            this.Load += new System.EventHandler(this.Squash_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Squash_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Squash_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Squash_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Squash_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}