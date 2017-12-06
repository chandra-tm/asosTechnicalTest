using System;
using TechTalk.SpecFlow;

namespace APITesting
{
    using RestSharp;

    [Binding]
    public class BaseSteps
    {
        protected DynamicRestClient Client;

        protected RestRequest Request;
        protected IRestResponse<dynamic> Response;

        protected string Store = "1";

        protected string Lang = "en";

        protected string Currency = "GBP";

        protected string OffSet = "0";

        protected const string RequestKey = "Request";
        protected const string ResponseKey = "Response";

        public BaseSteps()
        {
            //var url = String.Format("{0}/product/search/{1}/", "http://asos-pp-eun-pdt-search-api.cloudapp.net", "V1");
            var url = String.Format("{0}/product/search/{1}/", "http://searchapi.asos.com/", "V2");
            this.Client = new DynamicRestClient(new Uri(url));
        }
        
    }
}
