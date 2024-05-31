using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ProgramServer
{
    class Program
    {
        static int localPort;
        static string remoteIp;
        static string userName;
        static void Main(string[] args)
        {
            Console.Write("Введите имя сервера: ");
            userName = Console.ReadLine();
            Console.Write("Введите порт для подключения: ");
            localPort = int.Parse(Console.ReadLine());

            Console.Write("Введите IP адрес для группы (от 224.0.0.0 до 239.255.255.255): ");
            remoteIp = Console.ReadLine();

            ServerUdpBroadcast server = new ServerUdpBroadcast(userName, localPort, remoteIp);
            string message = string.Empty;
            string c;
            string type = string.Empty;
            do
            {
                Console.Write("Choose type: \n 1 - Discount \n 2 - News \n 3 - Events \n 4 - Emergency \n\nChoose: ");
                do
                {
                    c = Console.ReadLine();
                } while (c != "1" && c != "2" && c != "3" && c != "4");

                switch(c)
                {
                    case "1":
                        type = "Discounts";
                        break;
                    case "2":
                        type = "News";
                        break;
                    case "3":
                        type = "Events";
                        break;
                    case "4":
                        type = "Emergency";
                        break;
                }

                Console.WriteLine("\n\nEnter message: ");
                Console.Write("\n>> ");
                message = Console.ReadLine();
                server.SendType(type);
                server.SendMessage(message);
            } while (message.ToLower() != "exit");


        }
    }
}
