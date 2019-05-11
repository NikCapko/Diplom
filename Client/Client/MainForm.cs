using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int acceptPort;
        private int sendPort;
        private Socket socket;
        private IPAddress address;

        private bool connected = false;

        private static byte[] buffer = new byte[1024];
        private static MemoryStream stream = new MemoryStream(buffer);
        private BinaryWriter writer = new BinaryWriter(stream);
        private BinaryReader reader = new BinaryReader(stream);

        private List<string> listCode = new List<string>();

        void SendData(int port)
        {
            EndPoint _serverPoint = new IPEndPoint(address, port);
            EndPoint serverPoint = _serverPoint;
            socket.SendTo(buffer, serverPoint);
        }

        void ReceiveData()
        {
            int bytes = 0;

            EndPoint remoteIp = new IPEndPoint(IPAddress.Any, 0);
            listCode.Clear();
            do
            {
                bytes = socket.ReceiveFrom(buffer, ref remoteIp);
            }
            while (socket.Available > 0);

            bool getData = true;

            stream.Position = 0;
            while (getData)
            {
                string data = reader.ReadString();

                if (data != "")
                {
                    listCode.Add(data);
                }
                else
                {
                    getData = false;
                }
            }

            IPEndPoint remoteFullIP = remoteIp as IPEndPoint;

            HandleReceivedData();
        }

        void HandleReceivedData()
        {
            if (connected == false && listCode[0] == "1")
            {
                connected = true;
                //_btnConnect.text = "Отключиться";
                //_logs.text += "Вы успешно подключились";
            }
            else
            {
                //_logs.text += listCode[0] + "\n";
            }
        }

        void Close()
        {
            if (socket != null)
            {
                socket.Shutdown(SocketShutdown.Both);
                //acceptPort = Int32.Parse(_acceptPort.text);
                //sendPort = Int32.Parse(_sendPort.text);
            }
        }

        public void Btn_Connect_Click()
        {
            //address = IPAddress.Parse(_address.text);
            //acceptPort = Int32.Parse(_acceptPort.text);
            //sendPort = Int32.Parse(_sendPort.text);

            try
            {
                if (connected == false)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    IPEndPoint localIp = new IPEndPoint(IPAddress.Parse("0.0.0.0"), 0);
                    socket.Bind(localIp);
                    //writer.Write(_name.text);
                    //writer.Write(_color.text);
                    SendData(acceptPort);
                    ReceiveData();
                }
                else
                {
                    Close();
                    connected = false;
                    //_btnConnect.text = "Подключиться";
                    //_logs.text += "Вы успешно отключились";
                }
            }
            catch
            {
                Close();
            }
        }

        public void Btn_Status_Click()
        {
            if (connected == true)
            {

                stream.SetLength(0);
                writer.Write("STATUS");
                SendData(sendPort);
                ReceiveData();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {

        }
    }
}
