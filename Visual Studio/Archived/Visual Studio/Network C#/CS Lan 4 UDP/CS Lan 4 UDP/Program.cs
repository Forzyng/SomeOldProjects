using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_4_UDP
{
    class Program
    {
        
        static int Local_Port;
        static int Remote_Port;
        static string Remote_IP;
        static string LoginUser;
        static void Main(string[] args)
        {
            Console.Write("Введите Логин: ");
            LoginUser = Console.ReadLine();
            Console.Write("\nВведите порт для подключения: ");
            Local_Port = int.Parse(Console.ReadLine());
            Remote_Port = Local_Port;
            Console.Write("\nВведите IP для отправки(224.0.0.0. до 239.255.255.255): ");
            Remote_IP = Console.ReadLine();

            Task.Run(Receive_Message);
            Send_Message();

            Console.ReadLine();

        }
        static void Send_Message()
        {
            UdpClient client = new UdpClient();
            string message;
            byte[] buf;
            IPEndPoint Remote_Point = new IPEndPoint(IPAddress.Parse(Remote_IP), Remote_Port);
          

            Console.WriteLine("Enter message: ");
            while(true)
            {
                Console.Write("\n>> ");
                message = Console.ReadLine();
                if(message.ToLower() == "exit")
                {
                    break;
                }
                buf = Encoding.UTF8.GetBytes(LoginUser + " => " + message);
                client.Send(buf, buf.Length, Remote_Point);

            }
        }
        static void Receive_Message()
        {
            string localip = GetLocalIP();
            UdpClient receiver = new UdpClient(Local_Port);
            receiver.JoinMulticastGroup(IPAddress.Parse(Remote_IP), 10);
            try
            {
                byte[] buf;
                IPEndPoint RemotePoint = null;
                StringBuilder sb = new StringBuilder();
                Console.WriteLine("Server working\n\n");
                while(true)
                {
                    sb.Clear();
                    do
                    {
                        
                        buf = receiver.Receive(ref RemotePoint);
                            sb.Append(Encoding.UTF8.GetString(buf));
                    } while (receiver.Available > 0);
                    if(!RemotePoint.Address.ToString().Equals(localip))
                    {
                        Console.WriteLine($"\n\nMessage from {RemotePoint.Address} >> {sb}");
                    }
                    //else
                    //Console.WriteLine($"\n\nMessage from {RemotePoint.Address} >> {sb}");

                    //buf = Encoding.UTF8.GetBytes("Message received");
                    //int sent = receiver.Send(buf, buf.Length, RemotePoint);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\n\nError: {ex.Message}");
            }
            finally
            {
                receiver.DropMulticastGroup(IPAddress.Parse(Remote_IP));
                receiver.Close();
                Console.WriteLine("\n\nServer died");
            }
        }
        static string GetLocalIP()
        {
            IPHostEntry h = Dns.GetHostEntry(Dns.GetHostName());
            foreach(var i in h.AddressList)
            {
                if(i.AddressFamily == AddressFamily.InterNetwork)
                {
                    return i.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}
