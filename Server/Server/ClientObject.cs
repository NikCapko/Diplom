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
        public User user;

        static byte[] buffer = new byte[256];

        List<string> listCode = new List<string>();

        public ClientObject(ServerObject _server, User _user)
        {
            server = _server;
            user = _user;
        }

        /// <summary>
        /// Обработчик данных полученных от клиента
        /// </summary>
        /// <param name="data">Данные для обработки</param>
        internal void HandlerData(string data)
        {
            string[] codes = data.Split(';');
            foreach (string s in codes)
                listCode.Add(s);

            if (listCode.Count == 0)
            {
                buffer = Encoding.UTF8.GetBytes("Not receive data!!!");
                server.BroadcastMessage(buffer, user.FullInfoIP.Address.ToString(), true);
                return;
            }

            for (int i = 0; i < listCode.Count; i++)
            {
                switch (listCode[i])
                {
                    case "status":
                        string message = "";
                        for (int c = 0; c < server.users.Count; c++)
                        {
                            message += server.users[c].user.Name + ":" + "color" + ";\n";
                        }
                        Console.WriteLine(message);
                        buffer = Encoding.UTF8.GetBytes(message);
                        server.BroadcastMessage(buffer, user.FullInfoIP.Address.ToString(), true);
                        break;
                }
            }
        }
    }
}