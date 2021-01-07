using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MettaChallenge
{
    class ProductPage
    {

        private Util util;

        #region

        By locatorAddToCart = By.XPath("//button[contains(text(),'Add to cart')]");
        By locatorShipping = By.XPath("//span[contains(text(),'FREE US shipping over $100!')]");
        By locatorQuantity = By.XPath("//label[contains(text(),'Quantity:')]");
        By locatorCartIcon = By.XPath("//span[contains(text(),'My cart')]");
        By locatorProductName = By.XPath("//h1[@class='ty-product-block-title']");
        By locatorPrice = By.XPath("//span[@id='sec_discounted_price_18']");
        By locatorViewCart = By.XPath("//a[contains(text(),'View cart')]");
        By locatorCloseFooter = By.XPath("//button[@id='bp_off_bottom_panel']");






        #endregion


        public ProductPage()
        {

            util = new Util();
        }


        public void ValidateProductPage()
        {

            util.WaitElementIsVisible(locatorAddToCart);
            Assert.IsTrue(util.IsDisplayed(locatorShipping));
            Assert.IsTrue(util.IsDisplayed(locatorQuantity));
            SetUp.GetInstance().TotalPriceProduct = util.GetText(locatorPrice);
            SetUp.GetInstance().NameProduct = util.GetText(locatorProductName);
           // util.Click(locatorCloseFooter);

        }

        public void ClickAddToCart()
        {

            util.Click(locatorAddToCart);
            Thread.Sleep(5000);
          


        }

        public void ClickCartIcon()
        {

           util.Click(locatorCartIcon);



        }

        public void ClickViewCart()
        {

           util.Click(locatorViewCart);



        }

    }
}
