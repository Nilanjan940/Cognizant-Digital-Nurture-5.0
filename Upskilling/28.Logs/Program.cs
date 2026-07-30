using System;
using System.Diagnostics;
using System.IO;

// Logger class responsible for writing log messages
class Logger
{
    // Method to configure Trace listeners
    public static void ConfigureLogger()
    {
        // Remove any existing listeners
        Trace.Listeners.Clear();

        // Add a listener to write logs to the console
        Trace.Listeners.Add(new ConsoleTraceListener());

        // Add a listener to write logs to a file
        Trace.Listeners.Add(new TextWriterTraceListener("ApplicationLog.txt"));

        // Automatically flush the buffer after every write
        Trace.AutoFlush = true;
    }

    // Method to write a log message
    public static void Log(string message)
    {
        Trace.WriteLine($"[{DateTime.Now}] {message}");
    }

    // Method to close all Trace listeners
    public static void CloseLogger()
    {
        Trace.Flush();
        Trace.Close();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== System.Diagnostics.Trace Demonstration =====\n");

        // Configure logging
        Logger.ConfigureLogger();

        Logger.Log("Application Started.");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Logger.Log($"User entered name: {name}");

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Logger.Log($"User entered age: {age}");

        // Example condition
        if (age >= 18)
        {
            Console.WriteLine("\nYou are eligible to vote.");

            Logger.Log("Eligibility Check: User is eligible to vote.");
        }
        else
        {
            Console.WriteLine("\nYou are not eligible to vote.");

            Logger.Log("Eligibility Check: User is NOT eligible to vote.");
        }

        // Simulate an exception
        try
        {
            Console.Write("\nEnter a number to divide 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 100 / number;

            Console.WriteLine($"Result = {result}");

            Logger.Log($"Division Result = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred.");

            Logger.Log($"Exception: {ex.Message}");
        }

        Logger.Log("Application Finished Successfully.");

        // Close Trace listeners
        Logger.CloseLogger();

        Console.WriteLine("\nLogs have been saved to ApplicationLog.txt");
    }
}