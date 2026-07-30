# Assignment 20: Use LINQ for Filtering and Projection

## Objective

Learn how to use **Language Integrated Query (LINQ)** to query collections efficiently using filtering and projection.

---

# Problem Statement

Create a list of `Order` objects containing:

- OrderId
- CustomerName
- TotalAmount

Use LINQ to:

- Filter orders based on minimum amount.
- Project selected properties into an anonymous type.
- Display the filtered results.

---

# Learning Outcomes

After completing this assignment, you will understand:

- LINQ
- Filtering
- Projection
- Anonymous Types
- Lambda Expressions
- Extension Methods
- IEnumerable
- Querying Collections

---

# Prerequisites

- Classes and Objects
- List<T>
- foreach Loop
- Lambda Expressions
- Namespaces

```csharp
using System.Linq;
```

---

# What is LINQ?

LINQ stands for

> **Language Integrated Query**

It allows querying data directly in C#.

Instead of writing loops,

```csharp
foreach(...)
{
    ...
}
```

we can simply write

```csharp
orders.Where(...)
```

LINQ makes code

- Cleaner
- Shorter
- Easier to read
- Easier to maintain

---

# Why was LINQ Introduced?

Before LINQ,

filtering collections required loops.

Example

```csharp
foreach(Order order in orders)
{
    if(order.TotalAmount > 1000)
    {
        Console.WriteLine(order.CustomerName);
    }
}
```

Using LINQ

```csharp
orders.Where(order => order.TotalAmount > 1000);
```

Much shorter.

---

# Namespace Required

```csharp
using System.Linq;
```

Without this namespace,

LINQ methods like

- Where()
- Select()
- OrderBy()

cannot be used.

---

# Lambda Expressions

LINQ commonly uses lambda expressions.

Syntax

```csharp
parameter => expression
```

Example

```csharp
order => order.TotalAmount > 1000
```

Read as

> "Take each order and check whether its amount is greater than 1000."

---

# Filtering using Where()

The `Where()` method filters data.

Syntax

```csharp
collection.Where(condition)
```

Example

```csharp
orders.Where(order => order.TotalAmount >= 1000)
```

Only matching records are returned.

---

# Projection using Select()

Projection means selecting only required information.

Instead of returning the whole object,

we can return selected fields.

Example

```csharp
orders.Select(order => new
{
    order.OrderId,
    order.CustomerName
});
```

---

# Anonymous Types

Anonymous types allow temporary objects without creating a class.

Example

```csharp
var data = new
{
    Name = "Rahul",
    Age = 22
};
```

Compiler automatically creates the type.

---

# LINQ Execution Flow

```
Collection
     │
     ▼
Where()
     │
     ▼
Matching Records
     │
     ▼
Select()
     │
     ▼
Anonymous Objects
     │
     ▼
Display Output
```

---

# Program Explanation

## Step 1

Create List

```csharp
List<Order> orders = new();
```

---

## Step 2

Accept User Input

```csharp
orders.Add(...)
```

---

## Step 3

Filter Data

```csharp
Where(order => order.TotalAmount >= minimumAmount)
```

---

## Step 4

Project Required Fields

```csharp
Select(order => new
{
    order.OrderId,
    order.CustomerName,
    order.TotalAmount
})
```

---

## Step 5

Display Results

```csharp
foreach(var order in filteredOrders)
```

---

# Common LINQ Methods

| Method | Purpose |
|---------|----------|
| Where() | Filter data |
| Select() | Projection |
| OrderBy() | Ascending sort |
| OrderByDescending() | Descending sort |
| First() | First element |
| FirstOrDefault() | First or null/default |
| Last() | Last element |
| Count() | Count records |
| Any() | Checks existence |
| All() | Checks if all satisfy condition |
| Sum() | Total |
| Average() | Average |
| Max() | Maximum |
| Min() | Minimum |

---

# Deferred Execution

LINQ uses **deferred execution**.

The query is not executed immediately.

Execution occurs only when data is actually needed, such as during a `foreach` loop or by calling methods like `ToList()`.

Example

```csharp
var result = orders.Where(o => o.TotalAmount > 1000);
```

No filtering happens yet.

Filtering happens here:

```csharp
foreach(var item in result)
{
    Console.WriteLine(item.CustomerName);
}
```

---

# Advantages of LINQ

- Less code
- Better readability
- Type safety
- Compile-time checking
- Powerful querying
- Works with collections, XML, SQL, Entity Framework, etc.

---

# Best Practices

✔ Use meaningful variable names.

✔ Prefer LINQ over complex loops for querying.

✔ Use `var` for anonymous types.

✔ Avoid multiple unnecessary enumerations.

✔ Keep lambda expressions simple.

---

# Common Mistakes

### Missing Namespace

```csharp
using System.Linq;
```

---

### Forgetting Select()

Sometimes only specific fields are required.

Returning the complete object wastes memory.

---

### Confusing Filtering and Projection

Filtering

```csharp
Where()
```

Projection

```csharp
Select()
```

---

### Using First() without Checking

```csharp
orders.First()
```

May throw an exception if the collection is empty.

Prefer

```csharp
FirstOrDefault()
```

---

# Real-World Applications

LINQ is heavily used in

- ASP.NET Core
- Entity Framework Core
- Web APIs
- Blazor
- Desktop Applications
- Data Analytics
- XML Processing
- JSON Processing

---

# Interview Questions

## 1. What is LINQ?

LINQ (Language Integrated Query) is a feature that allows querying data from different data sources using C# syntax.

---

## 2. Which namespace is required for LINQ?

```csharp
using System.Linq;
```

---

## 3. What does `Where()` do?

It filters elements based on a condition.

---

## 4. What does `Select()` do?

It projects selected properties or transforms data into another form.

---

## 5. What is an anonymous type?

An object created without explicitly defining a class.

Example

```csharp
new
{
    Name = "Rahul"
}
```

---

## 6. What is a lambda expression?

A concise way to represent anonymous functions.

Example

```csharp
order => order.TotalAmount > 1000
```

---

## 7. What is deferred execution?

LINQ queries execute only when their results are actually enumerated.

---

## 8. Difference between `Where()` and `Select()`?

| Where() | Select() |
|----------|----------|
| Filters records | Selects or transforms data |
| Returns matching objects | Returns projected data |

---

## 9. Can LINQ work only with Lists?

No.

LINQ works with:

- Arrays
- Lists
- Dictionaries
- XML
- SQL Databases
- Entity Framework
- Any `IEnumerable<T>` source

---

## 10. Why is LINQ preferred?

Because it produces cleaner, more readable, maintainable, and type-safe code compared to manual loops.

---

# Summary

In this assignment, you learned:

- LINQ
- Filtering with `Where()`
- Projection with `Select()`
- Lambda Expressions
- Anonymous Types
- Deferred Execution
- Common LINQ Methods
- Best Practices
- Interview Questions

LINQ is one of the most important features of modern C#. It is extensively used in **ASP.NET Core**, **Entity Framework Core**, **Web APIs**, desktop applications, and enterprise software for querying and manipulating data efficiently.