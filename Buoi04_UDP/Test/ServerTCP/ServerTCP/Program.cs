using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ServerTCP
{
    internal class Program
    {
        static TcpListener server;
        static TcpClient client1;
        static TcpClient client2;
        static NetworkStream client1Stream;
        static NetworkStream client2Stream;
 
        static void Main(string[] args)
        {

            // Tạo địa chỉ IP và cổng dựng server
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 8888;

            // Tạo đối tượng TcpListener để lắng nghe kết nối từ các client
            server = new TcpListener(ipAddress, port);
            server.Start();

            Console.WriteLine("Máy chủ đang lắng nghe tại {0}:{1}", ipAddress, port);

            // Chấp nhận kết nối từ client 1
            client1 = server.AcceptTcpClient();
            Console.WriteLine("Client 1 đã kết nối!");
            client1Stream = client1.GetStream();

            // Chấp nhận kết nối từ client 2
            client2 = server.AcceptTcpClient();
            Console.WriteLine("Client 2 đã kết nối!");
            client2Stream = client2.GetStream();

            // Tạo luồng riêng cho việc lắng nghe tin nhắn từ client 1 và gửi cho client 2
            Thread client1Thread = new Thread(new ThreadStart(ListenAndForwardMessagesFromClient1));
            client1Thread.Start();

            // Tạo luồng riêng cho việc lắng nghe tin nhắn từ client 2 và gửi cho client 1
            Thread client2Thread = new Thread(new ThreadStart(ListenAndForwardMessagesFromClient2));
            client2Thread.Start();

        }
        static void ListenAndForwardMessagesFromClient1()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                bytesRead = client1Stream.Read(buffer, 0, buffer.Length);
                string messageReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Client 1 gửi: " + messageReceived);

                // Gửi tin nhắn từ client 1 cho client 2
                byte[] messageBytes = Encoding.ASCII.GetBytes(messageReceived);
                client2Stream.Write(messageBytes, 0, messageBytes.Length);
            }
        }

        static void ListenAndForwardMessagesFromClient2()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                bytesRead = client2Stream.Read(buffer, 0, buffer.Length);
                string messageReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Client 2 gửi: " + messageReceived);

                // Gửi tin nhắn từ client 2 cho client 1
                byte[] messageBytes = Encoding.ASCII.GetBytes(messageReceived);
                client1Stream.Write(messageBytes, 0, messageBytes.Length);
            }
        }




    }



}
