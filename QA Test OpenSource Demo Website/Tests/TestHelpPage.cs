using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QA_Test_OpenSource_Demo_Website;

namespace QA_Test_OpenSource_Demo_Website_Test
{
    [TestClass]
    public class TestHelpPage
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
        public void TestOpenNewHelpPageTab()
        {
            //Arrange


            //Act


            //Assert

            //Click on help button '?' in top right corner
            //Make sure that a new tab opens 
            //Make sure the following links are present/enabled (Admin User Guide, Employee User Guide, Mobile App, AWS Guide, FAQs)
            //Make sure the Search Bar is present
            //Make sure the Sign in button is displayed

        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}