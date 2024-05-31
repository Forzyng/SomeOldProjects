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
using System.Threading;

namespace CS_Lan_PR_2
{
    public partial class Form1 : Form
    {
        
        Button[] buttons;
        TcpConnection client;
        public Form1()
        {
            InitializeComponent();
            client = null;
            groupBox2.Enabled = false;
            btn_disc.Enabled = false;
   
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (var b in buttons)
            {
                b.TabStop = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string answer = string.Empty;
            bool win = false;



            ///
            var button = sender as Button;
            if (button == null)
            {
                return;
            }


            button.Text = "X";

            LabelToChange.Text = "O";
            SEND_ANSWER(button);



            button.Enabled = false;
            if (FullCheck())
            {
                btn_disc_Click(sender, e);
                return;
            }

            foreach (var b in buttons)
            {
                if (b.Enabled == true)
                {
                    win = false;
                    break;
                }
                else
                {
                    if (b.Enabled == false)
                    {
                        win = true;
                    }
                }
            }
            if (win == true)
            {
                MessageBox.Show("TIE");
                btn_disc_Click(sender, e);
                return;
            }
            //Thread.Sleep(10000);
            answer = client.Read();

            CHECK_ANSWER(answer);
            if (FullCheck())
            {
                btn_disc_Click(sender, e);
                return;
            }




        }

        private void SEND_ANSWER(Button button)
        {
            if(button == button1)
            {
                client.Send("1-1");
            }
            if (button == button2)
            {
                client.Send("1-2");
            }
            if (button == button3)
            {
                client.Send("1-3");
            }
            if (button == button4)
            {
                client.Send("2-1");
            }
            if (button == button5)
            {
                client.Send("2-2");
            }
            if (button == button6)
            {
                client.Send("2-3");
            }
            if (button == button7)
            {
                client.Send("3-1");
            }
            if (button == button8)
            {
                client.Send("3-2");
            }
            if (button == button9)
            {
                client.Send("3-3");
            }



        }
            private void CHECK_ANSWER(string answer)
        {

            if(answer.Contains("1-1"))
            {
                button1.Enabled = false;
                button1.Text = "0";
               
                LabelToChange.Text = "X";
            }
            if (answer.Contains("1-2"))
            {
                button2.Enabled = false;
                button2.Text = "0";
                
                LabelToChange.Text = "X";
            }
            if (answer.Contains("1-3"))
            {
                button3.Enabled = false;
                button3.Text = "0";
                
                LabelToChange.Text = "X";
            }
            if (answer.Contains("2-1"))
            {
                button4.Enabled = false;
                button4.Text = "0";
               
                LabelToChange.Text = "X";
            }
            if (answer.Contains("2-2"))
            {
                button5.Enabled = false;
                button5.Text = "0";
                
                LabelToChange.Text = "X";
            }
            if (answer.Contains("2-3"))
            {
                button6.Enabled = false;
                button6.Text = "0";
               
                LabelToChange.Text = "X";
            }
            if (answer.Contains("3-1"))
            {
                button7.Enabled = false;
                button7.Text = "0";
                
                LabelToChange.Text = "X";
            }
            if (answer.Contains("3-2"))
            {
                button8.Enabled = false;
                button8.Text = "0";
                
                LabelToChange.Text = "X";
            }
            if (answer.Contains("3-3"))
            {
                button9.Enabled = false;
                button9.Text = "0";
               
                LabelToChange.Text = "X";
            }
   
            
               
                
            

        }

        private bool FullCheck()
        {
            if( button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||

                button1.Text == "X" && button4.Text == "X" && button7.Text == "X"||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button8.Text == "X"||

                button1.Text == "X" && button5.Text == "X" && button9.Text == "X"||
                 button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                
                MessageBox.Show("U WIN!");
                return true;
            }
            if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
               button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
               button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                                                                              
               button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
               button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
               button3.Text == "O" && button6.Text == "O" && button8.Text == "O" ||
                                                                              
               button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
               button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("U LOSE!");
                return true;
            }
            return false;
        }
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Ip.Text))
            {
                return;
            }
            try
            {
                client = new TcpConnection(txb_Ip.Text, (int)nud_port.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (client.Connect())
            {
                groupBox1.Enabled = false;
                btn_Connect.Enabled = false;
                btn_disc.Enabled = true;
                groupBox2.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void btn_disc_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Disconnect();
                groupBox1.Enabled = true;
                btn_Connect.Enabled = true;
                btn_disc.Enabled = false;
                groupBox2.Enabled = false;

                button1.Enabled = true;
                button1.Text = null;

                button2.Enabled = true;
                button2.Text = null;

                button3.Enabled = true;
                button3.Text = null;

                button4.Enabled = true;
                button4.Text = null;

                button5.Enabled = true;
                button5.Text = null;

                button6.Enabled = true;
                button6.Text = null;

                button7.Enabled = true;
                button7.Text = null;

                button8.Enabled = true;
                button8.Text = null;

                button9.Enabled = true;
                button9.Text = null;
            }
        }
    }
}
