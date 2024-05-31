using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Work_With_Semaphore
{
    public class Reader
    {
        static Semaphore semaphore = new Semaphore(3, 3);
        private Thread thread;
        public Thread ReaderThread => thread;
        private int readerid;
        private int count;
        private ConsoleColor cls;
        public Reader(int ReaderID, ConsoleColor color)
        {
            count = 3;
            readerid = ReaderID;
            thread = new Thread(ReaderRun);
            thread.Name = $"Reader {readerid}";
            cls = color;
        }

        public void Start()
        {
            thread.Start();
        }

        private void ReaderRun()
        {
            while (count > 0)
            {
                
                semaphore.WaitOne();
                Console.ForegroundColor = cls;
                Console.WriteLine($"\nReader {readerid} Entering...");
                Console.ForegroundColor = cls;
                Console.WriteLine($"\nReader {readerid} Reading...");
                Thread.Sleep(2000);
                count--;
         
                Console.ForegroundColor = cls;
                Console.WriteLine($"\nReader {readerid} Exiting...");


                semaphore.Release();
                Thread.Sleep(3000);
            }
        }
    }
}
