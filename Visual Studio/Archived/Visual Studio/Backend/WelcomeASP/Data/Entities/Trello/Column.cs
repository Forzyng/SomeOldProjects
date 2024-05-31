using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WelcomeASP.Data.Entities.Trello
{
    public class Column
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid BoardId { get; set; }
        public Board Board { get; set; }

        public string Title { get; set; }

        public List<Card> Cards { get; set; }

    }
}
