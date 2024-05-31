using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_3_Tcp
{
    public class User_connection
    {
        public event Action<string> ShowMessage;
        public event Action<string> ShowError;
        public bool won;
        public int tryes;
        public int ColvoUgadanych;
        TcpClient client;
        Random random;
        public User_connection(TcpClient client)
        {
            this.client = client;
            tryes = 3;
            ColvoUgadanych = 0;
            won = false;
            random = new Random();
        }
        public void Run()
        {
            
            int value = random.Next(0, 2);
            NetworkStream stream = client.GetStream();
            int len = 0;
            byte[] buf = new byte[1024];
            StringBuilder sb = new StringBuilder();
            try
            {


                do
                {
                    sb.Clear();

                    do
                    {
                        len = stream.Read(buf, 0, buf.Length);
                        sb.Append(Encoding.UTF8.GetString(buf, 0, len));
                    } while (stream.DataAvailable);

                    buf = Encoding.UTF8.GetBytes("Exit");
                    if (tryes == 0)
                    {
                        buf = Encoding.UTF8.GetBytes("Don`t even try more");
                    }
                    else
                    {


                        if (Convert.ToInt32(sb.ToString()) == value)
                        {
                            buf = Encoding.UTF8.GetBytes("YOU WON");
                            stream.Write(buf, 0, buf.Length);
                            tryes = 0;
                            return;
                        }
                        else
                        {
                            if (tryes - 1 > 0)
                            {
                                tryes--;
                                buf = Encoding.UTF8.GetBytes($"Tryes left: {tryes}");
                                
                            }
                            else
                            {
                                buf = Encoding.UTF8.GetBytes("YOU LOSE");
                                stream.Write(buf, 0, buf.Length);
                                return;
                            }
                        }
                    }
                    ShowMessage?.Invoke($"\nMessage => {sb}");



                    stream.Write(buf, 0, buf.Length);
                } while (sb.ToString().ToLower() != "exit");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("\n\nError: " + ex.Message);
                ShowError?.Invoke($"\n\nError: {ex.Message}");
                try
                {
                    client.Close();
                }
                catch
                {

                }
            }

            finally
            {
                
                stream.Close();
                client.Close();
            }


        }
        public void RunAsync()
        {
            Task.Run(Run);
        }
    }
    class MyTcpServer
    {
        int Local_Port;
        public int LoacalPort => Local_Port;
        IPAddress address;
        public IPAddress Address => address;
        TcpListener server;

        public event Action<string> ShowMessage;
        public event Action<string> ShowError;

        private List<User_connection> clients;
        public MyTcpServer(string ip, int port)
        {
            Local_Port = port;
            address = IPAddress.Parse(ip);
            server = null;
            clients = new List<User_connection>();
        }
        public void Start()
        {
            if(server != null)
            {
                return;
            }

            try
            {
                server = new TcpListener(IPAddress.Any, LoacalPort);
                server.Start(10);
                ShowMessage?.Invoke("!Server Started!");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    string res = $"\n\nConnection from => {client.Client.RemoteEndPoint}\nAt => {DateTime.Now}\n";
                    ShowMessage?.Invoke(res);

                   
                    bool wait = false;
                    do
                    {
                      
                        foreach (var item in clients)
                        {
                            
                            if(item.tryes == 3)
                            {
                                wait = false;
                            }
                            else
                            {
                                if (item.tryes != 0)
                                {
                                    wait = true;
                                    break;
                                }
                                else
                                {
                                    wait = false;
                                }
                            }
                            
                           
                        }
                    } while (wait);
                    User_connection user = new User_connection(client);
                    clients.Add(user);
                    user.ShowMessage += ShowMessage;
                    user.ShowError += ShowError;
                    user.RunAsync();
                    User_connection userToDel = null;
                    foreach(var item in clients)
                    {
                        if (item.tryes == 0)
                        {
                            userToDel = item;
                        }
                    }
                    if(userToDel != null)
                    {
                        clients.Remove(userToDel);
                    }    
                    
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("\n\nError: " + ex.Message);
                ShowError?.Invoke($"\n\nError: {ex.Message}");
            }
            finally
            {
               
                if (server != null)
                {
                    server.Stop();
                }
                ShowMessage?.Invoke("!Server Stopped!");
            }
        }
    }
}
