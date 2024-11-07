using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;

namespace QA_Test_OpenSource_Demo_Website
{
    public class Selectors
    {
        IWebDriver _driver;

        public Selectors(IWebDriver driver)
        {
            _driver = driver;
        }

        public string url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        //Login Page Items
        public IWebElement userNameTextBox => _driver.FindElement(By.Name("username"));
        public IWebElement passwordTextBox => _driver.FindElement(By.Name("password"));
        public IWebElement loginButton => _driver.FindElement(By.CssSelector("button[type='submit']"));
    
        //Dashboard Page Items
        public IWebElement dashboardBotton => _driver.FindElement(By.CssSelector(".oxd-main-menu-item.active"));

    }
}