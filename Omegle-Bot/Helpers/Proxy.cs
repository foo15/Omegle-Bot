using System;
using System.Net;
using System.Collections.Generic;

namespace Omegle_Bot.Helpers
{
    public sealed class Proxy
    {
        public IPAddress HOST { get; private set; }

        public int PORT { get; private set; }

        public Proxy(IPAddress ip, int port)
        {
            HOST = ip;
            PORT = port;
        }
        public override string ToString()
        {
            return HOST.ToString() + ":" + PORT.ToString();
        }
    }
}
