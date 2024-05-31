using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19
{
    public abstract class Autos
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int DrivenDistance { get; set; }
        public void Drive()
        {
            Random rand = new Random();
            int distancePerSec = rand.Next(1, MaxSpeed);

            DrivenDistance += distancePerSec;

            if (DrivenDistance >= 100)
            {
                MaxSpeed = 0;
            }
        }
        public abstract void Finish();
    }


    public class Sport_Car : Autos
    {
        public Sport_Car(string name, int maxspeed)
        {
            Name = name;
            MaxSpeed = maxspeed;
            DrivenDistance = 0;
        }

        public override void Finish()
        {
            Console.WriteLine("\n\n=====================");
            Console.WriteLine("|Спорткар финишировал|");
            Console.WriteLine("=====================");

        }
    }



    public class Bus : Autos
    {
        public Bus(string name, int maxspeed)
        {
            Name = name;
            MaxSpeed = maxspeed;
            DrivenDistance = 0;
  
        }
        
        public override void Finish()
        {
            Console.WriteLine("\n\n=====================");
            Console.WriteLine("|Автобус финишировал|");
            Console.WriteLine("=====================");

        }
    }

    public class Light_Car : Autos
    {
        public Light_Car(string name, int maxspeed)
        {
            Name = name;
            MaxSpeed = maxspeed;
            DrivenDistance = 0;
            
        }
  
        public override void Finish()
        {
            Console.WriteLine("\n\n=========================");
            Console.WriteLine("|Легковушка финишировала|");
            Console.WriteLine("=========================");

        }
    }

    public class Hard_Car : Autos
    {
   
        public Hard_Car(string name, int maxspeed)
        {
            Name = name;
            MaxSpeed = maxspeed;
            DrivenDistance = 0;
        }

        public override void Finish()
        {
            Console.WriteLine("\n\n======================");
            Console.WriteLine("|Грузовой финишировал|");
            Console.WriteLine("======================");

        }
    }


}
