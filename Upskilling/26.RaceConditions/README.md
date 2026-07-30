# Assignment 26: Demonstrate Race Conditions with Multi-threading

## Objective

Learn how race conditions occur in multi-threaded applications and understand how synchronization using the `lock` statement prevents inconsistent results.

---

# Problem Statement

Create a C# program that:

- Creates a shared counter variable.
- Spawns multiple threads that increment the counter.
- Demonstrates the incorrect result caused by a race condition.
- Uses the `lock` statement to synchronize access.
- Shows the correct result after synchronization.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Processes and Threads
- Multithreading
- Shared Resources
- Race Conditions
- Critical Sections
- Thread Synchronization
- Thread Safety
- The `lock` Statement
- `Monitor` Class
- Mutual Exclusion

---

# Prerequisites

Before attempting this assignment, you should know:

- C# Classes and Objects
- Methods
- Loops
- Variables
- Basic OOP
- Basic Exception Handling

---

# Theory

# What is a Process?

A **process** is an independent program that is currently executing.

Examples:

- Microsoft Word
- Google Chrome
- Visual Studio
- Spotify

Each process has its own:

- Memory
- Resources
- Execution environment

```
Operating System
        │
 ┌──────┼──────┐
 │      │      │
Word  Chrome VS
```

---

# What is a Thread?

A **thread** is the smallest unit of execution inside a process.

A process may contain:

- One thread
- Multiple threads

Example

```
Chrome Process

│
├── UI Thread
├── Rendering Thread
├── Network Thread
├── GPU Thread
```

---

# Process vs Thread

| Process | Thread |
|----------|---------|
| Independent program | Smallest execution unit |
| Own memory | Shares process memory |
| Heavyweight | Lightweight |
| Slower to create | Faster to create |
| Expensive context switching | Faster switching |

---

# What is Multithreading?

Multithreading allows multiple threads to execute simultaneously.

Example

```
Main Thread

│
├── Download File
├── Play Music
├── Update UI
```

Advantages:

- Better responsiveness
- Efficient CPU utilization
- Faster execution
- Improved performance

---

# What is a Shared Resource?

A shared resource is any data that multiple threads can access.

Examples

- Counter variable
- Bank balance
- File
- Database connection
- Queue
- List

Example

```csharp
int counter = 0;
```

All threads modify the same variable.

---

# What is a Race Condition?

A **race condition** occurs when two or more threads access and modify shared data simultaneously without proper synchronization.

Example

Suppose

```
counter = 10
```

Thread A reads

```
10
```

Thread B reads

```
10
```

Thread A increments

```
11
```

Thread B increments

```
11
```

Expected

```
12
```

Actual

```
11
```

One update is lost.

---

# Why Does a Race Condition Occur?

Incrementing

```csharp
counter++;
```

is **not** a single operation.

It consists of:

```
Read
↓

Increment

↓

Write
```

Another thread may interrupt between these steps.

---

# What is a Critical Section?

A critical section is the part of code where shared resources are accessed.

Example

```csharp
counter++;
```

Only one thread should execute this code at a time.

---

# Thread Synchronization

Synchronization coordinates thread execution.

Purpose:

- Prevent race conditions
- Ensure data consistency
- Protect shared resources

Common synchronization techniques:

- lock
- Monitor
- Mutex
- Semaphore
- Interlocked

---

# The lock Statement

The easiest synchronization mechanism in C# is the `lock` statement.

Example

```csharp
lock(lockObject)
{
    counter++;
}
```

Only one thread can enter the block at a time.

---

# How lock Works

```
Thread A
     │
Gets Lock
     │
Executes
     │
Releases Lock
     │
Thread B Enters
```

This guarantees mutual exclusion.

---

# What is Mutual Exclusion?

Mutual exclusion means only **one thread** can access the critical section at any given time.

---

# What is Thread Safety?

Code is **thread-safe** if multiple threads can execute it without causing incorrect results or data corruption.

Using `lock` makes critical sections thread-safe.

---

# Monitor Class

Internally,

```csharp
lock(obj)
```

is equivalent to:

```csharp
Monitor.Enter(obj);

try
{
    // Critical Section
}
finally
{
    Monitor.Exit(obj);
}
```

The compiler automatically generates this code.

---

# Program Workflow

```
Start
   │
   ▼
Initialize Counter
   │
   ▼
Create Multiple Threads
   │
   ▼
Each Thread Increments Counter
   │
   ▼
Without Lock
   │
   ▼
Incorrect Result
   │
   ▼
Reset Counter
   │
   ▼
Use lock Statement
   │
   ▼
Threads Execute Safely
   │
   ▼
Correct Result
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Create a shared variable.

```csharp
int counter = 0;
```

---

## Step 2

Create a lock object.

```csharp
private static readonly object lockObject = new object();
```

---

## Step 3

Spawn multiple threads.

Each thread increments the shared counter thousands of times.

---

## Step 4

Run the program **without synchronization**.

Different threads modify the counter simultaneously.

Result:

```
Expected = 100000

Actual = 98734
```

(The value varies every run.)

---

## Step 5

Use

```csharp
lock(lockObject)
```

around

```csharp
counter++;
```

Now only one thread modifies the counter at a time.

---

## Step 6

Run again.

Output

```
Expected = 100000

Actual = 100000
```

---

# Race Condition Example

Without Lock

```
Counter = 5

Thread A → Read 5

Thread B → Read 5

Thread A → Write 6

Thread B → Write 6

Expected → 7

Actual → 6
```

---

# Synchronized Example

```
Thread A

↓

Gets Lock

↓

Counter++

↓

Releases Lock

↓

Thread B

↓

Gets Lock

↓

Counter++
```

Correct Result.

---

# Advantages of Synchronization

- Prevents race conditions
- Protects shared resources
- Ensures correct results
- Improves reliability
- Prevents data corruption

---

# Best Practices

✔ Lock only the critical section.

✔ Use a dedicated private lock object.

✔ Keep the locked code as short as possible.

✔ Avoid locking on `this` or public objects.

✔ Prefer `Interlocked` for simple atomic operations like incrementing an integer.

---

# Common Mistakes

### Forgetting Synchronization

Incorrect

```csharp
counter++;
```

Multiple threads may corrupt the value.

---

### Locking Large Sections of Code

Holding a lock longer than necessary reduces performance.

---

### Locking on Public Objects

Avoid

```csharp
lock(this)
```

or

```csharp
lock(typeof(MyClass))
```

Other code can accidentally acquire the same lock.

---

### Assuming ++ is Atomic

```csharp
counter++;
```

is **not** atomic.

It performs:

- Read
- Increment
- Write

---

# Flowchart

```
          Start
             │
             ▼
     Initialize Counter
             │
             ▼
    Create Multiple Threads
             │
             ▼
  Access Shared Counter
             │
     ┌───────┴────────┐
     │                │
 Without Lock     With lock
     │                │
     ▼                ▼
 Incorrect       Correct Result
    Result
     │                │
     └───────┬────────┘
             ▼
            End
```

---

# Real-World Applications

Thread synchronization is used in:

- Banking Systems
- ATM Transactions
- Online Shopping
- Airline Reservation Systems
- Hospital Management Systems
- Payroll Systems
- Stock Trading Platforms
- Multiplayer Games
- Database Transactions
- Web Servers
- ASP.NET Core Applications

---

# Interview Questions

## 1. What is a thread?

A thread is the smallest unit of execution within a process.

---

## 2. What is multithreading?

Multithreading is the concurrent execution of multiple threads within a single process.

---

## 3. What is a race condition?

A race condition occurs when multiple threads access and modify shared data simultaneously, leading to unpredictable or incorrect results.

---

## 4. What is a critical section?

A critical section is the part of code that accesses shared resources and must be executed by only one thread at a time.

---

## 5. What is the purpose of the `lock` statement?

The `lock` statement ensures mutual exclusion by allowing only one thread to execute a critical section at a time.

---

## 6. Is `counter++` an atomic operation?

No. It consists of three operations: read, increment, and write.

---

## 7. What is thread safety?

Thread safety means code behaves correctly even when accessed by multiple threads simultaneously.

---

## 8. What is the difference between `lock` and `Monitor`?

`lock` is syntactic sugar that internally uses `Monitor.Enter()` and `Monitor.Exit()`.

---

## 9. Why shouldn't you lock on `this`?

External code can also lock on the same object, increasing the risk of deadlocks and unexpected blocking.

---

## 10. What is `Interlocked.Increment()`?

It performs an atomic increment operation without requiring an explicit `lock`, making it efficient for simple counters.

---

## 11. What are common synchronization mechanisms in .NET?

- lock
- Monitor
- Mutex
- SemaphoreSlim
- ReaderWriterLockSlim
- Interlocked

---

## 12. Where is thread synchronization used in real projects?

It is widely used in ASP.NET Core applications, banking software, inventory management, payment systems, game servers, and any application where multiple threads access shared data.

---

# Summary

In this assignment, you learned:

- Processes and Threads
- Multithreading
- Shared Resources
- Race Conditions
- Critical Sections
- Thread Synchronization
- The `lock` Statement
- `Monitor`
- Thread Safety
- Best Practices
- Common Mistakes
- Real-world Applications
- Interview Questions

Understanding race conditions and synchronization is essential for building reliable multi-threaded applications. Proper use of the `lock` statement (or alternatives such as `Interlocked` when appropriate) helps protect shared resources, ensures data consistency, and prevents subtle bugs in modern .NET applications.