# Healthy Bites – Project Overview

Healthy Bites is a small website I originally created during my diploma to practise basic coding.
Later, I used this same website to build my QA skills by doing manual testing and automation.
This project shows how I test a simple website from start to finish — planning, execution, defect reporting, and automation.

## 📌 What This Project Includes
- A static website with three pages
- Manual testing (test plan, test cases, bug reports, summary)
- Real defects found during testing
- A working Selenium C# automation suite
- Clean, consistent folder structure
- README preview screenshots

## 🖥️ Website Pages
The website contains:
- **Home page** (`index.html`) – hero section, intro content, embedded video, and links
- **Recipes page** (`recipes.html`) – recipe table and featured recipe
- **Register page** (`register.html`) – form for user details

These pages gave me enough functionality to practise UI testing, navigation testing, and form validation.

## 🧪 Manual Testing
I performed manual testing to check:
- page loading
- navigation
- layout and styling
- form behaviour
- positive and negative scenarios
- cross-browser behaviour

All manual testing documents are inside the `manual-testing` folder.

## 🐞 Bugs Found
I found real issues during testing, including:
- invalid email accepted with no clear error message
- embedded YouTube video on the home page doesn't load
- weak password validation (no character restrictions beyond length)

These bugs are documented with steps, expected results, and actual results in `bug-reports.md`.

## 🤖 Automation
The `automation` folder contains a Selenium C# test suite covering:
- navigation between pages
- Register form validation (positive and negative cases)
- a test that documents the known email-validation bug, so it's caught if behaviour ever changes

Built using **C#, Selenium WebDriver, and NUnit**, following the **Page Object Model**. See `automation/HealthyBites.Automation/README.md` for setup and run instructions.

## 🎯 Why This Project Matters
Healthy Bites is important in my QA journey because:
- I built the website myself
- I tested it like a real QA project
- I found real bugs
- I wrote proper test cases
- I created clear documentation
- I automated part of the testing using my own work

This project shows how I learn, practise, and improve as a QA engineer.

