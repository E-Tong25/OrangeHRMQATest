using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_Test_OpenSource_Demo_Website
{
    [TestClass]
    public class LoginPage
    {
        public required IWebDriver _driver;
        public required Selectors _selectors;

        [TestInitialize]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _selectors = new Selectors(_driver);
        }
        
        [TestMethod]
        public void TestLogin()
        {
            _driver.Navigate().GoToUrl(_selectors.url);
            _selectors.userNameTextBox.SendKeys("Admin");
            _selectors.passwordTextBox.SendKeys("admin123");
            _selectors.loginButton.Click();

            bool dashBoardIsDisplayed = _selectors.dashboardBotton.Displayed;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(dashBoardIsDisplayed);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}