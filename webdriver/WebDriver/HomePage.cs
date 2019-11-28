using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriver
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

        [FindsBy(How = How.Name, Using = "day-21")]
        public IWebElement TittleArrivalDate { get; set; }



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
    }
}
}
