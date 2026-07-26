using System;

//Base class
class Shape
{
    //Virtual method
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a Shape.");
    }
}

//Derived Class 1
class Circle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

//Derived Class 2
class Rectangle:Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }
} 

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Inheritance and Method Overriding=====\n");
        Shape shape;
        Console.WriteLine("Choose a shape to draw:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Draw Both");
        Console.WriteLine("\nEnter your choice: ");
        int choice=Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                shape=new Circle();
                shape.Draw();
                break;
            case 2:
                shape=new Rectangle();
                shape.Draw();
                break;
            case 3:
                Shape[] shapes =
                {
                    new Circle(),
                    new Rectangle()
                };
                Console.WriteLine();
                foreach (Shape s in shapes)
                {
                    s.Draw();
                }
                break;
            default:
                Console.WriteLine("Invalid Choice.");
                break;
        }
    }
}