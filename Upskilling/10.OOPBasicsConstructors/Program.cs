using System;
class Car
{
    //Properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    //Default Constructor
    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }
    //Parameterized Constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    //Method to display car details
    public void DisplayDetails()
    {
        Console.WriteLine($"Car Make: {Make}, Model: {Model}, Year: {Year}");
    }   
}
class Program
{
    static void Main()
    {
        //Using default constructor
        Car car1 = new Car();
        car1.DisplayDetails();

        //Using parameterized constructor
        Car car2 = new Car("Toyota", "Camry", 2020);
        car2.DisplayDetails();
    }
}