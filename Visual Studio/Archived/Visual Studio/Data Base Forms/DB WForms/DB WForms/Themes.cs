using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DB_WForms
{
    [Table(Name = "Themes")]
    public class Themes
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "UNIQUEIDENTIFIER")]
        public Guid Id { get; set; }
        [Column]
        public string Name { get; set; }
        public override string ToString()
        {
            return Name + " (" + Convert.ToString(Id) + ") ";
        }
    }
}
