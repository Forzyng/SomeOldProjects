using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats
{
    class Average
    {
        delegate double MeanValue(List<double> values);
        delegate void PrintMean(List<double> values);
        public void Show()
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6 };

            MeanValue method;

            method = this.Arithmetic;
            //Console.WriteLine(method(numbers));
            method += this.Geometric; // Вывод только последнего значения
            Console.WriteLine(method(numbers));
            //Console.WriteLine(this.Arithmetic(numbers));
            //Console.WriteLine(this.Geometric(numbers));
            Console.WriteLine("================");
            PrintMean printMethods;
            printMethods = PrintArithmetic;
            printMethods += PrintGeometric;
            printMethods.Invoke(numbers);

        }

        double Arithmetic(List<double> values)
        {
            double s = 0;
            foreach(double v in values)
            {
                s += v;
            }
            return s / values.Count;
        }

        double Geometric(List<double> values)
        {
            double s = 1;
            foreach (double v in values)
            {
                s *= v;
            }
            return Math.Pow(s, (1.0 / values.Count)) ;
        }

        void PrintArithmetic(List<double> values)
        {
            Console.WriteLine($"{Arithmetic(values)} - DAS IST ARITHMETIC");
        }

        void PrintGeometric(List<double> values)
        {
            Console.WriteLine($"{Geometric(values)} - DAS IST GEOMETRIC");
        }




    }
}
