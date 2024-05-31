using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace WFRegistryTest
{
    public partial class RegistryTestForm : Form
    {
        public RegistryTestForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                edPath.Text = dlgOpen.FileName;
                if (string.IsNullOrWhiteSpace(edName.Text))
                    edName.Text = Path.GetFileName(edPath.Text);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edName.Text) || string.IsNullOrWhiteSpace(edPath.Text))
                return;

            RegistryKey lm = Registry.CurrentUser;
            try
            {
                RegistryKey run = lm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
                run.SetValue(edName.Text, edPath.Text);
                run.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edName.Text))
                return;

            RegistryKey lm = Registry.CurrentUser;
            try
            {
                RegistryKey run = lm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
                run.DeleteValue(edName.Text);
                run.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
