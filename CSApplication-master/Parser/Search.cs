using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PoliciesManager.Global;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliciesManager.Parser
{
    class Search
    {

        string json;
        IDictionary<int, Dictionary<string, string>> values;
        Dictionary<string, string> insideDic = new Dictionary<string, string>();

        Dictionary<int, Dictionary<string, string>> newValues = new Dictionary<int, Dictionary<string, string>>();
        public Search()
        {
            json = File.ReadAllText(GlobalSetUp.JsonPath);
            values = JsonConvert.DeserializeObject<IDictionary<int, Dictionary<string, string>>>(json);
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

        public Dictionary<int, Dictionary<string, string>> DisplayPolicies(string policyToFind)
        {
            List<int> policyIndexs = LoadJson(policyToFind);

            newValues.Clear();
   
            foreach (var policyNumber in values.Keys)
            {
                if (policyIndexs.Contains(policyNumber))
                {
                    foreach (var item in values[policyNumber])
                    {
                        //insideDic.Add(item.Key, item.Value);
                        if (item.Key == "info")
                        {
                            insideDic.Add(item.Key, item.Value);
                        }
                    }

                    newValues.Add(policyNumber, insideDic);
                    insideDic.Clear();
                }
            }

            return newValues;

        }
    }
}
