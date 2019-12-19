using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Framework.Steps;
using Framework.Pages;
using Framework.Utils;

namespace Framework
{
    [TestClass]
    public class HomePageTest
    {
        public MainPage mainPage;
        private const string XPATH_SEARCH = "//div[@class='c0145']";
        private const string XPATH_ERROR_EMAIL = "//p[@class='inner-txt-homep']//span";
        private const string XPATH_FLAG = "//div[@class='choose-btn choose-btn-russ js-choose-dropdown-btn flag-evro-drop']";
        private const string XPATH_VALUE = "//div[contains(text(),'USD')]";
        private const string XPATH_LANGUAGE = "//div[contains(text(),'DE')]";
        public const string BASE_URL = "https://azimuthotels.com/";
        public const string ERROR = "Произошла ошибка";
        public const string CITY = "Москва";
        Step step;
        public IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            step = new Step();
            step.InitBrowser();
            mainPage = new MainPage(step.driver);
        }

        [TestCleanup]
        public void TeardownTest()
        {
           step.CloseBrowser();
        }

        [TestMethod]
        public void SearchTest()
        {    
            step.GoToPage(BASE_URL);
            step.Search(CITY);
            Assert.IsTrue(step.driver.FindElement(By.XPath(XPATH_SEARCH)).Displayed);
        }

        [TestMethod]
        public void ChangeFlagTest()
        {
            step.GoToPage(BASE_URL);
            mainPage.ChangeFlag();
            Assert.IsTrue(step.driver.FindElement(By.XPath(XPATH_FLAG)).Displayed);
        }

        [TestMethod]
        public void ChangeLanguageTest()
        {
            step.GoToPage(BASE_URL);
            mainPage.ChangeLanguage();
            Assert.IsTrue(step.driver.FindElement(By.XPath(XPATH_LANGUAGE)).Displayed);
        }

        [TestMethod]
        public void ChangeValueTest()
        {
            step.GoToPage(BASE_URL);
            mainPage.ChangeValue();
            Assert.IsTrue(step.driver.FindElement(By.XPath(XPATH_VALUE)).Displayed);
        }

        [TestMethod]
        public void ErrorSignUpNewsTest()
        {
            string emailText = RandomGenerator.GetRandomString(5);
            step.GoToPage(BASE_URL);
            mainPage.SignUpNews(emailText);
            Assert.AreEqual(ERROR, step.driver.FindElement(By.XPath(XPATH_ERROR_EMAIL)).Text);
        }
    }
}
