using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalAmount { get; set; }
}

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>();

        Console.WriteLine("===== LINQ Filtering and Projection =====");

        Console.Write("Enter number of orders: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter Details for Order {i + 1}");

            Console.Write("Order ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Total Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            orders.Add(new Order
            {
                OrderId = id,
                CustomerName = name,
                TotalAmount = amount
            });
        }

        Console.Write("\nEnter minimum order amount for filtering: ");
        double minimumAmount = Convert.ToDouble(Console.ReadLine());

        // LINQ Filtering and Projection
        var filteredOrders = orders
            .Where(order => order.TotalAmount >= minimumAmount)
            .Select(order => new
            {
                order.OrderId,
                order.CustomerName,
                order.TotalAmount
            });

        Console.WriteLine("\nFiltered Orders\n");

        foreach (var order in filteredOrders)
        {
            Console.WriteLine($"Order ID      : {order.OrderId}");
            Console.WriteLine($"Customer Name : {order.CustomerName}");
            Console.WriteLine($"Amount        : {order.TotalAmount}");
            Console.WriteLine("----------------------------");
        }
    }
}