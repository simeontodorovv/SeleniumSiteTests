using System;

namespace SeleniumSitestests
{
    public class MainPageTests : SetUp
    {
        [Test]
        public void ckeckOut()
        {
            MainPage page = new MainPage(driver);
            page.AddElementsToCart();            
        }
    }
}