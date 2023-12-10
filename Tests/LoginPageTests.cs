using System;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V118.Page;
using SeleniumSiteTests;

namespace SeleniumSitestests
{
    public class LoginPageTests : SetUp
    {   
        
        [Test]
        [TestCaseSource("TestCases")]
        public void InvalidLoginTest(string username, string password, string error)
        {
            LoginPage page = new LoginPage(driver);
            page.PageLogin(username, password);
            Assert.That(page.errormsg.Text, Is.EqualTo(error));
        }

        [Test]
        [TestCase("standard_user", "secret_sauce")]
        public void ValidLoginTest(string username, string password)
        {
            LoginPage page = new LoginPage(driver);
            page.PageLogin(username, password);
        }

        public static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData("standart_user", "secret_sauce", "Epic sadface: Username and password do not match any user in this service");
            yield return new TestCaseData("locked_out_user", "secret_sauce", "Epic sadface: Sorry, this user has been locked out.");
            yield return new TestCaseData("", "secret_sauce", "Epic sadface: Username is required");
            yield return new TestCaseData("standart_user", "", "Epic sadface: Password is required");
        }
    }
}