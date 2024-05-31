using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CS_Lan_PR_Server
{
    public class Components
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Components(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }


    public class User_connection
    {
        public List<Components> components;
        int local;
        public int Connects;
        DateTime date;
        public int Local_Port => local;

     
        public User_connection(int loc)
        {
            local = loc;

            components = new List<Components>();
            components.Add(new Components(1, "Processor 1", 1000));
            components.Add(new Components(2, "Processor 2", 2000));
            components.Add(new Components(3, "Processor 3", 3000));
            components.Add(new Components(4, "Processor 4", 4000));
            components.Add(new Components(5, "Processor 5", 5000));
            components.Add(new Components(6, "Processor 6", 6000));
            Connects = 0;
            date = DateTime.Now;

        }
        public void Run()
        {


            UdpClient receiver = new UdpClient(Local_Port);
            try
            {
                byte[] buf;
                IPEndPoint RemotePoint = null;
                StringBuilder sb = new StringBuilder();
                do
                {


                    if (DateTime.Now > date.AddHours(1))
                    {
                        Connects = 0;
                    }
                    else
                    {
                        while (true)
                        {

                            if (Connects >= 2)
                            {
                                buf = Encoding.UTF8.GetBytes("\n\nU limited ur connections, wait 1 hour");
                                int sent1 = receiver.Send(buf, buf.Length, RemotePoint);
                                break;
                            }

                            sb.Clear();
                            do
                            {

                                buf = receiver.Receive(ref RemotePoint);
                                sb.Append(Encoding.UTF8.GetString(buf));
                            } while (receiver.Available > 0);

                            Connects++;

                            foreach (var item in components)
                            {
                                if (sb.ToString().Equals(item.Name))
                                {
                                    buf = Encoding.UTF8.GetBytes($"{item.Name} => {item.Price}");
                                    break;
                                }
                                else
                                {
                                    buf = Encoding.UTF8.GetBytes("Message received");
                                }
                            }
                            Console.WriteLine($"\n\nMessage from {RemotePoint.Address} >> {sb}");


                            int sent = receiver.Send(buf, buf.Length, RemotePoint);


                        }
                    }
                } while (sb.ToString().ToLower() != "exit");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\nError: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\n\nServer died");
                receiver.Close();
            }


        }
      
    }


    public class ServerUDP
    {
        int local;
        private List<User_connection> clients;
        public int Local_Port => local;

        public ServerUDP(int loc)
        {
            local = loc;
            clients = new List<User_connection>();
        }

        public void Receive_Message()
        {
          

            try
            {
                Console.WriteLine("Server working\n\n");
                while (true)
                {
                    User_connection user = new User_connection(Local_Port);
                    clients.Add(user);
                    user.Run();



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nError: " + ex.Message);
               
            }

        }
    }
}
