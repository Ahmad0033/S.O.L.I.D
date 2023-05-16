using UnityEngine;
// Shape will be abstract class
// You can create as many shapes you want with this without changing code
// Means: Extension is possible without modifcation in current code

public abstract class Shape
{
    public abstract double Area();
}


// Lets Create Different Shapes Now
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Mathf.PI * Radius * Radius;
    }
}

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return (Base * Height) / 2;
    }
}

