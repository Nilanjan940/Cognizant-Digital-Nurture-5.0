# Assignment 25: Use FileStream and MemoryStream

## Objective

Learn how to work with files and memory streams in C# using the **System.IO** namespace.

This assignment demonstrates:

- Reading files
- Writing files
- Working with streams
- Understanding byte arrays
- Using MemoryStream

---

# Problem Statement

Write a C# program that:

- Accepts a filename from the user.
- Writes text into the file using **FileStream**.
- Reads the same file using **FileStream**.
- Displays the file contents.
- Writes data into a **MemoryStream**.
- Displays the number of bytes written.
- Reads and prints the data stored in memory.

---

# Learning Outcomes

After completing this assignment, you will understand:

- Streams
- FileStream
- MemoryStream
- Byte Arrays
- UTF-8 Encoding
- File Handling
- IDisposable
- using Statement

---

# Prerequisites

You should know:

- Classes
- Methods
- Arrays
- User Input
- Strings

Namespaces required

```csharp
using System.IO;
using System.Text;
```

---

# Theory

# What is a Stream?

A **Stream** is a sequence of bytes that allows data to move between a source and a destination.

Examples

- File
- Memory
- Network
- Database
- Printer

Think of a stream like a water pipe.

```
Source  ========> Destination
```

Instead of water,

bytes flow through the stream.

---

# Types of Streams

```
Stream
│
├── FileStream
├── MemoryStream
├── NetworkStream
├── BufferedStream
├── CryptoStream
└── GZipStream
```

All these inherit from the **Stream** class.

---

# FileStream

A **FileStream** reads and writes data directly from files.

Example

```csharp
FileStream fs =
new FileStream("sample.txt",
FileMode.Open);
```

FileStream works with bytes.

---

# FileMode

FileMode determines how a file is opened.

Common modes

| FileMode | Description |
|----------|-------------|
| Create | Creates a new file |
| Open | Opens an existing file |
| OpenOrCreate | Opens or creates |
| Append | Adds data at end |
| Truncate | Deletes existing contents |
| CreateNew | Creates a new file only |

---

# FileAccess

Specifies permissions.

```text
Read
Write
ReadWrite
```

Example

```csharp
FileAccess.Read
```

---

# Byte Arrays

Computers store files as bytes.

Example

```csharp
byte[] bytes;
```

Strings must first be converted into bytes.

---

# UTF-8 Encoding

Converting text

```csharp
Encoding.UTF8.GetBytes(text);
```

Converting bytes back

```csharp
Encoding.UTF8.GetString(bytes);
```

---

# MemoryStream

A **MemoryStream** stores data in RAM instead of a file.

```
RAM
│
├── Faster
├── Temporary
└── Automatically destroyed
```

Example

```csharp
MemoryStream ms =
new MemoryStream();
```

---

# Why Use MemoryStream?

MemoryStream is useful when:

- Creating PDFs
- Generating Images
- Compressing Files
- Receiving API Responses
- Temporary Data Storage

---

# using Statement

Example

```csharp
using(FileStream fs = ...)
{
}
```

Benefits

- Automatically closes the stream.
- Releases resources.
- Prevents memory leaks.

---

# IDisposable

Classes like FileStream implement **IDisposable**.

Always dispose them after use.

The `using` statement does this automatically.

---

# Program Workflow

```
User Input
     │
     ▼
Create File
     │
     ▼
Write Text
     │
     ▼
Close File
     │
     ▼
Open File
     │
     ▼
Read Data
     │
     ▼
Display Text
     │
     ▼
Create MemoryStream
     │
     ▼
Write Bytes
     │
     ▼
Display Bytes
```

---

# Program Explanation

## Step 1

Accept filename.

```csharp
Console.ReadLine();
```

---

## Step 2

Create FileStream.

```csharp
new FileStream(...)
```

---

## Step 3

Convert string to bytes.

```csharp
Encoding.UTF8.GetBytes()
```

---

## Step 4

Write bytes.

```csharp
fileStream.Write(...)
```

---

## Step 5

Read bytes.

```csharp
fileStream.Read(...)
```

---

## Step 6

Convert bytes into string.

```csharp
Encoding.UTF8.GetString(...)
```

---

## Step 7

Create MemoryStream.

```csharp
MemoryStream ms = new();
```

---

## Step 8

Write bytes into memory.

```csharp
memoryStream.Write(...)
```

---

## Step 9

Display byte count.

```csharp
memoryStream.Length
```

---

# FileStream vs MemoryStream

| FileStream | MemoryStream |
|------------|--------------|
| Stores data on disk | Stores data in RAM |
| Permanent | Temporary |
| Slower | Faster |
| Requires file | No file required |

---

# Advantages of FileStream

- Efficient for large files
- Supports binary data
- Fine-grained file control
- Supports reading and writing

---

# Advantages of MemoryStream

- Extremely fast
- No disk access
- Temporary storage
- Ideal for APIs and image processing

---

# Best Practices

✔ Always use the `using` statement.

✔ Close streams properly.

✔ Use UTF-8 encoding.

✔ Handle exceptions.

✔ Avoid leaving files open.

---

# Common Mistakes

### Forgetting to Dispose Streams

Incorrect

```csharp
FileStream fs = new FileStream(...);
```

Correct

```csharp
using(FileStream fs = ...)
{
}
```

---

### Forgetting Encoding

Incorrect

```csharp
fs.Write(text);
```

Correct

```csharp
Encoding.UTF8.GetBytes(text);
```

---

### Reading Without Resetting Position

For MemoryStream

```csharp
memoryStream.Position = 0;
```

Otherwise reading may start from the end.

---

# Flowchart

```
          Start
             │
             ▼
 Read File Name
             │
             ▼
 Write File
             │
             ▼
 Read File
             │
             ▼
 Display Content
             │
             ▼
 Create MemoryStream
             │
             ▼
 Write Bytes
             │
             ▼
 Display Bytes
             │
             ▼
             End
```

---

# Real-World Applications

FileStream is used in:

- Log files
- Reports
- CSV files
- PDF generation
- Image storage
- File upload/download

MemoryStream is used in:

- Web APIs
- ASP.NET Core
- Image processing
- File compression
- Encryption
- Email attachments
- Cloud applications

---

# Interview Questions

## 1. What is a Stream in C#?

A Stream is a sequence of bytes used for reading or writing data between a source and a destination.

---

## 2. What is FileStream?

FileStream is used to read and write data to physical files on disk.

---

## 3. What is MemoryStream?

MemoryStream stores data in memory (RAM) instead of on disk, making it suitable for temporary and fast operations.

---

## 4. Why is UTF-8 encoding used?

UTF-8 converts text into bytes for storage and converts bytes back into readable text.

---

## 5. Why should FileStream be wrapped in a `using` statement?

The `using` statement ensures that the stream is automatically disposed and the file handle is released.

---

## 6. What is the difference between FileStream and MemoryStream?

FileStream stores data in files, while MemoryStream stores data in RAM.

---

## 7. What is FileMode?

`FileMode` specifies how a file should be opened or created, such as `Create`, `Open`, or `Append`.

---

## 8. What is FileAccess?

`FileAccess` defines the allowed operations on a file, such as `Read`, `Write`, or `ReadWrite`.

---

## 9. Why is `memoryStream.Position = 0` required?

After writing, the stream's position is at the end. Resetting it to `0` allows reading from the beginning.

---

## 10. Where are FileStream and MemoryStream commonly used?

- ASP.NET Core
- Web APIs
- File Upload Systems
- Logging
- Image Processing
- PDF Generation
- Cloud Storage
- Data Serialization

---

# Summary

In this assignment, you learned:

- Streams
- FileStream
- MemoryStream
- Byte Arrays
- UTF-8 Encoding
- File Handling
- IDisposable
- using Statement
- Best Practices
- Interview Questions

FileStream and MemoryStream are foundational I/O classes in .NET. They are heavily used in **ASP.NET Core**, **Web APIs**, **Azure**, **cloud storage**, **file upload/download services**, **image processing**, and **enterprise applications** for efficient handling of data.