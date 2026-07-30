# Assignment 8: Use `ref`, `out`, and `in` Parameters

## Objective

Learn how to use the `ref`, `out`, and `in` parameter modifiers in C#. These modifiers allow methods to pass arguments by reference, enabling them to modify, initialize, or safely access variables without copying their values.

---

# Problem Statement

Create a C# program that:

- Uses a method with a `ref` parameter.
- Uses a method with an `out` parameter.
- Uses a method with an `in` parameter.
- Accepts user input.
- Displays values before and after method calls.
- Explains the purpose of each parameter modifier.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Parameter Passing
- Pass by Value
- Pass by Reference
- `ref` Parameters
- `out` Parameters
- `in` Parameters
- Method Arguments
- Memory Efficiency

---

# Prerequisites

You should know:

- Variables
- Methods
- Functions
- User Input
- Return Values
- Basic C# Syntax

---

# Theory

# What are Parameters?

Parameters allow data to be passed from one method to another.

Example

```csharp
Add(10, 20);
```

Here,

```
10

20
```

are arguments passed to the method.

---

# Pass by Value

By default, C# passes variables **by value**.

Example

```csharp
void Increment(int number)
{
    number++;
}
```

```
Original Variable

10

↓

Copy Sent to Method

10

↓

Modified

11

↓

Original

10
```

The original variable remains unchanged.

---

# Pass by Reference

Using `ref`, `out`, or `in`, the method receives a reference to the original variable instead of a copy.

```
Original Variable
        │
        ▼
Method receives reference
        │
        ▼
Same memory location
```

---

# The `ref` Keyword

`ref` passes a variable by reference.

The variable **must already be initialized** before passing it.

Example

```csharp
int number = 10;

Increment(ref number);
```

Method

```csharp
void Increment(ref int number)
{
    number += 10;
}
```

Output

```
Before : 10

Inside : 20

After : 20
```

The original variable changes.

---

# The `out` Keyword

`out` is used when the method must assign a value back to the caller.

The variable **does not need to be initialized** before passing it.

Example

```csharp
int square;

CalculateSquare(5, out square);
```

Method

```csharp
void CalculateSquare(int number, out int square)
{
    square = number * number;
}
```

Output

```
25
```

The method is responsible for assigning the value.

---

# The `in` Keyword

The `in` keyword passes a variable by reference but makes it **read-only** inside the method.

Example

```csharp
DisplayValue(in number);
```

Method

```csharp
void DisplayValue(in int number)
{
    Console.WriteLine(number);
}
```

Attempting to modify the value results in a compilation error.

---

# Comparison of Parameter Types

| Modifier | Passed By | Must Initialize Before Passing? | Can Modify Value? |
|-----------|-----------|---------------------------------|-------------------|
| None | Value | Yes | No |
| `ref` | Reference | Yes | Yes |
| `out` | Reference | No | Yes (must assign) |
| `in` | Reference | Yes | No |

---

# Memory Representation

## Normal Parameter

```
Main()

number = 10

↓

Method receives

10 (copy)
```

---

## ref Parameter

```
Main()

number
   │
   ▼

Method

Same Variable
```

---

## out Parameter

```
Main()

square

↓

Method assigns value

↓

Caller receives initialized value
```

---

## in Parameter

```
Main()

number

↓

Method

Read Only
```

---

# Program Workflow

```
Start
   │
   ▼
Read Number
   │
   ▼
Call Increment(ref)
   │
   ▼
Display Updated Value
   │
   ▼
Read Number
   │
   ▼
Call CalculateSquare(out)
   │
   ▼
Display Square
   │
   ▼
Read Number
   │
   ▼
Call DisplayValue(in)
   │
   ▼
Display Value
   │
   ▼
Print Summary
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Read a number from the user.

```csharp
Console.ReadLine();
```

---

## Step 2

Call

```csharp
Increment(ref num);
```

The original variable is modified.

---

## Step 3

Read another number.

Call

```csharp
CalculateSquare(input, out result);
```

The method calculates the square and assigns it to `result`.

---

## Step 4

Read another number.

Call

```csharp
DisplayValue(in value);
```

The method can read the value but cannot modify it.

---

## Step 5

Display a summary explaining each parameter modifier.

---

# `ref` vs `out` vs `in`

| Feature | `ref` | `out` | `in` |
|----------|-------|--------|-------|
| Passed by Reference | Yes | Yes | Yes |
| Must Initialize Before Call | Yes | No | Yes |
| Method Must Assign Value | No | Yes | No |
| Method Can Modify Value | Yes | Yes | No |
| Read Only | No | No | Yes |

---

# Advantages of `ref`

- Allows modification of the caller's variable.
- Avoids copying large objects.
- Useful when updating values.

---

# Advantages of `out`

- Returns multiple values from a method.
- Useful for calculations.
- Commonly used with `TryParse()` methods.

---

# Advantages of `in`

- Improves performance for large value types.
- Prevents accidental modification.
- Ensures data safety.

---

# Best Practices

✔ Use `ref` only when the method needs to modify an existing value.

✔ Use `out` when the method must return additional values.

✔ Use `in` for read-only access to large value types.

✔ Initialize variables before using `ref` or `in`.

✔ Keep parameter modifiers meaningful and avoid unnecessary usage.

---

# Common Mistakes

### Forgetting to Initialize a `ref` Variable

Incorrect

```csharp
int number;

Increment(ref number);
```

Compilation Error

---

### Not Assigning an `out` Variable

Incorrect

```csharp
void Test(out int value)
{
}
```

Compilation Error

Every `out` parameter must be assigned before the method returns.

---

### Trying to Modify an `in` Parameter

Incorrect

```csharp
void Display(in int number)
{
    number++;
}
```

Compilation Error

`in` parameters are read-only.

---

# Flowchart

```
             Start
                │
                ▼
        Read Number
                │
                ▼
        Call ref Method
                │
                ▼
      Display Updated Value
                │
                ▼
        Read Number
                │
                ▼
        Call out Method
                │
                ▼
      Display Calculated Value
                │
                ▼
        Read Number
                │
                ▼
        Call in Method
                │
                ▼
        Display Value
                │
                ▼
         Print Summary
                │
                ▼
               End
```

---

# Real-World Applications

Parameter modifiers are commonly used in:

- ASP.NET Core
- Entity Framework Core
- Web APIs
- File Processing
- Mathematical Libraries
- Game Development
- High-Performance Applications

Examples include:

- `int.TryParse()` (`out`)
- `Dictionary.TryGetValue()` (`out`)
- Performance-critical methods using `in`

---

# Interview Questions

## 1. What is pass by value?

Pass by value sends a copy of the variable to the method. Changes made inside the method do not affect the original variable.

---

## 2. What is pass by reference?

Pass by reference sends the original variable to the method, allowing the method to work with the same memory location.

---

## 3. What is the `ref` keyword?

`ref` passes a variable by reference. The variable must already be initialized before it is passed.

---

## 4. What is the `out` keyword?

`out` passes a variable by reference and requires the called method to assign a value before returning.

---

## 5. What is the `in` keyword?

`in` passes a variable by reference but prevents the called method from modifying it.

---

## 6. What is the difference between `ref` and `out`?

`ref` requires initialization before the call, while `out` does not. However, `out` parameters must be assigned inside the method.

---

## 7. What is the difference between `ref` and `in`?

Both pass variables by reference, but `ref` allows modification whereas `in` makes the parameter read-only.

---

## 8. Why is `out` commonly used with `TryParse()`?

Because it allows the method to return both the success status (`bool`) and the converted value through an additional parameter.

---

## 9. Can `ref`, `out`, and `in` be used with reference types?

Yes. They modify how the reference itself is passed, not the fact that the object is a reference type.

---

## 10. When should you use `in`?

Use `in` when you want to avoid copying large value types while ensuring the method cannot modify the original value.

---

# Summary

In this assignment, you learned:

- Pass by Value
- Pass by Reference
- `ref` Parameters
- `out` Parameters
- `in` Parameters
- Method Arguments
- Best Practices
- Interview Questions

Understanding `ref`, `out`, and `in` is essential for writing efficient and maintainable C# code. These parameter modifiers are widely used in the .NET Framework, **ASP.NET Core**, **Entity Framework Core**, and enterprise applications to improve performance, return multiple values, and enforce safe parameter handling.