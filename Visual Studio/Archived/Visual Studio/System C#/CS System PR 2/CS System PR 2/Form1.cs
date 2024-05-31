using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CS_System_PR_2
{
    public partial class Form1 : Form
    {
        //TotalProce
        Process process;
        int tick = 10;
        int tack = 0;
        public Form1()
        {
            InitializeComponent();
            process = new Process();
            dgv_Proc.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
            try
            {
                dgv_Proc.DataSource = Process.GetProcesses();
            }
            catch
            {

            } 
        }


        private void Btn_Kill_Click(object sender, EventArgs e)
        {
            process.Kill();
            btn_Refresh_Click(sender, e);
            Btn_Kill.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tack++;
            if(tack >= tick)
            {
                tack = 0;
                btn_Refresh_Click(sender, e);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //BasePriority HandleCount Id
            if (dgv_Proc.SelectedRows.Count == 0)
            {
                return;
            }
            Btn_Kill.Enabled = true;
            //Я забыл дописать кнопку енейбл

            process = dgv_Proc.SelectedRows[0].DataBoundItem as Process;
            int count = 1;

            //var it = dgv_Proc.DataSource;

            //foreach (var item in dgv_Proc.DataSource)
            //{
            //    if (item.ToString().Equals(process.ProcessName))
            //    {
            //        count++;
            //    }

            //}


            MessageBox.Show($"Id: {process.Id}\nStart Time: {process.StartTime}\nCol-vo time: {process.TotalProcessorTime}\nCount potokov: {process.Threads.Count}\nCol-vo: {count}");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tick = (int)numericUpDown1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                tack = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileName = @"calc.exe";
            Process calc = new Process();
            calc.StartInfo = new ProcessStartInfo(FileName);
            calc.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string FileName = @"mspaint.exe";
            Process pain = new Process();
            pain.StartInfo = new ProcessStartInfo(FileName);
            pain.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FileName = @"notepad.exe";
            Process notepad = new Process();
            notepad.StartInfo = new ProcessStartInfo(FileName);
            notepad.Start();
        }
    }
}
