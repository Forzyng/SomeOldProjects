using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_ENUM
{
    public enum AccesMode
    {
        Read,
        Write,
        Append

    }

    public enum CompileMode
    {
        Debug,
        Release
    }

    public enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right
    }

    enum Menu
    {
        Start, // 0
        Resume, // 1
        Exit // 2
    }

    // Структуры - нессылочный тип (value type) данных, подобный классам
    // А = В
    // ссылочный тип: А и В - указатели на один объект (из В в А копируеться адрес)
    // нессылочный: в А создается копия объекта В (в итоге объектов - 2)

    struct Point
    {
        public int x;
        public int y;
        public override String ToString() { return $"({x};{y})"; }
    }

    class CPoint
    {
        public int x;
        public int y;
        public override String ToString() { return $"({x};{y})"; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point x1; // в отличие от классов нет = new Point()
            x1.x = 10;
            x1.y = 20;
            Console.WriteLine(x1);

            Point x2 = x1;
            x2.x = 30;
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.WriteLine("========");

            CPoint cx1 = new CPoint(); 
            cx1.x = 10;
            cx1.y = 20;
            Console.WriteLine(cx1);

            CPoint cx2 = cx1;
            cx2.x = 30;
            Console.WriteLine(cx1);
            Console.WriteLine(cx2);





            Console.ReadKey();

        }
        static void Main2(string[] args)
        {
            // Структуры перечесления
            // - это косплексные (составные) типы данных

            #region Enum
            AccesMode fileMode; // объявление переменной типа "перечисление"
            fileMode = AccesMode.Write; // присваивание значения
            Console.WriteLine(fileMode);

            CompileMode mode = CompileMode.Debug;
            int x = 10;
            if (mode == CompileMode.Debug)
            {
                Console.WriteLine($"x = {x}");
            }

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((MoveDirection)rnd.Next(4));
            }


            switch ((MoveDirection)rnd.Next(4))
            {
                case MoveDirection.Up:
                    break;
                case MoveDirection.Down:
                    break;
                case MoveDirection.Left:
                    break;
                case MoveDirection.Right:
                    break;
            }



            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            ConsoleKeyInfo r;
            do
            {
                r = Console.ReadKey();
            } while (r.Key != ConsoleKey.Escape);

            #endregion

           // ConsoleKeyInfo r;
            int m;
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
                Console.WriteLine((Menu)(r.Key - ConsoleKey.D1));
            } while ( m < (int)Menu.Start || m > (int)Menu.Exit );


            //=============
            Console.ResetColor();
            Console.WriteLine((Menu) m);
            //=============

            Console.ReadKey();
        }
    }
}
