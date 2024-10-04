using System;
using System.Diagnostics.CodeAnalysis;

public class Rectangle
{

    public Rectangle()
    {
        Console.Write("Enter length:");
        int l = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter breadth:");
        int b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Area of rectangle:" + (l * b));
    }
    public static void perimeter(int x, int y)
    {
        Console.WriteLine("Perimeter of the rectangle is :"+(2*(x*y)));
    }
    static void main(string[] args)
    {
        Rectangle r = new Rectangle();
        perimeter(4, 5);

    }

}