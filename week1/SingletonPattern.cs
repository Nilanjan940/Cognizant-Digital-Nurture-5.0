using System;
using System.Collections.Generic;

/// <summary>
/// Singleton Shopping Cart Class
/// </summary>
class ShoppingCart
{
    // Single instance of ShoppingCart
    private static readonly ShoppingCart instance = new ShoppingCart();

    // Stores cart items
    private List<string> items;

    // Private constructor prevents direct object creation
    private ShoppingCart()
    {
        items = new List<string>();
    }

    // Public method to get the single instance
    public static ShoppingCart GetInstance()
    {
        return instance;
    }

    // Add item to cart
    public void AddItem(string item)
    {
        items.Add(item);
        Console.WriteLine($"'{item}' added successfully.");
    }

    // Remove item from cart
    public void RemoveItem(string item)
    {
        if (items.Remove(item))
        {
            Console.WriteLine($"'{item}' removed successfully.");
        }
        else
        {
            Console.WriteLine($"'{item}' not found in cart.");
        }
    }

    // Display all items
    public void ShowItems()
    {
        Console.WriteLine("\n===== Shopping Cart =====");

        if (items.Count == 0)
        {
            Console.WriteLine("Cart is empty.");
            return;
        }

        foreach (string item in items)
        {
            Console.WriteLine("- " + item);
        }
    }
}

class SingletonPattern
{
    static void Main()
    {
        // Get Singleton instance
        ShoppingCart cart1 = ShoppingCart.GetInstance();

        // Get another reference to prove Singleton
        ShoppingCart cart2 = ShoppingCart.GetInstance();

        Console.WriteLine("Singleton Demonstration");
        Console.WriteLine("-----------------------");
        Console.WriteLine($"cart1 and cart2 refer to same object: " +
                          $"{Object.ReferenceEquals(cart1, cart2)}");

        int choice;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Show Items");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter item name: ");
                    string addItem = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(addItem))
                    {
                        cart1.AddItem(addItem);
                    }
                    else
                    {
                        Console.WriteLine("Item name cannot be empty.");
                    }
                    break;

                case 2:
                    Console.Write("Enter item to remove: ");
                    string removeItem = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(removeItem))
                    {
                        cart2.RemoveItem(removeItem);
                    }
                    else
                    {
                        Console.WriteLine("Item name cannot be empty.");
                    }
                    break;

                case 3:
                    cart1.ShowItems();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using Shopping Cart.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }
}