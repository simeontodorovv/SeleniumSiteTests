using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSiteTests;

namespace SeleniumSitestests
{
    public class SetUp
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}