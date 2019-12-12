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
/*data stream
 *Example            def
 *<STX>              -1        Header
 *sRA                 0        sRA
 *LMDscandata         1        LMDscandata
 *1                   2        version number
 *1                   3        device number 
 *114D00A             4        serial number
 *0 0                 5-6      device status (0 OK, 1 error, 2 pollution warning, pollution error) x2
 *2B26                7        telegram counter
 *2B9A                8        scan counter
 *744FCC8E            9        time since startup
 *744FE371           10        time of transmission
 *0 0                11-12     status of digital input  x2
 *1 0                13-14     status of digital output x2
 *0                  15        reserved
 *5DC                16        scan freq
 *A2                 17        measurement freq
 *0                  18        amount of encoder(=0, no encoder)
 *1                  19        amount of 18b channels
 *DIST1              20        content (DIST1, RSSI1, DIST2, RSSI2)
 *3F800000           21        scale factor
 *00000000           22        scale factor offset
 *FFF92230           23        start angle
 *D05                24        steps
 *32B                25        amount of data
 *[example data]     26-836    data(0000-FFFF)     [example data]: 1C6 1C3 1C0 1C2 1C2 1CD 1C7 1CF 1CA 1CC 1C7 1C7 1CA 1CB 1BD 1BC 1BA 1B9 1B4 1B0 1B8 1B9 1B5 1B0 1BA 1AF 1B9 1B0 1BE 1B6 1B1 1BA 1B1 1B8 1BC 1C4 1C6 1CA 1CD 1D1 1CA 1D2 1C6 173 630 606 608 60F 616 60C 610 618 619 624 618 629 626 63A 63E 63D 643 639 614 610 643 65B 64D 66F 642 5F4 5D9 5C8 5F2 5F8 5FB 622 61B 5DC 5B6 595 58F 5B3 622 654 613 59C 594 573 536 524 51E 51E 532 52F 547 58A 546 4CD 4CA 4CF 4C5 4C8 4B8 4C1 4CF 4DD 4CA 4A8 4A5 4A7 498 492 497 4AB 4BA 4C7 4D2 4E6 4F4 508 514 4F5 4D2 4DD 4CF 4C9 507 50E 512 515 518 4F8 499 48E 486 465 474 46B 466 48C 486 4A4 4CD 4DB 4BF 475 468 463 474 476 485 487 481 494 4DD 4A8 451 445 445 43F 458 486 4A5 4B6 49C 43B 43B 44A 476 492 4D9 4DF 486 493 4AB 4D1 522 52C 50F 4E5 4DB 4BE 4BB 4CC 4B3 4A7 4A4 48F 48C 44E 435 43D 43F 43B 43E 43B 442 43F 43E 4F0 BC8 BD1 C03 C46 C37 C3B C73 CB4 CDF CD9 CBA C88 C3F C1E B61 AC3 ACF BD8 C33 CD5 C82 C1E C1A C26 C2D C7C CDF CC4 C90 A7C A41 A2C A21 A1C A15 99C 8F0 8DD 8CF 8B9 8B1 8B2 8BE 8C7 8C3 8BE 8AD 8A8 8A6 8A0 8A0 8AE 8A2 89F 898 88D 885 889 884 886 87E 899 8B0 8A9 898 88C 88A 89F 8B7 8B9 8C6 8E0 8E2 8D8 8D0 8F0 A2B AD6 AC0 ABD AC0 ABE AC7 ACC AD1 AD5 ADC AE3 AE7 AEE AF5 AFD B05 B10 B18 B1E B2A B2F B38 B3F B48 B52 B59 B62 B68 B72 B7E B79 B62 B46 B21 B08 AE9 ACD AB0 9F1 913 8FB 8E0 8CE 8B8 8A1 88B 87C 868 856 840 82F 81C 80D 7FC 7EB 7DC 7C8 7C0 7BF 7CD 7D1 833 3A2 36D 2FF 2E1 2E4 2E3 2E9 2E0 2C9 2B8 2B9 298 27D 27E 275 283 274 276 27B 273 27B 27B 276 270 278 274 271 27C 277 285 275 287 27D 288 28A 286 293 28C 28A 284 28B 289 27E 27D 277 274 276 27C 26E 274 274 275 27D 288 304 303 2BE 284 27C 282 2CD 342 36E 359 36D 391 39B 38B 32D 2F0 2F3 30C 32D 324 326 325 32E 326 321 30E 2E4 2AE 287 2A0 2DD 303 312 314 308 30D 307 304 305 2FF 2FD 2FC 31A 3A9 3E5 3E8 3F1 3F1 3DE 3EA 3EE 3E8 3E7 3DF 3DA 3D4 3D2 3D4 3D2 3CA 3D9 3CC 3D3 3CD 3CD 3C5 3CC 3BD 3B7 3B7 3C6 498 5CC 5E1 5DF 5E2 5EF 5E7 5E7 5EB 5EE 5E4 4DD 3F6 3DF 3CE 3BE 3AE 3A0 393 385 37B 36C 35F 355 349 33D 331 324 31C 312 30B 2FC 2F2 2EB 2E8 2DE 2D0 2CE 2C2 2BA 2B3 2A8 2A9 29E 297 28E 286 281 281 27C 27A 26C 261 263 258 251 24F 245 236 229 231 233 239 23E 243 244 246 250 241 250 24D 24F 25A 25F 255 25B 262 262 264 26C 246 227 215 250 26A 27C 278 281 287 299 296 299 295 297 2A1 2A2 2A2 2AC 2B7 2B9 2BB 2C3 2CB 2CC 2C5 2D3 2D6 2E0 2DA 2DC 2DF 2E8 2F6 2F4 2FF 308 310 313 31B 322 326 32F 338 337 33F 34A 34B 357 35B 367 36E 378 36E 37E 0 718 D7 109 11F 11F 11C 118 119 116 123 11C 114 113 112 113 119 114 111 116 10D 10F 10E 109 10B 10C 107 10E 10C 105 10D 10A 10E 10D 10A 106 109 109 101 106 FC 103 100 101 108 106 100 104 105 102 FC 106 FA FE FE FB 100 107 F9 FE F7 FD 101 F6 F5 F8 F8 FC FF F6 F8 F9 FC FF F8 FE FC FE 108 10C 112 111 126 14C 25D 28A 294 299 29C 29B 297 290 28D 281 276 248 1B1 15C 129 1CF 265 28C 2A7 2A2 29B 29C 2A2 2A7 2AA 2A6 2A2 2A4 2A5 2A5 2A5 2A0 2A7 2A6 29E 2A8 2AA 2A5 2A4 2AB 2AA 2A2 2A5 28C 267 22C 265 280 290 2A7 2AB 28E 237 21E 211 1E1 1AD 1A2 19B 198 1A0 1A1 1A4 1C0 1E9 207 213 20F 215 21D 213 222 24A 2AD 2CD 2CF 2D5 2CD 2D2 2D7 2D8 2CC 2B4 2AE 2A7 2AC 2AE 2AB 2A6 2AA 2A4 2A8 291 28A 288 2A2 2A5 2AC 29E 296 273 260 2B7 301 310 312 30D 308 314 325 321 323 334 32F 33C 33C 33C 34A 342 33D 33F 321 307 2F6 2F2 2F8 2F8 2ED 2F4
 *0                 837        amount of 8b data (=0, no 8b data)
 *0                 838        position data (=0, no IMU)
 *1                 839        device name (0= no mane, 1= have name)
 *B                 840        device name length (0-F)
 *"not defined"     841        device name
 *0                 842        comment (0= no comment, 1= have comment)
 *0                 843        time transmitted (0= no time transmitted, 1= have time transmitted)
 *0                 844        event info (0= no event info, 1= have event info)
 *<ETX>             845        checksum
 */

namespace MSC_control
{
    public partial class Form1 : Form
    {
        Socket client;//socket
        byte[] bufbar = new byte[10240];
        double[] deg = new double[1000];
        double[] scanData = new double[1000];
        int dataLength = 0;
        //flags
        bool replied = false;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string ip = "192.168.1.49";// Properties.Settings.Default.ip_set;
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
            //init
            sendCommand("sMN SetAccessMode 03 F4724744");   //login
            sendCommand("sMI 3E");                          //enable scan, 3F to disable
            sendCommand("sMI 2");                           //logout, run

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

        void sendCommand(String command)
        {
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

        void parsedata(String data) 
        {
            String[] _commandArry = data.Split(' ');
            if (_commandArry[0] == "sRA"&&_commandArry[1]== "LMDscandata")
            {
                dataLength = Convert.ToInt32(_commandArry[25], 16);
                //collect scan data Y axis
                for (int i_para=0;i_para< dataLength; i_para++)
                {
                    scanData[i_para] = Convert.ToInt32(_commandArry[i_para + 26],16);   //scan data
                    deg[i_para] =- 185 / 2 + (185 / (float)dataLength)*(float)i_para;                 //scan deg
                }
                replied = true;
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

                replied = false;
                chart1.Series[0].Points.Clear();
                sendCommand("sRN LMDscandata 0");               //request scan data once
                while (replied == false)
                {
                    System.Threading.Thread.Sleep(10);
                }
            //data processing
                for (int i_btn=0; i_btn<= dataLength; i_btn++)
                {
                    if(deg[i_btn]<0)
                    {
                        scanData[i_btn] = scanData[i_btn] * Math.Sin(Math.PI * (90.0 - deg[i_btn]) / 180);
                    }
                    else if(deg[i_btn]> 0)
                    {
                        scanData[i_btn] = scanData[i_btn] * Math.Sin(Math.PI * (90.0 - deg[i_btn]) / 180);
                    }
                }
                chart1.Series[0].Points.DataBindXY(deg, scanData);
        }
    }
}
