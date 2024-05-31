using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace DllLoadTest
{
    public partial class MainForm : Form
    {
        KeyboardHook keyboard;
        bool isVisible;
        public MainForm()
        {
            InitializeComponent();
            isVisible = true;
            keyboard = new KeyboardHook();
            keyboard.KeyPressed += Keyboard_KeyPressed;
            keyboard.RegisterHotKey(DllLoadTest.ModifierKeys.Control | DllLoadTest.ModifierKeys.Alt, Keys.F9);
        }

        private void Keyboard_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (isVisible)
            {
                btnHide_Click(null, null);
            }
            else
            {
                ShowInTaskbar = true;
                ShowWindow(Handle, SW_SHOWNORMAL);
                isVisible = true;
            }
        }

        const int SW_HIDE = 0;
        const int SW_SHOWNORMAL = 1;
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int showCmd);
        [DllImport("NtHide.dll")]
        private static extern bool HideProcess(IntPtr pid, bool HideOnlyFromTaskManager);
        private void btnHide_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            HideProcess((IntPtr)Process.GetCurrentProcess().Id, false);
            ShowWindow(Handle, SW_HIDE);
            isVisible = false;
        }
    }
}
