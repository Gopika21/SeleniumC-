using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1.BaseClass
{
    [TestFixture]
     public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.youtube.com/";
            //driver.Url = "https://en-gb.facebook.com/campaign/landing.php?campaign_id=1653993517&extra_1=s%7Cc%7C318461158209%7Ce%7Cfacebook%20signup%7C&placement&creative=318461158209&keyword=facebook%20signup&partner_id=googlesem&extra_2=campaignid%3D1653993517%26adgroupid%3D63066387563%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D%26target%3D%26targetid%3Dkwd-321689134300%26loc_physical_ms%3D9040214%26loc_interest_ms%3D%26feeditemid%3D%26param1%3D%26param2%3D&gclid=CjwKCAjwhaaKBhBcEiwA8acsHCOLmGMH6QKUeeNZp-fRO7MUDs7GOH9RMZzMhuWCjpYZnPZ3nOkzUBoCbx0QAvD_BwE";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20); //implicit wait time
            
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }

    }
}
