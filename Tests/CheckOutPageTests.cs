using System;
using OpenQA.Selenium;

namespace SeleniumSitestests
{
    public class CheckOutPageTests : SetUp
    {
        [Test]
        public void TestCheckOut()
        {
            CheckOutPage page = new CheckOutPage(driver);
            page.CheckOutItems();
            Assert.That(page.label.Text, Is.EqualTo("Thank you for your order!"));
        }
    }
}