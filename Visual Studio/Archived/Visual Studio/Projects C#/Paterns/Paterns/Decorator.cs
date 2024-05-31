using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns
{
        /*
         * 
         * HotDog
         * 
         */

    interface Product // Component
    {
        String GetDescription();
        double GetPrice();
    }

    class HotDog : Product
    {
        public string GetDescription()
        {
            return "HotDog";
        }

        public double GetPrice()
        {
            return 50;
        }
    }

    public class ShowDecorator
    {
        public void Show()
        {
            Product product = new HotDog();
            Console.WriteLine("Check: " + product.GetDescription() + " " + product.GetPrice());

            
            // Расширение - решили добавить дополнения (+ Кетчуп, + Горчица, + Майонез)
            Product product2 = new HotDog();
            product2 = new Ketchup(product2);
            Console.WriteLine("Check: " + product2.GetDescription() + " " + product2.GetPrice());

            Product product3 = new HotDog();
            product3 = new Ketchup(product3);
            product3 = new Mayonez(product3);
            Console.WriteLine("Check: " + product3.GetDescription() + " " + product3.GetPrice());

            Console.ReadKey(true);
        }
    }

    abstract class Decorator : Product
    {
        protected Product BaseProduct; // aggregation - основа, которую декорируем
        public Decorator(Product p)
        {
            BaseProduct = p;
        }

        public abstract string GetDescription();
        public abstract double GetPrice();
    }

    class Ketchup : Decorator
    {
        public Ketchup(Product p) : base(p) { }

        public override string GetDescription()
        {
            return BaseProduct.GetDescription() + " + ketchup";
        }

        public override double GetPrice()
        {
            return BaseProduct.GetPrice() + 5;
        }
    }

    class Mayonez : Decorator
    {
        public Mayonez(Product p) : base(p) { }
        public override string GetDescription()
        {
            return BaseProduct.GetDescription() + " + mayonez";
        }

        public override double GetPrice()
        {
            return BaseProduct.GetPrice() + 4.99;
        }
    }
}
