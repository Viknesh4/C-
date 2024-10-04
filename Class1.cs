using System;

public class Rectangle
{
    
    public Rectangle()
    {
        Console.Write("Enter length:");
        int l = int.Parse(Console.ReadLine());
        Console.Write("Enter breadth:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Area of rectangle:" + (l * b));
    }
   
    static void main(string[] args)
    {
        Rectangle r = new Rectangle();
        
    }
}
