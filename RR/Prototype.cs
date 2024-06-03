using System;

public abstract class Shape
{
    public abstract Shape Clone();
}

public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    public override Shape Clone()
    {
        return new Circle(Radius);
    }

    public override string ToString()
    {
        return $"Circle with radius {Radius}";
    }
}

public class PrototypeEx
{
    public static void Run()
    {
        Circle original = new Circle(10);
        Circle clone = (Circle)original.Clone();
        Console.WriteLine(original); 
        Console.WriteLine(clone);    
    }
}