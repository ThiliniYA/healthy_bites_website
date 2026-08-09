using OpenQA.Selenium;

namespace HealthyBites.Automation.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickRecipesLink()
        {
            driver.FindElement(By.LinkText("Recipes")).Click();
        }

        public void ClickRegisterLink()
        {
            driver.FindElement(By.LinkText("Register")).Click();
        }
    }
}