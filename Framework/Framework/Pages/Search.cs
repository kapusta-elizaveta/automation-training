using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    public class Search
    {
        private const string BASE_URL = "http://www.github.com/";

        [FindsBy(How = How.CssSelector, Using = "input.select-search-box__search[placeholder='Выберите отель AZIMUT']")]
        public IWebElement Hotels { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.select-search-box__search.select-search-box__options.select-search-box__row[data-value='86207']")]
        public IWebElement TitleHotels { get; set; }

        [FindsBy(How = How.ClassName, Using = "react-datepicker-wrapper")]
        public IWebElement ArrivalDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='day-20']")]
        public IWebElement TittleArrivalDate { get; set; }

        [FindsBy(How = How.ClassName, Using = "react-datepicker-wrapper")]
        public IWebElement DepartureDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='day-23']")]
        public IWebElement TittleDepartureDate { get; set; }

        [FindsBy(How = How.ClassName, Using = "c0115")]
        public IWebElement Visitors { get; set; }

        [FindsBy(How = How.ClassName, Using = "c0138")]
        public IWebElement VisitorsPlus { get; set; }

        [FindsBy(How = How.ClassName, Using = "c0119")]
        public IWebElement Apartment { get; set; }

        [FindsBy(How = How.ClassName, Using = "c0138")]
        public IWebElement ApartmentPlus { get; set; }

        [FindsBy(How = How.ClassName, Using = "c016")]
        public IWebElement SearchButton { get; set; }


        private IWebDriver driver;
        IWebElement source;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        

        public void SelectCity(string textToType)
        {
            this.Hotels.Clear();
            this.Hotels.SendKeys(textToType);
        }

        public void ChooseHotel()
        {
            this.TitleHotels.Click();
        }
        public void ChooseArrivalDate()
        {
            this.ArrivalDate.Click();
            this.TittleArrivalDate.Click();
         }

        public void ChooseDepartureDate()
        {
            this.DepartureDate.Click();
            this.TittleDepartureDate.Click();

        }

        public void ChooseVisitors()
        {
            this.Visitors.Click();
            this.VisitorsPlus.Click();
         
        }

        public void ChooseApartment()
        {
            this.Apartment.Click();
            this.Apartment.Click();
        }

        public void SearchApartment()
        {
            this.SearchButton.Click();
        }

        public bool WaitForElementPresent(By locator, int seconds)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(
                   ExpectedConditions.ElementExists(locator));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IWebElement FindElementByLocator(By locator)
        {
            try
            {
                source = driver.FindElement(locator);
                return source;
            }
            catch
            {
                return null;
            }
        }
        public object FindElementByLocator(string xPATHHOTELS)
        {
            throw new NotImplementedException();
        }
    }
}
