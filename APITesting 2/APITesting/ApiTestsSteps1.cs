namespace APITesting
{
    using System;
    using System.Net;

    using NUnit.Framework;

    using RestSharp;
    using RestSharp.Extensions.MonoHttp;
    using TechTalk.SpecFlow;

    [Binding]
    public class ApiTestsSteps1 : BaseSteps
    {

        private const string SearchTerm = "red";
        private const string Limit = "10";
        IRestResponse actualResponse = new RestResponse();
        /// <summary>
        /// Make a request to 'GET /product/search/V1'
        /// Accept: application/json
        /// Parameters - ?store=1,lang=en,currency=GBP,q=red,offset=0,limit=10
        /// </summary>

        [Given(@"I call Search API without parameter")]
        public void GivenICallSearchApiWithoutParameter()
        {
            this.Request = new RestRequest(Method.GET);
            ////Add the Accept Type and Request Parameters here
            ScenarioContext.Current.Add(RequestKey, this.Request);
            actualResponse = Client.Execute(Request);

        }

        [Then(@"API returns (.*)")]
        public void ThenAPIReturns(string expectedStatusCode)
        {
            HttpStatusCode statusCode;
            uint stCode;

            //int.TryParse(expectedStatusCode, out testExpectedStatusCode);
            //CommonSteps cstepsObj = new CommonSteps();


            if (Enum.TryParse(actualResponse.StatusCode.ToString(), out statusCode))
            {
                stCode = (uint)statusCode;

                Console.Write(stCode);
                Console.WriteLine(expectedStatusCode);

                Assert.AreEqual(expectedStatusCode, stCode.ToString());

            }

        }
    }
}