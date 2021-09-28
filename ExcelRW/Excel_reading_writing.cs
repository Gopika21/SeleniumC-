using Microsoft.Office.Interop.Excel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests1
{
    [TestFixture]
    public class Excel_reading_writing
    {
        Application app_excel = null;
        Workbook book_excel = null;
        Worksheet sheet_excel = null;

        [Test]
        public void ExcelTestMethod()
        {
            app_excel = new Application();
            book_excel = app_excel.Workbooks.Open("D:\\Selenium\\testbook.xlsx");
            sheet_excel = book_excel.Worksheets.Item[1];
            app_excel.Visible = true;

            int row_count = sheet_excel.UsedRange.Rows.Count;
            string name;
            double mark1 = 0, mark2 = 0, mark3 = 0;
            for(int row=2;row<=row_count;row++)
            {
                name = sheet_excel.Cells[row, 2].value;
                mark1 = sheet_excel.Cells[row, 3].value;
                mark2 = sheet_excel.Cells[row, 4].value;
                mark3 = sheet_excel.Cells[row, 5].value;
                sheet_excel.Cells[row, 6].value = mark1 + mark2 + mark3;

            }
            book_excel.Save();
        }
        [TearDown]
        public void teardownmethod()
        {
            book_excel.Close();
            app_excel.Quit();
        }

    }
}
