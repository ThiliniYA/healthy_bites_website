using NUnit.Framework;
using OpenQA.Selenium;
using HealthyBites.Automation.Drivers;
using HealthyBites.Automation.Config;
using HealthyBites.Automation.Pages;

namespace HealthyBites.Automation.Tests
{
    [TestFixture]
    public class RecipesPageTests
    {
        private IWebDriver driver = null!;
        private RecipesPage recipesPage = null!;

        [SetUp]
        public void SetUp()
        {
            var driverFactory = new DriverFactory("chrome");
            driver = driverFactory.Driver;
            recipesPage = new RecipesPage(driver);
            driver.Navigate().GoToUrl(TestConfig.GetPageUrl("recipes.html"));
        }

        [Test]
        public void TC006_VerifyRecipesPageLoads()
        {
            Assert.That(driver.Title, Is.EqualTo("HEALTHY BITES - Recipes"));
        }

        [Test]
        public void TC007_VerifyRecipeTableHasExpectedRows()
        {
            var rows = recipesPage.GetRecipeRows();

            Assert.That(rows.Count, Is.EqualTo(4));
        }

        [Test]
        public void TC009_VerifyHomeLinkNavigatesBack()
        {
            recipesPage.ClickHomeLink();

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