using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MettaChallenge
{
    class CheckoutPage
    {

        private Util util;

        #region

        By locatorTitle = By.XPath("//h1[contains(text(),'Checkout')]");
        By locatorSignInMain = By.XPath("//a[contains(text(),'Sign in')]");
        By locatorSignInSecond = By.XPath("//button[contains(text(),'Sign in')]");
        By locatorPhoneOption = By.XPath("//p[contains(text(),'Phone ordering')]");
        By locatorTermsAccept = By.XPath("//label[@class='cm-check-agreement']");
        By locatorConfirmCheckout = By.XPath("//button[@id='litecheckout_place_order']");
        By locatorConfirmOrder = By.XPath("//bdi[contains(text(),'Your order has been received')]");



        #endregion


        public CheckoutPage()
        {

            util = new Util();
        }


        public void ValidateSearchPáge()
        {

            util.WaitElementIsVisible(locatorTitle);
            Assert.IsTrue(util.IsDisplayed(locatorTitle));
            Assert.IsTrue(util.IsDisplayed(locatorSignInMain));
        }

        public void ClickSignIn()
        {

            util.Click(locatorSignInMain);
            
        }

        public void ClickSignInBox()
        {

            util.Click(locatorSignInSecond);

        }

        public void ClickPhoneOption()
        {

            util.WaitElementIsVisible(locatorPhoneOption);
            util.Click(locatorPhoneOption);

        }

        public void ClickTermsAccept()
        {

            util.Click(locatorTermsAccept);

        }

        public void ClickConfirmCheckout()
        {

            util.Click(locatorConfirmCheckout);

        }

        public void ValidateOrder()
        {

            util.WaitElementIsVisible(locatorConfirmOrder);
            Assert.IsTrue(util.IsDisplayed(locatorConfirmOrder));
        }
    }
}
