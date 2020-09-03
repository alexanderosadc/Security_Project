using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace Top_Secret
{
    public enum PolicySource
    {
        localMachine,
        web
    }

    public class Policy
    {
        private readonly string pathToThePolicyFile;
        private readonly PolicySource policySource;

        public Policy(PolicySource policySource)
        {
            this.policySource = policySource;
            this.pathToThePolicyFile = AppDomain.CurrentDomain.BaseDirectory + policySource.ToString() + ".inf";
        }
        
        public void UpdatePolicy()
        {
            if(policySource == PolicySource.localMachine)
            {
                ExtractLocalPolicy();    
            }
            else if(policySource == PolicySource.web)
            {
                ExtractPolicyFromWeb();
            }
        }

        private void ExtractLocalPolicy()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "secedit.exe /export /cfg +" + pathToThePolicyFile;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void ExtractPolicyFromWeb()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string urlToSite = "https://www.irs.gov/pub/irs-utl/Safeguards%20Windows%2010%20Audit%20File%20v1.2.audit";
            WebClient webClient = new WebClient();

            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(urlToSite), desktopPath);

            webClient.Dispose();
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