# Healthy Bites – Test Summary

## 1. Overview
This document summarises the results of the manual testing completed for the Healthy Bites website.
The goal was to check basic functionality, navigation, layout, and form behaviour across all pages.
Testing was carried out on Windows 10/11 using Chrome and Edge.

## 2. Testing Completed
The following areas were covered:
- Page loading and basic functionality
- Navigation between pages
- Layout and styling checks
- Content and image verification
- Form validation on the Register page
- Positive and negative test scenarios

## 3. Overall Result
The website is functional and stable for desktop use.
All pages load correctly, and navigation works as expected.
Content displays properly, and the layout remains consistent across tested browsers.

## 4. Key Findings

**Passed**
- All pages load without errors
- Navigation links work correctly
- Images and text display as expected
- Layout is consistent across Chrome and Edge
- Positive form submissions behave correctly (see Bug 002 note below regarding the embedded video)

**Failed / Issues Found**
- Email field does not show a clear validation error for invalid formats (Bug 001)
- Embedded YouTube video on the home page does not load (Bug 002)
- Password field has no character restrictions beyond length (Bug 003)

All issues are documented in `bug-reports.md`.

> Note: The site has no backend, so form submissions are not saved or processed server-side. This is expected behaviour per the project scope (see Test Plan, Section 2 & 7) and is not counted as a defect.

## 5. Defect Summary
- Total defects found: 3
- High severity: 1
- Medium severity: 1
- Low severity: 1

## 6. Recommendations
- Add client-side validation with a clear, visible error message for invalid email formats
- Investigate and fix the embedded YouTube video on the home page
- Define and enforce stricter password composition rules if required
- Add backend support if future features require data storage

## 7. Conclusion
Healthy Bites works well as a simple static website.
The core pages behave as expected, and the user experience is smooth for basic browsing.
The issues found are minor and well understood.
Manual testing is complete, and the project has since been extended with automated regression tests covering navigation and Register form validation (see `automation/` folder).
