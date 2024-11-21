using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_Test_OpenSource_Demo_Website
{
    public class AdminPage
    { 
        public required IWebDriver _driver;
        public required Selectors _selectors;

        //Admin Page Selectors
        public IWebElement userSearchBox => _driver.FindElement(By.XPath("//input[@class='oxd-input oxd-input--focus']"));
        public IWebElement editButton => _driver.FindElement(By.XPath("//div[@role='table']//div[1]//div[1]//div[6]//div[1]//button[1]//i[1]"));
        public IWebElement addNewUserButton => _driver.FindElement(By.XPath("//button[normalize-space()='Add']"));
        public IWebElement userRoleSelectTextButton => _driver.FindElement(By.XPath("//i[@class='oxd-icon bi-caret-up-fill oxd-select-text--arrow']"));

        public IWebElement userRoleAdminOption  => _driver.FindElement(By.XPath("//div[@class='oxd-select-text-input'][normalize-space()='Admin']"));
        public IWebElement employeeNameTextBox => _driver.FindElement(By.XPath("//input[@placeholder='Type for hints...']"));

        //Helper Methods
        public void SearchUser(string username)
        {
            userSearchBox.Click();
            userSearchBox.SendKeys(username);
            //Edit all fields available and save
            //Search for same user using one of the new field values you provided
            //Make sure all fields are the new ones you edited 
            //Delete the user
            //Make sure the user no longer exists
        }
        public void EditUser(string username)
        {
            //Search user
            SearchUser(username);
            //Click on Edit Button
             editButton.Click();
            //Edit user
        }
        public void AssignAdminUserRole()
        {
            userRoleSelectTextButton.Click();
            userRoleAdminOption.Click();
        }

        public void AddEmployeeName()
        {

        }

        public void AddNewUser(string username, string name, string userRole, string password)
        {
        

            //Create a new user with Admin role
            addNewUserButton.Click();
            
            //Give User a username and password
            //Save User
            //Logout and then log back in using the credentials you just created
            //Make sure you are actually logged in as that user that you just created
        }

        public void SaveNewUser(string username, string name, string userRole, string password)
        {

        }

        public void DeleteUser(string username)
        {

        }
    }
}