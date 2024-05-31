using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace System_Threading_Join
{
    class Program
    {
        static List<User> UserList;
        static void Main(string[] args)
        {
            Console.WriteLine("Start receiving User List");
            Thread thread = new Thread(GetData);
            Console.WriteLine("Starting...\n");
            thread.Start();
            Console.WriteLine("Id \t| Login \t\t| Date");
            thread.Join();
            foreach(var item in UserList)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------------------------------------------");
            }
            Console.WriteLine("\n\nENTER to exit...");
            Console.ReadLine();
        }
        static void GetData()
        {
            UserList = new List<User>();
            for(int i = 1; i <= 25;i++)
            {
                UserList.Add(new User()
                {
                    Id = i,
                    Login = "User " + i.ToString()
                });
                Thread.Sleep(200);

            }
            Console.WriteLine("---------------------------------------------------------");
        }
    }
    class User
    {
        public User()
        {
            RegisterDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public DateTime RegisterDate { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} \t| Login: {Login} \t| RegistrDate: {RegisterDate.ToShortDateString()}";
        }
    }
}
