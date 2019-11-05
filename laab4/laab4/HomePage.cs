using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "link-auth")]
        public IWebElement ButtonPersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-login-canal-cab")]
        public IWebElement TitlePersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-hbi-login-fb")]
        public IWebElement FaceBookPersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "link-auth")]
        public IWebElement ChooseHotels { get; set; }

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

        public void ChooseApartment()
        {
            this.Apartment.Click();
            this.Apartment.Click();
        }

        public void SearchApartment()
        {
            this.SearchButton.Click();
        }
    }
}
