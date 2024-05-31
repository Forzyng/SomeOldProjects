using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationFirst.Data.Entities.Trello
{
    public class Card
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Tittle { get; set; }
        public Guid ColumnId { get; set; }
        public Column Column { get; set; }
        public string Body { get; set; }
    }
}
