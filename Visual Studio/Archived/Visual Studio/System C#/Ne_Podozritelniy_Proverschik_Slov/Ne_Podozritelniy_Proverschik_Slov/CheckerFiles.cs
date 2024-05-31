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
using System.IO;

namespace Ne_Podozritelniy_Proverschik_Slov
{
    public partial class CheckerFiles : MetroFramework.Forms.MetroForm
    {
        static string path_to_results = string.Empty;
        static string path_to_save_logs = string.Empty;
        static string path_to_save = string.Empty;
        Thread load_from_words;
        Mutex mutex;
        Dictionary<string, int> Words;
        public CheckerFiles()
        {
            InitializeComponent();
            Words = new Dictionary<string, int>();
            this.StyleManager = StyleManager;
            mutex = new Mutex();
          
            //mb_Load_Directory.Enabled = false;
            mb_Load_File.Enabled = false;
            

            // mb_Save_Logs.Enabled = true;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (FBD_Path.ShowDialog() == DialogResult.OK)
            {
                path_to_results = FBD_Path.SelectedPath;

                //mb_Load_Directory.Enabled = true;
                mb_Load_File.Enabled = true;
                lab_Error.Visible = false;

                Lb_All.Items.Insert(0, $"{DateTime.Now} => Results => Chosen To Save");
            }
           
        }

        private void mb_Save_Logs_Click(object sender, EventArgs e)
        {
            if (FBD_Logs.ShowDialog() == DialogResult.OK)
            {
                path_to_save_logs = FBD_Logs.SelectedPath;

                Lb_All.Items.Insert(0, $"{DateTime.Now} => Logs => Saving");

                try
                {
                    Thread thr = new Thread(SaveLogs);
                    thr.Start(Lb_All);
                }
                catch { }
            }
        }

        private void SaveLogs(object obc)
        {
            mutex.WaitOne();
            ListBox lball = obc as ListBox;

            Action action;
            string text = string.Empty;
            //Lb_All
            try
            {


                if (lball.Items.Count <= 1)
                {
                    //MessageBox.Show("Log Eng not saved");
                    action = () =>
                    {
                        Lb_All.Items.Insert(0, $"{DateTime.Now} => Logs => Not Saved");
                    };
                    if (InvokeRequired)
                    {

                        Invoke(action);
                    }
                    else
                    {
                        action();

                    }


                    // return;
                }
                else
                {
                    using (FileStream fstream = new FileStream($@"{path_to_save_logs}\Words_Logs_{DateTime.Now.ToString("dd-MM-yy_H-mm-ss")}.txt", FileMode.OpenOrCreate))
                    {
                        foreach (string item in Lb_All.Items)
                        {

                            text += item + Environment.NewLine;

                        }
                        byte[] array = System.Text.Encoding.Default.GetBytes(text);

                        fstream.Write(array, 0, array.Length);

                    }

                    action = () =>
                    {
                        Lb_All.Items.Insert(0, $"{DateTime.Now} => Logs => Saved");
                    };
                    if (InvokeRequired)
                    {

                        Invoke(action);
                    }
                    else
                    {
                        action();

                    }

                }
            }
            catch (Exception ex)
            {
                action = () =>
                {
                    Lb_All.Items.Insert(0, $"{DateTime.Now} => Logs => Error: {ex.Message}");
                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }

            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }



        private void mb_Save_Words_Click(object sender, EventArgs e)
        {
            try
            {
               
            
            if (FBD_Save.ShowDialog() == DialogResult.OK)
            {
                path_to_save = FBD_Save.SelectedPath;
                    Thread thr = new Thread(SaveWords);
                    thr.Start(Lb_Banned_Words);
                    // Lb_All.Items.Insert(0, $"{DateTime.Now} => Logs => Chosen To Save");
                }

            }
            catch { }


        }

        private void SaveWords(object obc)
        {
            ListBox lball = obc as ListBox;
            Action action;
            string text = string.Empty;
            mutex.WaitOne();
            try
            {


                if (lball.Items.Count <= 1)
                {
                    //MessageBox.Show("Log Eng not saved");
                    action = () =>
                    {
                        Lb_All.Items.Insert(0, $"{DateTime.Now} => Words => Not Saved");
                    };
                    if (InvokeRequired)
                    {

                        Invoke(action);
                    }
                    else
                    {
                        action();

                    }


                    // return;
                }
                else
                {
                    using (FileStream fstream = new FileStream($@"{path_to_save}\Server_Logs_{DateTime.Now.ToString("dd-MM-yy_H-mm-ss")}.txt", FileMode.OpenOrCreate))
                    {
                        foreach (string item in lball.Items)
                        {

                            text += item + Environment.NewLine;

                        }
                        byte[] array = System.Text.Encoding.Default.GetBytes(text);

                        fstream.Write(array, 0, array.Length);

                    }

                    action = () =>
                    {
                        Lb_All.Items.Insert(0, $"{DateTime.Now} => Words => Saved");
                    };
                    if (InvokeRequired)
                    {

                        Invoke(action);
                    }
                    else
                    {
                        action();

                    }

                }
            }
            catch (Exception ex)
            {
                action = () =>
                {
                    Lb_All.Items.Insert(0, $"{DateTime.Now} => Words => Error: {ex.Message}");
                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }

            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }


        private void mb_Load_Words_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFD_Load_Words.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                if (load_from_words != null)
                {
                    load_from_words.Abort();
                }

                load_from_words = new Thread(FileLoadWords);
                load_from_words.Start( new ArrayList { Lb_All, OFD_Load_Words.FileName, Lb_Banned_Words} );
            }
            catch { }


        }


        private void FileLoadWords(object obc)
        {
            ArrayList arrl = obc as ArrayList;
            ListBox lball = arrl[0] as ListBox;
            string name_file = arrl[1] as string;
            ListBox Lwords = arrl[2] as ListBox;

            mutex.WaitOne();
            Action action;
            string text = string.Empty;
            bool check = false;
            StreamReader str = new StreamReader(name_file, Encoding.Default);
            try
            {

                
                
                while (!str.EndOfStream)
                {
                    check = true;
                    string st = str.ReadLine();
                    foreach(string item in Lwords.Items)
                    {
                        if (st.StartsWith(item))
                        {
                            check = false;
                            break;
                        }

                    }
                    if(check)
                    {
                        action = () =>
                        {
                            Lb_Banned_Words.Items.Add(st);
                        };
                        if (InvokeRequired)
                        {

                            Invoke(action);
                        }
                        else
                        {
                            action();

                        }
                        
                    }
                    
                }
                
                //using (FileStream fstream = File.OpenRead(name_file))
                //    {

                //        byte[] array = new byte[fstream.Length];

                //        fstream.Read(array, 0, array.Length);

                //        text = System.Text.Encoding.Default.GetString(array);

                //    }





            }
            catch (Exception ex)
            {
                action = () =>
                {



                    Lb_All.Items.Insert(0, $"{DateTime.Now} => Logs => Error: {ex.Message}");
                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }
            }
            finally
            {
                try
                {
                    str.Close();
                  
                }
                catch { }
                
                action = () =>
                {

                    

                    Lb_All.Items.Insert(0, $"{DateTime.Now} => Words => Loaded");
                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }
                mutex.ReleaseMutex();
            }
        }

        private void mb_Load_File_Click(object sender, EventArgs e)
        {
            if (OFD_Open_File.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Thread chck = new Thread(CheckForBaneedWords);
            chck.Start(new ArrayList { OFD_Open_File.FileName, path_to_results, Lb_Banned_Words });

        }
       

        private void CheckForBaneedWords(object obc)
        {
            mutex.WaitOne();
            ArrayList arrl = obc as ArrayList;
            string name_file = arrl[0] as string;
            string path_to = arrl[1] as string;
            ListBox lb = arrl[2] as ListBox;
            Action action;
            string text = string.Empty;

            try
            {

                using (FileStream fstream = File.OpenRead(name_file))
                {

                    byte[] array = new byte[fstream.Length];

                    fstream.Read(array, 0, array.Length);

                    text = System.Text.Encoding.Default.GetString(array);

                }
                string res = text;
                res = res.ToLower();

                using (FileStream fstream = new FileStream($@"{path_to}\\FileChecked_{DateTime.Now.ToString("dd-MM-yy_H-mm-ss")}.txt", FileMode.OpenOrCreate))
                {
                    foreach (string item in lb.Items)
                    {
                        res = res.Replace(item, "*banned*");

                    }

                    //foreach (KeyValuePair<string, int> keyValue in dict)
                    //{
                    //    text += keyValue.Key + " - " + keyValue.Value + Environment.NewLine;
                    //}




                    byte[] array = System.Text.Encoding.Default.GetBytes(res);

                    fstream.Write(array, 0, array.Length);

                }


                String[] wordsarr = text.Split(new char[] { ' ', ',', '!', '?' });

                action = () =>
                {



                    foreach (string item in Lb_Banned_Words.Items)
                    {



                        foreach (var word in wordsarr)
                        {
                            if (item.ToLower() == word.ToLower())
                            {

                                if (Words.ContainsKey(item.ToLower()))
                                {
                                    Words[item.ToLower()] += 1;
                                }
                                else
                                {
                                    Words.Add(item.ToLower(), 1);
                                }

                            }

                        }
                    }

                    if (Words != null)
                    {
                        Dictionary<string, int> tmp = new Dictionary<string, int>();
                        foreach (KeyValuePair<string, int> keyValue in Words.OrderBy(t => t.Value))
                        {
                            tmp.Add(keyValue.Key, keyValue.Value);
                        }
                        Words = tmp;
                        //Dictionary<string, int> sortedDict = (Dictionary<string, int>)(from entry in Words orderby entry.Value ascending select entry).Take(10);
                    }

                    Lb_All.Items.Insert(0, $"{DateTime.Now} => File => Checked And Saved");


                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }
            }
            catch (Exception ex)
            {
                action = () =>
                {



                    Lb_All.Items.Insert(0, $"{DateTime.Now} => File => Read => Error: {ex.Message}");
                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }
            }
            finally
            {
                mutex.ReleaseMutex();
                Thread saving = new Thread(SaveFileResult);
                saving.Start(new ArrayList { Words, path_to_results });
            }
        }

        private void SaveFileResult(object obc)
        {
            ArrayList arrl = obc as ArrayList;
            Dictionary<string, int> dict = arrl[0] as Dictionary<string, int>;
            string path_to = arrl[1] as string;
            Action action;
            string text = string.Empty;
            mutex.WaitOne();
            try
            {


               
                    using (FileStream fstream = new FileStream($@"{path_to}\Results_{DateTime.Now.ToString("dd-MM-yy_H-mm-ss")}.txt", FileMode.OpenOrCreate))
                    {

                    if(dict == null)
                    {
                        text = "There is no banned words";
                    }
                    else
                    {
                        foreach (KeyValuePair<string, int> keyValue in dict)
                        {
                            text += keyValue.Key + " - " + keyValue.Value + Environment.NewLine;
                        }
                    }
                    

                    

                        
                        byte[] array = System.Text.Encoding.Default.GetBytes(text);

                        fstream.Write(array, 0, array.Length);

                    }




                    action = () =>
                    {
                        Lb_All.Items.Insert(0, $"{DateTime.Now} => File Results => Saved");
                    };
                    if (InvokeRequired)
                    {

                        Invoke(action);
                    }
                    else
                    {
                        action();

                    }

                }
            
            catch (Exception ex)
            {
                action = () =>
                {
                    Lb_All.Items.Insert(0, $"{DateTime.Now} => File => Save => Error: {ex.Message}");
                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }

            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
