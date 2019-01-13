using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace CanidBot
{
    class config
    {
        private const string configFolder = "Resources";
        private const string configFile = "config.json";
    
        static config()
        {
            if (!Directory.Exists(configFolder))
                Directory.CreateDirectory(configFolder);
            //if(File.Exists(""))
        }
    }
}

public struct BotConfiguration
{
    public string token;
    public string cmdPrefix;
}
