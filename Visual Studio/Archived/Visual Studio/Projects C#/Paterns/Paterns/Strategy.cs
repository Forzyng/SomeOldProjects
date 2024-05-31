using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns
{
    public class ShowStrategy
    {
        public void Show()
        {
            var absolute = new Absolute();
            absolute.algorithms.Add(new DoubleVal());
            absolute.algorithms.Add(new VectorVal());

            Console.WriteLine(absolute.Value(-12));
            Console.WriteLine(absolute.Value(new Vector {X = 3, Y = 4 }));
        }
    }

    /*
     * 
     * Шаблон Стратегия позволяет создать, сохранить
     * набор методов (алгоритмов), например обработки данных
     * 
     * Шаблон позволяет менять алгоритмы "на лету" - во время выполнения программы
     * в частности, подбирать "нужный" алгоритм по типу входных данных
     * 
     * Паттерн неактуален с применением функциональной парадигмы, ~ делегатов / lambda
     * 
     */

    /*
     * 
     * Реализовать класс Absolute
     * для различных типов данных. Для примера двух - число и вектор
     * алгоритм для числа - обычный модуль (без знака)
     * для вектора - его длина
     * 
     * Absolute.Value (-12) -> 12
     * Absolute.Value (Vector(3,4)) -> 5
     * 
     */

    public interface IValueable  // Strategy
    {
        double GetValue(object data); // Algorithm()
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

    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }


    }

    class VectorVal : IValueable // ConcreteStrategy2
    {
        public double GetValue(object data) // Algorithm()
        {
            Vector v = data as Vector;
            if(v == null)
            {
                throw new InvalidCastException("Vector type expected");
            }
            return Math.Sqrt(v.X * v.X + v.Y * v.Y);
        }
    }

    class Absolute // Constext
    {
        public List<IValueable> algorithms { get; set; } // Agregation algorithms

        public Absolute()
        {
            algorithms = new List<IValueable>();
        }


        public double Value(object data) // ContextMethod()
        {
            double res = 0;
            foreach(IValueable algorithm in algorithms)
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
