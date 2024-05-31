using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Делегаты
// это тип данных, отвечающий за функции ( ~ функциональний указатель )
// Если для переменных допю инфо = тип данных, то для функции:
// тип возврата, параметры (кол-во и типы)



namespace Delegats
{
   public delegate int Operation(int x, int y); // тип данных - можно создать переменную этого типа

public delegate int UnaryOperetion(int x);

public delegate void UOOperetion(int x);

    class Program
    {
        static void Main(string[] args)
        {
            Average avg = new Average();
            avg.Show();
            Console.WriteLine("================");
            Operation oper1; // Делегат - указатель на функцию
            oper1 = Add; // oper1 указывает на Add
            Console.WriteLine(oper1(10, 20)); // Вызов функции через делегат


            oper1 = Sub; // oper1 указывает на Add
            Console.WriteLine(oper1.Invoke(10, 20)); // Вызов функции через делегат

            Console.WriteLine("================"); 

            UnaryOperetion uo;
            // Явная инициализация  через конструктор
            uo = new UnaryOperetion(Square); // делегат - не просто указатель, а объект, выполняющий эту роль

            UOOperetion uos = SqareShow; // Выгода 1 - как у переменной - возможость поменять в одном месте

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.ForEach(new Action<int>(uos));
            Console.WriteLine("================");
            uos += CubeShow; // Выгода 2
            foreach (int n in numbers) uos(n);
            Console.WriteLine("================");
            Console.ReadKey(true);
        }


        // Функции, на которые можно будет указывать
        // Должны соответствовать такому же прототипу: int fun (int, int)

        static int Add (int x, int y)
        {
            return x + y;
        }

        static int Sub(int x, int y)
        {
            return x - y;
        }

        // UnaryOperation
       static int Square(int x) => x * x; // Arrow notations
       static int Cube(int x) => x * x * x;

        static void SqareShow(int x) => Console.WriteLine("{0}^2 = {1}", x, Square(x));
        static void CubeShow(int x) => Console.WriteLine("{0}^3 = {1}", x, Cube(x));

    }
}
