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
    public partial class MainForm : Form
    {
        //private string connectionString;
        private SqlConnection connection;
        private SqlDataAdapter adapterCountry;
        
        private DataTable dtCountry;

        public MainForm()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            //connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\Visual Studio\Data Base Forms\AdoWinForm1\AdoWinForm1\BookMagazine.mdf;Integrated Security=True;Connect Timeout=30";
            connection = null;
            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null)
                connection.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK)
                return;

            connection = new SqlConnection(login.SqlConnectionString.ConnectionString);
            try
            {
                connection.Open();
                adapterCountry = new SqlDataAdapter("select * from Countries", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapterCountry);
                dtCountry = new DataTable("Countries");
                adapterCountry.Fill(dtCountry);
                dataGridView1.DataSource = dtCountry;
                dataGridView1.Columns["Id"].ReadOnly = true;
                btnConnect.Enabled = false;
                btnUpdate.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adapterCountry.Update(dtCountry);

            dtCountry.Clear();

            adapterCountry.Fill(dtCountry);
            dataGridView1.DataSource = dtCountry;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }

            DataRowCollection itemColumns = dtCountry.Rows;
            itemColumns[dataGridView1.SelectedColumns.Count].Delete();
            //btnUpdate_Click(sender, e);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txb_Red.Text))
            {
                return;
            }

            DataRow row = dtCountry.NewRow();
            row["Id"] = Guid.NewGuid();
            row["Name"] = txb_Red.Text;
            dtCountry.Rows.Add(row);

            //btnUpdate_Click(sender, e);

        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txb_Red.Text))
            {
                return;
            }
            btn_del_Click(sender, e);
            btn_add_Click(sender, e);

            //btnUpdate_Click(sender, e);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
