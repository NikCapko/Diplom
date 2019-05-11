using System;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Server";
            Console.WriteLine("Server started...");

            ServerObject server = new ServerObject();
            Task serverTask = new Task(server.StartServer);

            serverTask.Start();
            serverTask.Wait();

            Console.WriteLine("Server stoped!");
            Console.ReadKey();
        }
    }
}
