using System;
using OpenQA.Selenium;

namespace SeleniumSitestests
{
    public class CheckOutPage
    {
        IWebDriver driver;

        public CheckOutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IList<IWebElement> elements => driver.FindElements(By.CssSelector("button.btn_inventory"));
        public IWebElement checkout => driver.FindElement(By.CssSelector(".shopping_cart_link"));
        public IWebElement username => driver.FindElement(By.Id("user-name"));
        public IWebElement password => driver.FindElement(By.Id("password"));
        public IWebElement login => driver.FindElement(By.Id("login-button"));
        public IWebElement checkOut => driver.FindElement(By.CssSelector("#checkout"));
        public IWebElement firstname => driver.FindElement(By.CssSelector("#first-name"));
        public IWebElement lastname => driver.FindElement(By.CssSelector("#last-name"));
        public IWebElement postcode => driver.FindElement(By.CssSelector("#postal-code"));
        public IWebElement continuebtn => driver.FindElement(By.CssSelector("#continue"));
        public IWebElement finish => driver.FindElement(By.Id("finish"));
        public IWebElement label => driver.FindElement(By.CssSelector(".complete-header"));


        public void CheckOutItems()
        {
            username.SendKeys("standard_user");
            password.SendKeys("secret_sauce");
            login.Click();
            foreach(IWebElement element in elements)
            {
                element.Click();
            }
            checkout.Click();
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500);");

            checkOut.Click();
            firstname.SendKeys("Simeon");
            lastname.SendKeys("Todorov");
            postcode.SendKeys("9000");
            continuebtn.Click();

            js.ExecuteScript("window.scrollBy(0,900);");
            finish.Click();
        } 
    }
}