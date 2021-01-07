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
            RestClient client = new RestClient("http://api.weatherbit.io/v2.0/current");


            RestRequest request = new RestRequest("?city=Tampa,TX&key=c61c893a97c04d87be540d1f69aeb5db", Method.GET);

            IRestResponse response = client.Execute(request);

            int StatusCode = (int)response.StatusCode;

            string StatusDescription = response.StatusDescription;

              
            Assert.IsNotNull(response);

            Assert.AreEqual(204,StatusCode);

            Assert.AreEqual("No Content", response.StatusDescription);




            





        }
    }
}
