using System;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using Omegle_Bot.Utils;

namespace Omegle_Bot
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddProxy_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Proxy List (.txt)|*.txt";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string[] lines = File.ReadAllLines(dlg.FileName);

                foreach (String line in lines)
                {

                }
            }
        }
    }
}
