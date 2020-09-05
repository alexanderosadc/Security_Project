using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;


namespace Top_Secret
{
    public class XmlParser
    {

        public void Parse(string pathToThePolicyFile)
        {
            List<Dictionary<string, string>> elementsFromXML = new List<Dictionary<string, string>>();
            
            
            string policyText = File.ReadAllText(pathToThePolicyFile);
            //policyText = policyText.Replace(" ", "");
            policyText = policyText.Replace(Environment.NewLine, "@");

            string pattern = "(?<=<custom_item>)(.*?)(?=</custom_item>)";
            Regex regex = new Regex(pattern);
            MatchCollection matchesCustItems = regex.Matches(policyText);

            
            if(matchesCustItems.Count > 0)
            {
                Dictionary<string, string> policyDict = new Dictionary<string, string>();
                string key = "";
                string value = "";

                foreach (Match matchCustItem in matchesCustItems)
                {
                    string matchingValue = matchCustItem.Value;
                    for(int i = 0; i < matchingValue.Length - 1; i ++)
                    {
                        if(matchingValue[i] == ':')
                        {
                            key = "empty";
                        }
                        else if(matchingValue[i] == '@')
                        {
                            key = "";
                            value = "";
                            policyDict.Clear();
                        }
                        else
                        {
                            if(key == "empty")
                            {
                                value += matchingValue[i];
                            }
                            else
                            {
                                key += matchingValue[i];
                            }
                            matchingValue[i] = ' ';
                        }
                    }
                }
            }

            /* System.IO.StreamReader file = new System.IO.StreamReader(pathToThePolicyFile);

           while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(':'))
                {
                    positionOfTheEqualsSign = line.IndexOf('=');
                    key = line.Substring(0, positionOfTheEqualsSign);
                    value = line.Substring(positionOfTheEqualsSign, line.LastIndexOf(line));
                    policiesFromFile.Add(key, value);
                }
            }
            */
        }
    }
}
