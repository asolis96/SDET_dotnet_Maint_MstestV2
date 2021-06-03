using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    class AboutPage : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Personal')]")]
        private IWebElement PersonalTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Professional')]")]
        private IWebElement ProfessionalTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Social')]")]
        private IWebElement SocialTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Leadership')]")]
        private IWebElement LeadershipTeamTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='leads']//div[contains(@class,'lead-card')]")]
        private IList<IWebElement> LeadershipTeam { get; set; }

        public AboutPage() : base()
        {
            PageFactory.InitElements(driver, this);
        }

        public AboutPage ValidateGuidingPurposesArePresent()
        {
            Assert.IsTrue(WaitForTextElement(PersonalTitle, 20, "PERSONAL"));
            Assert.IsTrue(WaitForTextElement(ProfessionalTitle, 20, "PROFESSIONAL"));
            Assert.IsTrue(WaitForTextElement(SocialTitle, 20, "SOCIAL"));

            return this;
        }

        public AboutPage PrintLeadershipTeam()
        {
            string[] aux;
            string s;
         
            browser.ScrollToElement(driver, LeadershipTeamTitle);
            browser.ScrollToElement(driver, LeadershipTeam[0]);
            foreach(IWebElement lead in LeadershipTeam)
            {
                browser.ScrollToElement(driver, lead);
                aux = lead.Text.Split("\r\n");                
                Console.WriteLine($"Name: {aux[0]}");
                Console.WriteLine($"Rol: {aux[1]}");
                Console.WriteLine();
            
            }
            return this;
        } 
    }
}
