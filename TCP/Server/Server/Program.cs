using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 5000);
            UdpClient newsock = new UdpClient(ipep);
            Console.WriteLine("Dang doi Client...");
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            data = newsock.Receive(ref sender);
            Console.WriteLine("Thong diep dc nha tu..(0):", sender.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
            string menu = "Nhap tu tieng anh ( Computer , RAM , HDD ): ";
            data = Encoding.ASCII.GetBytes(menu);
            newsock.Send(data, data.Length, sender);
            while (true)
            {

                /*data = newsock.Receive(ref sender);
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
                newsock.Send(data, data.Length, sender);*/
                data = newsock.Receive(ref sender);
                string message = Encoding.ASCII.GetString(data);
                string ketqua = TranslateToVietnamese(message);
                data = Encoding.ASCII.GetBytes(ketqua);
                newsock.Send(data, data.Length, sender);
                Console.WriteLine("Da gui:  {0}", ketqua);
            }

        }


        static string TranslateToVietnamese(string englishWord)
        {
            switch (englishWord)
            {
                case "Computer":
                    return "May Tinh";
                case "RAM":
                    return "Bo Nho RAM";
                case "HDD":
                    return "O Cung Di Dong";
                default:
                    return "Not Found";
            }
        }
    }
}
