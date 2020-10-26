using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Utils
{
    class RestUtil
    {
        public static IRestResponse Execute(string baseURL, IRestRequest restRequest)
        {
            RestClient restClient = new RestClient(baseURL);
            return restClient.Execute(restRequest);
        }
    }
}
