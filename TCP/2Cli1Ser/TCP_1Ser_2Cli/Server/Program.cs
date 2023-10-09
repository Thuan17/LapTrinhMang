using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {


            TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8888);
            server.Start();
            Console.WriteLine("Server đã khởi động và đang chờ kết nối...");

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Một client đã kết nối!");

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
        }
        static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                {
                    break;
                }

                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Client gửi: " + message);

                // Kiểm tra điều kiện ra vào ở đây
                if (message == "exit")
                {
                    break;
                }

                // Phản hồi cho client
                byte[] reply = Encoding.ASCII.GetBytes("Nhận được: " + message);
                stream.Write(reply, 0, reply.Length);
            }

            client.Close();
        }
    }
}
