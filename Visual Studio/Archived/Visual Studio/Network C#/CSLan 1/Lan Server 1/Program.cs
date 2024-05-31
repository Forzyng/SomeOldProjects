using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Lan_Server_1
{
    class Program
    {
        static int LocalPort = 10000;
        static void Main(string[] args)
        {
            IPEndPoint ListenPoint = new IPEndPoint(IPAddress.Any, LocalPort);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ListenPoint);
            try
            {
                server.Listen(10);
                Console.WriteLine("Server start!!!");
                while(true)
                {
                    Socket client = server.Accept();
                    StringBuilder builder = new StringBuilder();
                    int len = 0;
                    byte[] buf = new byte[1024];
                    do
                    {
                        len = client.Receive(buf);
                        builder.Append(Encoding.UTF8.GetString(buf, 0, len));
                    } while (client.Available > 0);

 string answer = "Message received";

                    DateTime dt = DateTime.Now;
                    if (builder.ToString() == "Date")
                    {
                        answer = dt.ToShortDateString();
                    }
                    else
                    {
                        if (builder.ToString() == "Time")
                        {
                            answer = dt.ToLongTimeString();
                        }
                       
                            Console.WriteLine($"Accepted from {client.LocalEndPoint}");
                            Console.WriteLine($"at {dt.ToShortDateString()} {dt.ToLongTimeString()} {builder}");
                        
                    }

                   
                    buf = Encoding.Unicode.GetBytes(answer);
                    client.Send(buf);

                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("\n\nError: " + ex.Message);
            }





            Console.ReadLine();
        }
    }
}
