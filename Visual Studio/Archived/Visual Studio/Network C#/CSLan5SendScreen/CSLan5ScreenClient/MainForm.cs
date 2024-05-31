using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Drawing;

namespace CSLan5ScreenClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            TcpClient tcp = new TcpClient();
            tcp.Connect(new IPEndPoint(IPAddress.Parse(edAddress.Text), (int)edPort.Value));
            NetworkStream ns= tcp.GetStream();
            pictureBox1.Image = Image.FromStream(ns);
        }
    }
}
