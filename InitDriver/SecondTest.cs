using NUnit.Framework;
using NUnit.Tests1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class SecondTest

    {
        IWebDriver driver;

    
        [Test,Category("UAT Testing")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Gopika Prakash");
            Thread.Sleep(5000);
            Driver.Quit();

        }
        


    }
}
