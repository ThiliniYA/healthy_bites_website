# Healthy Bites – Bug Reports

Below are the real bugs identified during manual testing of the Healthy Bites website.

---

## 🐞 Bug 001 – Email Field Accepts Invalid Email Format

**Severity:** Medium  
**Priority:** High  
**Page:** `register.html`

### Description  
The registration form accepts invalid email formats (e.g., "abc", "user@com") without showing any validation error.

### Steps to Reproduce  
1. Navigate to `register.html`  
2. Enter an invalid email (e.g., `a@b.com`)  
3. Click **Submit**

### Expected Result  
Form should display an error message and prevent submission.

### Actual Result  
Form accepts invalid email and submits.

---

## 🐞 Bug 002 – YouTube Link on Home Page Not Working

**Severity:** High  
**Priority:** High  
**Page:** `index.html`

### Description  
The YouTube link on the home page does not open the intended video.

### Steps to Reproduce  
1. Navigate to `index.html`  
2. Click the YouTube link  
3. Observe the result

### Expected Result  
YouTube video should open in a new tab.

### Actual Result  
Link is broken or does not navigate correctly.

---

## 🐞 Bug 003 – Password Field Allows Any Characters 

**Severity:** Low  
**Priority:** Medium  
**Page:** `register.html`

### Description  
The password field allows any characters or numbers without restrictions.  
If the requirement is “minimum 6 characters,” this is acceptable.  
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

# Summary  
This bug list includes only the issues confirmed during testing.  


