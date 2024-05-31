using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace SeverMessenger
{
    public class User_connection
    {
        MessageDBEntities messageDB;
        public event Action<string> ShowMessage;
        public event Action<string> ShowError;
        public bool connected;
        TcpClient client;

        public User_connection(TcpClient client)
        {
            this.client = client;
            
            messageDB = new MessageDBEntities();
            connected = true;

        }
        public void Run()
        {

            string TLogin = string.Empty;
            string TPassword = string.Empty;
            string message = string.Empty;
            string ULogin = string.Empty;

            NetworkStream stream = client.GetStream();
            int len = 0;
            byte[] buf = new byte[1024];
            StringBuilder sb = new StringBuilder();
            List<Message> listMes = new List<Message>();
            try
            {


                do
                {
                    sb.Clear();
                    buf = new byte[1024];



                    len = stream.Read(buf, 0, buf.Length);
                    sb.Append(Encoding.UTF8.GetString(buf, 0, len));
                    stream.Write(buf, 0, buf.Length);

                    switch (sb.ToString())
                    {
                        case "Registration":

                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));
                            stream.Write(buf, 0, buf.Length);

                            TLogin = sb.ToString();

                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));

                            TPassword = sb.ToString();

                            var user_find_reg = messageDB.Users.Where(t => t.Login.Equals(TLogin)).FirstOrDefault();
                            if (user_find_reg == null)
                            {
                                sb.Clear();
                                buf = new byte[1024];

                                buf = Encoding.UTF8.GetBytes("Success");
                                stream.Write(buf, 0, buf.Length);

                                User user = new User()
                                {
                                    Id = Guid.NewGuid(),
                                    Login = TLogin,
                                    Password = TPassword
                                };
                                messageDB.Users.Add(user);

                                messageDB.SaveChanges();

                                
                            }
                            else
                            {
                                sb.Clear();
                                buf = new byte[1024];
                                buf = Encoding.UTF8.GetBytes("Failed {Login}");
                                stream.Write(buf, 0, buf.Length);

                                sb.Append("exit");
                            }

                            break;

                        case "Logining":

                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));
                            stream.Write(buf, 0, buf.Length);

                            TLogin = sb.ToString();

                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));

                            TPassword = sb.ToString();

                            var user_find = messageDB.Users.Where(t => t.Login.Equals(TLogin) && t.Password.Equals(TPassword)).FirstOrDefault();
                            if (user_find != null)
                            {
                                sb.Clear();
                                buf = new byte[1024];

                                buf = Encoding.UTF8.GetBytes("Success");
                                stream.Write(buf, 0, buf.Length);

                            }
                            else
                            {
                                sb.Clear();
                                buf = new byte[1024];

                                buf = Encoding.UTF8.GetBytes("Failed");
                                stream.Write(buf, 0, buf.Length);

                                sb.Append("exit");
                            }

                            break;

                        case "GetContacts":

                            break;

                        case "GetChat":
                            ///
                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));
                            stream.Write(buf, 0, buf.Length);
                            ///
                            TLogin = sb.ToString();

                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));

                            ULogin = sb.ToString();

                            Guid FromG = (from t in messageDB.Users
                                         where t.Equals(TLogin)
                                         select t.Id).FirstOrDefault();

                            Guid ToG = (from t in messageDB.Users
                                       where t.Equals(ULogin)
                                       select t.Id).FirstOrDefault();

                            listMes = messageDB.Messages.Where(t => t.FromLogin.Equals(FromG) && t.ToLogin.Equals(ToG)).ToList();


                            break;

                           

                        case "SetChat":
                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));
                            stream.Write(buf, 0, buf.Length);

                            message = sb.ToString();
                            ///
                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));
                            stream.Write(buf, 0, buf.Length);
                            ///
                            TLogin = sb.ToString();

                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));

                            ULogin = sb.ToString();

                            Guid From = (from t in messageDB.Users
                                         where t.Equals(TLogin)
                                         select t.Id).FirstOrDefault();

                            Guid To = (from t in messageDB.Users
                                       where t.Equals(ULogin)
                                       select t.Id).FirstOrDefault();

                            

                            Message mes = new Message()
                            {
                                Id = Guid.NewGuid(),
                                ToLogin = To,
                                FromLogin = From,
                                MessageText = message,
                                file = null
                            };
                            //messageDB.Messages.Add()
                            break;

                        case "AddCotacts":
                            sb.Clear();
                            buf = new byte[1024];

                            len = stream.Read(buf, 0, buf.Length);
                            sb.Append(Encoding.UTF8.GetString(buf, 0, len));

                            TLogin = sb.ToString();

                            var user_find_add = messageDB.Users.Where(t => t.Login.Equals(TLogin)).FirstOrDefault();

                            if (user_find_add != null)
                            {
                                buf = Encoding.UTF8.GetBytes("Success");
                                stream.Write(buf, 0, buf.Length);



                            }
                            else
                            {
                                buf = Encoding.UTF8.GetBytes("Failed");
                                stream.Write(buf, 0, buf.Length);
                            }
                            break;
                    }


                    //buf = Encoding.UTF8.GetBytes("Exit");

                    //ShowMessage?.Invoke($"\nMessage => {sb}");





                } while (!sb.ToString().ToLower().Contains("exit"));
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
                connected = false;
                stream.Close();
                client.Close();
            }


        }
        public void RunAsync()
        {
            Task.Run(Run);
        }
    }
    class ServerConnectionTCP
    {
        int Local_Port;
        public int LoacalPort => Local_Port;
        IPAddress address;
        public IPAddress Address => address;
        TcpListener server;

        public event Action<string> ShowMessage;
        public event Action<string> ShowError;

        private List<User_connection> clients;
        public ServerConnectionTCP(string ip, int port)
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
                server = new TcpListener(address, LoacalPort);
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

                    Thread thread = new Thread(ToDel);
                    thread.Start(clients);

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

      private void ToDel(object obc)
        {
            List<User_connection> clients = obc as List<User_connection>;
            bool check = true;

            do
            {


                User_connection ToDel = null;
                foreach (var item in clients)
                {
                    if (item.connected == false)
                    {
                        ToDel = item;
                        check = true;
                        break;
                    }
                    else
                    {
                        check = false;
                    }
                }
                if (ToDel != null)
                {
                    Action a = () =>
                    {
                        clients.Remove(ToDel);
                    };

                    
                    //a.Invoke();
                    a();
                    
                }
            } while (check);
        }
    }


}
