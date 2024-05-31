using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16
{


    public class ShowStrategy
    {
        public void Show()
        {
            var absolute = new Absolute();
            absolute.algorithms.Add(new DoubleVal());
            absolute.algorithms.Add(new VectorVal());
            absolute.algorithms.Add(new FractionVal());
            absolute.algorithms.Add(new ComplexVal());

            Console.WriteLine(absolute.Value(-12));
            Console.WriteLine(absolute.Value(new Vector { X = 3, Y = 4 }));
            Console.WriteLine(absolute.Value(new Fraction { Numerator = 1, Denominator = -4 }));
            Console.WriteLine(absolute.Value(new Complex { Number_One = 1, Number_Two = -5 }));
        }
    }




    public interface IValueable  // Strategy
    {
        double GetValue(object data); // Algorithm()
    }

    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Fraction 
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public static Fraction operator *(Fraction x, Fraction y)
        {
            return new Fraction()
            {
                Denominator = x.Denominator * y.Denominator,
                Numerator = y.Numerator * x.Numerator
            };
        }



        public static implicit operator double(Fraction a)
        {
            return (double)a.Numerator / (double)a.Denominator;
        }

    }

    class Complex
    {
        public float Number_One { get; set; }
        public float Number_Two { get; set; }

        public double MySqrt()
        {
            float sqrt = 0;
            sqrt = Number_One * Number_One + Number_Two * Number_Two;
            return (double)sqrt;
        }
    }

    class FractionVal : IValueable
    {
        public double GetValue(object data) // Algorithm()
        {
            Fraction fr = data as Fraction;
            if (fr == null)
            {
                throw new InvalidCastException("Fraction type expected");
            }
            return Math.Sqrt(fr*fr);
        }
    }

    class DoubleVal : IValueable  // ConcreteStrategy1
    {
        public double GetValue(object data) // Algorithm()
        {
            double d;
            try
            {
                d = Convert.ToDouble(data);
            }
            catch
            {
                throw;
            }
            return d < 0 ? -d : d;
        }
    }

    class ComplexVal : IValueable // ConcreteStrategy2
    {
        public double GetValue(object data) // Algorithm()
        {
            Complex v = data as Complex;
            if (v == null)
            {
                throw new InvalidCastException("Complex type expected");
            }
            return Math.Sqrt(v.MySqrt());
        }
    }

    class VectorVal : IValueable // ConcreteStrategy2
    {
        public double GetValue(object data) // Algorithm()
        {
            Vector v = data as Vector;
            if (v == null)
            {
                throw new InvalidCastException("Vector type expected");
            }
            return Math.Sqrt(v.X * v.X + v.Y * v.Y);
        }
    }

    class Absolute // Context
    {
        public List<IValueable> algorithms { get; set; } // Agregation algorithms

        public Absolute()
        {
            algorithms = new List<IValueable>();
        }



        public double Value(object data) // ContextMethod()
        {
            double res = 0;
            foreach (IValueable algorithm in algorithms)
            {
                try
                {
                    res = algorithm.GetValue(data);
                }
                catch
                {
                    continue;
                }
            }
            return res;
        }
    }
}
