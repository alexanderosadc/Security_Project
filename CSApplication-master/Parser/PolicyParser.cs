using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace PoliciesManager.Parser
{
    public class PolicyParser
    {
        private readonly Dictionary<string, string> DictionaryInsider = new Dictionary<string, string>();
        private int _index = 0;
        private string json;
        private readonly string pathToJson;
        private string textToShow;

        public PolicyParser()
        {
            pathToJson = AppDomain.CurrentDomain.BaseDirectory + "Policies.json";
        }

        public void CustomItemRegex(string data)
        {
            var customItem = new Regex("(?<=<custom_item>)[^>]+(?=</custom_item>)");
            var beforeTwo = new Regex(@"^.*?(?=:)", RegexOptions.Multiline);
            var afterTwo = new Regex(@"(?<=:)(.+)", RegexOptions.Multiline);
            var betweenSpaces = new Regex(@"(.+)", RegexOptions.Multiline);
            string firstElement;
            string secondElement;
            string stringIndexer;
            string dictionaryToString;
            string lineString;


            List<string> listOfFirst = new List<string>();
            List<string> listOfSecond = new List<string>();


            data = ClearStringData(data);



            foreach (Match CustomItem in customItem.Matches(data))
            {

                foreach (Match customLine in betweenSpaces.Matches(CustomItem.Value))
                {

                    lineString = customLine.Value;

                    lineString = lineString.Replace("\n", "").Replace("\r", "");

                    if (string.IsNullOrWhiteSpace(lineString))
                        continue;


                    var item1 = beforeTwo.Matches(lineString);

                    if (item1.Count == 1)
                    {
                        firstElement = beforeTwo.Matches(lineString)[0].ToString();
                        secondElement = afterTwo.Matches(lineString)[0].ToString();

                        listOfFirst.Add(firstElement);
                        listOfSecond.Add(secondElement);
                    }
                    else
                    {
                        listOfSecond[listOfSecond.Count - 1] += lineString;
                    }
                }

                var numbersAndWords = listOfFirst.Zip(listOfSecond, (n, w) => new { first = n, second = w });
                
                foreach (var nw in numbersAndWords)
                {
                    try
                    {
                        DictionaryInsider.Add(nw.first, nw.second);
                        textToShow += nw.first + " : " + nw.second + "\n";
                    }
                    catch
                    {

                    }
                }
                stringIndexer = JsonConvert.SerializeObject(string.Format("{0}", _index));
                dictionaryToString = JsonConvert.SerializeObject(DictionaryInsider);

                json += stringIndexer + " : " + dictionaryToString + ",";

                _index += 1;

                listOfFirst.Clear();
                listOfSecond.Clear();

                DictionaryInsider.Clear();
            }

            json = json.Remove(json.Length - 1, 1);
            json = "{" + json + "}";


            File.WriteAllText(pathToJson, json);
        }


        private string ClearStringData(string text)
        {
            text = text.Replace("\n", "\n    ").Replace("\r", "\r    ").Replace("\"", " ");

            Regex regex = new Regex("[ ]{2,}", RegexOptions.Singleline);
            text = regex.Replace(text, " ");

            return text;
        }

        public string GetJson()
        {
            return textToShow;
        }
    }
}
