using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laab4
{
    public class HomePage
    {


        private IWebDriver driver;
        IWebElement source;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        [FindsBy(How = How.ClassName, Using = "link-auth")]
        public IWebElement ButtonPersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-login-canal-cab")]
        public IWebElement TitlePersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-hbi-login-fb")]
        public IWebElement FaceBookPersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "react-datepicker-wrapper")]
        public IWebElement ArrivalDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='day-23']")]
        public IWebElement TittleArrivalDate { get; set; }

        [FindsBy(How = How.ClassName, Using = "react-datepicker-wrapper")]
        public IWebElement DepartureDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-label='day-23']")]
        public IWebElement TittleDepartureDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div/div[3]/div")]
        public IWebElement Visitors { get; set; }

        [FindsBy(How = How.ClassName, Using = "c0137")]
        public IWebElement VisitorsPlus { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.select-search-box__search[placeholder='Выберите отель AZIMUT']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.select-search-box__row[data-value='102168']")]
        public IWebElement ApartmentTitle { get; set; }

        [FindsBy(How = How.ClassName, Using = "c0138")]
        public IWebElement ApartmentPlus { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[class='c0127']")]
        public IWebElement SearchButton { get; set; }


        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://azimuthotels.com/");
        }

        public void EntryGmail()
        {
            this.ButtonPersonalAccount.Click();
            this.TitlePersonalAccount.Click();
            this.FaceBookPersonalAccount.Click();
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

        public void ChooseCity(string textToType)
        {
            this.City.Click();
            this.City.SendKeys(textToType);
        }

        public void ChooseApartmnet()
        {
            this.ApartmentTitle.Click();
        }

        public void SearchApartment()
        {
            this.SearchButton.Click();
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
    }
}
