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

namespace CS_Lan_Form_Send_File
{
    
    public partial class Form1 : Form
    {
        private TcpListener server;
        public Form1()
        {
            InitializeComponent();
            server = null;
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(server != null)
            {
                server.Stop();
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            if(dlg_Open.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            txb_file.Text = dlg_Open.FileName;
            grb_Connection.Enabled = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Stop.Enabled = true;
                btn_start.Enabled = false;
                btn_Select.Enabled = false;
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(txb_address.Text), (int)nud_Port.Value);
                server = new TcpListener(endpoint);
                server.Start(10);
                server.BeginAcceptTcpClient(Accept_Connection, server);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Accept_Connection(IAsyncResult result)
        {

            Show_Message("Server wait");
            TcpListener tcp = result.AsyncState as TcpListener;
            TcpClient client = tcp.EndAcceptTcpClient(result);
            try
            {

                NetworkStream ns = client.GetStream();
            string filename = Path.GetFileName(txb_file.Text);
            byte[] buf = Encoding.UTF8.GetBytes(filename);

            ns.Write(buf, 0, buf.Length);

            StringBuilder sb = new StringBuilder();
            buf = new byte[128];
            int len;
            do
            {
               len = ns.Read(buf, 0, buf.Length);
                sb.Append(Encoding.UTF8.GetString(buf, 0, len));
            } while (ns.DataAvailable);
            Show_Message("Send filename");
            if(sb.ToString().Equals("/get"))
            {
                using(var fs = new FileStream(txb_file.Text,FileMode.Open, FileAccess.Read))
                {
                    

                    buf = new byte[fs.Length];
                    fs.Read(buf, 0, (int)fs.Length);
                    ns.Write(buf, 0, buf.Length);
                }
            }
            Show_Message("End Send filename");
            do
            {
                len = ns.Read(buf, 0, buf.Length);
                sb.Append(Encoding.UTF8.GetString(buf, 0, len));
            } while (ns.DataAvailable);

            Show_Message("Accept Message" + sb);

            ns.Close();
            client.Close();

            Show_Message("Waiting connection");
                tcp.BeginAcceptTcpClient(Accept_Connection, tcp);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
            
        }
       private void Show_Message(string message)
        {
            Action a = () =>
           {
               lb_Messages.Items.Insert(0, message);
           };
            if(InvokeRequired)
            {
                Invoke(a);
            }
            else
            {
                a();
            }

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                server.Stop();
                server = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btn_start.Enabled = true;
                btn_Stop.Enabled = false;
                grb_Connection.Enabled = false;
                btn_Select.Enabled = true;
            }
        }
    }
}
