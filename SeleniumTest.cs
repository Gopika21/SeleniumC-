using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class SeleniumTest
    {


        IWebDriver driver;
        [OneTimeSetUp]
        public void setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void verifyPage()
        {
            driver.Navigate().GoToUrl("https://www.browserstack.com/");
            Assert.IsTrue(driver.FindElement(By.Id("logo")).Displayed);


        }
        [Test]
        public void menuCountCheck()
        {
            driver.Navigate().GoToUrl("https://www.browserstack.com/");
            IReadOnlyCollection<IWebElement> menuItem = driver.FindElements(By.XPath("//ul[contains(@class,'horizontal-list product-menu')]/li"));
            Assert.AreEqual(menuItem.Count, 4);
        }

        [Test]
        public void verifyPricing()
        {
            driver.Navigate().GoToUrl("https://www.browserstack.com/pricing");
            IWebElement header = driver.FindElement(By.TagName("h1"));
            Assert.IsTrue(header.Text.Contains("Replace your device lab and VMs with any of these plans"));
        }
        [OneTimeTearDown]
        public void tearDown()
        {
            driver.Quit();
        }

    }
}
