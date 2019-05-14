using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int serverPort; // Порт, который прослушивает сервер
        private IPAddress serverAddress; // IP адрес машины на котором запущен сервер
        private EndPoint serverPoint; // Точка сервера, на которую будут отправлятся данные
        private Socket socket; // Сокет

        private bool connected = false; // Режим клиента

        private byte[] buffer = new byte[256]; // Массив байт, в котором будут хронится полученные данные или данные для отправки

        /// <summary>
        /// Отправка данных на сервер
        /// </summary>
        /// <param name="data">Сообщение для отправки</param>
        void SendData(string data)
        {
            buffer = Encoding.UTF8.GetBytes(data); // Получаем массив байт из сообщения
            socket.SendTo(buffer, serverPoint); // Отправляем массив байт серверу
        }

        /// <summary>
        /// Прием данных от сервера
        /// </summary>
        void ReceiveData()
        {
            try
            {
                int bytes = 0; // Счетчик полученных байт с сервера
                buffer = new byte[256]; // Массив байт, для данных полученых с сервера

                StringBuilder builder = new StringBuilder();
                EndPoint remoteIp = new IPEndPoint(IPAddress.Any, 0);

                do
                {
                    bytes = socket.ReceiveFrom(buffer, ref remoteIp); // Прием данных от сервера
                    builder.Append(Encoding.UTF8.GetString(buffer, 0, bytes)); // Строим сообщение из полученных данных ( массива байт )
                }
                while (socket.Available > 0);

                IPEndPoint remoteFullIP = remoteIp as IPEndPoint;

                HandlReceivedData(builder.ToString()); // Вызов метода для обработки полученных данных
            }
            catch (Exception ex)
            {
                //Debug.Log("Error in ReceiveData: " + ex.Message);
            }
        }

        /// <summary>
        /// Обработка полученных данных
        /// </summary>
        /// <param name="data">Данные которые необходимо обработать</param>
        void HandlReceivedData(string data)
        {
            // Если клиент не подключен к серверу и сообщение от сервера это "1", тогда переводим клиент в режим "подключенного клиента"
            if (connected == false && data == "success")
            {
                connected = true;
                btnConnect.Text = "Отключиться";
                //txtLogs.text += "Вы успешно подключились!\n";
            }
            else if (connected == true) // А если клиент подключен к серверу, выводим все данные полученные с сервера на экран
            {
                //tbMessage.Text += data + "\n";
            }
        }

        /// <summary>
        /// Закрытие сокета
        /// </summary>
        void CloseSocket()
        {
            if (socket != null)
            {
                socket.Close();
                socket = null;
            }
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "Отправить сообщение"
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (connected == true) // Если клиент подключен к серверу
            {
                SendData("status"); // Отправляем на сервер данные
                ReceiveData(); // Ожидаем ответ от сервера
            }
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "Подключится!"
        /// </summary>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Заполнение переменных данными из InputField'ов

            if (tbServerAddress.Text.Contains(":"))
            {
                serverAddress = IPAddress.Parse(tbServerAddress.Text.Split(':')[0]);
                serverPort = Int32.Parse(tbServerAddress.Text.Split(':')[1]);

                try
                {
                    if (connected == false) // Если клиент не подключен
                    {
                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); // Инициализируем сокет
                        IPEndPoint localIP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), 8088); // Устанавливаем локальную точку клиента
                        socket.Bind(localIP); // Привязываем точку

                        serverPoint = new IPEndPoint(serverAddress, serverPort); // Инициализируем точку сервера, на которую клиент будет отправлять данные

                        SendData("username:" + tbSenderName.Text); // Отправляем данные на сервер
                        ReceiveData(); // Ждем ответа от сервера
                    }
                    else // Если клиент подключен к серверу, закрываем сокет и переводим клиент в режим не подключенного клиента
                    {
                        SendData("connect:close");
                        connected = false;
                        btnConnect.Text = "Подключиться";
                        //txtLogs.text += "Вы успешно отключились!";
                    }
                }
                catch (Exception ex)
                {
                    //Debug.Log("Error in Btn_Connect_Click: " + ex.Message);
                    CloseSocket();
                }
            }
        }
    }
}
