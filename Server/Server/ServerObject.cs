using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Server
{
    public class ServerObject
    {
        private int acceptPort; // Порт для "приема" новых клиентов
        public int receivePort; // Порт для приема сообщений от "подключенных клиентов"
        private Socket listeningSocket; // Сокет для "приема" новых клиентов
        public List<User> users = new List<User>(); // Список всех "подключенных" клиентов

        static byte[] buffer = new byte[1024];
        static MemoryStream stream = new MemoryStream(buffer);
        BinaryReader reader = new BinaryReader(stream);
        BinaryWriter writer = new BinaryWriter(stream);

        List<string> listCode = new List<string>();

        /// <summary>
        /// Запуск сервера
        /// </summary>
        public void StartServer()
        {
            Console.Write("Write port for accept users: ");
            acceptPort = Int32.Parse(Console.ReadLine());
            Console.Write("Write port for receive message: ");
            receivePort = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            try
            {
                listeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); // Создаем сокет

                Task listenTask = new Task(Listen); // Создаем отдельный поток для метода
                listenTask.Start(); // Запускаем поток
                listenTask.Wait(); // Ожидаем завершения потока
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in StartServer(): " + ex.Message);
            }
            finally
            {
                StopServer(); // Останавливаем сервер
            }
        }

        /// <summary>
        /// Ожидание "подключений" к серверу
        /// </summary>
        private void Listen()
        {
            try
            {
                IPEndPoint acceptIP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), acceptPort); //Создаем конечную точку на которую будут приходить сообщения
                listeningSocket.Bind(acceptIP);

                while (true)
                {
                    int bytes = 0;
                    EndPoint senderIP = new IPEndPoint(IPAddress.Any, 0);

                    do
                    {
                        bytes = listeningSocket.ReceiveFrom(buffer, ref senderIP);
                    }
                    while (listeningSocket.Available > 0);

                    bool getData = true;
                    listCode.Clear();

                    while (getData)
                    {
                        string data = reader.ReadString();

                        if (data != "")
                            listCode.Add(data);
                        else
                            getData = false;
                    }

                    IPEndPoint senderFullIP = senderIP as IPEndPoint;
                    // Добавляем пользователя в список подключенных
                    bool addNewUser = true;
                    bool firstUser = false;

                    if (users.Count == 0)
                    {
                        AddUser(senderFullIP);
                        firstUser = true;
                        addNewUser = false;
                        Console.WriteLine("First connected {0}:{1} his name - {2}", senderFullIP.Address.ToString(), senderFullIP.Port.ToString(), users.Find(x => x.FullInfoIP == senderFullIP).Name);
                    }

                    if (firstUser == false)
                        for (int i = 0; i <= users.Count; i++)
                            if (users[i].FullInfoIP.Address.ToString() == senderFullIP.Address.ToString())
                                addNewUser = false;
                    if (addNewUser == true)
                    {
                        AddUser(senderFullIP);
                        Console.WriteLine("Connected {0}:{1} his name - {2}", senderFullIP.Address, senderFullIP.Port, users.Find(x => x.FullInfoIP == senderFullIP).Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Listen(): " + ex.Message);
            }
            finally
            {
                StopServer();
            }
        }


        /// <summary>
        /// Рассылка сообщений всем пользователям кроме одного
        /// </summary>
        /// <param name="address">Адрес отправителя (на этот адрес не будет отправлено сообщение)</param>
        /// <param name="reply">Отправить отправителю</param>
        public void BroadcastMessage(string address, bool reply)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].FullInfoIP.Address.ToString() != address && !reply)
                {
                    listeningSocket.SendTo(buffer, users[i].FullInfoIP);
                }
                else
                {
                    if (users[i].FullInfoIP.Address.ToString() == address && reply)
                    {
                        listeningSocket.SendTo(buffer, users[i].FullInfoIP);
                    }
                }
            }
        }

        /// <summary>
        /// Рассылка сообщений всем пользователям кроме одного
        /// </summary>
        /// <param name="data">Массив байт, который хотите отправить</param>
        /// <param name="address">Адрес отправителя (на этот адрес не будет отправлено сообщение)</param>
        /// <param name="reply">Отправить отправителю</param>
        public void BroadcastMessage(byte[] data, string address, bool reply)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].FullInfoIP.Address.ToString() != address && !reply)
                {
                    listeningSocket.SendTo(buffer, users[i].FullInfoIP);
                }
                else
                {
                    if (users[i].FullInfoIP.Address.ToString() == address && reply)
                    {
                        listeningSocket.SendTo(buffer, users[i].FullInfoIP);
                    }
                }
            }
        }

        /// <summary>
        /// Добавление клиента в список "подключенных"
        /// </summary>
        /// <param name="senderFullIP">Информация о новом клиенте</param>
        private void AddUser(IPEndPoint senderFullIP)
        {
            User user = new User();
            user.Id = Guid.NewGuid().ToString();
            user.FullInfoIP = senderFullIP;
            user.Name = listCode[0];

            listCode.Clear();

            users.Add(user);
            ClientObject client = new ClientObject(this, user, receivePort);

            stream.SetLength(0);

            writer.Write("1");
            BroadcastMessage(senderFullIP.Address.ToString(), true);

        }

        /// <summary>
        /// Запуск метода для прослушивания данного клиента в отдельном потоке
        /// </summary>
        /// <param name="client">Клиент для которого запускается отдельный поток</param>
        public void UserIsAdded(ClientObject client)
        {
            Task clientTask = new Task(client.Listen);
            clientTask.Start();
        }

        /// <summary>
        /// Остановка сервера
        /// </summary>
        private void StopServer()
        {
            if (listeningSocket != null)
            {
                listeningSocket.Shutdown(SocketShutdown.Both);
                listeningSocket.Close();
                listeningSocket = null;
            }
        }
    }
}