using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Ne_Podozritelniy_Proverschik_Slov
{
    class Tcp_Connect
    {
        IPAddress IP_Address;
        int Remote_Port;
        TcpClient client;
        public Tcp_Connect(string ip, int port)
        {
            IP_Address = IPAddress.Parse(ip);
            Remote_Port = port;
            client = null;
        }
        public bool Connect()
        {
            if (client != null)
            {
                return true;
            }

            try
            {
                IPEndPoint endPoint = new IPEndPoint(IP_Address, Remote_Port);
                client = new TcpClient();
                client.Connect(endPoint);

                return true;
            }
            catch (Exception ex)
            {
                client = null;
                return false;
            }
        }

       

        public void Disconnect()
        {
            if (client == null)
            {
                return;
            }
            try
            {
                //Send("Exit");
                System.Threading.Thread.Sleep(100);
                client.Close();
            }
            finally
            {
                client = null;
            }
        }

        private byte[] ToByteArray(string s) => Encoding.UTF8.GetBytes(s);
        private string to_string(byte[] b) => Encoding.UTF8.GetString(b, 0, b.Length);

        public void Send(string message)
        {
            try
            {

                if (client == null)
                {
                    return;
                }
                byte[] buf = ToByteArray(message);
                client.GetStream().Write(buf, 0, buf.Length);

            }
            catch (Exception)
            {

            }

        }

        public void SendFile(string direct)
        {
            try
            {
                if (client == null)
                {
                    return;
                }
                byte[] buf = File.ReadAllBytes(direct);
                client.GetStream().Write(buf, 0, buf.Length);
            }
            catch (Exception)
            {

            }


        }

        public string Read()
        {
            if (client == null)
            {
                return string.Empty;
            }
            try
            {


                int len = 0;
                byte[] buf = new byte[1024];
                NetworkStream stream = client.GetStream();
                StringBuilder sb = new StringBuilder();
                do
                {
                    len = stream.Read(buf, 0, buf.Length);
                    sb.Append(to_string(buf));
                } while (stream.DataAvailable);

                return sb.ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
