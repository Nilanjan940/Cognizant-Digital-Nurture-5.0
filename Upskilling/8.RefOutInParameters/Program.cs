using System;

class ParameterDemo
{
    //Method using ref
    public static void Increment(ref int number)
    {
        number+=10;
        Console.WriteLine($"Inside Increment method (ref): {number}");
    }

    //Method using out
    public static void CalculateSquare(int number,out int square)
    {
        square=number*number;
        Console.WriteLine($"Inside CalculateSquare method (out): {square}");
    }

    //Method using in
    public static void DisplayValue(in int number)
    {
        Console.WriteLine($"Inside DisplayValue method (in): {number}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Demonstrating ref Parameter=====");
        Console.Write("Enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before Increment(ref): {num}");
        ParameterDemo.Increment(ref num);
        Console.WriteLine($"After Increment(ref): {num}");
        Console.WriteLine("\n================================\n");

        Console.WriteLine("=====Demonstrating out Parameter=====");
        Console.Write("Enter a number to calculate its square: ");
        int input=Convert.ToInt32(Console.ReadLine());
        int result;
        ParameterDemo.CalculateSquare(input,out result);
        Console.WriteLine($"After CalculateSquare(out): {result}");
        Console.WriteLine("\n================================\n");
        Console.WriteLine("=====Demonstrating in Parameter=====");
        Console.Write("Enter a number to display its value: ");
        int value=Convert.ToInt32(Console.ReadLine());
        ParameterDemo.DisplayValue(in value);
        Console.WriteLine("\n================================\n");
        Console.WriteLine("Summary:");
        Console.WriteLine("ref -> Pass by reference (must be initialized before passing)");
        Console.WriteLine("out -> Pass by reference (must be assigned in the method)");
        Console.WriteLine("in -> Pass by reference (read-only, cannot be modified in the method)");
    }
}