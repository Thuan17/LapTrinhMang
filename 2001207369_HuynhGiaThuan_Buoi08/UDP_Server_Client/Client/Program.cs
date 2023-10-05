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

            byte[] data = new byte[1024];
            string  stringData;


            //Console.Write("nhap ip cua ban :");
            //var ip = Console.ReadLine();
            ////var ip = "127.0.0.1";
            //Console.Write("Nhap Port Server :");
            //var portString = Console.ReadLine();


            UdpClient server = new UdpClient("127.0.0.1", 1308);
            //IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);




            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
           

            string chao = "Chao server";
            data=Encoding.ASCII.GetBytes(chao);
            server.Send(data, data.Length);

            //data = server.Receive(ref ipEndPoint);

            //Console.WriteLine("Nhan tu server ",sender.ToString());

            byte[] receivedData = server.Receive(ref clientEndPoint);
            string request = Encoding.UTF8.GetString(receivedData);

            stringData =Encoding.ASCII.GetString(data ,0,data.Length);
            Console.WriteLine(stringData);
            while (true) 
            {
                Console.Write("nhap noi dung:");
                var input = Console.ReadLine();

                if (input == "ex")
                {
                    break;
                }
                server.Send(Encoding.ASCII.GetBytes(input), input.Length);
                //data=server.Receive(ref sender);
                stringData = Encoding.ASCII.GetString(data, 0, data.Length);
                Console.WriteLine(stringData);      
            }   
            //Console.WriteLine("dong client");
            //server.Close();

        }
    }
}
