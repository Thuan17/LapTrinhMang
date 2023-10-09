using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Client
    {
        public Socket m_socket;
        public NetworkStream m_stream;
        public BinaryReader reader;
        public BinaryWriter m_writer;
        public bool m_run = false;
        public string name;

        public Thread m_thread;


        public Client(Socket socket)
        {

            m_socket = socket;
            m_stream = new NetworkStream(socket);
            reader = new BinaryReader(m_stream, Encoding.ASCII);
            m_writer= new BinaryWriter(m_stream, Encoding.ASCII);
        }

        public void clientCtrol()
        {
            Form1 f = new Form1();
        }


        //bat dau 
        public void Strart () 
        {
            m_run = true;
            m_thread    = new Thread()
        }

    }
}
