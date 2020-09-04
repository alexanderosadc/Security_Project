using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace Top_Secret
{
    public enum PolicySource
    {
        localMachine,
        webServer
    }

    public class Policy
    {
        private readonly string pathToThePolicyFile;
        private readonly PolicySource policySource;
        private Dictionary<string, string> policiesFromFile;

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
                WriteLocalMachinePoliciesToTable();
            }
            else if(policySource == PolicySource.webServer)
            {
                ExtractPolicyFromWeb();
            }
        }
        
        private void ExtractLocalPolicy()
        {

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "secedit.exe",
                Arguments = "/export /cfg " + pathToThePolicyFile,
                Verb = "runas",
            };

            process.StartInfo = startInfo;
            Debug.WriteLine(startInfo.Arguments);

            process.Start();

            process.WaitForExit();
            process.Close();
        }

        private void ExtractPolicyFromWeb()
        {
           // string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string urlToSite = "https://www.irs.gov/pub/irs-utl/Safeguards%20Windows%2010%20Audit%20File%20v1.2.audit";
            WebClient webClient = new WebClient();

            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(urlToSite), pathToThePolicyFile);

            webClient.Dispose();
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
           // Debug.WriteLine(e.ProgressPercentage);
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            Debug.WriteLine("Download completed!");
        }

        private void WriteLocalMachinePoliciesToTable()
        {
            string localPoliciesText = System.IO.File.ReadAllText(pathToThePolicyFile);
            
        }
    }
}