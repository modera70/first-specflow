using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Gbm.Cash.AM.Accounts.Application.RegressionTest.Models
{
    public class RequestSpecification
    {
        public string Method { get; set; }
        public string Path { get; set; }
        public Dictionary<string, object> Headers { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
        public Dictionary<string, object> UrlSegments { get; set; }
        public object Body { get; set; }

    }
}
