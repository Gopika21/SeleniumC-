// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace NUnit.Tests1
{
    [TestFixture]
    public class OrderSkip
    {
        [Test,Order(2),Category("OrderAttribute")]
        public void TestMethod1()
        {

            Assert.Ignore("Defect"); // to skip the test
                IWebDriver driver = new ChromeDriver();
                driver.Url = "https://facebook.com/";
                IWebElement emailId = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailId.SendKeys("Gopika");
            Thread.Sleep(5000);
                driver.Quit();
           
        }
        [Test, Category("OrderAttribute")]
        public void TestMethod2()
        {


            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://facebook.com/";
            IWebElement emailId = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailId.SendKeys("selenium");
            Thread.Sleep(5000);
            driver.Quit();

        }
        [Test, Category("OrderAttribute")]
        public void TestMethod3()
        {
            // IWebDriver driver = new InternetExplorerDriver();
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://facebook.com/";
            IWebElement emailId = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailId.SendKeys("selenium");
            driver.Quit();

        }
    }
}
