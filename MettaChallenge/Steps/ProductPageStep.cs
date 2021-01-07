using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace MettaChallenge
{
    [Binding]
    class ProductPageStep : ProductPage
    {
        [Then(@"the product page will be displayed")]
        public void ThenTheProductPageWillBeDisplayed()
        {
            ValidateProductPage();
        }


        [Given(@"I click on Add To Cart button")]
        public void GivenIClickOnAddToCartButton()
        {
            ClickAddToCart();
        }

        [Given(@"I click on Cart icon")]
        public void GivenIClickOnCartIcon()
        {
            ClickCartIcon();
        }

        [When(@"I click on View Cart button")]
        public void WhenIClickOnViewCartButton()
        {
            ClickViewCart();
        }


    }
}