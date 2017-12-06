using System;
using TechTalk.SpecFlow;

namespace APITesting
{
    using RestSharp;

    [Binding]
    public class CommonSteps : BaseSteps
    {
        [When(@"I get the response back from API")]
        public void WhenIGetTheResponseBackFromApi()
        {
            this.Response = this.Client.Execute<dynamic>(ScenarioContext.Current.Get<IRestRequest>(RequestKey));
            ScenarioContext.Current.Add(ResponseKey, this.Response);
        }
    }
}
