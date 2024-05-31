using System;

namespace HW_1
{
    partial class Motorcycle
    {
        private int Value;
        private string name;
        private bool petrol;
        private int volume_engine;
        private int speed;

        public static decimal guarantee_month;
        public static decimal min_milage;

        public Motorcycle() // конструктор
        {
            Value = 0;
            name = "";
            petrol = false;
            volume_engine = 0;
            speed = 0;
        }
        public Motorcycle(int u_Value) // конструктор
        {
            Value = u_Value;
            name = "";
            petrol = false;
            volume_engine = 0;
            speed = 0;
        }
        public Motorcycle(int u_Value, string u_name) // конструктор
        {
            Value = u_Value;
            name = u_name;
            petrol = false;
            volume_engine = 0;
            speed = 0;
        }
        public Motorcycle(int u_Value, string u_name, bool u_petrol) // конструктор
        {
            Value = u_Value;
            name = u_name;
            petrol = u_petrol;
            volume_engine = 0;
            speed = 0;
        }
        public Motorcycle(int u_Value, string u_name, bool u_petrol, int u_volume_engine) // конструктор
        {
            Value = u_Value;
            name = u_name;
            petrol = u_petrol;
            volume_engine = u_volume_engine;
            speed = 0;
        }
        public Motorcycle(int u_Value, string u_name, bool u_petrol, int u_volume_engine, int u_speed) // конструктор
        {
            Value = u_Value;
            name = u_name;
            petrol = u_petrol;
            volume_engine = u_volume_engine;
            speed = u_speed;
        }


        public void Print()
        {
            Console.WriteLine("Cost: " + Value);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Petrol?: " + petrol);
            Console.WriteLine("Volume engine: " + volume_engine);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine();
            Console.WriteLine();
        }
        public void Print(ref Motorcycle obj)
        {
            Console.WriteLine("Cost: " + obj.Value);
            Console.WriteLine("Name: " + obj.name);
            Console.WriteLine("Petrol?: " + obj.petrol);
            Console.WriteLine("Volume engine: " + obj.volume_engine);
            Console.WriteLine("Speed: " + obj.speed);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region DZ_1
            #region Spaces
            //int Spaces = 0;
            //ConsoleKeyInfo Symbol;
            //do
            //{
            //    Console.WriteLine("Enter symbol: ");
            //    Symbol = Console.ReadKey();
            //    if (Symbol.KeyChar == ' ')
            //    {
            //        Spaces++;
            //    }
            //    if (Symbol.KeyChar == '.')
            //    {
            //        break;
            //    }
            //    Console.WriteLine();
            //} while (true);
            //Console.WriteLine("Spaces: ", Spaces);
            #endregion

            #region Ticket
            //Console.WriteLine("Enter 6 number: ");
            //try
            //{
            //    string ticket = Console.ReadLine();
            //    if (ticket.Length < 0 && ticket.Length > 6)
            //    {
            //        throw new IndexOutOfRangeException();
            //    }
            //    int Iticket = Convert.ToInt32(ticket);
            //    Console.WriteLine
            //        ((Convert.ToInt32(Convert.ToString(ticket)[0].ToString()) +
            //        Convert.ToInt32(Convert.ToString(ticket)[1].ToString()) +
            //        Convert.ToInt32(Convert.ToString(ticket)[2].ToString())
            //        ) == (
            //         Convert.ToInt32(Convert.ToString(ticket)[3].ToString()) +
            //         Convert.ToInt32(Convert.ToString(ticket)[4].ToString()) +
            //         Convert.ToInt32(Convert.ToString(ticket)[5].ToString())
            //         )
            //        ? "Lucky" : "Unlucky"
            //        );
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Uncorrect number");
            //    Environment.Exit(0);
            //}
            #endregion

            #region Convert
            //ConsoleKeyInfo symbol;
            //do
            //{
            //    Console.WriteLine("Enter symbol: ");
            //    symbol = Console.ReadKey();
            //    Console.WriteLine();
            //    Console.Clear();
            //    if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
            //    {
            //        if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
            //        {
            //            Console.WriteLine("New symbol: " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("New symbol: " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
            //            Console.WriteLine();
            //        }
            //    }
            //    if (Convert.ToInt32(symbol.KeyChar) == 27)
            //    {
            //        break;
            //    }
            //} while (true);
            #endregion

            #region A<B
            //Console.WriteLine("Необходимо ввести А и В, причем А<B");
            //try
            //{
            //    Console.WriteLine("A: ");
            //    int A = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("B: ");
            //    int B = Convert.ToInt32(Console.ReadLine());
            //    if (A >= B || A <= 0 || B <= 0)
            //    {
            //        throw new IndexOutOfRangeException();
            //    }
            //    Console.Clear();
            //    for (int i = A; i <= B; i++)
            //    {
            //        for (int j = 0; j < i; j++)
            //        {
            //            Console.Write(i);
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Close");
            //    Environment.Exit(0);
            //}
            #endregion

            #region N but in the contrary
            //try
            //{
            //    Console.WriteLine("Enter N");
            //    string N = Console.ReadLine();
            //    if (Convert.ToInt32(N) < 0)
            //    {
            //        throw new IndexOutOfRangeException();
            //    }
            //    Console.Clear();
            //    Console.WriteLine("New number: ");
            //    for (int i = N.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(N[i]);
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Close");
            //    Environment.Exit(0);
            //}
            //Console.WriteLine();
            #endregion
            #endregion

            Motorcycle Motorcycle1 = new Motorcycle() {Cost = 1000};
            Motorcycle[] arr = new Motorcycle[5];
            Motorcycle1.Print();
            Motorcycle1.Print(ref Motorcycle1);
            arr[0] = new Motorcycle();
            arr[1] = new Motorcycle() { Cost = 1000 };
            arr[2] = new Motorcycle() { Cost = 2000, Name = "Supra" };
            arr[3] = new Motorcycle() { Cost = 3000, Name = "BMW", Petrol = true };
            arr[4] = new Motorcycle() { Cost = 4000, Name = "Mercedes", Petrol = true, Volume_engine = 24, Speed = 400 };
            foreach (var a in arr)
            {
                // a as IPrintable)?.Print();   -   null-safe access
                if (a is Motorcycle)
                {
                    (a as Motorcycle).Print();
                }
            }
        }
    }
}
