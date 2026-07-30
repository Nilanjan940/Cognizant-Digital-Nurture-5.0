# Assignment 10: Demonstrate OOP Basics with Constructors

## Objective

Learn the fundamentals of Object-Oriented Programming (OOP) by creating a class with properties and constructors. This assignment demonstrates the use of **default constructors**, **parameterized constructors**, object creation, and methods in C#.

---

# Problem Statement

Create a C# program that:

- Defines a `Car` class.
- Includes properties for `Make`, `Model`, and `Year`.
- Implements both a default constructor and a parameterized constructor.
- Creates objects using both constructors.
- Displays the details of each object.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Classes
- Objects
- Properties
- Constructors
- Default Constructor
- Parameterized Constructor
- Object Initialization
- Methods
- Encapsulation

---

# Prerequisites

You should know:

- Variables
- Methods
- Classes
- Objects
- Basic C# Syntax

---

# Theory

# What is Object-Oriented Programming (OOP)?

Object-Oriented Programming (OOP) is a programming paradigm that organizes software around **objects** rather than functions.

An object contains:

- Data (Properties)
- Behavior (Methods)

Example

```
Car
│
├── Make
├── Model
├── Year
└── DisplayDetails()
```

---

# What is a Class?

A class is a blueprint for creating objects.

Example

```csharp
class Car
{
    public string Make { get; set; }
}
```

The class itself does not occupy memory for object data until an object is created.

---

# What is an Object?

An object is an instance of a class.

Example

```csharp
Car car1 = new Car();
```

Here,

- `Car` → Class
- `car1` → Object

Each object has its own copy of the properties.

---

# What are Properties?

Properties are used to store data inside an object.

Example

```csharp
public string Make { get; set; }
```

Your class contains three properties:

- Make
- Model
- Year

---

# What is a Constructor?

A constructor is a special method that initializes an object when it is created.

Characteristics

- Same name as the class.
- Has no return type.
- Called automatically during object creation.

Example

```csharp
Car car = new Car();
```

The constructor executes automatically.

---

# Default Constructor

A default constructor does not take any parameters.

Example

```csharp
public Car()
{
    Make = "Unknown";
    Model = "Unknown";
    Year = 0;
}
```

It assigns default values when no information is provided.

---

# Parameterized Constructor

A parameterized constructor accepts values while creating an object.

Example

```csharp
Car car = new Car("Toyota", "Camry", 2020);
```

The object is initialized immediately with meaningful data.

---

# Constructor Overloading

Your program demonstrates **constructor overloading**.

Two constructors exist:

```csharp
Car()
```

and

```csharp
Car(string make, string model, int year)
```

The compiler chooses the appropriate constructor based on the arguments passed.

---

# Object Initialization

Object creation follows these steps:

```
new Car()

↓

Memory Allocated

↓

Constructor Called

↓

Properties Initialized

↓

Object Ready
```

---

# Methods

Methods define the behavior of an object.

Example

```csharp
DisplayDetails()
```

This method prints the values of the object's properties.

---

# Program Workflow

```
Start
   │
   ▼
Create Car Object
Using Default Constructor
   │
   ▼
Display Details
   │
   ▼
Create Car Object
Using Parameterized Constructor
   │
   ▼
Display Details
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Define the `Car` class.

```csharp
class Car
```

---

## Step 2

Create three properties.

```csharp
Make
Model
Year
```

These store the details of a car.

---

## Step 3

Create a default constructor.

```csharp
public Car()
```

It initializes the object with default values.

---

## Step 4

Create a parameterized constructor.

```csharp
public Car(string make, string model, int year)
```

It initializes the object with user-specified values.

---

## Step 5

Create the `DisplayDetails()` method.

It prints the property values.

---

## Step 6

Create two objects.

Using default constructor

```csharp
Car car1 = new Car();
```

Using parameterized constructor

```csharp
Car car2 = new Car("Toyota","Camry",2020);
```

---

## Step 7

Display the details of both objects.

---

# Default Constructor vs Parameterized Constructor

| Default Constructor | Parameterized Constructor |
|---------------------|---------------------------|
| No parameters | Accepts parameters |
| Initializes default values | Initializes custom values |
| Called with `new Car()` | Called with `new Car("Toyota","Camry",2020)` |
| Useful for default objects | Useful for fully initialized objects |

---

# Constructor vs Method

| Constructor | Method |
|-------------|--------|
| Initializes an object | Performs an operation |
| Same name as class | Can have any valid name |
| No return type | May return a value |
| Automatically called | Explicitly called |

---

# Advantages of Constructors

- Automatically initialize objects.
- Reduce repetitive code.
- Ensure objects start in a valid state.
- Improve readability.

---

# Advantages of Constructor Overloading

- Flexible object creation.
- Supports different initialization scenarios.
- Reduces the need for setter methods after object creation.

---

# Best Practices

✔ Initialize all required properties in constructors.

✔ Use parameterized constructors for meaningful object creation.

✔ Use constructor overloading when multiple initialization options are needed.

✔ Keep constructors simple.

✔ Use descriptive property names.

---

# Common Mistakes

### Forgetting to Initialize Properties

Incorrect

```csharp
public Car()
{
}
```

Properties remain uninitialized.

---

### Using Constructors Like Methods

Incorrect

```csharp
Car();
```

Constructors are called automatically during object creation.

---

### Giving Constructors a Return Type

Incorrect

```csharp
public void Car()
```

Constructors never have a return type.

---

### Confusing Constructors with Methods

Constructors initialize objects.

Methods perform actions.

---

# Flowchart

```
            Start
               │
               ▼
     Define Car Class
               │
               ▼
 Create Object using
 Default Constructor
               │
               ▼
 Display Details
               │
               ▼
 Create Object using
 Parameterized Constructor
               │
               ▼
 Display Details
               │
               ▼
              End
```

---

# Real-World Applications

Constructors are used extensively in:

- ASP.NET Core
- Entity Framework Core
- Web APIs
- Windows Forms
- WPF Applications
- Game Development
- Banking Systems
- Inventory Management
- Student Management Systems

Almost every object created in a C# application uses a constructor.

---

# Interview Questions

## 1. What is a constructor?

A constructor is a special method that initializes an object when it is created.

---

## 2. What is the difference between a class and an object?

A class is a blueprint, while an object is an instance of that class.

---

## 3. What is a default constructor?

A default constructor is a constructor that takes no parameters and initializes an object with default values.

---

## 4. What is a parameterized constructor?

A parameterized constructor accepts arguments and initializes an object with custom values.

---

## 5. Can constructors be overloaded?

Yes. A class can contain multiple constructors with different parameter lists.

---

## 6. Can a constructor have a return type?

No. Constructors never have a return type.

---

## 7. When is a constructor called?

A constructor is called automatically when an object is created using the `new` keyword.

---

## 8. What is constructor overloading?

Constructor overloading means defining multiple constructors with different parameter lists in the same class.

---

## 9. Why are constructors important?

They ensure objects are initialized properly before use and simplify object creation.

---

## 10. Where are constructors commonly used?

Constructors are used throughout .NET applications, including ASP.NET Core, Entity Framework Core, desktop applications, Web APIs, and console applications.

---

# Summary

In this assignment, you learned:

- Object-Oriented Programming (OOP)
- Classes
- Objects
- Properties
- Constructors
- Default Constructor
- Parameterized Constructor
- Constructor Overloading
- Methods
- Best Practices
- Interview Questions

Constructors are one of the core building blocks of Object-Oriented Programming. They ensure that objects are initialized correctly and consistently. Understanding constructors is essential for developing robust C# applications, and they are used extensively in **ASP.NET Core**, **Entity Framework Core**, **Web APIs**, and enterprise software.