
````markdown
# Assignment 5: Perform Conditional Logic for Grade Calculation

## Objective

Learn how to make decisions in C# using conditional statements. This assignment demonstrates the use of **if-else statements**, **switch expressions**, and **pattern matching** to calculate grades based on student marks.

---

# Problem Statement

Create a C# program that:

- Accepts marks from the user.
- Validates the input.
- Determines the grade using an **if-else ladder**.
- Determines the grade again using a **switch expression with pattern matching**.
- Displays the calculated grade.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Conditional Statements
- if Statement
- if-else Ladder
- switch Expression
- Pattern Matching
- Input Validation
- int.TryParse()
- Relational Patterns

---

# Prerequisites

You should know:

- Variables
- Operators
- User Input
- Methods
- Basic C# Syntax

---

# Theory

# What are Conditional Statements?

Conditional statements allow a program to make decisions based on whether a condition is true or false.

General flow

```
Condition
    │
 ┌──┴──┐
 │     │
True  False
 │      │
Execute  Execute
Block A  Block B
```

---

# if Statement

The `if` statement executes a block of code only if the specified condition is true.

Syntax

```csharp
if(condition)
{
    // code
}
```

Example

```csharp
if(marks >= 50)
{
    Console.WriteLine("Pass");
}
```

---

# if-else Statement

The `else` block executes when the condition is false.

Example

```csharp
if(marks >= 50)
{
    Console.WriteLine("Pass");
}
else
{
    Console.WriteLine("Fail");
}
```

---

# if-else-if Ladder

Used when multiple conditions need to be checked.

Example

```csharp
if(marks >= 90)
{
    grade = "A+";
}
else if(marks >= 80)
{
    grade = "A";
}
else
{
    grade = "F";
}
```

The conditions are checked from top to bottom.

As soon as one condition is true, the remaining conditions are skipped.

---

# switch Expression

Introduced in modern C#, the switch expression provides a concise way to select values based on patterns.

Example

```csharp
string grade = marks switch
{
    >= 90 => "A+",
    >= 80 => "A",
    _ => "F"
};
```

This replaces long if-else ladders in many scenarios.

---

# Pattern Matching

Pattern matching allows conditions to be written in a more readable way.

Example

```csharp
>= 90 => "A+"
```

This is called a **Relational Pattern**.

Instead of writing

```csharp
if(marks >= 90)
```

the switch expression directly checks the condition.

---

# Relational Patterns

C# supports relational operators inside switch expressions.

Examples

```csharp
>= 90
<= 50
> 70
< 20
```

These patterns improve readability.

---

# Input Validation

Instead of directly converting input,

```csharp
Convert.ToInt32()
```

this program uses

```csharp
int.TryParse()
```

Advantages

- Prevents runtime exceptions.
- Safely checks if the input is numeric.
- Returns `true` if conversion succeeds.
- Returns `false` if conversion fails.

Example

```csharp
int.TryParse(Console.ReadLine(), out int marks)
```

---

# Why Validate Input?

Suppose the user enters

```
ABC
```

Using

```csharp
Convert.ToInt32()
```

throws an exception.

Using

```csharp
TryParse()
```

simply returns

```
false
```

allowing the program to handle invalid input gracefully.

---

# Program Workflow

```
Start
   │
   ▼
Read Marks
   │
   ▼
Validate Input
   │
   ▼
Valid?
 ┌──┴──┐
 │     │
No    Yes
 │      │
Display  Calculate Grade
Error    using if-else
 │         │
 │         ▼
 │   Calculate Grade
 │   using switch
 └──────┬───────
        ▼
 Display Grades
        │
        ▼
       End
```

---

# Program Explanation

## Step 1

Accept marks from the user.

```csharp
Console.ReadLine();
```

---

## Step 2

Validate input.

```csharp
int.TryParse(...)
```

Also ensure the marks are between **0 and 100**.

---

## Step 3

Calculate the grade using an if-else ladder.

```csharp
if(marks >= 90)
```

---

## Step 4

Calculate the grade using a switch expression.

```csharp
marks switch
```

---

## Step 5

Display both results.

---

# if-else vs switch Expression

| if-else | switch Expression |
|----------|-------------------|
| More verbose | More concise |
| Better for complex logic | Better for value-based decisions |
| Easier for beginners | Modern C# syntax |
| Multiple statements | Single expression |

---

# switch Statement vs switch Expression

Traditional

```csharp
switch(choice)
{
    case 1:
        break;
}
```

Modern

```csharp
choice switch
{
    1 => "One",
    _ => "Other"
};
```

Switch expressions are shorter and more readable.

---

# Advantages of Pattern Matching

- Cleaner syntax
- Easier to read
- Less code
- More expressive
- Supports relational conditions

---

# Advantages of TryParse()

- Prevents exceptions
- Safer user input handling
- Improves application reliability
- Recommended over `Convert.ToInt32()` for user input

---

# Best Practices

✔ Validate all user input.

✔ Prefer `TryParse()` over `Convert.ToInt32()` when reading user input.

✔ Use switch expressions for simple decision-making.

✔ Use meaningful variable names.

✔ Keep conditions ordered from highest to lowest when assigning grades.

---

# Common Mistakes

### Using Convert.ToInt32()

Incorrect

```csharp
int marks = Convert.ToInt32(Console.ReadLine());
```

This throws an exception for invalid input.

Better

```csharp
int.TryParse(...)
```

---

### Forgetting Range Validation

Always ensure marks are between **0 and 100**.

---

### Incorrect Condition Order

Incorrect

```csharp
if(marks >= 50)
```

before

```csharp
if(marks >= 90)
```

The higher grade conditions would never execute.

---

### Forgetting the Default Case

Always include

```csharp
_ => "F"
```

to handle all remaining cases.

---

# Flowchart

```
            Start
               │
               ▼
        Read User Input
               │
               ▼
      Validate Input
               │
        ┌──────┴──────┐
        │             │
     Invalid        Valid
        │             │
        ▼             ▼
   Display Error   Calculate Grade
                    using if-else
                         │
                         ▼
                 Calculate Grade
                 using switch
                         │
                         ▼
                  Display Results
                         │
                         ▼
                        End
```

---

# Real-World Applications

Conditional logic is widely used in:

- Student Result Systems
- Banking Applications
- Payroll Systems
- Shopping Discounts
- Authentication Systems
- Attendance Management
- Online Examinations
- Business Rule Engines

Pattern matching is commonly used in:

- ASP.NET Core
- Web APIs
- Entity Framework Core
- Modern C# Applications

---

# Interview Questions

## 1. What is an if-else ladder?

An if-else ladder checks multiple conditions sequentially until one condition evaluates to true.

---

## 2. What is a switch expression?

A switch expression is a concise alternative to a traditional switch statement that returns a value based on matching patterns.

---

## 3. What is pattern matching in C#?

Pattern matching allows objects or values to be tested against specific patterns such as constants, types, or relational conditions.

---

## 4. What are relational patterns?

Relational patterns compare values using operators such as:

```text
>
<
>=
<=
```

Example

```csharp
>= 90 => "A+"
```

---

## 5. Why is `TryParse()` preferred over `Convert.ToInt32()`?

`TryParse()` safely handles invalid input without throwing exceptions, making programs more robust.

---

## 6. What is the purpose of the `_` symbol in a switch expression?

The underscore (`_`) is the discard pattern. It acts as the default case and matches any value not handled by previous patterns.

---

## 7. Can pattern matching replace if-else statements?

For many value-based decisions, yes. However, complex logic may still be better suited to if-else statements.

---

## 8. Which C# version introduced switch expressions?

Switch expressions were introduced in **C# 8.0**.

---

## 9. What happens if the conditions in an if-else ladder are ordered incorrectly?

Earlier conditions may match first, preventing later conditions from executing and producing incorrect results.

---

## 10. Where are switch expressions commonly used?

- ASP.NET Core
- Web APIs
- Entity Framework Core
- LINQ
- Console Applications
- Business Rule Processing

---

# Summary

In this assignment, you learned:

- Conditional Statements
- if-else Ladder
- switch Expression
- Pattern Matching
- Relational Patterns
- Input Validation
- `int.TryParse()`
- Best Practices
- Interview Questions

Conditional logic is one of the most fundamental concepts in programming. Modern C# enhances decision-making with **switch expressions** and **pattern matching**, resulting in cleaner, safer, and more maintainable code. These features are widely used in **ASP.NET Core**, **Web APIs**, **Entity Framework Core**, and enterprise .NET applications.
````
