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
        public HtmlDocument document;
        public Proxy proxy;

        public void Connect()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.omegle.com/");
            request.Proxy = proxiesEnabled ? new WebProxy(proxy.HOST.ToString(), proxy.PORT)  : null;
        }

        public WebDriver(ChatType type = ChatType.TextChat)
        {
            chatType = type;
        }
    }
}