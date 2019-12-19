using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Pages
{
    public class BonusPage
    {
        [FindsBy(How = How.XPath ,Using = "/html[1]/body[1]/section[1]/section[1]/div[1]/div[3]/form[1]/div[1]/div[2]/div[4]/input[1]")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='azimut-bonus-inform-button js-login-mrate']")]
        public IWebElement EntryButton { get; set; }
        private IWebDriver driver;
        private ILog log = LogManager.GetLogger(typeof(BonusPage));

        public BonusPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            log4net.Config.DOMConfigurator.Configure();
            log.Info("BonusPage created");
        }

        public void EntryBonus(string email)
        {
            Email.SendKeys(email);
            EntryButton.Click();
            log.Info("Get bonus");
        }
    }
}
