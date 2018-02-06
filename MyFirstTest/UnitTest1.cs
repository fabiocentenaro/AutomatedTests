using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyFirstTest
{
    [TestClass]
    public class UnitTest1
    {

        ChromeDriver _driver;

        [TestInitialize]
        public void setup()
        {
            _driver = new ChromeDriver();
        }


        [TestMethod]
        public void TestMethod1()
        {


            _driver.Url = "http://www.google.com";

            _driver.Navigate();


            var button = _driver.FindElement(By.Name("btnK"));


            Assert.IsNotNull(button);
            Assert.AreEqual(button.GetAttribute("value"), "Pesquisa Google");

            var text = _driver.FindElement(By.Name("q"));

            text.SendKeys("Eu amo a Toelha");

            button.Click();



            //var googlePage = new GooglePage(_driver);
            //googlePage.Text.SendKeys("my test");

        }

        [TestCleanup]
        public void cleanup()
        {
            //_driver.Quit();
        }
    }
}
