using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Library;

namespace Console_DDL
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User { Id = Guid.NewGuid(), Name = "User 1", Login = "Login 1", Password = "123456789" });
            users.Add(new User { Id = Guid.NewGuid(), Name = "User 2", Login = "Login 2", Password = "987654321" });
            users.Add(new User { Id = Guid.NewGuid(), Name = "User 3", Login = "Login 3", Password = "1209348756" });

            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
            Console.Write("\nPress any Key... ");
            Console.ReadKey(true);
        }
    }
}
