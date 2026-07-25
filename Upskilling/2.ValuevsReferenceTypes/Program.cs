using System;

//Custom reference type
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    //Method modifying value type
    static void ModifyValueType(int number)
    {
        number=100;
        Console.WriteLine("\nInside ModifyValueType()");
        Console.WriteLine($"Number = {number}");
    }

    //Method modifying reference type
    static void ModifyReferenceType(Person person)
    {
        person.Name = "Alex";
        person.Age = 30;
        Console.WriteLine("\nInside ModifyReferenceType()");
        Console.WriteLine($"Name = {person.Name}");
        Console.WriteLine($"Age = {person.Age}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("VALUE TYPE EXAMPLE");

        int  number = 10;
        double salary = 50000.5;

        Console.WriteLine($"Before method call: number = {number}");
        ModifyValueType(number);
        Console.WriteLine($"After method call: number = {number}");

        Console.WriteLine("\n--------------------------------\n");
        Console.WriteLine("REFERENCE TYPE EXAMPLE");
        Person person = new Person { Name = "John", Age = 25 };
        Console.WriteLine($"Before method call: Name = {person.Name}, Age = {person.Age}");
        ModifyReferenceType(person);
        Console.WriteLine($"After method call: Name = {person.Name}, Age = {person.Age}");

        Console.WriteLine("\n--------------------------------\n");

        Console.WriteLine("STRING REFERENCE TYPE EXAMPLE");
        string name = "John";
        Console.WriteLine($"Before:{name}");
        ChangeString(name);
        Console.WriteLine($"After:{name}");

    }

    static void ChangeString(string text)
    {
        text = "Alex";
        Console.WriteLine($"Inside method: {text}");
    }
}