using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit_ParallelProject;
using OpenQA.Selenium.Support.UI;

namespace NUnit_ParallelProject
{
    [TestFixture]
    //[Parallelizable]
    public class TestClass1
    {
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.csm-testcenter.org/test?do=show&subdo=common&test=file_upload";
        }

        [Test]
        public void TestMethod0()
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
        public void TestMethod1()
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
        [Test]
        public void TestMethod4()
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
        public void TestMethod5()
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
        public void TestMethod6()
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
        public void TestMethod7()
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
        public void TestMethod8()
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
        public void TestMethod9()
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
        public void TestMethod10()
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
        public void TestMethod11()
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
        public void TestMethod12()
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
        public void TestMethod13()
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
        public void TestMethod14()
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
        public void TestMethod15()
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
        public void TestMethod16()
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
        public void TestMethod17()
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
        public void TestMethod18()
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
        public void TestMethod19()
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
        public void TestMethod20()
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
