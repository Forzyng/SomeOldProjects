using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DB_WForms_PR
{
    [Table(Name = "Countries")]
    public class Country
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "UNIQUEIDENTIFIER")]
        public Guid Id { get; set; }
        [Column]
        public string Name_Country { get; set; }
        [Column]
        public string Name_Capital { get; set; }
        [Column]
        public double Quantity_People { get; set; }
        [Column]
        public int Country_Area { get; set; }
        [Column]
        public string Name_Part_World { get; set; }


        //public override string ToString()
        //{
        //    return Name + " (" + Convert.ToString(Id) + ") ";
        //}
    }
    
}
