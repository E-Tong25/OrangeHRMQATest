using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_Test_OpenSource_Demo_Website
{
    public class LeavePage
    {
        public required IWebDriver _driver;
        public required Selectors _selectors;
        
        public void ApplyForLeave()
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
            
        }
    }
}