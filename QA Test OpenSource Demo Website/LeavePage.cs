using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_Test_OpenSource_Demo_Website
{
    [TestClass]
    public class LeavePage
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
        public void TestApplyForLeave()
        {
            //Navigate to Leave page
            //Click Apply
            //Select Leave Type
            //Use Date picker to select a date range in the future (make sure you pay attention to how much time you have available)
            //Fill out comment section
            //Apply
            //Navigate to main leave page and make sure the leave you requested is showing in the results view
            //Navigate to 'My Leave' tab and make sure the leave is there and pending approval
            //Cancel the leave you just requested
            //Make sure the leave is now marked as canceled on the 'My Leave' page
            //Navigate back to main leave page and make sure that leave is no longer in the results view
            _driver.Navigate().GoToUrl(_selectors.url);
            _selectors.userNameTextBox.SendKeys("username");
            _selectors.passwordTextBox.SendKeys("");
            _selectors.loginButton.Click();

        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}