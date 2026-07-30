# Assignment 11: Demonstrate Access Modifiers

## Objective

Learn how different access modifiers control the visibility and accessibility of class members in C#. This assignment demonstrates the use of **public**, **private**, and **protected** access modifiers and shows how they behave in both base and derived classes.

---

# Problem Statement

Create a C# program that:

- Defines a class containing public, private, and protected members.
- Creates a derived class that inherits from the base class.
- Demonstrates which members can be accessed from:
  - The base class.
  - The derived class.
- Uses public methods to access private and protected members where appropriate.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Access Modifiers
- Encapsulation
- public
- private
- protected
- Inheritance
- Base Class
- Derived Class
- Member Accessibility

---

# Prerequisites

You should know:

- Classes
- Objects
- Methods
- Variables
- Constructors
- Inheritance

---

# Theory

# What are Access Modifiers?

Access modifiers determine **who can access a class or its members**.

They help implement **Encapsulation**, one of the four pillars of Object-Oriented Programming.

---

# Why are Access Modifiers Important?

Access modifiers help to:

- Protect sensitive data.
- Hide implementation details.
- Prevent accidental modification.
- Improve software security.
- Support encapsulation.

---

# Types of Access Modifiers

C# provides several access modifiers.

The most commonly used are:

- public
- private
- protected
- internal
- protected internal
- private protected

This assignment focuses on the first three.

---

# Public Access Modifier

A public member is accessible from **anywhere**.

Example

```csharp
public string Name = "Nilanjan";
```

It can be accessed from

- Same class
- Derived class
- Any other class

Example

```csharp
Console.WriteLine(person.Name);
```

---

# Private Access Modifier

A private member is accessible **only inside the class where it is declared**.

Example

```csharp
private int Age = 21;
```

Outside the class

```csharp
person.Age
```

results in a compilation error.

To access it safely, your program uses

```csharp
DisplayAge();
```

---

# Protected Access Modifier

A protected member is accessible

- Inside the same class.
- Inside derived classes.

Example

```csharp
protected string Address = "Kolkata";
```

Accessible inside

```csharp
class Student : Person
```

but not through an object of `Person`.

---

# Encapsulation

Encapsulation means hiding data and allowing controlled access through methods or properties.

Example

Instead of

```csharp
person.Age
```

your program uses

```csharp
person.DisplayAge();
```

This keeps the data protected while still allowing controlled access.

---

# Inheritance

Inheritance allows one class to acquire the members of another class.

Example

```csharp
class Student : Person
```

Here

```
Person

↓

Student
```

Student inherits all accessible members from Person.

---

# Member Accessibility

Your program demonstrates the following:

## Public Member

```csharp
public string Name
```

Accessible from

- Base class
- Derived class
- Other classes

---

## Private Member

```csharp
private int Age
```

Accessible only inside

```
Person
```

Cannot be accessed directly anywhere else.

---

## Protected Member

```csharp
protected string Address
```

Accessible

- Inside Person
- Inside Student

Not accessible through a Person object.

---

# Access Modifier Comparison

| Access Modifier | Same Class | Derived Class | Other Classes |
|-----------------|-----------|---------------|---------------|
| public | ✔ | ✔ | ✔ |
| private | ✔ | ✖ | ✖ |
| protected | ✔ | ✔ | ✖ |

---

# Program Workflow

```
Start
   │
   ▼
Create Person Object
   │
   ▼
Access Public Member
   │
   ▼
Access Private Member
Through Public Method
   │
   ▼
Access Protected Member
Through Public Method
   │
   ▼
Create Student Object
   │
   ▼
Access Public Member
   │
   ▼
Access Protected Member
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Create the `Person` class.

It contains:

- Public member
- Private member
- Protected member

---

## Step 2

Create public methods

```csharp
DisplayAge()
```

and

```csharp
DisplayAddress()
```

These methods provide controlled access to private and protected members.

---

## Step 3

Create the derived class.

```csharp
class Student : Person
```

Student inherits the accessible members of Person.

---

## Step 4

Inside the derived class

```csharp
Console.WriteLine(Name);
```

works because `Name` is public.

---

```csharp
Console.WriteLine(Address);
```

works because `Address` is protected.

---

The following is not allowed

```csharp
Age
```

because it is private.

---

## Step 5

Create a Person object.

```csharp
Person person = new Person();
```

Access

```csharp
person.Name;
```

---

Access Age through

```csharp
DisplayAge();
```

---

Access Address through

```csharp
DisplayAddress();
```

---

## Step 6

Create a Student object.

```csharp
Student student = new Student();
```

Call

```csharp
DisplayDetails();
```

to demonstrate inherited accessibility.

---

# Visibility Diagram

```
                Person
      ┌────────────────────┐
      │ public Name        │ ✔ Everyone
      │ private Age        │ ✔ Person only
      │ protected Address  │ ✔ Person + Student
      └────────────────────┘
                 │
                 ▼
              Student
        Can access

        ✔ Name

        ✔ Address

        ✖ Age
```

---

# Access Modifiers vs Encapsulation

| Access Modifier | Purpose |
|-----------------|---------|
| public | Accessible everywhere |
| private | Hide implementation |
| protected | Allow inheritance |
| Encapsulation | Protect data using access modifiers |

---

# Advantages of Access Modifiers

- Improve security.
- Hide sensitive data.
- Prevent accidental modification.
- Improve maintainability.
- Support Object-Oriented Programming.

---

# Best Practices

✔ Keep fields private whenever possible.

✔ Use public methods or properties for controlled access.

✔ Use protected only when inheritance requires it.

✔ Avoid making every member public.

✔ Follow encapsulation principles.

---

# Common Mistakes

### Making Everything Public

Incorrect

```csharp
public int Age;
```

Sensitive data should usually be private.

---

### Accessing Private Members Outside the Class

Incorrect

```csharp
person.Age;
```

Compilation Error.

---

### Accessing Protected Members Through an Object

Incorrect

```csharp
person.Address;
```

Compilation Error.

Protected members are accessible only inside derived classes.

---

### Forgetting Encapsulation

Directly exposing data can reduce security and flexibility.

---

# Flowchart

```
             Start
                │
                ▼
        Create Person Object
                │
                ▼
      Access Public Member
                │
                ▼
 Call Public Methods
                │
                ▼
      Create Student Object
                │
                ▼
 Access Public Member
                │
                ▼
Access Protected Member
                │
                ▼
               End
```

---

# Real-World Applications

Access modifiers are used extensively in:

- ASP.NET Core
- Entity Framework Core
- Web APIs
- Banking Applications
- Hospital Management Systems
- Student Management Systems
- Payroll Systems
- Enterprise Software

Encapsulation and access control are fundamental principles in professional software development.

---

# Interview Questions

## 1. What are access modifiers?

Access modifiers define the visibility and accessibility of classes and class members.

---

## 2. What is the difference between public and private?

A public member can be accessed from anywhere, whereas a private member can only be accessed within the class where it is declared.

---

## 3. What is the purpose of the protected modifier?

A protected member is accessible within its own class and by derived classes but not through objects of the base class.

---

## 4. Can a derived class access private members of its base class?

No. Private members are accessible only within the class in which they are declared.

---

## 5. Why are public methods used to access private data?

Public methods provide controlled access, supporting encapsulation and protecting the object's internal state.

---

## 6. What is encapsulation?

Encapsulation is the process of hiding internal data and exposing only the necessary functionality through controlled interfaces such as methods or properties.

---

## 7. Which access modifier is the most restrictive?

`private` is the most restrictive among the modifiers demonstrated in this assignment.

---

## 8. Which access modifier should be used for class fields?

Fields are generally declared `private`, with controlled access provided through public properties or methods.

---

## 9. What is inheritance?

Inheritance allows a derived class to reuse and extend the functionality of a base class.

---

## 10. Where are access modifiers used in real-world applications?

Access modifiers are used in all modern C# applications, including ASP.NET Core, Entity Framework Core, Web APIs, desktop applications, mobile applications, and enterprise systems to enforce security, encapsulation, and maintainability.

---

# Summary

In this assignment, you learned:

- Access Modifiers
- public
- private
- protected
- Encapsulation
- Inheritance
- Base and Derived Classes
- Member Accessibility
- Best Practices
- Interview Questions

Access modifiers are a fundamental part of Object-Oriented Programming. They provide control over the visibility of data and methods, enabling encapsulation and secure software design. Understanding how to use `public`, `private`, and `protected` correctly is essential for building maintainable and scalable C# applications.