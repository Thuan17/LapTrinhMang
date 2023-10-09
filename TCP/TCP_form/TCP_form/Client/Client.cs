using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {


        private TcpClient client;
        public NetworkStream stream;
        public BinaryReader STR;
        public BinaryWriter STW;
        public string rec;
        public string TextSend;

        public Thread m_thread;


        public Client()
        {
            InitializeComponent();
        }

        //check Server
        public void checkServer()
        {
            try
            {
                string noidung = STR.ReadString();
                while ((noidung) != string.Empty)
                {


                }
            }
            catch (Exception ex)
            {
                upChat("Mất kết nối máy chủ");

            }
        }


        //khung chat
        public void upChat(string Text)
        {
            this.list_chat.Items.Add(Text);
        }


        private void btnCONNECT_Click(object sender, EventArgs e)
        {
            string IpServer = txtIpServer.Text;
            string Port = txtPortServer.Text;

            if (IpServer == null || IpServer.Equals(""))
            {
                MessageBox.Show("Ip Không Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Port == null || Port.Equals(""))
            {
                MessageBox.Show("Port Không Để Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int port = int.Parse(Port);

            try
            {
                client = new TcpClient();
                client.Connect(IpServer, port);
                stream = client.GetStream();
                STR = new BinaryReader(stream, Encoding.ASCII);
                STW = new BinaryWriter(stream, Encoding.ASCII);


                m_thread.Start();
                upChat("Kết nối Server thành công");
            }
            catch (Exception ex)
            {
                upChat("Kết nối Server thất bại ");
                upChat(IpServer + "\t" + Port);
            }
        }
    }
}
