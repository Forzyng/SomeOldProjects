using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns
{
    interface PizzaBuilder
    {
        void SetRare(int n);
        void VariantsPizza(int n);
        void SetSize(int n);
        void Show();
        //void SetDescription();
        double GetPrice();

        void ShowPizzas();
    }





    class Pizza : PizzaBuilder
    {
        String result = "Pizza";
        String[] arr = new string[6];
        //public void SetDescription()
        //{
           
        //    arr[0] = "Pizza";
        //    arr[1] = "Italiano ";
        //    arr[2] = "Americano ";
        //    arr[3] = "Vegetariano ";
        //    arr[4] = "Studento ";
        //    arr[5] = "Defaulto ";

        //}

        public double GetPrice()
        {
            return 40;
        }

        public void SetRare(int n)
        {
            
            switch(n)
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
            //int i = 1;
            //while(i < arr.Length)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            
        }

        public void VariantsPizza(int n)
        {
            //result = arr[n].ToString() + result;
            switch(n)
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
    
            //cmb.SetSize(2);
            //cmb.SetRare(2);
            //cmb.VariantsPizza(2);
            //Console.WriteLine();
            Console.WriteLine(result);
        }
    }




}
