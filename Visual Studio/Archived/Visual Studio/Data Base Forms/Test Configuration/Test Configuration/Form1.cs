using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace Test_Configuration
{
    public partial class Main_Form : Form
    {
        DbProviderFactory factory = null;
        DbConnection connection = null;
        DbDataAdapter adapter = null;
        DbCommand command = null;
        public Main_Form()
        {
            InitializeComponent();
            cbConnection.SelectedIndexChanged += cbConnection_SelectedIndexChanged;
            //DataTable table = DbProviderFactories.GetFactoryClasses();
        }

        private void Button_Show_Conn_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settingsCollection = ConfigurationManager.ConnectionStrings;
            cbConnection.Items.Clear();
            cbConnection.DisplayMember = "Name";
            cbConnection.ValueMember = "ConnectionString";
            //cbConnection.DataSource = settingsCollection;
            foreach (ConnectionStringSettings item in settingsCollection)
            {
                cbConnection.Items.Add(item);
            }
        }

        private void cbConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbConnection.SelectedIndex == ListBox.NoMatches)
            {
                return;
            }
            //txbConnectionString.Text = cbConnection.SelectedValue.ToString();
            ConnectionStringSettings settings = cbConnection.SelectedItem as ConnectionStringSettings;
            if(settings != null)
            {
                txbConnectionString.Text = settings.ConnectionString;
            }
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbConnectionString.Text))
            {
                return;
            }
            try
            {
                ConnectionStringSettings settings = cbConnection.SelectedItem as ConnectionStringSettings;
                if (settings != null)
                {
                    factory = DbProviderFactories.GetFactory(settings.ProviderName);
                    connection = factory.CreateConnection();
                    connection.ConnectionString = settings.ConnectionString;

                    Button_Exec.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Exec_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txbConnectionString.Text) || connection == null)
            {
                return;
            }
                connection.Open();
                
                adapter = factory.CreateDataAdapter();
                
                adapter.SelectCommand = factory.CreateCommand();
                adapter.SelectCommand.CommandText = SQLQuery.Text;
                adapter.SelectCommand.Connection = connection;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            command = connection.CreateCommand();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            if(string.IsNullOrWhiteSpace(textBox4.Text))
            {
                return;
            }

           

            // Create the InsertCommand.
            command.CommandText =
                    $"INSERT INTO Countries  VALUES (NEWID(),{textBox4.Text})";


            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            textBox4.Text = null;

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            // Create the DeleteCommand.
            command.CommandText =
                $"DELETE FROM Countries WHERE Name = '{dataGridView1.CurrentCell.Value}' OR Id = '{dataGridView1.CurrentCell.Value}'";


            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            textBox4.Text = null;
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            // Create the UpdateCommand.
            command.CommandText =
                $"UPDATE Countries SET Name = {textBox4.Text} " +
                $"WHERE  Name = '{dataGridView1.CurrentCell.Value}' OR Id = '{dataGridView1.CurrentCell.Value}'";


            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            textBox4.Text = null;
        }
    }
}
