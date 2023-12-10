using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace SeleniumSiteTests
{
    public class LoginPage
    {
        private IWebDriver driver;

        // Constructor
        public LoginPage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(driver, this); // Initialize PageElements
        }

        public IWebElement username => driver.FindElement(By.Id("user-name"));
        public IWebElement password => driver.FindElement(By.Id("password"));
        public IWebElement login => driver.FindElement(By.Id("login-button"));
        public IWebElement errormsg => driver.FindElement(By.CssSelector("h3[data-test='error']"));


        // Login method
        public void PageLogin(string userName, string passWord)
        {
            // Perform login actions
            username.SendKeys(userName);
            password.SendKeys(passWord);
            login.Click();

            // Return an instance of EAPageObject (make sure EAPageObject is defined)
             
        }
    }
}
