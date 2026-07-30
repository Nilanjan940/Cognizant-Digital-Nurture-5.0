# Assignment 17: Use Null-Conditional Chaining in a Contact App

## Objective

Learn how to safely work with nullable reference types in C# using the **null-conditional operator (`?.`)** and the **null-coalescing operator (`??`)**. This assignment demonstrates how to avoid `NullReferenceException` while accessing object properties.

---

# Problem Statement

Create a Contact application that:

- Creates a `Contact` object with `Name` and `PhoneNumber` properties.
- Safely accesses the contact's information using **null-conditional chaining (`?.`)**.
- Displays default values using the **null-coalescing operator (`??`)** when the object or its properties are null.

---

# Learning Outcomes

After completing this assignment, you will be able to:

- Understand nullable reference types.
- Use the null-conditional operator (`?.`).
- Use the null-coalescing operator (`??`).
- Understand null-conditional chaining.
- Prevent `NullReferenceException`.
- Write cleaner and safer C# code.

---

# Prerequisites

Before attempting this assignment, you should know:

- Classes and Objects
- Properties
- Object Creation
- User Input (`Console.ReadLine()`)
- Basic Conditional Statements (`if`)
- Nullable Reference Types (`?`)

---

# Theory

## 1. What is a Null Reference?

A **null reference** means an object reference does not point to any object in memory.

Example:

```csharp
Contact contact = null;
```

Here, `contact` does not reference any object.

Trying to access

```csharp
contact.Name;
```

will throw

```
System.NullReferenceException
```

---

# 2. What is Nullable Reference Type?

Beginning with **C# 8**, reference types can be marked as nullable.

Example

```csharp
string? name;
Contact? contact;
```

The `?` indicates the variable can contain either

- an object
- or `null`

Without `?`

```csharp
string name;
```

the compiler assumes the variable should never be null.

---

# 3. What is NullReferenceException?

It is one of the most common runtime exceptions.

Example

```csharp
Contact contact = null;

Console.WriteLine(contact.Name);
```

Output

```
System.NullReferenceException:
Object reference not set to an instance of an object.
```

---

# 4. Null-Conditional Operator (?.)

The null-conditional operator safely accesses members.

Syntax

```csharp
object?.Member
```

Example

```csharp
Console.WriteLine(contact?.Name);
```

If `contact` is null,

instead of throwing an exception,

it simply returns **null**.

---

# How `?.` Works

Without `?.`

```csharp
Console.WriteLine(contact.Name);
```

Possible Result

```
NullReferenceException
```

With `?.`

```csharp
Console.WriteLine(contact?.Name);
```

Possible Result

```
(no exception)
```

---

# 5. Null-Coalescing Operator (??)

The `??` operator provides a default value.

Syntax

```csharp
expression ?? defaultValue
```

Example

```csharp
Console.WriteLine(contact?.Name ?? "No Name Available");
```

Meaning

If

```csharp
contact?.Name
```

is null,

display

```
No Name Available
```

---

# 6. Combining ?. and ??

Most real-world programs combine both operators.

Example

```csharp
Console.WriteLine(contact?.PhoneNumber ?? "Not Available");
```

Possible situations

| Contact | Phone Number | Output |
|----------|--------------|--------|
| Exists | Exists | Actual Number |
| Exists | Null | Not Available |
| Null | Doesn't Matter | Not Available |

---

# 7. Null-Conditional Chaining

Sometimes objects contain other objects.

Example

```csharp
employee.Manager.Department.Name
```

If any object is null,

the program crashes.

Instead write

```csharp
employee?.Manager?.Department?.Name
```

This is called

**Null-Conditional Chaining**

Each level is checked safely.

---

# 8. Why is Null-Conditional Chaining Important?

Benefits

- Prevents NullReferenceException
- Cleaner code
- Less nested if statements
- Easy to read
- Production-ready coding style

---

# Program Explanation

## Step 1

Ask whether the user wants to create a contact.

```csharp
Console.Write("Do you want to create a contact? (yes/no): ");
```

---

## Step 2

Initially

```csharp
Contact? contact = null;
```

The object is null.

---

## Step 3

If user enters

```
yes
```

create the object.

```csharp
contact = new Contact();
```

---

## Step 4

Take user input.

```csharp
contact.Name = ...
contact.PhoneNumber = ...
```

---

## Step 5

Safely print the values.

```csharp
Console.WriteLine(contact?.Name);
```

---

## Step 6

Provide default values.

```csharp
Console.WriteLine(contact?.Name ?? "No Name Available");
```

---

## Step 7

Perform null checking.

```csharp
if(contact?.Name != null)
{
    ...
}
```

---

# Operators Used

## Nullable Reference

```csharp
string?
```

Allows null values.

---

## Null Conditional

```csharp
?.
```

Safely accesses members.

---

## Null Coalescing

```csharp
??
```

Provides a default value.

---

# Flowchart

```
          Start
             │
             ▼
 Ask User to Create Contact
             │
             ▼
      Contact Created?
        /          \
      Yes          No
       │            │
       ▼            ▼
Read Contact     Contact
 Details         remains null
       │            │
       └──────┬─────┘
              ▼
 Use ?. Operator
              ▼
 Use ?? Operator
              ▼
 Display Details
              ▼
      End Program
```

---

# Advantages of Null-Conditional Chaining

- Eliminates unnecessary null checks.
- Prevents runtime crashes.
- Improves readability.
- Makes maintenance easier.
- Recommended by Microsoft.
- Commonly used in ASP.NET Core applications.

---

# Real-Life Example

Suppose a customer may or may not have an address.

Without null checking

```csharp
customer.Address.City
```

may crash.

Safer version

```csharp
customer?.Address?.City ?? "Unknown City"
```

---

# Best Practices

✔ Always enable nullable reference types.

✔ Prefer `?.` over multiple nested `if` statements.

✔ Use `??` for sensible default values.

✔ Validate user input.

✔ Never assume an object is non-null.

---

# Common Mistakes

### Mistake 1

```csharp
contact.Name
```

without checking for null.

---

### Mistake 2

Using

```csharp
??
```

without

```csharp
?.
```

when the object itself can be null.

---

### Mistake 3

Ignoring compiler nullability warnings.

---

# Interview Questions

## 1. What is a null reference?

A null reference is a reference variable that does not point to any object in memory.

---

## 2. What is `NullReferenceException`?

It is a runtime exception thrown when a program tries to access members of a null object.

---

## 3. What is a nullable reference type?

A nullable reference type is a reference type marked with `?`, indicating it can contain either an object reference or `null`.

Example:

```csharp
string? name;
```

---

## 4. What does the `?.` operator do?

The null-conditional operator safely accesses a member only if the object is not null. Otherwise, it returns `null` instead of throwing an exception.

Example:

```csharp
contact?.Name
```

---

## 5. What does the `??` operator do?

The null-coalescing operator returns a default value when the left-hand expression is `null`.

Example:

```csharp
contact?.Name ?? "Unknown"
```

---

## 6. What is null-conditional chaining?

It is the repeated use of the `?.` operator to safely access nested objects.

Example:

```csharp
employee?.Manager?.Department?.Name
```

---

## 7. Difference between `?.` and `??`

| `?.` | `??` |
|------|------|
| Safely accesses members | Provides a default value |
| Returns null if object is null | Replaces null with another value |
| Prevents exceptions | Improves output readability |

---

## 8. Why is null safety important?

It prevents runtime exceptions, improves application stability, and makes code more reliable and maintainable.

---

## 9. Can `?.` be used with methods?

Yes.

Example:

```csharp
person?.DisplayDetails();
```

The method executes only if `person` is not `null`.

---

## 10. What are the benefits of nullable reference types?

- Detect null-related issues at compile time.
- Reduce runtime errors.
- Encourage safer coding practices.
- Improve code quality.

---

# Summary

In this assignment, you learned:

- Nullable Reference Types (`?`)
- Null References
- `NullReferenceException`
- Null-Conditional Operator (`?.`)
- Null-Coalescing Operator (`??`)
- Null-Conditional Chaining
- Safe Object Access
- Best Practices for Null Safety

These features are widely used in modern C# development, especially in **ASP.NET Core**, **Entity Framework Core**, **Web APIs**, and enterprise applications to write robust, maintainable, and null-safe code.