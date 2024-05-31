using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19
{
    delegate void message();
    class Game
    {
        //public 
        public void Start()
        {
            Console.WriteLine("========================================================================================");
            Sport_Car SPORT = new Sport_Car("Ferari", 10);
            Bus bus = new Bus("Mercedes", 8);
            Light_Car light = new Light_Car("T Supra A80", 20);
            Hard_Car hard = new Hard_Car("TRUCK", 10);
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", SPORT.Name, bus.Name, light.Name, hard.Name);
            Console.WriteLine("========================================================================================\n");

            while (true)
            {
                SPORT.Drive();
                bus.Drive();
                light.Drive();
                hard.Drive();

                if (SPORT.DrivenDistance >= 100 )
                {
                    message mes;
                    mes = SPORT.Finish;
                    mes();
                    break;
                }

                if (bus.DrivenDistance >= 100)
                {
                    message mes;
                    mes = bus.Finish;
                    mes();
                    break;
                }

                if (light.DrivenDistance >= 100)
                {
                    message mes;
                    mes = light.Finish;
                    mes();
                    break;
                }

                if (hard.DrivenDistance >= 100)
                {
                    message mes;
                    mes = hard.Finish;
                    mes();
                    break;
                }

                Console.WriteLine("{0}\t\t{1}\n\n{2}\t\t{3}\n\n{4}\t\t{5}\n\n{6}\t\t{7}", SPORT.Name, SPORT.DrivenDistance, bus.Name, bus.DrivenDistance, light.Name, light.DrivenDistance, hard.Name, hard.DrivenDistance);
                Console.WriteLine("========================================================================================");
            }
        }




    }
}

