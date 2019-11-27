using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    class LoginPage
    {
        private const string BASE_URL = "http://www.github.com/";

        [FindsBy(How = How.ClassName, Using = "link-auth")]
        public IWebElement ButtonPersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-login-canal-cab")]
        public IWebElement TitlePersonalAccount { get; set; }

        [FindsBy(How = How.ClassName, Using = "js-hbi-login-fb")]
        public IWebElement FaceBookPersonalAccount { get; set; }

        private IWebDriver driver;
        IWebElement source;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void EntryGmail()
        {
            this.ButtonPersonalAccount.Click();
            this.TitlePersonalAccount.Click();
            this.FaceBookPersonalAccount.Click();
        }
    }
}
