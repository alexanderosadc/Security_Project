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
                WritePoliciesToTable();
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

            process.Start();
            process.WaitForExit();
            process.Close();
        }

        private void ExtractPolicyFromWeb()
        {
            //https://www.irs.gov/privacy-disclosure/nessus-audit-files
            string urlToSite = "https://www.irs.gov/pub/irs-utl/Safeguards%20Windows%2010%20Audit%20File%20v1.2.audit";
            WebClient webClient = new WebClient();

            //webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            //webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFile(new Uri(urlToSite), pathToThePolicyFile);

            
            //webClient.Dispose();
        }

        private void WritePoliciesToTable()
        {
            int positionOfTheEqualsSign;
            string line;
            string key;
            string value;

            policiesFromFile = new Dictionary<string, string>();
            System.IO.StreamReader file = new System.IO.StreamReader(pathToThePolicyFile);

            while((line = file.ReadLine()) != null)
            {
                if (line.Contains('='))
                {
                    positionOfTheEqualsSign = line.IndexOf('=');
                    key = line.Substring(0, positionOfTheEqualsSign);
                    value = line.Substring(positionOfTheEqualsSign, line.LastIndexOf(line));
                    policiesFromFile.Add(key, value);
                }
            }
            file.Close();
            file.Dispose();
        }

        public string ReturnPathToThePolicy()
        {
            return pathToThePolicyFile;
        }
    }
}