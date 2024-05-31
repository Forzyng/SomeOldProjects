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

namespace CS_Lan_Form_Receive_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if(dlg_Folder.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            txb_select.Text = dlg_Folder.SelectedPath;
            grb_Connection.Enabled = true;
            btn_select.Enabled = false;
        }

        private void btn_Receive_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(txb_address.Text), (int)nud_Port.Value);
                TcpClient client = new TcpClient();
                client.Connect(endpoint);

                Show_Message("Connect To server...");

                string FileName;
                int len;
                byte[] buf = new byte[1024];
                StringBuilder sb = new StringBuilder();

                NetworkStream ns = client.GetStream();

                do
                {
                    len = ns.Read(buf, 0, buf.Length);
                    sb.Append(Encoding.UTF8.GetString(buf, 0, len));
                } while (ns.DataAvailable);
                FileName = sb.ToString();
                Show_Message("Filename is: " + FileName);
                buf = Encoding.UTF8.GetBytes("/get");
                ns.Write(buf, 0, buf.Length);
                FileName = txb_select.Text + "\\" + FileName;
                using(var fs = new FileStream(FileName,FileMode.Create, FileAccess.Write))
                {
                    buf = new byte[1024];
                    Show_Message("Start Receiving file");
                    do
                    {
                        len = ns.Read(buf, 0, buf.Length);
                        fs.Write(buf, 0, len);
                    } while (ns.DataAvailable);
                    Show_Message("End Receiving file");
                }

                buf = Encoding.UTF8.GetBytes("OK");
                ns.Write(buf, 0, buf.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Show_Message(string message)
        {
            Action a = () =>
            {
                lb_Messages.Items.Insert(0, message);
            };
            if (InvokeRequired)
            {
                Invoke(a);
            }
            else
            {
                a();
            }

        }
    }
}
