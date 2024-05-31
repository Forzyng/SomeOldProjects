using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_2
{
    class Program
    {
        static int Local_Port;
        static int Remote_Port;
        static Socket Lisening_Socket = null;
        
        static void Main(string[] args)
        { 
            IPEndPoint Local_Point = null;
            try
            {
                Console.Write("Enter port for receiving message: ");
                Local_Port = int.Parse(Console.ReadLine());

                Console.Write("\nEnter port for sending message: ");
                Remote_Port = int.Parse(Console.ReadLine());

                
                Local_Point = new IPEndPoint(IPAddress.Any, Local_Port);
                Lisening_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);


                
                string message;
                byte[] buf;
                Task Listen_Task = new Task(Listen);
                Listen_Task.Start();
                while(true)
                {
                    Console.Write("\n\n>>: ");
                    message = Console.ReadLine();
                    if(message.ToLower() == "exit")
                    {
                        break;
                    }
                    buf = Encoding.UTF8.GetBytes(message);
                    IPEndPoint Remote_Point = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Remote_Port);
                    Lisening_Socket.SendTo(buf, Remote_Point);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nError: " + ex.Message);
                return;
            }
            finally
            {
                if(Lisening_Socket != null)
                {
                    Lisening_Socket.Shutdown(SocketShutdown.Both);
                    Lisening_Socket.Close();
                    Lisening_Socket = null;
                }
            }
            Console.Write("\n\n\nEnter smth to end");
            Console.ReadLine();
        }
        static void Listen()
        {
            IPEndPoint Local_Point = new IPEndPoint(IPAddress.Any, Local_Port);
            try
            {
                Lisening_Socket.Bind(Local_Point);
                while(true)
                {
                    Console.Write("\n\n>>: ");
                    StringBuilder builder = new StringBuilder();
                    int len = 0;
                    byte[] buf = new byte[1024];
                    EndPoint Remote_IP = new IPEndPoint(IPAddress.Any, 0);
                    do
                    {
                        len = Lisening_Socket.ReceiveFrom(buf, ref Remote_IP);
                        builder.Append(Encoding.UTF8.GetString(buf, 0, len));
                    } while (Lisening_Socket.Available > 0);

                    IPEndPoint FullIp = Remote_IP as IPEndPoint;
                    Console.WriteLine($"From {FullIp.Address}:{FullIp.Port}");
                    Console.WriteLine($"Message at {DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}: {builder}");

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("\n\nError: " + ex.Message);
                return;
            }
            finally
            {
                Close_Socket();
            }
        }
        static void Close_Socket()
        {
            Lisening_Socket.Shutdown(SocketShutdown.Both);
            Lisening_Socket.Close();
            Lisening_Socket = null;
        }
    }
}
