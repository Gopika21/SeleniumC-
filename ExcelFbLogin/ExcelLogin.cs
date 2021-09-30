using Microsoft.Office.Interop.Excel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class ExcelLogin
    {
        IWebDriver driver;
        String excel_path="";
        [SetUp]
        public void SetupMethod1()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            
            //Implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void excelTest()
        {
            Application MyApp = null;
            Workbook MyBook = null;
            Worksheet MySheet = null;


            MyApp = new Application();
            MyApp.Visible = true;

            MyBook = MyApp.Workbooks.Open("D:\\Selenium\\loginData.xlsx");
            MySheet = MyBook.Worksheets.Item[1];

            int row_count = MySheet.UsedRange.Rows.Count;

            for(int i=2;i<=row_count;i++)
            {
                string title = driver.Title;
                string email = MySheet.Cells[i, 1].value;
                driver.FindElement(By.XPath(".//*[@id='email']")).SendKeys(email);
                string password= MySheet.Cells[i, 2].value;
                driver.FindElement(By.XPath(".//*[@id='pass']")).SendKeys(password);
                driver.FindElement(By.XPath(".//*[@type='submit']")).Click();
               
            }
            MyBook.Close();
            MyApp.Quit();
        }
        [TearDown]
        public void tearDown1()
        {
            driver.Quit();
        }
    
    }
}
