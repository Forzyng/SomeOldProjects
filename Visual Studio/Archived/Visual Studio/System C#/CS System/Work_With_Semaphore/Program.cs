using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Work_With_Semaphore
{
    class Program
    {
        static ConsoleColor[] consoleColors = new ConsoleColor[10] { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.DarkBlue, ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.DarkCyan, ConsoleColor.DarkGreen, ConsoleColor.DarkRed };
        static void Main(string[] args)
        {
            Reader[] readers = new Reader[10];
            for(int i = 0; i < readers.Length; i++)
            {
                readers[i] = new Reader(i + 1, consoleColors[i]);
                readers[i].Start();
            }
            //for (int i = 0; i < readers.Length; i++)
            //{
            //    readers[i].ReaderThread.Join();
            //}
            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();
        }
    }
}
