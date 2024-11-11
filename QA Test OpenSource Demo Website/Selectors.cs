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

        //Admin Page Items
        public IWebElement adminButton => _driver.FindElement(By.PartialLinkText("Admin"));
        public IWebElement systemUserToggle => _driver.FindElement(By.ClassName("oxd-table-filter-header-options"));
        public IWebElement userSearchBox => _driver.FindElement(By.ClassName("oxd-input oxd-input--active"));
        public IWebElement editButton => _driver.FindElement(By.ClassName("oxd-icon bi-pencil-fill"));
        public IWebElement addNewUserButton => _driver.FindElement(By.ClassName("oxd-button oxd-butoon--medium oxd-button--secondary"));
        public IWebElement userRoleSelectTextButton => _driver.FindElement(By.ClassName("oxd-select-text-input"));

        //Help Page
        public IWebElement helpPageButton => _driver.FindElement(By.ClassName("oxd-icon bi-question-lg"));
    }
}