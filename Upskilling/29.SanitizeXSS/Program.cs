using System;
using System.Net;

// Class responsible for sanitizing user input
class InputSanitizer
{
    // Method to sanitize input using HTML Encoding
    public static string Sanitize(string input)
    {
        // Convert special HTML characters into safe encoded characters
        return WebUtility.HtmlEncode(input);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Input Sanitization and XSS Prevention =====\n");

        // Ask the user to enter some text
        Console.Write("Enter your message: ");
        string userInput = Console.ReadLine();

        // Display the original input
        Console.WriteLine("\nOriginal Input:");
        Console.WriteLine(userInput);

        // Sanitize the input
        string safeInput = InputSanitizer.Sanitize(userInput);

        // Display the encoded (safe) output
        Console.WriteLine("\nSanitized Output:");
        Console.WriteLine(safeInput);

        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("Explanation:");
        Console.WriteLine("Original input may contain HTML or JavaScript code.");
        Console.WriteLine("Sanitized output converts special characters into");
        Console.WriteLine("HTML entities so that browsers display the text");
        Console.WriteLine("instead of executing it.");

        Console.WriteLine("\nExample Malicious Input:");
        Console.WriteLine("<script>alert('Hacked!');</script>");

        Console.WriteLine("\nEncoded Version:");
        Console.WriteLine(
            InputSanitizer.Sanitize("<script>alert('Hacked!');</script>")
        );

        Console.WriteLine("\nApplication Finished Successfully.");
    }
}