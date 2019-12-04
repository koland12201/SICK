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

/*
 * Address table
 * 0        model number
 * 5F 
 * 71C      current time/date
 * 784      ?array[3] (hex)
 * 785      ?array[3] (int)
 * 81       ?cont. update status (bool)
 * 786      ?array[3] (int)
 * 88       ?cont. update status (bool)
 * 787      ?array[3] (int)
 * 89       ?cont. update status (bool)
 * 78E      ?array[3] (hex)
 * 8A       ?cont. update status (bool)
 * 78F      ?array[3] (int)
 * 8B       ?cont. update status (bool)
 * 790      ?array[3] (int)
 * 8C       ?cont. update status (bool)
 * 791      ?array[3] (int)
 * 8D       ?cont. update status (bool)
 * 792      ?array[3] (int)
 * 8E       ?cont. update status (bool)
 * 793      ?array[3] (int)
 * 8F       ?cont. update status (bool)
 * 794      ?array[3] (hex)
 * 90       ?cont. update status (bool)
 */
namespace MSC_control
{
    public partial class Form1 : Form
    {
        Socket client;//socket
        byte[] bufbar = new byte[10240];
        String[,] addressTable = new String[4096,100]; //4096: FFF, 100: data received
        String[] addressMatched = new String[4096];
        String Target="";
        int matchedCount = 0;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //-----------------------------------------------
            //connect
            //-----------------------------------------------
            string ip = Properties.Settings.Default.ip_set;
            this.textBox1.Text = ip;
            int port = Convert.ToInt16(Properties.Settings.Default.port_set);
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(ip), port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(endpoint);//connect to server
                client.BeginReceive(bufbar, 0, bufbar.Length, SocketFlags.None, new AsyncCallback(dataReceive), client);
                this.label24.Text = "已经连接";
            }
            catch (Exception)
            {
               //throw;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            checkBox_scanCompleted.Checked = false;
            Target =textBox_Target.Text;
            scanAddress();
            //scan for similaries
            for (int i_btnSearch1 = 0; i_btnSearch1 <= 4096; i_btnSearch1++)
            {
                for (int i_btnSearch2 = 0; i_btnSearch2 <= 100; i_btnSearch2++)
                {
                    if (string.IsNullOrEmpty(addressTable[i_btnSearch1,i_btnSearch2]))
                        continue;
                    if (addressTable[i_btnSearch1, i_btnSearch2].ToLowerInvariant().Contains(Target.ToLowerInvariant()))
                    {
                        matchedCount += 1;
                        addressMatched[matchedCount] = i_btnSearch1.ToString("X");
                        
                    }
                }
            }

        }
        private void button_Reset_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------------------
        //Functions
        //---------------------------------------------------------------------------------
        void scanAddress()
        {
            String strHex = "";
            int i2;
            for (i2 = 0; i2 <= 4096; i2++)
            {
                strHex = i2.ToString("X");
                String command = "sRI " + strHex;
                Byte[] commad_arry = Encoding.UTF8.GetBytes(command);
                Byte[] send = new Byte[command.Length + 2];
                send[0] = 0x02;
                for (int i = 0; i < command.Length; i++)
                {
                    send[i + 1] = commad_arry[i];
                }
                send[command.Length + 1] = 0x03;
                client.Send(send);
                System.Threading.Thread.Sleep(100);
            }
            checkBox_scanCompleted.Checked = true;
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
            if ("sRA"==_commandArry[0])
            {
                try
                {
                    int addressInt = Convert.ToInt32(_commandArry[1], 16);
                    int i_pars;
                    for (i_pars = 0; i_pars <= 100; i_pars++)
                    {
                        addressTable[addressInt, i_pars] = _commandArry[2];
                    }
                }
                catch
                {
                    
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Properties.Settings.Default.ip_set = textBox1.Text;
                Properties.Settings.Default.Save();

            }
        }
    }
}

