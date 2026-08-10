# Healthy Bites – Automation Suite

This folder contains the Selenium automation tests for the Healthy Bites website.

I built these tests using **C#, Selenium WebDriver, and NUnit** while learning test automation. I used the **Page Object Model (POM)** to keep the page code separate from the test code and make the project easier to maintain.

If you'd like to see the full project, including the manual testing documents, bug reports, and the website itself, please see the main project README.

## Project Structure

```text
Config/    → project settings and website path
Drivers/   → browser setup (Chrome and Edge)
Pages/     → page classes (HomePage, RecipesPage, RegisterPage)
Tests/     → automation test classes
```

## What the Tests Cover

### Home page

* Check that the page loads
* Navigate to the Recipes page
* Navigate to the Register page

### Recipes page

* Check that the page loads
* Verify the recipe table content
* Navigate back to the Home page

### Register page

* Successful registration
* Required field validation
* Short password validation
* Password mismatch validation
* A known email validation issue found during manual testing

The automation test names match the manual test case IDs. For example:

```text
TC001_VerifyHomePageLoads
```

This makes it easy to see which manual test each automated test is based on.

## Running the Tests

From this folder, run:

```bash
dotnet test
```



