using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_Async_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string Local_IP;
            int Local_Port;
            Console.Write("Enter Ip: ");
            Local_IP = Console.ReadLine();
            Console.Write("\nEnter port: ");
            Local_Port = int.Parse(Console.ReadLine());

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(Local_IP), Local_Port);
            AssyncServer server = new AssyncServer(endpoint);
            server.ShowMessage += Server_ShowMessage;
            server.Start();
            Console.WriteLine("Press ENTER for stop...");
            Console.ReadLine();
            server.Stop();
        }

        private static void Server_ShowMessage(string obj)
        {
            Console.WriteLine(obj);
        }
    }
}
