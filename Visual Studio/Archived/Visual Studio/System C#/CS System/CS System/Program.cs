using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS_System
{
    class Program
    {
        static int x = 0;
        //static Mutex mutex;
        static object locker = new object();

        //CountdownEvent
        //ManualResetEventSlim
        static ManualResetEvent manualReset = new ManualResetEvent(false);
        //AutoResetEvent
        static void Main(string[] args)
        {
            //mutex = new Mutex();
            Thread[] threads = new Thread[5];
            for(int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(Calc);
                threads[i].Start();
            }
            Console.WriteLine("Waiting");
            for(int i = 0; i < 5; i++)
            {
                threads[i].Join();
            }
            manualReset.Set();
            Console.ReadLine();

            Console.WriteLine($"\n\nX => {x} ... Press Enter...");
            Console.ReadLine();

        }

        static void Calc()
        {

            #region ManualReset
           // manualReset.WaitOne();
            
            try
            {
                manualReset.WaitOne();
                manualReset.Reset();
                
                //mutex.WaitOne();
                Thread.Sleep(10);
                
                for (int i = 0; i < 1000000; i++)
                {
                    x++;
                }
                Console.WriteLine($"\n! Id => {Thread.CurrentThread.ManagedThreadId} => Ended !");
                // mutex.ReleaseMutex();
            }
            finally
            {
                manualReset.Set();
                
            }

            #endregion

            #region Использование Monitor
            //Monitor.Enter(locker);
            //try
            //{
            //    //mutex.WaitOne();
            //    Thread.Sleep(10);
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        x++;
            //    }
            //    Console.WriteLine($"\n! Id => {Thread.CurrentThread.ManagedThreadId} => Ended !");
            //    // mutex.ReleaseMutex();
            //}
            //finally
            //{
            //    Monitor.Exit(locker);
            //}

            #endregion

            #region Использовние lock
            /* lock (locker)
             {
                 //mutex.WaitOne();
                 Thread.Sleep(10);
                 for (int i = 0; i < 1000000; i++)
                 {
                     x++;
                 }
                 Console.WriteLine($"\n! Id => {Thread.CurrentThread.ManagedThreadId} => Ended !");
                 // mutex.ReleaseMutex();
             }*/
            #endregion

        }
    }
}
