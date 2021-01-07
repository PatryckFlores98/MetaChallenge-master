using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace MettaChallenge
{
    [Binding]
    class CartPageStep : CartPage
    {

        [Then(@"the cart page will be displayed")]
        public void ThenTheCartPageWillBeDisplayed()
        {
            ValidateCartPage();
        }

        [Given(@"I click on Proceed to Checkout button")]
        public void GivenIClickOnProceedToCheckoutButton()
        {
            ClickProceedToCheckout();
        }



    }
}