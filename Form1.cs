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
        String[] barcodeArry = new String[1000];
        int barIndex = 0;
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
            try //enable data feed
            {
                String command = "sEI C1 1";
                Byte[] commad_arry = Encoding.UTF8.GetBytes(command);

                Byte[] send = new Byte[command.Length + 2];
                send[0] = 0x02;
                for (int i = 0; i < command.Length; i++)
                {
                    send[i + 1] = commad_arry[i];
                }

                send[command.Length + 1] = 0x03;

                client.Send(send);
                System.Threading.Thread.Sleep(10);
            }
            catch (Exception)
            {

               // throw;
            }
            try //activate module
            {
                String command = "sMI A3"; //"sMI A4" to shut down
                Byte[] commad_arry = Encoding.UTF8.GetBytes(command);

                Byte[] send = new Byte[command.Length + 2];
                send[0] = 0x02;
                for (int i = 0; i < command.Length; i++)
                {
                    send[i + 1] = commad_arry[i];
                }

                send[command.Length + 1] = 0x03;

                client.Send(send);
                System.Threading.Thread.Sleep(10);
            }
            catch (Exception)
            {
               //throw;
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
            String[] _commandArry = data.Split(' ');
            if (_commandArry[0] == "sSI")
            {
                try
                {
                    
                    textBox_Index.Text = barIndex.ToString();
                    textBox_Barcode.Text = _commandArry[19]; //barcode
                    //textBox_Length.Text = _commandArry[2];  //length
                    //textBox_Width.Text = _commandArry[3];   //width
                    //textBox_Height.Text = _commandArry[4];  //height
                    //textBox_Volume.Text = _commandArry[5];  //volume
                    //textBox_Weight.Text = _commandArry[6];  //weight
                    listBox_Barocde.Items.Add(_commandArry[19]);
                    barcodeArry[barIndex] = _commandArry[19];
                    barIndex += 1;
                }
                catch (Exception)
                {
                    textBox_Barcode.Text = "No Read";
                    //throw;
                }
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
