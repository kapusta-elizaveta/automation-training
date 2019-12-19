using OpenQA.Selenium;
using Framework.Pages;
using System.Threading;
using Framework.Utils;
using log4net;

namespace Framework.Steps
{
    public class Step
    {
        public IWebDriver driver;
        private const string EMAIL_PREFIX = "@mail.ru";
        private ILog log = LogManager.GetLogger(typeof(Step));

        public Step()
        {
            log.Info("Step created");
        }
        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string GenerateRandomEmailCharLength(int howManyChars)
        {
            string repositoryEmailPrefix = EMAIL_PREFIX;
            return string.Concat(RandomGenerator.GetRandomString(howManyChars), repositoryEmailPrefix);
        } 

        public void Close()
        {
            if (driver.FindElement(By.ClassName("fancybox-outer")).Displayed)
             {
                 driver.FindElement(By.XPath("//a[@title='Close']")).Click();
             }
        }

        public void Search(string city)
        {
            MainPage mainPage = new MainPage(driver);
            Thread.Sleep(100);
            mainPage.Visitors.Click();
            mainPage.VisitorsPlus.Click();
            mainPage.City.Click();
            mainPage.City.SendKeys(city);
            mainPage.ApartmentTitle.Click();
            mainPage.SearchButton.Click();
            log.Info("Search result shown");
        }

        public void GoToGallary()
        {
            EventsPage eventsPage = new EventsPage(driver);
            SearchEventsResultPage searchEventsResultPage = 
                new SearchEventsResultPage(driver);
            eventsPage.ChooseEvents();
            searchEventsResultPage.GoToGallary();
            log.Info("Go to Gallary");
        }
    }
} 
