using System;

//Abstract Class
abstract class Vehicle
{
    public string Brand {get; set;}
    public Vehicle(string brand)
    {
        Brand=brand;
    }
    //Abstract Method
    public abstract void Drive();

    //Concrete Method
    public void DisplayBrand()
    {
        Console.WriteLine($"Brand:{Brand}");
    }
}

//Interface
interface IDrivable
{
    void Start();
}

//Derived Class
class Car: Vehicle,IDrivable
{
    public Car(string brand) : base(brand)
    {}
    //Implement Interface Method
    public void Start()
    {
        Console.WriteLine("Car Started.");
    }
    //Override Abstract Method
    public override void Drive()
    {
        Console.WriteLine("Car is being driven.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Abstract Class and Interface Demonstration =====\n");
        Console.Write("Enter Car Brand: ");
        string brand=Console.ReadLine();
        //Create object
        Car car=new Car(brand);
        Console.WriteLine("\nUsing Car Object");
        car.DisplayBrand();
        car.Start();
        car.Drive();

        Console.WriteLine("\n--------------------------");

        //Abstract Class Polymorphism
        Vehicle vehicle=car;

        Console.WriteLine("Using Vehicle Reference");
        vehicle.DisplayBrand();
        vehicle.Drive();

        Console.WriteLine("\n---------------------------");

        //Interface Polymorphism
        IDrivable drivable=car;
        Console.WriteLine("Using IDrivable Reference");
        drivable.Start();
    }
}