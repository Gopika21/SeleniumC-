using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class Parallelcs
    {
        public IWebDriver driver;
        [SetUp]
        public void setUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

        }
        [Parallelizable]
        [Test]
        public void testAutomate1()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Gopika Prakash");
            Thread.Sleep(5000);

        }
        [Parallelizable]
        [Test]
        public void testAutomate2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Advik");
            Thread.Sleep(5000);

        }
        [Parallelizable]
        [Test]
        public void testAutomate3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Kiran");
            Thread.Sleep(5000);

        }
        [TearDown]
        public void tearDown()
        {
            driver.Quit();
        }

    }
}
