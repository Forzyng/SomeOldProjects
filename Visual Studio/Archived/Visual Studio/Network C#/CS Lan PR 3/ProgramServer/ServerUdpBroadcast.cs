using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ProgramServer
{
    class ServerUdpBroadcast
    {
        
        public string User_Name;
        int localport;
        public int Local_Port => localport;
        public int Remote_Port => localport;
        public string Remote_IP;

        public ServerUdpBroadcast(string name, int local, string ip)
        {
            User_Name = name;
            localport = local;
            Remote_IP = ip;
        }

        public void SendType(string type)
        {
            UdpClient client = new UdpClient();
            byte[] buf;
            IPEndPoint remotePoint = new IPEndPoint(IPAddress.Parse(Remote_IP), Remote_Port);
            ///
            buf = Encoding.UTF8.GetBytes(type);
            client.Send(buf, buf.Length, remotePoint);
            ///
           
            
        }
        public void SendMessage(string message)
        {
            UdpClient client = new UdpClient();
            byte[] buf;
            IPEndPoint remotePoint = new IPEndPoint(IPAddress.Parse(Remote_IP), Remote_Port);
            ///

            buf = Encoding.UTF8.GetBytes(User_Name + " => " + message);
            client.Send(buf, buf.Length, remotePoint);

        }
    }
}
