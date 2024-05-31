using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class ClassB
    {
        
            // Полиморфизм: Поли - много, морф форма
            // в программировании - несколько реализаций
            // параметрический полиморфизм - наличие нескольких тел у функции/метода 
            // отличающихся набором и/или типом параметров

            public void SayHello()
            {
            Console.WriteLine("Hello");
            }
        public void SayHello(String Name)
        {
            Console.WriteLine($"Hello, {Name}");
        }
        public void SayHello(String Name, String Greeting)
        {
            Console.WriteLine($"{Greeting}, {Name}");
        }

        

        static void Main(string[] args)
        {
            List<Issue> Funds = new List<Issue>();
            Funds.Add(new Journal() { Title = "Nature", Number = 10 });
            Funds.Add(new Journal() { Title = "Work", Number = 37 });
            Funds.Add(new Book() { Title = "Dungeon", Author = "Dungeon master" });
            Funds.Add(new Book() { Title = "Gym", Author = "Boss of the gym" });
            Funds.Add(new Magazine() { Title = "2020 - Начало", Date = new DateTime(2020, 01, 01) });
            Funds.Add(new Magazine() { Title = "2020 - Конец", Date = new DateTime(2020,12,31) });

            foreach (Issue issue in Funds)
            {
                Console.WriteLine(issue.ToString());
            }

            Console.WriteLine();

            foreach (Issue issue1 in Funds)
            {
                if( (issue1 as Book) != null)
                {
                    Console.WriteLine(issue1.ToString());
                }   
            }

            //Issue x = new Issue() { Title = "X" };
            //Journal j = new Journal() { Title = "J", Number = 10 };

            //Console.WriteLine(x.ToString());
            //Console.WriteLine(j.ToString());

            //Issue xj = new Journal() { Title = "XJ", Number = 11 };
            //// virtual -Journal / non-virtual - Issue
            //Console.WriteLine(xj.ToString());

            //ClassA A = new ClassA();
            //A.x = 10; // Поле обычное присваивание
            //A.X = 10; // Свойство - Вызов геттера 10
            //A.X = A.Y; // X - пишеться, Y -читаеться


            // О строках в С#
            // - символ - 2 байта (UTF-16)
            // - служебные символы - есть (\n, \t, \r ...)
            // - всегда "", для char - ''
            // константная строка (без проработки \)

            // str = @"C:\new_files\n.txt"
            // str = @"C:\\new_files\\n.txt"

            // строка с подстановкой
            // str = $"x = {x}" -- значение x подставляется вместо {x}
            // ~ str = "x = " + x;

            // Форматирование
            //Console.WriteLine
            //    (
            //    String.Format("{0, 5} + {1, -5} = {2}", 2, 3, 5)
            //    // "2 + 3 = 5"
            //    ); 

            //ClassB b = new ClassB();
            //b.SayHello();
            //b.SayHello("buddy");
            //b.SayHello("buddy", "Welcome to the club");
            Console.ReadKey();
        }
    }


    // В C# классы можно описовать в namespace
    // Приявязки к файлам - нет (много классов в одном файле / один класс в разныъ файлах)
    // Видимость классов - public / default (в пределах namespace)

    //public class ClassA
    //{
    //    // Fields
    //    public int x;
    //    private int y;

    //    // Properties
    //    public int X { get; set; } // Свойство - скрытое поле + методы получения и установления
    //    public int Y { get { return 42; } } // read only
    //    public int Z { get; private set; } // inside - get; set; outside - get;
    //                                       // partical - описан в нескольких файлах
    //    public ClassA() // конструктор
    //    {
    //        x = 0;
    //        y = 0;
    //    }



    //}

}



/* Инкапсуляция - ин-капсулв = "Все мое ношу с собой"
 * Наследование - расширение
 * Полиморфизм - суть, перезагрузка функций (параметрический п)
 * Абстракция  - выделение общих признаков / моделирование - не предполагает создание экземпляров
 * Класс - тип данных, соединяющий в себе данные и методы
 * Объект
 * Интерфейс
 * Шаблон
 */

