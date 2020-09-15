using MaterialSkin.Controls;
using PoliciesManager.Parser;
using PoliciesManager.Scraper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace PoliciesManager
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private DownloadManager policies;
        PolicyController dataClass;
        public Form1()
        {
            InitializeComponent();

            dataClass = new PolicyController();
            policies = new DownloadManager();
            EventManager.EventManager.DownloadingInProgress += Downloading;
            EventManager.EventManager.FinishDownloading += FinishDownload;
            EventManager.EventManager.OnStartDownloading();

        }

        private void checkButton_Click(object sender, EventArgs e)
        {

            string input = "REGISTRY_SETTING";
            consoleOutput.Text = dataClass.GetJson();
            Dictionary<int, string> items = dataClass.PolicySearch(input);

            Debug.WriteLine("Pidar" + items.Count);

            foreach (KeyValuePair<int, string> element in items)
            {
                int i = 0;

                ElementsListBox.Items.Insert(i, element.Value);
                i++;

            }
            }

        private void FinishDownload(EventArgs e)
        {
            

            string brutPolicies = policies.GetData();
            dataClass.CustomItemRegex(brutPolicies);
            Debug.WriteLine("Finished");
            
         

        }

        private void Downloading(int progress)
        {
            Debug.Write("..");
        }

        private void applyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
