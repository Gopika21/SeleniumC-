using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{

    [TestFixture]
    class Demo_AutoComplete
    {
        IWebDriver driver;
        [SetUp]
        public void setUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.co.in");
        }
        [Test]
        public void TestAutoComplete()
        {
            driver.FindElement(By.XPath(".//*[@name='q']")).SendKeys("selenium");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[2]/div[2]/div[2]/ul")));
            IWebElement ac = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[2]/div[2]/div[2]/ul"));
            IReadOnlyCollection<IWebElement> list1 = ac.FindElements(By.TagName("li"));
            foreach(IWebElement op in list1)
            {
                if(op.Text.Equals("selenium webdriver"))
                {
                    op.Click();
                    break;
                }
            }
        }


    }
}
