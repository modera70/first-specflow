using Gbm.Cash.AM.Accounts.Application.RegressionTest.Models;
using RestSharp;
using SpecFlowProject1.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace SpecFlowProject1.Requests
{
    public class TokenRq : IRequest
    {
        public string Url { get; set; }
        public string GrantType { get; set; }
        public string Scope { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public RequestSpecification RequestSpecification{get;set;}
        

        public IRestRequest GetRequestSpecification()
        {
            RestRequest restRequest;
            if (RequestSpecification != null) {

                restRequest = new RestRequest(RequestSpecification.Path, (Method)Enum.Parse(typeof(Method), RequestSpecification.Method, true));
                foreach (string key in RequestSpecification.Parameters.Keys)
                {
                    restRequest.AddParameter(key, RequestSpecification.Parameters[key]);
                }
                
            }
            else
            {
                restRequest = new RestRequest(Method.POST);
                //restRequest.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                restRequest.AddParameter("grant_type", GrantType);
                restRequest.AddParameter("scope", Scope);
                restRequest.AddParameter("client_id", ClientId);
                restRequest.AddParameter("client_secret", ClientSecret);
            }
            

            return restRequest;
        }
    }
}
