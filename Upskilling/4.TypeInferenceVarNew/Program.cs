using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Display()
    {
        Console.WriteLine($"Name :{Name}");
        Console.WriteLine($"Age :{Age}");
    }
}

class Program
{
    static void Main()
    {
        //var with primitive types
        var number = 100;
        var message = "Welcome to C#";
        var price = 999.99;
        Console.WriteLine("Using var");
        Console.WriteLine($"Value :{number}, Type : {number.GetType()}");
        Console.WriteLine($"Value :{message}, Type : {message.GetType()}");
        Console.WriteLine($"Value :{price}, Type : {price.GetType()}");
        Console.WriteLine("\n--------------------------------\n");

        //var with custom class
        var student1=new Student("Alice",21);
        Console.WriteLine("Student created using var:");
        student1.Display();
        Console.WriteLine("\n--------------------------------\n");

        //Target-typed new()
        var student2 = new Student("Bob", 22);
        Console.WriteLine("Student created using target-typed new:");
        student2.Display();
        Console.WriteLine("\n--------------------------------\n");

        //Anonymous type
        var employee=new
        {
            Id=101,
            Name="David",
            Department="IT"
        };
        Console.WriteLine("Anonymous type:");
        Console.WriteLine($"Id :{employee.Id}");
        Console.WriteLine($"Name :{employee.Name}");
        Console.WriteLine($"Department :{employee.Department}");
    }
}