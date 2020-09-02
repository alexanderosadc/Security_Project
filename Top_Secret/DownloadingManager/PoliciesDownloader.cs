using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace DownloadingManager
{
    public class PoliciesDownloader
    {
        public void DownloadPolicy()
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("https://www.irs.gov/pub/irs-utl/Safeguards%20Windows%2010%20Audit%20File%20v1.2.audit"),
                AppDomain.CurrentDomain.BaseDirectory + "windows.txt");
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
