using System;
using System.Net;
using System.Collections.Generic;

namespace Omegle_Bot.Utils
{
    public sealed class Proxy
    {
        public IPAddress IP_ADDRESS { get; private set; }

        public int PORT { get; private set; }

        public Proxy(IPAddress ip, int port)
        {
            IP_ADDRESS = ip;
            PORT = port;
        }
        public override string ToString()
        {
            return IP_ADDRESS.ToString() + ":" + PORT.ToString();
        }
    }
}
