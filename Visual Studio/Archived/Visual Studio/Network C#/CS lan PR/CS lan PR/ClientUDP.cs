using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_lan_PR
{
    class ClientUDP
    {
        int local;
        int remote;
        string remoteip;
        public int Local_Port =>  local;
        public int Remote_Port => remote;
        public string Remote_IP =>remoteip;
        public ClientUDP(int loc, int rem, string remip)
        {
            local = loc;
            remote = rem;
            remoteip = remip;
        }
        public void Send_Message()
        {
            UdpClient client = new UdpClient();
            string message;
            byte[] buf;
            IPEndPoint Remote_Point = new IPEndPoint(IPAddress.Parse(Remote_IP), Remote_Port);
            client.Connect(Remote_Point);

            Console.WriteLine("Enter message: ");
            while (true)
            {
                Console.Write("\n>> ");
                message = Console.ReadLine();
                if (message.ToLower() == "exit")
                {
                    break;
                }
                buf = Encoding.UTF8.GetBytes(message);
                client.Send(buf, buf.Length);

                StringBuilder sb = new StringBuilder();
                IPEndPoint endPoint = null;
                do
                {
                    buf = client.Receive(ref endPoint);
                    sb.Append(Encoding.UTF8.GetString(buf));
                }while(client.Available > 0);
                Console.WriteLine($"Message from server: {sb}");

            }
        }

       


    }
}
