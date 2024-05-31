using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HW_13
{
    class Program
    {
       
            const String UserFileName = "users.txt";
            static void Main(string[] args)
            {
            //List<User> users = new List<User>();
            //users.Add(new User { Login = "User 1", Name = "Andrey", Password = "123456789" });
            //users.Add(new User { Login = "User 2", Name = "Misha", Password = "123456789" });
            //users.Add(new User { Login = "User 3", Name = "Oleg", Password = "123456789" });
            //users.Add(new User { Login = "User 4", Name = "Guzul", Password = "123456789" });
            //users.Add(new User { Login = "User 5", Name = "Seedruner", Password = "123456789" });
            //BinaryFormatter serializer = new BinaryFormatter();

            //using (FileStream writer = new FileStream(UserFileName, FileMode.CreateNew))
            //{
            //    serializer.Serialize(writer, users);
            //}

            Reg(args);
                //Auth(args);
            }
            static void Auth(string[] args)
            {

                String  UserPassword = String.Empty;
            String UserLogin = String.Empty;
          
                Console.Write("Login: ");
                UserLogin = Console.ReadLine();
                Console.Write("Password: ");

                bool checker = false;
            while(checker == false)
            {
                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        checker = true;
                        break;
                    }
                    if (key.Key == ConsoleKey.Backspace)
                    {
                        UserPassword = String.Empty;
                    }
                    else
                    {
                        UserPassword += key.KeyChar;
                        Console.Write("*");
                    }

                }
            }
            if(checker == false)
                {
                User user;

                BinaryFormatter deserializer = new BinaryFormatter();
                using (FileStream reader = new FileStream(UserFileName, FileMode.Open))
                {
                    var query = from u in (List<User>)deserializer.Deserialize(reader)
                                where u.Login == UserLogin && u.Password == UserPassword
                                select u;

                    user = query.FirstOrDefault();
                }
                if (user == null)
                {
                    Console.WriteLine("\nAcces denied");
                }
                else
                {
                    Console.WriteLine("\nHello, {0}", user.Name);
                }
            }
            else
            {
                Console.Write("\nExit> ");

            }
                
                //UserPassword = Console.ReadLine();

                


                Console.ReadKey(true);
            }
            static void Reg(string[] args)
            {

            String UserLogin = string.Empty;
            String UserPassword = String.Empty;
            String UserName = String.Empty;
            List<User> users;

            BinaryFormatter formatt = new BinaryFormatter();
            using (FileStream reader = new FileStream(UserFileName, FileMode.Open))
            {
                users = (List<User>)formatt.Deserialize(reader);
            }
            bool check = true;
           

            bool checker = false;
            while (checker == false)
            {
                Console.Clear();
                Console.Write("Login: ");
                UserLogin = Console.ReadLine();



                foreach (var s in users)
                {
                    if (s.Login == UserLogin)
                    {
                        Console.WriteLine("\nLogin have already been taken");
                        check = false;
                        checker = true;
                    }
                }
                if(check != false)
                {
                    if (UserLogin.Length < 3)
                    {
                        Console.WriteLine("\nUser login must be 3 and more symbols");
                       
                    }
                    else
                    {



                        Console.Write("Password: ");
                        while (true)
                        {
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                            if (key.Key == ConsoleKey.Escape)
                            {
                                UserPassword = String.Empty;
                            }
                            if (key.Key == ConsoleKey.Backspace)
                            {
                                UserPassword = String.Empty;
                            }
                            else
                            {
                                UserPassword += key.KeyChar;
                                Console.Write(key.KeyChar);
                            }

                        }


                        if (UserPassword.Length < 6)
                        {
                            Console.WriteLine("\nUser password must be 6 and more symbols");
                        }
                        else
                        {





                            Console.Write("\nName: ");
                            UserName = Console.ReadLine();
                            if (UserName.Length < 3)
                            {
                                Console.WriteLine("\nUser Name must be 3 and more symbols");
                            }
                            else
                            {
                                checker = true;
                            }
                        }

                    }
                }
                


                Console.Write("Press any Key> ");
                Console.ReadKey(true);
            }

               

            if(check == true)
            {
                users.Add(new User { Login = UserLogin, Name = UserName, Password = UserPassword });
                using (FileStream writer = new FileStream(UserFileName, FileMode.Create))
                {
                    formatt.Serialize(writer, users);
                }
            }
               


                Console.ReadKey(true);
            }









        
    }
    [Serializable]
    public class User
    {
        public String Login { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
    }
}
