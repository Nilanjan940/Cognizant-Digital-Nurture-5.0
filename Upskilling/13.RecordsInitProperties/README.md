# Assignment 13: Create and Use Records with init Properties

## Objective

Learn how to create immutable objects using **Records** and **init-only properties** in C#. This assignment demonstrates how records simplify object creation, support value-based equality, and allow safe modification using the `with` expression.

---

# Problem Statement

Create a C# program that:

- Defines an immutable `Employee` record.
- Uses **init-only properties**.
- Accepts employee details from the user.
- Creates an employee record.
- Creates a modified copy using the `with` expression.
- Verifies that the original record remains unchanged.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Records
- Immutable Objects
- init Properties
- with Expression
- Value-Based Equality
- Object Copying
- Modern C# Features

---

# Prerequisites

You should know:

- Classes
- Objects
- Properties
- Constructors
- Object Initialization

---

# Theory

# What is a Record?

A **record** is a special reference type introduced in **C# 9** that is designed to represent immutable data.

Unlike a class, a record focuses on storing data rather than behavior.

Example

```csharp
public record Employee
{
    public int Id { get; init; }
}
```

Records automatically provide:

- Value-based equality
- Better `ToString()`
- Copying support
- Immutability support

---

# Why Use Records?

Records are useful when objects represent **data** instead of behavior.

Examples include:

- Employee
- Student
- Customer
- Product
- Address
- Order
- Invoice

---

# What are init-only Properties?

An `init` property can only be assigned:

- During object creation
- Inside an object initializer

Example

```csharp
public string Name { get; init; }
```

Valid

```csharp
Employee emp = new Employee
{
    Name = "Nilanjan"
};
```

Invalid

```csharp
emp.Name = "Alex";
```

This results in a compilation error because the object has already been initialized.

---

# Why Use init Instead of set?

Using `init` makes objects immutable after creation.

Benefits include:

- Prevents accidental modification
- Improves thread safety
- Makes programs easier to debug
- Encourages functional programming

---

# What is Immutability?

An immutable object **cannot be changed after it is created**.

Instead of modifying the object, a **new object** is created.

Example

```
Employee 1

↓

Cannot Change

↓

Create Employee 2
```

This prevents unexpected side effects.

---

# Object Initializer

Your program creates an employee record using an object initializer.

```csharp
Employee employee1 = new Employee
{
    Id = id,
    Name = name,
    Department = department,
    Salary = salary
};
```

This syntax is concise and works perfectly with `init` properties.

---

# What is the with Expression?

The `with` expression creates a **copy** of an existing record while changing selected properties.

Example

```csharp
Employee employee2 = employee1 with
{
    Salary = newSalary
};
```

Only the `Salary` changes.

All other properties remain the same.

---

# Why Use the with Expression?

Instead of

```
Create Entire Object Again
```

you simply write

```csharp
employee1 with
{
    Salary = 60000
}
```

This creates a new object efficiently.

---

# Original Object Remains Unchanged

One of the biggest advantages of records is immutability.

Original Record

```
Salary = 50000
```

Modified Record

```
Salary = 60000
```

Original Record

```
Still 50000
```

Your program verifies this behavior.

---

# Value-Based Equality

Unlike classes, records compare **values**, not memory addresses.

Example

```csharp
Employee e1 = new Employee
{
    Id = 1,
    Name = "John"
};

Employee e2 = new Employee
{
    Id = 1,
    Name = "John"
};
```

For records

```csharp
e1 == e2
```

returns

```
True
```

because their values are the same.

With classes, the comparison would return `False` unless overridden.

---

# Record vs Class

| Record | Class |
|---------|-------|
| Designed for immutable data | Designed for behavior and data |
| Value-based equality | Reference-based equality |
| Supports `with` expression | Does not support `with` by default |
| Supports concise syntax | More verbose |
| Ideal for DTOs and models | Ideal for business logic |

---

# init vs set

| init | set |
|------|-----|
| Assigned only during initialization | Can be changed anytime |
| Supports immutability | Mutable |
| Safer | Less restrictive |
| Introduced in C# 9 | Available since earlier C# versions |

---

# Program Workflow

```
Start
   │
   ▼
Read Employee Details
   │
   ▼
Create Employee Record
   │
   ▼
Display Original Record
   │
   ▼
Read New Salary
   │
   ▼
Create Copy Using with
   │
   ▼
Display Modified Record
   │
   ▼
Display Original Record Again
   │
   ▼
Verify Original Is Unchanged
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Define the `Employee` record.

It contains four `init` properties:

- Id
- Name
- Department
- Salary

---

## Step 2

Accept employee details from the user.

```csharp
Console.ReadLine();
```

---

## Step 3

Create the original employee record.

```csharp
Employee employee1 = new Employee
{
    ...
};
```

---

## Step 4

Display the employee details.

```csharp
DisplayEmployee(employee1);
```

---

## Step 5

Ask the user for a new salary.

---

## Step 6

Create a modified copy.

```csharp
Employee employee2 = employee1 with
{
    Salary = newSalary
};
```

---

## Step 7

Display the modified record.

---

## Step 8

Display the original record again.

Its salary remains unchanged, proving immutability.

---

# Advantages of Records

- Less boilerplate code
- Cleaner syntax
- Built-in value equality
- Supports immutability
- Easy object copying
- Better readability

---

# Advantages of init Properties

- Prevent accidental modifications
- Improve object consistency
- Support immutable design
- Safer for multi-threaded applications

---

# Best Practices

✔ Use records for data-only objects.

✔ Use `init` when values should not change after creation.

✔ Use `with` instead of modifying immutable objects.

✔ Prefer records for DTOs and API models.

✔ Keep records simple and focused on data.

---

# Common Mistakes

### Trying to Modify an init Property

Incorrect

```csharp
employee.Name = "Alex";
```

This causes a compilation error.

---

### Recreating the Entire Object Instead of Using with

Instead of

```csharp
new Employee(...)
```

use

```csharp
employee with
{
    Salary = 70000
}
```

---

### Using Records for Complex Business Logic

Records are intended primarily for representing data, not implementing extensive behavior.

---

### Confusing Value Equality with Reference Equality

Records compare values.

Classes compare references unless equality is overridden.

---

# Flowchart

```
             Start
                │
                ▼
      Read Employee Data
                │
                ▼
    Create Employee Record
                │
                ▼
 Display Original Record
                │
                ▼
      Enter New Salary
                │
                ▼
 Create Copy Using with
                │
                ▼
Display Modified Record
                │
                ▼
Display Original Record
                │
                ▼
      Verify Immutability
                │
                ▼
               End
```

---

# Real-World Applications

Records are widely used in:

- ASP.NET Core Web APIs
- Entity Transfer Objects (DTOs)
- Microservices
- Configuration Models
- JSON Serialization
- Cloud Applications
- Event Sourcing
- Messaging Systems
- Clean Architecture

They are especially valuable when representing data that should not change after creation.

---

# Interview Questions

## 1. What is a record in C#?

A record is a reference type designed for immutable data and value-based equality.

---

## 2. What is the difference between a class and a record?

Classes use reference equality by default, while records use value-based equality and are designed for immutable data.

---

## 3. What is an init-only property?

An `init` property can only be assigned during object initialization and cannot be modified afterward.

---

## 4. What is the purpose of the with expression?

The `with` expression creates a copy of an existing record while allowing selected properties to be changed.

---

## 5. What is immutability?

Immutability means an object's state cannot change after it has been created.

---

## 6. Why are records useful?

They reduce boilerplate code, improve readability, support value equality, and simplify immutable object creation.

---

## 7. Can records contain methods?

Yes. Records can contain methods, constructors, properties, and other members just like classes.

---

## 8. What is value-based equality?

Two records are considered equal if all their property values are equal, regardless of whether they are different object instances.

---

## 9. Where are records commonly used?

Records are commonly used for DTOs, API request/response models, configuration objects, immutable domain models, and message contracts.

---

## 10. Which C# version introduced records and init properties?

Both records and `init` properties were introduced in **C# 9**.

---

# Summary

In this assignment, you learned:

- Records
- Immutable Objects
- init-only Properties
- Object Initializers
- with Expression
- Value-Based Equality
- Modern C# Features
- Best Practices
- Interview Questions

Records provide a modern, concise way to represent immutable data in C#. Combined with `init` properties and the `with` expression, they make applications safer, easier to maintain, and better suited for modern .NET development. They are extensively used in **ASP.NET Core**, **Web APIs**, **Microservices**, and **Cloud-native applications**.