using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Registry_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if(dlgOpen.ShowDialog() != DialogResult.OK)
            {
                txb_Name.Text = dlgOpen.FileName;
                if(!string.IsNullOrWhiteSpace(txb_Name.Text))
                {
                    txb_app.Text = Path.GetDirectoryName(txb_Name.Text);
                }
            }
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            ///RegistryKey
        }
    }
}
