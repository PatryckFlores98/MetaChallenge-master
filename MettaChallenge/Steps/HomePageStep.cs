using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace MettaChallenge
{
    [Binding]
    class HomeStep : HomePage
    {

        [Given(@"I go to ""(.*)""")]
        public void GivenIGoTo(string site)
        {
            GoToSite(site);
        }

        [Then(@"the site will be displayed")]
        public void ThenTheSiteWillBeDisplayed()
        {
            ValidateHome();
        }


        [Given(@"I search for a product")]
        public void GivenISearchForAProduct()
        {
            SearchProduct();
        }


    }
}