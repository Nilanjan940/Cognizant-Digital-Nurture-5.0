# Assignment 16: Handle Null References Safely

## Objective

Learn how to safely handle nullable reference types in C# using nullable reference annotations, the null-conditional operator (`?.`), the null-coalescing operator (`??`), and explicit null checking.

---

# Problem Statement

Create a C# program that:

- Defines a `Person` class with nullable reference type properties.
- Allows the user to create or skip creating a `Person` object.
- Accepts optional values for `Name` and `City`.
- Uses the null-conditional operator (`?.`) to safely access object members.
- Uses the null-coalescing operator (`??`) to provide default values.
- Performs explicit null checking before accessing object members.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Nullable Reference Types
- Null Safety
- Null-Conditional Operator (`?.`)
- Null-Coalescing Operator (`??`)
- Nullable Variables
- Safe Null Checking
- Modern C# Null Handling

---

# Prerequisites

You should know:

- Classes and Objects
- Properties
- User Input
- if-else Statements
- Basic OOP Concepts

---

# Theory

# What is Null?

`null` represents the absence of an object or value.

Example

```csharp
Person person = null;
```

Here, `person` does not refer to any object.

---

# What are Nullable Reference Types?

Nullable reference types were introduced in **C# 8**.

They help developers identify possible null reference problems during compilation.

Example

```csharp
string? Name;
```

The `?` indicates that the variable is allowed to contain `null`.

Without `?`

```csharp
string Name;
```

the compiler assumes the variable should never be null.

---

# Why Use Nullable Reference Types?

Benefits include:

- Prevents `NullReferenceException`
- Improves code safety
- Produces compiler warnings for unsafe code
- Encourages better programming practices

---

# What is the Null-Conditional Operator (`?.`)?

The null-conditional operator safely accesses members of an object.

Syntax

```csharp
object?.Member
```

Example

```csharp
Console.WriteLine(person?.Name);
```

If `person` is `null`, the expression returns `null` instead of throwing an exception.

---

# What is the Null-Coalescing Operator (`??`)?

The null-coalescing operator provides a default value when the left-hand side is null.

Syntax

```csharp
value ?? defaultValue
```

Example

```csharp
Console.WriteLine(person?.City ?? "Not Available");
```

If `City` is null, `"Not Available"` is displayed.

---

# Safe Null Checking

Before accessing object members, always check if the object exists.

Example

```csharp
if(person is not null)
{
    Console.WriteLine(person.Name);
}
```

This prevents runtime exceptions.

---

# What is `string.IsNullOrWhiteSpace()`?

This method checks whether a string is:

- `null`
- Empty (`""`)
- Contains only whitespace

Example

```csharp
if(string.IsNullOrWhiteSpace(name))
{
    person.Name = null;
}
```

This ensures blank input is stored as `null`.

---

# Null-Forgiving Operator (`!`)

Your program uses:

```csharp
Console.ReadLine()!
```

The `!` operator tells the compiler that you are confident the returned value will not be null.

It suppresses nullable warnings but should be used carefully.

---

# Program Workflow

```
Start
   │
   ▼
Ask User to Create Person?
   │
   ▼
Yes? ──────────────── No
 │                      │
 ▼                      ▼
Read Name           Person = null
Read City               │
 │                      │
 ▼                      ▼
Store Values        Display Output
 │                      │
 ▼                      ▼
Use ?.
Use ??
Check for Null
 │
 ▼
Display Results
 │
 ▼
End
```

---

# Program Explanation

## Step 1

Define the `Person` class.

```csharp
class Person
```

It contains nullable properties.

```csharp
string? Name;
string? City;
```

---

## Step 2

Ask whether the user wants to create a `Person` object.

```csharp
yes / no
```

---

## Step 3

If the answer is "yes", create the object.

```csharp
person = new Person();
```

---

## Step 4

Read the name and city.

Blank input is converted to `null` using:

```csharp
string.IsNullOrWhiteSpace()
```

---

## Step 5

Safely display the name.

```csharp
person?.Name
```

If `person` is null, no exception occurs.

---

## Step 6

Display the city.

```csharp
person?.City ?? "Not Available"
```

If `City` is null, a default message is displayed.

---

## Step 7

Perform explicit null checking.

```csharp
if(person is not null)
```

This ensures the object exists before accessing its members.

---

# Nullable Reference Types vs Non-Nullable Reference Types

| Nullable (`?`) | Non-Nullable |
|---------------|--------------|
| Can contain `null` | Should not contain `null` |
| Compiler tracks nullability | Compiler assumes non-null |
| Safer | Less safe if null is assigned |

---

# Null-Conditional vs Null-Coalescing

| Null-Conditional (`?.`) | Null-Coalescing (`??`) |
|--------------------------|------------------------|
| Safely accesses members | Provides a default value |
| Returns null if object is null | Replaces null with another value |

Example

```csharp
person?.Name
```

Example

```csharp
person?.City ?? "Unknown"
```

---

# Advantages of Nullable Reference Types

- Reduces runtime errors
- Prevents null reference exceptions
- Compiler-assisted null checking
- Cleaner code
- Better maintainability

---

# Best Practices

✔ Enable nullable reference types in new C# projects.

✔ Use `?.` whenever an object may be null.

✔ Use `??` to provide meaningful default values.

✔ Prefer `is not null` for explicit null checks.

✔ Avoid unnecessary use of the null-forgiving operator (`!`).

---

# Common Mistakes

### Accessing a Null Object

Incorrect

```csharp
Console.WriteLine(person.Name);
```

This throws a `NullReferenceException` if `person` is null.

---

### Forgetting to Check for Null

Always verify that an object exists before accessing its members.

---

### Overusing the Null-Forgiving Operator

Using `!` hides compiler warnings and can lead to runtime exceptions if used incorrectly.

---

### Confusing Nullable Value Types and Nullable Reference Types

`int?` is a nullable **value type**.

`string?` is a nullable **reference type**.

---

# Flowchart

```
            Start
               │
               ▼
 Ask User to Create Person
               │
       ┌───────┴────────┐
       │                │
      Yes              No
       │                │
       ▼                ▼
 Read Name & City   Person = null
       │
       ▼
 Store Null if Blank
       │
       ▼
 Use ?. Operator
       │
       ▼
 Use ?? Operator
       │
       ▼
 Check for Null
       │
       ▼
 Display Output
       │
       ▼
              End
```

---

# Real-World Applications

Null handling is essential in:

- ASP.NET Core Web APIs
- Entity Framework Core
- Database Applications
- File Handling
- JSON Serialization
- REST APIs
- Cloud Applications
- Enterprise Software

It helps prevent unexpected crashes caused by null values.

---

# Interview Questions

## 1. What is a `NullReferenceException`?

It is an exception thrown when code attempts to access a member of an object whose reference is `null`.

---

## 2. What are nullable reference types?

Nullable reference types are reference types marked with `?`, indicating they are allowed to contain `null`.

---

## 3. What does the null-conditional operator (`?.`) do?

It safely accesses members of an object and returns `null` instead of throwing an exception if the object itself is `null`.

---

## 4. What does the null-coalescing operator (`??`) do?

It returns the left-hand value if it is not `null`; otherwise, it returns the specified default value.

---

## 5. What is the purpose of `string.IsNullOrWhiteSpace()`?

It checks whether a string is `null`, empty, or contains only whitespace characters.

---

## 6. What is the null-forgiving operator (`!`)?

The `!` operator suppresses nullable warnings by telling the compiler that the value is expected to be non-null.

---

## 7. What is the difference between `?.` and `??`?

`?.` safely accesses members of a potentially null object, while `??` provides a fallback value if an expression evaluates to `null`.

---

## 8. When were nullable reference types introduced?

They were introduced in **C# 8**.

---

## 9. Why are nullable reference types important?

They improve code safety by allowing the compiler to detect possible null reference issues before runtime.

---

## 10. Where are nullable reference types commonly used?

They are widely used in ASP.NET Core, Entity Framework Core, Web APIs, desktop applications, cloud services, and enterprise .NET applications.

---

# Summary

In this assignment, you learned:

- Nullable Reference Types
- Null Safety
- Null-Conditional Operator (`?.`)
- Null-Coalescing Operator (`??`)
- Explicit Null Checking
- `string.IsNullOrWhiteSpace()`
- Null-Forgiving Operator (`!`)
- Best Practices
- Interview Questions

Proper null handling is a fundamental skill in modern C# development. By using nullable reference types, the null-conditional operator, and the null-coalescing operator, you can write safer, more reliable applications that avoid `NullReferenceException` and improve overall code quality. These techniques are widely used in **ASP.NET Core**, **Entity Framework Core**, **Web APIs**, and enterprise .NET development.