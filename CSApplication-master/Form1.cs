using MaterialSkin.Controls;
using PoliciesManager.Parser;
using PoliciesManager.Scraper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace PoliciesManager
{
    public partial class Form1 : MaterialForm
    {
        private DownloadManager policies;
        public Form1()
        {
            InitializeComponent();
            
            policies = new DownloadManager();
            EventManager.EventManager.DownloadingInProgress += Downloading;
            EventManager.EventManager.FinishDownloading += FinishDownload;
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
            //consoleOutput.Text = dataClass.GetJson();

           Dictionary<string, string> items = dataClass.GetListOfItems();
            Debug.WriteLine("Pidor" + items.Count);
            foreach (KeyValuePair<string, string> element in items)
            {
                int i = 0;
                ElementsListBox.Items.Insert(i, element.Key);
                i++;
            }

        }

        private void Downloading(int progress)
        {
            Debug.Write("..");
        }

        private void applyButton_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ElementsListBox.Items.Count; i++)
            {
                ElementsListBox.SetItemChecked(i, !ElementsListBox.GetItemChecked(i));
            }
        }
    }
}
