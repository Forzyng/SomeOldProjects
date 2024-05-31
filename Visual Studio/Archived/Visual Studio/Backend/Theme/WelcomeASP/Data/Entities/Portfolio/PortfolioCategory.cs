using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WelcomeASP.Data.Entities.Portfolio
{
    public class PortfolioCategory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Display(Name =" Название категории")]
        public string Name { get; set; }

        public string Slug { get; set; }

        public List<PortfolioItem> Items { get; set; }

    }
}
