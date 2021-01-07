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
    class HomePage
    {

        private Util util;

        #region

        By locatorTitle = By.XPath("//img[@id='det_img_1378747131']");
        By locatorSearchField = By.XPath("//input[@id='search_input']");
        By locatorImageHome = By.XPath("//input[@id='det_img_93203576']");
        By locatorBlog = By.XPath("//a[@class='ty-text-links__a']");
        By locatorSearchIcon = By.XPath("//i[@class='ty-icon-search']");
        By locatorCloseFooter = By.XPath("//button[@id='bp_off_bottom_panel']");



        #endregion


        public HomePage()
        {

            util = new Util();
        }

        public void GoToSite(string site)
        {

            util.GoToUrl(site);

        }

        public void ValidateHome()
        {

            util.WaitElementIsVisible(locatorTitle);
            Assert.IsTrue(util.ElementContainsText(locatorBlog, "Our blog"));
            util.Click(locatorCloseFooter);
        }

        public void SearchProduct()
        {

            util.SendKeys(locatorSearchField, "test");
            util.Click(locatorSearchIcon);
            
        }

    }
}
