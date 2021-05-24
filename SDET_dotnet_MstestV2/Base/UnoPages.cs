using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SDET_dotnet_MstestV2.Base
{
    public class UnoPages
    {
        protected static UnoBrowser browser;
        protected static IWebDriver driver;
        public UnoPages()
        {
            if (driver == null)
            {
                browser = new UnoBrowser();
                driver = browser.CreateBrowser(UnoBrowser.Browser.Chrome);
                PageFactory.InitElements(driver, this);
            }
        }

    }
}
