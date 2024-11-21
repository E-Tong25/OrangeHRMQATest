using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QA_Test_OpenSource_Demo_Website;

namespace QA_Test_OpenSource_Demo_Website_Test
{
    [TestClass]
    public class TestMyInfoPage
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
        public void TestChangeUserName()
        {
            //Arrange


            //Act


            //Assert

            //Navigate to My Info page
            //In Personal Details, change the Employee Full Name
            //Save your changes
            //Validate that the user name has changed in the top right corner (logged in user should now be the name you changed)
        }

        [TestMethod]
        public void TestUploadFile()
        {
            //Arrange


            //Act


            //Assert

            //Navigate to My Info page
            //On one of the tabs in Personal Details, upload a file
            //Save the changes
            //Make sure the file shows up in the grid below
            //Make sure the date matches the day it was uploaded
            //Validate the Type and Added By fields as well
        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}