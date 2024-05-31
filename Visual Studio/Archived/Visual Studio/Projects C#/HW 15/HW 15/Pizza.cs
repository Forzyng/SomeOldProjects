using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_15
{
    interface PizzaBuilder
    {
        void SetRare(int n);
        void VariantsPizza(int n);
        void SetSize(int n);
        void Show();


        void ShowPizzas();
    }





    class Pizza : PizzaBuilder
    {
        String result = "Pizza";

        public void SetRare(int n)
        {

            switch (n)
            {
                case 1:
                    result = "Weak rare " + result;
                    break;
                case 2:
                    result = "Medium rare " + result;
                    break;
                case 3:
                    result = "Full rare " + result;
                    break;
            }
        }

        public void SetSize(int n)
        {
            switch (n)
            {
                case 1:
                    result = "Small size " + result;
                    break;
                case 2:
                    result = "Medium size " + result;
                    break;
                case 3:
                    result = "MEGA size " + result;
                    break;
            }
        }

        public void ShowPizzas()
        {
            Console.WriteLine("\n\tPizzas:");
            Console.WriteLine("Vegetariano");
            Console.WriteLine("Plaino");
            Console.WriteLine("Americano");
            Console.WriteLine("Italiano");
            Console.WriteLine();
        }

        public void VariantsPizza(int n)
        {
            switch (n)
            {
                case 1:
                    result += " Vegetariano";
                    break;
                case 2:
                    result += " Plaino";
                    break;
                case 3:
                    result += " Americano";
                    break;
                case 4:
                    result += " Italiano";
                    break;

            }
        }

        public void Show()
        {
            //var cmb = new Pizza();
            //cmb.ShowPizzas();
            //cmb.SetSize(2);
            //cmb.SetRare(2);
            //cmb.VariantsPizza(2);
            //Console.WriteLine();
            //Console.WriteLine(cmb.result);

            //var cmb2 = new Pizza();
            //cmb2.SetSize(3);
            //cmb2.SetRare(1);
            //cmb2.VariantsPizza(4);
            //Console.WriteLine();
            //Console.WriteLine(cmb2.result);

            //var cmb3 = new Pizza();
            //cmb3.SetSize(1);
            //cmb3.SetRare(3);
            //cmb3.VariantsPizza(1);
            //Console.WriteLine();
            Console.WriteLine(result);
        }
    }



    class ShowPizza
    {
        public void Show()
        {
            var cmb = new Pizza();
            cmb.ShowPizzas();
            cmb.SetSize(2);
            cmb.SetRare(2);
            cmb.VariantsPizza(2);
            Console.WriteLine();
            cmb.Show();

            var cmb2 = new Pizza();
            cmb2.SetSize(3);
            cmb2.SetRare(1);
            cmb2.VariantsPizza(4);
            Console.WriteLine();
            cmb2.Show();

            var cmb3 = new Pizza();
            cmb3.SetSize(1);
            cmb3.SetRare(3);
            cmb3.VariantsPizza(1);
            Console.WriteLine();
            cmb3.Show();
        }
    }






}
