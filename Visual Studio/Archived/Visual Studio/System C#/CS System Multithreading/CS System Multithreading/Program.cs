using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS_System_Multithreading
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Random random;
            random = new Random();
            Thread.CurrentThread.Name = "Master";
            GetInfoThread(Thread.CurrentThread);

            #region New thread
            Thread[] threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                //Thread thread = new Thread(new ThreadStart(RunThread));
                //Thread thread = new Thread(Factorial);
                threads[i] = new Thread(Factorial);
                threads[i].Name = $"Thread slave {i + 1}";
                threads[i].IsBackground = true;
                threads[i].Start(random.Next(5, 15));
                threads[i].Suspend();
            }

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Thread states: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (Thread t in threads)
            {
                Console.WriteLine($"\tId: { t.ManagedThreadId} \t| State: {t.ThreadState}");
            }

            foreach(Thread t in threads)
            {
                t.Resume();
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Master continue");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Master ended");
            #endregion

            Console.WriteLine();
            Console.WriteLine("Press ENTER... ");
            Console.ReadLine();

        }

        static void GetInfoThread(Thread thread)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t|=========================|");
            Console.WriteLine("\t\t|         Info            |");
            Console.WriteLine("\t\t|=========================|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t\t| Name: {thread.Name}");
            Console.WriteLine($"\t\t| Id: {thread.ManagedThreadId}");
            Console.WriteLine($"\t\t| Is Background?: {thread.IsBackground}");
            Console.WriteLine($"\t\t| Is Alive?: {thread.IsAlive}");
            Console.WriteLine($"\t\t| Priority: {thread.Priority}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t|=========================|\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void RunThread()
        {
            Thread thread = Thread.CurrentThread;
            GetInfoThread(thread);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Start {thread.Name} ({thread.ManagedThreadId}) another thread at {DateTime.Now}");
           
            Thread.Sleep(10000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"End thread {thread.Name} ({thread.ManagedThreadId}) at {DateTime.Now}");
        }

        static void Factorial(object src)
        {
            int n = (int)src;
            int f = 1;
            for(int i = 1; i <=n;i++)
            {
                f *= i;
                Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\t\tFactorial {n} => {f}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
