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

namespace CS_Lan_Tcp_Client_Forms
{
    public partial class Form1 : Form
    {
        Tcp_Connect client;
        public Form1()
        {
            InitializeComponent();
            client = null;
            groupBox2.Enabled = false;
            btn_disc.Enabled = false;
            button1.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Ip.Text))
            {
                return;
            }
            try
            {
                client = new Tcp_Connect(txb_Ip.Text, (int)nud_port.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (client.Connect())
            {
                groupBox1.Enabled = false;
                btn_Connect.Enabled = false;
                btn_disc.Enabled = true;
                groupBox2.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void btn_disc_Click(object sender, EventArgs e)
        {
            if(client != null)
            {
                client.Disconnect();
                groupBox1.Enabled = true;
                btn_Connect.Enabled = true;
                btn_disc.Enabled = false;
                groupBox2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txb_send.Text))
            {
                return;
            }
            client.Send(txb_send.Text);
            //lb_Messages.Items.Insert(0, txb_send.Text);

            string answer = client.Read();
            lb_Messages.Items.Insert(0, answer);
            if(answer.Contains("YOU WON"))
            {
                MessageBox.Show("YOU WON");
                client.Disconnect();
                groupBox1.Enabled = true;
                btn_Connect.Enabled = true;
                btn_disc.Enabled = false;
                groupBox2.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                if (answer.Contains("YOU LOSE"))
                {
                    MessageBox.Show("YOU LOSE");
                    client.Disconnect();
                    groupBox1.Enabled = true;
                    btn_Connect.Enabled = true;
                    btn_disc.Enabled = false;
                    groupBox2.Enabled = false;
                    button1.Enabled = false;
                }
            }
            
        }
    }
}
