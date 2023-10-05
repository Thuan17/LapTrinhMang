using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client02
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Nhap ID");
            var ip = Console.ReadLine();

            Console.Write("Nhap port");
            string portString = Console.ReadLine();

            int port = int.Parse(portString);

            // var ip = "127.0.0.1";
            var ipAdd = IPAddress.Parse(ip);

            var ipEndPoint = new IPEndPoint(ipAdd, port);

            while (true)
            {
                Console.WriteLine("Client 02");
                Console.WriteLine("Nhap yeu cau");
                string request = Console.ReadLine();

                var socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipEndPoint);

                NetworkStream stream = new NetworkStream(socket);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream);


                writer.WriteLine(request);
                ///da ydu lieu di
                writer.Flush();




                //gui
                string reponse = reader.ReadLine();
                Console.WriteLine("Yue Cau" + reponse);
                socket.Close();

            }

        }
    }
}
