using RestSharp;
using SpecFlowProject1.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace SpecFlowProject1.Requests
{
    public class TokenRq : Request
    {
        public string Url{ get; set; }
        public string GrantType { get; set; }
        public string Scope { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        

        public IRestRequest GetRestRequest()
        {
            RestRequest restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            restRequest.AddParameter("grant_type", GrantType);
            restRequest.AddParameter("scope", Scope);
            restRequest.AddParameter("client_id", ClientId);
            restRequest.AddParameter("client_secret", ClientSecret);

            return restRequest;
        }
    }
}
