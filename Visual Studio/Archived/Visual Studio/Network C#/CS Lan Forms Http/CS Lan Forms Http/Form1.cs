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

namespace CS_Lan_Forms_Http
{
    public partial class Form1 : Form
    {
        HttpWebRequest Request;
        HttpWebResponse Response;
        public Form1()
        {
            InitializeComponent();
            Request = null;
            Response = null;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_load.Text))
            {
                MessageBox.Show("АДРЕС ВВЕДИ");
                txb_load.Focus();
                return;
            }

            try
            {


                Request = HttpWebRequest.CreateHttp(txb_load.Text);

                Request.CookieContainer = new CookieContainer();

                Response = (HttpWebResponse)Request.GetResponse();


                //Request.CookieContainer.Add(new Cookie("LastConnectionDate", "09.09.2021"));

                foreach (var h in Response.Headers)
                {
                    listBox1.Items.Add(h.ToString());
                }
              //  listBox1.Items.Clear();

                listBox1.Items.Add("");
                listBox1.Items.Add("====================================================");
                listBox1.Items.Add("Cookie");
                listBox1.Items.Add("====================================================");

                foreach (Cookie c in Response.Cookies)
                {
                    listBox1.Items.Add($"{c.Name} : {c.Value}");
                }

                StreamReader reader = new StreamReader(Response.GetResponseStream());
                txb_show.Text = reader.ReadToEnd();

                reader.Close();
                Response.Close();

                //ServicePointManager.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txb_show_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
