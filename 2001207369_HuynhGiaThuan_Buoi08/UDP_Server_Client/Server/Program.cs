using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {


            byte[] data = new byte[1024];
            IPEndPoint ipend = new IPEndPoint(IPAddress.Any, 1308);
            UdpClient socket = new UdpClient(ipend);
            Console.WriteLine("Dang Cho Ket Noi Client");
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            data = socket.Receive(ref sender);
            Console.WriteLine("Nhan Tu {0} noi dung{1}", ipend, sender.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
            string chao = "chao client";
            data = Encoding.ASCII.GetBytes(chao);
            socket.Send(data, data.Length, sender);


            while (true)
            {

                data = socket.Receive(ref sender);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
                socket.Send(data, data.Length, sender);
            }
        }

        public void XuLy(string noidung)
        {


        }
    }
}
