using System;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;


namespace SeleniumTest

    {
    public class FirstTestCase
    {
        [Test]

        public static void Main()
        {

            // Create a new instance of the Firefox driver
            IWebDriver driver = new FirefoxDriver();

            //Launch the Online Store Website
            driver.Navigate().GoToUrl("http://www.google.com");

            //Wait for 5 Sec
            System.Threading.Thread.Sleep(5000);

            // Close the driver
            driver.Quit();
        }
    }

}



