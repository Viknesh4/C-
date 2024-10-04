using System;
using System.Diagnostics.CodeAnalysis;

public class surface
{
    static int b;
    static int l;
    public surface()
    {
        Console.Write("Enter radius:");
        l = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter height:");
        b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Surface area of cyclinder:" + (3.14 * l * l * b));
    }
    public static void perimeter()
    {
        Console.WriteLine("Perimeter of the rectangle is :" + (2 * (l*b)));
    }
    static void main(string[] args)
    {
        new surface();
        perimeter();

    }

}