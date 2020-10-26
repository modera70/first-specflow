using FluentAssertions;
using Gbm.Cash.AM.Accounts.Application.RegressionTest.Models;
using Gbm.Cash.AM.Accounts.Application.RegressionTest.Utils;
using RestSharp;
using SpecFlowProject1.Requests;
using SpecFlowProject1.Utils;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class TokenStepDefinitions
    {
        private TokenRq tokenRq;
        private RestClient restClient;
        private IRestResponse tokenRp;

        public TokenStepDefinitions(TokenRq tokenRq)
        {
            this.tokenRq = tokenRq;
        }

        [Given(@"I have the access token URL '(.*)'")]
        public void GivenIHaveTheAccessTokenURL(string URL)
        {
            restClient = new RestClient(URL);
        }
        
        [Given(@"the grant type '(.*)'")]
        public void GivenTheGrantType(string grantType)
        {
            tokenRq.GrantType = grantType;
        }
        
        [Given(@"the scope '(.*)'")]
        public void GivenTheScope(string scope)
        {
            tokenRq.Scope = scope;
        }
        
        [Given(@"the client id '(.*)'")]
        public void GivenTheClientId(string clientId)
        {
            tokenRq.ClientId = clientId;
        }
        
        [Given(@"the client secret '(.*)'")]
        public void GivenTheClientSecret(string clientSecret)
        {
            tokenRq.ClientSecret = clientSecret;
        }
        
        [When(@"I make a POST request")]
        public void WhenIMakeAPOSTRequest()
        {
            tokenRp = restClient.Execute(tokenRq.GetRequestSpecification());
        }

        [Given(@"I have the token request specification '(.*)'")]
        public void GivenIHaveTheTokenTRequestSpecification(string requestSpecificationFile)
        {
            tokenRq.RequestSpecification = JsonUtil.DeserializeObjectFromFile<RequestSpecification>(requestSpecificationFile);
        }

        [When(@"I make a the request")]
        public void WhenIMakeATheRequest()
        {
            tokenRp = RestUtil.Execute("https://auth.stg-gbmapi.com", tokenRq.GetRequestSpecification());
        }

        [Then(@"the result statsu code should be (.*)")]
        public void ThenTheResultStatsuCodeShouldBe(int statusCode)
        {
            tokenRp.StatusCode.Should().Be(statusCode);
        }
    }
}
