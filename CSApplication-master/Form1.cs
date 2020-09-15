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
            PolicyController dataClass = new PolicyController();

            string brutPolicies = policies.GetData();
            dataClass.CustomItemRegex(brutPolicies);
            Debug.WriteLine("Finished");
            //consoleOutput.Text = dataClass.GetJson();

            Dictionary<int, string> items = dataClass.PolicySearch(SearchBox.Text);
            Debug.WriteLine("Pidor" + items.Count);
            ElementsListBox.Items.Clear();
            foreach (KeyValuePair<int, string> element in items)
            {
                ElementsListBox.Items.Add(element.Value);
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
            
        }

        private void selectAllSwitch_CheckedChanged(object sender, EventArgs e)
        {
            bool check = false;
            if(selectAllSwitch.Checked)
            {
                check = true;
            }
            
            for (int i = 0; i < ElementsListBox.Items.Count; i++)
            {
                ElementsListBox.SetItemChecked(i, check);
            }
        }
    }
}
