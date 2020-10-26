using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Gbm.Cash.AM.Accounts.Application.RegressionTest.Utils
{
    class ConfigManager
    {
        private IConfiguration configuration;
        public ConfigManager(string jsonConfigFile)
        {
            configuration = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(jsonConfigFile), optional: true, reloadOnChange: true)
                .Build();
        }

        public string GetDevBaseUrl()
        {
            return configuration["DevBaseUrl"];
        }

        public string GetStageBaseUrl()
        {
            return configuration["StageBaseUrl"];
        }
    }
}
