using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace NUnit.Tests1
{
    [TestFixture]
    public class FourthTest
    {
        
        ExtentReports extent = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\\Users\User\\source\repos\\NUnit.Tests1\\NUnit.Tests1\\ExtentReport\\Tutorial3.html");
            extent.AttachReporter(htmlReporter);
        }
        [OneTimeTearDown]
        public void EntentClose()
        {
            extent.Flush();

        }
        [Test]
        public void Test2()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("Test2").Info("Test Started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.facebook.com/";
                test.Log(Status.Info, "Chrome Browser Launched");
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTextField.SendKeys("Gopika Prakash");
                test.Log(Status.Info, "Email id entered");
                driver.Quit();
                test.Log(Status.Pass, "Test Passed");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, ex.ToString());
                Console.WriteLine(ex.StackTrace);
                throw;

            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }
    }
 }

