using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2
{
    class Library
    {
        /*
         В фондах есть журналы (Номер, название), 
         книги (Название, автор), газеты (Название, дата).
         Обеспечить ПО для управление фондами
         */




    }


    abstract class Issue
    {
        public String Title { get; set; }

        public abstract String ToString();
        //{
        //    return "Issue";
        //}
    }


    class Journal : Issue // Наследование ":"
    {
        public int Number { get; set; }

        public override String ToString()
        {
            return $"Journal '{Title}' #{Number}";
        }


    }



    class Book : Issue 
    {
        public String Author { get; set; }

        public override String ToString()
        {
            return $"Book '{Title}' © {Author}";
        }
    }



    class Magazine : Issue
    {
        public DateTime Date { get; set; }

        public override String ToString()
        {
            return $"Newspaper '{Title}' In: {Date.ToLongDateString()}";
        }
    }

}
