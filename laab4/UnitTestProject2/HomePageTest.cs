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

        [TestMethod]
        public void SignInTest()
        {
            HomePage homePage = new HomePage(this.Driver);
            homePage.goToPage();
            homePage.EntryGmail();
            Assert.IsTrue(homePage.ErrorMessageExpected());

        }

        [TestMethod]
        public void SearchApartmentTest()
        {
            HomePage homePage = new HomePage(this.Driver);
            homePage.goToPage();
            homePage.ChooseArrivalDate();
            homePage.ChooseDepartureDate();
            homePage.ChooseVisitors();
            homePage.ChooseApartment();
            homePage.SearchApartment();
            Assert.IsTrue(homePage.ErrorMessageExpected());
        }


    }
}
