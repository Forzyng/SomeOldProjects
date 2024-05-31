using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats
{
    delegate void PrintMean(List<double> values);

    class Demo
    {
        public void Show()
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6 };

            List<Mean> means = new List<Mean>();
            means.Add(new MeanArithmetic());
            means.Add(new MeanGeometric());


            PrintMean printMean = means[0].CalcAndShow;
            for (int i = 1; i < means.Count; i++)
                printMean += means[1].CalcAndShow;

            printMean(numbers);
        }
    }

    abstract class Mean
    {
        public abstract void CalcAndShow(List<double> values);
    }

    class MeanArithmetic : Mean
    {
        public override void CalcAndShow(List<double> values)
        {
            double s = 0;
            foreach (double v in values)
                s += v;
            Console.WriteLine(s / values.Count);
        }
    }

    class MeanGeometric : Mean
    {
        public override void CalcAndShow(List<double> values)
        {
            double s = 1;
            foreach (double v in values)
                s *= v;
            Console.WriteLine(Math.Pow(s, (1.0 / values.Count)));
        }
    }
}