using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDapperTest
{
    public class Countrie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Continent))
                return Name;
            else
                return $"{Name} ({Continent})";
        }
    }
}
