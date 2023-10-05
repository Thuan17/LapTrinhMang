using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Threading;

namespace _2001207369_HuynhGiaThuan_Server
{
    internal class Program
    {



        static void Main(string[] args)
        {
            int port = 12345; // Port để lắng nghe kết nối
            byte[] buffer = new byte[1024];
            TcpListener listener = new TcpListener(IPAddress.Any, port);

            int bytesRead;

            listener.Start();
            Console.WriteLine("Server tren port {0}..",port);

            while (true)
            {

               
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client đã kết nối.");

                NetworkStream stream = client.GetStream();
                string menu = "Menu:\n1. Cong \n2. Tru \n3. Nhan\n4. Chia\nChon thuat toan : ";
                byte[] menuBytes = Encoding.ASCII.GetBytes(menu);

                // Gửi menu đến Client
                stream.Write(menuBytes, 0, menuBytes.Length);

              
                byte[] operationBytes = new byte[1];
                stream.Read(operationBytes, 0, operationBytes.Length);
                int operation = int.Parse(Encoding.ASCII.GetString(operationBytes));

                double result = 0;
                if (operation >= 1 && operation <= 4)
                {
                    byte[] operand1Bytes = new byte[8];
                    byte[] operand2Bytes = new byte[8];

                    // Đọc số thứ nhất
                    stream.Read(operand1Bytes, 0, operand1Bytes.Length);
                    double operand1 = BitConverter.ToDouble(operand1Bytes, 0);

                    // Đọc số thứ hai
                    stream.Read(operand2Bytes, 0, operand2Bytes.Length);
                    double operand2 = BitConverter.ToDouble(operand2Bytes, 0);

                    switch (operation)
                    {
                        case 1:
                            result = operand1 + operand2;
                            break;
                        case 2:
                            result = operand1 - operand2;
                            break;
                        case 3:
                            result = operand1 * operand2;
                            break;
                        case 4:
                            if (operand2 == 0)
                                Console.WriteLine("Loi: Chia cho 0.");
                            else
                                Console.WriteLine("Loi: Chia cho 0.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("loi.");
                }

                // Gửi kết quả về Client
                byte[] resultBytes = BitConverter.GetBytes(result);
                stream.Write(resultBytes, 0, resultBytes.Length);

                client.Close();
                Console.WriteLine("Client mat ket noi.\n");
            }
        }

    }
}