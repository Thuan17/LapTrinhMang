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

            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 12345;
            IPEndPoint endPoint = new IPEndPoint(ipAddress, port);

            // Tạo UDP socket
            UdpClient serverSocket = new UdpClient(endPoint);

            Console.WriteLine("Server đang lắng nghe...");

            while (true)
            {
                byte[] data = serverSocket.Receive(ref endPoint); // Nhận dữ liệu từ client

                string message = Encoding.ASCII.GetString(data);
                Console.WriteLine($"Nhận từ {endPoint}: {message}");

                // Phản hồi lại client
                string response = "Dữ liệu đã được nhận!";
                byte[] responseData = Encoding.ASCII.GetBytes(response);
                serverSocket.Send(responseData, responseData.Length, endPoint);
            }
        }
    }
}
