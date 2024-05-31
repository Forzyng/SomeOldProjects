using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Сериализация, суть сохранение.
// Дословно - представить в последовательном виде (serial - последовательный)
// Смысл - сохранить объект в файле или в строке (отправить по сети)

namespace Serialization
{
    class Program
    {
        const String UserFileName = "users.txt";
        static void Main(string[] args)
        {
           // Reg(args);
            Auth(args);
        }
            static void Auth(string[] args)
        {

            String UserLogin, UserPassword = String.Empty;
            Console.Write("Login: ");
            UserLogin = Console.ReadLine();
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
                else
                {
                    UserPassword += key.KeyChar;
                    Console.Write("*");
                }
            }
            //UserPassword = Console.ReadLine();

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


            Console.ReadKey(true);
        }
        static void Reg(string[] args)
        {

            String UserLogin, UserPassword, UserName = String.Empty;
            Console.Write("Login: ");
            UserLogin = Console.ReadLine();
            Console.Write("Password: ");
            UserPassword = Console.ReadLine();
            Console.Write("Name: ");
            UserName = Console.ReadLine();


            List<User> users;

            BinaryFormatter formatt = new BinaryFormatter();
            using (FileStream reader = new FileStream(UserFileName, FileMode.Open))
            {
                users = (List<User>)formatt.Deserialize(reader);
            }
            Console.WriteLine(users);



            users.Add(new User { Login = UserLogin, Name = UserName, Password = UserPassword });
            using (FileStream writer = new FileStream(UserFileName, FileMode.Create))
            {
                formatt.Serialize(writer, users);
            }


            Console.ReadKey(true);
        }
        static void Main3(string[] args)
        {
            

            #region Creation
            // Первоначальное заполнение
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

            #endregion
            #region Enter
            // Авторизация

            //String UserLogin, UserPassword = String.Empty;
            //Console.Write("Login: ");
            //UserLogin = Console.ReadLine();
            //Console.Write("Password: ");

            //while(true)
            //{
            //    ConsoleKeyInfo key = Console.ReadKey(true);
            //    if(key.Key == ConsoleKey.Enter)
            //    {
            //        break;
            //    }
            //    if (key.Key == ConsoleKey.Escape)
            //    {
            //        UserPassword = String.Empty;
            //    }
            //    else
            //    {
            //        UserPassword += key.KeyChar;
            //        Console.Write("*");
            //    }
            //}
            ////UserPassword = Console.ReadLine();

            //User user;

            //BinaryFormatter deserializer = new BinaryFormatter();
            //using (FileStream reader = new FileStream(UserFileName, FileMode.Open))
            //{
            //    var query = from u in (List<User>)deserializer.Deserialize(reader)
            //                where u.Login == UserLogin && u.Password == UserPassword
            //                select u;

            //    user = query.FirstOrDefault();
            //}
            //if(user == null)
            //{
            //    Console.WriteLine("\nAcces denied");
            //}
            //else
            //{
            //    Console.WriteLine("\nHello, {0}", user.Name);
            //}
            #endregion

            String UserLogin, UserPassword, UserName = String.Empty;
            Console.Write("Login: ");
            UserLogin = Console.ReadLine();
            Console.Write("Password: ");
            UserPassword = Console.ReadLine();
            Console.Write("Name: ");
            UserName = Console.ReadLine();

            
            List<User> users;
         
            BinaryFormatter formatt = new BinaryFormatter();
            using (FileStream reader = new FileStream(UserFileName, FileMode.Open))
            {
                users = (List<User>)formatt.Deserialize(reader);
            }
            Console.WriteLine(users);



            users.Add(new User { Login = UserLogin, Name = UserName, Password = UserPassword }); 
            using (FileStream writer = new FileStream(UserFileName, FileMode.CreateNew))
            {
                formatt.Serialize(writer, users);
            }
            

            Console.ReadKey(true);
        }
            static void Main2(string[] args)
        {
            String FileName = "data.txt";
            String FileName2 = "DataList.txt";
            String FileName3 = "ArrayData.txt";
            Data data = new Data
            {
                Data1 = 10,
                Data2 = "Data2",
                Data3 = new double[] { 0.1, 0.2, 0.3 }
            };
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(data);

            // Сериализаторы - средсвта, реализующие сериализацию
            //XmlSerializer - System.Xml.Serialization
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));

            // 3. Файл
            using (StreamWriter TextWriter = new StreamWriter(FileName))
            {
                // 4. Сериализация - сохранения данных
                xmlSerializer.Serialize(TextWriter, data);
            }
            Console.WriteLine("============================");

            // Десериализация - восстановление объекта из сохраненного состояния
            Data data2;
            using(StreamReader textReader = new StreamReader(FileName))
            {
                data2 = (Data)xmlSerializer.Deserialize(textReader);
            }
            Console.WriteLine(data2);


            #region Collection
            //// Коллекции
            //List<Data> dataList = new List<Data>();
            //dataList.Add(data2);
            //data2.Data1 = 20;
            //dataList.Add(data2);
            //XmlSerializer xmlSerializer2 = new XmlSerializer(dataList.GetType());

            //using (StreamWriter TextWriter = new StreamWriter(FileName2))
            //{

            //    xmlSerializer2.Serialize(TextWriter, dataList);
            //}
            //Console.WriteLine("============================");

            //List<Data> dataList2 = new List<Data>();

            //using (StreamReader textReader = new StreamReader("DataList2.txt"))
            //{
            //    dataList2 = (List<Data>)xmlSerializer2.Deserialize(textReader);
            //}
            //Console.WriteLine(data2);

            //foreach (var s in dataList2)
            //{
            //    Console.WriteLine(s);
            //    Console.WriteLine("--------------");
            //}
            #endregion

            #region Array
            //String[] arr = new string[] { "Data1", "Data2", "Data3" };
         
            //XmlSerializer xmlSerializer3 = new XmlSerializer(arr.GetType());

            //using (StreamWriter TextWriter = new StreamWriter(FileName3))
            //{

            //    xmlSerializer3.Serialize(TextWriter, arr);
            //}
            //Console.WriteLine("============================");

            //List<Data> dataList2 = new List<Data>();

            //using (StreamReader textReader = new StreamReader(FileName3))
            //{
            //    arr = (String[])xmlSerializer3.Deserialize(textReader);
            //}

            //foreach (var s in arr)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion



            Console.ReadKey(true);
        }
    }

    // 1. Классы, объекты которых сериализуются, помечаются атрибутами
    [Serializable]
    public class Data
    {
        public int Data1 { get; set; }
        public String Data2 { get; set; }
        public double[] Data3 { get; set; }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            String str = "Data1: " + Data1 +
                "\nData2: " + Data2 + "\nData3:";
            foreach(double d in Data3)
            {
                str += " " + d;
            }
            return str;
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
