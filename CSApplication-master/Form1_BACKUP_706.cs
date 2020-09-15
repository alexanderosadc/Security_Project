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

<<<<<<< HEAD
            string brutPolicies = policies.GetData();
            dataClass.CustomItemRegex(brutPolicies);
            Debug.WriteLine("Finished");
            //consoleOutput.Text = dataClass.GetJson();
=======
            string input = "REGISTRY_SETTING";
            consoleOutput.Text = dataClass.GetJson();
            Dictionary<int, string> items = dataClass.PolicySearch(input);

            Debug.WriteLine("Pidar" + items.Count);
>>>>>>> f4fe85ce60a487a9a6c915043dffdd249c05fc6f

            foreach (KeyValuePair<int, string> element in items)
            {
                int i = 0;
<<<<<<< HEAD
                ElementsListBox.Items.Insert(i, element.Key);
=======

                ElementsListBox.Items.Insert(i, element.Value);
>>>>>>> f4fe85ce60a487a9a6c915043dffdd249c05fc6f
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
