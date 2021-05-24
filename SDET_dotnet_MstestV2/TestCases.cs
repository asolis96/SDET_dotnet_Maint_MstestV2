using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDET_dotnet_MstestV2.POM;

namespace SDET_dotnet_MstestV2
{
    [TestClass]
    public class TestCases
    {
        HomePage homepage;
        BlogPage blogPage;
        [TestInitialize]
        public void BeforeTest()
        {
            homepage = new HomePage();
            blogPage = new BlogPage();
        }
        [TestMethod]
        public void Unosquare_BlogValidation()
        {
            //homepage.GoToServicesAndPracticeAreas();
            /*Add a new Page object name Blog
             *Implement all neded to use Blog in the test class (Constructor, WebElements, etc)
             *Perform the following flow, Go to www.unosquare.com
             * Go to Blog - Vlidate using Asserts, this element is present DIGITAL TRANSFORMATION BLOG
             * Search for Quality Assurance, validate with Asserts that at least one result is displayed
             */
            homepage.GoToBlog();
            blogPage.ValidatePageTitleIsPresent();
            blogPage.SearchForInPage("Quality Assurance");
            blogPage.ValidateSearchResults();
            
        }

    }
}
