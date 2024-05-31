using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generic - Обобщенне программирование / Templates
// 1. Использование стандартных средств
// 2. Разработка собственных

// Genetic - программирование с изменчивым типом данных
namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 2, 5, 1, 6, 2, -3 };
            float [] arr2 = new float[] { 3.5f, 2, 5, 1.9f, 6, 2.3f, -5.7f };
            long [] arr3 = new long[] { 1234, 9849, -9895, 23421, 6765, 23122, -8893 };

            Optimist<int> oi = new Optimist<int>();
            oi.SetData(arr1);
            Console.WriteLine($"Min: {oi.FindMin()}");
            Console.WriteLine($"Max: {oi.FindMax()}");

            Console.WriteLine("==========");

            var fi = new Optimist<float>();
            fi.SetData(arr2);
            Console.WriteLine($"Min: {fi.FindMin()}");
            Console.WriteLine($"Max: {fi.FindMax()}");

            Console.WriteLine("==========");

            var lo = new Optimist<long>();
            lo.SetData(arr3);
            Console.WriteLine($"Min: {lo.FindMin()}");
            Console.WriteLine($"Max: {lo.FindMax()}");

            Console.WriteLine("======================");

            Number[] numbers = new Number[arr2.Length]; // Создаёем массив 7 шт из ссылок на Number и пока они null
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Number { Value = arr2[i] };
            }
            OptimistR<Number> or = new OptimistR<Number>();
            or.SetData(numbers);
            Console.WriteLine($"Min: {or.FindMin()}");
            Console.WriteLine($"Max: {or.FindMax()}");

            Console.WriteLine("======================");

            var ou = new OptimistU();
            Console.WriteLine($"Min: {ou.FindMin(numbers)}");
            Console.WriteLine($"Max: {ou.FindMax(numbers)}");

            Console.WriteLine("======================");

            Console.ReadKey(true);
        }
        static void Main1(string[] args)
        {
            // Одна из наиболее популярных сфер - колекциии
            // Наличие прото-объекта object  уже позволяет объеденить разнотипные данные

            List<object> list = new List<object>();
            list.Add(1);
            list.Add("String");
            list.Add(true);

            list.ForEach(arg => Console.WriteLine(arg + " " + arg.GetType()));

            Console.WriteLine("===========");

            List<String> ts = new List<String>(); // аналог одномерного массива
            ts.Add("string 1"); // Заполнение коллекции
            ts.Add("string 2");
            ts.Add("string 3");
            ts.Add("string 4");

            ts[1] = "new string"; // Индексатор позволяет индексировать

            // Рекомендации по кодированию - использовать инструкции одного уровня абстракции

            for (int i = 0; i < ts.Count; i++) // array -> .Length
            {
                // ts.Add("forever"); - for  не блокирует коллекцию -Ю бескрнечный цикл
                // ts.RemoveAt(2); - удаление по индексу
                Console.WriteLine(ts[i]); // Колекции поддерживают индексаторы [i]
            }

            Console.WriteLine("===========");

            foreach  (String s in ts) // только чтение + блокировка от изминений
            {
                // s += "-"; - error - read only
                // ts.Add("foreach forever"); - exception - колекция изменилась при переборе
                Console.WriteLine(s);
            }

            Console.WriteLine("===========");

            ts.ForEach(Console.WriteLine);

            Console.WriteLine("===========\n");
            // Dictionary
            // Словарь (HashMap, HashTable, hash, ассоциатиный массив)
            // - массив, в котором индекс (ключ) не обязательное число

            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("lclhost", "127.0.0.1");
            dictionary.Add("router", "192.168.1.1");
            dictionary.Add("it.step", "104.22.6.139");

            Console.WriteLine(dictionary["router"]);

            foreach (var p in dictionary)
            {
                Console.WriteLine(p.Key + " => " + p.Value);
            }
            try
            {
                Console.WriteLine(dictionary["no key"]);
            }
            catch
            {
                Console.WriteLine("no data");
            }




            int n = 1;
            try
            {
                switch (n)
                {
                    case 1:
                        throw new IndexOutOfRangeException();
                       // break;
                    case 2:
                        throw new InvalidOperationException();
                    // break;
                    default:
                        throw new Exception();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Out of range");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown exceptin " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Final");
            }

            Console.ReadKey();
        }
    }
}
