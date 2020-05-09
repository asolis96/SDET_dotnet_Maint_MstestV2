using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDET_dotnet_MstestV2.POM;

namespace SDET_dotnet_MstestV2
{
    [TestClass]
    public class TestCases
    {
        HomePage homepage;
        [TestInitialize]
        public void BeforeTest()
        {
            homepage = new HomePage();
        }
        [TestMethod]
        public void Unosquare_GotoCareers()
        {
            homepage.GoToServicesAndPracticeAreas();
        }

        [TestMethod]
        public void AllElementsInServices()
        {
            /*
             * Your code goes here:
             * Create a new POM Page called: Services, implement Page Factory and add the following Test
             * Go to https://www.unosquare.com
             * Go to Services
             * Verify that this element is present: TRUSTED BY INDUSTRY LEADERS
             * Print How many Industry Leaders are being displayed
             * */
        }
        [TestMethod]
        public void ValidateOurMission()
        {
            /*
             * Your code goes here:
             * Create a new POM Page called: About, implement Page Factory and add the following Test
             * Go to https://www.unosquare.com
             * Go to About
             * Verify that 3 elements are present: Personal, Professional and Social
             * Scroll Down and verify element is present: LEADERSHIP TEAM
             * Print the name of each Leader and the corresponding Rol
             * */
        }
    }
}
