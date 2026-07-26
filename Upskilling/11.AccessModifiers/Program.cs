using System;

class Person
{
    //Public member
    public string Name = "Nilanjan";
    //Private member
    private int Age = 21;
    //Protected member
    protected string Address = "Kolkata";
    //Public method to access private member
    public void DisplayAge()
    {
        Console.WriteLine($"Age(Private): {Age}");
    }
    //Public method to access protected member
    public void DisplayAddress()
    {
        Console.WriteLine($"Address(Protected): {Address}");
    }
}

//Derived class
class Student : Person
{
    public void DisplayDetails()
    {
        Console.WriteLine("\nAccessing Members from Derived Class:");
        //Accessible
        Console.WriteLine($"Name(Public): {Name}");
        //Accessible
        Console.WriteLine($"Address(Protected): {Address}");
        //Not Accessible: Age is private in base class
        //Console.WriteLine($"Age(Private): {Age}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Access Modifiers Demonstration=====");
        Person person = new Person();
        Console.WriteLine("\nAccessing Members from Base Class:");
        //Accessible
        Console.WriteLine($"Name(Public): {person.Name}");
        //Accessible through public method
        person.DisplayAge();
        //Accessible through public method
        person.DisplayAddress();
        //Not Accessible: Age is private in base class
        //Console.WriteLine($"Age(Private): {person.Age}"); 
        //Not Accessible: Address is protected in base class
        //Console.WriteLine($"Address(Protected): {person.Address}");
        Student student = new Student();
        student.DisplayDetails();
    }
}