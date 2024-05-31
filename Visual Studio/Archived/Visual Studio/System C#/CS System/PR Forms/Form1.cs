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

namespace PR_Forms
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Btn_Get_Click(object sender, EventArgs e)
        {
            
            Btn_Get.Enabled = false;

            RandomNumbers[] readers = new RandomNumbers[10];
            for (int i = 0; i < readers.Length; i++)
            {
               
                    readers[i] = new RandomNumbers(i + 1);
                    readers[i].ReaderMessage += Form1_ReaderMessage;
                    readers[i].Start();
               
        
            }
         
            

        }

        private void Form1_ReaderMessage(string obj)
        {
            Action a = new Action(() =>
            {
                Lb_Res.Items.Insert(0, obj.ToString());
            }
           );
            if (this.InvokeRequired)
            {
                this.Invoke(a);
                Thread.Sleep(10);
            }
            else
            {
                a();
            }
           
        }
    }
}
