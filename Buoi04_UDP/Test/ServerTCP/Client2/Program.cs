using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kết nối đến máy chủ
            TcpClient client = new TcpClient("127.0.0.1", 8888);

            // Mở luồng gửi và nhận dữ liệu
            NetworkStream stream = client.GetStream();

            Console.WriteLine("KClient_2");

            while (true)
            {
                string message = Console.ReadLine();

                // Gửi dữ liệu đến máy chủ
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }

            // Đóng kết nối
            client.Close();
        }
    
    }
}
