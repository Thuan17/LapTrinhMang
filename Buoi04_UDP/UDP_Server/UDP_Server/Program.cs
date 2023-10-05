using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UDP_Server
{
    internal class Program
    {


        public void UDP() 
        {
            
        }


        static void Main(string[] args)
        {


            int recv;

            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 5000);
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            Console.WriteLine("Dang cho ket noi ...");
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)(sender);
            recv = newsock.ReceiveFrom(data, ref Remote);
            Console.WriteLine("Thong diep dupc nhan tu12 {0}", Remote.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data,0,recv));

            string xinchao = "Chao";
            data=Encoding.ASCII.GetBytes(xinchao);
            newsock.SendTo(data, data.Length, SocketFlags.None, Remote);


            while (true) {
                data = new byte[1024];
              
               recv = newsock.ReceiveFrom(data,ref Remote);
                Console.WriteLine(Encoding.ASCII.GetString(data,0,recv));   
                newsock.SendTo(data,recv,SocketFlags.None, Remote); 
            }

        }
    }
}
