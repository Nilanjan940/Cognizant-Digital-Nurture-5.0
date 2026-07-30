# Assignment 23: Simulate Async File Upload with Exception Handling

## Objective

Learn how to write asynchronous programs in C# using **async** and **await**, simulate a file upload using `Task.Delay()`, and handle exceptions using **try-catch-finally**.

---

# Problem Statement

Create a C# program that:

- Accepts a file name from the user.
- Simulates uploading the file by waiting for **3 seconds**.
- Returns a success message after the delay.
- Uses exception handling to manage invalid input.
- Displays an appropriate message whether the upload succeeds or fails.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Asynchronous Programming
- async Keyword
- await Keyword
- Task Class
- Task.Delay()
- Exception Handling
- try-catch-finally
- ArgumentException

---

# Prerequisites

You should know:

- Methods
- User Input
- Return Values
- Classes
- Exception Handling Basics

Required Namespace

```csharp
using System.Threading.Tasks;
```

---

# Theory

# What is Asynchronous Programming?

Normally, a program executes one statement after another.

If a task takes a long time (for example, uploading a file), the application may become unresponsive.

Asynchronous programming allows the program to continue doing other work while waiting for long-running operations to finish.

---

# Synchronous vs Asynchronous

## Synchronous

```
Start
   │
Upload File
   │
Wait...
   │
Finish
```

The application waits until the upload completes.

---

## Asynchronous

```
Start
   │
Begin Upload
   │
Continue Other Work
   │
Upload Completes
   │
Finish
```

The application remains responsive.

---

# What is async?

The `async` keyword tells the compiler that a method contains asynchronous operations.

Example

```csharp
async Task UploadAsync()
{
}
```

An async method usually returns:

- Task
- Task<T>
- void (only for event handlers)

---

# What is await?

The `await` keyword pauses the async method until the awaited task completes.

Example

```csharp
await Task.Delay(3000);
```

Unlike `Thread.Sleep()`, it does not block the thread.

---

# What is Task?

A `Task` represents an asynchronous operation.

Examples

```csharp
Task
```

No return value.

```csharp
Task<string>
```

Returns a string.

```csharp
Task<int>
```

Returns an integer.

---

# Task.Delay()

`Task.Delay()` waits asynchronously for a specified amount of time.

Example

```csharp
await Task.Delay(3000);
```

This waits for **3 seconds** without blocking the executing thread.

---

# Exception Handling

Exception handling prevents a program from crashing unexpectedly.

Syntax

```csharp
try
{
}
catch(Exception ex)
{
}
finally
{
}
```

---

# try Block

Contains code that may throw an exception.

Example

```csharp
try
{
    await UploadFileAsync(fileName);
}
```

---

# catch Block

Handles errors.

Example

```csharp
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
```

---

# finally Block

Executes whether an exception occurs or not.

It is commonly used to:

- Close files
- Close database connections
- Release resources
- Display cleanup messages

---

# Throwing an Exception

You can generate your own exceptions using `throw`.

Example

```csharp
throw new ArgumentException("Invalid File Name");
```

---

# Program Explanation

## Step 1

Accept the file name from the user.

```csharp
Console.ReadLine();
```

---

## Step 2

Call the asynchronous upload method.

```csharp
await UploadFileAsync(fileName);
```

---

## Step 3

Simulate upload time.

```csharp
await Task.Delay(3000);
```

---

## Step 4

Validate the input.

```csharp
if(string.IsNullOrWhiteSpace(fileName))
```

Throw an exception if the file name is invalid.

---

## Step 5

Handle exceptions using `try-catch`.

---

## Step 6

Execute the `finally` block.

---

# Advantages of Asynchronous Programming

- Improves application responsiveness.
- Better user experience.
- Efficient resource usage.
- Ideal for I/O operations.
- Supports scalable applications.

---

# async vs Thread

| async/await | Thread |
|-------------|--------|
| Lightweight | Heavier |
| Easier to write | More complex |
| Doesn't block waiting operations | Can block execution |
| Best for I/O-bound tasks | Better suited for CPU-bound work |

---

# Task vs Thread

| Task | Thread |
|------|--------|
| Represents asynchronous work | Represents an OS thread |
| Managed by the Task Parallel Library | Managed by the operating system |
| More efficient for many scenarios | Higher overhead |

---

# Best Practices

✔ Use `async` and `await` together.

✔ Return `Task` or `Task<T>` from asynchronous methods.

✔ Catch specific exceptions before general ones.

✔ Use `Task.Delay()` instead of `Thread.Sleep()` in async code.

✔ Keep asynchronous methods focused and simple.

---

# Common Mistakes

### Forgetting await

```csharp
UploadFileAsync(fileName);
```

The task starts, but the caller doesn't wait for completion.

Correct

```csharp
await UploadFileAsync(fileName);
```

---

### Using Thread.Sleep()

Avoid

```csharp
Thread.Sleep(3000);
```

Prefer

```csharp
await Task.Delay(3000);
```

---

### Catching Only Exception

Prefer catching specific exceptions first.

Example

```csharp
catch(ArgumentException ex)
```

before

```csharp
catch(Exception ex)
```

---

# Flowchart

```
          Start
             │
             ▼
Read File Name
             │
             ▼
Call UploadFileAsync()
             │
             ▼
Wait 3 Seconds
             │
             ▼
Valid File Name?
      ┌──────┴──────┐
      │             │
     Yes            No
      │             │
      ▼             ▼
Return Success   Throw Exception
      │             │
      └──────┬──────┘
             ▼
 Handle Exception
             │
             ▼
 Execute finally
             │
             ▼
            End
```

---

# Real-World Applications

Asynchronous programming is widely used in:

- ASP.NET Core Web APIs
- File Upload Systems
- Cloud Storage Applications
- Database Operations
- HTTP Requests
- Email Services
- Download Managers
- Mobile Applications

---

# Interview Questions

## 1. What is asynchronous programming?

It is a programming technique that allows long-running tasks to execute without blocking the main thread.

---

## 2. What is the purpose of the `async` keyword?

It marks a method as asynchronous and enables the use of `await`.

---

## 3. What does the `await` keyword do?

It asynchronously waits for a task to complete without blocking the calling thread.

---

## 4. What is a `Task`?

A `Task` represents an asynchronous operation that may or may not return a value.

---

## 5. What is the difference between `Task` and `Task<T>`?

| Task | Task<T> |
|------|---------|
| No return value | Returns a value of type `T` |

---

## 6. Why is `Task.Delay()` preferred over `Thread.Sleep()` in async methods?

`Task.Delay()` does not block the executing thread, allowing better responsiveness and scalability.

---

## 7. What is the purpose of the `finally` block?

It executes regardless of whether an exception occurs and is typically used for cleanup operations.

---

## 8. What is an `ArgumentException`?

It is thrown when a method receives an invalid argument, such as an empty file name in this assignment.

---

## 9. Can `Main()` be asynchronous?

Yes. Starting with C# 7.1, `Main()` can be declared as:

```csharp
static async Task Main(string[] args)
```

---

## 10. Where is asynchronous programming commonly used?

- ASP.NET Core
- Web APIs
- Entity Framework Core
- Cloud Applications
- File Processing
- Network Programming
- Desktop Applications
- Mobile Apps

---

# Summary

In this assignment, you learned:

- Asynchronous Programming
- `async` and `await`
- `Task` and `Task<T>`
- `Task.Delay()`
- Exception Handling
- `try-catch-finally`
- `ArgumentException`
- Best Practices
- Interview Questions

Asynchronous programming is one of the most important concepts in modern C#. It enables applications to remain responsive while performing long-running operations such as file uploads, database queries, and network communication.