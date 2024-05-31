using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DB_WForms_2
{
    class TestDbContext : DbContext
    {
            public TestDbContext(string NameOrConnectionString) : base(NameOrConnectionString) { }
            public DbSet<Gadget> Gadgets { get; set; }
    }
    public class Gadget
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Memory { get; set; }
        public float Display_Size { get; set; }
        public override string ToString()
        {
            return $"({Name} - {Type} - {Brand}), Memory: {Memory} | Display: {Display_Size}";
        }
    }
}
