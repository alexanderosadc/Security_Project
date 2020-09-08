using MaterialSkin.Controls;
using PoliciesManager.Parser;
using PoliciesManager.Scraper;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PoliciesManager
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        MaterialLabel materialLabel;
        DownloadManager policies;
        public Form1()
        {
            InitializeComponent();
            
            policies = new DownloadManager();
            EventManager.EventManager.downloadingInProgress += Downloading;
            EventManager.EventManager.finishDownloading += FinishDownload;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            EventManager.EventManager.OnStartDownloading();
        }

        private void FinishDownload(EventArgs e)
        {
            PolicyParser dataClass = new PolicyParser();

            string brutPolicies = policies.GetData();
            dataClass.CustomItemRegex(brutPolicies);
            Debug.WriteLine("Finished");
            consoleOutput.Text = dataClass.GetJson();
        }

        private void Downloading(int progress)
        {
            Debug.Write("..");
        }
    }
}
