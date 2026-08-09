using NUnit.Framework;
using OpenQA.Selenium;
using HealthyBites.Automation.Drivers;
using HealthyBites.Automation.Config;

namespace HealthyBites.Automation.Tests
{
    [TestFixture]
    public class HomePageTests
    {
        private IWebDriver driver = null!;

        [SetUp]
        public void SetUp()
        {
            var driverFactory = new DriverFactory("chrome");
            driver = driverFactory.Driver;
        }

        [Test]
        public void TC001_VerifyHomePageLoads()
        {
            driver.Navigate().GoToUrl(TestConfig.GetPageUrl("index.html"));

            Assert.That(driver.Title, Is.EqualTo("HEALTHY BITES - Home"));
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
