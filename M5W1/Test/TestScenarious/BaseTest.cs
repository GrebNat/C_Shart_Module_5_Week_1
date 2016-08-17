using System;
using NUnit.Framework;
using OpenQA.Selenium;
using static M5W1.Util.BrowserManager;
using static M5W1.Util.PropertiesGetter;

namespace M5W1.Test.TestScenarious
{
    class BaseTest
    {
        public IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = GetDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
        }


        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
