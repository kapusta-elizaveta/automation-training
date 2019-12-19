using Framework.Pages;
using Framework.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using log4net;
namespace Framework
{
    [TestClass]
    public class BonusPageTest
    {
        private const string BASE_URL = "https://azimuthotels.com/bonus/";
        private const string XPATH_CONNECT_BONUS = "//div[@class='autorization-popup connect-to-bonus-popup js-connect-to-bonus']//form";
        private Step step;
        private BonusPage bonusPage;

        [TestInitialize]
        public void SetupTest()
        {
            step = new Step();
            step.InitBrowser();
            bonusPage = new BonusPage(step.driver);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            step.CloseBrowser();
        }

        [TestMethod]
        public void AttachBonus()
        {
            string emailText = step.GenerateRandomEmailCharLength(5);
            step.GoToPage(BASE_URL);
            bonusPage.EntryBonus(emailText);
            Assert.IsNotNull(step.driver.FindElement(By.XPath(XPATH_CONNECT_BONUS)).Displayed);
        }
    }
}
