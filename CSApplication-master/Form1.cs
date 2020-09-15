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


            //test input
            //List<int> selectedIndexes = new List<int> { 4, 2, 12 };
            //string test = $"..\\UserPolicyData\\Save\\aaaassdasfds.audit";


            //!!!!!!!!!!!!!!!!!!!!
            //functia asta face save, aici prosta trimiti indexurile pe care le-ao ales userul. te tip : List <int>
            //si treb sa trimiti directorul unde este user cand apasa pe save
            //dataClass.Save(selectedIndexex, curentDir);


            //!!!!!!!!!!!!!!!!!
            //functia asta face aceeasi huinea ca si cea de sus si tot treb list de int. Si mai trebuie numele la document care userul lo ales
            //path e default : "..\\UserPolicyData\\Save\\.." 
            //daca stii cum sa faci tipa userul sa aleaga singur ap spune

            //dataClass.SaveAs(selectedIndexes, test);



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
