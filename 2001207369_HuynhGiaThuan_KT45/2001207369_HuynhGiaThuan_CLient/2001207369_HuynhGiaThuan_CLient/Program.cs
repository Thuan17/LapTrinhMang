using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2001207369_HuynhGiaThuan_CLient
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string serverIP = "127.0.0.1"; // Địa chỉ IP của Server
            int serverPort = 12345; // Cổng kết nối đến Server

            while (true)
            {
                TcpClient client = new TcpClient(serverIP, serverPort);
                NetworkStream stream = client.GetStream();

                byte[] menuBytes = new byte[1024];
                int bytesRead = stream.Read(menuBytes, 0, menuBytes.Length);
                string menu = Encoding.ASCII.GetString(menuBytes, 0, bytesRead);
                Console.WriteLine(menu);

                Console.Write("Nhap phep toan  ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                int operation = int.Parse(input);
                byte[] operationBytes = Encoding.ASCII.GetBytes(operation.ToString());
                stream.Write(operationBytes, 0, operationBytes.Length);

                if (operation >= 1 && operation <= 4)
                {
                    Console.Write("Nhap so thu nhat: ");
                    double operand1 = double.Parse(Console.ReadLine());
                    byte[] operand1Bytes = BitConverter.GetBytes(operand1);
                    stream.Write(operand1Bytes, 0, operand1Bytes.Length);



                    

                    Console.Write("Nhap gia tri thu hai ");
                    double operand2 = double.Parse(Console.ReadLine());
                  
                       
                        byte[] operand2Bytes = BitConverter.GetBytes(operand2);
                        stream.Write(operand2Bytes, 0, operand2Bytes.Length);
                    
                   

                    byte[] resultBytes = new byte[8];
                    bytesRead = stream.Read(resultBytes, 0, resultBytes.Length);
                    double result = BitConverter.ToDouble(resultBytes, 0);
                    Console.WriteLine("Ket qua: " + result);
                }
                else
                {
                    Console.WriteLine("Loi phep toan.");
                }

                client.Close();
            }
        }
    }
}
