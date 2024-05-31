using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_System_8
{
    public class Car
    {
        public string Factory { get; set; }
        public string Model { get; set; }
        public short Year { get; set; }
        public ConsoleColor Color { get; set; }
        public override string ToString()
        {
            return $"({Year}) {Model} - {Factory}, {Color}";
        }
    }
}
