# Healthy Bites – Bug Reports

Below are the real bugs identified during manual testing of the Healthy Bites website.

## 🐞 Bug 001 – Email Field Accepts Invalid Email Format Without Error Message

**Severity:** Medium
**Priority:** High
**Page:** `register.html`

### Description
The registration form does not show a custom validation error for invalid email formats. Some clearly invalid values (e.g. `abc`, `user@com`) are only caught by the browser's built-in email check, with no page-level message explaining what's wrong. There is no custom validation logic for the email field at all.

### Steps to Reproduce
1. Navigate to `register.html`
2. Enter an invalid email format, e.g. `abc` or `user@com`
3. Fill the remaining fields with valid data
4. Click Submit

### Expected Result
Form should display a clear, page-level error message and prevent submission.

### Actual Result
No custom error message appears anywhere on the page. The form relies solely on the browser's native validation, which blocks submission silently (via a small browser tooltip) rather than informing the user through the page itself.

---

## 🐞 Bug 002 – Embedded YouTube Video Does Not Load

**Severity:** High
**Priority:** High
**Page:** `index.html`

### Description
The home page embeds a YouTube video via an `<iframe>` in the "Quick Healthy Meal Ideas" section. The video does not load/play as expected.

### Steps to Reproduce
1. Navigate to `index.html`
2. Scroll to the "Quick Healthy Meal Ideas" section
3. Observe the embedded video area

### Expected Result
The embedded YouTube video should load and be playable directly on the page.

### Actual Result
The video does not load correctly in the embedded player.

---

## 🐞 Bug 003 – Password Field Allows Any Characters

**Severity:** Low
**Priority:** Medium
**Page:** `register.html`

### Description
The password field allows any characters or numbers without restrictions.
If the requirement is "minimum 6 characters," this is acceptable.
If stricter validation is expected, this is a bug.

### Steps to Reproduce
1. Navigate to `register.html`
2. Enter any characters
3. Submit the form

### Expected Result
Password should meet defined criteria.

### Actual Result
Password accepts any characters.

---

## Summary
This bug list includes only the issues confirmed during testing.



