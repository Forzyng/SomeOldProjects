using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace HW_9
{
    class StringPresenter<T>
    {
        public T value { get; set; }
        public Type type { get; set; }
        public void setValue(T t, StringPresenter<T> obj)
        {
            value = t;
            type = obj.GetType();
            Console.WriteLine("Value = {0}", t);
        }
        public void Show()
        {
            Console.WriteLine("Type - " + Convert.ToString(type) + " || Value - " + value ); 
        }
        public string ToString()
        {
            return "Type - " + Convert.ToString(type) + " || Value - " + value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sp = new StringPresenter<bool>();
            sp.setValue(true, sp);
            sp.Show(); 
            Console.WriteLine(sp.ToString()); 


            Console.ReadKey(true);

        }
    }
}
