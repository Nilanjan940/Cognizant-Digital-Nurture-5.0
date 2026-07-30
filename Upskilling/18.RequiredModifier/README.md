# Assignment 18: Use the `required` Modifier in C# 12

## Objective

Learn how to use the **required** modifier introduced in **C# 11** (fully supported in C# 12) to ensure that important object properties are initialized during object creation.

---

# Problem Statement

Create a `Student` class that contains required properties.

- Declare required properties such as `StudentId`, `Name`, and `Department`.
- Create an object using object initializer syntax.
- Observe the compiler behavior when a required property is omitted.
- Display the student's information.

---

# Learning Outcomes

After completing this assignment, you will be able to:

- Understand the `required` modifier.
- Know why required properties are useful.
- Differentiate between `required` and normal properties.
- Create safer and more reliable classes.
- Understand compile-time validation.

---

# Prerequisites

You should know:

- Classes and Objects
- Properties
- Object Initializers
- Constructors
- C# Property Syntax

---

# Theory

## What is the `required` Modifier?

The `required` modifier tells the compiler that a property **must be initialized** whenever an object of the class is created.

Example

```csharp
public required string Name { get; set; }
```

If the property is not initialized, the compiler produces an error.

---

# Why was `required` Introduced?

Before C# 11, developers often forgot to initialize important properties.

Example

```csharp
Student s = new Student();
```

Here,

```
Name
Department
StudentId
```

may all remain uninitialized.

This can lead to bugs.

The `required` keyword solves this problem by forcing initialization.

---

# Syntax

```csharp
public required string Name { get; set; }
```

---

# Object Initialization

Correct

```csharp
Student student = new Student
{
    StudentId = 101,
    Name = "Rahul",
    Department = "Computer Science"
};
```

Incorrect

```csharp
Student student = new Student
{
    StudentId = 101
};
```

Compiler Error

```
Required member 'Student.Name' must be set.
```

---

# How the Compiler Works

During compilation, C# checks whether every required property has been initialized.

If any required member is missing,

the program **does not compile**.

This makes applications much safer.

---

# Required vs Normal Property

Normal Property

```csharp
public string Name { get; set; }
```

Can remain uninitialized.

Required Property

```csharp
public required string Name { get; set; }
```

Must be initialized.

---

# Required vs Constructor

Before C# 11

```csharp
public Student(string name)
{
    Name = name;
}
```

Now

```csharp
Student s = new Student
{
    Name = "Rahul"
};
```

No constructor is necessary just to enforce initialization.

---

# Program Explanation

## Step 1

Create a Student class.

```csharp
class Student
{
}
```

---

## Step 2

Declare required properties.

```csharp
public required int StudentId { get; set; }
```

---

## Step 3

Accept user input.

```csharp
Console.ReadLine();
```

---

## Step 4

Create the object.

```csharp
Student student = new Student
{
    StudentId = id,
    Name = name,
    Department = department
};
```

---

## Step 5

Display the details.

```csharp
student.DisplayDetails();
```

---

# Advantages of `required`

- Prevents partially initialized objects.
- Catches mistakes during compilation.
- Produces safer code.
- Improves maintainability.
- Eliminates unnecessary constructors.
- Encourages better object initialization.

---

# Limitations

- Available from **C# 11** onward.
- Does not validate values (only ensures initialization).
- Does not replace business validation.

Example

```csharp
Name = "";
```

This is allowed because the property has been initialized, even though the value is empty.

---

# `required` with Nullable Reference Types

Recommended

```csharp
public required string Name { get; set; }
```

instead of

```csharp
public string? Name { get; set; }
```

because the compiler ensures initialization.

---

# Best Practices

✔ Use `required` for mandatory properties.

✔ Use normal properties for optional data.

✔ Combine `required` with validation when necessary.

✔ Prefer object initializers.

✔ Use meaningful default values for optional members.

---

# Common Mistakes

### Forgetting Required Properties

```csharp
Student s = new Student();
```

Compiler Error.

---

### Assuming `required` Validates Data

It only checks initialization.

It does **not** check whether the value is empty or invalid.

---

### Confusing `required` with Constructors

Constructors initialize objects.

`required` enforces initialization.

---

# Flowchart

```
          Start
             │
             ▼
      Read Student Details
             │
             ▼
     Create Student Object
             │
             ▼
Compiler Checks Required Properties
             │
      ┌──────┴──────┐
      │             │
     Yes            No
      │             │
      ▼             ▼
 Display Details   Compilation Error
      │
      ▼
      End
```

---

# Real-Life Example

Imagine an online university portal.

Every student **must** have

- Student ID
- Name
- Department

Age may be optional.

The `required` keyword guarantees that essential information is never forgotten.

---

# Interview Questions

## 1. What is the `required` modifier?

The `required` modifier forces certain properties to be initialized during object creation.

---

## 2. Which version of C# introduced `required`?

C# 11 (and it is fully supported in C# 12).

---

## 3. Does `required` validate values?

No.

It only ensures that the property is assigned.

---

## 4. Can a required property be changed later?

Yes, if it has a `set` accessor.

If combined with `init`

```csharp
public required string Name { get; init; }
```

it becomes immutable after initialization.

---

## 5. Difference between `required` and `init`

| required | init |
|-----------|------|
| Ensures initialization | Restricts modification after initialization |
| Compile-time enforcement | Read-only after object creation |
| Introduced in C# 11 | Introduced in C# 9 |

---

## 6. Can constructors and `required` be used together?

Yes.

Many real-world applications combine both features.

---

## 7. Why is `required` useful?

It prevents incomplete object creation and catches errors at compile time.

---

## 8. Is `required` checked at runtime?

No.

It is enforced by the compiler during compilation.

---

## 9. Can optional properties also be declared?

Yes.

Only the properties marked with `required` must be initialized.

---

## 10. Where is `required` commonly used?

- ASP.NET Core Models
- Entity Framework Models
- DTOs
- API Request Objects
- Enterprise Applications

---

# Summary

In this assignment, you learned:

- The `required` modifier
- Object initialization
- Compile-time safety
- Required vs normal properties
- Required vs constructors
- Required vs `init`
- Best practices
- Common mistakes

The `required` modifier is an important modern C# feature that helps developers build safer, more maintainable, and less error-prone applications by ensuring essential object data is always initialized.