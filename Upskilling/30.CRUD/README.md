# Assignment 30: Perform CRUD Operations using ADO.NET

# Objective

The objective of this assignment is to learn how to interact with a SQL Server database using **ADO.NET**. This includes establishing a database connection, executing SQL commands, and performing **CRUD (Create, Read, Update, Delete)** operations using classes such as `SqlConnection`, `SqlCommand`, `SqlDataReader`, and `SqlDataAdapter`.

---

# Problem Statement

Develop a C# Console Application that:

- Connects to a local SQL Server database.
- Performs CRUD operations on an `Employees` table.
- Uses parameterized SQL queries.
- Displays employee records using both `SqlDataReader` and `SqlDataAdapter`.
- Handles database exceptions gracefully.

---

# Learning Outcomes

After completing this assignment, you will understand:

- ADO.NET Architecture
- Connected and Disconnected Architecture
- SQL Server Connectivity
- SqlConnection
- SqlCommand
- SqlDataReader
- SqlDataAdapter
- DataTable
- Parameterized Queries
- CRUD Operations
- Exception Handling
- SQL Injection Prevention
- Database Programming in C#

---

# Software Requirements

- Visual Studio 2022 / VS Code
- .NET 8 SDK
- SQL Server Express / SQL Server
- SQL Server Management Studio (SSMS)
- Microsoft.Data.SqlClient NuGet Package

Install the SQL Client package:

```bash
dotnet add package Microsoft.Data.SqlClient
```

---

# Database Setup

## Step 1: Create Database

```sql
CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB;
GO
```

---

## Step 2: Create Employees Table

```sql
CREATE TABLE Employees
(
    EmployeeId INT PRIMARY KEY IDENTITY(1,1),
    EmployeeName NVARCHAR(100) NOT NULL,
    Department NVARCHAR(100) NOT NULL,
    Salary DECIMAL(10,2) NOT NULL
);
```

---

# What is ADO.NET?

ADO.NET (ActiveX Data Objects .NET) is Microsoft's data access technology used to communicate with databases from .NET applications.

It enables applications to:

- Connect to databases
- Execute SQL commands
- Read data
- Update data
- Delete data
- Work with disconnected datasets

---

# ADO.NET Architecture

ADO.NET mainly works in two architectures:

## 1. Connected Architecture

A live connection with the database remains open while data is being accessed.

Classes Used:

- SqlConnection
- SqlCommand
- SqlDataReader

Advantages

- Fast
- Less memory usage
- Suitable for real-time applications

Disadvantages

- Database connection remains occupied
- Not ideal for large distributed systems

---

## 2. Disconnected Architecture

Data is copied into memory and the database connection is closed immediately.

Classes Used

- SqlDataAdapter
- DataSet
- DataTable

Advantages

- Better scalability
- Less database load
- Suitable for desktop applications

Disadvantages

- Slightly higher memory usage

---

# Connected vs Disconnected Architecture

| Connected | Disconnected |
|-----------|--------------|
| Uses SqlDataReader | Uses SqlDataAdapter |
| Connection remains open | Connection closes after data retrieval |
| Faster | More scalable |
| Less memory | More memory |
| Read-only streaming | Editable in memory |

---

# ADO.NET Components

## SqlConnection

Represents a connection to SQL Server.

Example

```csharp
SqlConnection connection = new SqlConnection(connectionString);
```

Responsibilities

- Opens connection
- Closes connection
- Manages communication

---

## Connection String

A connection string contains all the information required to connect to SQL Server.

Example

```csharp
Data Source=localhost\SQLEXPRESS;
Initial Catalog=EmployeeDB;
Integrated Security=True;
```

Important Parameters

| Parameter | Description |
|------------|-------------|
| Data Source | SQL Server instance |
| Initial Catalog | Database name |
| Integrated Security | Windows Authentication |
| Encrypt | Encryption |
| Trust Server Certificate | Trust certificate |

---

## SqlCommand

Represents a SQL statement.

Example

```csharp
SqlCommand command =
new SqlCommand(query, connection);
```

Used for

- INSERT
- UPDATE
- DELETE
- SELECT

---

## ExecuteNonQuery()

Used for

- INSERT
- UPDATE
- DELETE

Returns

Number of affected rows.

Example

```csharp
command.ExecuteNonQuery();
```

---

## ExecuteReader()

Used for

SELECT queries.

Returns

SqlDataReader object.

Example

```csharp
SqlDataReader reader =
command.ExecuteReader();
```

---

## SqlDataReader

Reads data one row at a time.

Example

```csharp
while(reader.Read())
{
    Console.WriteLine(reader["EmployeeName"]);
}
```

Characteristics

- Connected
- Forward Only
- Read Only
- Very Fast

---

## SqlDataAdapter

Acts as a bridge between database and memory.

Example

```csharp
SqlDataAdapter adapter =
new SqlDataAdapter(query, connection);
```

---

## DataTable

Stores data in memory.

Example

```csharp
DataTable table =
new DataTable();
```

---

## Fill()

Copies database records into memory.

Example

```csharp
adapter.Fill(table);
```

---

# CRUD Operations

CRUD stands for:

| Operation | SQL Statement |
|------------|--------------|
| Create | INSERT |
| Read | SELECT |
| Update | UPDATE |
| Delete | DELETE |

---

# Create Operation

Adds a new employee.

SQL

```sql
INSERT INTO Employees(...)
VALUES(...)
```

---

# Read Operation

Displays employee records.

SQL

```sql
SELECT * FROM Employees;
```

---

# Update Operation

Updates salary.

SQL

```sql
UPDATE Employees
SET Salary=@Salary
WHERE EmployeeId=@Id;
```

---

# Delete Operation

Deletes employee.

SQL

```sql
DELETE FROM Employees
WHERE EmployeeId=@Id;
```

---

# Parameterized Queries

Instead of

```sql
SELECT * FROM Employees
WHERE Name='John'
```

Use

```csharp
command.Parameters.AddWithValue("@Name",name);
```

Advantages

- Prevents SQL Injection
- Improves performance
- Better readability
- Handles special characters safely

---

# SQL Injection

Bad Example

```sql
' OR 1=1 --
```

Parameterized queries completely prevent this attack.

---

# Exception Handling

Database operations should always be inside:

```csharp
try
{

}
catch(Exception ex)
{

}
```

Benefits

- Prevents application crash
- Displays meaningful error
- Easier debugging

---

# using Statement

Example

```csharp
using(SqlConnection connection =
new SqlConnection(connectionString))
{

}
```

Advantages

- Automatically closes connection
- Prevents memory leaks
- Recommended by Microsoft

---

# Program Workflow

```
Start

↓

Display Menu

↓

User Chooses Operation

↓

Open SQL Connection

↓

Execute SQL Command

↓

Display Result

↓

Close Connection

↓

Repeat

↓

Exit
```

---

# Flowchart

```
               Start
                  │
                  ▼
        Display Main Menu
                  │
                  ▼
      User Selects Operation
                  │
                  ▼
      Open SQL Server Connection
                  │
                  ▼
 Execute SQL Command (CRUD)
                  │
                  ▼
 Display Success / Data
                  │
                  ▼
 Close Connection
                  │
                  ▼
More Operations?
      │        │
     Yes       No
      │        │
      ▼        ▼
 Main Menu    Exit
```

---

# Best Practices

✔ Always use parameterized queries.

✔ Close database connections.

✔ Use `using` blocks.

✔ Validate user input.

✔ Catch exceptions.

✔ Never hardcode passwords.

✔ Store connection strings in configuration files.

✔ Use appropriate SQL data types.

✔ Keep transactions short.

✔ Follow naming conventions.

---

# Common Mistakes

❌ Forgetting to close the connection.

❌ Using string concatenation for SQL queries.

❌ Ignoring exceptions.

❌ Not validating input.

❌ Hardcoding database credentials.

❌ Forgetting to dispose objects.

---

# Real-World Applications

ADO.NET is widely used in:

- Banking Systems
- Hospital Management Systems
- Payroll Systems
- ERP Applications
- HR Management
- Student Information Systems
- E-Commerce Websites
- Inventory Management
- Railway Reservation Systems
- Government Portals

---

# Advantages of ADO.NET

- High Performance
- Secure
- Easy Database Connectivity
- Supports Multiple Databases
- Rich API
- Connected and Disconnected Models
- Strong Integration with .NET

---

# Disadvantages

- More boilerplate code than ORMs
- Manual SQL writing
- Less productive for very large projects
- Requires SQL knowledge

---

# Interview Questions

## 1. What is ADO.NET?

ADO.NET is Microsoft's data access framework for communicating with databases in .NET applications.

---

## 2. What are the main components of ADO.NET?

- SqlConnection
- SqlCommand
- SqlDataReader
- SqlDataAdapter
- DataSet
- DataTable

---

## 3. What is the difference between ExecuteReader() and ExecuteNonQuery()?

ExecuteReader() returns rows from a SELECT query.

ExecuteNonQuery() executes INSERT, UPDATE, or DELETE commands and returns the number of affected rows.

---

## 4. What is SqlDataReader?

A forward-only, read-only object used in connected architecture to read data.

---

## 5. What is SqlDataAdapter?

A bridge between the database and memory that supports disconnected architecture.

---

## 6. What is a DataTable?

An in-memory table used to store and manipulate data after it is retrieved.

---

## 7. What is SQL Injection?

A security attack where malicious SQL code is inserted into user input to manipulate database queries.

---

## 8. How do parameterized queries prevent SQL Injection?

They separate SQL commands from user input, preventing malicious input from being executed as SQL.

---

## 9. What is a connection string?

A string containing the information required to connect to a database.

---

## 10. What is the purpose of the using statement?

It automatically disposes of database objects and closes connections.

---

## 11. Difference between Connected and Disconnected Architecture?

Connected architecture maintains an active database connection, whereas disconnected architecture loads data into memory and closes the connection.

---

## 12. Why should ExecuteNonQuery() be used for INSERT?

Because it returns the number of rows affected and is designed for commands that do not return result sets.

---

## 13. What does AddWithValue() do?

It adds a parameter and its value to a SQL command.

---

## 14. What happens if you don't close a SqlConnection?

The connection remains open, consuming database resources and potentially exhausting the connection pool.

---

## 15. What is CRUD?

Create, Read, Update, and Delete—the four fundamental database operations.

---

# Summary

In this assignment, you built a complete **Employee Management System** using **ADO.NET**. You learned how to connect a C# application to SQL Server, execute SQL statements securely using parameterized queries, and perform all CRUD operations. You also explored both connected (`SqlDataReader`) and disconnected (`SqlDataAdapter`) architectures, practiced proper exception handling, and followed secure coding practices such as using `using` blocks and preventing SQL injection. These concepts form the foundation of database programming in .NET and are frequently tested in technical interviews for .NET developer roles.