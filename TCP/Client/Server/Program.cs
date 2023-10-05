using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp);


            var ipEndPoint = new IPEndPoint(IPAddress.Any, 1308);

            listener.Bind(ipEndPoint);
            listener.Listen(1000);


            Console.Write("DAng Cho ket noi client");

            while (true)
            {
                //chap nhan cong khong bind()
                Socket worker = listener.Accept();

                NetworkStream stream = new NetworkStream(worker);
                var reader = new StreamReader(stream);
                var witer = new StreamWriter(stream);
                //doc 
                string request = reader.ReadLine();
                Console.WriteLine(request);
                Console.WriteLine("Client {0} da ket noi", ipEndPoint);
                //gui 
                //string reponse = "Gia THuan";


                string response = Xuly(request);

                witer.WriteLine(response);
                witer.Flush();
                worker.Close();

            }
        }
        public static String Xuly(string request)
        {


            string response = "THuan";


            int index = 0;
            for (  int i = 0; i < request.Length; i++)
            {
                if (char.IsNumber(request[i]) == false)
                {
                    index = i;
                    break;
                }
            
            }

            int  a = int.Parse(request.Substring(0,index));
            int b = int.Parse(request.Substring(index + 1));
            Console.WriteLine("A={0} va B={1}",a,b);
            char pToan = request[index];
            if (pToan == '+')
            {
                int sum = a + b;
                response = sum.ToString();
            }
            else if (pToan == '-')
            {
                int tru = a - b;
                response = tru.ToString();
            }

            else if (pToan == '*')
            {
                int nhan = a * b;
                response = nhan.ToString();
            }
            else if (pToan == '/')
            {
                int chia = a / b;
                response = chia.ToString();
            }
            else
            {
                response = "Loi phep toan";


            }



           
            return response;


        }
    }
}
