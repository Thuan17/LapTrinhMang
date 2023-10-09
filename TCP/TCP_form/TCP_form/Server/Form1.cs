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

namespace Server
{
    public partial class Send : Form
    {



        private TcpClient client;
        public NetworkStream stream;
        public BinaryReader STR;
        public BinaryWriter STW;
        public string rec;
        public string TextSend;

        public Thread m_thread;
        public Send()
        {
            InitializeComponent();
        }
        //CLient Control

        //public void upDateList(string Text) {

        //    this.list_Client.Items.Add(Text);
        //}

        public void upChat(string Text)
        {
            this.list_Client.Items.Add(Text);
        }


        public  void serverCtrol(Client fClient)
        {
            string text;
            upChat("abc");
            try {
                
                while ((text = fClient.reader.ReadString()) !=string.Empty) 
                {
                    text = fClient.name + "" + text;
                    upChat(text);

                }
             
            } catch(Exception ex) { }   
            
        }



        private void Send_Load(object sender, EventArgs e)
        {

        }

        private void btnCONNECT_Click(object sender, EventArgs e)
        {

        }
    }
}
