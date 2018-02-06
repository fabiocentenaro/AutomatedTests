using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTest
{
    public class GooglePage
    {
        private IWebDriver driver;

        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);

            this.driver.Url = "http://www.google.com";

            this.driver.Navigate();
        }


        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement Button { get; set; }

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement Text { get; set; }
    }
}
