using System;
using System.Threading;

class Program
{
    // Shared counter variable accessed by multiple threads
    static int counter = 0;

    // Lock object used for synchronization
    static readonly object lockObject = new object();

    // Number of times each thread increments the counter
    const int iterations = 100000;

    // Method without synchronization (causes race condition)
    static void IncrementWithoutLock()
    {
        for (int i = 0; i < iterations; i++)
        {
            counter++;
        }
    }

    // Method with synchronization using lock
    static void IncrementWithLock()
    {
        for (int i = 0; i < iterations; i++)
        {
            // Only one thread can execute this block at a time
            lock (lockObject)
            {
                counter++;
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("===== Race Condition Demonstration =====\n");

        // ---------------- WITHOUT LOCK ----------------
        Console.WriteLine("Running WITHOUT lock...");

        // Reset counter
        counter = 0;

        // Create two threads
        Thread thread1 = new Thread(IncrementWithoutLock);
        Thread thread2 = new Thread(IncrementWithoutLock);

        // Start both threads
        thread1.Start();
        thread2.Start();

        // Wait for both threads to complete
        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Expected Counter Value : {iterations * 2}");
        Console.WriteLine($"Actual Counter Value   : {counter}");

        Console.WriteLine("\nNotice that the value may be incorrect because multiple threads");
        Console.WriteLine("updated the shared variable simultaneously.\n");

        // ---------------- WITH LOCK ----------------
        Console.WriteLine("Running WITH lock...\n");

        // Reset counter
        counter = 0;

        // Create two new threads
        Thread thread3 = new Thread(IncrementWithLock);
        Thread thread4 = new Thread(IncrementWithLock);

        // Start both threads
        thread3.Start();
        thread4.Start();

        // Wait for both threads to finish
        thread3.Join();
        thread4.Join();

        Console.WriteLine($"Expected Counter Value : {iterations * 2}");
        Console.WriteLine($"Actual Counter Value   : {counter}");

        Console.WriteLine("\nThe counter is now correct because");
        Console.WriteLine("the lock statement synchronized access to the shared resource.");

        Console.WriteLine("\n===== Program Completed =====");
    }
}