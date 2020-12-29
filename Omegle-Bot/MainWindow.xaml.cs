using System;
using System.Net;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;
using System.Windows.Input;
using Omegle_Bot.Helpers;
using MahApps.Metro;

namespace Omegle_Bot
{

    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MenuItem_AddProxies_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Proxy List (.txt)|*.txt";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string[] lines = File.ReadAllLines(dlg.FileName);
                
                List<Proxy> proxyList = new List<Proxy>();

                foreach (String line in lines)
                {
                    IPAddress host;
                    int port;

                    String[] s = line.Split((char)':');
                    
                    if (IPAddress.TryParse(s[1], out host) && Int32.TryParse(s[2], out port))
                    {
                        proxyList.Add(new Proxy(host, port));
                    }
                }
                WebDriver.ProxyList = proxyList;
            }
        }
    }
}
