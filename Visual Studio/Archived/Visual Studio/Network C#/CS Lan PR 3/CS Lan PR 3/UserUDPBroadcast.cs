using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_PR_3
{
    class UserUDPBroadcast
    {
        public Message subscribe;
        public string User_Name;
        int localport;
        public int Local_Port => localport;
        public int Remote_Port => localport;
        public string Remote_IP;
        

        public UserUDPBroadcast(string name, int local, string ip, bool d, bool n, bool e)
        {
            User_Name = name;
            localport = local;
            Remote_IP = ip;

            subscribe = new Message(d,n,e);
        }

        public void ReceiveMessage()
        {
            string localIp = GetLocalIp();
            UdpClient receiver = new UdpClient(Local_Port);
            receiver.JoinMulticastGroup(IPAddress.Parse(Remote_IP), 10);
            try
            {
                byte[] buf;
                IPEndPoint remotePoint = null;
                StringBuilder sb = new StringBuilder();

                Console.WriteLine("\n\nВы подключились! Ждите сообщений (EXIT что бы выйти)");
                while (true)
                {
                    sb.Clear();
                    buf = null;

                    
                        buf = receiver.Receive(ref remotePoint);
                        sb.Append(Encoding.UTF8.GetString(buf));
                 
                   

                    if (sb.ToString() == "Discounts" && subscribe.Discounts == true)
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

                    if (sb.ToString() == "News" && subscribe.News == true)
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

                    if (sb.ToString() == "Events" && subscribe.Events == true)
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

                    if (sb.ToString() == "Emergency")
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\nОшибка: {ex.Message}");
            }
            finally
            {
                receiver.DropMulticastGroup(IPAddress.Parse(Remote_IP));
                receiver.Close();
                Console.WriteLine("\nВы отключились!");
            }
        }

        private string GetLocalIp()
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
