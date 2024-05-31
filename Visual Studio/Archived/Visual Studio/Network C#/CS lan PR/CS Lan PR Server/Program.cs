using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_PR_Server
{
    class Program
    {
        static int Local_Port;



        static void Main(string[] args)
        {

            Console.Write("Введите порт для прослушивания: ");
            Local_Port = int.Parse(Console.ReadLine());


            ServerUDP server = new ServerUDP(Local_Port) ;
           
                Task.Run(server.Receive_Message);
            Console.ReadLine();
        }
    }
}
