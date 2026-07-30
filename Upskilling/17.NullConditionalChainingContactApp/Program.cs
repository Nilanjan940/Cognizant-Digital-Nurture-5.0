using System;

class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Contact Application using Null-Conditional Chaining =====\n");

        Console.Write("Do you want to create a contact? (yes/no): ");
        string? choice = Console.ReadLine()?.Trim().ToLower();

        Contact? contact = null;

        if (choice == "yes")
        {
            contact = new Contact();

            Console.Write("Enter Contact Name (leave blank if none): ");
            string? name = Console.ReadLine();

            Console.Write("Enter Phone Number (leave blank if none): ");
            string? phone = Console.ReadLine();

            contact.Name = string.IsNullOrWhiteSpace(name) ? null : name;
            contact.PhoneNumber = string.IsNullOrWhiteSpace(phone) ? null : phone;
        }

        Console.WriteLine("\n===== Contact Details =====");

        // Null-conditional chaining
        Console.WriteLine($"Name         : {contact?.Name ?? "No Name Available"}");
        Console.WriteLine($"Phone Number : {contact?.PhoneNumber ?? "No Phone Number Available"}");

        Console.WriteLine();

        if (contact?.Name != null)
        {
            Console.WriteLine($"Welcome, {contact.Name}!");
        }
        else
        {
            Console.WriteLine("Contact name is unavailable.");
        }
    }
}