
namespace WindowsFormsBasicsSecond
{
    partial class Events2
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
            this.SuspendLayout();
            // 
            // Events2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Events2";
            this.Text = "Events2";
            this.Load += new System.EventHandler(this.Events2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Events2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Events2_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Events2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Events2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Events2_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}