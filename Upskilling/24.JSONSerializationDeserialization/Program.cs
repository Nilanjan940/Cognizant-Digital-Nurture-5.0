using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== JSON Serialization & Deserialization =====\n");

        // Accept user input
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        // Create User object
        User user = new User
        {
            Name = name,
            Age = age,
            Email = email
        };

        // File path
        string filePath = "user.json";

        // Serialize object to JSON
        string jsonString = JsonSerializer.Serialize(user,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        // Save JSON to file
        File.WriteAllText(filePath, jsonString);

        Console.WriteLine("\nData successfully written to user.json");

        // Read JSON from file
        string jsonFromFile = File.ReadAllText(filePath);

        // Deserialize JSON
        User deserializedUser =
            JsonSerializer.Deserialize<User>(jsonFromFile);

        Console.WriteLine("\n===== Deserialized User =====");

        Console.WriteLine($"Name  : {deserializedUser.Name}");
        Console.WriteLine($"Age   : {deserializedUser.Age}");
        Console.WriteLine($"Email : {deserializedUser.Email}");
    }
}