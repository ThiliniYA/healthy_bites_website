using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HealthyBites.Automation.Drivers
{
    public class DriverFactory
    {
        public IWebDriver Driver { get; private set; }

        public DriverFactory()
        {
            Driver = new ChromeDriver();
        }

    }

}
