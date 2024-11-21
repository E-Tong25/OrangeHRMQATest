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
    }
}