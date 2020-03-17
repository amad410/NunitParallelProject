using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_ParallelProject
{
    [TestFixture]
    [Parallelizable]
    public class TestClass2
    {
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://ps.uci.edu/~franklin/doc/file_upload.html";
        }

        [Test]
        public void TestMethod2()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [Test]
        public void TestMethod3()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TearDown]
        public void Cleanup()
        {
            DriverFactory.getInstance().removeDriver();

        }
    }
}
