using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QaseProjectTest.Core;

namespace QaseProjectTest.Utils
{
    public class Waiters
    {
        private readonly WebDriverWait wait;

        public Waiters(IWebDriver driver, TimeSpan timeOut)
        {
            wait = new WebDriverWait(driver, timeOut);
        }
        
        public Waiters(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, ReadProperties.Timeout);
        }

        public IWebElement waitForVisibility(By by)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
        
        
    }
}