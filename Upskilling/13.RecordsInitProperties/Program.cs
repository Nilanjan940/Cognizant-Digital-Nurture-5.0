using System;
//Immutable record type with init-only properties
public record Employee
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Department { get; init; }
    public double Salary { get; init; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Records and init Properties=====\n");
        //Taking user input for employee details
        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Employee Department: ");
        string department = Console.ReadLine();
        Console.Write("Enter Employee Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        //Create original record
        Employee employee1 = new Employee { Id = id, Name = name, Department = department, Salary = salary };
        Console.WriteLine("\nOriginal Employee Record:");
        Console.WriteLine("-------------------------");
        DisplayEmployee(employee1);
        //Create a new record by copying and modifying the original record
        Console.Write("\nEnter New Salary for Modification: ");
        double newSalary = Convert.ToDouble(Console.ReadLine());
        Employee employee2 = employee1 with { Salary = newSalary };
        Console.WriteLine("\nModified Employee Record:");
        Console.WriteLine("-------------------------");
        DisplayEmployee(employee2);
        Console.WriteLine("\nOriginal Employee After Modification");
        Console.WriteLine("-------------------------");
        DisplayEmployee(employee1);
        Console.WriteLine("\nVerification");
        Console.WriteLine("Original Record Remains Unchanged");
    }

    static void DisplayEmployee(Employee employee)
    {
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("-----------------");
        Console.WriteLine($"ID: {employee.Id}");
        Console.WriteLine($"Name: {employee.Name}");
        Console.WriteLine($"Department: {employee.Department}");
        Console.WriteLine($"Salary: Rs. {employee.Salary}");
    }
}