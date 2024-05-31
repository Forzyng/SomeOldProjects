using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MessageBox
{
    class Program
    {
        static long MB_YESNOCANCEL = 0x00000003L;
        // [MarshalAs(UnmanagedType.LPStr)]
        internal static class NativeMethods
        {
            // Declares managed prototypes for unmanaged functions.
            [DllImport("User32.dll", EntryPoint = "MessageBox", CharSet = CharSet.Auto)]
            internal static extern int MsgBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

            // Causes incorrect output in the message window.
            [DllImport("User32.dll", EntryPoint = "MessageBoxW", CharSet = CharSet.Ansi)]
            internal static extern int MsgBox2(IntPtr hWnd, string lpText, string lpCaption, uint uType);

            // Causes an exception to be thrown. EntryPoint, CharSet, and
            // ExactSpelling fields are mismatched.
            [DllImport("User32.dll", EntryPoint = "MessageBox", CharSet = CharSet.Ansi, ExactSpelling = true)]
            internal static extern int MsgBox3(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        }

        static void Main(string[] args)
        {

            NativeMethods.MsgBox(IntPtr.Zero, "VAS VZLOMALI", "Attention", 0);
            NativeMethods.MsgBox2(IntPtr.Zero, "vas ne vzlomali", "No Attention", 0);

            try
            {
                NativeMethods.MsgBox3(IntPtr.Zero, "Y VAS 20 VIRUSOV ", "ERROR", 0);
            }
            catch (EntryPointNotFoundException)
            {
                Console.WriteLine($"{nameof(EntryPointNotFoundException)} thrown as expected!");
            }
            Console.WriteLine();
            Console.WriteLine("Enter => ");
            Console.ReadLine();
        }
    }
}
