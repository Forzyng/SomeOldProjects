using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace System_Timer
{
    class Program
    {
        static System.Threading.Timer timer;
        static void Main(string[] args)
        {
            //   timer = new System.Threading.Timer(TestTime, 30, 0, 2000);
            int worker, completion;
            System.Threading.ThreadPool.GetMaxThreads(out worker, out completion);
            Console.WriteLine($"Max Threads: Worker => {worker} | Completion => {completion}");
            System.Threading.ThreadPool.GetMinThreads(out worker, out completion);
            Console.WriteLine($"Min Threads: Worker => {worker} | Completion => {completion}");
            Console.WriteLine("\n\t\tTest\n");
            for(int i = 0; i < 10; i++)
            {
                System.Threading.ThreadPool.QueueUserWorkItem(TestTime, i + 5);
            }

            Console.WriteLine("\n\nEnd main");
            Console.ReadLine();
            //timer
        }
        static void TestTime(object obj)
        {
            int n = (int)obj;
            int f1 = 0;
            int f2 = 1;
            int t;
            for(int i = 2; i < n; i++)
            {
                Console.WriteLine($"Id => {Thread.CurrentThread.ManagedThreadId} | Fibo = {f2}");
                t = f2;
                f2 += f1;
                f1 = t;
                Thread.Sleep(50);
            }
        }
    }
}
