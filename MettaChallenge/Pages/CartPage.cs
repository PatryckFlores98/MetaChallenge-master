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
    class CartPage
    {

        private Util util;

        #region

        By locatorTitle = By.XPath("//h1[contains(text(),'Cart contents')]");
        By locatorProduct = By.XPath("//a[@class='ty-cart-content__product-title']");
        By locatorProceedToCheckout = By.XPath("//a[contains(text(),'Proceed to checkout')][1]");
        By locatorPrice = By.XPath("//span[@id='sec_product_subtotal_2944839123']");
        string product;

        #endregion


        public CartPage()
        {

            util = new Util();
        }


        public void ValidateCartPage()
        {

            util.WaitElementIsVisible(locatorTitle);
            Assert.IsTrue(util.IsDisplayed(locatorTitle));
            Assert.IsTrue(util.IsDisplayed(locatorProceedToCheckout));
            Assert.IsTrue(util.ElementEqualsText(locatorProduct, SetUp.GetInstance().NameProduct));
            Assert.IsTrue(util.ElementEqualsText(locatorPrice, SetUp.GetInstance().TotalPriceProduct));
        }

        public void ClickProceedToCheckout()
        {

            util.Click(locatorProceedToCheckout);
            
        }


    }
}
