using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace MSC_control
{
    public partial class Form1 : Form
    {
        Socket client;//socket
        byte[] bufbar = new byte[10240];

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string ip = Properties.Settings.Default.ip_set;
            this.textBox1.Text = ip;

   
            int port = Convert.ToInt16(Properties.Settings.Default.port_set);
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(ip), port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(endpoint);//connect to server
                client.BeginReceive(bufbar, 0, bufbar.Length, SocketFlags.None, new AsyncCallback(dataReceive), client);

            }
            catch (Exception)
            {
                
               // throw;
            }


              

        }

        void dataReceive(IAsyncResult ia)
        {
            client = ia.AsyncState as Socket;
            int count = client.EndReceive(ia);

            client.BeginReceive(bufbar, 0, bufbar.Length, SocketFlags.None, new AsyncCallback(dataReceive), client);


            string _context = "";
            _context = Encoding.GetEncoding("gb2312").GetString(bufbar, 1, count - 2);
            parsedata(_context);

        }

        void parsedata(String data) 
        {

            String[] _commandArry = data.Split(new char[2] { '_', ';' });
            if (_commandArry[0] != "0")
            {
                textBox_Barcode.Text = _commandArry[1]; //barcode
                textBox_Length.Text = _commandArry[2];  //length
                textBox_Width.Text = _commandArry[3];   //width
                textBox_Height.Text = _commandArry[4];  //height
                textBox_Volume.Text = _commandArry[5];  //volume
                textBox_Weight.Text = _commandArry[6];  //weight
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                Properties.Settings.Default.ip_set = textBox1.Text;
                Properties.Settings.Default.Save();

            }
        }

    }
}
