using Newtonsoft.Json;
using PoliciesManager.Features;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace PoliciesManager.Parser
{
    public class PolicyController
    {
        private PolicySearch _policySearch;
        private PolicyParser _policyParser;
        private PolicySaver _policySaver;
        private string _textToShow;

        public PolicyController()
        {
            _policySearch = new PolicySearch();
            _policyParser = new PolicyParser();
            _policySaver = new PolicySaver();
        }

        public void CustomItemRegex(string data)
        {
            _textToShow =  _policyParser.CustomItemRegex(data);
        }

        public string GetJson()
        {
            return _textToShow;
        }
        

        public Dictionary<int, string> PolicySearch(string input)
        {
            Dictionary<int, string> dict = _policySearch.DisplayPolicies(input);
            return dict;
        }

        public void Save(List<int> selecedIndexes, string curentDir)
        {
            _policySaver.SaveToFile(selecedIndexes, curentDir);
        }

        public void SaveAs(List<int> selectedIndexes, string userSelectedDir)
        {
            _policySaver.SaveAsToFile(selectedIndexes, userSelectedDir);
        }

        public List<string> GetUniqueTypes()
        {
            return _policySearch.GetUnitTypes();
        }
    }
}
