using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDET_dotnet_MstestV2.POM
{
    public class HomePage : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//a[.= 'Services' and @class = 'nav-link']")]
        private IWebElement ServicesMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.= 'Practice Areas' and @class = 'nav-link']")]
        private IWebElement PracticeAreas { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.= 'About' and @class = 'nav-link']")]
        private IWebElement AboutMenu { get; set; }
        public HomePage() : base()
        {
            
        }

        public HomePage GoToServicesAndPracticeAreas()
        {
            //WaitForElement(ServicesMenu, 20);
            browser.Click(ServicesMenu);
            browser.Click(PracticeAreas);
            return this;
        }

        public HomePage GoToServicesPage()
        {
            browser.Click(ServicesMenu);
            return this;
        }

        public HomePage GoToAboutPage()
        {
            browser.Click(AboutMenu);
            return this;
        }
    }
}
