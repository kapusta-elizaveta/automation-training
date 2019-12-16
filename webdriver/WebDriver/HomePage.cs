using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriver
{
    public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "react-datepicker-wrapper")]
        public IWebElement ArrivalDate { get; set; }

        [FindsBy(How = How.Name, Using = "day-27")]
        public IWebElement TittleArrivalDate { get; set; }

        [FindsBy(How = How.ClassName, Using = "c0115")]
        public IWebElement Visitors { get; set; }

        [FindsBy(How = How.ClassName, Using = "c0137")]
        public IWebElement VisitorsPlus { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.select-search-box__search[placeholder='Выберите отель AZIMUT']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//li[2]//div[1]//ul[1]//li[1]")]
        public IWebElement TitleCity { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li.select-search-box__row[data-value='102168']")]
        public IWebElement ApartmentTitle { get; set; }

        [FindsBy(How = How.ClassName, Using = "c0138")]
        public IWebElement ApartmentPlus { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'c016')]//button[contains(@class,'')]")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Ваш E-mail']")]
        public IWebElement Card { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='footer__form-subscribe__btn-submit button']")]
        public IWebElement CityCard { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://azimuthotels.com/");
        }

        public void SignUpNews(string email)
        {
            Card.SendKeys(email);
            CityCard.Click();
        }

        public void Search(string city)
        {
            ArrivalDate.Click();
            TittleArrivalDate.Click();
            Visitors.Click();
            VisitorsPlus.Click();
            City.Click();
            City.SendKeys(city);
            ApartmentTitle.Click();
            SearchButton.Click();
        }
    }
}

