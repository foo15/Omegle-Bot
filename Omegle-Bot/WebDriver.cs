using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Omegle_Bot.Helpers;
using HtmlAgilityPack;

namespace Omegle_Bot
{
    public enum ChatType
    {
        TextChat,
        VideoChat
    }

    public sealed class WebDriver
    {
        public static List<Proxy> ProxyList { get; set; }

        public static bool proxiesEnabled;

        public ChatType chatType;
        public HttpClient client;
        public NetworkCredential credentials { get; private set; }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public WebDriver(ChatType type = ChatType.TextChat)
        {
            chatType = type;
        }
    }
}