using System;

/// <summary>
/// Product Interface
/// All notification types must implement this.
/// </summary>
interface INotification
{
    void SendNotification(string message);
}

/// <summary>
/// Concrete Product - Email Notification
/// </summary>
class EmailNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Email Sent: {message}");
    }
}

/// <summary>
/// Concrete Product - SMS Notification
/// </summary>
class SMSNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"SMS Sent: {message}");
    }
}

/// <summary>
/// Concrete Product - Push Notification
/// </summary>
class PushNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Push Notification Sent: {message}");
    }
}

/// <summary>
/// Factory Class
/// Responsible for creating notification objects.
/// </summary>
class NotificationFactory
{
    public static INotification CreateNotification(int choice)
    {
        switch (choice)
        {
            case 1:
                return new EmailNotification();

            case 2:
                return new SMSNotification();

            case 3:
                return new PushNotification();

            default:
                return null;
        }
    }
}

class FactoryMethodPattern
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Notification System =====");
            Console.WriteLine("1. Send Email");
            Console.WriteLine("2. Send SMS");
            Console.WriteLine("3. Send Push Notification");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            if (choice >= 1 && choice <= 3)
            {
                Console.Write("Enter notification message: ");
                string message = Console.ReadLine();

                INotification notification =
                    NotificationFactory.CreateNotification(choice);

                notification.SendNotification(message);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Exiting Notification System...");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

        } while (choice != 4);
    }
}