# Assignment 28: Log with System.Diagnostics.Trace

## Objective

Learn how to log application events using the `System.Diagnostics.Trace` class in C#. Understand how to write log messages to both the console and a text file using `TraceListener` objects.

---

# Problem Statement

Create a C# program that:

- Configures the Trace class.
- Writes log messages to both the console and a file.
- Uses `ConsoleTraceListener` and `TextWriterTraceListener`.
- Logs user input and application events.
- Logs exceptions.
- Properly closes all Trace listeners.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Logging
- System.Diagnostics.Trace
- Trace Listeners
- ConsoleTraceListener
- TextWriterTraceListener
- Trace.WriteLine()
- AutoFlush
- Exception Logging
- Debugging vs Logging
- Logging Best Practices

---

# Prerequisites

Before attempting this assignment, you should know:

- C# Basics
- Classes and Objects
- Methods
- Exception Handling
- File Handling
- Namespaces

---

# Theory

# What is Logging?

Logging is the process of recording information about the execution of an application.

Logs help developers:

- Monitor applications
- Detect bugs
- Track user activity
- Diagnose errors
- Audit important events

Without logging, finding problems in large applications becomes extremely difficult.

---

# Why is Logging Important?

Logging helps to:

- Debug applications
- Monitor production systems
- Detect unexpected behavior
- Record exceptions
- Maintain application history

---

# What is System.Diagnostics.Trace?

`System.Diagnostics.Trace` is a built-in .NET class used for writing diagnostic and logging information.

Unlike `Console.WriteLine()`, Trace allows output to be redirected to different destinations such as:

- Console
- Text files
- Event Viewer
- Custom listeners

---

# Trace Namespace

```csharp
using System.Diagnostics;
```

This namespace contains classes for debugging, tracing, and performance monitoring.

---

# What is Trace.WriteLine()?

`Trace.WriteLine()` writes a message to every configured Trace listener.

Example

```csharp
Trace.WriteLine("Application Started");
```

If multiple listeners are configured, every listener receives the message.

---

# What are Trace Listeners?

A Trace Listener determines where log messages are written.

Examples include:

- Console
- Text File
- Event Log
- XML File
- Custom Destination

---

# ConsoleTraceListener

Writes Trace messages directly to the console.

Example

```csharp
Trace.Listeners.Add(new ConsoleTraceListener());
```

Output

```
Application Started
```

---

# TextWriterTraceListener

Writes Trace messages into a text file.

Example

```csharp
Trace.Listeners.Add(new TextWriterTraceListener("ApplicationLog.txt"));
```

Example log file

```
Application Started
User Logged In
Application Closed
```

---

# Trace.Listeners Collection

Trace maintains a collection of listeners.

Example

```csharp
Trace.Listeners.Add(...)
```

You can add multiple listeners.

```
Trace

│

├── Console Listener

├── File Listener

└── Custom Listener
```

One log message reaches all listeners.

---

# Trace.AutoFlush

Normally Trace stores messages in a buffer.

Setting

```csharp
Trace.AutoFlush = true;
```

forces every message to be written immediately.

Benefits

- Prevents data loss
- Useful during crashes
- Ensures logs remain up to date

---

# Trace.Flush()

Flush writes any remaining buffered messages immediately.

Example

```csharp
Trace.Flush();
```

---

# Trace.Close()

Always close Trace before exiting.

Example

```csharp
Trace.Close();
```

This releases file resources properly.

---

# Logger Class

Instead of calling Trace everywhere,

a Logger class provides a cleaner design.

Example

```csharp
Logger.Log("Application Started");
```

Advantages

- Centralized logging
- Easy maintenance
- Reusable
- Cleaner code

---

# Exception Logging

Errors should always be logged.

Example

```csharp
catch(Exception ex)
{
    Trace.WriteLine(ex.Message);
}
```

This helps developers identify problems quickly.

---

# Logging Levels

Professional applications often classify logs into levels.

Common levels:

- Information
- Warning
- Error
- Critical
- Debug

Example

```
INFO

Application Started

WARNING

Low Disk Space

ERROR

Database Connection Failed

CRITICAL

Application Crash
```

---

# Trace vs Console.WriteLine()

| Console.WriteLine() | Trace.WriteLine() |
|----------------------|-------------------|
| Displays output only on console | Supports multiple outputs |
| Mainly for simple programs | Used in real-world applications |
| Cannot easily redirect output | Can write to files and listeners |
| Not suitable for production logging | Suitable for application logging |

---

# Trace vs Debug

| Trace | Debug |
|--------|-------|
| Works in Debug and Release builds | Typically active only in Debug builds |
| Used for application logging | Used during development |
| Suitable for production diagnostics | Intended for debugging code |

---

# Program Workflow

```
Start

↓

Configure Logger

↓

Add Console Listener

↓

Add File Listener

↓

Read User Input

↓

Log User Input

↓

Perform Operations

↓

Log Results

↓

Exception?

│

├── Yes

│      ↓

│ Log Exception

│

└── No

↓

Log Completion

↓

Flush Logs

↓

Close Logger

↓

End
```

---

# Program Explanation

## Step 1

Import required namespaces.

```csharp
using System.Diagnostics;
```

---

## Step 2

Create a Logger class.

This class handles all logging operations.

---

## Step 3

Configure Trace listeners.

```csharp
ConsoleTraceListener

TextWriterTraceListener
```

Now logs appear on both the console and in a text file.

---

## Step 4

Enable AutoFlush.

```csharp
Trace.AutoFlush = true;
```

Every log is written immediately.

---

## Step 5

Read user input.

```csharp
Console.ReadLine();
```

---

## Step 6

Log user input.

```csharp
Logger.Log(...)
```

---

## Step 7

Perform calculations.

Log important events.

---

## Step 8

Catch exceptions.

```csharp
catch(Exception ex)
```

Write the exception message into the log file.

---

## Step 9

Close Trace.

```csharp
Trace.Close();
```

---

# Sample Log File

```
[10:30:10] Application Started

[10:30:20] User entered name

[10:30:28] User entered age

[10:30:35] User eligible to vote

[10:30:50] Division Result = 20

[10:30:55] Application Finished
```

---

# Advantages of Logging

- Easier debugging
- Production monitoring
- Error diagnosis
- User activity tracking
- System auditing
- Faster maintenance

---

# Best Practices

✔ Log meaningful events.

✔ Log exceptions.

✔ Use timestamps.

✔ Close Trace listeners properly.

✔ Keep sensitive information out of logs.

✔ Separate logging logic into a Logger class.

✔ Use different log levels.

✔ Store logs in a dedicated location.

---

# Common Mistakes

## Forgetting Trace.Close()

May result in incomplete log files.

---

## Logging Sensitive Information

Never log:

- Passwords
- Credit card numbers
- API Keys
- Authentication tokens

---

## Excessive Logging

Logging every minor operation can:

- Slow applications
- Create huge log files
- Make debugging harder

---

## Ignoring Exceptions

Always log caught exceptions.

---

# Flowchart

```
             Start

                │

                ▼

       Configure Logger

                │

                ▼

      Add Trace Listeners

                │

                ▼

      Read User Input

                │

                ▼

        Log User Input

                │

                ▼

      Perform Operation

                │

        ┌───────┴────────┐

        │                │

   Exception?          Success

        │                │

        ▼                ▼

 Log Exception     Log Result

        │                │

        └───────┬────────┘

                ▼

         Flush Logs

                │

                ▼

         Close Logger

                │

                ▼

               End
```

---

# Real-World Applications

Logging is used in:

- Banking Systems
- Hospital Management
- ERP Software
- ASP.NET Core Web APIs
- E-Commerce Websites
- Payment Gateways
- Cloud Applications
- Enterprise Applications
- Microservices
- Game Servers
- Desktop Applications

---

# Interview Questions

## 1. What is logging?

Logging is the process of recording application events, errors, and important information during program execution.

---

## 2. What is `System.Diagnostics.Trace`?

It is a .NET class used for writing diagnostic and logging information to one or more output destinations.

---

## 3. What is a Trace Listener?

A Trace Listener determines where Trace messages are written, such as the console or a text file.

---

## 4. What is `ConsoleTraceListener`?

It writes Trace messages to the console window.

---

## 5. What is `TextWriterTraceListener`?

It writes Trace messages to a text file or any `TextWriter` stream.

---

## 6. What is `Trace.AutoFlush`?

It forces Trace to write messages immediately instead of buffering them.

---

## 7. Why should `Trace.Close()` be called?

To flush remaining messages and release resources such as file handles.

---

## 8. What is the difference between `Trace` and `Debug`?

`Trace` works in both Debug and Release builds, whereas `Debug` is mainly intended for development and is typically active only in Debug builds.

---

## 9. Why is exception logging important?

It helps developers diagnose and fix issues by recording error details when failures occur.

---

## 10. Why should passwords not be logged?

Logging sensitive information creates security risks and may expose confidential user data.

---

## 11. What are common logging levels?

- Information
- Warning
- Error
- Critical
- Debug

---

## 12. Where is logging used in enterprise applications?

Logging is used in monitoring systems, auditing, troubleshooting, security analysis, performance monitoring, and production support.

---

# Summary

In this assignment, you learned:

- Logging Fundamentals
- System.Diagnostics.Trace
- Trace Listeners
- ConsoleTraceListener
- TextWriterTraceListener
- Trace.WriteLine()
- AutoFlush
- Flush()
- Close()
- Exception Logging
- Debug vs Trace
- Logging Best Practices
- Common Mistakes
- Real-world Applications
- Interview Questions

Logging is an essential part of professional software development. By using `System.Diagnostics.Trace` with multiple listeners, you can record application events to different destinations, making debugging, monitoring, and maintaining applications significantly easier. Proper logging improves software reliability and is widely used in enterprise .NET applications.