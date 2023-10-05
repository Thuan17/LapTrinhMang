using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace TCP_Server_Client
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
                dataleft -= size;
            }
            return total;
        }


        private static byte[] ReceiveData(Socket s, int size)
        {
            int total = 0;
            int dataleft = size;
            byte[] data = new byte[size];
            int revc;
            while (total < size)
            {
                revc = s.Receive(data, total, dataleft, 0);
                if (revc == 0)
                {
                    data = Encoding.ASCII.GetBytes("thoat");
                    break;
                }
                total += revc;
                dataleft -= revc;
            }
            return data;
        }
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            Socket newsock = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
            newsock.Bind(ipep);
            newsock.Listen(10);
            Console.WriteLine("Waiting for a client...") ;
            Socket client = newsock.Accept();
            IPEndPoint newclient = (IPEndPoint)client.RemoteEndPoint;
            //Console.WriteLine("Connected with { 0 } at port { 1}",newclient.Address,newclient.Port);
            string welcome = "Welcome to my test server";
            data = Encoding.ASCII.GetBytes(welcome);
            int sent = SendData(client, data);
            for (int i = 0; i < 5; i++)
            {
                data = ReceiveData(client, 9);
                Console.WriteLine(Encoding.ASCII.GetString(data));
            }
            //Console.WriteLine("Disconnected from { 0}", newclient.Address);
            client.Close();
            newsock.Close();

        }
    }
}
