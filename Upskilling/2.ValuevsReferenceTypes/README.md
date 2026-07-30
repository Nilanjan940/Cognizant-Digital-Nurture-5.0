# Assignment 2: Explore Value Types vs Reference Types

## Objective

Learn the difference between **Value Types** and **Reference Types** in C# by observing how they behave when passed to methods.

This assignment also demonstrates why **string**, although a reference type, behaves differently because it is **immutable**.

---

# Problem Statement

Create a C# program that:

- Declares variables using value types (`int`, `double`)
- Declares a custom reference type (`Person`)
- Creates methods to modify both value types and reference types
- Demonstrates how changes affect the original variables
- Shows how strings behave when passed to methods

---

# Learning Outcomes

After completing this assignment, you will understand:

- Value Types
- Reference Types
- Stack Memory
- Heap Memory
- Pass by Value
- Object References
- String Immutability
- Method Parameters

---

# Prerequisites

You should know:

- Variables
- Methods
- Classes and Objects
- Properties
- Basic Memory Concepts

---

# Theory

# What are Data Types?

Every variable in C# belongs to a data type.

They are mainly divided into two categories:

- Value Types
- Reference Types

```
             Data Types
                 │
      ┌──────────┴──────────┐
      │                     │
 Value Types         Reference Types
```

---

# Value Types

A value type stores the **actual value** directly inside the variable.

Examples

```csharp
int
double
float
char
bool
decimal
struct
enum
```

Example

```csharp
int number = 10;
```

Memory

```
number
-------
| 10 |
-------
```

---

# Characteristics of Value Types

- Store actual data
- Stored on the stack (typically for local variables)
- Faster access
- Each variable has its own copy
- Changes inside methods do not affect the original variable when passed by value

---

# Reference Types

Reference types store the **address (reference)** of an object instead of the object itself.

Examples

```csharp
class
object
array
delegate
string
interface
record (class)
```

Example

```csharp
Person person = new Person();
```

Memory

```
Stack

person
------
| ● | ----------------------+

Heap                           |
----------------------------    |
Name = John                     |
Age = 25                        |
---------------------------- <---+
```

---

# Characteristics of Reference Types

- Store references
- Objects are allocated on the heap
- Multiple variables can reference the same object
- Changes through one reference affect the original object

---

# Value Type Example

```csharp
int number = 10;
ModifyValueType(number);
```

Method

```csharp
static void ModifyValueType(int number)
{
    number = 100;
}
```

Output

```
Before = 10
Inside = 100
After = 10
```

Why?

Because only a copy of the value is passed.

---

# Reference Type Example

```csharp
Person person = new Person();
ModifyReferenceType(person);
```

Method

```csharp
person.Name = "Alex";
```

Output

```
Before = John
Inside = Alex
After = Alex
```

Why?

Because both variables refer to the same object in memory.

---

# Why Does String Behave Differently?

One of the most common interview questions.

Many developers think strings behave like value types.

Actually,

**String is a Reference Type.**

```csharp
string name = "John";
```

But strings are **immutable**.

Immutable means

> Once created, a string object cannot be changed.

Instead,

```csharp
text = "Alex";
```

creates a **new string object**.

The original string remains unchanged.

Output

```
Before : John

Inside : Alex

After : John
```

---

# What is Immutability?

Immutable means

> An object's state cannot be modified after it is created.

Example

```csharp
string name = "John";
name = "Alex";
```

Memory

```
Before

Stack
name -----> "John"

After

Stack
name -----> "Alex"

Old object

"John"
```

A new object is created.

The old object is left unchanged.

---

# Stack vs Heap

## Stack

Stores

- Local variables
- Method calls
- Value types

Characteristics

- Fast
- Automatically managed
- Small memory

---

## Heap

Stores

- Objects
- Arrays
- Strings
- Classes

Characteristics

- Larger
- Managed by Garbage Collector

---

# Pass by Value

Default behavior in C#

```
Original

10

↓

Method

10

(copy)

↓

Modified

100

Original remains

10
```

---

# Pass by Reference

Objects are passed by reference (the reference itself is passed by value).

```
Original

Reference
    │
    ▼

Person Object

↓

Method changes object

↓

Original object changes
```

---

# Program Explanation

## Step 1

Create the Person class.

```csharp
class Person
```

---

## Step 2

Create a value type variable.

```csharp
int number = 10;
```

---

## Step 3

Pass it to

```csharp
ModifyValueType()
```

Only a copy is modified.

---

## Step 4

Create a Person object.

```csharp
Person person
```

---

## Step 5

Modify its properties.

```csharp
person.Name
```

Original object changes.

---

## Step 6

Create a string.

```csharp
string name = "John";
```

---

## Step 7

Pass it to

```csharp
ChangeString()
```

Because strings are immutable, the original string remains unchanged.

---

# Output Explanation

### Value Type

```
Before = 10

Inside = 100

After = 10
```

Original variable is unchanged.

---

### Reference Type

```
Before = John

Inside = Alex

After = Alex
```

Original object is modified.

---

### String

```
Before = John

Inside = Alex

After = John
```

The original string remains unchanged because strings are immutable.

---

# Value Type vs Reference Type

| Feature | Value Type | Reference Type |
|----------|------------|----------------|
| Stores | Actual Value | Memory Address |
| Memory | Stack (typically for locals) | Heap (object) |
| Copy Behavior | Copies Value | Copies Reference |
| Modification | Doesn't affect original | Affects original object |
| Speed | Faster | Slightly Slower |
| Null Allowed | Nullable variants only | Yes |

---

# String vs Other Reference Types

| String | Person |
|---------|--------|
| Reference Type | Reference Type |
| Immutable | Mutable |
| New object created on modification | Same object modified |
| Original unchanged | Original changes |

---

# Advantages of Value Types

- Fast
- Less memory overhead
- Independent copies
- Good for small data

---

# Advantages of Reference Types

- Efficient for large objects
- Supports inheritance
- Supports polymorphism
- Dynamic memory allocation

---

# Best Practices

✔ Use value types for simple data.

✔ Use classes for complex objects.

✔ Remember that strings are immutable.

✔ Avoid unnecessary object creation.

✔ Understand stack and heap memory.

---

# Common Mistakes

### Assuming String is a Value Type

Incorrect.

String is a **Reference Type**.

---

### Thinking Strings Change

```csharp
name = "Alex";
```

does not modify the existing string.

It creates a new string object.

---

### Forgetting Pass-by-Value

This

```csharp
ModifyValueType(number);
```

does not modify the original variable.

---

# Flowchart

```
             Start
                │
                ▼
      Create Value Type
                │
                ▼
      Pass to Method
                │
                ▼
      Original Unchanged
                │
                ▼
     Create Person Object
                │
                ▼
      Pass to Method
                │
                ▼
      Object Modified
                │
                ▼
      Create String
                │
                ▼
      Pass to Method
                │
                ▼
 New String Created
                │
                ▼
 Original Unchanged
                │
                ▼
               End
```

---

# Real-World Applications

Understanding value and reference types is essential in:

- ASP.NET Core
- Entity Framework Core
- Web APIs
- Desktop Applications
- Game Development
- Microservices
- Cloud Applications
- High-performance systems

---

# Interview Questions

## 1. What is a Value Type?

A value type stores the actual value directly in the variable.

Examples include `int`, `double`, `bool`, and `struct`.

---

## 2. What is a Reference Type?

A reference type stores the address of an object located on the heap.

Examples include `class`, `string`, `array`, and `object`.

---

## 3. Is `string` a Value Type or Reference Type?

`string` is a **Reference Type**.

---

## 4. Why does `string` behave like a Value Type?

Because strings are **immutable**. Any modification creates a new string object instead of changing the existing one.

---

## 5. What is Immutability?

Immutability means an object's contents cannot be modified after creation.

---

## 6. Where are Value Types stored?

Typically on the **stack** when they are local variables.

---

## 7. Where are Reference Types stored?

The object is stored on the **heap**, while the reference variable is typically stored on the stack.

---

## 8. What is Pass by Value?

A copy of the value is passed to the method.

Changes do not affect the original variable.

---

## 9. Why does modifying a Person object affect the original object?

Because both variables reference the same object in heap memory.

---

## 10. How can a Value Type be modified inside a method?

By using the `ref` keyword, which passes the variable by reference instead of by value.

---

# Summary

In this assignment, you learned:

- Value Types
- Reference Types
- Stack vs Heap Memory
- Pass by Value
- Object References
- String Immutability
- Method Parameter Behavior
- Best Practices
- Interview Questions

Understanding the distinction between value types and reference types is fundamental to writing efficient C# applications. This knowledge is crucial for **ASP.NET Core**, **Entity Framework Core**, **Web APIs**, multithreading, and performance optimization, and is one of the most frequently tested topics in .NET interviews.