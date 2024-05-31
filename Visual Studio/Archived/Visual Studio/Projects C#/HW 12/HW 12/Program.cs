using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    class Program
    {
        static void Main(string[] args)
        {




            List<User> users = new List<User>();
            users.Add(new User { ID = 1, Name = "User 1" });
            users.Add(new User { ID = 2, Name = "Admin 1" });
            users.Add(new User { ID = 3, Name = "Moderator 1" });
            users.Add(new User { ID = 4, Name = "User 2" });
            users.Add(new User { ID = 5, Name = "Tester 1" });
            users.Add(new User { ID = 6, Name = "Not User 1" });


            List<Log> logs = new List<Log>();
            logs.Add(new Log { ID = 1, UserID = 2, Moment = new DateTime(2021, 3, 15, 18, 10, 10) });
            logs.Add(new Log { ID = 3, UserID = 4, Moment = new DateTime(2021, 1, 16, 18, 10, 10) });
            logs.Add(new Log { ID = 2, UserID = 3, Moment = new DateTime(2021, 3, 11, 18, 10, 10) });
            logs.Add(new Log { ID = 9, UserID = 2, Moment = new DateTime(2021, 3, 15, 17, 10, 10) });
            logs.Add(new Log { ID = 5, UserID = 6, Moment = new DateTime(2019, 3, 17, 18, 10, 10) });
            logs.Add(new Log { ID = 7, UserID = 1, Moment = new DateTime(2022, 3, 17, 17, 10, 10) });
            logs.Add(new Log { ID = 4, UserID = 5, Moment = new DateTime(2021, 3, 17, 18, 10, 10) });
            logs.Add(new Log { ID = 10, UserID = 2, Moment = new DateTime(2021, 3, 13, 14, 10, 10) });
            logs.Add(new Log { ID = 11, UserID = 3, Moment = new DateTime(2021, 3, 12, 16, 10, 10) });
            logs.Add(new Log { ID = 12, UserID = 1, Moment = new DateTime(2021, 3, 17, 16, 10, 10) });
            logs.Add(new Log { ID = 13, UserID = 1, Moment = new DateTime(2021, 3, 22, 16, 10, 10) });
            logs.Add(new Log { ID = 14, UserID = 4, Moment = new DateTime(2021, 5, 1, 16, 10, 10) });
            //17.03
            //1
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\t\t HW 17.03");
            Console.WriteLine();
            var query9 = from log in logs
                          join u in users on log.UserID equals u.ID
                          where u.Name.Equals("User 1")
                          orderby log.Moment
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



            foreach (var obj in query9)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("================================================================");
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
                Console.Write("{0} ", obj.log.ID);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("|");
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("================================================================");

            Console.WriteLine();
            Console.WriteLine();

            //2
            String today = DateTime.Now.ToShortDateString();

            var query10 = from log in logs
                         join u in users on log.UserID equals u.ID
                          where log.Moment.ToShortDateString()
                               .Equals(today) &&  u.Name.Equals("User 1")
                         orderby log.Moment
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
                Console.Write("{0} ", obj.log.ID);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("|");
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("================================================================");

            Console.WriteLine();
            Console.WriteLine();






            //3
            var query11 = from log in logs
                          join u in users on log.UserID equals u.ID
                          where u.Name.StartsWith("User")
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


            foreach (var obj in query11)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("================================================================");
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
                    Console.Write("{0} ", obj.log.ID);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("|");
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("================================================================");

            Console.WriteLine();
            Console.WriteLine();














            int n = 0;
            Console.WriteLine("\t\t HW 18.03");
            Console.WriteLine();
            //18.03
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Uname              ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("|   ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Moment               ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("| ");

            Console.WriteLine("=============================================");
            var query12 = from log in logs
                          join u in users on log.UserID equals u.ID
                          orderby u.Name
                          group log by u.Name into g                        
                          select new
                               {
                                   Name = g.Key,
                                   Count = g.Count(),
                                   P = g.Select(p => p)
                               };

            foreach (var group in query12)
            {

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("-- ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("{0, -12} : {1}", group.Name, group.Count);

                foreach (Log obj in group.P)
                {
                    if(n < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("| -- ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("{0} ", obj.Moment);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("| ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("                   | -- ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("{0} ", obj.Moment);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("| ");
                    }
                    n++;
                }
                n = 0;
                Console.WriteLine("=============================================");
            }


            Console.WriteLine();
            Console.WriteLine();











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
