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
    class BlogPage : UnoPages
    {
        [FindsBy(How = How.XPath, Using = "//*[@class='breadcrumb-container']//h1")]
        private IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='search-bar']")]
        private IWebElement SearchBar { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='results-title']")]
        private IWebElement ResultsTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='title-header']//a")]
        private IList<IWebElement> SearchResults { get; set; }


        private string SearchText;
        public BlogPage() : base()
        {
            PageFactory.InitElements(driver, this);
            SearchText = "";

        }

        public BlogPage ValidatePageTitleIsPresent()
        {
            Assert.IsTrue(PageTitle.Displayed);
            return this;
        }

        public BlogPage SearchForInPage(string text)
        {
            SearchText = text;
            browser.SendText(SearchBar, text);
            browser.Click(SubmitButton);
            return this;
        }

        public BlogPage ValidateSearchResults()
        {
            Assert.IsTrue(ResultsTitle.Text.Contains(SearchText), "Result title does not contains the search text");
            Assert.IsTrue(SearchResults.Count() > 0, "The list is empty, search result was empty");
            //Assert.IsTrue(SearchResults[0].Text.Contains(SearchText));
            
            return this;
        }
    }
}
