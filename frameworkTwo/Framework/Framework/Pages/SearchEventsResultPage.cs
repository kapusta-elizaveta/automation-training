
using Framework.Pages;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    public class SearchEventsResultPage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='intro intro--inner second_page_of_hotels second_page_of_hotels_events']//li[3]")]
        public IWebElement Gallary { get; set; }

        [FindsBy(How = How.LinkText, Using = "Вернуться к бронированию")]
        public IWebElement Book { get; set; }

        private IWebDriver driver;
        private ILog log = LogManager.GetLogger(typeof(SearchEventsResultPage));

        public SearchEventsResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            log.Info("SearchEventsResultPage created");
        }

        public void GoToGallary()
        {
            Gallary.Click();
            log.Info("Gallary choosed");
        }

        public MainPage ReturnBook()
        {
            GoToGallary();
            Book.Click();
            log.Info("Return to booking");
            return new MainPage(driver);
        }
    }
}
