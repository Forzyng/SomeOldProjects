/*
 * 
 * Fractions - работа с дробями
 * 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        #region Interface
        // Интерфейсы 
        // Интерфейс (в ООП) -
        // абстрактный класс, в котором 
        // только public методы
        // только абстрактные методы
        // классы наследуют (extends), интерфейсы реализуют (implements)

        //interface IPrintable // строго рекомендуеться начинать с I и заканчивать -able
        //{
        //    void Print(); // тела нет - абстрактный
        //}



        //class Parent : IComparable
        //{
        //    public virtual String getName() { return "Parent"; }

        //    public int CompareTo(object obj)
        //    {
        //        // 1 this >  obj
        //        // 0 this == obj
        //        // -1 this < obj
        //        if(obj == null)
        //        {
        //            return 1;
        //        }
        //        Parent p = obj as Parent;
        //        if(p == null) // obj не типа Parent
        //        {
        //            throw new InvalidOperationException("Compare Parent with non-Parent");
        //        }
        //        else // p - Parent
        //        {
        //            return n.CompareTo(p.n); // сравниваем this.n и p.n
        //        }
        //    }

        //    public int n { get; set; }
        //}

        //class Child1 : Parent, IPrintable
        //{
        //    public override String getName() { return "CHILD1 " + n; }
        //    public void Print()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        //class Child2 : Parent
        //{
        //    public override String getName() { return "CHILD2 " + n; }

        //}

        //class InverseSorter : IComparer<Parent>
        //{
        //    public int Compare(Parent x, Parent y)
        //    {
        //        return -x.CompareTo(y);
        //    }
        //}
        //class NameSorter : IComparer<Parent>
        //{
        //    public int Compare(Parent x, Parent y)
        //    {
        //        return x.getName().CompareTo(y.getName());
        //    }
        //}
        #endregion


        static void Main(string[] args)
        {
            Fraction x;
            x = new Fraction() { Numerator = 3, Denominator = 0 };
            //
            var y = new Fraction(4, 7);

            // x.Numerator = 3;
            // x.Denominator = 7;

            Console.WriteLine("{0} = {1}", x, x.Value);
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            //Console.WriteLine(x + 1);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x > 0.1);
            //Console.WriteLine(x < 0.1);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x == y);
            //Console.WriteLine(x == 2);
            //Console.WriteLine(x != 2);
            

            // Интерфейсы на примере сортировки
            //List<Fraction> fractions = new List<Fraction>();
            //fractions.Add(x);
            //fractions.Add(new Fraction { Numerator = 1, Denominator = 2 });
            //fractions.Add(new Fraction { Numerator = 1, Denominator = 5 });
            //fractions.Add(new Fraction { Numerator = 1, Denominator = 4 });
            //fractions.Add(new Fraction { Numerator = 1, Denominator = 3 });
            //fractions.Sort();
            //fractions.ForEach(Console.WriteLine);

            #region Interface_main
            //List<Parent> arr = new List<Parent>();
            //arr.Add(new Child1() { n = 1 });
            //arr.Add(new Child2() { n = 8 });
            //arr.Add(new Child2() { n = 3 });
            //arr.Add(new Child1() { n = 9 });
            //arr.Add(new Child1() { n = 4 });
            //arr.Add(new Child2() { n = 6 });
            ////arr.Sort();
            ////foreach (var a in arr)
            ////{
            ////    // a as IPrintable)?.Print();   -   null-safe access
            ////    if (a is IPrintable)
            ////    {
            ////        (a as IPrintable).Print();
            ////    }
            ////}
            ////arr.Sort(new InverseSorter());
            //arr.Sort(new NameSorter());
            //arr.ForEach(a => { Console.WriteLine(a.getName()); });
            #endregion
            Console.ReadKey();
        }
    }
}
