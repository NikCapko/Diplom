using System.Net;

namespace Server
{
    public class User
    {
        public string Id { get; set; }
        public IPEndPoint FullInfoIP { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
    }
}