using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
     
        



        static void Main(string[] args)
        {



            ///dung luong noi dung
            var receiveByte = new byte[1024];
            IPAddress ipServer = IPAddress.Any ;
            EndPoint ipEndPoint = new IPEndPoint(IPAddress.Any,  1308);
            
            //ip v 4//AddressFamily.InterNetwork,

            Socket socket = new Socket(AddressFamily.InterNetwork , SocketType.Dgram, ProtocolType.Udp);

            socket.Bind(ipEndPoint);    // chiem dong cong hoi hdh la ip nay đã có người dùng chưa

            Console.WriteLine("Dang cho ket noi\t" );
            
           

            var length = socket.ReceiveFrom(receiveByte, ref ipEndPoint);




            string nhanduoc = Encoding.ASCII.GetString(receiveByte);
            Console.Write("Ip {0} da ket noi", ipEndPoint);
            Console.WriteLine("\n Nhan Duoc \t" + nhanduoc);


            socket.SendTo(Encoding.ASCII.GetBytes("Xin Chao Client"), ipEndPoint);

            socket.SendTo(Encoding.ASCII.GetBytes("Phep toan"), ipEndPoint);


            //bai toan

            while (true)
            {
          
                


            }

        }





    }

}
