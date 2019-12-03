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

            try
            {
                this.label24.Text = "已经连接";



                try
                {

                    int i3;
                    String strHex;
                        for (i3=0; i3<=16; i3++)
                        {
                            if (i3 >= 10)
                            {
                                switch (i3)
                                {
                                    case 10:
                                    strHex = "A";
                                        break;
                                    case 11:
                                    strHex = "B";
                                        break;
                                    case 12:
                                    strHex = "C";
                                        break;
                                    case 13:
                                    strHex = "D";
                                        break;
                                    case 14:
                                    strHex = "E";
                                        break;
                                    case 15:
                                    strHex = "F";
                                        break;
                                }
                            }
                            else if (i3 <=9)
                            {
                                strHex = i3.ToString();
                            }
                            
                            int i2;
                            for (i2 = 0; 99 <= i2; i2++)
                            {
                                String command = "sRI " + i2 + strHex;
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
                        }
                    
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {
                
              //  throw;
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
                case "sEA"://指令回复 

                    break;

                case "sRA"://查询指令回复 

                    if (_commandArry[1]=="50A")//output1 查询状态回复
                    {
                        if (_commandArry[2]=="1")
                        {
                            this.checkBox_Output1.Checked = true;
                            
                        }

                        if (_commandArry[2] == "0")
                        {
                            this.checkBox_Output1.Checked = false;

                        }
                        
                    }

                    if (_commandArry[1] == "50B")//output2 查询状态回复
                    {
                        if (_commandArry[2] == "1")
                        {
                            this.checkBox_Output2.Checked = true;

                        }

                        if (_commandArry[2] == "0")
                        {
                            this.checkBox_Output2.Checked = false;

                        }

                    }

                    if (_commandArry[1] == "50C")//output3 查询状态回复
                        {
                            if (_commandArry[2] == "1")
                            {
                                this.checkBox_Output3.Checked = true;

                            }

                            if (_commandArry[2] == "0")
                            {
                                this.checkBox_Output3.Checked = false;

                            }


                        }

                    if (_commandArry[1] == "50D")//output4 查询状态回复
                        {
                            if (_commandArry[2] == "1")
                            {
                                this.checkBox_Output4.Checked = true;

                            }

                            if (_commandArry[2] == "0")
                            {
                                this.checkBox_Output4.Checked = false;

                            }

                        }

                    if (_commandArry[1] == "50E")//Relay1 查询状态回复
                        {
                            if (_commandArry[2] == "1")
                            {
                                this.checkBox_Relay1.Checked = true;

                            }

                            if (_commandArry[2] == "0")
                            {
                                this.checkBox_Relay1.Checked = false;

                            }

                        }

                    if (_commandArry[1] == "50F")//Relay2 查询状态回复
                        {
                            if (_commandArry[2] == "1")
                            {
                                this.checkBox_Relay2.Checked = true;

                            }

                            if (_commandArry[2] == "0")
                            {
                                this.checkBox_Relay2.Checked = false;

                            }

                        }

                    break;


                case "sSI"://时间,速度,状态返回值

                    if (_commandArry[1]== "5F")//2D指令返回
                    {
                        this.textBox_Date.Text = _commandArry[7];
                        textBox_Time.Text = _commandArry[3];
                        textBox_speed.Text = ((float)(Convert.ToInt32(_commandArry[8], 16))/1000.0).ToString("0.000");


                        //System Ready
                        if (_commandArry[9]=="1")
                        {
                            this.checkBox_DeviceReady.Checked = true; 
                        }
                        if (_commandArry[9] == "0")
                        {
                            this.checkBox_DeviceReady.Checked = false; 
                        }

                        //device ready
                        if (_commandArry[10] == "1")
                        {
                            checkBox_SystemReady.Checked = true;
                        }
                        if (_commandArry[10] == "0")
                        {
                            checkBox_SystemReady.Checked = false;
                        }

                        //result
                        if (_commandArry[11] == "1")
                        {
                            checkBox_Result.Checked = true;
                        }
                        if (_commandArry[11] == "0")
                        {
                            checkBox_Result.Checked = false;
                        }

                        
                    }

                    if (_commandArry[1] == "54"  && _commandArry.Length==5) //Output1
                    {

                        if (_commandArry[4]=="1")
                        {
                            checkBox_Output1.Checked = true;   
                        }

                        if (_commandArry[4] == "0")
                        {
                            checkBox_Output1.Checked = false;
                        }
                    }  

                    if (_commandArry[1] == "55") //Output2
                    {

                        if (_commandArry[4]=="1")
                        {
                            checkBox_Output2.Checked = true;   
                        }

                        if (_commandArry[4] == "0")
                        {
                            checkBox_Output2.Checked = false;
                        }
                    }

                    if (_commandArry[1] == "56") //Output3
                    {

                        if (_commandArry[4] == "1")
                        {
                            checkBox_Output3.Checked = true;
                        }

                        if (_commandArry[4] == "0")
                        {
                            checkBox_Output3.Checked = false;
                        }
                    }

                    if (_commandArry[1] == "58") //Output4
                    {

                        if (_commandArry[4] == "1")
                        {
                            checkBox_Output4.Checked = true;
                        }

                        if (_commandArry[4] == "0")
                        {
                            checkBox_Output4.Checked = false;
                        }
                    }

                    if (_commandArry[1] == "94") //relay1
                    {

                        if (_commandArry[4] == "1")
                        {

                            checkBox_Relay1.Checked = true;
                        }

                        if (_commandArry[4] == "0")
                        {
                            checkBox_Relay1.Checked = false;
                        }
                    }

                    if (_commandArry[1] == "59") //Relay2
                    {

                        if (_commandArry[4] == "1")
                        {
                            checkBox_Relay2.Checked = true;
                        }

                        if (_commandArry[4] == "0")
                        {
                            checkBox_Relay2.Checked = false;
                        }
                    }  

                    break;

                case "sAN"://写入指令回复
                    break;    
                        

 
                default:
                    break;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
