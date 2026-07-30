# Assignment 29: Sanitize Input and Prevent XSS

## Objective

Learn how to sanitize user input to prevent **Cross-Site Scripting (XSS)** attacks using **HTML Encoding** in C#. Understand the importance of secure coding practices while accepting and displaying user input.

---

# Problem Statement

Create a C# program that:

- Accepts input from the user.
- Displays the original input.
- Sanitizes the input using `WebUtility.HtmlEncode()`.
- Displays the sanitized output.
- Demonstrates how HTML encoding prevents XSS attacks.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Web Security Basics
- Cross-Site Scripting (XSS)
- Input Validation
- Input Sanitization
- Output Encoding
- HTML Encoding
- `System.Net.WebUtility`
- `HtmlEncode()`
- Secure Coding Practices
- OWASP Security Principles

---

# Prerequisites

Before attempting this assignment, you should know:

- C# Basics
- Console Input and Output
- Classes and Methods
- Strings
- Basic HTML Concepts

---

# Theory

# What is XSS?

**Cross-Site Scripting (XSS)** is one of the most common web security vulnerabilities.

It occurs when an attacker injects malicious JavaScript or HTML into an application.

When another user views that content, the malicious script executes in their browser.

---

# Example of XSS

A user enters:

```html
<script>alert("Hacked!")</script>
```

If the application displays it directly:

```html
<script>alert("Hacked!")</script>
```

The browser executes the JavaScript.

Result:

- Pop-up windows
- Cookie theft
- Session hijacking
- User impersonation
- Data theft

---

# What Happens During an XSS Attack?

```
Attacker

↓

Enters Malicious Script

↓

Application Stores Input

↓

Another User Opens Page

↓

Browser Executes Script

↓

User Data Compromised
```

---

# Types of XSS

## 1. Stored XSS

The malicious script is stored permanently in a database.

Example:

- Blog comments
- Product reviews
- Discussion forums

Every visitor executes the script.

---

## 2. Reflected XSS

The malicious script is reflected immediately from the server response.

Example:

```
Search Box

↓

Server Returns Input

↓

Browser Executes Script
```

---

## 3. DOM-Based XSS

The vulnerability exists entirely in client-side JavaScript.

The browser modifies the page using unsafe user input.

---

# Why is XSS Dangerous?

An attacker can:

- Steal cookies
- Steal session tokens
- Redirect users
- Display fake login pages
- Modify web pages
- Access sensitive information
- Perform actions as another user

---

# What is Input Validation?

Input validation checks whether the input follows expected rules.

Example:

```
Age

↓

Must be a number

↓

Reject letters
```

Validation ensures that the format is correct.

---

# What is Input Sanitization?

Sanitization removes or neutralizes dangerous content.

Example

Input

```html
<script>alert("Hello")</script>
```

After sanitization

```text
&lt;script&gt;alert("Hello")&lt;/script&gt;
```

The browser displays the text instead of executing it.

---

# What is Output Encoding?

Output encoding converts special characters into safe representations before displaying them.

Examples:

| Character | Encoded Value |
|------------|---------------|
| `<` | `&lt;` |
| `>` | `&gt;` |
| `&` | `&amp;` |
| `"` | `&quot;` |
| `'` | `&#39;` |

---

# HTML Encoding

HTML encoding replaces special characters with HTML entities.

Example

Original

```html
<h1>Hello</h1>
```

Encoded

```text
&lt;h1&gt;Hello&lt;/h1&gt;
```

The browser displays the tags instead of interpreting them.

---

# System.Net.WebUtility

The `System.Net.WebUtility` class provides methods for safely encoding and decoding data.

Namespace

```csharp
using System.Net;
```

---

# HtmlEncode()

Syntax

```csharp
string safeText = WebUtility.HtmlEncode(text);
```

Example

```csharp
string input = "<script>alert('XSS')</script>";
string output = WebUtility.HtmlEncode(input);
```

Result

```text
&lt;script&gt;alert(&#39;XSS&#39;)&lt;/script&gt;
```

---

# Why HTML Encoding Works

Browsers interpret characters such as `<` and `>` as HTML tags.

Encoding converts them into plain text.

Instead of executing:

```html
<script>
```

The browser displays:

```text
<script>
```

---

# Input Validation vs Sanitization vs Encoding

| Input Validation | Input Sanitization | Output Encoding |
|------------------|-------------------|-----------------|
| Checks correctness | Removes or neutralizes dangerous content | Converts characters into safe display format |
| Rejects invalid data | Cleans input | Protects browser output |
| Happens before processing | Happens before storage or display | Happens immediately before display |

---

# Program Workflow

```
Start

↓

Read User Input

↓

Display Original Input

↓

Call HtmlEncode()

↓

Generate Safe Text

↓

Display Sanitized Output

↓

Show Example

↓

End
```

---

# Program Explanation

## Step 1

Import the required namespace.

```csharp
using System.Net;
```

---

## Step 2

Create an `InputSanitizer` class.

This class contains a reusable method for sanitizing user input.

---

## Step 3

Accept input using:

```csharp
Console.ReadLine();
```

---

## Step 4

Display the original input.

This demonstrates what the user entered.

---

## Step 5

Call

```csharp
WebUtility.HtmlEncode()
```

to encode special characters.

---

## Step 6

Display the encoded text.

Instead of executing HTML or JavaScript, the browser would display it as plain text.

---

## Example

Input

```html
<script>alert("Hacked!")</script>
```

Output

```text
&lt;script&gt;alert(&quot;Hacked!&quot;)&lt;/script&gt;
```

---

# Advantages of HTML Encoding

- Prevents XSS attacks
- Easy to implement
- Built into .NET
- Improves application security
- Safe for displaying user-generated content

---

# Best Practices

✔ Always validate user input.

✔ Always encode output before displaying it.

✔ Never trust user input.

✔ Use built-in encoding methods instead of writing custom ones.

✔ Follow the principle of least privilege.

✔ Keep frameworks and libraries updated.

✔ Use HTTPS for secure communication.

✔ Follow OWASP security guidelines.

---

# Common Mistakes

## Displaying Raw Input

```csharp
Console.WriteLine(userInput);
```

Displaying untrusted input directly in a web page can introduce XSS vulnerabilities.

---

## Skipping Validation

Never assume users will enter valid data.

Always validate input before processing.

---

## Writing Custom Encoding Logic

Avoid manually replacing characters.

Instead, use trusted .NET methods such as `WebUtility.HtmlEncode()`.

---

## Assuming Console Applications Are Vulnerable to XSS

Console applications themselves are generally **not vulnerable** to XSS because they do not render HTML.

However, the same sanitization techniques are essential when developing:

- ASP.NET applications
- Web APIs
- Razor Pages
- Blazor applications

---

# Flowchart

```
              Start
                 │
                 ▼
        Read User Input
                 │
                 ▼
      Display Original Input
                 │
                 ▼
      HtmlEncode(User Input)
                 │
                 ▼
      Generate Safe Output
                 │
                 ▼
    Display Sanitized Output
                 │
                 ▼
        Application Ends
```

---

# Real-World Applications

Input sanitization is used in:

- Banking Applications
- E-Commerce Websites
- Social Media Platforms
- Hospital Management Systems
- Online Examination Portals
- Government Websites
- Blog Platforms
- Customer Feedback Systems
- Discussion Forums
- Chat Applications
- ASP.NET MVC Applications
- ASP.NET Core Web APIs

---

# Interview Questions

## 1. What is Cross-Site Scripting (XSS)?

XSS is a web security vulnerability where attackers inject malicious scripts into web pages viewed by other users.

---

## 2. What are the three types of XSS?

- Stored XSS
- Reflected XSS
- DOM-Based XSS

---

## 3. Why is XSS dangerous?

It can steal cookies, hijack sessions, redirect users, modify pages, and expose sensitive information.

---

## 4. What is HTML Encoding?

HTML encoding converts special characters into HTML entities so browsers display them as text instead of interpreting them as HTML.

---

## 5. Which .NET method is commonly used for HTML encoding?

`WebUtility.HtmlEncode()`

---

## 6. What namespace contains `WebUtility`?

```csharp
System.Net
```

---

## 7. What is the difference between validation and sanitization?

Validation checks whether the input is acceptable, while sanitization neutralizes potentially dangerous content.

---

## 8. Why should developers never trust user input?

Because user input can be malicious, invalid, or intentionally crafted to exploit vulnerabilities.

---

## 9. What is OWASP?

OWASP (Open Worldwide Application Security Project) is an organization that provides best practices and resources for improving software security.

---

## 10. Is a console application vulnerable to XSS?

Generally no, because it does not render HTML. However, the same secure coding techniques apply when building web applications.

---

## 11. What characters are commonly encoded?

- `<`
- `>`
- `&`
- `"`
- `'`

---

## 12. Where is HTML encoding commonly used?

- ASP.NET Core
- MVC Applications
- Razor Pages
- Blazor
- Web APIs
- Dynamic HTML generation

---

# Summary

In this assignment, you learned:

- Cross-Site Scripting (XSS)
- Types of XSS
- Input Validation
- Input Sanitization
- Output Encoding
- HTML Encoding
- `System.Net.WebUtility`
- `HtmlEncode()`
- OWASP Security Practices
- Secure Coding Best Practices
- Real-world Applications
- Common Mistakes
- Interview Questions

Input sanitization is a fundamental security practice in web development. Although this assignment uses a console application for demonstration, the concepts directly apply to ASP.NET and other web frameworks. By validating input, sanitizing data when necessary, and encoding output before displaying it, developers can effectively protect applications against XSS and other injection attacks.