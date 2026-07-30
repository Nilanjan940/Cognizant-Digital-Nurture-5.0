# Assignment 27: Simulate and Resolve a Deadlock

## Objective

Learn how deadlocks occur in multi-threaded applications and understand how to prevent them using `Monitor.TryEnter()` in C#.

---

# Problem Statement

Create a C# program that:

- Creates two shared lock objects.
- Spawns two threads.
- Simulates a deadlock scenario where each thread acquires one lock and waits for the other.
- Prevents the deadlock using `Monitor.TryEnter()`.
- Displays appropriate messages showing whether a deadlock was avoided.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Processes and Threads
- Multithreading
- Synchronization
- Deadlocks
- Critical Sections
- Monitor Class
- Monitor.TryEnter()
- Lock Ordering
- Deadlock Prevention Techniques
- Thread Safety

---

# Prerequisites

Before attempting this assignment, you should know:

- C# Basics
- Classes and Objects
- Methods
- Loops
- Multithreading
- lock Statement
- Monitor Class

---

# Theory

# What is a Deadlock?

A **deadlock** is a situation where two or more threads wait indefinitely for each other to release resources.

As a result:

- None of the threads continue.
- The application appears frozen.
- CPU usage may become very low.
- The program never completes.

---

# Simple Example

Imagine two people trying to cross a narrow bridge.

Person A waits for Person B.

Person B waits for Person A.

Neither moves.

This is a deadlock.

---

# Deadlock in Programming

Suppose

```
Thread 1

Locks Resource A

↓

Needs Resource B
```

Meanwhile

```
Thread 2

Locks Resource B

↓

Needs Resource A
```

Both threads wait forever.

---

# Visual Representation

```
Thread 1
   │
   ▼
Lock A
   │
Wait for Lock B
```

```
Thread 2
   │
   ▼
Lock B
   │
Wait for Lock A
```

Neither thread can continue.

---

# What Causes Deadlocks?

Deadlocks occur when multiple threads compete for shared resources without proper synchronization.

Common causes include:

- Nested locking
- Improper lock ordering
- Multiple shared resources
- Waiting indefinitely

---

# Coffman Conditions

Four conditions must exist for a deadlock to occur.

---

## 1. Mutual Exclusion

Only one thread can use a resource at a time.

Example

```
Printer

↓

Only one user prints.
```

---

## 2. Hold and Wait

A thread holds one resource while waiting for another.

Example

```
Thread

↓

Lock A

↓

Waiting for Lock B
```

---

## 3. No Preemption

Resources cannot be taken away forcefully.

Only the owning thread releases them.

---

## 4. Circular Wait

Thread A waits for Thread B.

Thread B waits for Thread C.

Thread C waits for Thread A.

```
A → B → C → A
```

This forms a cycle.

---

# What is Synchronization?

Synchronization controls access to shared resources.

Its goals are:

- Prevent data corruption
- Prevent race conditions
- Prevent deadlocks
- Maintain consistency

---

# What is Monitor?

`Monitor` is a synchronization class in .NET.

It provides:

- Enter()
- Exit()
- TryEnter()
- Wait()
- Pulse()

The C# `lock` statement internally uses `Monitor`.

Example

```csharp
lock(lockObject)
{
    // Critical Section
}
```

Equivalent to

```csharp
Monitor.Enter(lockObject);

try
{
    // Critical Section
}
finally
{
    Monitor.Exit(lockObject);
}
```

---

# What is Monitor.TryEnter()?

`Monitor.TryEnter()` attempts to acquire a lock within a specified timeout.

Syntax

```csharp
Monitor.TryEnter(object, milliseconds)
```

If the lock is acquired

```
Returns true
```

Otherwise

```
Returns false
```

This prevents waiting forever.

---

# Why Use Monitor.TryEnter()?

Instead of waiting indefinitely,

the thread waits only for a limited time.

Example

```csharp
if(Monitor.TryEnter(lockObject,2000))
{
    // Work
}
else
{
    Console.WriteLine("Could not acquire lock.");
}
```

---

# How This Assignment Works

Thread 1

```
Acquire Lock 1

↓

Sleep

↓

Try Lock 2
```

Thread 2

```
Acquire Lock 2

↓

Sleep

↓

Try Lock 1
```

Normally

```
Deadlock
```

But

```
Monitor.TryEnter()

↓

Timeout

↓

Thread exits safely
```

---

# Program Workflow

```
Start

↓

Create Lock Objects

↓

Create Two Threads

↓

Thread 1 Acquires Lock 1

↓

Thread 2 Acquires Lock 2

↓

Both Try Second Lock

↓

Monitor.TryEnter()

↓

Lock Available?

      │
 ┌────┴────┐
 │         │
Yes        No
 │         │
 ▼         ▼
Perform   Display
Work      Deadlock Avoided

↓

Release Locks

↓

End
```

---

# Program Explanation

## Step 1

Create two shared lock objects.

```csharp
static readonly object lock1
static readonly object lock2
```

---

## Step 2

Create two thread methods.

```
Thread1Work()

Thread2Work()
```

Each thread performs a different locking sequence.

---

## Step 3

Thread 1 locks

```
Lock 1
```

---

## Step 4

Thread 2 locks

```
Lock 2
```

---

## Step 5

Each thread attempts to acquire the other lock.

Instead of using

```csharp
lock(...)
```

the program uses

```csharp
Monitor.TryEnter()
```

---

## Step 6

If the second lock cannot be obtained

```
Timeout

↓

Display

Deadlock Avoided
```

---

## Step 7

Release all acquired locks.

Program exits normally.

---

# Deadlock Example

Without TryEnter

```
Thread 1

Lock A

↓

Waiting Lock B
```

```
Thread 2

Lock B

↓

Waiting Lock A
```

Result

```
Application Hangs Forever
```

---

# Deadlock Prevention

Using TryEnter

```
Thread 1

↓

Try Lock B

↓

Timeout

↓

Release Lock A
```

Now

Thread 2 continues.

---

# Deadlock Prevention Techniques

## 1. Lock Ordering

Always acquire locks in the same order.

Correct

```
Thread 1

Lock A

↓

Lock B
```

```
Thread 2

Lock A

↓

Lock B
```

Deadlock cannot occur.

---

## 2. Timeout

Use

```csharp
Monitor.TryEnter()
```

instead of waiting forever.

---

## 3. Reduce Nested Locks

Avoid locking multiple resources simultaneously.

---

## 4. Minimize Lock Scope

Lock only the critical section.

---

## 5. Use Concurrent Collections

Instead of manual locking,

use:

- ConcurrentDictionary
- ConcurrentQueue
- ConcurrentBag

---

# lock vs Monitor

| lock | Monitor |
|------|----------|
| Simpler syntax | More flexible |
| Automatically releases lock | Must call Exit() manually |
| No timeout | Supports timeout |
| Internally uses Monitor | Base synchronization class |

---

# Advantages of Monitor.TryEnter()

- Prevents deadlocks
- Supports timeout
- More flexible than lock
- Better control
- Improves reliability

---

# Best Practices

✔ Keep critical sections small.

✔ Release locks quickly.

✔ Always use `try...finally` when using `Monitor.Enter()`.

✔ Use `Monitor.TryEnter()` when waiting indefinitely is undesirable.

✔ Acquire locks in a consistent order.

✔ Avoid unnecessary nested locks.

✔ Prefer concurrent collections where appropriate.

---

# Common Mistakes

## Waiting Forever

Using

```csharp
lock()
```

for multiple resources may cause deadlocks.

---

## Locking in Different Orders

Incorrect

Thread 1

```
A → B
```

Thread 2

```
B → A
```

---

## Forgetting Monitor.Exit()

This leaves the resource permanently locked.

Always use

```csharp
finally
{
    Monitor.Exit(lockObject);
}
```

---

## Large Critical Sections

Holding locks for a long time reduces application performance.

---

# Flowchart

```
             Start
                │
                ▼
      Create Two Lock Objects
                │
                ▼
        Create Two Threads
                │
                ▼
     Thread 1 → Lock 1
     Thread 2 → Lock 2
                │
                ▼
     Try Second Lock
                │
        ┌───────┴────────┐
        │                │
    Lock Acquired     Timeout
        │                │
        ▼                ▼
   Perform Work   Deadlock Avoided
        │                │
        └───────┬────────┘
                ▼
         Release Locks
                │
                ▼
               End
```

---

# Real-World Applications

Deadlock prevention is important in:

- Banking Systems
- ATM Transactions
- Online Payment Gateways
- Inventory Management
- Airline Reservation Systems
- Hospital Management Systems
- Railway Reservation Systems
- ASP.NET Core Applications
- SQL Server Transactions
- Distributed Systems
- Cloud Services
- Game Servers

---

# Interview Questions

## 1. What is a deadlock?

A deadlock is a situation where two or more threads wait indefinitely for each other to release resources, preventing further execution.

---

## 2. What are the Coffman conditions?

1. Mutual Exclusion
2. Hold and Wait
3. No Preemption
4. Circular Wait

All four must exist for a deadlock to occur.

---

## 3. What is `Monitor`?

`Monitor` is a .NET synchronization class used to control access to shared resources.

---

## 4. What is `Monitor.TryEnter()`?

It attempts to acquire a lock within a specified timeout period. If unsuccessful, it returns `false` instead of waiting indefinitely.

---

## 5. How does `lock` differ from `Monitor`?

`lock` is simpler and automatically releases the lock, while `Monitor` provides additional features such as timed lock attempts and explicit control over lock acquisition and release.

---

## 6. Why is `try...finally` used with `Monitor`?

To guarantee that `Monitor.Exit()` is executed even if an exception occurs.

---

## 7. How can deadlocks be prevented?

- Acquire locks in a consistent order.
- Use `Monitor.TryEnter()` with timeouts.
- Minimize nested locking.
- Keep critical sections short.
- Use concurrent collections when appropriate.

---

## 8. What is a critical section?

A section of code that accesses shared resources and must be executed by only one thread at a time.

---

## 9. Can deadlocks occur with a single thread?

No. Deadlocks require multiple threads or processes competing for shared resources.

---

## 10. What is synchronization?

Synchronization coordinates multiple threads to safely access shared resources without causing data corruption or inconsistent behavior.

---

## 11. Why is lock ordering important?

Acquiring locks in the same order across all threads eliminates circular waiting, one of the necessary conditions for deadlocks.

---

## 12. Where is deadlock prevention used?

Deadlock prevention is commonly used in databases, operating systems, banking software, enterprise applications, cloud services, and web servers.

---

# Summary

In this assignment, you learned:

- Deadlocks
- Coffman Conditions
- Critical Sections
- Synchronization
- Monitor Class
- Monitor.TryEnter()
- Lock Ordering
- Deadlock Prevention
- Best Practices
- Common Mistakes
- Real-world Applications
- Interview Questions

Deadlocks are among the most challenging issues in concurrent programming because they can halt an application indefinitely. By understanding why deadlocks occur and applying techniques such as consistent lock ordering, minimizing lock scope, and using `Monitor.TryEnter()` with timeouts, you can build safer and more reliable multi-threaded applications in C#.
```