using DownloadingManager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Top_Secret
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private OperatingSystem OSInfo;
        PoliciesDownloader policiesDownloader;


        public MainWindow()
        {
            InitializeComponent();
            OSInfo = System.Environment.OSVersion;
            policiesDownloader = new PoliciesDownloader();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FindName("OS_Information_Text") != null)
            {
                
                TextBlock OSInformationText = FindName("OS_Information_Text") as TextBlock;

                OSInformationText.Text = OSInfo.VersionString;
                CustomEventController.OnStartDownloading();
                Debug.WriteLine("Pressed");
            }
        }
    }
}