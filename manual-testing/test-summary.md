# Healthy Bites – Test Summary

## 1. Overview
This document summarises the results of the manual testing completed for the Healthy Bites website.  
The goal was to check basic functionality, navigation, layout, and form behaviour across all pages.

Testing was carried out on Windows 10/11 using Chrome and Edge.

---

## 2. Testing Completed
The following areas were covered:

- Page loading and basic functionality  
- Navigation between pages  
- Layout and styling checks  
- Content and image verification  
- Form validation on the Register page  
- Positive and negative test scenarios  
- Boundary value checks for form fields  

---

## 3. Overall Result
The website is **functional and stable** for desktop use.  
All pages load correctly, and navigation works as expected.  
Content displays properly, and the layout remains consistent across tested browsers.

---

## 4. Key Findings

### Passed
- All pages load without errors  
- Navigation links work correctly  
- Images and text display as expected  
- Layout is consistent across Chrome and Edge  
- Positive form submissions behave correctly (static behaviour)

### Failed / Issues Found
- Some form fields do not show clear error messages  
- Missing validation for boundary values  
- Minor alignment issues on the Register page  
- Some images load slowly or appear stretched  
- No backend → form submission does not save or process data  

All issues are documented in **bug-reports.md** with screenshots where relevant.

---

## 5. Defect Summary
- **Total defects found:** 6  
- **High severity:** 1  
- **Medium severity:** 3  
- **Low severity:** 2  

*(Adjust these numbers based on your actual bug report file.)*

---

## 6. Recommendations
- Add proper client‑side validation for all form fields  
- Improve visibility and consistency of error messages  
- Fix layout alignment issues on the Register page  
- Optimise image sizes for faster loading  
- Add backend support if future features require data storage  

---

## 7. Conclusion
Healthy Bites works well as a simple static website.  
The core pages behave as expected, and the user experience is smooth for basic browsing.  
The issues found are minor and easy to fix.

Manual testing is complete, and the project is ready for automation.


