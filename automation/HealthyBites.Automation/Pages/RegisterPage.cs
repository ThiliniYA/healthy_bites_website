using OpenQA.Selenium;

namespace HealthyBites.Automation.Pages
{
    public class RegisterPage
    {
        private readonly IWebDriver driver;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement FirstNameField => driver.FindElement(By.Id("firstName"));
        private IWebElement LastNameField => driver.FindElement(By.Id("lastName"));
        private IWebElement EmailField => driver.FindElement(By.Id("email"));
        private IWebElement MobileField => driver.FindElement(By.Id("mobile"));
        private IWebElement PasswordField => driver.FindElement(By.Id("password"));
        private IWebElement ConfirmPasswordField => driver.FindElement(By.Id("confirmPassword"));
        private IWebElement SubmitButton => driver.FindElement(By.CssSelector("button[type='submit']"));
        private IWebElement MessageElement => driver.FindElement(By.Id("message"));

        public void FillForm(string firstName, string lastName, string email,
                              string mobile, string password, string confirmPassword)
        {
            FirstNameField.Clear();
            FirstNameField.SendKeys(firstName);

            LastNameField.Clear();
            LastNameField.SendKeys(lastName);

            EmailField.Clear();
            EmailField.SendKeys(email);

            MobileField.Clear();
            MobileField.SendKeys(mobile);

            PasswordField.Clear();
            PasswordField.SendKeys(password);

            ConfirmPasswordField.Clear();
            ConfirmPasswordField.SendKeys(confirmPassword);
        }

        public void ClickRegister()
        {
            SubmitButton.Click();
        }

        public string GetMessageText()
        {
            return MessageElement.Text;
        }

        // Check if the field is valid according to HTML5 validation rules

        public bool IsFieldNativelyInvalid(string fieldId)
        {
            var js = (IJavaScriptExecutor)driver;
            var result = js.ExecuteScript(
                $"return document.getElementById('{fieldId}').checkValidity();");
            var isValid = result is bool b && b;
            return !isValid;
        }
    }
}
