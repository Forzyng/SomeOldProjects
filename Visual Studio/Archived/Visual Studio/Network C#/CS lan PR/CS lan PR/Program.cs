using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_lan_PR
{
    class Program
    {
        static int Local_Port;
        static int Remote_Port;
        static string Remote_IP;
        static void Main(string[] args)
        {
            Console.Write("Введите порт для прослушивания: ");
            Local_Port = int.Parse(Console.ReadLine());
            Console.Write("\nВведите порт для отправки: ");
            Remote_Port = int.Parse(Console.ReadLine());
            Console.Write("\nВведите IP для отправки: ");
            Remote_IP = Console.ReadLine();
            ClientUDP client = new ClientUDP(Local_Port, Remote_Port, Remote_IP);


            client.Send_Message();

            Console.ReadLine();

        }
        
        
     
    }
}
