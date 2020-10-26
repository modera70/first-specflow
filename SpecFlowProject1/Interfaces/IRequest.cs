using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Interfaces
{
    public interface IRequest
    {
        public IRestRequest GetRequestSpecification();
    }
}
