using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace CS_Lan_7_Web_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if(dlg_Save.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                return;
            }
            string FileName = dlg_Save.FileName; ;
            WebClient wc = new WebClient();
            try
            {
                wc.DownloadFile(textBox1.Text, FileName);

                System.Diagnostics.Process.Start(Path.GetDirectoryName(FileName));
                MessageBox.Show("Download complete");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                if(File.Exists(FileName))
                {
                    File.Delete(FileName);
                }
            }
        }
    }
}
