using System;

class Person
{
    //Nullable reference types
    public string?Name{get; set;}
    public string?City{get; set;}
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Handle Null References Safely=====");
        Console.Write("Do you want to create a Person object? (yes/no): ");
        string choice=Console.ReadLine()!.Trim().ToLower();
        Person?person=null;
        if(choice=="yes")
        {
            person=new Person();

            Console.Write("Enter Name (leave blank if none): ");
            string?name=Console.ReadLine();

            Console.Write("Enter City (leave blank if none): ");
            string?city=Console.ReadLine();

            //Store null if input is empty
            person.Name=string.IsNullOrWhiteSpace(name)?null:name;
            person.City=string.IsNullOrWhiteSpace(city)?null:city;
        }

        Console.WriteLine("\n-------------Output-----");

        //Null-conditional operator
        Console.WriteLine($"Name : {person?.Name}");

        //Null-coalescing operator
        Console.WriteLine($"City : {person?.City??"Not Available"}");

        //Safe null checking
        if(person is not null)
        {
            Console.WriteLine("\nPerson object exists.");
            if(person.Name is not null)
                Console.WriteLine("Name has a value.");
            else
                Console.WriteLine("Name is null.");
        }
        else
        {
            Console.WriteLine("Person object is null.");
        }
    }
}