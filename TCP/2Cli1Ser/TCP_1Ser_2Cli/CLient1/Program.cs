using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CLient1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 8888);

            NetworkStream stream = client.GetStream();
            Console.WriteLine("Kết nối đến server...");

            while (true)
            {
                Console.Write("Nhập tin nhắn (hoặc 'exit' để thoát): ");
                string message = Console.ReadLine();
                byte[] data = Encoding.ASCII.GetBytes(message);

                stream.Write(data, 0, data.Length);

                if (message == "exit")
                {
                    break;
                }

                byte[] responseBuffer = new byte[1024];
                int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                string responseMessage = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);
                Console.WriteLine("Server trả về: " + responseMessage);
            }

            client.Close();
        }
    }
}
