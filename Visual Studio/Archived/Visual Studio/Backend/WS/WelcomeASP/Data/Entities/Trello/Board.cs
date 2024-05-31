using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace WelcomeASP.Data.Entities.Trello
{
    public class Board
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Title { get; set; }
        public ICollection<TrelloTag> Tags { get; set; }

        public List<Column> Columns { get; set; }

        /// <summary>
        /// Ссылка на изображение, в случае, если файл будет хранится в файловой системе
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// Поле в базе, где будет храниться тело изображения
        /// </summary>
        public byte[] Logo { get; set; }

        //[NotMapped]
        //public IFormFile fileToStorage { get; set; }

        //[NotMapped]
        //public IFormFile fileToDB { get; set; }



    }
}
