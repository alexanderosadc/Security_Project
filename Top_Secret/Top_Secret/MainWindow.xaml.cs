﻿using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Top_Secret
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //secedit.exe /configure /db %windir%\security\local.sdb /cfg D:\security-policy.inf
        private readonly OperatingSystem OSInfo;
        private readonly Policy localPolicy;
        private readonly Policy webPolicy;

        public MainWindow()
        {
            InitializeComponent();
            OSInfo = System.Environment.OSVersion;
            localPolicy = new Policy(PolicySource.localMachine);
            webPolicy = new Policy(PolicySource.webServer);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FindName("OS_Information_Text") != null)
            {
                TextBlock OSInformationText = FindName("OS_Information_Text") as TextBlock;
                OSInformationText.Text = OSInfo.VersionString;
                Debug.WriteLine("Pressed");
            }

            if (localPolicy != null)
            {
                localPolicy.UpdatePolicy();
            }

            if(webPolicy != null)
            {
                webPolicy.UpdatePolicy();
            }
        }
    }
}