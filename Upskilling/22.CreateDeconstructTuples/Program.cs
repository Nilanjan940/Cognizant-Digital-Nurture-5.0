using System;

class Program
{
    // Method returning a tuple
    static (int, string) GetStudentDetails()
    {
        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        return (id, name);
    }

    static void Main()
    {
        Console.WriteLine("===== Tuple Demonstration =====\n");

        // Tuple Deconstruction
        (int studentId, string studentName) = GetStudentDetails();

        Console.WriteLine("\n===== Student Details =====");
        Console.WriteLine($"Student ID   : {studentId}");
        Console.WriteLine($"Student Name : {studentName}");
    }
}