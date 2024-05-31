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
using System.Collections;

namespace Multithreading_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            pb1.Value = 0;
            Thread thread = new Thread(RunInThread);
            //thread.Start(new ArrayList { pb1, btn_Start });
            thread.Start(pb1);
        }

        private void RunInThread(object obc)
        {


            try
            {


                #region 1.0


                ArrayList list = obc as ArrayList;
                ProgressBar bar = list[0] as ProgressBar;
                Button button = list[1] as Button;

                Action action = () =>
                {
                    button.Enabled = false;
                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }

                action = () =>
                {
                    bar.Increment(1);
                };

                while (bar.Value < bar.Maximum)
                {
                    if (InvokeRequired)
                    {
                        Thread.Sleep(100);
                        Invoke(action);
                    }
                    else
                    {
                        action();
                        Thread.Sleep(100);
                    }
                }

                action = () =>
                {
                    button.Enabled = true;
                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }
                #endregion

                #region 2.0

                #endregion


                //MessageBox.Show("100%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_start2_Click(object sender, EventArgs e)
        {
            pb2.Value = 0;
            Thread thread = new Thread(RunInThread);
            thread.Start(new ArrayList { pb2, Btn_start2 });
        }

        private void Btn_Start3_Click(object sender, EventArgs e)
        {
            pb3.Value = 0;
            Thread thread = new Thread(RunInThread);
            thread.Start(new ArrayList { pb3, Btn_Start3 });
        }
    }
}
