# Assignment 3: Use Primary Constructors in C# 12

## Objective

Learn how to use **Primary Constructors**, a feature introduced in **C# 12**, to simplify class initialization and reduce boilerplate code.

This assignment demonstrates:

- Primary Constructors
- Auto-Implemented Properties
- Object Initialization
- Instance Methods
- Modern C# Syntax

---

# Problem Statement

Create a C# program that:

- Defines a `Person` class using the **Primary Constructor** syntax.
- Uses auto-implemented properties to initialize object data.
- Creates a `DisplayInfo()` method to print the person's details.
- Instantiates the class and displays the information.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Primary Constructors
- Auto-Implemented Properties
- Constructors
- Object Initialization
- Class Members
- Instance Methods
- Modern C# Features

---

# Prerequisites

You should know:

- Classes and Objects
- Methods
- Constructors
- Properties
- Variables

---

# Theory

# What is a Constructor?

A constructor is a special method that is automatically called whenever an object is created.

Example

```csharp
Person person = new Person();
```

The constructor initializes the object.

---

# Traditional Constructor

Before C# 12, constructors were written like this:

```csharp
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
```

Notice that we have to write:

- Constructor
- Assignments
- Parameters

This increases boilerplate code.

---

# Primary Constructor

C# 12 introduced **Primary Constructors**.

Syntax

```csharp
class Person(string name, int age)
{
}
```

Parameters are declared directly in the class declaration.

These parameters are available throughout the class body.

---

# Your Example

```csharp
class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
}
```

Instead of writing a separate constructor, the parameters are automatically available for initializing the properties.

---

# Auto-Implemented Properties

Properties provide controlled access to fields.

Example

```csharp
public string Name { get; set; }
```

The compiler automatically creates the private backing field.

---

# Property Initialization

Properties can be initialized directly.

Example

```csharp
public string Name { get; set; } = name;
```

Here,

```
Primary Constructor Parameter
            │
            ▼
        name
            │
            ▼
 Property Initialization
            │
            ▼
        Name Property
```

---

# Instance Methods

Instance methods operate on object data.

Example

```csharp
public void DisplayInfo()
{
    Console.WriteLine(Name);
}
```

Since `Name` and `Age` belong to the object,

every object has its own values.

---

# Creating an Object

```csharp
Person person = new Person("Nilanjan", 21);
```

This automatically invokes the primary constructor.

Object created

```
Person

Name = Nilanjan

Age = 21
```

---

# Accessing Properties

```csharp
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);
```

Output

```
Nilanjan

21
```

---

# Program Explanation

## Step 1

Declare the primary constructor.

```csharp
class Person(string name, int age)
```

---

## Step 2

Initialize properties.

```csharp
public string Name { get; set; } = name;
```

---

## Step 3

Create the method.

```csharp
DisplayInfo()
```

---

## Step 4

Create an object.

```csharp
new Person("Nilanjan",21)
```

---

## Step 5

Call the method.

```csharp
person.DisplayInfo();
```

---

## Step 6

Access auto-properties.

```csharp
person.Name
person.Age
```

---

# Traditional Constructor vs Primary Constructor

| Traditional Constructor | Primary Constructor |
|-------------------------|---------------------|
| More code | Less code |
| Separate constructor | Constructor in class declaration |
| More boilerplate | Cleaner syntax |
| Easy to understand | More concise |

---

# Constructor vs Primary Constructor

| Constructor | Primary Constructor |
|-------------|---------------------|
| Explicitly defined | Declared in class header |
| Introduced in earlier C# versions | Introduced in C# 12 |
| More verbose | More concise |

---

# Auto-Properties

Instead of

```csharp
private string name;

public string Name
{
    get
    {
        return name;
    }

    set
    {
        name = value;
    }
}
```

we simply write

```csharp
public string Name { get; set; }
```

The compiler automatically creates the backing field.

---

# Advantages of Primary Constructors

- Less boilerplate code
- Cleaner syntax
- Better readability
- Faster development
- Easier object initialization
- Modern C# feature

---

# Advantages of Auto-Properties

- Less code
- Cleaner syntax
- Automatic backing field
- Easy maintenance

---

# Best Practices

✔ Use Primary Constructors for simple initialization.

✔ Use auto-properties whenever custom logic is unnecessary.

✔ Keep constructors focused on initialization.

✔ Use meaningful parameter names.

✔ Prefer modern C# syntax when targeting .NET 8 / C# 12.

---

# Common Mistakes

### Forgetting Property Initialization

Incorrect

```csharp
public string Name { get; set; }
```

Without assigning

```csharp
= name;
```

the property won't receive the constructor value.

---

### Confusing Constructor Parameters with Properties

These are different

```csharp
name
```

Constructor parameter

```csharp
Name
```

Property

---

### Using Primary Constructors in Older C# Versions

Primary Constructors require

- C# 12
- .NET 8 SDK

---

# Flowchart

```
            Start
               │
               ▼
      Primary Constructor
               │
               ▼
Receive Name and Age
               │
               ▼
Initialize Properties
               │
               ▼
Create Person Object
               │
               ▼
Call DisplayInfo()
               │
               ▼
Display Name and Age
               │
               ▼
              End
```

---

# Real-World Applications

Primary Constructors are commonly used in:

- ASP.NET Core
- Dependency Injection
- Web APIs
- Entity Framework Core
- Microservices
- Blazor
- Console Applications
- Desktop Applications

---

# Interview Questions

## 1. What is a Primary Constructor?

A Primary Constructor is a constructor declared directly in the class declaration, introduced in **C# 12**, to reduce boilerplate code.

---

## 2. Which C# version introduced Primary Constructors?

**C# 12**

---

## 3. What are Auto-Implemented Properties?

Properties where the compiler automatically creates the private backing field.

Example

```csharp
public string Name { get; set; }
```

---

## 4. Why use Primary Constructors?

- Less code
- Cleaner syntax
- Easier initialization
- Better readability

---

## 5. Can Primary Constructor parameters be used inside the class?

Yes.

They are available throughout the class body.

---

## 6. What is the difference between a constructor and a Primary Constructor?

A traditional constructor is written separately inside the class, whereas a Primary Constructor is declared in the class header.

---

## 7. Do Primary Constructors replace traditional constructors?

No.

They simplify many scenarios, but traditional constructors are still useful when complex initialization logic is required.

---

## 8. What is an auto-property backing field?

It is a compiler-generated private field used to store the property's value.

---

## 9. Can Primary Constructors contain validation logic?

Yes, but for complex validation or multiple initialization paths, a traditional constructor is often more appropriate.

---

## 10. Where are Primary Constructors commonly used?

They are frequently used in **ASP.NET Core**, **Dependency Injection**, **Blazor**, **Entity Framework Core**, **Web APIs**, and other modern .NET applications.

---

# Summary

In this assignment, you learned:

- Primary Constructors
- Constructors
- Auto-Implemented Properties
- Object Initialization
- Instance Methods
- Modern C# 12 Features
- Best Practices
- Interview Questions

Primary Constructors are one of the most significant additions in **C# 12**. They simplify object creation, reduce boilerplate code, and improve readability, making them especially valuable in modern **ASP.NET Core**, **Blazor**, **Web API**, and **Entity Framework Core** applications.