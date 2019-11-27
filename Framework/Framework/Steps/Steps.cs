using OpenQA.Selenium;

namespace Framework.Steps
{
    class Steps
    {
        IWebDriver driver;
        private Pages.SearchPage searchPage;


        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void SignIn()
        {
            Pages.LoginPage loginPage= new Pages.LoginPage(driver);
            loginPage.goToPage();
            loginPage.EntryGmail();
        }

        public void ChooseArrivalDate()
        {
            searchPage = new Pages.SearchPage(driver);
            searchPage.goToPage();
            searchPage.ChooseArrivalDate();
        }

        public void ChooseVisitorsTest()
        {
            searchPage = new Pages.SearchPage(driver);
            searchPage.goToPage();
            searchPage.ChooseVisitors();
        }

        public void ChooseCityTest(string city)
        {
            searchPage = new Pages.SearchPage(driver);
            searchPage.goToPage();
            searchPage.SelectCity(city);
            searchPage.ChooseHotel();
        }
    }
}
