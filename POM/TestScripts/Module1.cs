using NUnit.Framework;
using NUnit.Tests1.BaseClass;
using NUnit.Tests1.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit.Tests1.TestScripts
{
    [TestFixture]
    public class Module1:BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            var searchPage = new SearchPage(driver);
            var resultPage = searchPage.NavigateToResultPage();
            resultPage.NavigateToChannelPage();
            Thread.Sleep(5000);


        }
    }
}
