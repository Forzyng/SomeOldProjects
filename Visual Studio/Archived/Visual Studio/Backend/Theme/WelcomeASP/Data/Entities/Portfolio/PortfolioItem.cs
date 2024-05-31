using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WelcomeASP.Data.Entities.Portfolio
{
    public class PortfolioItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public Guid CategoryId { get; set; }

        public PortfolioCategory Category { get; set; }

    }
}
