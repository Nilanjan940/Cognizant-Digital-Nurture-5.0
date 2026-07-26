using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array:");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] numbers=new int[n];
        Console.WriteLine("\nEnter the array elements:");
        for(int i=0;i<n;i++)
        {
            Console.Write($"Element {i+1}: ");
            numbers[i]=Convert.ToInt32(Console.ReadLine());
        }

        //FOR LOOP
        Console.WriteLine("\n=====FOR LOOP=====");
        for(int i=0;i<n;i++)
        {
            if(numbers[i]==30)
            {
                Console.WriteLine("Skipping 30...");
                continue;
            }
            if(numbers[i]==50)
            {
                Console.WriteLine("Stopping at 50...");
                break;
            }
            Console.WriteLine($"Element {i+1}: {numbers[i]}");
        }

        //FOREACH LOOP
        Console.WriteLine("\n=====FOREACH LOOP=====");
        foreach(int number in numbers)
        {
            if(number==20)
            {
                Console.WriteLine("Skipping 20...");
                continue;
            }
            if(number==60)
            {
                Console.WriteLine("Stopping at 60...");
                break;
            }
            Console.WriteLine($"Element: {number}");
        }

        //WHILE LOOP
        Console.WriteLine("\n=====WHILE LOOP=====");
        int index=0;
        while(index<n)
        {
            if(numbers[index]==10)
            {
                Console.WriteLine("Skipping 10...");
                index++;
                continue;
            }
            if(numbers[index]==40)
            {
                Console.WriteLine("Stopping at 40...");
                break;
            }
            Console.WriteLine($"Element {index+1}: {numbers[index]}");
            index++;
        }

        //DO-WHILE LOOP
        Console.WriteLine("\n=====DO-WHILE LOOP=====");
        index=0;
        do
        {
            if(numbers[index]==70)
            {
                Console.WriteLine("Skipping 70...");
                index++;
                continue;
            }
            if(numbers[index]==80)
            {
                Console.WriteLine("Stopping at 80...");
                break;
            }
            Console.WriteLine($"Element {index+1}: {numbers[index]}");
            index++;
        } while(index<n);
    }
}