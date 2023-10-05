using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    public class Program
    {
        static void ShowIp()
        {
            IPAddress[] add = Dns.GetHostAddresses("LAPTOP-ALA9RHJO");
            foreach (IPAddress ip in add)
            {
                Console.WriteLine("lAy ip cach 1 :" + ip.ToString());
            }
        }
        static void ShowIp2()
        {
            IPAddress[] add = Dns.GetHostAddresses("LAPTOP-ALA9RHJO");
            for (int i = 0; i < add.Length; i++)
            {
                Console.WriteLine("Lay Ip cach 2" + add[i].ToString());
            }
        }
        static void CreateIPHostEntry()
        {
            IPHostEntry iphe, ip1, ip2;
            IPAddress ipadd = IPAddress.Parse("127.0.0.1"); ;
            iphe = Dns.GetHostEntry("LAPTOP-ALA9RHJO");
            ip1 = Dns.GetHostEntry("127.0.0.1");
            ip2 = Dns.GetHostEntry(ipadd);
            Console.WriteLine(iphe.HostName);
            Console.WriteLine(ip1.HostName);
            Console.WriteLine(ip2.HostName);

        }
        static void neww ()
        {
            IPAddress[] add = Dns.GetHostAddresses("LAPTOP-ALA9RHJO");
            foreach (IPAddress ip in add)
            {
                Console.WriteLine("ip" + ip.ToString());
            }
            IPAddress ipp = IPAddress.Parse("127.0.0.1");   
            IPEndPoint iped = new IPEndPoint(ipp, 1000);

        }

        static void GetIPAddress()
        {
            string IPAddress = string.Empty;
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            Console.WriteLine(IPAddress) ;
        }

        static void test()
        {
            IPAddress[] add = Dns.GetHostAddresses("LAPTOP-ALA9RHJO");
            foreach (IPAddress ip in add)
            {
               
                IPEndPoint iped = new IPEndPoint(ip, 10000);
                Console.WriteLine("Ip:\t"+ ip.ToString());
                Console.WriteLine("Port:\t"+ iped.ToString());
                Console.WriteLine(iped.ToString());

            }
        }
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            //ShowIp2();
            //ShowIp();
            //CreateIPHostEntry();
            //neww();
            //GetIPAddress();

            
            test();
            //string port = class1.PortID();
            //Console.WriteLine(port.ToString());


            Console.WriteLine("Hello Mono World");
            Console.ReadLine();
        }
       
    }
}
