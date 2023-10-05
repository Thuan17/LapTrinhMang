using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            string input, stringData;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5000);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            string chao = "chao server";
            data=Encoding.ASCII.GetBytes(chao);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)sender;
            data = new byte[1024];
            int recv = server.ReceiveFrom(data, ref Remote);
            Console.WriteLine("Thong Diep {0}",Remote.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));
            Remote.ToString();
            Console.WriteLine(Encoding.ASCII.GetString(data,0,recv));
            server.SendTo(Encoding.ASCII.GetBytes("Thuan 1"), Remote);

            server.SendTo(Encoding.ASCII.GetBytes("Thuan 2"), Remote);
            server.SendTo(Encoding.ASCII.GetBytes("Thuan 3"), Remote);
            server.SendTo(Encoding.ASCII.GetBytes("Thuan 4"), Remote);
            server.SendTo(Encoding.ASCII.GetBytes("Thuan 5"), Remote);




            while (true)
            {

                input = Console.ReadLine();
                if (input == "thoat") 
                    break;
                server.SendTo(Encoding.ASCII.GetBytes(input), Remote);
                data = new byte[1024];
                recv = server.ReceiveFrom(data, ref Remote);
                stringData=Encoding.ASCII.GetString(data,0, recv);
                Console.WriteLine(stringData);
            }
            Console.WriteLine("Dang dong ");
            server.Close(); 
        }
    }
}
