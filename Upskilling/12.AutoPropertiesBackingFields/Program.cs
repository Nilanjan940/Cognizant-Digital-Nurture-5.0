using System;
using System.Net.Http.Headers;
class Product
{
    //Auto-implemented property
    public string Name { get; set; }
    //Backing field
    private double _price;
    //Property with validation
    public double Price
    {
        get { return _price;}
        set
        {
            if(value>=0)
            {
                _price=value;
            }
            else
            {
                Console.WriteLine("Price cannot be negative. Setting price to 0.");
                _price=0;
            }
        }
    }

    //Constructor
    public Product(string name, double price)
    {
        Name=name;
        Price=price;
    }

    //Display Method
    public void DisplayProduct()
    {
        Console.WriteLine("\nProduct Details:");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Price: Rs. {Price}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Auto-Implemented Properties and Backing Fields=====");
        Console.Write("Enter product name: ");
        string productName=Console.ReadLine();
        Console.Write("Enter product price: ");
        double productPrice=Convert.ToDouble(Console.ReadLine());

        Product product=new Product(productName,productPrice);
        product.DisplayProduct();

        Console.WriteLine("\nUpdating Price...");
        Console.Write("Enter new product price: ");
        product.Price=Convert.ToDouble(Console.ReadLine());
        product.DisplayProduct();
    }
}