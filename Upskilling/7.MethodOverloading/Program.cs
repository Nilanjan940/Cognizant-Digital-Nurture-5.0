using System;

class Calculator
{
    //Method 1: Two integers
    public int CalculateTotal(int num1,int num2)
    {
        return num1 + num2;
    }
    //Method 2: Three doubles
    public double CalculateTotal(double num1,double num2,double num3)
    {
        return num1 + num2 + num3;
    }
    //Method 3: Three integers
    public int CalculateTotal(int num1,int num2,int num3)
    {
        return num1 + num2 + num3;
    }
    //Method 4: Two doubles
    public double CalculateTotal(double num1,double num2)
    {
        return num1 + num2;
    }
}
class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        //Using method 1
        int total1 = calculator.CalculateTotal(10, 20);
        Console.WriteLine("Total of two integers: " + total1);

        //Using method 2
        double total2 = calculator.CalculateTotal(10.5, 20.5, 30.5);
        Console.WriteLine("Total of three doubles: " + total2);

        //Using method 3
        int total3 = calculator.CalculateTotal(5, 15, 25);
        Console.WriteLine("Total of three integers: " + total3);

        //Using method 4
        double total4 = calculator.CalculateTotal(12.5, 7.5);
        Console.WriteLine("Total of two doubles: " + total4);

    }
}