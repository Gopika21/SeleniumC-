using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1.PageObjects
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Name, Using = "search_query")]
        public IWebElement SearchTextBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#search-icon-legacy")]
        public IWebElement SearchButton { get; set; }

        public ResultPage NavigateToResultPage()
        {
            SearchTextBox.SendKeys("selenium c# by bakkappa n");
            SearchButton.Click();
            return new ResultPage(driver);
        }
    }
}
