using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver;

namespace WebDriverTest
{
    [TestClass]
    public class HomePageTest
    {
        private HomePage homePage;
        private const int LENGTH_FALLS_EMAIL = 5;
        private const string ERROR = "Произошла ошибка";
        private const string XPATH_SEARCH_RESULT = "//div[@class='c0145']";
        private const string XPATH_ERROR_MESSAGE = "//p[@class='inner-txt-homep']//span";
        public IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            homePage = new HomePage(Driver);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void SearchTest()
        {
            homePage.goToPage();
            homePage.Search(CITY);
            Assert.IsTrue(Driver.FindElement(By.XPath(XPATH_SEARCH_RESULT)).Displayed);
        }

        [TestMethod]
        public void ErrorSignUpNewsTest()
        {
            string emailText = RandomGenerator.GetRandomString(LENGTH_FALLS_EMAIL);
            homePage.SignUpNews(emailText);
            Assert.AreEqual(ERROR, Driver.FindElement(By.XPath(XPATH_ERROR_MESSAGE)).Text);
        }
    }
}
