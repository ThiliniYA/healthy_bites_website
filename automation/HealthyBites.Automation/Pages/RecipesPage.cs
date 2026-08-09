using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace HealthyBites.Automation.Pages
{
    public class RecipesPage
    {
        private readonly IWebDriver driver;

        public RecipesPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ReadOnlyCollection<IWebElement> GetRecipeRows()
        {
            // Skips the header row, returns just the data rows
            return driver.FindElements(By.CssSelector("table tbody tr"));
        }

        public void ClickHomeLink()
        {
            driver.FindElement(By.LinkText("Home")).Click();
        }
    }
}