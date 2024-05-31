using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CS_System_DZ_1
{
    class Program
    {
        const int WM_SETTEXT = 0x0c;
        const int SW_MINIMIZE = 6;
        const int SW_SHOWNORMAL = 1;

        const int WM_CLOSE = 0x10;
        const int WM_QUIT = 0x12;

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow([MarshalAs(UnmanagedType.LPStr)]  string lpClassName, string lpWindowName);
        static void Main(string[] args)
        {
            string caption = @"WindowCatching";
            string clast = "WindowsForms10.Window.8.app.0.141b42a_r8_ad1";

            Console.ReadLine();
            IntPtr toplevelWindow = FindWindow(clast, caption);

            

            if(toplevelWindow != IntPtr.Zero)
            {
                //Console.Write("Menyam okno => ");
                //ShowWindow(toplevelWindow, SW_MINIMIZE);
                //Console.ReadLine();
                //Console.Write("\nObratnoe znacheniye =>");
                //ShowWindow(toplevelWindow, SW_SHOWNORMAL);
                //Console.ReadLine();
                SendMessage(toplevelWindow, WM_SETTEXT, 0, "1");
                //SendMessage(toplevelWindow, WM_CLOSE, 0, "Vzlom");
                Console.WriteLine("\n\nVzlom - success");
            }
            else
            {
                Console.WriteLine("Vzlom ne ydlasa");
            }

            Console.WriteLine();
            Console.Write("Press ENTER... ");
            Console.ReadLine();
        }
    }
}
