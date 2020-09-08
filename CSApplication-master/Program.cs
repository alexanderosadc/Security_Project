using PoliciesManager.Parser;
using PoliciesManager.Scraper;
using System;

namespace PoliciesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var policies = new DownloadManager();
            var brutPolicies = policies.DownlaodPolicies();


            PolicyParser dataClass = new PolicyParser();

            dataClass.CustomItemRegex(brutPolicies);

            Console.WriteLine("Finished");
            Console.ReadLine();

        }
    }
}
