using System;
using OpenQA.Selenium;
using SeleniumSiteTests;

namespace SeleniumSitestests
{
    public class MainPage 
    {
        IWebDriver driver;


        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IList<IWebElement> elements => driver.FindElements(By.CssSelector("button.btn_inventory"));
        public IWebElement checkout => driver.FindElement(By.CssSelector(".shopping_cart_link"));
        public IWebElement username => driver.FindElement(By.Id("user-name"));
        public IWebElement password => driver.FindElement(By.Id("password"));
        public IWebElement login => driver.FindElement(By.Id("login-button"));

        public void AddElementsToCart()
        {
            username.SendKeys("standard_user");
            password.SendKeys("secret_sauce");
            login.Click();
            foreach(IWebElement element in elements)
            {
                element.Click();
            }
            checkout.Click();
        }   
    }
}