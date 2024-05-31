using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS_Sytem_5_Threading
{
    class Program
    {
        private static int x;
        private static Random random = new Random();
        private static Mutex mutex;
        static void Main(string[] args)
        {
            x = 1;
            mutex = new Mutex();
            for(int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Calculate);
                thread.Start();
            }
            Console.WriteLine("\nEnded Main...");
            Console.ReadLine();
        }

        static void Calculate()
        {
            mutex.WaitOne();
            int delay = random.Next(50, 250);
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: x => {x}");
                x++;
                Thread.Sleep(delay);
            }
            mutex.ReleaseMutex();
        }
    }
}
