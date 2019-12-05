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
        String addressMax="";
        bool sFA = false;
        bool replied = false;

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
            string ip = "169.254.157.220";//Properties.Settings.Default.ip_set;
            this.textBox1.Text = ip;
            int port = Convert.ToInt16("2112");//Properties.Settings.Default.port_set);
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
            button_Search.Enabled= false;
            listBox_resultAddress.Items.Clear();
            checkBox_scanCompleted.Checked = false;
            Target =textBox_Target.Text;
            scanAddress();
            //scan for similaries
            for (int i_btnSearch1 = 0; i_btnSearch1 < 4095; i_btnSearch1++)
            {
                for (int i_btnSearch2 = 0; i_btnSearch2 < 1; i_btnSearch2++)
                {
                    if (string.IsNullOrEmpty(addressTable[i_btnSearch1, i_btnSearch2]))
                        continue;
                    //if (addressTable[i_btnSearch1, i_btnSearch2].ToLowerInvariant().Contains(Target.ToLowerInvariant())) (fuzzy search)
                    if (addressTable[i_btnSearch1, i_btnSearch2] == Target)
                    {
                        matchedCount += 1;
                        addressMatched[matchedCount] = i_btnSearch1.ToString("X");
                        String combinedData = "";
                        for (int i_btnSearch3 = 0; i_btnSearch3 < 100; i_btnSearch3++)
                        {
                            combinedData = combinedData + addressTable[i_btnSearch1, i_btnSearch3] + " ";
                        }
                        listBox_resultAddress.Items.Add(addressMatched[matchedCount]+"      "+ combinedData);

                    }
                }
            }
            textBox_addressCount.Text = matchedCount.ToString();
            button_Search.Enabled = true;
        }
        private void button_Reset_Click(object sender, EventArgs e)
        {
            listBox_resultAddress.Items.Clear();
            textBox_addressCount.Text = 0.ToString();
            textBox_addressSize.Text = 0.ToString();
            Target = "";
            
        }
        //----------------------------------------------------------------------------------
        //Functions
        //---------------------------------------------------------------------------------
        void scanAddress()
        {
            sFA = false;
            String strHex = "";
            int i2;
            for (i2 = 0; i2 < 4096&&sFA==false; i2++)
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
                replied = false;
                client.Send(send);
                while (replied==false&&sFA==false)
                {
                    System.Threading.Thread.Sleep(10);
                }
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
            switch (_commandArry[0])
            {
                case "sRA":
                    try
                    {
                        replied = true;
                        addressMax = _commandArry[1];
                        int addressInt = Convert.ToInt32(_commandArry[1], 16);
                        int i_pars;
                        for (i_pars = 0; i_pars < 100; i_pars++)
                        {
                            addressTable[addressInt, i_pars] = _commandArry[i_pars+2];
                        }
                        
                    }
                    catch
                    {

                    }
                break;
                case "sFA":
                    if (_commandArry[1]=="3")
                    {
                        sFA = true;
                        textBox_addressSize.Text = addressMax;
                    }
                break;
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

