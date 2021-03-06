﻿using MaterialSkin.Controls;
using PoliciesManager.Global;
using PoliciesManager.Parser;
using PoliciesManager.Scraper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace PoliciesManager
{
    public partial class Form1 : MaterialForm
    {
        private DownloadManager policies;
        PolicyController dataClass;
        SaveFileDialog savefile;
        List<bool> fullListOfIndexes = new List<bool>();
        public Form1()
        {
            InitializeComponent();


            
            policies = new DownloadManager();
            EventManager.EventManager.DownloadingInProgress += Downloading;
            EventManager.EventManager.FinishDownloading += FinishDownload;
            EventManager.EventManager.OnStartDownloading();
            savefile = new SaveFileDialog();

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            EventManager.EventManager.OnStartDownloading();
        }

        private void FinishDownload(EventArgs e)
        {
            dataClass = new PolicyController();

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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            List<int> indexes = new List<int>();
            for(int i = 0; i < ElementsListBox.Items.Count; i++)
            {
                if(ElementsListBox.GetItemChecked(i))
                {
                    indexes.Add(i);
                }
            }
            SearchBox.Text = "";
            selectAllSwitch.Checked = false;
            checkButton.PerformClick();
            dataClass.Save(indexes, GlobalSetUp.LocalPath);
        }

        private Thread InvokeThread;
        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            InvokeThread = new Thread(new ThreadStart(OpenSaveAsDialog));
            InvokeThread.SetApartmentState(ApartmentState.STA);
            InvokeThread.Start();
            savefile.FileOk += SaveAs;
        }

        private void OpenSaveAsDialog()
        {
            Debug.Write("Ahtung");
            savefile.FileName = "policy.json";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.audit)|*.audit|All files (*.*)|*.*";
            savefile.ShowDialog();
            
           
        }

        private void SaveAs(object sender, CancelEventArgs e)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < ElementsListBox.Items.Count; i++)
            {
                if (ElementsListBox.GetItemChecked(i))
                {
                    indexes.Add(i);
                }
            }
            
            Debug.Write(indexes);
            dataClass.SaveAs(indexes, savefile.FileName);
        }

        private void CheckSysButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < ElementsListBox.Items.Count; i++)
            {
                bool boolValue = rand.Next(2) == 1 ? true : false;
                ElementsListBox.SetItemChecked(i, boolValue);
                fullListOfIndexes.Add(ElementsListBox.GetItemChecked(i));
            }
        }

        private void applyPolicyButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Policies Applied", "Policy",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ElementsListBox.Items.Count; i++)
            {
                Debug.WriteLine(fullListOfIndexes[i]);
                ElementsListBox.SetItemChecked(i, fullListOfIndexes[i]);
            }
        }

        private void ElementsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
