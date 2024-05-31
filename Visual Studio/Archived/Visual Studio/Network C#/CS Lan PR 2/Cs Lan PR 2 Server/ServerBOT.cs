using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Cs_Lan_PR_2_Server
{
    public class User_connection
    {
        public event Action<string> ShowMessage;
        public event Action<string> ShowError;
        public string[] check;
     
  
        TcpClient client;
        Random random;
        public User_connection(TcpClient client)
        {
            this.client = client;
            random = new Random();
            check = new string[9];
        }
        public void Run()
        {

            int value = random.Next(0, 2);
            NetworkStream stream = client.GetStream();
            int len = 0;
            int moves = 0;
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

                    //
                   
                    check[moves] = sb.ToString();
                    moves++;

                    int pos1;
                    int pos2;
                    string res = string.Empty;
                    bool checktrue = true;
                    
                    do
                    {


                        pos1 = random.Next(1, 4);
                        pos2 = random.Next(1, 4);
                        res = $"{pos1}-{pos2}";
                        foreach (var item in check)
                        {
                            if (item != res)
                            {
                                checktrue = false;
                            }
                            else
                            {
                                if(item == res)
                                {
                                    checktrue = true;
                                    break;
                                }
                            }
                        }
                    } while (checktrue);

                    check[moves] = res;
                    moves++;

                    buf = Encoding.UTF8.GetBytes(res);
                    ShowMessage?.Invoke($"\nMove => {sb}");



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
    class ServerBOT
    {
        int Local_Port;
        public int LoacalPort => Local_Port;
        IPAddress address;
        public IPAddress Address => address;
        TcpListener server;

        public event Action<string> ShowMessage;
        public event Action<string> ShowError;

        private List<User_connection> clients;
        public ServerBOT(string ip, int port)
        {
            Local_Port = port;
            address = IPAddress.Parse(ip);
            server = null;
            clients = new List<User_connection>();
        }
        public void Start()
        {
            if (server != null)
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

                    User_connection user = new User_connection(client);
                    clients.Add(user);
                    user.ShowMessage += ShowMessage;
                    user.ShowError += ShowError;
                    user.RunAsync();
                   

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
