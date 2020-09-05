using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Top_Secret
{
    public class XMLParser
    {
        private IEnumerable<string> elementsFromXML;
        XElement XMLFile;

        XMLParser(string pathToXML)
        {
            XMLFile = XElement.Load(pathToXML);
        }

        public string Parse()
        {
            string extractedData;
            elementsFromXML = XMLFile.Select(x => (string) x.Attribute("custom_item"));

            return extractedData;
        }
    }
}
