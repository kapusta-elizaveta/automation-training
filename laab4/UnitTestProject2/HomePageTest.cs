using System;
using System.IO;
using System.Reflection;
using laab4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace lab4Test
{
    [TestClass]
    public class HomePageTest
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        public const string HOTELS = "Москва";
        public const string XPATHHOTELS = "input.select-search-box__search[placeholder='Выберите отель AZIMUT']";
        IWebElement sourse;

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
           
        }

        [TestCleanup]
        public void TeardownTest()
        {
           this.Driver.Quit();
        }

       /* [TestMethod]
        public void SignInTest()
        {
            HomePage homePage = new HomePage(this.Driver);
            homePage.goToPage();
            homePage.EntryGmail();
            
        }*/

        [TestMethod]
        public void SearchApartmentTest()
        {
            HomePage homePage = new HomePage(this.Driver);
            homePage.goToPage();
            Assert.IsTrue(homePage.WaitForElementPresent(By.CssSelector(XPATHHOTELS), 30));
            homePage.SelectCity(HOTELS);
            Assert.AreEqual(HOTELS, homePage.FindElementByLocator(By.CssSelector(XPATHHOTELS)).GetAttribute("value"));
            homePage.ChooseHotel();
            // Assert.IsTrue(homePage.FindElementByLocator(By.CssSelector(XPATHHOTELS)).Text.Contains(HOTELS));
            /* homePage.ChooseArrivalDate();
             homePage.ChooseDepartureDate();
             homePage.ChooseVisitors();
             homePage.ChooseApartment();
             homePage.SearchApartment();*/
        }


    }
}
