using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace client
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 12345;
            IPEndPoint endPoint = new IPEndPoint(ipAddress, port);

            // Tạo UDP socket
            UdpClient clientSocket = new UdpClient();

            while (true)
            {
                Console.Write("Nhập tin nhắn: ");
                string message = Console.ReadLine();

                // Gửi dữ liệu đến server
                byte[] data = Encoding.ASCII.GetBytes(message);
                clientSocket.Send(data, data.Length, endPoint);

                // Nhận phản hồi từ server
                byte[] responseData = clientSocket.Receive(ref endPoint);
                string response = Encoding.ASCII.GetString(responseData);
                Console.WriteLine($"Phản hồi từ server: {response}");
            }

        }
    }
}
