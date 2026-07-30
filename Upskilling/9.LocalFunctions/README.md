# Assignment 9: Use Local Functions

## Objective

Learn how to define and use **local functions** in C#. This assignment demonstrates the use of a local function to calculate the factorial of a number using recursion.

---

# Problem Statement

Create a C# program that:

- Accepts a non-negative integer from the user.
- Uses a method named `CalculateFactorial()`.
- Defines a **local function** inside `CalculateFactorial()`.
- Calculates the factorial using recursion.
- Displays the result.
- Handles invalid (negative) input gracefully.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Local Functions
- Recursion
- Factorial
- Method Scope
- Input Validation
- Recursive Algorithms
- Return Values

---

# Prerequisites

You should know:

- Variables
- Methods
- Conditional Statements
- Recursion
- User Input
- Basic C# Syntax

---

# Theory

# What is a Local Function?

A local function is a function declared **inside another method**.

Unlike normal methods, a local function is accessible **only within the method in which it is declared**.

Example

```csharp
void Display()
{
    void Message()
    {
        Console.WriteLine("Hello");
    }

    Message();
}
```

The function `Message()` cannot be called outside `Display()`.

---

# Why Use Local Functions?

Local functions help to:

- Keep helper logic private.
- Improve code readability.
- Reduce unnecessary class-level methods.
- Organize related functionality.
- Improve maintainability.

---

# What is Recursion?

Recursion is a programming technique where a function calls itself to solve a problem.

Example

```csharp
Factorial(5)
```

calls

```
Factorial(4)

↓

Factorial(3)

↓

Factorial(2)

↓

Factorial(1)

↓

Factorial(0)
```

After reaching the base case, the calls return one by one.

---

# What is Factorial?

The factorial of a non-negative integer `n` is the product of all positive integers from `1` to `n`.

Mathematically,

```
n! = n × (n − 1) × (n − 2) × ... × 1
```

Examples

```
0! = 1

1! = 1

3! = 6

5! = 120

7! = 5040
```

---

# Recursive Formula

```
Factorial(n)

=

n × Factorial(n−1)
```

Base Case

```
Factorial(0) = 1
```

Without the base case, recursion would continue indefinitely, resulting in a stack overflow.

---

# Input Validation

Your program checks whether the entered number is negative.

```csharp
if(number < 0)
{
    Console.WriteLine("Factorial is not defined for negative numbers.");
    return -1;
}
```

This prevents invalid calculations and provides meaningful feedback to the user.

---

# Program Workflow

```
Start
   │
   ▼
Read Number
   │
   ▼
Is Number Negative?
   │
 ┌─┴─────────┐
 │           │
Yes         No
 │           │
 ▼           ▼
Display    Call Local
Error      Function
 │           │
 └─────┬─────┘
       ▼
Calculate Factorial
       │
       ▼
Display Result
       │
       ▼
End
```

---

# Program Explanation

## Step 1

Accept a non-negative integer from the user.

```csharp
Console.ReadLine();
```

---

## Step 2

Call

```csharp
CalculateFactorial(input);
```

---

## Step 3

Inside `CalculateFactorial()`, validate the input.

If the number is negative,

```csharp
return -1;
```

---

## Step 4

Define a local function named `Factorial()`.

```csharp
long Factorial(int n)
```

This function exists only inside `CalculateFactorial()`.

---

## Step 5

The local function calculates the factorial recursively.

```csharp
return n * Factorial(n - 1);
```

---

## Step 6

Return the calculated value to the caller.

---

# Local Function vs Normal Method

| Local Function | Normal Method |
|----------------|---------------|
| Declared inside another method | Declared inside a class |
| Accessible only within the enclosing method | Accessible throughout the class (depending on access modifier) |
| Used for helper logic | Used for reusable functionality |
| Improves encapsulation | More general purpose |

---

# Recursion vs Iteration

| Recursion | Iteration |
|------------|-----------|
| Function calls itself | Uses loops |
| Easier to understand for some algorithms | Usually more memory efficient |
| Uses call stack | Uses loop variables |
| Requires a base case | Requires a loop condition |

---

# Advantages of Local Functions

- Better code organization.
- Improved readability.
- Limits helper methods to where they are needed.
- Reduces unnecessary public/private methods.
- Can access local variables of the enclosing method.

---

# Advantages of Recursion

- Elegant solution for mathematical problems.
- Simplifies divide-and-conquer algorithms.
- Useful for tree and graph traversal.
- Reduces code complexity for recursive problems.

---

# Best Practices

✔ Use local functions only when they are needed within a single method.

✔ Always define a proper base case in recursive functions.

✔ Validate user input before processing.

✔ Use descriptive method names.

✔ Keep recursion simple and readable.

---

# Common Mistakes

### Missing Base Case

Incorrect

```csharp
return n * Factorial(n - 1);
```

without

```csharp
if(n == 0)
    return 1;
```

This causes infinite recursion and a `StackOverflowException`.

---

### Ignoring Negative Input

Factorial is not defined for negative integers.

Always validate input before calculation.

---

### Declaring the Helper as a Class Method

If the helper function is used only by one method, a local function is cleaner and better encapsulated.

---

### Using `int` for Large Factorials

Factorials grow very quickly.

Using `long` increases the range, though extremely large factorials will still overflow.

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
      ┌────────┴────────┐
      │                 │
 Negative          Non-negative
      │                 │
      ▼                 ▼
 Display Error   Call Local Function
                         │
                         ▼
                Recursive Calculation
                         │
                         ▼
                 Return Result
                         │
                         ▼
                  Display Result
                         │
                         ▼
                        End
```

---

# Real-World Applications

Local functions and recursion are commonly used in:

- Mathematical Computations
- Tree Traversal
- Binary Search Trees
- Graph Algorithms
- File System Navigation
- Dynamic Programming
- Compiler Design
- Expression Evaluation

Local functions are also used in modern C# applications to keep helper logic private and improve code readability.

---

# Interview Questions

## 1. What is a local function?

A local function is a function declared inside another method and is accessible only within that method.

---

## 2. Why use local functions?

They improve encapsulation, reduce unnecessary class-level methods, and keep helper logic close to where it is used.

---

## 3. What is recursion?

Recursion is a technique where a function calls itself until a base condition is reached.

---

## 4. What is the base case in recursion?

The base case is the condition that stops recursive calls. Without it, recursion continues indefinitely.

---

## 5. What is the factorial of 0?

The factorial of 0 is defined as:

```
0! = 1
```

---

## 6. Why is input validation important in this program?

Factorial is not defined for negative integers. Validation prevents invalid calculations and improves program reliability.

---

## 7. Can a local function access variables from its enclosing method?

Yes. Local functions can directly access local variables and parameters of the enclosing method.

---

## 8. What exception may occur if recursion never ends?

A `StackOverflowException` may occur due to excessive recursive calls.

---

## 9. Why is `long` used instead of `int`?

`long` can store much larger values than `int`, making it more suitable for factorial calculations, although it also has limits.

---

## 10. Where are local functions commonly used?

They are used in helper methods, recursive algorithms, LINQ queries, parsers, mathematical computations, and other situations where functionality is needed only within a single method.

---

# Summary

In this assignment, you learned:

- Local Functions
- Recursion
- Factorial Calculation
- Method Scope
- Input Validation
- Recursive Algorithms
- Best Practices
- Interview Questions

Local functions provide a clean way to organize helper logic within a method, while recursion offers an elegant solution for problems such as factorial calculation. Together, these features help create readable, maintainable, and efficient C# programs.