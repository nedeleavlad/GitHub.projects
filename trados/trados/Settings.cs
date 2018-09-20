using Microsoft.Extensions.Configuration;
using Ranorex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trados
{
    public class Settings
    {
        public Settings()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("configs.json")
                .Build();

            Timeout = Duration.FromMilliseconds(int.Parse(config["timeout"]));
            Path = config["path"];
        }

        public Duration Timeout { get; }
        public string Path { get; }
    }
}
