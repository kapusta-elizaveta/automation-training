using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Framework.Pages
{
    public class EventsPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='filter-choose-city2']")]
        public IWebElement Hotel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/span[1]/span[1]/span[2]/ul[1]/li[1]/ul[1]/li[1]")]
        public IWebElement HotelName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='filter-section booking-form__time js-time-choose']")]
        public IWebElement Time { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='guest__control semantic-button js-hour-control inc']//*[@class='guest__control-icon svg-icon-plus']")]
        public IWebElement TimeHoursPlus { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id='myLinkToEvent']")]
        public IWebElement Book { get; set; }

        private IWebDriver driver;
        private ILog log = LogManager.GetLogger(typeof(EventsPage));

        public EventsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            log4net.Config.DOMConfigurator.Configure();
            log.Info("EventsPage created");
        }

        public SearchEventsResultPage ChooseEvents()
        {
            Hotel.Click();
            Thread.Sleep(1000);
            HotelName.Click();
            Time.Click();
            TimeHoursPlus.Click();
            Book.Click();
            log.Info("Event choosed");
            return new SearchEventsResultPage(driver);
        }
    }
}
