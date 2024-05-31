
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



namespace Hooker
{
    public partial class Form1 : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;



        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);



        private HookProc proc; //= HookCallback;
        private IntPtr hook = IntPtr.Zero;
        public Form1()
        {
            proc = HookCallback;
            InitializeComponent();
            FormClosing += (s, e) =>
            {
                if (hook != IntPtr.Zero)
                    UnhookWindowsHookEx(hook);
            };
        }



        private void btn_activate_Click(object sender, EventArgs e)
        {
            hook = SetHook(proc);
            if (hook != IntPtr.Zero)
            {
                btn_activate.Enabled = false;
                btn_deactivate.Enabled = true;
            }
        }



        private void btn_deactivate_Click(object sender, EventArgs e)
        {
            btn_activate.Enabled = true;
            btn_deactivate.Enabled = false;
            UnhookWindowsHookEx(hook);
            hook = IntPtr.Zero;
            lb_Info.Text = "";
        }
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
                int vkCode = Marshal.ReadInt32(lParam);
                Keys keys = (Keys)vkCode;
                //if ((keys == Keys.LWin) || (keys == Keys.RWin))
                //{
                    //Console.WriteLine("{0} blocked!", (Keys)vkCode);
                    lb_Info.Items.Insert(0, $"{keys}");
                    //return (IntPtr)1;
                //}
            }
            return CallNextHookEx(hook, nCode, wParam, lParam);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
