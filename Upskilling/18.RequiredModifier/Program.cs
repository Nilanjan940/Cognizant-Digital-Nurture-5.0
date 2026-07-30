using System;

class Student
{
    // Required properties
    public required int StudentId { get; set; }

    public required string Name { get; set; }

    public required string Department { get; set; }

    // Optional property
    public int Age { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine("\n===== Student Details =====");
        Console.WriteLine($"Student ID : {StudentId}");
        Console.WriteLine($"Name       : {Name}");
        Console.WriteLine($"Department : {Department}");
        Console.WriteLine($"Age        : {Age}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== C# 12 Required Modifier Demo =====\n");

        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Department: ");
        string department = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Student student = new Student
        {
            StudentId = id,
            Name = name,
            Department = department,
            Age = age
        };

        student.DisplayDetails();

        Console.WriteLine("\nRequired properties were successfully initialized.");

        /*
        Uncomment the following code to observe the compiler error.

        Student s = new Student
        {
            StudentId = 101,
            Age = 20
        };

        Error:
        Required member 'Student.Name' must be set.
        Required member 'Student.Department' must be set.
        */
    }
}