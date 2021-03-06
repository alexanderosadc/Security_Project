﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliciesManager.Global
{
    public static class GlobalSetUp
    {
        public static readonly String JsonPath = AppDomain.CurrentDomain.BaseDirectory + "Policies.json";
        public static readonly String LocalPath = AppDomain.CurrentDomain.BaseDirectory + "LocalPolicies.json";

        public static String UserSavePath = AppDomain.CurrentDomain.BaseDirectory + "LocalSave.audit";

        public static IDictionary<int, Dictionary<string, string>> JsonDictionary()
        {
            string json = File.ReadAllText(JsonPath);
            IDictionary<int, Dictionary<string, string>> values = JsonConvert.DeserializeObject<IDictionary<int, Dictionary<string, string>>>(json);
            return values;
        }

    }
}
