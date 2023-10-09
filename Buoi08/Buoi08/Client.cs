using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            string input, stringData;
            UdpClient server = new UdpClient("192.168.20.1", 5000);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

            string welcome = "Xac nhan phan hoi tu phia Server.";
            data = Encoding.ASCII.GetBytes(welcome);
            server.Send(data, data.Length);
            data = new byte[1024];
            try
            {
                data = server.Receive(ref sender);
                Console.WriteLine("Xac nhan thanh cong, tu {0}:", sender.ToString());
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
            }
            catch (SocketException)
            {
                Console.WriteLine("Gap van de ket noi den Server, ngat ket noi...");
                return;
            }

            int i = 30;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "exit")
                    break;
                server.Send(Encoding.ASCII.GetBytes(input), input.Length);
                data = new byte[1024];
                try
                {
                    data = server.Receive(ref sender);
                    stringData = Encoding.ASCII.GetString(data, 0, data.Length);
                    Console.WriteLine(stringData);
                }
                catch (SocketException)
                {
                    Console.WriteLine("Mat du lieu! vui long nhap lai.");
                    i += 10;
                }
            }
            Console.WriteLine("Ngat ket noi...");
            server.Close();
        }
    }
}
