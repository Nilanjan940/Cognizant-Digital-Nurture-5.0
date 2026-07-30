# Assignment 4: Demonstrate Type Inference with `var`

## Objective

Learn how C# performs **type inference** using the `var` keyword for primitive data types, custom objects, and anonymous types. This assignment demonstrates how the compiler automatically determines the type of a variable based on the assigned value.

---

# Problem Statement

Create a C# program that:

- Declares variables using `var` for primitive data types.
- Creates objects using `var`.
- Creates an anonymous type using `var`.
- Displays the values and their inferred runtime types using `GetType()`.
- Discusses when type inference improves readability and when explicit types are preferred.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Type Inference
- `var` Keyword
- Compile-Time Type Inference
- Object Creation using `var`
- Anonymous Types
- `GetType()` Method
- Strongly Typed Variables

---

# Prerequisites

You should know:

- Variables
- Data Types
- Classes and Objects
- Constructors
- Methods
- Properties

---

# Theory

# What is Type Inference?

Type inference means that the **C# compiler automatically determines the data type** of a variable based on the value assigned to it.

Instead of writing

```csharp
int number = 100;
```

we can simply write

```csharp
var number = 100;
```

The compiler infers that `number` is of type `int`.

---

# What is `var`?

`var` is a keyword that tells the compiler to determine the variable's type automatically.

Example

```csharp
var number = 100;
```

Compiler interprets it as

```csharp
int number = 100;
```

Similarly,

```csharp
var message = "Welcome";
```

becomes

```csharp
string message = "Welcome";
```

---

# Is `var` a Data Type?

No.

`var` is **not** a data type.

It is only a keyword that enables **compile-time type inference**.

Once the compiler determines the type, it cannot change.

Example

```csharp
var number = 100;
```

The compiler treats it as

```csharp
int number = 100;
```

Later,

```csharp
number = 200;
```

is valid.

But

```csharp
number = "Hello";
```

produces a compilation error because `number` is an integer.

---

# Using `var` with Primitive Types

Examples

```csharp
var number = 100;
```

Type → `int`

---

```csharp
var message = "Welcome";
```

Type → `string`

---

```csharp
var price = 999.99;
```

Type → `double`

---

# Using `var` with Custom Classes

The `var` keyword can also be used when creating objects.

Example

```csharp
var student = new Student("Alice", 21);
```

The compiler automatically infers that `student` is of type `Student`.

This makes the code shorter while still being strongly typed.

---

# Anonymous Types

Anonymous types allow us to create objects without defining a class.

Example

```csharp
var employee = new
{
    Id = 101,
    Name = "David",
    Department = "IT"
};
```

The compiler creates the type automatically.

Anonymous types are useful for:

- LINQ queries
- Temporary objects
- Read-only data

---

# Runtime Type Identification

The `GetType()` method returns the runtime type of an object.

Example

```csharp
Console.WriteLine(number.GetType());
```

Output

```
System.Int32
```

Similarly,

```csharp
Console.WriteLine(message.GetType());
```

Output

```
System.String
```

---

# Program Workflow

```
Start
   │
   ▼
Declare Primitive Variables using var
   │
   ▼
Display Values and Types
   │
   ▼
Create Student Object using var
   │
   ▼
Display Student Details
   │
   ▼
Create Another Student Object using var
   │
   ▼
Display Student Details
   │
   ▼
Create Anonymous Object
   │
   ▼
Display Anonymous Object Properties
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Create primitive variables using `var`.

```csharp
var number = 100;
var message = "Welcome to C#";
var price = 999.99;
```

The compiler automatically infers their data types.

---

## Step 2

Display their values and runtime types.

```csharp
number.GetType();
```

---

## Step 3

Create a `Student` object using `var`.

```csharp
var student1 = new Student("Alice", 21);
```

The compiler infers the type as `Student`.

---

## Step 4

Create another `Student` object using `var`.

```csharp
var student2 = new Student("Bob", 22);
```

Again, the compiler infers the type as `Student`.

---

## Step 5

Create an anonymous object.

```csharp
var employee = new
{
    Id = 101,
    Name = "David",
    Department = "IT"
};
```

---

## Step 6

Display the anonymous object's properties.

---

# `var` vs Explicit Type

| `var` | Explicit Type |
|--------|---------------|
| Compiler infers the type | Programmer specifies the type |
| Less code | More descriptive |
| Easier to write | Easier to understand in some cases |
| Strongly typed | Strongly typed |

---

# `var` vs `dynamic`

| `var` | `dynamic` |
|--------|-----------|
| Compile-time type | Runtime type |
| Strongly typed | Dynamically typed |
| Compiler checks errors | Errors occur at runtime |
| Better performance | Slightly slower |

---

# Advantages of Using `var`

- Reduces code verbosity.
- Makes object creation cleaner.
- Improves readability when the type is obvious.
- Required when using anonymous types.
- Commonly used with LINQ.

---

# Advantages of Anonymous Types

- No need to create a separate class.
- Quick and convenient.
- Read-only properties.
- Frequently used in LINQ projections.

---

# Best Practices

✔ Use `var` when the type is obvious from the right-hand side.

✔ Use explicit types when they improve readability.

✔ Use anonymous types for temporary data.

✔ Avoid overusing `var` when it makes the code difficult to understand.

✔ Use meaningful variable names.

---

# Common Mistakes

### Declaring `var` Without Initialization

Incorrect

```csharp
var number;
```

Correct

```csharp
var number = 100;
```

---

### Assuming `var` is Dynamic

Incorrect.

`var` is strongly typed.

---

### Assigning a Different Type Later

Incorrect

```csharp
var number = 100;
number = "Hello";
```

Compilation Error

---

### Trying to Modify Anonymous Type Structure

Anonymous types are immutable.

You cannot add or remove properties after creation.

---

# Flowchart

```
           Start
              │
              ▼
 Create Primitive Variables
              │
              ▼
 Display Runtime Types
              │
              ▼
 Create Student Objects
              │
              ▼
 Display Student Details
              │
              ▼
 Create Anonymous Object
              │
              ▼
 Display Anonymous Data
              │
              ▼
              End
```

---

# Real-World Applications

Type inference is widely used in:

- ASP.NET Core
- Entity Framework Core
- LINQ Queries
- Web APIs
- Blazor
- Console Applications
- Desktop Applications
- Cloud Applications

Anonymous types are commonly used in:

- LINQ Projections
- Data Transformations
- API Responses
- Reporting Applications

---

# Interview Questions

## 1. What is type inference in C#?

Type inference is the process where the compiler automatically determines a variable's data type based on its assigned value.

---

## 2. What is `var`?

`var` is a keyword that enables compile-time type inference. It is **not** a data type.

---

## 3. Is `var` strongly typed?

Yes.

Variables declared with `var` are strongly typed. Their type is determined during compilation and cannot change later.

---

## 4. Can `var` be used with custom classes?

Yes.

Example

```csharp
var student = new Student("Alice", 21);
```

The compiler infers the type as `Student`.

---

## 5. Can `var` be used with anonymous types?

Yes.

In fact, `var` is required because anonymous types do not have an explicit type name.

---

## 6. What does `GetType()` do?

`GetType()` returns the runtime type of an object.

Example

```csharp
Console.WriteLine(number.GetType());
```

Output

```
System.Int32
```

---

## 7. What is an anonymous type?

An anonymous type is a compiler-generated class created without explicitly defining a class.

---

## 8. What is the difference between `var` and `dynamic`?

`var` is compile-time typed, whereas `dynamic` resolves types at runtime.

---

## 9. Does using `var` improve performance?

No.

`var` only reduces code verbosity. The compiled code is the same as using explicit types.

---

## 10. Where is `var` commonly used?

- LINQ
- Entity Framework Core
- ASP.NET Core
- Web APIs
- Blazor
- Generic Collections
- Anonymous Types

---

# Summary

In this assignment, you learned:

- Type Inference
- `var` Keyword
- Compile-Time Type Inference
- Object Creation using `var`
- Anonymous Types
- Runtime Type Identification using `GetType()`
- Best Practices
- Interview Questions

Type inference is an important feature of modern C#. It helps reduce boilerplate code while maintaining strong typing. The `var` keyword is widely used in **ASP.NET Core**, **Entity Framework Core**, **LINQ**, **Blazor**, and many other .NET applications to write cleaner and more maintainable code.