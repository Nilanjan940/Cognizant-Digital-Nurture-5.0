# Assignment 14: Demonstrate Inheritance and Method Overriding

## Objective

Learn how **Inheritance**, **Method Overriding**, **Virtual Methods**, and **Runtime Polymorphism** work in C#. This assignment demonstrates how derived classes can inherit from a base class and provide their own implementation of inherited methods.

---

# Problem Statement

Create a C# program that:

- Defines a base class named `Shape`.
- Declares a virtual method `Draw()`.
- Creates two derived classes:
  - `Circle`
  - `Rectangle`
- Overrides the `Draw()` method in each derived class.
- Uses a base class reference to call overridden methods.
- Demonstrates runtime polymorphism.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Inheritance
- Base Class
- Derived Class
- Method Overriding
- Virtual Methods
- Override Keyword
- Runtime Polymorphism
- Dynamic Method Dispatch

---

# Prerequisites

You should know:

- Classes
- Objects
- Methods
- Constructors
- Access Modifiers

---

# Theory

# What is Inheritance?

Inheritance is one of the four pillars of Object-Oriented Programming (OOP).

It allows one class to inherit the properties and methods of another class.

Example

```
Shape
   │
   ├──────────────┐
   │              │
Circle      Rectangle
```

Here,

- `Shape` is the **Base Class**
- `Circle` and `Rectangle` are **Derived Classes**

---

# Why Use Inheritance?

Inheritance helps to:

- Reuse existing code.
- Reduce code duplication.
- Improve maintainability.
- Support polymorphism.
- Create hierarchical relationships.

---

# Base Class

The base class contains common properties and methods that can be inherited by other classes.

Example

```csharp
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a Shape.");
    }
}
```

---

# Derived Class

A derived class inherits from the base class.

Example

```csharp
class Circle : Shape
{
}
```

The colon (`:`) indicates inheritance.

---

# Virtual Method

A virtual method allows derived classes to provide their own implementation.

Example

```csharp
public virtual void Draw()
{
}
```

Without the `virtual` keyword, overriding is not possible.

---

# Method Overriding

Method overriding allows a derived class to replace the implementation of a virtual method.

Example

```csharp
public override void Draw()
{
    Console.WriteLine("Drawing a Circle.");
}
```

The `override` keyword tells the compiler that this method replaces the base class implementation.

---

# Runtime Polymorphism

Runtime polymorphism occurs when a base class reference points to a derived class object.

Example

```csharp
Shape shape = new Circle();
```

Calling

```csharp
shape.Draw();
```

produces

```
Drawing a Circle.
```

even though the reference type is `Shape`.

The decision is made at runtime based on the object's actual type.

---

# Dynamic Method Dispatch

Dynamic method dispatch is the mechanism by which C# determines which overridden method should execute at runtime.

Example

```
Shape shape

↓

Circle Object

↓

Circle.Draw()
```

---

# Polymorphic Array

Your program also demonstrates polymorphism using an array.

```csharp
Shape[] shapes =
{
    new Circle(),
    new Rectangle()
};
```

Each object calls its own version of `Draw()`.

This is a common design pattern in professional software.

---

# Program Workflow

```
Start
   │
   ▼
Display Menu
   │
   ▼
Read User Choice
   │
   ▼
Create Shape Object
(Base Class Reference)
   │
   ▼
Runtime Decides
Which Draw() Executes
   │
   ▼
Display Output
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Create the base class.

```csharp
class Shape
```

It contains a virtual method.

```csharp
Draw()
```

---

## Step 2

Create the `Circle` class.

```csharp
class Circle : Shape
```

Override

```csharp
Draw()
```

---

## Step 3

Create the `Rectangle` class.

```csharp
class Rectangle : Shape
```

Override

```csharp
Draw()
```

---

## Step 4

Create a base class reference.

```csharp
Shape shape;
```

---

## Step 5

Read the user's choice.

The user selects:

- Circle
- Rectangle
- Both

---

## Step 6

Assign a derived object.

Example

```csharp
shape = new Circle();
```

---

## Step 7

Call

```csharp
shape.Draw();
```

The correct overridden method executes automatically.

---

## Step 8

If the user selects "Draw Both",

create an array.

```csharp
Shape[]
```

Iterate using

```csharp
foreach
```

Each object executes its own overridden method.

---

# Inheritance Hierarchy

```
                Shape
                  │
      ┌───────────┴───────────┐
      │                       │
   Circle                Rectangle
```

---

# Base Class vs Derived Class

| Base Class | Derived Class |
|------------|---------------|
| Parent class | Child class |
| Contains common functionality | Extends functionality |
| Can be inherited | Inherits members |
| General representation | Specialized representation |

---

# Virtual vs Override

| virtual | override |
|----------|----------|
| Declared in base class | Declared in derived class |
| Allows overriding | Replaces base implementation |
| Optional to override | Must match virtual method |

---

# Method Overriding vs Method Overloading

| Method Overriding | Method Overloading |
|-------------------|--------------------|
| Same method signature | Different parameter list |
| Requires inheritance | Does not require inheritance |
| Uses `virtual` and `override` | Same method name |
| Runtime polymorphism | Compile-time polymorphism |

---

# Runtime Polymorphism

Example

```csharp
Shape shape = new Rectangle();

shape.Draw();
```

Output

```
Drawing a Rectangle.
```

Although the reference type is `Shape`, the method belonging to `Rectangle` executes.

---

# Advantages of Inheritance

- Code Reusability
- Less Duplication
- Easier Maintenance
- Extensibility
- Better Organization

---

# Advantages of Method Overriding

- Runtime Polymorphism
- Flexible Design
- Better Code Reuse
- Easier Extension
- Supports Dynamic Behavior

---

# Best Practices

✔ Keep common functionality in the base class.

✔ Override methods only when behavior changes.

✔ Use meaningful class names.

✔ Prefer polymorphism instead of large `if-else` chains.

✔ Use base class references whenever appropriate.

---

# Common Mistakes

### Forgetting the virtual Keyword

Incorrect

```csharp
public void Draw()
```

Cannot be overridden.

---

### Forgetting the override Keyword

Incorrect

```csharp
public void Draw()
```

Creates a new method instead of overriding.

---

### Confusing Overloading with Overriding

Overloading changes parameters.

Overriding changes implementation.

---

### Calling Derived Methods Without Polymorphism

Instead of

```csharp
Circle c = new Circle();
Rectangle r = new Rectangle();
```

prefer

```csharp
Shape shape;
```

when polymorphism is required.

---

# Flowchart

```
              Start
                 │
                 ▼
          Display Menu
                 │
                 ▼
         Read User Choice
                 │
                 ▼
      Create Appropriate Object
                 │
                 ▼
      Call Overridden Draw()
                 │
                 ▼
          Display Output
                 │
                 ▼
                End
```

---

# Real-World Applications

Inheritance and method overriding are widely used in:

- ASP.NET Core MVC
- Windows Forms
- WPF Applications
- Game Development
- Graphic Editors
- Banking Systems
- Payroll Systems
- Hospital Management Systems
- Entity Framework Core
- Design Patterns such as Template Method and Strategy

---

# Interview Questions

## 1. What is inheritance?

Inheritance is an OOP feature that allows a class to inherit properties and methods from another class.

---

## 2. What is a base class?

A base class is the parent class whose members are inherited by derived classes.

---

## 3. What is method overriding?

Method overriding allows a derived class to provide its own implementation of a virtual method defined in the base class.

---

## 4. What is the purpose of the virtual keyword?

The `virtual` keyword allows a method in the base class to be overridden by derived classes.

---

## 5. What is the purpose of the override keyword?

The `override` keyword indicates that a derived class is replacing the implementation of a virtual method.

---

## 6. What is runtime polymorphism?

Runtime polymorphism occurs when a base class reference invokes the overridden method of the actual derived object at runtime.

---

## 7. What is dynamic method dispatch?

Dynamic method dispatch is the runtime mechanism that selects the correct overridden method based on the object's actual type.

---

## 8. Can a non-virtual method be overridden?

No. Only methods marked as `virtual`, `abstract`, or `override` can be overridden.

---

## 9. What is the difference between overriding and overloading?

Overriding changes the implementation of an inherited method, while overloading uses the same method name with different parameter lists.

---

## 10. Where are inheritance and overriding commonly used?

They are widely used in ASP.NET Core, Entity Framework Core, desktop applications, game development, GUI frameworks, and enterprise software to enable reusable and extensible designs.

---

# Summary

In this assignment, you learned:

- Inheritance
- Base Class
- Derived Class
- Virtual Methods
- Method Overriding
- Runtime Polymorphism
- Dynamic Method Dispatch
- Best Practices
- Interview Questions

Inheritance and method overriding are fundamental concepts of Object-Oriented Programming. They promote code reuse, extensibility, and flexibility by allowing derived classes to customize inherited behavior. Combined with runtime polymorphism, they form the basis of many modern C# frameworks, including **ASP.NET Core**, **Entity Framework Core**, **Windows Forms**, and **WPF**.