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
            string[] codes = data.Split(':');
            foreach (string s in codes)
            {
                listCode.Add(s);
            }

            if (listCode.Count == 0)
            {
                buffer = Encoding.UTF8.GetBytes("Not receive data!!!");
                server.BroadcastMessage(buffer, user.FullInfoIP.Address.ToString(), true);
                return;
            }
            switch (listCode[0])
            {
                case "status":
                    string message = "";
                    buffer = Encoding.UTF8.GetBytes(message);
                    server.BroadcastMessage(buffer, user.FullInfoIP.Address.ToString(), true);
                    break;
                case "connect":
                    server.BroadcastMessage(buffer, user.FullInfoIP.Address.ToString(), true);
                    server.DeleteUser(user.FullInfoIP);
                    break;
            }
        }
    }
}