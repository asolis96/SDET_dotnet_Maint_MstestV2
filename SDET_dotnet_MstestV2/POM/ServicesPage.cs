using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace SDET_dotnet_MstestV2.POM
{

    class ServicesPage : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//*[@class='subtitle' and contains(text(),'Trusted')]")]
        private IWebElement TrustedByIndustriesText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'logos')]//div")]
        private IList<IWebElement> IndustryLeadersLogos { get; set; }
                
        public ServicesPage() : base()
        {
            PageFactory.InitElements(driver, this);
        }


        public ServicesPage ValidateTextIsPresent()
        {
            Assert.IsTrue(TrustedByIndustriesText.Displayed, "Element is not present");            
            return this;
        }

        public ServicesPage PrintTotalIndustryLeadersDisplayed()
        {
            Console.WriteLine($"Industry Leaders displayed: {IndustryLeadersLogos.Count}");
            return this;
        }

    }
}
