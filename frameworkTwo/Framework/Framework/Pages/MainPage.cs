using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using log4net;

namespace Framework.Pages
{
    public class MainPage
    {
        private IWebDriver driver;
        public static readonly ILog log = LogManager.GetLogger(typeof(MainPage));

        [FindsBy(How = How.ClassName, Using = "link-auth")]
        public IWebElement ButtonPersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-login-canal-cab")]
        public IWebElement TitlePersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-hbi-login-fb")]
        public IWebElement FaceBookPersonalAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='c0162 react-datepicker-ignore-onclickoutside']')]/div[contains(@class,'main-slider-list')]/div[@id='root']/div[contains(@class,'')]/div[2]/div[1]")]
        public IWebElement ArrivalDate { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/section[1]/section[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[3]/div[1]/button[1]")]
        public IWebElement ForwardButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/section[1]/section[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[3]/div[1]/div[2]/div[2]/div[5]/div[3]")]
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

        [FindsBy(How = How.XPath, Using = "//div[@class='choose-btn choose-btn-russ js-choose-dropdown-btn flag-russ-drop']")]
        public IWebElement Flag { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'inner-europe-icon')]")]
        public IWebElement FlagName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='header-lang choose-dropdown-block lang-russ']")]
        public IWebElement Language { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Deutsch')]")]
        public IWebElement LanguageName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'RUB')]")]
        public IWebElement Value { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[3]//li[1]//a[1]")]
        public IWebElement ValueUSD { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Ваш E-mail']")]
        public IWebElement Card { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='footer__form-subscribe__btn-submit button']")]
        public IWebElement CityCard { get; set; }

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            log4net.Config.DOMConfigurator.Configure();
            log.Info("MainPage create");
        }

        public void SignUpNews(string email)
        {
            Card.SendKeys(email);
            CityCard.Click();
            log.Info("Subscribe to news");
        }

        public MainPage ChangeValue()
        {
            Value.Click();
            ValueUSD.Click();
            log.Info("Currency has changed to USD");
            return new MainPage(driver);
        }

        public MainPage ChangeFlag()
        {
            Flag.Click();
            FlagName.Click();
            log.Info("Flag has changed to EURO");
            return new MainPage(driver);
        }

        public MainPage ChangeLanguage()
        {
            Language.Click();
            LanguageName.Click();
            log.Info("Languagr has changed to Deutsch");
            return new MainPage(driver);
        }      
    }
}
    

