using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    class ThirdTest
    {
        [Test]
        //[Author("Gopika","gopika@gmail.com")]
        //[Description("Facebook Test")]
        [TestCaseSource("DataDrivenTesting")] //name of the data method
        public void Test1(string urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
                //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                //emailTextField.SendKeys("Gopika Prakash");

                //Error Code for screenshot
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='eail']"));
                emailTextField.SendKeys("Gopika Prakash");
                driver.Quit();

            }
            catch (Exception ex)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\User\\source\\repos\\NUnit.Tests1\\NUnit.Tests1\\Screenshots\\Screenshot1", ScreenshotImageFormat.Jpeg;
                                  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id
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

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");
            return list;
        }
    }
}
