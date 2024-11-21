using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_Test_OpenSource_Demo_Website
{
    public class LoginPage
    {
        public required IWebDriver _driver;
        public required Selectors _selectors;

        //Login Page Selectors
        public IWebElement userNameTextBox => _driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        public IWebElement passwordTextBox => _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        public IWebElement loginButton => _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
        public IWebElement userAccountDropDown => _driver.FindElement(By.XPath("//span[@class='oxd-userdropdown-tab']"));
        public IWebElement logoutButton => _driver.FindElement(By.XPath("//a[normalize-space()='Logout']"));

        //Dashboard Page Items
        public IWebElement dashboardBotton => _driver.FindElement(By.CssSelector(".oxd-main-menu-item.active"));

        //Helper Methods
        public void Login(string url)
        {
           GoToURL(url);
           userNameTextBox.SendKeys("Admin");
           passwordTextBox.SendKeys("admin123");
           loginButton.Click();
        }

        public void GoToURL(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void Logout()
        {
            userAccountDropDown.Click();
            logoutButton.Click();

        }
    }
}