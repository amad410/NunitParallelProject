using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit_ParallelProject
{
    public class DriverFactory
    {
        private DriverFactory()
        {
            //Do-nothing..Do not allow to initialize this class from outside
        }
        private static DriverFactory instance = new DriverFactory();

        public static DriverFactory getInstance()
        {
            return instance;
        }

        //ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>() // thread local driver object for webdriver
        //{
        //    protected IWebDriver initialValue()
        //    {
        //        return new ChromeDriver(); // can be replaced with other browser drivers
        //    }
        //};

        public static ThreadLocal<IWebDriver> webDriver = new ThreadLocal<IWebDriver>(() =>
        {
            return new ChromeDriver();
        });

        public IWebDriver getDriver() // call this method to get the driver object and launch the browser
        {
            return webDriver.Value;
        }

        public void removeDriver() // Quits the driver and closes the browser
        {
            webDriver.Value.Quit();
        }

    }
}
