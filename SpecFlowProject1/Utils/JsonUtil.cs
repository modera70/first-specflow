using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Gbm.Cash.AM.Accounts.Application.RegressionTest.Utils
{
    public static class JsonUtil
    {

        public static T DeserializeObjectFromFile<T>(string jsonFilePath)
        {
            T obj = JsonConvert.DeserializeObject<T>(File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), jsonFilePath)));
            return obj;
        }

        public static T DeserializeObject<T>(string json)
        {
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public static string SerializeObject(object obj)
        {
            string serializedObj = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return serializedObj; ;
        }
    }
}
