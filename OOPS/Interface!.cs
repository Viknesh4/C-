using System;

namespace AnimalInterface
{
    
    public interface IAnimal
    {
        public void sound(); 
        public void eat();   
    }

    
    public class Dog : IAnimal
    {
        
        public void sound()
        {
            Console.WriteLine("Wrrr Wrrrr");
        }

        
        public void eat()
        {
            Console.WriteLine("Eats Meat");
        }
    }

    
    public class Cat : IAnimal
    {
        
        public void sound()
        {
            Console.WriteLine("Meow Meow");
        }

        
        public void eat()
        {
            Console.WriteLine("Eats Fish");
        }
    }

    



}
