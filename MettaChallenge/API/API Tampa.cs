using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net;
using OpenQA.Selenium.Remote;

namespace UnitTestProject2
{
   
    [TestClass]
    public class APITampa
    {
       

       

        [TestMethod]
        public void TestMethod1()
        {
            RestClient client = new RestClient("https://api.interzoid.com/");


            RestRequest request = new RestRequest("getweather?license=904d305e79bb5988484eb6d6745bd0ef&city=tampa&state=tx", Method.GET);

            IRestResponse response = client.Execute(request);

            int StatusCode = (int)response.StatusCode;

            string StatusDescription = response.StatusDescription;

              
            Assert.IsNotNull(response);

            Assert.AreEqual(404,StatusCode);

            Assert.AreEqual("Not Found", response.StatusDescription);



          
    
               


          
        }
    }
}
