using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS_Systrm_7
{
    class Program
    {
        static Random random;
        static void Main(string[] args)
        {
            random = new Random();
            //// v1

            //Task task1 = new Task(RuinInTask);
            //task1.Start();

            //// v2

            //Task task2 = Task.Run(RuinInTask);

            //// v3

            //Task task3 = Task.Factory.StartNew(RuinInTask);

            //// v4

            //Task task4 = task1.ContinueWith(RunAfter);

            //task1.Wait();
            // Task.WaitAll(task1, task2, task3);

            //Parallel.Invoke(DisplayHello, Sum, () =>
            //{
            //    int f = 1;
            //    for (int i = 1; i < 10; i++)
            //    {
            //        f *= i;
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"Fractional => {f}");
            //    }
            //});

            //Parallel.For(1, 20, (int x) =>
            //    {
            //        int f = 1;
            //        for (int i = 1; i <= x; i++)
            //        {
            //            f *= i;

            //        }
            //        //Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"Fractional of X => {f}        \t\t| Id => {Task.CurrentId}");

            //    });

            Console.WriteLine();


            List<User> users = new List<User>();
            for(int i = 0; i < 13; i++)
            {
                users.Add(new User() { Id = i + 1, Login = $"User {i + 1}" });
            }
            foreach(var i in users)
            {
                i.GetStr();
            }
            Console.WriteLine();
            Console.WriteLine();
            Parallel.ForEach(users, (u) =>
            {
                u.Id += 1000;
                u.GetStr();
            });

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Press ENTER... ");
            Console.ReadLine();
        }

        static void RuinInTask()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nStart task => !{Task.CurrentId}!");
            Thread.Sleep(random.Next(2000,5000));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nEnd task => !{Task.CurrentId}!");
        }

        static void RunAfter(Task src)
        {
            Console.WriteLine($"Task {Task.CurrentId} run after task {src.Id}");
        }

        static void DisplayHello()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello");
        }

        static void Sum()
        {
            int s = 0;
            for(int i = 0; i < 100; i++)
            {
                s += i;
                Thread.Sleep(100);
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nSum => {s}");
        }

        public class User
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public void GetStr()
            {
                Console.WriteLine($"Id => <{Id}> | Login => {Login}");
                Thread.Sleep(100);
            }
        }
    }
}
