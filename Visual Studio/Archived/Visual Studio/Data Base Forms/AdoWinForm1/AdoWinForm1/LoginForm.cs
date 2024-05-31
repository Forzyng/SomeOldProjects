using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoWinForm1
{
    public partial class LoginForm : Form
    {
        private SqlConnectionStringBuilder sqlConnectionString;
        public SqlConnectionStringBuilder SqlConnectionString => sqlConnectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = !rbWindows.Checked;
        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = rbSQL.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnectionString = new SqlConnectionStringBuilder()
            {
                DataSource = txbServer.Text,
                AttachDBFilename = txbDatabase.Text,
                IntegratedSecurity = rbWindows.Checked/*,
                UserID = txbUser.Text,
                Password = txbPassword.Text*/
            };
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txbServer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
