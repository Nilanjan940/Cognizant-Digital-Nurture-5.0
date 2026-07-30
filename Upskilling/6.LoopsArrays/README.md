# Assignment 6: Loop Through an Array with Different Loop Types

## Objective

Learn how to iterate through an array using different looping constructs in C#. This assignment demonstrates the use of **for**, **foreach**, **while**, and **do-while** loops, along with the `break` and `continue` statements.

---

# Problem Statement

Create a C# program that:

- Accepts the size of an array from the user.
- Accepts array elements from the user.
- Traverses the array using:
  - for loop
  - foreach loop
  - while loop
  - do-while loop
- Uses `continue` to skip specific values.
- Uses `break` to stop iteration when a particular value is encountered.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Arrays
- Array Traversal
- for Loop
- foreach Loop
- while Loop
- do-while Loop
- break Statement
- continue Statement
- User Input

---

# Prerequisites

You should know:

- Variables
- Arrays
- Operators
- User Input
- Basic C# Syntax

---

# Theory

# What is a Loop?

A loop repeatedly executes a block of code until a specified condition becomes false.

General Flow

```
Condition
    │
 ┌──┴──┐
 │     │
True  False
 │      │
Repeat End
```

Loops help eliminate repetitive code.

---

# What is an Array?

An array stores multiple values of the same data type in contiguous memory locations.

Example

```csharp
int[] numbers = {10,20,30,40,50};
```

Memory Representation

```
Index

0   1   2   3   4

10 20 30 40 50
```

---

# The for Loop

The `for` loop is used when the number of iterations is known.

Syntax

```csharp
for(initialization; condition; increment)
{
    // code
}
```

Example

```csharp
for(int i=0;i<n;i++)
{
    Console.WriteLine(numbers[i]);
}
```

Advantages

- Index available
- Easy traversal
- Best for arrays

---

# The foreach Loop

The `foreach` loop is used to iterate over every element in a collection.

Syntax

```csharp
foreach(int number in numbers)
{
    Console.WriteLine(number);
}
```

Characteristics

- No index required
- Simple syntax
- Read-only iteration

---

# The while Loop

The `while` loop executes as long as the condition is true.

Syntax

```csharp
while(condition)
{
    // code
}
```

Example

```csharp
int index = 0;

while(index < n)
{
    Console.WriteLine(numbers[index]);
    index++;
}
```

---

# The do-while Loop

Unlike the while loop, the do-while loop executes at least once.

Syntax

```csharp
do
{
    // code
}
while(condition);
```

Even if the condition is false initially, the loop body executes once.

---

# The break Statement

`break` immediately terminates the nearest loop.

Example

```csharp
if(number == 50)
{
    break;
}
```

Program Flow

```
Loop
 │
 ▼
Condition
 │
 ▼
break
 │
 ▼
Exit Loop
```

---

# The continue Statement

`continue` skips the current iteration and moves to the next iteration.

Example

```csharp
if(number == 30)
{
    continue;
}
```

Program Flow

```
Loop
 │
 ▼
Condition
 │
 ▼
continue
 │
 ▼
Next Iteration
```

---

# Program Workflow

```
Start
   │
   ▼
Read Array Size
   │
   ▼
Read Array Elements
   │
   ▼
Traverse using for Loop
   │
   ▼
Traverse using foreach Loop
   │
   ▼
Traverse using while Loop
   │
   ▼
Traverse using do-while Loop
   │
   ▼
Display Results
   │
   ▼
End
```

---

# Program Explanation

## Step 1

Read the array size.

```csharp
int n = Convert.ToInt32(Console.ReadLine());
```

---

## Step 2

Create an integer array.

```csharp
int[] numbers = new int[n];
```

---

## Step 3

Accept array elements.

```csharp
for(int i=0;i<n;i++)
```

Each element is stored in the array.

---

## Step 4

Traverse using a for loop.

- Skip value `30`
- Stop at value `50`

---

## Step 5

Traverse using a foreach loop.

- Skip value `20`
- Stop at value `60`

---

## Step 6

Traverse using a while loop.

- Skip value `10`
- Stop at value `40`

---

## Step 7

Traverse using a do-while loop.

- Skip value `70`
- Stop at value `80`

---

# Comparison of Loops

| Loop | Index Available | Executes At Least Once | Best Use |
|------|-----------------|------------------------|----------|
| for | Yes | No | Arrays and fixed iterations |
| foreach | No | No | Collections and arrays |
| while | Yes | No | Unknown number of iterations |
| do-while | Yes | Yes | Menu-driven programs |

---

# break vs continue

| break | continue |
|--------|----------|
| Terminates the loop | Skips current iteration |
| Control exits the loop | Control moves to next iteration |
| Used to stop processing | Used to ignore certain values |

---

# Advantages of Arrays

- Fast element access
- Easy traversal
- Fixed size
- Efficient memory usage

---

# Advantages of foreach

- Cleaner syntax
- No index management
- Less error-prone
- Easy to read

---

# Best Practices

✔ Use `for` when index values are required.

✔ Use `foreach` for simple read-only traversal.

✔ Use `while` when the number of iterations is unknown.

✔ Use `do-while` when the loop must execute at least once.

✔ Use `break` only when necessary.

✔ Use `continue` sparingly to improve readability.

---

# Common Mistakes

### Forgetting to Increment the Index

Incorrect

```csharp
while(index < n)
{
    Console.WriteLine(numbers[index]);
}
```

Results in an infinite loop.

---

### Accessing an Invalid Index

Always ensure

```csharp
index < n
```

before accessing the array.

---

### Using foreach to Modify Elements

The iteration variable in `foreach` is read-only.

---

### Using do-while with an Empty Array

Since a do-while loop executes at least once, ensure the array contains elements before accessing `numbers[0]`.

---

# Flowchart

```
             Start
                │
                ▼
        Read Array Size
                │
                ▼
      Read Array Elements
                │
                ▼
        Execute for Loop
                │
                ▼
     Execute foreach Loop
                │
                ▼
       Execute while Loop
                │
                ▼
     Execute do-while Loop
                │
                ▼
        Display Results
                │
                ▼
               End
```

---

# Real-World Applications

Loops and arrays are fundamental in:

- Data Processing
- Student Management Systems
- Banking Applications
- Inventory Management
- Payroll Systems
- Web APIs
- Game Development
- Scientific Computing

---

# Interview Questions

## 1. What is an array?

An array is a collection of elements of the same data type stored in contiguous memory locations.

---

## 2. Which loop is best for arrays?

The `for` loop is generally preferred because it provides access to the array index.

---

## 3. What is the difference between `for` and `foreach`?

`for` provides index access, while `foreach` directly accesses each element without exposing the index.

---

## 4. What is the difference between `while` and `do-while`?

A `while` loop checks the condition before executing, whereas a `do-while` loop executes the body at least once before checking the condition.

---

## 5. What does the `break` statement do?

It immediately terminates the nearest enclosing loop or switch statement.

---

## 6. What does the `continue` statement do?

It skips the remaining statements in the current iteration and proceeds to the next iteration.

---

## 7. Can we modify array elements using `foreach`?

You can modify the array by using its index, but the iteration variable itself in a `foreach` loop is read-only.

---

## 8. When should you use a `foreach` loop?

Use `foreach` when you only need to read elements and do not require the index.

---

## 9. What happens if an array index exceeds its bounds?

The runtime throws an `IndexOutOfRangeException`.

---

## 10. Where are loops used in real-world applications?

Loops are used in file processing, database operations, collections, web applications, games, data analysis, and almost every software application.

---

# Summary

In this assignment, you learned:

- Arrays
- Array Traversal
- for Loop
- foreach Loop
- while Loop
- do-while Loop
- break Statement
- continue Statement
- Best Practices
- Interview Questions

Looping constructs are fundamental to programming. Understanding when to use each type of loop and how to control iteration with `break` and `continue` is essential for developing efficient C# applications. These concepts are widely used in **ASP.NET Core**, **Entity Framework Core**, **Web APIs**, desktop applications, and enterprise software.