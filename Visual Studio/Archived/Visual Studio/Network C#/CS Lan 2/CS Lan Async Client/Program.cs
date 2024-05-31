using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_Async_Client
{
    class Program
    {
        static int Remote_Port = 2000;
        static void Main(string[] args)
        {
            Console.ReadKey(true);
            IPEndPoint Remote_Point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Remote_Port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(Remote_Point);
                while(true)
                {

                
                Console.WriteLine("Enter option (1-Random citata 2-Disconnect): ");
                string message = Console.ReadLine();
                if(message == "2")
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                        break;
                }
                if(message == "1")
                {
                    byte[] buf = Encoding.UTF8.GetBytes(message);
                    socket.Send(buf);

                    buf = new byte[1024];
                    int len = 0;
                    StringBuilder builder = new StringBuilder();
                    do
                    {
                        len = socket.Receive(buf);
                        builder.Append(Encoding.UTF8.GetString(buf, 0, len));
                    } while (socket.Available > 0);

                    Console.WriteLine($"Answer: {builder}");
                    }
                }
               
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nError: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
