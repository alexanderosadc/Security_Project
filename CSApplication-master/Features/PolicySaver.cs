using PoliciesManager.Global;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliciesManager.Features
{
    class PolicySaver
    {

        private IDictionary<int, Dictionary<string, string>> values;


        public PolicySaver()
        {
            values = GlobalSetUp.JsonDictionary();
        }

        public void SaveAsToFile(List<int> selectedIndexes, string policyName)
        {
            string _policyString = "";

            _policyString = SettingsInputer(_policyString);
            _policyString = PolicyToString(selectedIndexes, _policyString);

            File.WriteAllText($"..\\UserPolicyData\\Save\\{policyName}.audit", _policyString);
        }
        public void SaveToFile(List<int> selectedIndexes)
        {

            string _policyString = "";

            _policyString = SettingsInputer(_policyString);
            _policyString = PolicyToString(selectedIndexes, _policyString);

            File.WriteAllText(GlobalSetUp.UserSavePath, _policyString);

        }

        private string PolicyToString(List<int> test, string _policyString)
        {
            foreach (var policyIndex in test)
            {

                _policyString += "   <custom_item>\n";

                foreach (var block in values[policyIndex])
                {
                    _policyString += "\t" + block.Key + " : " + block.Value + "\n";
                }

                _policyString += "   </custom_item>\n\n";
            }

            return _policyString;
        }

        private string SettingsInputer(string _policyString)
        {
            Dictionary<string, string> _settingsDict = GetSettings();

            _policyString += "<check_type:\"Windows\" version:\"2\">\n< group_policy:\"MS Windows 10\" >\n< report type: \"INFO\" >\n\t" +
                "description : \"Safeguards Windows 10 Audit File v1.1 11-31-2016\"\n</ report >\n<if>\n  <condition type:\"and\">\n" +
                "   <custom_item\n";

            foreach (var setting in _settingsDict)
            {
                _policyString += "\t" + setting.Key + " : " + setting.Value + "\n";
            }

            _policyString += "    </custom_item>\n  </ condition >\n  < then > \n\n\n";
            return _policyString;
        }


        private Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> _settingsDict = values[0];
            return _settingsDict;
        }
    }
}
