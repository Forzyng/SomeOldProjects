using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CSLan4TestUdpClient
{
    class Program
    {
        static int localPort;
        static int remotePort;
        static string remoteIp;
        static string userName;
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите порт для подключения: ");
            localPort = int.Parse(Console.ReadLine());
            remotePort = localPort;
            Console.Write("Введите IP адрес для группы (от 224.0.0.0 до 239.255.255.255): ");
            remoteIp = Console.ReadLine();

            Task.Run(ReceiveMessage);

            SendMessage();
        }
        static void SendMessage()
        {
            UdpClient client = new UdpClient();
            string message;
            byte[] buf;
            IPEndPoint remotePoint = new IPEndPoint(IPAddress.Parse(remoteIp), remotePort);

            Console.WriteLine("Введите сообщение для отправки и нажмите ENTER, /exit - для выхода");
            while (true)
            {
                Console.Write("\n>>");
                message = Console.ReadLine();
                if (message.ToLower() == "/exit")
                    return;
                buf = Encoding.UTF8.GetBytes(userName + ": " + message);
                client.Send(buf, buf.Length, remotePoint);
            }
        }
        static void ReceiveMessage()
        {
            string localIp = GetLocalIp();
            UdpClient receiver = new UdpClient(localPort);
            receiver.JoinMulticastGroup(IPAddress.Parse(remoteIp), 10);
            try
            {
                byte[] buf;
                IPEndPoint remotePoint = null;
                StringBuilder sb = new StringBuilder();
                Console.WriteLine("Сервер запущен...");
                while (true)
                {
                    sb.Clear();
                    do
                    {
                        buf = receiver.Receive(ref remotePoint);
                        sb.Append(Encoding.UTF8.GetString(buf));
                    } while (receiver.Available > 0);

                    if (!remotePoint.Address.ToString().Equals(localIp))
                        Console.WriteLine($"\nСообщение от {remotePoint.Address} >> {sb}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\nОшибка: {ex.Message}");
            }
            finally
            {
                receiver.DropMulticastGroup(IPAddress.Parse(remoteIp));
                receiver.Close();
                Console.WriteLine("\nСервер остановлен!");
            }
        }
        static string GetLocalIp()
        {
            IPHostEntry h = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress i in h.AddressList)
            {
                if (i.AddressFamily == AddressFamily.InterNetwork)
                    return i.ToString();
            }
            return "127.0.0.1";
        }
    }
}
