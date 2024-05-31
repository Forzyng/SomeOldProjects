using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_PR_3
{
    class Program
    {
        
        static int localPort;
        static int remotePort;
        static string remoteIp;
        static string userName;

        
        
        static void Main(string[] args)
        {
            bool discount;
            bool events;
            bool news;
            Console.Write("Введите Ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите порт для подключения: ");
            localPort = int.Parse(Console.ReadLine());
            remotePort = localPort;
            Console.Write("Введите IP адрес для группы (от 224.0.0.0 до 239.255.255.255): ");
            remoteIp = Console.ReadLine();

            string  c ;

            #region discounts
            Console.Write("\n\nSubscribe to discounts?(Y/N): ");
            do
            {
                c = Console.ReadLine();
            } while (c.ToLower() != "y" && c.ToLower() != "n");

            if(c.ToLower() == "y")
            {
                discount = true;
            }
            else
            {
                discount = false;
            }
            #endregion

            #region news
            Console.Write("\n\nSubscribe to news?(Y/N): ");
            do
            {
                c = Console.ReadLine();
            } while (c.ToLower() != "y" && c.ToLower() != "n");

            if (c.ToLower() == "y")
            {
                news = true;
            }
            else
            {
                news = false;
            }

            #endregion

            #region events
            Console.Write("\n\nSubscribe to events?(Y/N): ");
            do
            {
                c = Console.ReadLine();
            } while (c.ToLower() != "y" && c.ToLower() != "n");

            if (c.ToLower() == "y")
            {
                events = true;
            }
            else
            {
                events = false;
            }
            #endregion

            UserUDPBroadcast user = new UserUDPBroadcast(userName, localPort, remoteIp, discount, news, events);


            Task.Run(user.ReceiveMessage);

           


            Console.ReadLine();
        }
      
    }
}
