using NUnit.Framework;
using OpenQA.Selenium;
using HealthyBites.Automation.Drivers;
using HealthyBites.Automation.Config;
using HealthyBites.Automation.Pages;

namespace HealthyBites.Automation.Tests
{
    [TestFixture]
    public class HomePageTests
    {
        private IWebDriver driver = null!;
        private HomePage homePage = null!;

        [SetUp]
        public void SetUp()
        {
            var driverFactory = new DriverFactory("chrome");
            driver = driverFactory.Driver;
            homePage = new HomePage(driver);
            driver.Navigate().GoToUrl(TestConfig.GetPageUrl("index.html"));
        }

        [Test]
        public void TC001_VerifyHomePageLoads()
        {
            Assert.That(driver.Title, Is.EqualTo("HEALTHY BITES - Home"));
        }

        [Test]
        public void TC003_VerifyRecipesLinkNavigates()
        {
            homePage.ClickRecipesLink();

            Assert.That(driver.Title, Is.EqualTo("HEALTHY BITES - Recipes"));
        }

        [Test]
        public void TC004_VerifyRegisterLinkNavigates()
        {
            homePage.ClickRegisterLink();

            Assert.That(driver.Title, Is.EqualTo("HEALTHY BITES - Register"));
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}