using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace SDET_dotnet_MstestV2.Base
{
    public abstract class UnoPages
    {
        protected static UnoBrowser browser;
        protected static IWebDriver driver;
        protected WebDriverWait wait;
        public UnoPages()
        {
            if (driver == null)
            {
                browser = new UnoBrowser();
                driver = browser.CreateBrowser(UnoBrowser.Browser.Chrome);
                PageFactory.InitElements(driver, this);
            }
        }

        /**
        public IWebElement WaitForElement(IWebElement element, int timeOutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible);
        }
        */

        public bool WaitForTextElement(IWebElement element, int timeOutInSeconds, string text)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(element, text));
        }

        public IWebElement WaitForElement(By locator, int timeOutInSeconds)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

    }
}
