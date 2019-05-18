using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class ServerObject
    {
        private int serverPort; // Порт для "приема" новых клиентов

        private Socket acceptSocket; // Сокет для "приема" новых клиентов
        public List<ClientObject> users = new List<ClientObject>(); // Список всех "подключенных" клиентов 

        static byte[] buffer = new byte[10240]; // Массив байт, в котором будут хранится полученные данные или данные для отправки

        List<string> listData = new List<string>(); // Список полученных и распарсенных данных от клиента

        public static ManualResetEvent socketEvent = new ManualResetEvent(false);

        /// <summary>
        /// Запуск сервера
        /// </summary>
        public void StartServer()
        {
            //Console.Write("Enter port for received data: ");
            serverPort = 8083; //Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            try
            {
                acceptSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); // Создаем сокет

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
        /// Получение данных от клиентов
        /// </summary>
        private void Listen()
        {
            try
            {
                IPEndPoint acceptIP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), serverPort); // Устанавливаем локальную точку клиента
                acceptSocket.Bind(acceptIP); // Привязываем точку

                while (true)
                {
                    int bytes = 0; // Счетчик полученных байт с сервера
                    buffer = new byte[10240]; // Массив байт, для данных полученных с сервера
                    listData.Clear(); // Очищаем список устаревших полученных данных

                    StringBuilder builder = new StringBuilder();
                    EndPoint senderIP = new IPEndPoint(IPAddress.Any, 0);

                    do
                    {
                        bytes = acceptSocket.ReceiveFrom(buffer, ref senderIP); // Прием данных от сервера
                        builder.Append(Encoding.UTF8.GetString(buffer, 0, bytes)); // Строим сообщение из полученных данных ( массива байт )
                    }
                    while (acceptSocket.Available > 0);

                    IPEndPoint senderFullIP = senderIP as IPEndPoint;

                    // Добавляем пользователя в список "подключенных"
                    bool addNewUser = true;
                    bool firstUser = false;
                    IPEndPoint client = new IPEndPoint(IPAddress.Parse("0.0.0.0"), 0);

                    if (users.Count == 0)
                    {
                        string[] codes = builder.ToString().Split(';');

                        foreach (string s in codes)
                        {
                            listData.Add(s);
                        }

                        AddUser(senderFullIP);

                        firstUser = true;
                        addNewUser = false;
                        client = senderFullIP;
                        Console.WriteLine("First connected {0}:{1} his name - {2}", senderFullIP.Address.ToString(), senderFullIP.Port.ToString(), users.Find(x => x.user.FullInfoIP.ToString() == senderFullIP.ToString()).user.Name);
                    }

                    if (firstUser == false)
                    {
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].user.FullInfoIP.ToString() == senderFullIP.ToString())
                            {
                                addNewUser = false;
                                break;
                            }
                        }
                    }

                    if (addNewUser == true)
                    {
                        string[] codes = builder.ToString().Split(';');

                        foreach (string s in codes)
                        {
                            listData.Add(s);
                        }

                        AddUser(senderFullIP);

                        Console.WriteLine("Connected {0}:{1} his name - {2}", senderFullIP.Address.ToString(), senderFullIP.Port.ToString(), users.Find(x => x.user.FullInfoIP.ToString() == senderFullIP.ToString()).user.Name);
                    }
                    else if (senderFullIP.ToString() != client.ToString()) // Если клиент от которого пришли данные уже подключен к серверу, тогда отправляем его данные на обработку
                    {
                        int index = users.FindIndex(x => x.user.FullInfoIP.ToString() == senderFullIP.ToString());
                        users[index].HandlerData(builder.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Listen(): " + ex.Message);
            }
            finally
            {
                StopServer(); // Останавливаем сервер
            }
        }

        public string getUserKey(string userName)
        {
            string key = "";
            foreach (ClientObject user in users)
            {
                if (user.user.Name == userName)
                {
                    key = user.user.Key;
                    break;
                }
            }
            return key;
        }

        /// <summary>
        /// Рассылка сообщений
        /// </summary>
        /// <param name="address">Адрес отправителя ( на этот адрес не будет отправлено сообщение )</param>
        /// <param name="reply">Ответить отправителю</param>
        public void BroadcastMessage(string address, bool reply)
        {
            for (int i = 0; i < users.Count; i++)
            {
                /*if (users[i].user.FullInfoIP.Address.ToString() != address && !reply)
                {
                    acceptSocket.SendTo(buffer, users[i].user.FullInfoIP);
                }
                else */
                if (users[i].user.FullInfoIP.ToString() == address && reply)
                {
                    acceptSocket.SendTo(buffer, users[i].user.FullInfoIP);
                }
            }
        }

        /// <summary>
        /// Рассылка сообщений
        /// </summary>
        /// <param name="data">Массив байт который хотите отправить</param>
        /// <param name="address">Адрес отправителя ( на этот адрес не будет отправлено сообщение )</param>
        /// <param name="reply">Ответить отправителю</param>
        public void BroadcastMessage(byte[] data, string address, bool reply)
        {
            for (int i = 0; i < users.Count; i++)
            {
                /*if (users[i].user.FullInfoIP.Address.ToString() != address && !reply)
                {
                    acceptSocket.SendTo(data, users[i].user.FullInfoIP);
                }
                else */
                if (users[i].user.FullInfoIP.ToString() == address && reply)
                {
                    acceptSocket.SendTo(data, users[i].user.FullInfoIP);
                }
            }
        }
        /// <summary>
        /// Рассылка сообщений
        /// </summary>
        /// <param name="data">Массив байт который хотите отправить</param>
        /// <param name="username">Имя получателя ( этому пользователю будет отправлено сообщение )</param>
        public void BroadcastMessage(byte[] data, string username)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].user.Name == username)
                {
                    acceptSocket.SendTo(data, users[i].user.FullInfoIP);
                    break;
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
            user.Name = listData[0].Split(':')[1];
            user.Key = listData[1].Split(':')[1];

            ClientObject client = new ClientObject(this, user);

            listData.Clear();

            users.Add(client);

            buffer = Encoding.UTF8.GetBytes("success");
            BroadcastMessage(senderFullIP.ToString(), true);
        }

        /// <summary>
        /// Удаление клиента из списка "подключенных" при отключении
        /// </summary>
        /// <param name="senderFullIP">Информация о новом клиенте</param>
        internal void DeleteUser(IPEndPoint senderFullIP)
        {
            for (int i = 0; i < users.Count; i++)
            {
                /*if (users[i].user.FullInfoIP.Address.ToString() != address && !reply)
                {
                    acceptSocket.SendTo(data, users[i].user.FullInfoIP);
                }
                else */
                if (users[i].user.FullInfoIP.ToString() == senderFullIP.ToString())
                {
                    users.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Остановка сервера
        /// </summary>
        private void StopServer()
        {
            if (acceptSocket != null)
            {
                acceptSocket.Close();
                acceptSocket = null;
            }
        }
    }
}
