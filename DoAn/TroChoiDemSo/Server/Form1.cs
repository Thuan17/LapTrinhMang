﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void Server() 
        {
            Socket listenr = new Socket(SocketType.Stream, ProtocolType.Tcp);


        
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
