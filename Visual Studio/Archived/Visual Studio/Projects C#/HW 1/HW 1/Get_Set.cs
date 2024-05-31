using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1
{
    partial class Motorcycle
    {
        public int Cost
        {
            get { return Value; }
            set { Value = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool Petrol
        {
            get { return petrol; }
            set { petrol = value; }
        }
        public int Volume_engine
        {
            get { return volume_engine; }
            set { volume_engine = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
