# Assignment 24: Serialize and Deserialize JSON Files

## Objective

Learn how to convert C# objects into JSON format (Serialization) and convert JSON back into C# objects (Deserialization) using the **System.Text.Json** library.

---

# Problem Statement

Create a C# program that:

- Defines a `User` class with:
  - Name
  - Age
  - Email
- Accepts user input.
- Serializes the object into JSON.
- Saves the JSON into a file.
- Reads the JSON file.
- Deserializes the JSON back into a C# object.
- Displays the object's properties.

---

# Learning Outcomes

After completing this assignment, you will understand:

- JSON
- Serialization
- Deserialization
- System.Text.Json
- JsonSerializer
- File Handling
- Object Conversion
- Data Persistence

---

# Prerequisites

You should know:

- Classes and Objects
- Properties
- File Handling
- Methods
- Namespaces

Required namespaces:

```csharp
using System.Text.Json;
using System.IO;
```

---

# Theory

# What is JSON?

JSON stands for

> **JavaScript Object Notation**

It is a lightweight text format used for storing and exchanging data.

Example

```json
{
  "Name": "Rahul",
  "Age": 22,
  "Email": "rahul@gmail.com"
}
```

JSON is:

- Human-readable
- Lightweight
- Language-independent
- Easy to parse

---

# Why JSON?

JSON is the standard format used by:

- REST APIs
- ASP.NET Core Web APIs
- Mobile Apps
- Cloud Applications
- Configuration Files
- Microservices

---

# Serialization

Serialization means converting an object into another format for storage or transmission.

Object

```csharp
User user = new User();
```

↓

JSON

```json
{
  "Name":"Rahul"
}
```

C# Code

```csharp
string json = JsonSerializer.Serialize(user);
```

---

# Deserialization

Deserialization converts JSON back into a C# object.

JSON

↓

Object

```csharp
User user =
JsonSerializer.Deserialize<User>(json);
```

---

# System.Text.Json

`System.Text.Json` is Microsoft's built-in JSON library.

Advantages

- Fast
- Lightweight
- Secure
- Included with .NET Core and .NET 5+

Namespace

```csharp
using System.Text.Json;
```

---

# JsonSerializer Class

Main methods

Serialize

```csharp
JsonSerializer.Serialize(object)
```

Deserialize

```csharp
JsonSerializer.Deserialize<T>()
```

---

# Pretty Printing JSON

Normally JSON is written in one line.

To improve readability,

```csharp
new JsonSerializerOptions
{
    WriteIndented = true
}
```

produces formatted JSON.

---

# File Handling

Writing

```csharp
File.WriteAllText(filePath, jsonString);
```

Reading

```csharp
File.ReadAllText(filePath);
```

---

# Program Workflow

```
User Input
     │
     ▼
Create User Object
     │
     ▼
Serialize Object
     │
     ▼
Convert to JSON
     │
     ▼
Save JSON File
     │
     ▼
Read JSON File
     │
     ▼
Deserialize JSON
     │
     ▼
Display Object
```

---

# Program Explanation

## Step 1

Create the User class.

```csharp
class User
{
    public string Name { get; set; }
}
```

---

## Step 2

Accept user input.

---

## Step 3

Create the object.

```csharp
User user = new User();
```

---

## Step 4

Serialize.

```csharp
JsonSerializer.Serialize(user);
```

---

## Step 5

Write JSON into a file.

```csharp
File.WriteAllText(...)
```

---

## Step 6

Read the file.

```csharp
File.ReadAllText(...)
```

---

## Step 7

Deserialize.

```csharp
JsonSerializer.Deserialize<User>()
```

---

## Step 8

Display the object.

---

# Serialization vs Deserialization

| Serialization | Deserialization |
|---------------|-----------------|
| Object → JSON | JSON → Object |
| Saving data | Reading data |
| Exporting | Importing |

---

# JSON vs XML

| JSON | XML |
|------|-----|
| Lightweight | Verbose |
| Faster | Slower |
| Easy to Read | More Complex |
| Widely Used | Legacy Systems |

---

# Advantages

- Easy data exchange
- Cross-platform
- Human-readable
- Works with APIs
- Lightweight
- Fast parsing

---

# Best Practices

✔ Use `System.Text.Json` in modern .NET applications.

✔ Format JSON with `WriteIndented` for readability during development.

✔ Validate input before serialization.

✔ Handle exceptions while reading and writing files.

✔ Use meaningful property names.

---

# Common Mistakes

### Missing Namespace

```csharp
using System.Text.Json;
```

---

### Forgetting Generic Type

Incorrect

```csharp
JsonSerializer.Deserialize(json);
```

Correct

```csharp
JsonSerializer.Deserialize<User>(json);
```

---

### Invalid JSON

Malformed JSON causes a `JsonException`.

---

### File Not Found

Reading a missing file throws a `FileNotFoundException`.

Always verify the file exists when appropriate.

---

# Flowchart

```
          Start
             │
             ▼
      Read User Input
             │
             ▼
     Create User Object
             │
             ▼
 Serialize to JSON String
             │
             ▼
 Save JSON to File
             │
             ▼
 Read JSON File
             │
             ▼
 Deserialize JSON
             │
             ▼
 Display User Details
             │
             ▼
             End
```

---

# Real-World Applications

JSON is used in:

- ASP.NET Core Web APIs
- REST APIs
- Entity Framework Core
- Mobile Applications
- Microservices
- Configuration Files (appsettings.json)
- Cloud Applications
- Azure Services
- Logging Systems
- Data Exchange

---

# Interview Questions

## 1. What is JSON?

JSON (JavaScript Object Notation) is a lightweight text format for storing and exchanging structured data.

---

## 2. What is Serialization?

Serialization is the process of converting an object into JSON (or another format) for storage or transmission.

---

## 3. What is Deserialization?

Deserialization converts JSON back into an object.

---

## 4. Which namespace is used for JSON in .NET?

```csharp
System.Text.Json
```

---

## 5. What is `JsonSerializer`?

It is the class used to serialize and deserialize JSON in modern .NET.

---

## 6. Why use `WriteIndented = true`?

It formats the JSON with indentation, making it easier for humans to read.

---

## 7. What exceptions can occur while working with JSON?

- `JsonException`
- `FileNotFoundException`
- `IOException`
- `UnauthorizedAccessException`

---

## 8. What is the difference between JSON and XML?

JSON is more lightweight, easier to read, and generally faster to parse than XML.

---

## 9. Where is JSON commonly used?

- Web APIs
- ASP.NET Core
- Mobile Apps
- Cloud Services
- Configuration Files
- Microservices

---

## 10. Why is JSON preferred over XML?

Because it is smaller, faster, easier to parse, and has become the industry standard for modern web and API communication.

---

# Summary

In this assignment, you learned:

- JSON
- Serialization
- Deserialization
- `System.Text.Json`
- `JsonSerializer`
- File Handling
- Object Persistence
- Best Practices
- Interview Questions

JSON serialization and deserialization are fundamental skills for modern C# development. They are used extensively in **ASP.NET Core**, **Web APIs**, **Entity Framework Core**, **Microservices**, **Blazor**, **Azure**, and virtually every application that exchanges or stores structured data.