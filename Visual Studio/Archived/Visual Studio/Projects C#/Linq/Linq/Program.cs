using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * LINQ - Language integrated queries
             * Query - запрос / Обычно запрос на манипуляцию с данными
             * Request - сетевой запрос
             * LINQ - SQL -> C#
             * Хранилище данных в языке - это массивы и коллекции
             * LINQ - технология (операторы и т.д.) для манипуляции с данными
             * из массивов и коллекций
             * 
             */

            List<User> users = new List<User>();
            users.Add(new User { ID = 1, Name = "User 1" });
            users.Add(new User { ID = 2, Name = "Admin 1" });
            users.Add(new User { ID = 3, Name = "Moderator 1" });
            users.Add(new User { ID = 4, Name = "User 2" });
            users.Add(new User { ID = 5, Name = "Tester 1" });


            List<Log> logs = new List<Log>();
            logs.Add(new Log { ID = 1, UserID = 2, Moment = new DateTime(2021, 3, 15, 18, 10, 10) });
            logs.Add(new Log { ID = 3, UserID = 4, Moment = new DateTime(2021, 1, 16, 18, 10, 10) });
            logs.Add(new Log { ID = 2, UserID = 3, Moment = new DateTime(2021, 3, 11, 18, 10, 10) });
            logs.Add(new Log { ID = 9, UserID = 7, Moment = new DateTime(2021, 3, 15, 17, 10, 10) });
            logs.Add(new Log { ID = 5, UserID = 6, Moment = new DateTime(2019, 3, 17, 18, 10, 10) });
            logs.Add(new Log { ID = 7, UserID = 1, Moment = new DateTime(2022, 3, 17, 17, 10, 10) });
            logs.Add(new Log { ID = 4, UserID = 5, Moment = new DateTime(2021, 3, 17, 18, 10, 10) });

            #region Query
            //var query1 = from u in users // Foreach ( u in users ) { return u }
            //             select u;

            ////Console.WriteLine(query1);

            //foreach(User user in query1)
            //{
            //    Console.WriteLine(user.ID + " - " + user.Name);
            //}

            //Console.WriteLine("==========================");

            //var query2 = from u in users // Foreach ( u in users ) { return u }
            //             where u.Name.Contains('e') || u.ID == 2// ~ if
            //             orderby u.Name // Сортировка
            //             select u.ID + " - " + u.Name;

            //foreach (String s in query2)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.WriteLine("==========================");

            //// Журнал в обратной хронологии
            //var query3 = from q in logs
            //             orderby q.Moment descending // Сортировка
            //             select q.ID + " - " + q.UserID + " - " + q.Moment;
            //foreach(String l in query3)
            //{
            //    Console.WriteLine(l);
            //}

            //// Журнал за сегодня
            //Console.WriteLine("==========================");
            //var query4 = from q in logs
            //             where q.Moment.Day == DateTime.Now.Day && q.Moment.Month == DateTime.Now.Month && q.Moment.Year == DateTime.Now.Year
            //             orderby q.Moment descending // Сортировка
            //             select q.ID + " - " + q.UserID + " - " + q.Moment;
            //foreach (String l in query4)
            //{
            //    Console.WriteLine(l);
            //}

            //Console.WriteLine("==========================");
            //var query5 = from q in logs
            //             where DateTime.Now.ToShortDateString()
            //             .Equals(q.Moment.ToShortDateString())
            //             orderby q.Moment descending // Сортировка
            //             select q.ID + " - " + q.UserID + " - " + q.Moment;
            //foreach (String l in query5)
            //{
            //    Console.WriteLine(l);
            //}
            #endregion

            #region Query6
            //int n = 1;
            //var query6 = from log in logs
            //             orderby log.Moment descending
            //             select new
            //             {
            //                 Date = log.Moment.ToShortDateString(),
            //                 User = log.UserID,
            //                 ID = log.ID,
            //                 Num = n++
            //             };
            //// Запускает ли query5.Count() запрос (Построение объектов)
            //Console.WriteLine(n);
            //Console.WriteLine("Count {0}", query6.Count());
            //Console.WriteLine(n);
            //// Да n меняет зачение, n++ меняет значения

            //// Использует ли ранее построенный результат?
            //foreach(var obj in query6)
            //{
            //    Console.WriteLine( obj.Num + " " + obj.ID + " " + obj.Date + "-" + obj.User );
            //}
            //// Нет объекты построены заново и числа в них 8,9...
            #endregion

            #region Query7
            // объеденение
            //var query7 = from log in logs
            //             join u in users on log.UserID equals u.ID
            //             orderby log.Moment descending
            //             select new
            //             {
            //                 Moment = log.Moment,
            //                 Name = u.Name
            //             };

            //foreach (var obj in query7)
            //{
            //    Console.WriteLine("{0} -- {1, -12} |", obj.Moment, obj.Name);
            //}
            #endregion

            #region Query8
            //var query7 = from log in logs
            //             join u in users on log.UserID equals u.ID
            //             orderby log.Moment descending
            //             select new
            //             {
            //                log,
            //                u
            //             };
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine    ("LId |   Moment               | LUid | Uid   | Uname           |");


            //foreach (var obj in query7)
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkCyan;
            //    Console.WriteLine("===============================================================");
            //    Console.ForegroundColor = ConsoleColor.DarkGreen;
            //    Console.WriteLine("{0, -3} | -- {1} | -- {2} | --  {3} | -- {4, -12} |", obj.log.ID, obj.log.Moment, obj.log.UserID, obj.u.ID, obj.u.Name);
            //}
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("===============================================================");
            #endregion

            //var query9 = from log in logs
            //             join u in users on log.UserID equals u.ID
            //             orderby u.Name 
            //             select new
            //             {
            //                 log,
            //                 u
            //             };
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("Uname           |   Moment               | LUid | Uid   | LId  |");


            //foreach (var obj in query9)
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkCyan;
            //    Console.WriteLine("================================================================");
            //    Console.ForegroundColor = ConsoleColor.DarkGreen;
            //    Console.WriteLine("-- {0, -12} | -- {1} | -- {2} | --  {3} | -- {4} |", obj.u.Name, obj.log.Moment, obj.log.UserID, obj.u.ID, obj.log.ID);
            //}
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("================================================================");


            var query10 = from log in logs
                         join u in users on log.UserID equals u.ID
                         orderby u.Name
                         select new
                         {
                             log,
                             u
                         };
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Uname           ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("|   ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Moment               ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("LUid ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Uid   ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("LId  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("|");


            foreach (var obj in query10)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("================================================================");


                if (obj.u.Name.Contains("User"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("-- ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("{0, -12} ", obj.u.Name);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| -- ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("{0} ", obj.log.Moment);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| -- ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("{0} ", obj.log.UserID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| --  ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("{0} ", obj.u.ID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| -- ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("{0} ",  obj.log.ID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("|");
                }
                if (obj.u.Name.Contains("Admin"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("-- ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("{0, -12} ", obj.u.Name);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| -- ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("{0} ", obj.log.Moment);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| -- ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("{0} ", obj.log.UserID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| --  ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("{0} ", obj.u.ID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| -- ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("{0} ", obj.log.ID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("|");
                }
                if (obj.u.Name.Contains("Moderator"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("-- ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0, -12} ", obj.u.Name);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| -- ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0} ", obj.log.Moment);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| -- ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0} ", obj.log.UserID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| --  ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0} ", obj.u.ID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("| -- ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("{0} ", obj.log.ID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("|");
                }




            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("================================================================");




            Console.ReadKey(true);
        }
    }

    class User
    {
        public int ID { get; set; }
        public String Name { get; set; }
    }

    class Log
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime Moment { get; set; }
    }


}
