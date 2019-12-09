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
 * addressTable array default
 * [000]    [000's content 1]   [000's content 2] ...  ... [000's content 100]
 * [001]
 * [002]
 * ...
 * ...
 * [FFF]
 * 
 * addressMatched array default
 * [000]
 * [001]
 * ...
 * ...
 * [FFF]
 */
namespace MSC_control
{
    public partial class Form1 : Form
    {
        //TCP params------------------------------------------------------------------
        Socket client;//socket
        byte[] bufbar = new byte[10240];

        //searching vars--------------------------------------------------------------
        String[,] addressTable = new String[4096,100]; //4096: FFF, 100: data received
        String[] addressMatched = new String[4096];    //defaults to 000-FFF, to Null if content not matched
        String Target="";                              //entered target
        int matchedCount = 0;                          //matched address count
        String addressMax="";                          //highest address of that given device

        //flags-----------------------------------------------------------------------
        bool sFA = false;                             //sFA 3 returned, max address reached
        bool replied = false;                         //replied to previous commnad, ready to send another
        bool noMatch = true;                          //entire address doesnt contain target value 

        //----------------------------------------------------------------------------
        //forms and buttons
        //----------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Port.Text = "2112";//defalut port
            
            for(int i_load=0;i_load<=4095;i_load++) //initalize addressMatched, assume 0-4095 matched
            {
                addressMatched[i_load] = i_load.ToString("X");
            }
        }

        private void button_Search_Click(object sender, EventArgs e)  //compares each respond output from addressTable
        {
            button_Search.Enabled= false;
            listBox_resultAddress.Items.Clear();
            checkBox_scanCompleted.Checked = false;
            Target =textBox_Target.Text;
            scanAddress();


            //search address table
            if (checkBox_Contains.Checked==false)
            {
                //scan for similaries (exact serch)
                for (int i_btnSearch1 = 0; i_btnSearch1 < 4095; i_btnSearch1++)
                {
                    noMatch = true;
                    for (int i_btnSearch2 = 0; i_btnSearch2 < 100; i_btnSearch2++)
                    {
                        if (string.IsNullOrEmpty(addressTable[i_btnSearch1, i_btnSearch2]))
                            continue;
                        if (addressTable[i_btnSearch1, i_btnSearch2] == Target)//exact search
                        {
                            noMatch = false;    //set no match flag to false, match found
                        }
                    }
                    if (noMatch == true)
                    {
                        addressMatched[i_btnSearch1] = null;
                    }
                    else
                    {
                        matchedCount += 1;
                        String combinedData = "";
                        for (int i_btnSearch3 = 0; i_btnSearch3 < 100; i_btnSearch3++)
                        {
                            combinedData = combinedData + addressTable[i_btnSearch1, i_btnSearch3] + " ";
                        }
                        listBox_resultAddress.Items.Add(addressMatched[i_btnSearch1] + "      " + combinedData);
                    }
                }
            }
            else
            {
                //scan for similaries (contains search)
                for (int i_btnSearch1 = 0; i_btnSearch1 < 4095; i_btnSearch1++)
                {
                    noMatch = true;
                    for (int i_btnSearch2 = 0; i_btnSearch2 < 100; i_btnSearch2++)
                    {
                        if (string.IsNullOrEmpty(addressTable[i_btnSearch1, i_btnSearch2]))
                            continue;
                        if (addressTable[i_btnSearch1, i_btnSearch2].Contains(Target))//contains search
                        {
                            noMatch = false;    //set no match flag to false, match found
                        }
                    }
                    if (noMatch == true)
                    {
                        addressMatched[i_btnSearch1] = null;
                    }
                    else
                    {
                        matchedCount += 1;
                        String combinedData = "";
                        for (int i_btnSearch3 = 0; i_btnSearch3 < 100; i_btnSearch3++)
                        {
                            combinedData = combinedData + addressTable[i_btnSearch1, i_btnSearch3] + " ";
                        }
                        listBox_resultAddress.Items.Add(addressMatched[i_btnSearch1] + "      " + combinedData);
                    }
                }
            }
            textBox_addressCount.Text = matchedCount.ToString();
            button_Search.Enabled = true;
        }
        private void button_Reset_Click(object sender, EventArgs e) //resets search results, intialize search array
        {
            clearTable();
            //initalize addressMatched, assume 0-4095 matched
            for (int i_load = 0; i_load <= 4095; i_load++)
            {
                addressMatched[i_load] = i_load.ToString("X");
            }
            listBox_resultAddress.Items.Clear();
            textBox_addressCount.Text = 0.ToString();
            textBox_addressSize.Text = 0.ToString();
            Target = "";
            
        }

        private void button_Connect_Click(object sender, EventArgs e) //connect with entered IP/Port        
        {
            //-----------------------------------------------
            //connect to ip
            //-----------------------------------------------
            string ip = textBox_IP.Text;//Properties.Settings.Default.ip_set;
            this.textBox_IP.Text = ip;
            int port = Convert.ToInt16(textBox_Port.Text);//Properties.Settings.Default.port_set);
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
                throw;
            }
        }
        //----------------------------------------------------------------------------------
        //Functions
        //---------------------------------------------------------------------------------
        void scanAddress()
        {
            clearTable();
            sFA = false;
            int i2;
            for (i2 = 0; i2 <= 4095; i2++)
            {
                while(addressMatched[i2]==null) //skip addresses that does not match in previous searches
                {
                    i2++;
                }
                String command = "sRI " + addressMatched[i2];
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
                while (replied == false && sFA == false)
                {
                    System.Threading.Thread.Sleep(10);//assuming ping: < 10ms
                }
            }
            checkBox_scanCompleted.Checked = true;
        }

        void clearTable()
        {
            matchedCount = 0;
            for (int i_clr=0; i_clr<4095;i_clr++)
            {
                for (int i_clr2 = 0; i_clr2 < 100; i_clr2++)
                {
                    addressTable[i_clr,i_clr2] = null;
                }
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
                Properties.Settings.Default.ip_set = textBox_IP.Text;
                Properties.Settings.Default.Save();

            }
        }


    }
}

