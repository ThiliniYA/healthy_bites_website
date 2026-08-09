using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace HealthyBites.Automation.Drivers
{
    public class DriverFactory
    {
        public IWebDriver Driver { get; private set; }

        public DriverFactory(string browser)
        {
            if (browser.ToLower() == "chrome")
            {
                Driver = new ChromeDriver();
            }
            else if (browser.ToLower() == "edge")
            {
                Driver = new EdgeDriver();
            }
            else
            {
                throw new ArgumentException($"Unsupported browser: {browser}");
            }
        }
    }
}
