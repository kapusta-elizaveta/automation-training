
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
        public const string XPATHINPUTCITY = "input.select-search-box__search[placeholder='Выберите отель AZIMUT']";
        public const string XPATHINPUTVISITOR = "//*[@id='root']/div/div[3]/div/div";
        public const string XPATHARRIVALDATE = "//*[@id='root']/div/div[2]/div[1]/div[2]/div/input";

        public const string ARRIVALDATE = "29.11.2019";
        public const string CITY = "Москва";
        public const string VISITORS = "2";
        public const string APARTMENT = "AZIMUT Отель Смоленская  Москва  ";
        public IWebDriver Driver { get; set; }

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
        }

        [TestMethod]
        public void ChooseArrivalDateTest()
        {
            HomePage homePage = new HomePage(this.Driver);
            homePage.goToPage();
            homePage.ChooseArrivalDate();
            Assert.AreEqual(ARRIVALDATE, homePage.FindElementByLocator(By.XPath(XPATHARRIVALDATE)).GetAttribute("value"));
        }

        [TestMethod]
        public void ChooseVisitorsTest()
        {
            HomePage homePage = new HomePage(this.Driver);
            homePage.goToPage();
            homePage.ChooseVisitors();
            Assert.AreEqual(VISITORS, homePage.FindElementByLocator(By.XPath(XPATHINPUTVISITOR)).Text);
        }

        [TestMethod]
        public void ChooseCityTest()
        {
            HomePage homePage = new HomePage(this.Driver);
            homePage.goToPage();
            homePage.ChooseCity(CITY);
            Assert.AreEqual(CITY, homePage.FindElementByLocator(By.CssSelector(XPATHINPUTCITY)).GetAttribute("value"));
            homePage.ChooseApartmnet();
            Assert.AreEqual(APARTMENT, homePage.FindElementByLocator(By.CssSelector(XPATHINPUTCITY)).GetAttribute("value"));
        }


    }
}
