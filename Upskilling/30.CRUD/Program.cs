using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    // SQL Server Connection String
    static string connectionString =
        @"Data Source=localhost\SQLEXPRESS;
          Initial Catalog=EmployeeDB;
          Integrated Security=True;
          Pooling=False;
          Connect Timeout=30;
          Encrypt=False;
          Trust Server Certificate=True;
          Application Name=vscode-mssql;
          Application Intent=ReadWrite;
          Command Timeout=30;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n======================================");
            Console.WriteLine("   EMPLOYEE MANAGEMENT SYSTEM");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Insert Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Update Employee Salary");
            Console.WriteLine("4. Delete Employee");
            Console.WriteLine("5. View Employees (Using DataAdapter)");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid Input!");
                continue;
            }

            switch (choice)
            {
                case 1:
                    InsertEmployee();
                    break;

                case 2:
                    ViewEmployees();
                    break;

                case 3:
                    UpdateEmployee();
                    break;

                case 4:
                    DeleteEmployee();
                    break;

                case 5:
                    ViewEmployeesUsingDataAdapter();
                    break;

                case 6:
                    Console.WriteLine("\nThank You!");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }

    // INSERT OPERATION
    static void InsertEmployee()
    {
        Console.Write("\nEnter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Department: ");
        string department = Console.ReadLine();

        Console.Write("Enter Salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        string query =
            "INSERT INTO Employees(EmployeeName, Department, Salary) VALUES(@Name,@Department,@Salary)";

        using SqlConnection connection = new SqlConnection(connectionString);
        using SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@Name", name);
        command.Parameters.AddWithValue("@Department", department);
        command.Parameters.AddWithValue("@Salary", salary);

        try
        {
            connection.Open();

            int rows = command.ExecuteNonQuery();

            Console.WriteLine($"\n{rows} Employee Inserted Successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // READ OPERATION USING SqlDataReader
    static void ViewEmployees()
    {
        string query = "SELECT * FROM Employees";

        using SqlConnection connection = new SqlConnection(connectionString);
        using SqlCommand command = new SqlCommand(query, connection);

        try
        {
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("\n============= EMPLOYEE LIST =============");

            while (reader.Read())
            {
                Console.WriteLine($"Employee ID : {reader["EmployeeId"]}");
                Console.WriteLine($"Name        : {reader["EmployeeName"]}");
                Console.WriteLine($"Department  : {reader["Department"]}");
                Console.WriteLine($"Salary      : {reader["Salary"]}");
                Console.WriteLine("----------------------------------------");
            }

            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // UPDATE OPERATION
    static void UpdateEmployee()
    {
        Console.Write("\nEnter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter New Salary: ");
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        string query =
            "UPDATE Employees SET Salary=@Salary WHERE EmployeeId=@Id";

        using SqlConnection connection = new SqlConnection(connectionString);
        using SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@Salary", salary);
        command.Parameters.AddWithValue("@Id", id);

        try
        {
            connection.Open();

            int rows = command.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("\nEmployee Updated Successfully.");
            else
                Console.WriteLine("\nEmployee Not Found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // DELETE OPERATION
    static void DeleteEmployee()
    {
        Console.Write("\nEnter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        string query =
            "DELETE FROM Employees WHERE EmployeeId=@Id";

        using SqlConnection connection = new SqlConnection(connectionString);
        using SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@Id", id);

        try
        {
            connection.Open();

            int rows = command.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("\nEmployee Deleted Successfully.");
            else
                Console.WriteLine("\nEmployee Not Found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // READ OPERATION USING DataAdapter (Disconnected Architecture)
    static void ViewEmployeesUsingDataAdapter()
    {
        string query = "SELECT * FROM Employees";

        using SqlConnection connection = new SqlConnection(connectionString);

        try
        {
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            Console.WriteLine("\n========= EMPLOYEE LIST (DataAdapter) =========");

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"Employee ID : {row["EmployeeId"]}");
                Console.WriteLine($"Name        : {row["EmployeeName"]}");
                Console.WriteLine($"Department  : {row["Department"]}");
                Console.WriteLine($"Salary      : {row["Salary"]}");
                Console.WriteLine("-----------------------------------------------");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}