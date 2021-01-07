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
    class SearchPage
    {

        private Util util;

        #region

        By locatorTitle = By.XPath("//span[contains(text(),'Search results')]");
        By locatorSearchFilter = By.XPath("//a[@id='sw_elm_sort_fields']");
        By locatorProduct = By.XPath("//div[@id='icons_18']");
       


        #endregion


        public SearchPage()
        {

            util = new Util();
        }


        public void ValidateSearchPáge()
        {

            util.WaitElementIsVisible(locatorTitle);
            Assert.IsTrue(util.IsDisplayed(locatorTitle));
            Assert.IsTrue(util.IsDisplayed(locatorSearchFilter));
        }

        public void ClickProduct()
        {

          //  util.ScrollToElement(locatorProduct, -100);
            util.Click(locatorProduct);
            
        }

    }
}
