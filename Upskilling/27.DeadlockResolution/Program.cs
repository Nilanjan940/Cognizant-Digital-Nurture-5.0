using System;
using System.Threading;

class Program
{
    // Two shared lock objects
    static readonly object lock1 = new object();
    static readonly object lock2 = new object();

    // Thread 1 method
    static void Thread1Work()
    {
        Console.WriteLine("Thread 1: Trying to acquire Lock 1...");

        lock (lock1)
        {
            Console.WriteLine("Thread 1: Lock 1 acquired.");

            // Delay so Thread 2 can acquire Lock 2
            Thread.Sleep(1000);

            Console.WriteLine("Thread 1: Trying to acquire Lock 2...");

            // TryEnter prevents waiting forever
            if (Monitor.TryEnter(lock2, 2000))
            {
                try
                {
                    Console.WriteLine("Thread 1: Lock 2 acquired.");
                    Console.WriteLine("Thread 1: Performing work...");
                }
                finally
                {
                    Monitor.Exit(lock2);
                    Console.WriteLine("Thread 1: Released Lock 2.");
                }
            }
            else
            {
                Console.WriteLine("Thread 1: Could not acquire Lock 2.");
                Console.WriteLine("Thread 1: Deadlock avoided.");
            }
        }

        Console.WriteLine("Thread 1: Released Lock 1.");
    }

    // Thread 2 method
    static void Thread2Work()
    {
        Console.WriteLine("Thread 2: Trying to acquire Lock 2...");

        lock (lock2)
        {
            Console.WriteLine("Thread 2: Lock 2 acquired.");

            // Delay so Thread 1 attempts Lock 2
            Thread.Sleep(1000);

            Console.WriteLine("Thread 2: Trying to acquire Lock 1...");

            if (Monitor.TryEnter(lock1, 2000))
            {
                try
                {
                    Console.WriteLine("Thread 2: Lock 1 acquired.");
                    Console.WriteLine("Thread 2: Performing work...");
                }
                finally
                {
                    Monitor.Exit(lock1);
                    Console.WriteLine("Thread 2: Released Lock 1.");
                }
            }
            else
            {
                Console.WriteLine("Thread 2: Could not acquire Lock 1.");
                Console.WriteLine("Thread 2: Deadlock avoided.");
            }
        }

        Console.WriteLine("Thread 2: Released Lock 2.");
    }

    static void Main()
    {
        Console.WriteLine("===== Deadlock Simulation and Resolution =====\n");

        // Create two threads
        Thread thread1 = new Thread(Thread1Work);
        Thread thread2 = new Thread(Thread2Work);

        // Start threads
        thread1.Start();
        thread2.Start();

        // Wait for both threads to complete
        thread1.Join();
        thread2.Join();

        Console.WriteLine("\nProgram completed successfully.");
        Console.WriteLine("Deadlock was prevented using Monitor.TryEnter().");
    }
}