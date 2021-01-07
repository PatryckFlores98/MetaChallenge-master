using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Collections;

using static System.Net.Mime.MediaTypeNames;

namespace MettaChallenge
{
    public class SetUp
    {
        private static IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        private static SetUp setUp;
        private string url;
        private string nameProduct;
        private string totalPriceProduct;
   

        public string TotalPriceProduct
        {
            get
            {
                return totalPriceProduct;
            }

            set
            {
                totalPriceProduct = value;
            }
        }

        public string NameProduct
        {
            get
            {
                return nameProduct;
            }

            set
            {
                nameProduct = value;
            }
        }

       
        
        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }


        public SetUp()
        {


        }

        public static SetUp GetInstance()
        {
            if (setUp == null)
            {
                setUp = new SetUp();
            }
            return setUp;
        }




        public void GoToURL(string url)
        {
            try
            {
                Driver.Navigate().GoToUrl(url);
            }
            catch (Exception) { }
        }

    }

}
