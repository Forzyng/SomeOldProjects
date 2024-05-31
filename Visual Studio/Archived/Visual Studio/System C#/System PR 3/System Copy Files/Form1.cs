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

namespace System_Copy_Files
{
    public partial class Form1 : Form
    {
        char[] glasnie = new char[10] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я'};
       

            char[] soglasnie = new char[21] {'б' , 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'};
        int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public Form1()
        {
            InitializeComponent();

        }

        private void Btn_Count_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txb_Enter_Words.Text))
            {
                return;
            }
            Btn_Count.Enabled = false;
            Thread thread = new Thread(RunCounterInThread);
            thread.Start(new ArrayList { lb_res, txb_Enter_Words.Text});
            Btn_Count.Enabled = true;
        }

        private void RunCounterInThread(object obc)
        {
            ArrayList list = obc as ArrayList;
            ListBox listbox = list[0] as ListBox;
            string WORDS = list[1] as string;
            bool checkglas = false;

            int countglas = 0;
            int countsoglas = 0;
            int countnumbers = 0;
            int countsymbols = 0;
            int countprobel = 0 ;
            for (int i = 0; i < WORDS.Length; i++)
            {
                for (int j = 0; j < glasnie.Length; j++)
                {
                    if (WORDS[i].ToString() == " ")
                    {
                        countprobel++;
                        checkglas = true;
                        break;
                    }

                    else
                    {
                        if (glasnie[j].ToString() == WORDS[i].ToString().ToLower())
                        {
                            countglas++;
                            checkglas = true;
                            break;
                        }



                    }
                }

                if (!checkglas)
                {
                    for (int j = 0; j < soglasnie.Length; j++)
                    {
                        if (soglasnie[j].ToString() == WORDS[i].ToString().ToLower())
                        {
                            countsoglas++;
                            checkglas = true;
                            break;
                        }
                    }
                }
                if (!checkglas)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (WORDS[i].ToString() == numbers[j].ToString())
                        {
                            countnumbers++;
                            checkglas = true;
                            break;
                        }
                    }
                }




                if (!checkglas)
                {

                    countsymbols++;
                }
                checkglas = false;
            }
           // MessageBox.Show($"Не согласных: {countglas}\nСогласных: {countsoglas}");
            Action a = new Action(() =>
            {
                listbox.Items.Insert(0, $"Пробелов: {countprobel}");
                listbox.Items.Insert(0, $"Символов: {countsymbols}"); 
                listbox.Items.Insert(0, $"Цифр: {countnumbers}");
                listbox.Items.Insert(0, $"Не согласных: {countglas}");
                listbox.Items.Insert(0, $"Согласных: {countsoglas}");
            }
            );
           if(this.InvokeRequired)
            {
                this.Invoke(a);
                Thread.Sleep(10);
            }
            else
            {
                a();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
