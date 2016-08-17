using M5W1.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace M5W1.PO
{
    public class MainPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "gb_70")] public IWebElement signInButton;


        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        public LoginPage NavigateToLoginPage()
        {
            signInButton.Click();
            return new LoginPage(_driver);
        }

        public MainPage Login(string user, string password)
        {
            LoginPage loginPage = NavigateToLoginPage();
            loginPage.Login(user, password);
            return this;
        }

        internal MainPage Login(User user)
        {
            return Login(user.UserName, user.Password);
        }
    }
}