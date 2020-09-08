using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PoliciesManager.Scraper
{
    class DownloadManager
    {
        public string DownlaodPolicies()
        {
            var httpClient = new HttpClient();

            var data = httpClient.GetStringAsync("https://www.irs.gov/pub/irs-utl/Safeguards%20Windows%2010%20Audit%20File%20v1.2.audit").Result;

            return data;
        }
    }
}
