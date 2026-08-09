using NUnit.Framework;
using OpenQA.Selenium;
using HealthyBites.Automation.Drivers;
using HealthyBites.Automation.Config;
using HealthyBites.Automation.Pages;

namespace HealthyBites.Automation.Tests
{
    [TestFixture]
    public class RegisterPageTests
    {
        private IWebDriver driver = null!;
        private RegisterPage registerPage = null!;

        [SetUp]
        public void SetUp()
        {
            var driverFactory = new DriverFactory("chrome");
            driver = driverFactory.Driver;
            registerPage = new RegisterPage(driver);
            driver.Navigate().GoToUrl(TestConfig.GetPageUrl("register.html"));
        }

        [Test]
        public void TC014_ValidData_ShowsSuccessMessage()
        {
            registerPage.FillForm("Thilini", "Amarasekara", "thilini@example.com",
                                   "0211234567", "pass123", "pass123");
            registerPage.ClickRegister();

            Assert.That(registerPage.GetMessageText(), Does.Contain("Registration successful"));
        }

        [Test]
        public void TC015_018_EmptyRequiredField_BlocksSubmission()
        {
            // First name left empty; everything else valid
            registerPage.FillForm("", "Amarasekara", "thilini@example.com",
                                   "0211234567", "pass123", "pass123");
            registerPage.ClickRegister();

            // Browser validation blocks form submission
            Assert.That(registerPage.GetMessageText(), Is.Empty);
            Assert.That(registerPage.IsFieldNativelyInvalid("firstName"), Is.True);
        }

        [Test]
        public void TC016_InvalidEmailFormat_NoMessageShown_DocumentsKnownBug()
        {
            // Known issue (TC-016): invalid email is handled by browser validation only
            registerPage.FillForm("Thilini", "Amarasekara", "notanemail",
                                   "0211234567", "pass123", "pass123");
            registerPage.ClickRegister();

            Assert.That(registerPage.GetMessageText(), Is.Empty);
            Assert.That(registerPage.IsFieldNativelyInvalid("email"), Is.True);
        }

        [Test]
        public void TC017_ShortPassword_BlocksSubmission()
        {
            // Password below the 6-character minimum
            registerPage.FillForm("Thilini", "Amarasekara", "thilini@example.com",
                                   "0211234567", "abc", "abc");
            registerPage.ClickRegister();

            Assert.That(registerPage.GetMessageText(), Is.Empty);
            Assert.That(registerPage.IsFieldNativelyInvalid("password"), Is.True);
        }

        [Test]
        public void TC_Bonus_PasswordMismatch_ShowsErrorMessage()
        {
            // HTML5 validation passes, but the site checks that both passwords match
            registerPage.FillForm("Thilini", "Amarasekara", "thilini@example.com",
                                   "0211234567", "pass123", "different");
            registerPage.ClickRegister();

            Assert.That(registerPage.GetMessageText(), Does.Contain("Passwords do not match"));
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}
