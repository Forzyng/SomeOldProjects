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
        TcpClient client;
        Random random;
        string[] QUOTES;
        public User_connection(TcpClient client)
        {
            this.client = client;
            random = new Random();
            QUOTES = new string[10];
            QUOTES[0] = "Quote 1";
            QUOTES[1] = "Quote 2";
            QUOTES[2] = "Quote 3";
            QUOTES[3] = "Quote 4";
            QUOTES[4] = "Quote 5";
            QUOTES[5] = "Quote 6";
            QUOTES[6] = "Quote 7";
            QUOTES[7] = "Quote 8";
            QUOTES[8] = "Quote 9";
            QUOTES[9] = "Quote 10";
        }
        public void Run()
        {
            
            
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

                    

                    int value = random.Next(0, QUOTES.Length);

                    buf = Encoding.UTF8.GetBytes(QUOTES[value]);

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
