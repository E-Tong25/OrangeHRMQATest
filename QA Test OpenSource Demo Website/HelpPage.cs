using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_Test_OpenSource_Demo_Website
{

    public class HelpPage
    {
        public required IWebDriver _driver;
        public required Selectors _selectors;
        
        //Help Page Selectors
        public IWebElement helpPageButton => _driver.FindElement(By.XPath("//i[@class='oxd-icon bi-question-lg']"));
        public IWebElement adminUserGuideLink => _driver.FindElement(By.XPath(""));
        public IWebElement searchBar => _driver.FindElement(By.XPath("//input[@id='query']"));
        public IWebElement signInButton => _driver.FindElement(By.XPath("//a[@class='sign-in']"));
        public void OpenNewHelpPageTab()
        {
            //Click on help button '?' in top right corner

            helpPageButton.Click();

        }
    }
}