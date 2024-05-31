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

namespace System_PR_3
{
    public partial class Form1 : Form
    {
        public string Password;
        public Thread thread;
        public Thread thread1;
        public Thread thread2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if(thread != null)
            {
                thread.Start(progressBarGen);
              
            }
            if (thread1 != null)
            {
                thread1.Start(progressBarGen);


            }
            if (thread2 != null)
            {
                thread2.Start(progressBarGen);

            }
            textBox1.Text = Password;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           thread = new Thread(RunInThreadText);
            //thread.Start(new ArrayList { pb1, btn_Start });
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            thread1 = new Thread(RunInThreadNumbers);
            
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            thread2 = new Thread(RunInThreadSymbols);
          
         
        }


        private void RunInThreadText(object obc)
        {

            Random rand = new Random();
            try
            {
                ProgressBar bar = obc as ProgressBar;


                Action action = () =>
                {
                    bar.Increment(5);
                };

                while (bar.Value < bar.Maximum)
                {
                    if (InvokeRequired)
                    {
                        Thread.Sleep(100);
                        Password += (char)rand.Next(65, 127);
                        Invoke(action);
                    }
                    else
                    {
                        action();
                        Thread.Sleep(100);
                    }
                }



                Thread.Sleep(2000);

                MessageBox.Show(Password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void RunInThreadNumbers(object obc)
        {

            Random rand = new Random();
            try
            {
                ProgressBar bar = obc as ProgressBar;


                Action action = () =>
                {
                    bar.Increment(5);
                };

                while (bar.Value < bar.Maximum)
                {
                    if (InvokeRequired)
                    {
                        Thread.Sleep(100);
                        Password += rand.Next(0, 10);
                        Invoke(action);
                    }
                    else
                    {
                        action();
                        Thread.Sleep(100);
                    }
                }





                //MessageBox.Show("100%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RunInThreadSymbols(object obc)
        {

            Random rand = new Random();
            try
            {
                ProgressBar bar = obc as ProgressBar;


                Action action = () =>
                {
                    bar.Increment(5);
                };

                while (bar.Value < bar.Maximum)
                {
                    if (InvokeRequired)
                    {
                        Thread.Sleep(100);
                        Password += (char)rand.Next(0, 256);
                        Invoke(action);
                    }
                    else
                    {
                        action();
                        Thread.Sleep(100);
                    }
                }




                
                //MessageBox.Show("100%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
