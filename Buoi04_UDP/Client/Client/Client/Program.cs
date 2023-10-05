using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] receiByte = new byte[1024];


            ////nhap lieu
            Console.Write("nhap ip cua ban :");
             var ip= Console.ReadLine();
            //var ip = "127.0.0.1";
            Console.Write("Nhap Port Server :");
            var portString = Console.ReadLine();

            //ep kieu 
            int port = int.Parse(portString);   

            //gan chet
            //int port = 1711;
            //string ip="127.0.0.1";
            IPAddress serverIp= IPAddress.Parse(ip);

            //khai ba socket UDP
            var socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            //chuyen vao ip , port 
            var ipEndPoint = new IPEndPoint(serverIp, port);
          

            string chao = "Xin Chao Server";
          var  requestByte=Encoding.ASCII.GetBytes(chao);
            socket.SendTo(requestByte, ipEndPoint);


           




            while (true)
            {
                receiByte = new byte[1024];
                EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                int length = socket.ReceiveFrom(receiByte, ref endPoint);
           
                Console.WriteLine(Encoding.ASCII.GetString(receiByte, 0, length));
                
            }
        }
    }
}
