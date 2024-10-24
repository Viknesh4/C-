using System;

namespace AnimalInterface
{
    public interface IShape
    {
        void Draw(); 
        void Description()
        {
            Console.WriteLine("This is a shape.");
        }
    }

    
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }

        
        public void Description()
        {
            Console.WriteLine("This is a Circle.");
        }
    }

    
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }   
        public void Description()
        {
            Console.WriteLine("This is a Rectangle.");
        }
    }

    
}
