# Assignment 15: Differentiate Abstract Classes and Interfaces

## Objective

Learn the differences between **Abstract Classes** and **Interfaces** in C#. This assignment demonstrates how both can be used together to achieve abstraction, code reuse, and polymorphism.

---

# Problem Statement

Create a C# program that:

- Defines an abstract class named `Vehicle`.
- Declares an abstract method `Drive()`.
- Includes a concrete method to display the vehicle brand.
- Defines an interface `IDrivable`.
- Implements both the abstract class and the interface in a `Car` class.
- Demonstrates polymorphism using abstract class and interface references.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Abstraction
- Abstract Classes
- Abstract Methods
- Concrete Methods
- Interfaces
- Method Overriding
- Interface Implementation
- Runtime Polymorphism
- Constructor Chaining

---

# Prerequisites

You should know:

- Classes
- Objects
- Constructors
- Inheritance
- Method Overriding

---

# Theory

# What is Abstraction?

Abstraction is one of the four pillars of Object-Oriented Programming (OOP).

It hides implementation details and exposes only the essential functionality.

Example

```
Car

↓

Start()

↓

User does not know
how the engine starts internally.
```

Abstraction simplifies program design and improves maintainability.

---

# What is an Abstract Class?

An abstract class is a class that **cannot be instantiated directly**.

It acts as a blueprint for derived classes.

Example

```csharp
abstract class Vehicle
{
}
```

The following is **not allowed**:

```csharp
Vehicle vehicle = new Vehicle();
```

---

# Why Use Abstract Classes?

Abstract classes are used when:

- Multiple classes share common functionality.
- Some methods have a common implementation.
- Some methods must be implemented differently by derived classes.

---

# Abstract Method

An abstract method has **no implementation** in the base class.

Example

```csharp
public abstract void Drive();
```

Every derived class must override this method.

---

# Concrete Method

Unlike abstract methods, a concrete method already contains an implementation.

Example

```csharp
public void DisplayBrand()
{
    Console.WriteLine(Brand);
}
```

Derived classes inherit this implementation automatically.

---

# What is an Interface?

An interface defines a **contract**.

It specifies what a class must do without specifying how.

Example

```csharp
interface IDrivable
{
    void Start();
}
```

Every class implementing the interface must provide its own implementation.

---

# Why Use Interfaces?

Interfaces provide:

- Loose coupling
- Multiple inheritance of behavior
- Better flexibility
- Easier testing
- Better maintainability

---

# Implementing an Interface

Your `Car` class implements the interface.

```csharp
class Car : Vehicle, IDrivable
```

Notice that a class can inherit from **one abstract class** but implement **multiple interfaces**.

---

# Constructor Chaining

Your constructor uses the `base` keyword.

```csharp
public Car(string brand) : base(brand)
{
}
```

This calls the constructor of the abstract class.

Flow

```
Car Constructor

↓

Vehicle Constructor

↓

Brand Initialized
```

---

# Method Overriding

The abstract method is implemented using the `override` keyword.

```csharp
public override void Drive()
{
    Console.WriteLine("Car is being driven.");
}
```

---

# Interface Implementation

The interface method is implemented directly.

```csharp
public void Start()
{
    Console.WriteLine("Car Started.");
}
```

---

# Runtime Polymorphism

Your program demonstrates runtime polymorphism in three different ways.

### 1. Using the Car Object

```csharp
Car car = new Car(brand);
```

All members are accessible.

---

### 2. Using an Abstract Class Reference

```csharp
Vehicle vehicle = car;
```

Only members of `Vehicle` are accessible.

Runtime still calls

```csharp
Car.Drive()
```

because of method overriding.

---

### 3. Using an Interface Reference

```csharp
IDrivable drivable = car;
```

Only the interface members are accessible.

```
drivable.Start();
```

This is another example of runtime polymorphism.

---

# Program Workflow

```
Start
   │
   ▼
Read Car Brand
   │
   ▼
Create Car Object
   │
   ▼
Display Brand
   │
   ▼
Start Car
   │
   ▼
Drive Car
   │
   ▼
Create Vehicle Reference
   │
   ▼
Call Overridden Method
   │
   ▼
Create Interface Reference
   │
   ▼
Call Interface Method
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Create the abstract class.

```csharp
abstract class Vehicle
```

It contains

- Brand property
- Constructor
- Abstract method
- Concrete method

---

## Step 2

Create the interface.

```csharp
interface IDrivable
```

It declares

```csharp
Start();
```

---

## Step 3

Create the derived class.

```csharp
class Car : Vehicle, IDrivable
```

The class

- Inherits Vehicle
- Implements IDrivable

---

## Step 4

Call the base constructor.

```csharp
base(brand)
```

This initializes the `Brand` property.

---

## Step 5

Override the abstract method.

```csharp
Drive()
```

---

## Step 6

Implement the interface method.

```csharp
Start()
```

---

## Step 7

Create the object.

```csharp
Car car = new Car(brand);
```

---

## Step 8

Demonstrate abstract class polymorphism.

```csharp
Vehicle vehicle = car;
```

---

## Step 9

Demonstrate interface polymorphism.

```csharp
IDrivable drivable = car;
```

---

# Abstract Class vs Interface

| Abstract Class | Interface |
|----------------|-----------|
| Can contain abstract and concrete methods | Declares a contract |
| Can have constructors | Cannot have constructors |
| Can have fields | Cannot have instance fields |
| Supports code reuse | Supports multiple implementation |
| Single inheritance | Multiple interfaces can be implemented |

---

# Abstract Method vs Interface Method

| Abstract Method | Interface Method |
|-----------------|------------------|
| Belongs to an abstract class | Belongs to an interface |
| May coexist with implemented methods | Represents required behavior |
| Requires `override` | Requires implementation |

---

# Polymorphism Demonstrated

Your program demonstrates three references.

```
Car

↓

Vehicle

↓

IDrivable
```

Each reference exposes different members while referring to the same object.

---

# Advantages of Abstract Classes

- Code reuse
- Common implementation
- Constructors
- Shared fields
- Better organization

---

# Advantages of Interfaces

- Loose coupling
- Multiple inheritance
- Better extensibility
- Easier unit testing
- Supports dependency injection

---

# Best Practices

✔ Use abstract classes when classes share common implementation.

✔ Use interfaces to define capabilities or contracts.

✔ Keep interfaces focused on a single responsibility.

✔ Use abstract methods only when derived classes must provide their own implementation.

✔ Favor interfaces for flexible and testable designs.

---

# Common Mistakes

### Creating an Object of an Abstract Class

Incorrect

```csharp
Vehicle vehicle = new Vehicle();
```

Abstract classes cannot be instantiated.

---

### Forgetting to Override an Abstract Method

A derived class must implement all inherited abstract methods.

---

### Forgetting to Implement Interface Members

All interface methods must be implemented.

---

### Confusing Interfaces with Abstract Classes

Interfaces define **what** should be done.

Abstract classes define **what** and may also define **how**.

---

# Flowchart

```
            Start
               │
               ▼
       Read Brand Name
               │
               ▼
      Create Car Object
               │
               ▼
    Display Brand Name
               │
               ▼
     Start the Vehicle
               │
               ▼
      Drive the Vehicle
               │
               ▼
  Demonstrate Polymorphism
               │
               ▼
              End
```

---

# Real-World Applications

Abstract classes and interfaces are extensively used in:

- ASP.NET Core
- Entity Framework Core
- Dependency Injection
- Repository Pattern
- Strategy Pattern
- Factory Pattern
- Payment Gateways
- Vehicle Management Systems
- Banking Applications
- Game Development

Interfaces are especially important in enterprise applications because they enable loose coupling and improve testability.

---

# Interview Questions

## 1. What is an abstract class?

An abstract class is a class that cannot be instantiated and may contain both abstract and concrete methods.

---

## 2. What is an interface?

An interface defines a contract that implementing classes must follow by providing implementations for its members.

---

## 3. What is the difference between an abstract class and an interface?

An abstract class can contain both implemented and abstract members, constructors, and fields. An interface defines a contract and supports multiple implementation.

---

## 4. Can an abstract class have constructors?

Yes. Constructors in an abstract class are called when a derived class object is created.

---

## 5. Can an interface have constructors?

No. Interfaces cannot have constructors because they cannot be instantiated.

---

## 6. Why is the `override` keyword used?

The `override` keyword provides a new implementation for an inherited abstract or virtual method.

---

## 7. Can a class inherit multiple abstract classes?

No. C# supports inheritance from only one class.

---

## 8. Can a class implement multiple interfaces?

Yes. A class can implement any number of interfaces.

---

## 9. Why are interfaces widely used in ASP.NET Core?

Interfaces promote loose coupling, dependency injection, easier testing, and maintainable application architecture.

---

## 10. When should you choose an abstract class instead of an interface?

Choose an abstract class when related classes share common state or implementation. Choose an interface when different classes only need to share a common capability or contract.

---

# Summary

In this assignment, you learned:

- Abstraction
- Abstract Classes
- Interfaces
- Abstract Methods
- Concrete Methods
- Method Overriding
- Interface Implementation
- Constructor Chaining
- Runtime Polymorphism
- Best Practices
- Interview Questions

Abstract classes and interfaces are fundamental building blocks of modern C# development. Abstract classes provide shared implementation and state, while interfaces define reusable contracts that enable loose coupling and extensible application design. Together, they are heavily used in **ASP.NET Core**, **Entity Framework Core**, **Dependency Injection**, **Microservices**, and enterprise-scale .NET applications.