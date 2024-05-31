using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    // Основной класс для дробей
    class Fraction : IComparable
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        // Value - десятичное (FLOP) значение дроби
        public double Value { get { return (double)Numerator / Denominator; } }

        public override string ToString()
        {
            return $"({Numerator}/{Denominator})"; 
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
                Numerator = x.Numerator+y*x.Denominator,
                Denominator = x.Denominator
            }.Reduce();
        ///
        public static Fraction operator +(int y, Fraction x) => x + y;
        public static bool operator true(Fraction x) => x.Numerator != 0;
        public static bool operator false(Fraction x) => x.Numerator == 0;
        ///
        public static bool operator < (Fraction x, Fraction y)
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
        public static bool operator <( Fraction x, int y ) => x.Value < y;
        //
        //
        public static bool operator >(Fraction x, double y) => x.Value > y;
        public static bool operator >(double y, Fraction x) => x.Value > y;
        public static bool operator >(int y, Fraction x) => x.Value > y;
        public static bool operator >( Fraction x, int y) => x.Value > y;
        //
        //
        public static bool operator <=(Fraction x, double y) => x.Value <= y;
        public static bool operator <=(double y, Fraction x) => x.Value <= y;
        public static bool operator <=(int y, Fraction x) => x.Value <= y;
        public static bool operator <=( Fraction x, int y ) => x.Value <= y;
        //
        //
        public static bool operator >=(Fraction x, double y) => x.Value >= y;
        public static bool operator >=(double y, Fraction x) => x.Value >= y;
        public static bool operator >=(int y, Fraction x) => x.Value >= y;
        public static bool operator >=( Fraction x, int y ) => x.Value >= y;
        ///
        public static bool operator ==(Fraction x, Fraction y)
        {
            if (y?.Denominator == null) return (x?.Denominator == null);
            if (x?.Numerator == null) return (y?.Numerator == null);
            return x.Numerator* y.Denominator == y.Numerator * x.Denominator;
        }
        public static bool operator ==(Fraction x, int y) => x.Numerator * y ==  x.Denominator;
        public static bool operator ==(int y, Fraction x) => x.Numerator * y == x.Denominator;
        public static bool operator !=(Fraction x, Fraction y) => !(x == y);
        public static bool operator !=(Fraction x, int y) => !(x == y);
        public static bool operator !=(int y, Fraction x) => !(x == y);

        ///================================================================
        public static Fraction operator /(int y, Fraction x)
        {
            return new Fraction()
            {
                Denominator = x.Numerator,
                Numerator = y * x.Denominator
            }.Reduce();
        }
        public static Fraction operator -(Fraction x)
        {
            return new Fraction()
            {
                Denominator = -1 * x.Denominator,
                Numerator = -1 * x.Numerator
            };
        }
        ///================================================================ DZ

        public int this[int n] // Индексатор - Fraction[0] / Fraction[1]
        {
            get
            {
                if (n == 0)
                {
                    return Numerator ;
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
                    if(n == 1)
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
        }

        // Конструктор с параметрами
        public Fraction(int n)
        {
            Numerator = n;
            Denominator = 1;
        }

        public Fraction(int n, int k)
        {
            Numerator = n;
            Denominator = k;
        }

        // НОД - наибольший общий делитель / GCD
        // Инкапсуляция - описываем здесь
        private int gcd(int x,int y)
        {
            if(y == 0)
            {
                return x;
            }
            return gcd(y, x % y);
        }

        // Сокращение дроби - делим Ч и З на НОД
        public Fraction Reduce()
        {
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
}
