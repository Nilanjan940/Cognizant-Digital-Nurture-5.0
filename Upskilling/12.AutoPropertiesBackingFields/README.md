# Assignment 12: Use Auto-Properties and Backing Fields

## Objective

Learn how to use **auto-implemented properties** and **backing fields** in C#. This assignment demonstrates how properties can simplify code while backing fields allow validation and controlled access to data.

---

# Problem Statement

Create a C# program that:

- Defines a `Product` class.
- Uses an auto-implemented property for `Name`.
- Uses a backing field for `Price`.
- Validates that the price cannot be negative.
- Accepts product details from the user.
- Displays product information.
- Updates the price and demonstrates validation.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Properties
- Auto-Implemented Properties
- Backing Fields
- Getter (`get`)
- Setter (`set`)
- Encapsulation
- Data Validation
- Constructors

---

# Prerequisites

You should know:

- Classes
- Objects
- Constructors
- Variables
- Methods
- Basic OOP Concepts

---

# Theory

# What is a Property?

A property provides controlled access to a class field.

Instead of directly exposing variables, properties allow validation and additional logic.

Example

```csharp
public string Name { get; set; }
```

---

# What is an Auto-Implemented Property?

An auto-implemented property allows the compiler to automatically create a hidden backing field.

Example

```csharp
public string Name { get; set; }
```

Equivalent to

```csharp
private string name;

public string Name
{
    get { return name; }
    set { name = value; }
}
```

but with much less code.

---

# Advantages of Auto-Implemented Properties

- Less code
- Easy to read
- Cleaner syntax
- Compiler automatically creates the backing field
- Ideal when no validation is required

---

# What is a Backing Field?

A backing field is a private variable that stores the actual data for a property.

Example

```csharp
private double _price;
```

The property accesses this field through `get` and `set`.

---

# Why Use a Backing Field?

Backing fields allow you to:

- Validate input
- Restrict values
- Perform calculations
- Trigger additional actions
- Protect object state

Your program uses a backing field to ensure that the price cannot be negative.

---

# Getter (`get`)

The `get` accessor returns the value stored in the backing field.

Example

```csharp
get
{
    return _price;
}
```

---

# Setter (`set`)

The `set` accessor assigns a value to the backing field.

Example

```csharp
set
{
    _price = value;
}
```

In your program, the setter also validates the input.

---

# Property Validation

Your `Price` property checks whether the entered value is valid.

```csharp
if(value >= 0)
{
    _price = value;
}
else
{
    Console.WriteLine("Price cannot be negative.");
    _price = 0;
}
```

If the user enters a negative value, the program prevents invalid data from being stored.

---

# Encapsulation

Encapsulation is the practice of hiding internal data and exposing controlled access through properties or methods.

Instead of allowing direct modification of `_price`, the property ensures only valid values are stored.

```
User
   │
   ▼
Price Property
   │
Validation
   │
   ▼
Backing Field (_price)
```

---

# Constructor

The constructor initializes the product object.

Example

```csharp
public Product(string name, double price)
{
    Name = name;
    Price = price;
}
```

Notice that assigning `Price = price` invokes the property's validation logic.

---

# Program Workflow

```
Start
   │
   ▼
Read Product Name
   │
   ▼
Read Product Price
   │
   ▼
Create Product Object
   │
   ▼
Validate Price
   │
   ▼
Display Product
   │
   ▼
Read New Price
   │
   ▼
Validate Again
   │
   ▼
Display Updated Product
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Create the `Product` class.

It contains:

- Auto-property (`Name`)
- Backing field (`_price`)
- Property (`Price`)

---

## Step 2

Read product details from the user.

```csharp
Console.ReadLine();
```

---

## Step 3

Create a new object.

```csharp
Product product = new Product(productName, productPrice);
```

---

## Step 4

The constructor initializes the properties.

For `Price`, the setter validates the value.

---

## Step 5

Display the product information.

```csharp
DisplayProduct();
```

---

## Step 6

Update the product price.

```csharp
product.Price = newPrice;
```

Again, validation occurs automatically.

---

# Auto-Property vs Backing Field

| Auto-Property | Backing Field |
|---------------|---------------|
| Compiler creates storage automatically | Programmer creates storage manually |
| Minimal code | More code |
| No custom logic | Supports validation and business rules |
| Best for simple data | Best for controlled access |

---

# Field vs Property

| Field | Property |
|-------|----------|
| Stores data directly | Controls access to data |
| No validation | Supports validation |
| Usually private | Can be public |
| Not recommended for exposing data | Preferred approach in C# |

---

# Advantages of Properties

- Supports encapsulation
- Allows validation
- Improves maintainability
- Enables future enhancements without changing external code

---

# Advantages of Backing Fields

- Data validation
- Prevents invalid values
- Better control over assignments
- Supports custom business rules

---

# Best Practices

✔ Use auto-properties when no validation is needed.

✔ Use backing fields when validation or custom logic is required.

✔ Keep backing fields private.

✔ Expose data through public properties.

✔ Validate user input before storing values.

---

# Common Mistakes

### Making Fields Public

Incorrect

```csharp
public double price;
```

This bypasses validation.

---

### Forgetting Validation

Always validate values before assigning them to important properties.

---

### Exposing Backing Fields

Backing fields should remain private.

Incorrect

```csharp
public double _price;
```

---

### Using Properties Incorrectly

Inside the property setter, assign to the backing field.

Correct

```csharp
_price = value;
```

Avoid assigning to the property itself, which would cause infinite recursion.

---

# Flowchart

```
             Start
                │
                ▼
      Read Product Details
                │
                ▼
     Create Product Object
                │
                ▼
     Validate Product Price
                │
                ▼
      Display Product Data
                │
                ▼
      Update Product Price
                │
                ▼
      Validate New Price
                │
                ▼
 Display Updated Product
                │
                ▼
               End
```

---

# Real-World Applications

Properties and backing fields are used in:

- ASP.NET Core Models
- Entity Framework Core Entities
- Banking Systems
- E-commerce Applications
- Inventory Management
- Student Management Systems
- Payroll Systems
- Hospital Management Systems

Validation through properties is a common practice in enterprise software.

---

# Interview Questions

## 1. What is a property in C#?

A property is a member that provides controlled access to a class field using `get` and `set` accessors.

---

## 2. What is an auto-implemented property?

An auto-implemented property is a property where the compiler automatically creates the backing field.

Example

```csharp
public string Name { get; set; }
```

---

## 3. What is a backing field?

A backing field is a private variable used internally by a property to store data and apply validation or other logic.

---

## 4. Why use a backing field instead of an auto-property?

Use a backing field when validation, calculations, or additional processing is required during assignment or retrieval.

---

## 5. What is the purpose of the `get` accessor?

The `get` accessor returns the current value of the property.

---

## 6. What is the purpose of the `set` accessor?

The `set` accessor assigns a value to the property and can include validation or other business logic.

---

## 7. What is encapsulation?

Encapsulation is the process of hiding internal data and exposing controlled access through properties or methods.

---

## 8. Why should fields generally be private?

Private fields prevent unauthorized access and ensure data can only be modified through controlled interfaces.

---

## 9. Can an auto-property perform validation?

Not directly. If validation is needed, you should use a property with a custom getter/setter and a backing field.

---

## 10. Where are properties commonly used?

Properties are widely used in ASP.NET Core models, Entity Framework Core entities, desktop applications, mobile applications, Web APIs, and enterprise software.

---

# Summary

In this assignment, you learned:

- Properties
- Auto-Implemented Properties
- Backing Fields
- Getter and Setter
- Encapsulation
- Data Validation
- Constructors
- Best Practices
- Interview Questions

Properties are a fundamental feature of C# that provide controlled access to object data. Auto-implemented properties simplify code for straightforward scenarios, while backing fields enable validation and business logic. Together, they promote encapsulation and are extensively used in **ASP.NET Core**, **Entity Framework Core**, **Web APIs**, and other professional .NET applications.