using Newtonsoft.Json;
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
        Search policySearch;
        Parser policyParser;
        private string _textToShow;

        public PolicyController()
        {
            policySearch = new Search();
            policyParser = new Parser();
        }

        public void CustomItemRegex(string data)
        {
            _textToShow =  policyParser.CustomItemRegex(data);
        }

        public string GetJson()
        {
            return _textToShow;
        }
        

        public Dictionary<int, string> PolicySearch(string input)
        {
            Dictionary<int, string> dict = policySearch.DisplayPolicies(input);
            return dict;
        }


        public List<string> GetUniqueTypes()
        {
            return policySearch.GetUnitTypes();
        }
    }
}
