using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PR
{
    class Program
    {
        private static int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static Random random = new Random();
        private static Mutex mutex;
        static void Main(string[] args)
        {
            bool first;
            Mutex checker = new Mutex(true, "Test", out first);

            if(!first)
            {
                Console.WriteLine("NELZY BOLSHE 1 PRILOZHENIYA!!! VICHODI!!!");
                Console.ReadLine();
            }
            mutex = new Mutex();
            //Thread thread1 = new Thread(From10);
            //    Thread thread = new Thread(To20);
            //    thread.Start();
            //thread1.Start();

            Thread mod = new Thread(Modiffication);
            Thread show = new Thread(Finder);

            mod.Start();

            show.Start();

            checker.ReleaseMutex();
            Console.WriteLine("\nEnded Main...");
            Console.ReadLine();
        }

        static void To20()
        {
            mutex.WaitOne();
            int delay = random.Next(50, 250);
            Console.WriteLine();
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: Count => {i}");
               
                Thread.Sleep(delay);
            }
            mutex.ReleaseMutex();
        }
        static void From10()
        {

            mutex.WaitOne();
            int delay = random.Next(50, 250);
            Console.WriteLine();
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: Count => {i}");
               
                Thread.Sleep(delay);
            }
            mutex.ReleaseMutex();
        }

        static void Modiffication()
        {
      
            mutex.WaitOne();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i;
                Console.WriteLine($"Index: {i} | Value {arr[i]}");
            }
            
            mutex.ReleaseMutex();
        }

        static void Finder()
        {
            mutex.WaitOne();
            int big = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(big < arr[i])
                {
                    big = arr[i];
                }
            }
            Console.WriteLine($"The biggest in modificated: {big}");
            mutex.ReleaseMutex();
        }
    }
}
