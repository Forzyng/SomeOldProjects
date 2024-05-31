using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace DB_WForms_PR
{
    public partial class Connecting : Form
    {
        
        public string TheValueServer
        {
            get { return txbServer.Text; }
        }

        public string TheValueDB
        {
            get { return txbDB.Text; }
        }

        public Connecting()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbDB.Text) || string.IsNullOrWhiteSpace(txbServer.Text))
            {
                return;
            }
           
            this.Hide();
        }
    }
}
