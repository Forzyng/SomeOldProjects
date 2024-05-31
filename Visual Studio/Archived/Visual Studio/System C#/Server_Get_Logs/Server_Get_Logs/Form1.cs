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
using System.IO;
using System.Threading;
using System.Collections;

namespace Server_Get_Logs
{


    public partial class Form1 : Form
    {
        static string path = string.Empty;
        static string path_to_Logs = string.Empty;
        int tick = 10;
        int tack = 0;

        Thread load_from;

        int tick_refr_btn = 5;
        int tack_refr_btn = 0;
        DB_LogsEntitiesNew Logs_DB_Local;
        private static Mutex mutex;
        private SynchronizationContext Context_UI;
        public Form1()
        {
            InitializeComponent();

            mutex = new Mutex();
            Btn_Save_logs.Enabled = false;
            dgv_Logs.AutoGenerateColumns = false;
            Btn_start.Enabled = true;
            Btn_Download.Enabled = false;

            Context_UI = SynchronizationContext.Current;


            Logs_DB_Local = new DB_LogsEntitiesNew();
            tick = (int)nud_Every_sec.Value;
        }



        private void Btn_start_Click(object sender, EventArgs e)
        {
            Btn_start.Enabled = false;

            nud_port.Enabled = false;

            Tcp_Server server = new Tcp_Server("0.0.0.0", (int)nud_port.Value);
            server.Start();
            Lb_All.Items.Insert(0, $"{DateTime.Now} => Server => Started");

            server.ShowMessage += Server_ShowMessage;
        }

        private void Server_ShowMessage(string message) => Context_UI.Send(ShowMessageMain, message);

        private void ShowMessageMain(object obj)
        {
            Lb_All.Items.Insert(0, $"{DateTime.Now} => {obj.ToString()}");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txb_path.Text = dlgOpen.SelectedPath;
                path = txb_path.Text;
                Btn_Download.Enabled = true;
            }
            Lb_All.Items.Insert(0, $"{DateTime.Now} => File => Choosen To Save");
        }







        public class User_connection
        {
            public event Action<string> ShowMessage;
            DB_LogsEntitiesNew Logs_DB;

            TcpClient client;

            public User_connection(TcpClient client)
            {
                this.client = client;
                Logs_DB = new DB_LogsEntitiesNew();
            }
            public void Run()
            {

                string name = string.Empty;
                NetworkStream stream = client.GetStream();
                int len = 0;
                byte[] buf = new byte[1024];
                StringBuilder sb = new StringBuilder();
                bool New = false;
                try
                {


                    do
                    {
                        New = false;
                        sb.Clear();
                        buf = new byte[1024];

                        #region New
                        len = stream.Read(buf, 0, buf.Length);
                        sb.Append(Encoding.UTF8.GetString(buf, 0, len));

                        if (sb.ToString().Equals("File => True"))
                        {
                            New = true;
                        }
                        else
                        {
                            New = false;
                        }

                        buf = new byte[1024];
                        buf = Encoding.UTF8.GetBytes($"Server => 1) Got Condition of File");
                        stream.Write(buf, 0, buf.Length);
                        ShowMessage?.Invoke($"Server => 1) Got Condition of File");
                        #endregion

                        #region Name

                        sb.Clear();
                        buf = new byte[1024];

                        len = stream.Read(buf, 0, buf.Length);
                        sb.Append(Encoding.UTF8.GetString(buf, 0, len));

                        name = sb.ToString();

                        buf = new byte[1024];
                        buf = Encoding.UTF8.GetBytes($"Server => 2) Got Name of File");
                        stream.Write(buf, 0, buf.Length);
                        ShowMessage?.Invoke($"Server => 2) Got Name of File => {name}");
                        #endregion

                        #region Text
                        buf = new byte[4000];
                        sb.Clear();

                        do
                        {
                            len = stream.Read(buf, 0, buf.Length);

                        } while (stream.DataAvailable);

                        byte[] buf1 = new byte[1024];
                        buf1 = Encoding.UTF8.GetBytes($"Server => 3) Got Text of File");
                        stream.Write(buf1, 0, buf1.Length);
                        ShowMessage?.Invoke($"Server => 3) Got Text of File => {name}");
                        #endregion

                        #region Got
                        if (name != "" && New == true)
                        {
                            Log log = new Log()
                            {
                                Id = Guid.NewGuid(),
                                FileName = name,
                                Text = buf,
                                Time = DateTime.Now
                            };

                            Logs_DB.Logs.Add(log);
                            Logs_DB.SaveChanges();

                            buf = new byte[1024];
                            buf = Encoding.UTF8.GetBytes($"4) Server => Got file => {name}");
                            stream.Write(buf, 0, buf.Length);
                            ShowMessage?.Invoke($"4) Server => Got file => {name}");
                        }
                        else
                        {
                            var t1 = (from a in Logs_DB.Logs
                                      orderby a.Time descending
                                      select a).ToList();

                            Log temp = t1.Where(t => t.FileName.Equals(name)).FirstOrDefault();
                            if (temp != null)
                            {
                                Logs_DB.Logs.Remove(temp);
                                Logs_DB.SaveChanges();
                                temp.Time = DateTime.Now;
                                temp.Text = buf;
                                Logs_DB.Logs.Add(temp);
                                Logs_DB.SaveChanges();

                                buf = new byte[1024];
                                buf = Encoding.UTF8.GetBytes($"4) Server => Got file => {name}");
                                stream.Write(buf, 0, buf.Length);
                                ShowMessage?.Invoke($"4) Server => Got file => {name}");
                            }


                        }
                        #endregion



                        //File.WriteAllText($@"{path}\{name}", sb.ToString());


                    } while (sb.ToString().ToLower() != "exit");
                }
                catch (Exception)
                {

                    //Console.WriteLine("\n\nError: " + ex.Message);
                    //ShowError?.Invoke($"\n\nError: {ex.Message}");
                    try
                    {
                        //buf = new byte[1024];
                        //buf = Encoding.UTF8.GetBytes($"Server => Error");
                        //stream.Write(buf, 0, buf.Length);
                        client.Close();
                    }
                    catch
                    {

                    }
                }

                finally
                {

                    stream.Close();
                    client.Close();
                }


            }
            public void RunAsync()
            {
                Task.Run(Run);
            }
        }

        class Tcp_Server
        {
            int Local_Port;
            public int LoacalPort => Local_Port;
            IPAddress address;
            public IPAddress Address => address;
            TcpListener server;

            public event Action<string> ShowMessage;

            private List<User_connection> clients;


            public Tcp_Server(string ip, int port)
            {
                Local_Port = port;
                address = IPAddress.Parse(ip);
                server = null;
                clients = new List<User_connection>();
            }
            private void RunServer()
            {
                try
                {
                    server = new TcpListener(address, LoacalPort);
                    server.Start(100);
                    while (true)
                    {
                        TcpClient client = server.AcceptTcpClient();
                 

                        ShowMessage?.Invoke($"{DateTime.Now} => Connection from => {client.Client.RemoteEndPoint}");
                        //Thread thread = new Thread(IsertingToLb);
                        //thread.Start(res);
                        User_connection user = new User_connection(client);
                        user.ShowMessage += ShowMessage;
                        clients.Add(user);
                        user.RunAsync();
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("\n\nError: " + ex.Message);
                    ShowMessage?.Invoke($"{DateTime.Now} => Error => {ex.Message}");
                }
                finally
                {

                    if (server != null)
                    {
                        server.Stop();
                    }
                    ShowMessage?.Invoke($"{DateTime.Now} => !Server Stopped!");
                }
            }

            public void Start()
            {
                if (server != null)
                {
                    return;
                }

                var t = new Thread(RunServer);
                t.IsBackground = true;
                t.Start();
            }
        }

        private void Btn_start_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            if (dgv_Logs.SelectedRows.Count == 0)
            {
                return;
            }
            Log au = dgv_Logs.SelectedRows[0].DataBoundItem as Log;
            Thread thread = new Thread(DowloadFile);
            thread.Start(new ArrayList { au, Btn_Download });
        }
        private void DowloadFile(object obc)
        {
            mutex.WaitOne();
            ArrayList arl = obc as ArrayList;

            Log au = arl[0] as Log;
            Button b = arl[1] as Button;
            try
            {
                Action action = () =>
                {
                    b.Enabled = false;
                    if (File.Exists($@"{path}\IN_{au.Time.ToString("dd-MM-yy_H-mm-ss")}_{au.FileName}"))
                    {
                        Lb_All.Items.Insert(0, $"{DateTime.Now} => File => Exist => IN_{au.Time.ToString("dd-MM-yy_H-mm-ss")}_{au.FileName}");
                    }
                    else
                    {
                        using (FileStream fstream = new FileStream($@"{path}\IN_{au.Time.ToString("dd-MM-yy_H-mm-ss")}_{au.FileName}", FileMode.OpenOrCreate))
                        {
                            byte[] input = au.Text;
                            // запись массива байтов в файл
                            fstream.Write(input, 0, input.Length);
                            Lb_All.Items.Insert(0, $"{DateTime.Now} => File => Downloaded => {au.FileName}_IN_{au.Time}");

                        }
                    }

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
                Action action = () =>
                {
                    Lb_All.Items.Insert(0, $"Error: {ex.Message}");
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
                Action action = () =>
                {
                    MessageBox.Show("File downloaded");
                    b.Enabled = true;
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






        private void dgv_Logs_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {

            Btn_refresh.Enabled = false;
            Timer_btn_refr.Start();
            Task.Run(GetDBtoDgv);
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (dgv_Logs.SelectedRows.Count == 0)
            {
                MessageBox.Show("U need to selct Row");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are u sure to delete this from DB?", "Continue", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Log au = dgv_Logs.SelectedRows[0].DataBoundItem as Log;
                try
                {

                    Logs_DB_Local.Logs.Remove(au);
                    Logs_DB_Local.SaveChanges();
                    Lb_All.Items.Insert(0, $"{DateTime.Now} => File => Deleted {au.FileName}");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    Lb_All.Items.Insert(0, $"Error: {ex.Message}");
                }
                finally
                {
                    Btn_refresh_Click(sender, e);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void nud_Every_sec_ValueChanged(object sender, EventArgs e)
        {
            tick = (int)nud_Every_sec.Value;
        }

        private void Timer_Refresh_Tick(object sender, EventArgs e)
        {
            tack++;
            if (tack >= tick)
            {
                tack = 0;

                Task.Run(GetDBtoDgv);




            }
        }

        private void GetDBtoDgv()
        {
            mutex.WaitOne();
            try
            {


                Action action = () =>
                {
                    try
                    {
                        if (b_category.SelectedItem == null)
                        {
                            if (b_asc_dsc.SelectedItem != null)
                            {
                                if (b_asc_dsc.SelectedItem.Equals("Ascending"))
                                {
                                    dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderBy(t => t.FileName).ToList();
                                }
                                else
                                {
                                    dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderByDescending(t => t.FileName).ToList();
                                }
                            }
                            else
                            {
                                dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderBy(t => t.FileName).ToList();
                            }
                        }
                        else
                        {
                            if (b_asc_dsc.SelectedItem == null)
                            {
                                if (b_category.SelectedItem.Equals("Date"))
                                {

                                    dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderByDescending(t => t.Time).ToList();
                                }
                                else
                                {
                                    dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderByDescending(t => t.FileName).ToList();
                                }
                            }
                            else
                            {
                                if (b_category.SelectedItem.Equals("Name"))
                                {
                                    if (b_asc_dsc.SelectedItem.Equals("Ascending"))
                                    {
                                        dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderBy(t => t.FileName).ToList();
                                    }
                                    else
                                    {
                                        dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderByDescending(t => t.FileName).ToList();
                                    }

                                }
                                else
                                {


                                    if (b_category.SelectedItem.Equals("Date"))
                                    {
                                        if (b_asc_dsc.SelectedItem.Equals("Ascending"))
                                        {
                                            dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderBy(t => t.Time).ToList();
                                        }
                                        else
                                        {
                                            dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderByDescending(t => t.Time).ToList();
                                        }

                                    }
                                    else
                                    {
                                        dgv_Logs.DataSource = Logs_DB_Local.Logs.OrderBy(t => t.FileName).ToList();
                                    }
                                }
                            }
                        }


                    }
                    catch
                    {

                    }

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
                Action action = () =>
                {
                    Lb_All.Items.Insert(0, $"Error: {ex.Message}");
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

        private void refr_every_sec_CheckedChanged(object sender, EventArgs e)
        {
            tick = (int)nud_Every_sec.Value;
            if (refr_every_sec.Checked)
            {
                tack = 0;
                Timer_Refresh.Start();

            }
            else
            {
                Timer_Refresh.Stop();
                tack = 0;
            }
        }

        private void Timer_btn_refr_Tick(object sender, EventArgs e)
        {
            tack_refr_btn++;
            if (tack_refr_btn >= tick_refr_btn)
            {
                Btn_refresh.Enabled = true;
                Timer_btn_refr.Stop();
            }
        }

        private void Btn_Save_Click_1(object sender, EventArgs e)
        {
            Btn_Save_Click(sender, e);
        }

        private void btn_save_to_logs_Click(object sender, EventArgs e)
        {
            if (FBD_LOGS.ShowDialog() == DialogResult.OK)
            {
                txb_path_logs.Text = FBD_LOGS.SelectedPath;
                path_to_Logs = txb_path_logs.Text;
                Btn_Save_logs.Enabled = true;
            }
            Lb_All.Items.Insert(0, $"{DateTime.Now} => Logs => Choosen To Save");
        }

        private void Btn_Save_logs_Click(object sender, EventArgs e)
        {
            try
            {
                Thread thr = new Thread(SaveLogs);
                thr.Start(Lb_All);
            }
            catch { }
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
                    using (FileStream fstream = new FileStream($@"{path_to_Logs}\Banned_Words_{DateTime.Now.ToString("dd-MM-yy_H-mm-ss")}.txt", FileMode.OpenOrCreate))
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

        private void Btn_load_logs_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFD_LOGS.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                if (load_from != null)
                {
                    load_from.Abort();
                }

                load_from = new Thread(FileLOadLogs);
                load_from.Start(new ArrayList { Lb_All, OFD_LOGS.FileName });
            }
            catch { }
        }


        private void FileLOadLogs(object obc)
        {
            ArrayList arrl = obc as ArrayList;
            ListBox lball = arrl[0] as ListBox;
            string name_file = arrl[1] as string;
            mutex.WaitOne();
            Action action;
            string text = string.Empty;
            StreamReader str = new StreamReader(name_file, Encoding.Default);
            try
            {
                if (name_file.Contains("Server_Logs")) // && name_file.Contains(".txt")
                {



                    //using (FileStream fstream = File.OpenRead(name_file))
                    //{

                    //    byte[] array = new byte[fstream.Length];

                    //    fstream.Read(array, 0, array.Length);

                    //    text = System.Text.Encoding.Default.GetString(array);

                    //}

                   
                    while (!str.EndOfStream)
                    {
                        
                        string st = str.ReadLine();
                            action = () =>
                            {
                                Lb_All.Items.Add(st);
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

                    

                    action = () =>
                    {   
                        Lb_All.Items.Insert(0, $"{DateTime.Now} => Logs => Loaded");
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

                    Lb_All.Items.Add(text);

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
                mutex.ReleaseMutex();
            }
        }
    }
}
