using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CS_System_1
{
    class Program
    {
        
        const int WM_SETTEXT = 0x0c;
        const int WM_CLOSE = 0x10;
        const int WM_QUIT = 0x12;

        const int SW_MINIMIZE = 6;
        const int SW_SHOWNORMAL = 1;
        
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        static void Main(string[] args)
        {
            //Console.WriteLine("Current Process info: \n");

            //Get_Current_Info(Process.GetCurrentProcess());

            Console.WriteLine("Run notepad");
            Run_Notepad();
            Process np = null;
            //foreach(Process item in Process.GetProcesses())
            //{
            //    try
            //    {
            //        Console.WriteLine($"{item.ProcessName}\t{item.Id}\t{item.Handle}");
            //        if(item.ProcessName == "wordpad")
            //        {
            //            np = item;
            //        }
            //    }
            //    catch
            //    {

            //    }
                
            //}

            if (np != null)
            {
                Console.WriteLine("Sending");
                SendMessage(np.Handle, WM_SETTEXT, 0, "Vzlom");
                Console.WriteLine("Minimize");
                ShowWindow(np.Handle, SW_MINIMIZE);

                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Normal");
                ShowWindow(np.Handle, SW_SHOWNORMAL);
            }

            Console.WriteLine();
            Console.Write("=>");
            Console.ReadLine();
        }
        static void Get_Current_Info(Process process)
        {
            // var current = Process.GetCurrentProcess();
            try
            {

           
            Console.WriteLine("Process Id: " + process.Id);
            Console.WriteLine("Process Name: " + process.ProcessName);
            Console.WriteLine("Handle count: " + process.HandleCount);

            Console.WriteLine("Start Info Arguments: " + process.StartInfo.Arguments);
            Console.WriteLine("Start Info File Name: " + process.StartInfo.FileName);

            Console.WriteLine();
            Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void Run_Notepad()
        {
            string FileName = @"notepad.exe";

            #region 1.0
            //var notepad = Process.Start(FileName);
            #endregion

            #region 2.0
            Process notepad = new Process();
            notepad.StartInfo = new ProcessStartInfo(FileName);
            notepad.Start();
            #endregion

            notepad.Exited += Calc_Exited;

            //var np = Process.GetProcessesByName(FileName)[0];

            //SendMessage(notepad.Handle, WM_SETTEXT, 0, "Vzlom bloknota");
            //ShowWindow(notepad.Handle, SW_MINIMIZE);

            ////System.Threading.Thread.Sleep(2000);
            //ShowWindow(notepad.Handle, SW_SHOWNORMAL);

            //Console.WriteLine("MainWindow: " + notepad.MainWindowTitle);

            Get_Current_Info(notepad);

            ////notepad.WaitForExit();

            //Console.Write("Press ENTER or close => ");
            //Console.ReadLine();



            ////notepad.CloseMainWindow();
            //notepad.Kill();
            //IntPtr res = SendMessage(notepad.Handle, WM_CLOSE, 0, string.Empty);
            //Console.WriteLine("Return: " + res.ToString());
            //Console.WriteLine();
            Console.WriteLine("Stoped");
        }

        private static void Calc_Exited(object sender, EventArgs e)
        {
            Console.WriteLine("Calculator closed");
        }
    }
}
