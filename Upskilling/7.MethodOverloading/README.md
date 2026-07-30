# Assignment 7: Implement Method Overloading

## Objective

Learn how to implement **method overloading** in C#. This assignment demonstrates how multiple methods can have the **same name** but different parameter lists, allowing the compiler to determine which method to invoke based on the arguments passed.

---

# Problem Statement

Create a C# program that:

- Defines multiple methods named `CalculateTotal`.
- Uses different numbers and types of parameters.
- Calls each overloaded method from `Main()`.
- Displays the calculated totals.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Method Overloading
- Method Signature
- Compile-Time Polymorphism
- Function Parameters
- Return Types
- Object Creation
- Static vs Instance Methods

---

# Prerequisites

You should know:

- Variables
- Methods
- Classes
- Objects
- Parameters
- Return Values

---

# Theory

# What is a Method?

A method is a block of code that performs a specific task.

Example

```csharp
public int Add(int a, int b)
{
    return a + b;
}
```

Methods improve:

- Code reusability
- Readability
- Maintainability

---

# What is Method Overloading?

Method overloading means defining **multiple methods with the same name** in the same class but with different parameter lists.

Example

```csharp
CalculateTotal(int a, int b)
```

and

```csharp
CalculateTotal(double a, double b)
```

Both methods have the same name but different signatures.

---

# What is a Method Signature?

A method signature consists of:

- Method name
- Number of parameters
- Data types of parameters
- Order of parameters

The **return type is NOT part of the method signature**.

Example

```csharp
Add(int a, int b)
```

and

```csharp
Add(double a, double b)
```

are valid overloads.

---

# Types of Method Overloading

## Different Number of Parameters

```csharp
CalculateTotal(int a, int b)
```

```csharp
CalculateTotal(int a, int b, int c)
```

---

## Different Data Types

```csharp
CalculateTotal(int a, int b)
```

```csharp
CalculateTotal(double a, double b)
```

---

## Different Number and Type of Parameters

```csharp
CalculateTotal(double a, double b, double c)
```

---

# Your Overloaded Methods

Method 1

```csharp
CalculateTotal(int num1, int num2)
```

Adds two integers.

---

Method 2

```csharp
CalculateTotal(double num1, double num2, double num3)
```

Adds three double values.

---

Method 3

```csharp
CalculateTotal(int num1, int num2, int num3)
```

Adds three integers.

---

Method 4

```csharp
CalculateTotal(double num1, double num2)
```

Adds two double values.

---

# Compile-Time Polymorphism

Method overloading is also called **Compile-Time Polymorphism** or **Static Polymorphism**.

The compiler decides which method to execute based on the arguments.

Example

```csharp
calculator.CalculateTotal(10,20);
```

Compiler selects

```csharp
CalculateTotal(int,int)
```

Example

```csharp
calculator.CalculateTotal(10.5,20.5);
```

Compiler selects

```csharp
CalculateTotal(double,double)
```

---

# Why Return Types Don't Matter

This is NOT allowed

```csharp
int Calculate()
```

```csharp
double Calculate()
```

Only changing the return type does not create a new method signature.

---

# Program Workflow

```
Start
   │
   ▼
Create Calculator Object
   │
   ▼
Call CalculateTotal(int,int)
   │
   ▼
Display Result
   │
   ▼
Call CalculateTotal(double,double,double)
   │
   ▼
Display Result
   │
   ▼
Call CalculateTotal(int,int,int)
   │
   ▼
Display Result
   │
   ▼
Call CalculateTotal(double,double)
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

Create the `Calculator` class.

```csharp
class Calculator
```

---

## Step 2

Define four overloaded methods.

Each method has the same name:

```csharp
CalculateTotal()
```

but different parameters.

---

## Step 3

Create a Calculator object.

```csharp
Calculator calculator = new Calculator();
```

---

## Step 4

Call each overloaded method.

The compiler automatically selects the correct method based on the supplied arguments.

---

## Step 5

Display the returned totals.

---

# Method Overloading vs Method Overriding

| Method Overloading | Method Overriding |
|--------------------|-------------------|
| Same class | Parent and child classes |
| Same method name | Same method name |
| Different parameters | Same parameters |
| Compile-time polymorphism | Runtime polymorphism |
| No inheritance required | Requires inheritance |

---

# Advantages of Method Overloading

- Improves code readability
- Avoids multiple method names
- Increases code reusability
- Makes APIs easier to use
- Supports compile-time polymorphism

---

# Best Practices

✔ Use the same method name for related operations.

✔ Overload methods only when they perform similar tasks.

✔ Keep parameter lists meaningful.

✔ Avoid creating ambiguous overloads.

✔ Use descriptive parameter names.

---

# Common Mistakes

### Changing Only the Return Type

Incorrect

```csharp
int Add(int a, int b)
```

```csharp
double Add(int a, int b)
```

Compilation Error

---

### Creating Ambiguous Overloads

Avoid overloads that the compiler cannot distinguish clearly.

---

### Using Different Method Names

Instead of

```csharp
AddTwoNumbers()

AddThreeNumbers()
```

prefer

```csharp
Add()
```

with overloads.

---

# Flowchart

```
              Start
                 │
                 ▼
      Create Calculator Object
                 │
                 ▼
     Call Overloaded Method
                 │
                 ▼
 Compiler Matches Signature
                 │
                 ▼
 Execute Correct Method
                 │
                 ▼
 Return Total
                 │
                 ▼
 Display Result
                 │
                 ▼
                End
```

---

# Real-World Applications

Method overloading is widely used in:

- ASP.NET Core
- Entity Framework Core
- Web APIs
- Mathematical Libraries
- File Handling
- String Manipulation
- Graphics Programming
- Game Development

Examples from the .NET Framework include methods like `Console.WriteLine()`, `Math.Round()`, and `String.IndexOf()`, all of which have multiple overloaded versions.

---

# Interview Questions

## 1. What is method overloading?

Method overloading is the process of defining multiple methods with the same name but different parameter lists within the same class.

---

## 2. What is compile-time polymorphism?

Compile-time polymorphism is the ability of the compiler to decide which overloaded method should be executed based on the method signature.

---

## 3. What is a method signature?

A method signature includes:

- Method name
- Number of parameters
- Data types of parameters
- Order of parameters

It does **not** include the return type.

---

## 4. Can methods be overloaded by changing only the return type?

No.

Changing only the return type does not create a new method signature.

---

## 5. What are the ways to overload a method?

- Change the number of parameters.
- Change the data types of parameters.
- Change the order of parameter types.

---

## 6. Is inheritance required for method overloading?

No.

Method overloading occurs within the same class and does not require inheritance.

---

## 7. What is the difference between method overloading and method overriding?

Method overloading occurs in the same class with different parameter lists and is resolved at compile time. Method overriding occurs in a derived class with the same method signature and is resolved at runtime.

---

## 8. Can constructors be overloaded?

Yes.

Constructors can also be overloaded by using different parameter lists.

---

## 9. How does the compiler choose which overloaded method to call?

The compiler compares the arguments supplied with each method's signature and selects the best matching overload.

---

## 10. Where is method overloading commonly used?

Method overloading is commonly used in the .NET Framework, including classes such as `Console`, `Math`, `String`, and many ASP.NET Core libraries.

---

# Summary

In this assignment, you learned:

- Method Overloading
- Method Signature
- Compile-Time Polymorphism
- Function Parameters
- Return Types
- Object-Oriented Programming Basics
- Best Practices
- Interview Questions

Method overloading is one of the core features of Object-Oriented Programming in C#. It improves readability, promotes code reuse, and enables compile-time polymorphism. It is widely used throughout the .NET Framework and is an essential concept for developing **ASP.NET Core**, **Entity Framework Core**, **Web API**, and enterprise applications.