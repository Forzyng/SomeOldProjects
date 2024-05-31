using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PR_Forms
{
    class RandomNumbers
    {
        static Semaphore semaphore = new Semaphore(3, 3);
        private Thread thread;
        private int count;
        public int Id;
        static Random rand;
        public int value;


        public event Action<string> ReaderMessage;
        public RandomNumbers(int id)
        {
            Id = id;
            count = 3;
            thread = new Thread(GetRandom);
            rand = new Random();
        }

        public void Start()
        {
            thread.Start();
        }

        public string GetValue()
        {
            return $"Id: {Id} | Value: {value}";
        }

  

        private void GetRandom()
        {
            while (count > 0)
            {

                semaphore.WaitOne();

              

                value = rand.Next(1, 100);
                ReaderMessage?.Invoke(GetValue());
                Thread.Sleep(2000);
                count--;
                semaphore.Release();
                Thread.Sleep(3000);
            }
           

           
        }
    }
}
