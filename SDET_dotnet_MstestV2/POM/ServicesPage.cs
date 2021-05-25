using OpenQA.Selenium;
using SDET_dotnet_MstestV2.Base;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET_dotnet_MstestV2.POM
{

    class ServicesPage : UnoPages
    {
        [FindsBy( How = How.XPath, Using = "//*[@class='subtitle' and contains(text(),'Trusted')]")]
        private IWebElement TrustedByIndustriesText { get; set; }

        public ServicesPage() : base()
        {

        }


    }
}
