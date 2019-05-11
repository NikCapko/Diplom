using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class ClientObject
    {
        ServerObject server;
        User user;
        int receivePort; // порт который будет принимать сообщения от данного клиента

        static byte[] buffer = new byte[1024];
        static MemoryStream stream = new MemoryStream(buffer);
        BinaryReader reader = new BinaryReader(stream);
        BinaryWriter writer = new BinaryWriter(stream);

        List<string> listCode = new List<string>();

        public ClientObject(ServerObject _server, User _user, int _port)
        {
            server = _server;
            user = _user;
            receivePort = _port;
            server.UserIsAdded(this);
        }
        // priem sms ot konkretnogo polzovatelya
        public void Listen()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint receiveIP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), receivePort);
            socket.Bind(receiveIP);

            while (true)
            {
                StringBuilder builder = new StringBuilder();
                int bytes = 0;
                EndPoint senderIP = new IPEndPoint(user.FullInfoIP.Address, user.FullInfoIP.Port);

                do
                {
                    bytes = socket.ReceiveFrom(buffer, ref senderIP);
                }
                while (socket.Available > 0);

                bool getData = true;
                stream.Position = 0;
                while (getData)
                {
                    string data = reader.ReadString();

                    if (data != "")
                        listCode.Add(data);
                    else
                        getData = false;
                }
                HandleReceiveData();
            }
        }
        private void HandleReceiveData()
        {
            for (int i = 0; i < listCode.Count; i++)
            {
                stream.SetLength(0);
                switch (listCode[i])
                {
                    case "Status":
                        string message = null;
                        for (int c = 0; c < server.users.Count; c++)
                        {
                            message += server.users[i].Name + "\n";
                        }
                        writer.Write(message);
                        server.BroadcastMessage(buffer, user.FullInfoIP.Address.ToString(), true);
                        break;
                }
            }
        }
    }
}