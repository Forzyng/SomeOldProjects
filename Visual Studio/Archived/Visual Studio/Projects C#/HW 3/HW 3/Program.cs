using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    class Fraction : IComparable
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public int Full { get; set; }

        // Value - десятичное (FLOP) значение дроби
        public double Value { get { return (double)Numerator / Denominator; } }

        public override string ToString()
        {
            return $"{Full}({Numerator}/{Denominator})";
        }

        // Перегрузка операторов
        public static Fraction operator +(Fraction x, Fraction y)
        {
            return new Fraction()
            {

                Denominator = x.Denominator * y.Denominator,
                Numerator = x.Numerator * y.Denominator + y.Numerator * x.Denominator
            }.Reduce();
        }

        public static Fraction operator -(Fraction x, Fraction y)
        {
            return new Fraction()
            {

                Denominator = x.Denominator * y.Denominator,
                Numerator = x.Numerator * y.Denominator - y.Numerator * x.Denominator
            }.Reduce();
        }

        public static Fraction operator +(Fraction x, int y)
       => // стрелочное выражение / arrow notation
            new Fraction()
            {
                Numerator = x.Numerator + y * x.Denominator,
                Denominator = x.Denominator
            }.Reduce();
        ///
        public static Fraction operator +(int y, Fraction x) => x + y;
        #region Last
        //public static bool operator true(Fraction x) => x.Numerator != 0;
        //public static bool operator false(Fraction x) => x.Numerator == 0;
        /////
        //public static bool operator <(Fraction x, Fraction y)
        //{
        //    return x.Value < y.Value;
        //}
        //public static bool operator >(Fraction x, Fraction y) => x.Value > y.Value;
        /////  
        //public static bool operator <=(Fraction x, Fraction y) => x.Value <= y.Value;
        //public static bool operator >=(Fraction x, Fraction y) => x.Value >= y.Value;
        ////
        //public static bool operator <(Fraction x, double y) => x.Value < y;
        //public static bool operator <(double y, Fraction x) => x.Value < y;
        //public static bool operator <(int y, Fraction x) => x.Value < y;
        //public static bool operator <(Fraction x, int y) => x.Value < y;
        ////
        ////
        //public static bool operator >(Fraction x, double y) => x.Value > y;
        //public static bool operator >(double y, Fraction x) => x.Value > y;
        //public static bool operator >(int y, Fraction x) => x.Value > y;
        //public static bool operator >(Fraction x, int y) => x.Value > y;
        ////
        ////
        //public static bool operator <=(Fraction x, double y) => x.Value <= y;
        //public static bool operator <=(double y, Fraction x) => x.Value <= y;
        //public static bool operator <=(int y, Fraction x) => x.Value <= y;
        //public static bool operator <=(Fraction x, int y) => x.Value <= y;
        ////
        ////
        //public static bool operator >=(Fraction x, double y) => x.Value >= y;
        //public static bool operator >=(double y, Fraction x) => x.Value >= y;
        //public static bool operator >=(int y, Fraction x) => x.Value >= y;
        //public static bool operator >=(Fraction x, int y) => x.Value >= y;
        /////
        //public static bool operator ==(Fraction x, Fraction y)
        //{
        //    if (y?.Denominator == null) return (x?.Denominator == null);
        //    if (x?.Numerator == null) return (y?.Numerator == null);
        //    return x.Numerator * y.Denominator == y.Numerator * x.Denominator;
        //}
        //public static bool operator ==(Fraction x, int y) => x.Numerator * y == x.Denominator;
        //public static bool operator ==(int y, Fraction x) => x.Numerator * y == x.Denominator;
        //public static bool operator !=(Fraction x, Fraction y) => !(x == y);
        //public static bool operator !=(Fraction x, int y) => !(x == y);
        //public static bool operator !=(int y, Fraction x) => !(x == y);
        #endregion
        ///================================================================
        public static Fraction operator /(int y, Fraction x)
        {
            return new Fraction()
            {
                Denominator = x.Numerator,
                Numerator = y * x.Denominator
            }.Reduce();
        }
        public static Fraction operator /(Fraction x, int y)
        {
            return new Fraction()
            {
                Denominator = x.Numerator,
                Numerator = y * x.Denominator
            }.Reduce();
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction()
            {
                Denominator = a.Numerator * b.Denominator,
                Numerator = a.Denominator * b.Numerator
            }.Reduce();
        }



        public static Fraction operator *(Fraction a, Fraction b)
        => 
        new Fraction()
        {
          Numerator =  a.Numerator * b.Numerator,
          Denominator = a.Denominator * b.Denominator
        }.Reduce1();
        public static Fraction operator *(Fraction a, int y)
        =>
        new Fraction()
        {
            Numerator = a.Numerator * y,
            Denominator = a.Denominator 
        }.Reduce1();
        public static Fraction operator *(int y, Fraction a)
        =>
        new Fraction()
        {
            Numerator = a.Numerator * y,
            Denominator = a.Denominator
        }.Reduce1();
        public static Fraction operator +(Fraction a) => a;



        ///================================================================ DZ


        public static bool operator true(Fraction x) => x.Numerator != 0;
        public static bool operator false(Fraction x) => x.Numerator == 0;
        ///
        public static bool operator <(Fraction x, Fraction y)
        {
            return x.Value < y.Value;
        }
        public static bool operator >(Fraction x, Fraction y) => x.Value > y.Value;
        ///  
        public static bool operator <=(Fraction x, Fraction y) => x.Value <= y.Value;
        public static bool operator >=(Fraction x, Fraction y) => x.Value >= y.Value;
        //
        public static bool operator <(Fraction x, double y) => x.Value < y;
        public static bool operator <(double y, Fraction x) => x.Value < y;
        public static bool operator <(int y, Fraction x) => x.Value < y;
        public static bool operator <(Fraction x, int y) => x.Value < y;
        //
        //
        public static bool operator >(Fraction x, double y) => x.Value > y;
        public static bool operator >(double y, Fraction x) => x.Value > y;
        public static bool operator >(int y, Fraction x) => x.Value > y;
        public static bool operator >(Fraction x, int y) => x.Value > y;
        //
        //
        public static bool operator <=(Fraction x, double y) => x.Value <= y;
        public static bool operator <=(double y, Fraction x) => x.Value <= y;
        public static bool operator <=(int y, Fraction x) => x.Value <= y;
        public static bool operator <=(Fraction x, int y) => x.Value <= y;
        //
        //
        public static bool operator >=(Fraction x, double y) => x.Value >= y;
        public static bool operator >=(double y, Fraction x) => x.Value >= y;
        public static bool operator >=(int y, Fraction x) => x.Value >= y;
        public static bool operator >=(Fraction x, int y) => x.Value >= y;
        ///
        public static bool operator ==(Fraction x, Fraction y)
        {
            if (y?.Denominator == null) return (x?.Denominator == null);
            if (x?.Numerator == null) return (y?.Numerator == null);
            return x.Numerator * y.Denominator == y.Numerator * x.Denominator;
        }
        public static bool operator ==(Fraction x, int y) => x.Numerator * y == x.Denominator;
        public static bool operator ==(int y, Fraction x) => x.Numerator * y == x.Denominator;
        public static bool operator !=(Fraction x, Fraction y) => !(x == y);
        public static bool operator !=(Fraction x, int y) => !(x == y);
        public static bool operator !=(int y, Fraction x) => !(x == y);

        
        public static implicit operator double(Fraction a)
        {
            return (double)a.Numerator / (double)a.Denominator;
        }




        ///================================================================ DZ

        public int this[int n] // Индексатор - Fraction[0] / Fraction[1]
        {
            get
            {
                if (n == 0)
                {
                    return Numerator;
                }
                else
                {
                    if (n == 1)
                    {
                        return Denominator;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Index should be 0 or 1");
                    }
                }
            }
            set
            {
                if (n == 0)
                {
                    Numerator = value; // value - то, что присваиваеться
                }
                else
                {
                    if (n == 1)
                    {
                        Denominator = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException("Index should be 0 or 1");
                    }
                }
            }
        }

        ///

        // Конструктор
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
            Full = 0;
        }

        // Конструктор с параметрами
        public Fraction(int n)
        {
            Numerator = n;
            Denominator = 1;
            Full = 0;
        }

        public Fraction(int n, int k)
        {
            Numerator = n;
            Denominator = k;
            Full = 0;
        }

        public Fraction(int n, int k, int d)
        {
            Numerator = n;
            Denominator = k;
            Full = d;
        }

        // НОД - наибольший общий делитель / GCD
        // Инкапсуляция - описываем здесь
        private int gcd(int x, int y)
        {
            if(x == y)
            {
                return Full += 1;
            }
            if (y == 0)
            {
                return x;
            }
            else
            {
                Full = x / y;
            }
            return gcd(y, x % y);
        }
        public int CheckReturn(int n, int d)
        {
            if(Numerator > Denominator)
            {
                return Numerator - Denominator;
            }
            return Numerator;
        }

        // Сокращение дроби - делим Ч и З на НОД
        public Fraction Reduce1()
        {
            return new Fraction()
            {
                Denominator = Denominator / gcd(Numerator, Denominator),
                Numerator = Numerator / gcd(Numerator, Denominator)

            };
        }
        public Fraction Reduce()
        {
            while (Numerator > Denominator)
            {
                 return new Fraction()
                 {
                     Full = Numerator / Denominator,
                     Denominator = Denominator / gcd(Numerator, Denominator),
                     Numerator = Numerator / CheckReturn(Numerator, Denominator)
                 };
            }
            if (Numerator == Denominator)
            {
                return new Fraction()
                {
                    Full = Numerator / Denominator,
                    Denominator = 0,
                    Numerator = 0
                };
            }
            return new Fraction()
            {
                Denominator = Denominator / gcd(Numerator, Denominator),
                Numerator = Numerator / gcd(Numerator, Denominator)

            };
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Fraction p = obj as Fraction;
            if (p == null) // obj не типа Parent
            {
                throw new InvalidOperationException("Compare Parent with non-Parent");
            }
            else // p - Parent
            {
                return (Numerator * p.Denominator).CompareTo(p.Numerator * Denominator); // сравниваем this.n и p.n
            }



        }
    }

   

    class Program
    {
        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        static void Main(string[] args)
        {
            Fraction x;
            x = new Fraction() { Numerator = 7, Denominator = 7 };
            //
            var y = new Fraction(8, 7);

            Fraction k;
            k = new Fraction() { Numerator = 5, Denominator = 7 };
            //
            var z = new Fraction(5, 7);
            // x.Numerator = 3;
            // x.Denominator = 7;
          


            double d = 2;
                int di = 1;
                while (d % 1 != 0)
                {
                    d *= 10;
                    di *= 10;
                }
                int g = GCD((int)d, di);
            int Num = (int)d / g;
            int Den = di / g;
            var u = new Fraction(Num, Den);
            Console.WriteLine(u);






            Console.WriteLine("{0} = {1}", x, x.Value);
            Console.WriteLine(x + y);
            Console.WriteLine(y - x);
            Console.WriteLine(k * z);
            Console.WriteLine(k / z);
            Console.ReadKey();
        }
    }
}
