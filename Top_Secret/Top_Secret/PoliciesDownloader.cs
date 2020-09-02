using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace DownloadingManager
{
    public class PoliciesDownloader
    {
        public PoliciesDownloader()
        {
            CustomEventController.downloadEvent += StartDownloadingPolicy;
        }

        private void StartDownloadingPolicy(string arg)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string appPath = AppDomain.CurrentDomain.BaseDirectory + "windows.txt";
            Debug.WriteLine(AppDomain.CurrentDomain.BaseDirectory + "windows.txt");
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("https://www.irs.gov/pub/irs-utl/Safeguards%20Windows%2010%20Audit%20File%20v1.2.audit"),
                desktopPath + "/windowsaaaaaaaaaaaaaaaa.txt");
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Debug.WriteLine(e.ProgressPercentage);
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Debug.WriteLine("Download completed!");
        }
    }
}
