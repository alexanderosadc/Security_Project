using PoliciesManager.EventManager;
using System;
using System.Diagnostics;
using System.Net;

namespace PoliciesManager.Scraper
{
    public class DownloadManager
    {
        private readonly string url = "https://www.irs.gov/pub/irs-utl/Safeguards%20Windows%2010%20Audit%20File%20v1.2.audit";
        private string data;

        public DownloadManager()
        {
            EventManager.EventManager.StartDownloading += DownlaodPolicies;
        }
        public string GetData()
        {
            return data;
        }
        private void DownlaodPolicies(EventArgs args)
        {
           WebClient webClient = new WebClient();
            Uri uri = new Uri(url);

            webClient.DownloadProgressChanged += Downloading;
            webClient.DownloadStringCompleted += DownloadStringComplete;
            webClient.DownloadStringAsync(uri);
        }

        private void Downloading(object sender, DownloadProgressChangedEventArgs e)
        {
            EventManager.EventManager.OnDownloading(e.ProgressPercentage);
        }

        private void DownloadStringComplete(object sender, DownloadStringCompletedEventArgs e)
        {
            data = e.Result.ToString();
            EventManager.EventManager.OnFinishDownloading();
        }

    }
}
