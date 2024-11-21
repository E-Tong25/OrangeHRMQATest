using Microsoft.VisualBasic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QA_Test_OpenSource_Demo_Website;

namespace QA_Test_OpenSource_Demo_Website_Test
{
    [TestClass]
    public class TestAdminPage
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
        public void TestSearchEditUser()
        {
            //Arrange 

            //Act

            //Assert
            
            string url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

            //Click on Admin Tab
            //Search for user via the Username
            //Click on Edit Button
            //Edit all fields available and save
            //Search for same user using one of the new field values you provided
            //Make sure all fields are the new ones you edited 
            //Delete the user
            //Make sure the user no longer exists
        }

        [TestMethod]
        public void TestAddNewUserAndLogin()
        {
            //Arrange


            //Act


            //Assert

            //Navigate to Admin page

            //Create a new user with Admin role
            
            
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