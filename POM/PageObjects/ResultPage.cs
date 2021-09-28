using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit.Tests1.PageObjects
{
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.LinkText, Using = "Selenium C# Full Course by Bakkappa N")]
        public IWebElement ChanneName { get; set; }

        public void NavigateToChannelPage()
        {

            ChanneName.Click();
            Thread.Sleep(5000);
        }
    }
}
