using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CanidBot
{
    class Utilities
    {
        private static Dictionary<string, string> alerts;

        static Utilities()
        {
            string Json = File.ReadAllText("Alerts/alerts.json");
            var data = JsonConvert.DeserializeObject<dynamic>(Json);
            alerts = data.ToObject<Dictionary<string, string>>();
        }
        public static string GetAlert(string key)
        {
            if (alerts.ContainsKey(key)) return alerts[key];
            return "";
        }
    }
}
