using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    struct Number_In_Struct
    {
        //public Number_In_Struct()
        //{
        //    number = 0;   // - не можем использовать конструктор по умолчанию (без параметров) для структуры, потому что компилятор всегда генерирует его сам
        //}                
        public Number_In_Struct(int n)
        {
            number = n;   //  Если в этом конструкторе не будет инициализировано какое-нибудь значение, компилятор не будет его инициализировать за нас и покажет ошибку.
        }
        public int number;
        // public int number = 0 - Вызовет ошибку - мы не можем инициализировать  значение полей непосредственно в месте их объявления
        public override String ToString() { return $"({number} - In Struct)"; }
    }

    class Number_In_Class
    {
        public Number_In_Class()
        {
            number = 0; // В Class создается конструктор по умолчанию, лишь тогда, когда мы его не определили
        }
        // public int number = 0 - мы можем инициализировать  значение полей непосредственно в месте их объявления
        // Можно использовать Number_In_Struct в классе
        public int number;
        public override String ToString() { return $"({number} - In Class)"; }
    }

    enum Menu
    {
        Start, // 0
        Resume, // 1
        Exit // 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            ConsoleKeyInfo r;
            int m;
            do
            {              
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("1 - {0}", Menu.Start);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("2 - {0}", Menu.Resume);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("3 - {0}", Menu.Exit);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    r = Console.ReadKey(true);
                    m = r.Key - ConsoleKey.D1;
                    Console.WriteLine();
                    Console.WriteLine((Menu)(r.Key - ConsoleKey.D1));
                } while (m < (int)Menu.Start || m > (int)Menu.Exit);
                //=============
                Console.ResetColor();
                //  Console.WriteLine((Menu)m);
                switch ((Menu)m)
                {
                    case Menu.Start:
                        for(i = 1; i < 10; i++)
                        {
                            if(i % 2 == 0)
                            {
                                i++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("I = {0}", i);
                            }
                        }
                        Console.ReadKey(true);
                        break;
                    case Menu.Resume:
                        for ( ; i < 10; i++)
                        {
                            if (i % 2 == 0)
                            {
                                i++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("I = {0}", i);
                            }
                        }
                        Console.ReadKey(true);
                        break;
                    case Menu.Exit:
                        Console.WriteLine("Bye!... You used - {0}", Menu.Exit);
                        break;


                }
            } while ((Menu)m != Menu.Exit && i < 10);



            // Отличия: Class - (refernce type) | Struct - (value type, but with using modifikatora "ref" can be reference type)

            Console.WriteLine();
            Number_In_Struct Example_struct; // в отличие от классов нет = new Point()
            Example_struct.number = 10;
            Console.WriteLine(Example_struct);

            Number_In_Struct Example_struct_2 = Example_struct;
            Example_struct_2.number = 100;
            Console.WriteLine("----------------");
            Console.WriteLine(Example_struct);
            Console.WriteLine(Example_struct_2);

            Console.WriteLine("================");

            Number_In_Class Example_class = new Number_In_Class();
            Example_class.number = 10;
            Console.WriteLine(Example_class);

            Number_In_Class Example_class_2 = Example_class;
            Example_class_2.number = 100;
            Console.WriteLine("----------------");
            Console.WriteLine(Example_class);
            Console.WriteLine(Example_class_2);




            Console.ReadKey(true);
        }
    }
}
