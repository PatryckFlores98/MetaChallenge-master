using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace MettaChallenge
{
    [Binding]
    class SearchPageStep : SearchPage
    {

        [Then(@"the search page will be displayed")]
        public void ThenTheSearchPageWillBeDisplayed()
        {
            ValidateSearchPáge();
        }

        [Given(@"I click on the product")]
        public void GivenIClickOnTheProduct()
        {
            ClickProduct();
        }



    }
}