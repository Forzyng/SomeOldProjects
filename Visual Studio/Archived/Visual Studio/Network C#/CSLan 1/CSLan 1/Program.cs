using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CSLan_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPAddress address = IPAddress.Parse("127.0.0.1");
            //IPAddress address = IPAddress.Loopback;

            //IPHostEntry entry = Dns.GetHostEntry("www.google.com");
            //Console.WriteLine("Google IP: \n");
            //foreach(var ip in entry.AddressList)
            //{
            //    Console.WriteLine(ip.ToString());
            //}
            //Console.WriteLine();
            //entry = Dns.GetHostEntry("www.microsoft.com");
            //Console.WriteLine("Microsoft IP: \n");
            //foreach (var ip in entry.AddressList)
            //{
            //    Console.WriteLine(ip.ToString());
            //}
            while (true)
            {


                Console.WriteLine();
                Console.WriteLine("Enter address: ");
                string address = Console.ReadLine();
                if(address == "0")
                {
                    break;
                    //return;
                }
                try
                {

                    Console.WriteLine();
                    IPHostEntry entry = Dns.GetHostEntry(address);
                    Console.WriteLine("IP list: \n");
                    foreach (var ip in entry.AddressList)
                    {
                        Console.WriteLine(ip.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //Console.WriteLine();
            //Console.ReadLine();


            



        }
    }
}
