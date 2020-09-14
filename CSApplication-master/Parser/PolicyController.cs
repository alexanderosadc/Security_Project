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
        //Dictionary<string, string> elementsFromPolicy = new Dictionary<string, string>();

        Search policySearch;
        Parser policyParser;
        private string textToShow;

        public PolicyController()
        {
            policySearch = new Search();
            policyParser = new Parser();
        }

        public void CustomItemRegex(string data)
        {
            textToShow =  policyParser.CustomItemRegex(data);
        }

        public string GetJson()
        {
            return textToShow;
        }
        

        public Dictionary<int, Dictionary<string, string>> PolicySearch(string input)
        {
            Dictionary<int, Dictionary<string, string>> dict = policySearch.DisplayPolicies(input);
            return dict;
        }

        //public Dictionary<string, string> GetListOfItems()
        //{
        //    elementsFromPolicy.Add("aaaa", "bbbb");
        //    return elementsFromPolicy;
        //}
    }
}
