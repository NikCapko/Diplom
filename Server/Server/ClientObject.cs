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

        static byte[] buffer = new byte[10240];

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
            if (data.StartsWith("check"))
            {
                string userName = data.Split(';')[0].Split(':')[1];
                string message = "check:" + server.getUserKey(userName);
                buffer = Encoding.UTF8.GetBytes(message);
                server.BroadcastMessage(buffer, user.Name);
            }
            if (data.StartsWith("user"))
            {
                string userName = data.Split(';')[0].Split(':')[1];
                string pass = data.Split(';')[1].Split(':')[1];
                string passMessage = data.Split(';')[2].Split(':')[1];
                string message = "key:" + pass + ";message:" + passMessage + ";from:" + userName + ";";
                buffer = Encoding.UTF8.GetBytes(message);
                server.BroadcastMessage(buffer, userName);
            }
            else if (data == "status")
            {
                string message = "success";
                buffer = Encoding.UTF8.GetBytes(message);
                server.BroadcastMessage(buffer, user.FullInfoIP.Address.ToString(), true);
            }
            else if (data == "disconnect")
            {
                server.BroadcastMessage(buffer, user.FullInfoIP.Address.ToString(), true);
                Console.WriteLine("username " + user.Name + " is disconneted");
                server.DeleteUser(user.FullInfoIP);
            }
        }
    }
}