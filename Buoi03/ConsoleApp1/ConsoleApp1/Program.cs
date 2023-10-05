using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp1
{
    internal class Program
    {

        private static int SendData(Socket s, byte[] data)
        {
            int total = 0;
            int size = data.Length;
            int dataleft = size;
            int sent;
            while (total < size)
            {
                sent = s.Send(data, total, dataleft, SocketFlags.None);
                total += sent;
                dataleft -= sent;
            }
            return total;
        }
        private static byte[] ReceiveData(Socket s, int size)
        {
            int total = 0;
            int dataleft = size;
            byte[] data = new byte[size];
            int recv;
            while (total < size)
            {
                recv = s.Receive(data, total, dataleft, 0);
                if (recv == 0)
                {
                    data = Encoding.ASCII.GetBytes("THoat");
                    break;
                }
                total += recv;
                dataleft -= recv;
            }
            return data;
        }
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            int sent;
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            Socket server = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
            }
            catch (SocketException e)
            {
                Console.WriteLine("khong ket noi");
                Console.WriteLine(e.ToString());
                return;
            }
            int recv = server.Receive(data);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine(stringData);
            sent = SendData(server, Encoding.ASCII.GetBytes("THuan"));
            sent = SendData(server, Encoding.ASCII.GetBytes("Huynh Gia HUatn"));
            sent = SendData(server, Encoding.ASCII.GetBytes("Map"));
            server.Shutdown(SocketShutdown.Both);
            server.Close();

        }

    }
}
