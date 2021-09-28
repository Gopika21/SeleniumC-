using NUnit.Framework;
using NUnit.Tests1.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class FirstTest:BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            //emailTextField.SendKeys("Gopika Prakash");
            //Thread.Sleep(5000);
            IWebElement monthDropDown = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropDown);
            element.SelectByIndex(1);
            Thread.Sleep(5000);
            element.SelectByText("Mar");
            Thread.Sleep(5000);
            element.SelectByValue("6");
            Thread.Sleep(5000);
        }

    }
}
