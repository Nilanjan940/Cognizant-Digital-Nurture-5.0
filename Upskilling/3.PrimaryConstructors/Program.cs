using System;

class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public void DisplayInfo()
    {
        Console.WriteLine("Person Information");
        Console.WriteLine("------------------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Nilanjan", 21);
        person.DisplayInfo();
        Console.WriteLine("\nUsing Auto Properties:");
        Console.WriteLine($"Person Name: {person.Name}");
        Console.WriteLine($"Person Age: {person.Age}");
    }
}
