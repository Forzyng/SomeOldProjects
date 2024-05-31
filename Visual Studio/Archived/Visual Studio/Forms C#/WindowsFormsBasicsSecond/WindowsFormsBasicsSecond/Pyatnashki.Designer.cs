
namespace WindowsFormsBasicsSecond
{
    partial class Pyatnashki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pyatnashki));
            this.PanelField = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelField
            // 
            this.PanelField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelField.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PanelField.Location = new System.Drawing.Point(25, 22);
            this.PanelField.Name = "PanelField";
            this.PanelField.Size = new System.Drawing.Size(430, 436);
            this.PanelField.TabIndex = 0;
            this.PanelField.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelField_Paint);
            // 
            // Pyatnashki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(489, 470);
            this.Controls.Add(this.PanelField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Pyatnashki";
            this.Text = "Pyatnashki";
            this.Load += new System.EventHandler(this.Pyatnashki_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelField;
    }
}