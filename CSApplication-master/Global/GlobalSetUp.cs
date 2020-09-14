using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliciesManager.Global
{
    public static class GlobalSetUp
    {
        public static readonly String JsonPath = AppDomain.CurrentDomain.BaseDirectory + "Policies.json";
    }
}
