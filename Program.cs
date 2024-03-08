using System;

// Define an interface for shapes
public interface IShape
{
    double Area(); // Abstract method to calculate the area of the shape
}

// Define a concrete class representing a circle
public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }
}

// Define a concrete class representing a rectangle
public class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Area()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Circle and Rectangle
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        // Calculate and display areas of shapes
        Console.WriteLine("Area of Circle: " + circle.Area());
        Console.WriteLine("Area of Rectangle: " + rectangle.Area());
    }
}
