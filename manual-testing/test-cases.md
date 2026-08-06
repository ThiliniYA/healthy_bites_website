# Healthy Bites – Test Cases

## 1. Home Page (index.html)

| TC ID | Test Case Description | Precondition | Steps | Expected Result | Status |
|-------|------------------------|--------------|--------|------------------|--------|
| TC-001 | Verify home page loads successfully | Browser open | 1. Navigate to index.html | Home page loads without errors | Pass |
| TC-002 | Verify navigation bar is visible | Home page loaded | 1. Check top navigation bar | Navigation bar displays all links | Pass |
| TC-003 | Verify "Recipes" link navigates correctly | Home page loaded | 1. Click "Recipes" | User is taken to recipes.html | Pass |
| TC-004 | Verify "Register" link navigates correctly | Home page loaded | 1. Click "Register" | User is taken to register.html | Pass |
| TC-005 | Verify images & video load correctly | Home page loaded | 1. Scroll through page | All images appear without broken links | Fail |

---

## 2. Recipes Page (recipes.html)

| TC ID | Test Case Description | Precondition | Steps | Expected Result | Status |
|-------|------------------------|--------------|--------|------------------|--------|
| TC-006 | Verify recipes page loads | Browser open | 1. Navigate to recipes.html | Page loads without errors | Pass|
| TC-007 | Verify recipe cards display | Recipes page loaded | 1. Scroll through recipe list | All recipe cards appear correctly | Pass |
| TC-008 | Verify images load | Recipes page loaded | 1. Inspect each recipe card | Images load without broken links | Pass |
| TC-009 | Verify navigation back to home | Recipes page loaded | 1. Click "Home" | User returns to index.html | Pass |

---

## 3. Register Page (register.html)

### **Positive Test Cases**

| TC ID | Test Case Description | Precondition | Steps | Expected Result | Status |
|-------|------------------------|--------------|--------|------------------|--------|
| TC-010 | Verify register page loads | Browser open | 1. Navigate to register.html | Page loads without errors | Pass |
| TC-011 | Verify user can enter valid name | Register page loaded | 1. Enter valid name | Name is accepted | Pass |
| TC-012 | Verify user can enter valid email | Register page loaded | 1. Enter valid email | Email is accepted | Pass |
| TC-013 | Verify user can enter valid password | Register page loaded | 1. Enter valid password | Password is accepted | Pass |
| TC-014 | Verify form submits with valid data | All fields valid | 1. Fill form 2. Click submit | Success message or no errors | Pass |

### **Negative Test Cases**

| TC ID | Test Case Description | Precondition | Steps | Expected Result | Status |
|-------|------------------------|--------------|--------|------------------|--------|
| TC-015 | Verify empty form shows error | Register page loaded | 1. Click submit without entering data | Error message appears | Pass|
| TC-016 | Verify invalid email shows error | Register page loaded | 1. Enter invalid email 2. Submit | Error message appears |Fail |
| TC-017 | Verify short password shows error | Register page loaded | 1. Enter short password 2. Submit | Error message appears | Pass |
| TC-018 | Verify missing name shows error | Register page loaded | 1. Leave name empty 2. Submit | Error message appears | Pass |

---

## 4. General UI Test Cases

| TC ID | Test Case Description | Precondition | Steps | Expected Result | Status |
|-------|------------------------|--------------|--------|------------------|--------|
| TC-019 | Verify consistent header across pages | Any page loaded | 1. Navigate through pages | Header remains consistent | Pass |
| TC-020 | Verify consistent footer across pages | Any page loaded | 1. Navigate through pages | Footer remains consistent | Pass |
| TC-021 | Verify responsive layout (desktop) | Browser open | 1. Resize window | Layout adjusts without breaking | Pass |

---

## 5. Cross-Browser Test Cases

| TC ID | Test Case Description | Precondition | Steps | Expected Result | Status |
|-------|------------------------|--------------|--------|------------------|--------|
| TC-022 | Verify site loads in Chrome | Chrome installed | 1. Open site in Chrome | All pages load correctly | Pass |
| TC-023 | Verify site loads in Edge | Edge installed | 1. Open site in Edge | All pages load correctly | Pass |

---

## 6. Assets & Links

| TC ID | Test Case Description | Precondition | Steps | Expected Result | Status |
|-------|------------------------|--------------|--------|------------------|--------|
| TC-024 | Verify CSS loads correctly | Any page loaded | 1. Inspect page styling | Styles applied correctly | Pass |
| TC-025 | Verify JS loads correctly | Any page loaded | 1. Check console for errors | No JS errors | Pass |
| TC-026 | Verify all links work | Any page loaded | 1. Click each link | All links navigate correctly | Pass|


