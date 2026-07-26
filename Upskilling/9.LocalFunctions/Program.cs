using System;
class Program
{
    //Method that uses a local function
    static long CalculateFactorial(int number)
    {
        //Input validation
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return -1; // Return -1 to indicate an error
        }

        //Local function to calculate factorial
        long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        // Call the local function and return the result
        return Factorial(number);
    }

    static void Main()
    {
        Console.WriteLine("=====Factorial Calculator=====");
        Console.Write("Enter a non-negative integer: ");
        int input = Convert.ToInt32(Console.ReadLine());

        long result = CalculateFactorial(input);
        if (result != -1) // Check for error
        {
            Console.WriteLine($"Factorial of {input} is: {result}");
        }
    }
}