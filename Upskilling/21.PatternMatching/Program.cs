using System;

class Program
{
    static void DisplayInformation(object obj)
    {
        // Pattern Matching using 'is'
        if (obj is int number)
        {
            Console.WriteLine($"\nThe object is an Integer.");
            Console.WriteLine($"Square = {number * number}");
        }
        else if (obj is double decimalNumber)
        {
            Console.WriteLine($"\nThe object is a Double.");
            Console.WriteLine($"Half = {decimalNumber / 2}");
        }
        else if (obj is string text)
        {
            Console.WriteLine($"\nThe object is a String.");
            Console.WriteLine($"Length = {text.Length}");
        }
        else
        {
            Console.WriteLine("\nUnknown object type.");
        }

        Console.WriteLine("\nUsing Switch Pattern Matching:");

        switch (obj)
        {
            case int n:
                Console.WriteLine($"Integer Value : {n}");
                break;

            case double d:
                Console.WriteLine($"Double Value : {d}");
                break;

            case string s:
                Console.WriteLine($"String Value : {s}");
                break;

            default:
                Console.WriteLine("Unsupported Type");
                break;
        }
    }

    static void Main()
    {
        Console.WriteLine("===== Pattern Matching using is and switch =====");

        Console.WriteLine("\nChoose Data Type");
        Console.WriteLine("1. Integer");
        Console.WriteLine("2. Double");
        Console.WriteLine("3. String");

        Console.Write("\nEnter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        object value;

        switch (choice)
        {
            case 1:
                Console.Write("Enter an Integer: ");
                value = Convert.ToInt32(Console.ReadLine());
                break;

            case 2:
                Console.Write("Enter a Double: ");
                value = Convert.ToDouble(Console.ReadLine());
                break;

            case 3:
                Console.Write("Enter a String: ");
                value = Console.ReadLine();
                break;

            default:
                value = true;
                break;
        }

        DisplayInformation(value);
    }
}