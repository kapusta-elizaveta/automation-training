using Framework.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Framework.Pages;

namespace Framework
{
    [TestClass]
    public class EventsTest
    {
        private const string HOTEL_NAME = "AZIMUT Отель Олимпик Москва ★★★★";
        private const string BASE_URL = "https://azimuthotels.com/events/";
        private const string XPATH_HOTEL_NAME = "//h1[@class='intro__title h-large']";
        private const string XPATH_MENU_GALLARY = "//a[@class='intro__menu-link active']";
        private Step step;
        private EventsPage eventsPage;
        private SearchEventsResultPage searchEventsResultPage;

        [TestInitialize]
        public void SetupTest()
        {
            step = new Step();
            step.InitBrowser();
            eventsPage = new EventsPage(step.driver);
            searchEventsResultPage = new SearchEventsResultPage(step.driver);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            step.CloseBrowser();
        }

        [TestMethod]
        public void ChooseEventsTest()
        {
            step.GoToPage(BASE_URL);
            eventsPage.ChooseEvents();
            Assert.AreEqual(HOTEL_NAME, step.driver.FindElement(By.XPath(XPATH_HOTEL_NAME)).Text);
        }

        [TestMethod]
        public void ChooseGallaryTest()
        {
            step.GoToPage(BASE_URL);
            step.GoToGallary();
            Assert.IsTrue(step.driver.FindElement(By.XPath(XPATH_MENU_GALLARY)).Displayed);
        }

        [TestMethod]
        public void ReturnEventsTest()
        {
            step.GoToPage(BASE_URL);
            step.GoToGallary();
            Assert.IsTrue(searchEventsResultPage.Book.Displayed);
        }
    }
}
