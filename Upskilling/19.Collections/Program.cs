using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating List and Dictionary
        List<string> fruits = new List<string>();
        Dictionary<int, string> students = new Dictionary<int, string>();

        Console.WriteLine("===== Working with List<T> =====");

        Console.Write("How many fruits do you want to add? ");
        int fruitCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < fruitCount; i++)
        {
            Console.Write($"Enter Fruit {i + 1}: ");
            fruits.Add(Console.ReadLine());
        }

        Console.WriteLine("\nList of Fruits:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.Write("\nEnter a fruit to remove: ");
        string removeFruit = Console.ReadLine();

        if (fruits.Remove(removeFruit))
            Console.WriteLine($"{removeFruit} removed successfully.");
        else
            Console.WriteLine($"{removeFruit} not found.");

        Console.WriteLine("\nUpdated Fruit List:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine("\n========================================");

        Console.WriteLine("\n===== Working with Dictionary<int, string> =====");

        Console.Write("How many students do you want to add? ");
        int studentCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"\nEnter Student ID {i + 1}: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            students[id] = name;
        }

        Console.WriteLine("\nStudent Records:");

        foreach (KeyValuePair<int, string> student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }

        Console.Write("\nEnter Student ID to remove: ");
        int removeId = Convert.ToInt32(Console.ReadLine());

        if (students.Remove(removeId))
            Console.WriteLine("Student removed successfully.");
        else
            Console.WriteLine("Student ID not found.");

        Console.WriteLine("\nUpdated Student Records:");

        foreach (KeyValuePair<int, string> student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
    }
}