using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace System_Timer_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            lb_res.BeginUpdate();
            int f1 = 0;
            int f2 = 1;
            int t;
            for (int i = 2; i < 25; i++)
            {
                lb_res.Items.Insert(0, $"Id => {Thread.CurrentThread.ManagedThreadId} | Fibo = {f2}");
                t = f2;
                f2 += f1;
                f1 = t;
                Thread.Sleep(50);
            }
            lb_res.EndUpdate();
            Timer.Start();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if(Btn_Start.Text.Equals("Start"))
            {
                Timer.Start();
                Btn_Start.Text = "Stop";
            }
            else
            {
                Timer.Stop();
                Btn_Start.Text = "Start";
            }
        }
    }
}
