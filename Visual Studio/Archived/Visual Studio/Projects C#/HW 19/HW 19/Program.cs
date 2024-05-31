using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Game gm = new Game();
            gm.Start();

            Console.Write("\n\nPress any key... ");
            Console.ReadKey(true);
        }
    }
}
