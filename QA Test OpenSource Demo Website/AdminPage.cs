using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_Test_OpenSource_Demo_Website
{
    [TestClass]
    public class AdminPage
    {
        public required IWebDriver _driver;
        public required Selectors _selectors;

        [TestInitialize]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _selectors = new Selectors(_driver);
        }
        public void TestSearchEditUser()
        {
            //Login Prerequisites with valid credentials

            _driver.Navigate().GoToUrl(_selectors.url);
            _selectors.userNameTextBox.SendKeys("Admin");
            _selectors.passwordTextBox.SendKeys("admin123");
            _selectors.loginButton.Click();

            bool dashBoardIsDisplayed = _selectors.dashboardBotton.Displayed;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(dashBoardIsDisplayed);

            //Click on Admin Tab
            _selectors.adminButton.Click();
            //Search for user via the Username
            _selectors.systemUserToggle.SendKeys("FMLName");
            //Click on Edit Button
            _selectors.editButton.Click();
            //Edit all fields available and save
            //Search for same user using one of the new field values you provided
            //Make sure all fields are the new ones you edited 
            //Delete the user
            //Make sure the user no longer exists

        }

        [TestMethod]
        
        public void TestAddNewUser(string username)
        {
            //Login Prerequisites with valid credentials

            _driver.Navigate().GoToUrl(_selectors.url);
            _selectors.userNameTextBox.SendKeys("Admin");
            _selectors.passwordTextBox.SendKeys("admin123");
            _selectors.loginButton.Click();

            //Navigate to Admin page
            _selectors.adminButton.Click();

            //Create a new user with Admin role
            _selectors.addNewUserButton.Click();
            
            //Make sure User is enabled
            //Employee name has to be one that is already in the system
            //Give User a username and password
            //Save User
            //Logout and then log back in using the credentials you just created
            //Make sure you are actually logged in as that user that you just created

        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}