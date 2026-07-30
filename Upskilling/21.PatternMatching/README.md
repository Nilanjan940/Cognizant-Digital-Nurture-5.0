# Assignment 21: Use Pattern Matching with `is` and `switch`

## Objective

Learn how to use **Pattern Matching** in C# with the `is` operator and the `switch` statement to write cleaner, safer, and more readable code.

---

# Problem Statement

Create a program that:

- Accepts an object as input.
- Uses the `is` operator to determine its type.
- Uses a `switch` statement with pattern matching to perform operations based on the object's type.
- Displays type-specific information.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Pattern Matching
- `is` Pattern
- `switch` Pattern Matching
- Object Type Checking
- Type Casting
- Runtime Type Identification
- Polymorphism Basics

---

# Prerequisites

- Variables
- Data Types
- Object Class
- Methods
- Conditional Statements
- Switch Statement

---

# Theory

# What is Pattern Matching?

Pattern Matching is a feature introduced in C# that combines **type checking** and **type casting** into a single, concise expression.

Instead of first checking a type and then casting it, Pattern Matching allows both operations at once.

---

# Why Use Pattern Matching?

Without Pattern Matching:

```csharp
if(obj is string)
{
    string s = (string)obj;
}
```

With Pattern Matching:

```csharp
if(obj is string s)
{
    Console.WriteLine(s.Length);
}
```

Advantages:

- Less code
- No explicit casting
- More readable
- Safer
- Better performance

---

# The `is` Operator

The `is` operator checks whether an object matches a specified type.

Syntax:

```csharp
if(objectName is Type variable)
{
    // Use variable
}
```

Example:

```csharp
if(obj is int number)
{
    Console.WriteLine(number);
}
```

If `obj` is an integer, it is automatically cast to `number`.

---

# Pattern Matching with `switch`

The `switch` statement can match types directly.

Example:

```csharp
switch(obj)
{
    case int n:
        Console.WriteLine(n);
        break;

    case string s:
        Console.WriteLine(s);
        break;
}
```

Each case checks the object's type and creates a typed variable.

---

# Object Class

In C#, every type ultimately derives from the `object` class.

```csharp
object value = 25;
object text = "Hello";
object amount = 45.5;
```

Pattern Matching helps determine the actual runtime type stored in an `object`.

---

# Program Explanation

## Step 1

Accept the user's choice and input.

---

## Step 2

Store the input in an `object` variable.

```csharp
object value;
```

---

## Step 3

Use `is` Pattern Matching.

```csharp
if(obj is int number)
```

The object is checked and automatically cast.

---

## Step 4

Use `switch` Pattern Matching.

```csharp
case string s:
```

The correct block executes depending on the object's runtime type.

---

## Step 5

Display type-specific information.

---

# Pattern Matching vs Traditional Type Checking

Traditional:

```csharp
if(obj is string)
{
    string s = (string)obj;
}
```

Pattern Matching:

```csharp
if(obj is string s)
{
}
```

Pattern Matching is shorter, safer, and avoids redundant casts.

---

# Benefits of Pattern Matching

- Eliminates explicit casting.
- Improves readability.
- Reduces errors.
- Supports complex conditions.
- Works well with polymorphism.

---

# Best Practices

✔ Prefer Pattern Matching over manual casting.

✔ Use `switch` for multiple type checks.

✔ Use meaningful variable names.

✔ Avoid unnecessary casts.

✔ Use `object` only when required.

---

# Common Mistakes

### Forgetting Pattern Variables

Incorrect

```csharp
if(obj is int)
{
}
```

Correct

```csharp
if(obj is int number)
{
}
```

---

### Using Explicit Casting Unnecessarily

Avoid

```csharp
(int)obj
```

Prefer

```csharp
obj is int number
```

---

### Missing Default Case

Always include

```csharp
default:
```

to handle unsupported types.

---

# Flowchart

```
          Start
             │
             ▼
      Read User Choice
             │
             ▼
      Store as Object
             │
             ▼
      Pattern Match using is
             │
             ▼
      Pattern Match using switch
             │
             ▼
      Display Result
             │
             ▼
             End
```

---

# Real-World Applications

Pattern Matching is widely used in:

- ASP.NET Core
- Entity Framework Core
- Web APIs
- JSON Processing
- Desktop Applications
- Game Development
- Compiler Design
- Data Validation

---

# Interview Questions

## 1. What is Pattern Matching in C#?

Pattern Matching is a feature that combines type checking and type casting into one operation.

---

## 2. What is the `is` operator?

It checks whether an object is of a specified type and can automatically create a typed variable.

---

## 3. What is Pattern Matching in a `switch` statement?

It allows each `case` to match a type instead of only constant values.

---

## 4. What are the advantages of Pattern Matching?

- Cleaner code
- No explicit casting
- Better readability
- Safer runtime behavior
- Easier maintenance

---

## 5. Difference between `is` and `as`?

| `is` | `as` |
|------|------|
| Checks type | Attempts safe cast |
| Returns `bool` (or creates pattern variable) | Returns object or `null` |
| Works with value and reference types | Mainly used with reference/nullable types |

---

## 6. Can Pattern Matching work with classes?

Yes. It works with classes, interfaces, records, structs, and built-in types.

---

## 7. Why is `object` used in this assignment?

Because an `object` variable can store values of different data types, allowing Pattern Matching to determine the runtime type.

---

## 8. Is Pattern Matching compile-time or runtime?

The syntax is checked at compile time, but the type matching happens at runtime based on the actual object.

---

## 9. Can `switch` perform Pattern Matching?

Yes. Modern C# `switch` statements and switch expressions support type patterns and other advanced patterns.

---

## 10. Where is Pattern Matching commonly used?

It is commonly used in ASP.NET Core, Web APIs, Entity Framework Core, desktop applications, and enterprise software to simplify type-based logic.

---

# Summary

In this assignment, you learned:

- Pattern Matching
- `is` Operator
- `switch` Pattern Matching
- Runtime Type Checking
- Type Casting
- Object Class
- Best Practices
- Interview Questions

Pattern Matching is one of the most useful modern C# features. It produces cleaner, safer, and more maintainable code by eliminating unnecessary type casts and making type-dependent logic more expressive.