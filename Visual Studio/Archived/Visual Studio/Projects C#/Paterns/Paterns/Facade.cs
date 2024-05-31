using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Шаблон Фасад
 * Идея - предоставить набор функций
 * для работы со сложными системами (подсистемами)
 * 
 * Суть - несколько человеко-понятных функций
 * скрывают сложные механизмы вызовов подсистемных методов
 * 
 */
namespace Paterns
{
    class PizzaFacade // Упростить взаимодействие с билдером, предоставив удобство
    {
        Pizza pizab;
        public PizzaFacade()
        {
            pizab = new Pizza();
        }
        public void SetRoast(Roast roast)
        {
            switch (roast)
            {
                case Roast.Low:
                    pizab.SetRare(1);
                    break;
                case Roast.Medium:
                    pizab.SetRare(2);
                    break;
                case Roast.High:
                    pizab.SetRare(3);
                    break;
            }
        }
        public void SetDough(Dough dough)
        {
            switch (dough)
            {
                case Dough.American:
                    pizab.VariantsPizza(3);
                    break;
                case Dough.Italian:
                    pizab.VariantsPizza(4);
                    break;
            }

        }
        public void SetType(Type typ)
        {
            switch (typ)
            {
                case Type.Vegeterian:
                    pizab.VariantsPizza(1);
                    break;
                case Type.Plain:
                    pizab.VariantsPizza(2);
                    break;
            }
        }

        public void Show()
        {
            pizab.Show();
        }

    }

    public class FacadeShow
    {
        public void Show()
        {
            var p = new PizzaFacade();
            p.SetRoast(Roast.High);
            p.SetDough(Dough.American);
            p.SetType(Type.Vegeterian);
            p.Show();
            Console.WriteLine("=====================================");
            new FluidPizzaFacade().SetRoast(Roast.Low).SetDough((Dough)1).SetType((Type)1).Show();


            Console.ReadKey(true);
        }
    }


    class FluidPizzaFacade // Упростить взаимодействие с билдером, предоставив удобство
    {
        Pizza pizab;
        public FluidPizzaFacade()
        {
            pizab = new Pizza();
        }
        public FluidPizzaFacade SetRoast(Roast roast)
        {
            switch (roast)
            {
                case Roast.Low:
                    pizab.SetRare(1);
                    break;
                case Roast.Medium:
                    pizab.SetRare(2);
                    break;
                case Roast.High:
                    pizab.SetRare(3);
                    break;
            }
            return this;
        }
        public FluidPizzaFacade SetDough(Dough dough)
        {
            switch (dough)
            {
                case Dough.American:
                    pizab.VariantsPizza(3);
                    break;
                case Dough.Italian:
                    pizab.VariantsPizza(4);
                    break;
            }
            return this;
        }
        public FluidPizzaFacade SetType(Type typ)
        {
            switch (typ)
            {
                case Type.Vegeterian:
                    pizab.VariantsPizza(1);
                    break;
                case Type.Plain:
                    pizab.VariantsPizza(2);
                    break;
            }
            return this;
        }
        public void Show()
        {
            pizab.Show();
        }

    }

    public enum Type
    {
        Vegeterian,
        Plain
    }

    public enum Dough
    {
        American,
        Italian
    }

    public enum Roast
    {
        Low,
        Medium,
        High
    }

  
}
