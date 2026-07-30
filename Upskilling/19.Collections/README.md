# Assignment 19: Work with Lists and Dictionaries

## Objective

Learn how to use two of the most commonly used generic collections in C#:

- **List<T>**
- **Dictionary<TKey, TValue>**

These collections are part of the **System.Collections.Generic** namespace and are widely used in desktop, web, and enterprise applications.

---

# Problem Statement

Create a program that:

- Creates a `List<string>` and stores fruit names.
- Creates a `Dictionary<int, string>` to store student records.
- Accepts user input.
- Displays all entries using `foreach`.
- Performs add and remove operations.
- Displays the updated collections.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Generic Collections
- List<T>
- Dictionary<TKey, TValue>
- Adding Elements
- Removing Elements
- Iterating using foreach
- Key-Value Pairs
- Collection Manipulation

---

# Prerequisites

- Variables
- Loops
- Classes and Objects
- Generic Collections
- foreach Loop

---

# Theory

# What are Collections?

Collections are data structures used to store multiple objects.

Instead of creating many variables,

```csharp
string fruit1;
string fruit2;
string fruit3;
```

we can use

```csharp
List<string> fruits = new List<string>();
```

Collections make programs easier to manage and more flexible.

---

# Generic Collections

Generic collections are type-safe collections.

Example

```csharp
List<int>
List<string>
Dictionary<int,string>
```

Advantages

- Faster
- Type Safe
- No Boxing/Unboxing
- Better Performance

Namespace

```csharp
using System.Collections.Generic;
```

---

# List<T>

A List is a dynamic array.

Unlike arrays,

its size can grow or shrink.

Example

```csharp
List<string> fruits = new List<string>();
```

---

## Adding Items

```csharp
fruits.Add("Apple");
```

---

## Removing Items

```csharp
fruits.Remove("Apple");
```

---

## Iterating

```csharp
foreach(string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

---

# Dictionary<TKey,TValue>

A Dictionary stores data as

```
Key → Value
```

Example

```
101 → Rahul
102 → Priya
```

Declaration

```csharp
Dictionary<int,string> students =
new Dictionary<int,string>();
```

---

## Adding Items

```csharp
students.Add(101,"Rahul");
```

or

```csharp
students[101] = "Rahul";
```

---

## Removing Items

```csharp
students.Remove(101);
```

---

## Accessing Values

```csharp
Console.WriteLine(students[101]);
```

---

## Iterating

```csharp
foreach(KeyValuePair<int,string> student in students)
{
    Console.WriteLine(student.Key);
    Console.WriteLine(student.Value);
}
```

---

# Program Explanation

## Part 1

Create a List.

```csharp
List<string> fruits = new List<string>();
```

---

## Part 2

Accept fruit names.

```csharp
fruits.Add(Console.ReadLine());
```

---

## Part 3

Display all fruits.

```csharp
foreach(...)
```

---

## Part 4

Remove one fruit.

```csharp
fruits.Remove(...)
```

---

## Part 5

Create Dictionary.

```csharp
Dictionary<int,string> students
```

---

## Part 6

Store student records.

```
ID → Name
```

---

## Part 7

Display all records.

---

## Part 8

Remove one student.

---

# Common List Methods

| Method | Description |
|---------|-------------|
| Add() | Adds an element |
| Remove() | Removes an element |
| RemoveAt() | Removes by index |
| Insert() | Inserts at an index |
| Clear() | Removes all elements |
| Contains() | Checks whether an item exists |
| Count | Returns total number of items |

---

# Common Dictionary Methods

| Method | Description |
|---------|-------------|
| Add() | Adds a key-value pair |
| Remove() | Removes by key |
| ContainsKey() | Checks key existence |
| ContainsValue() | Checks value existence |
| Clear() | Removes all entries |
| Count | Returns total entries |

---

# List vs Array

| Array | List |
|--------|------|
| Fixed Size | Dynamic Size |
| Faster | Slightly Slower |
| Less Flexible | Highly Flexible |
| Size cannot change | Size changes automatically |

---

# List vs Dictionary

| List | Dictionary |
|------|------------|
| Stores values | Stores key-value pairs |
| Access by index | Access by key |
| Duplicate values allowed | Keys must be unique |
| Ordered | Lookup by key |

---

# Time Complexity

## List

| Operation | Complexity |
|-----------|------------|
| Add (end) | O(1) |
| Access by Index | O(1) |
| Remove | O(n) |
| Search | O(n) |

---

## Dictionary

| Operation | Complexity |
|-----------|------------|
| Add | O(1) Average |
| Search | O(1) Average |
| Remove | O(1) Average |
| Access | O(1) Average |

---

# Advantages

## List

- Dynamic size
- Easy insertion
- Easy deletion
- Simple iteration

---

## Dictionary

- Extremely fast searching
- Unique keys
- Efficient lookups
- Ideal for mappings

---

# Best Practices

✔ Use List when order matters.

✔ Use Dictionary for fast lookups.

✔ Use meaningful keys.

✔ Check before removing items.

✔ Use foreach for iteration.

---

# Common Mistakes

### Forgetting Namespace

```csharp
using System.Collections.Generic;
```

---

### Duplicate Dictionary Keys

```csharp
students.Add(101,"Rahul");
students.Add(101,"Amit");
```

Produces an exception because keys must be unique.

---

### Accessing Missing Keys

```csharp
Console.WriteLine(students[500]);
```

May throw a `KeyNotFoundException`.

Prefer

```csharp
students.ContainsKey(500)
```

---

# Flowchart

```
          Start
             │
             ▼
      Create List
             │
             ▼
      Add Fruits
             │
             ▼
     Display Fruits
             │
             ▼
     Remove Fruit
             │
             ▼
 Create Dictionary
             │
             ▼
 Add Student Records
             │
             ▼
Display Student Records
             │
             ▼
 Remove Student
             │
             ▼
Display Updated Records
             │
             ▼
            End
```

---

# Real-World Applications

## List<T>

- Shopping Cart
- Student List
- Product Catalog
- Employee List
- Recent Files

---

## Dictionary<TKey,TValue>

- Login Credentials
- Student Database
- Product Inventory
- Cache Storage
- Phone Directory
- Configuration Settings

---

# Interview Questions

## 1. What is a List in C#?

A `List<T>` is a dynamic collection that can grow or shrink in size at runtime.

---

## 2. What is a Dictionary?

A `Dictionary<TKey, TValue>` stores data as key-value pairs and provides fast lookup using keys.

---

## 3. Which namespace contains List and Dictionary?

```csharp
System.Collections.Generic
```

---

## 4. Difference between List and Array?

Arrays have a fixed size, while Lists can dynamically resize.

---

## 5. Can a Dictionary have duplicate keys?

No. Dictionary keys must always be unique.

---

## 6. Can a Dictionary have duplicate values?

Yes. Multiple keys can have the same value.

---

## 7. Which collection is faster for searching?

`Dictionary<TKey, TValue>` is generally faster because it uses hashing for average O(1) lookups.

---

## 8. What is a generic collection?

A collection that stores only one specific data type, providing type safety and better performance.

---

## 9. When should you use a List?

Use a `List<T>` when you need an ordered collection that changes in size.

---

## 10. When should you use a Dictionary?

Use a `Dictionary<TKey, TValue>` when you need fast retrieval of values using unique keys.

---

# Summary

In this assignment, you learned:

- Generic Collections
- List<T>
- Dictionary<TKey, TValue>
- Adding and Removing Items
- foreach Iteration
- Key-Value Pairs
- Collection Methods
- Time Complexity
- Best Practices
- Interview Questions

These collections are fundamental in C# and are extensively used in **ASP.NET Core**, **Entity Framework Core**, **Web APIs**, desktop applications, and enterprise software to efficiently manage and retrieve data.