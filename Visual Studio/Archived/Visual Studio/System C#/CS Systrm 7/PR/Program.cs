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
        static Random random;
        
        static double number = 3;
        static void Main(string[] args)
        {
            random = new Random();
            #region Task 1
            //Task task1 = new Task(GetTime);
            //task1.Start();

            //// v2

            //Task task2 = Task.Run(GetTime);

            //// v3

            //Task task3 = Task.Factory.StartNew(GetTime);


            ////task1.Wait();
            //Task.WaitAll(task1, task2, task3);

            #endregion
            #region Task 2-3

            //int d2;
            //int d1;
            //do
            //{
            //    Console.Write("Enter d1: ");
            //    d1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter d1: ");
            //    d2 = Convert.ToInt32(Console.ReadLine());
            //} while (d2 < d1);
            //int[] a = { d1, d2 };
            //Task task1 = new Task(Numbers, a);
            //task1.Start();

            ////Parallel.Invoke( () => Numbers(d1,d2));
            ///
            #endregion
            #region Task 4

            //double[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Parallel.Invoke(() =>
            //{
            //    FindMax(arr);
            //    FindMin(arr);
            //    FindAvg(arr);
            //    FindSum(arr);
            //}
            //);
            #endregion
            double[] array = { 1, 2, 2, 3, 3, 3, 3, 4, 5, 6, 7, 8, 8, 5 };


          //  Task task = new Task(DeletingCopy, array);
            //task.Start();



            Console.Write("Press ENTER... ");
            Console.ReadLine();
        }

        static double[] DeletingCopy(object obc)
        {
            double[] arr = obc as double[];

            return arr.Distinct().ToArray();


        }

        static double[] SortingArr(object obc)
        {
            double[] arr = obc as double[];

            double temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }


            }

            Console.WriteLine("Sorted =>");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            return arr;
        }

        static void FindElement(object obc)
        {
            double[] arr = obc as double[];
            bool check = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    Console.WriteLine($"Founded: {number}");
                    return; 
                }
               
            }

            if(!check)
            {
                Console.WriteLine($"Not Founded: {number}");
            }
            
        }








        static void FindMax(object obc)
        {
            double[] arr = obc as double[];
            double max = 0;
            foreach (var item in arr)
            {
                if(max < item)
                {
                    max = item;
                }
                
            }
            Console.WriteLine($"\nThe biggest number => {max}");
        }

        static void FindMin(object obc)
        {
            double[] arr = obc as double[];
            double min = arr[0];
            foreach (var item in arr)
            {
                if (min > item)
                {
                    min = item;
                }
                
            }
            Console.WriteLine($"\nThe smalles number => {min}");
        }

        static void FindAvg(object obc)
        {
            double[] arr = obc as double[];
            double avg = 0;
            foreach (var item in arr)
            {
                avg += item;
            }
            avg /= arr.Length;
            Console.WriteLine($"\nAvg => {avg}");
        }

        static void FindSum(object obc)
        {
            double[] arr = obc as double[];
            double sum = 0;
            foreach(var item in arr)
            {
                sum += item;
            }
            Console.WriteLine($"\nSumm arr is => {sum}");

        }


        static void Numbers(object obj)
        {
            int[] arr = obj as int[];

            int start = arr[0];
            int end = arr[1];

            Console.WriteLine();
            int s = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i != 1)
                {
                    s++;
                }
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                    s++;
                }

                Console.WriteLine($"Number => {i}");
                //Thread.Sleep(100);
            }
            Console.WriteLine($"\nCount of prostich numbers => {s}");

        }



        static void GetTime()
        {
          
            Console.WriteLine($"\n!Start task => !{Task.CurrentId}!");
            Thread.Sleep(random.Next(2000, 5000));
            Console.WriteLine();
            Console.WriteLine($"!Curren Time: {DateTime.Now}");
            Console.WriteLine();
            Console.WriteLine($"\n!End task => !{Task.CurrentId}!");
            
        }

    }
}
