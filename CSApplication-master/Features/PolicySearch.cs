using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PoliciesManager.Global;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliciesManager.Parser
{
    class PolicySearch
    {

        IDictionary<int, Dictionary<string, string>> values;
        Dictionary<int, string> newValues = new Dictionary<int, string>();

        public PolicySearch()
        {
            values = GlobalSetUp.JsonDictionary();
        }


        private List<int> LoadJson(string policyToFind)
        {
            List<int> indexes = new List<int>();

            foreach (var key in values.Keys)
            {
                foreach (var keys in values[key])
                {
                    if (keys.Key == "type" && keys.Value.Contains(policyToFind.ToUpper()))
                    {
                        indexes.Add(key);                         
                    }
                }
            }

            return indexes;
        }

        public Dictionary<int, string> DisplayPolicies(string policyToFind)
        {
            List<int> policyIndexs = LoadJson(policyToFind);
            newValues.Clear();

            string valueContainer = "";
   
            foreach (var policyNumber in values.Keys)
            {
                if (policyIndexs.Contains(policyNumber))
                {
                    foreach (var item in values[policyNumber])
                    {
                        if (item.Key == "info" /*|| item.Key == "type"*/)
                        {
                            valueContainer += item.Value;
                        }
                        //valueContainer += "\n";
                    }

                    newValues.Add(policyNumber, valueContainer);

                    valueContainer = "";
    
                }
            }

            return newValues;
        }

        public List<string> GetUnitTypes()
        {

            List<string> uniqueTypes = new List<string>();

            foreach (var policyNumber in values.Keys)
            {
         
                foreach (var item in values[policyNumber])
                    {
                    if (item.Key == "type" && !uniqueTypes.Contains(item.Value))
                        uniqueTypes.Add(item.Value);
                    }
            }

            return uniqueTypes;
        }
    }
}
