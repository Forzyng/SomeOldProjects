using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_Async_Server
{
    class AssyncServer
    {
        private IPEndPoint Listen_Point;
        private Socket socket = null;
        public event Action<string> ShowMessage; // = delegate {}
        string[] Citati = new string[] { "1", "2", "3", "4", "5", "6", "7" };
        Random rand;
        public AssyncServer(string ip, int port) 
        {
            Listen_Point = new IPEndPoint(IPAddress.Parse(ip), port);
        }
        public AssyncServer(IPEndPoint EndPoint)
        {
            Listen_Point = EndPoint;
            //socket = null;
        }
        public void Start()
        {
            // Start server
            if(socket!= null)
            {
                return;
            }
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(Listen_Point);
                socket.Listen(10);
                socket.BeginAccept(AcceptConnection, socket);

            }
            catch(Exception ex)
            {
                try
                {
                    socket.Close();
                }
                catch
                {

                }
                throw (ex);
            }
        }
        public void Stop()
        {
            // Stop Server
            if(socket == null)
            {
                return;
            }
            if(socket.Connected)
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            
            socket.Close();
            socket = null;
        }
        private void AcceptConnection(IAsyncResult result)
        {
            Socket srv = result.AsyncState as Socket;
            Socket client = srv.EndAccept(result);

          
            //Console.WriteLine("Accept: " + client.LocalEndPoint.ToString() + " at " + DateTime.Now);
            ShowMessage?.Invoke("Accept: " + client.LocalEndPoint.ToString() + " at " + DateTime.Now);
            #region Обработка подключения
            try
            {
                rand = new Random();
                int i = rand.Next(0, Citati.Length);


                StringBuilder builder = new StringBuilder();
                //int len = 0;
                //byte[] buf2 = new byte[1024];
               // while (client.Connected)//checks connected
               // {
                    try
                    {
                       // client.BeginReceive(buf2, 0, 200, SocketFlags.None, null, client);//says begin receive and continues to do endlessly
                      //  if (builder.ToString() == "1")
                       // {
                            DateTime time = DateTime.Now;
                            byte[] buf = Encoding.Unicode.GetBytes(time.ToString());//(Citati[i].ToString());         //
                            client.BeginSend(buf, 0, buf.Length, SocketFlags.None, SendComplete, client);

                       // }
                        //if (builder.ToString() == "2")
                        //{
                        //    Stop();
                        //}
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
              //  }



                

                
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nError: " + ex.Message);

            }
            finally
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            #endregion
            srv.BeginAccept(AcceptConnection, srv);
        }
        private void SendComplete(IAsyncResult result)
        {
            Socket client = result.AsyncState as Socket;
            //int len = client.EndSend(result);

            client.Shutdown(SocketShutdown.Both);
            client.Close();
        }
    }
}
