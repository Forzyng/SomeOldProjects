using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_3_Tcp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int Loacal_Port;
            Console.Write("Enter port: ");
            Loacal_Port = int.Parse(Console.ReadLine());
            MyTcpServer server = new MyTcpServer("0.0.0.0", Loacal_Port);

            server.ShowMessage += Server_ShowMessage;
            server.ShowError += Server_ShowError;
            server.Start();

        }

        private static void Server_ShowError(string obj)
        {
            Console.WriteLine($"\n\nError: {obj}");
        }

        private static void Server_ShowMessage(string obj)
        {
            Console.WriteLine(obj);
        }
    }
}
