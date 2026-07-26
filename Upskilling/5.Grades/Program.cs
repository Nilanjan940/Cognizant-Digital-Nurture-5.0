using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Grade Calculator=====");
        Console.Write("Enter your marks (0-100): ");
        if(!int.TryParse(Console.ReadLine(), out int marks) || marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            return;
        }

        //Grade using if-else

        string gradeIfElse;

        if(marks >= 90)
        {
            gradeIfElse = "A+";
        }
        else if(marks >= 80)
        {
            gradeIfElse = "A";
        }
        else if(marks >= 70)
        {
            gradeIfElse = "B";
        }
        else if(marks >= 60)
        {
            gradeIfElse = "C";
        }
        else if(marks >= 50)
        {
            gradeIfElse = "D";
        }
        else
        {
            gradeIfElse = "F";
        }
        Console.WriteLine("\nGrade using if-else: " + gradeIfElse);

        //Grade using switch expression with pattern matching
        string gradeSwitch = marks switch
        {
            >= 90 => "A+",
            >= 80 => "A",
            >= 70 => "B",
            >= 60 => "C",
            >= 50 => "D",
            _ => "F"
        };
        Console.WriteLine("Grade using switch pattern matching: " + gradeSwitch);
    }
}