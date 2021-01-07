using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace MettaChallenge
{
    [Binding]
    class CheckoutPageStep : CheckoutPage
    {

        [Then(@"the checkout page will be displayed")]
        public void ThenTheCheckoutPageWillBeDisplayed()
        {
            ValidateSearchPáge();
        }

        [Given(@"I click on Sign In button")]
        public void GivenIClickOnSignInButton()
        {
            ClickSignIn();
        }

        [Given(@"I click on Sign In button in the login box")]
        public void GivenIClickOnSignInButtonInTheLoginBox()
        {
            ClickSignInBox();
        }


        [Given(@"I click on Phone Option")]
        public void GivenIClickOnPhoneOption()
        {
            ClickPhoneOption();
        }

        [Given(@"I click on the terms box")]
        public void GivenIClickOnTheTermsBox()
        {
            ClickTermsAccept();
        }

        [When(@"I click on Checkout confirm option")]
        public void WhenIClickOnCheckoutConfirmOption()
        {
            ClickConfirmCheckout();
        }

        [Then(@"the order will be confirmed")]
        public void ThenTheOrderWillBeConfirmed()
        {
            ValidateOrder();
        }

    }
}